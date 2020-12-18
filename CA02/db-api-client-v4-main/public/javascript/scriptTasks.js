// Parse JSON
// Create task rows
// Display in web page
function displayTasks(tasks, status) {
  // Use the Array map method to iterate through the array of tasks (in json format)
  // Each tasks will be formated as HTML table rowsand added to the array
  // see https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Array/map
  // Finally the output array is inserted as the content into the <tbody id="taskRows"> element.
  console.log("antes de dar pau");
  if (tasks != null) {
    const showUpdate = checkAuth(UPDATE_TASK);
    const showDelete = checkAuth(DELETE_TASK);
    const showStatusChange = checkAuth(CHANGE_STATUS_TASK);;

    const rows = tasks.map(task => {
      // returns a template string for each task, values are inserted using ${ }
      // <tr> is a table row and <td> a table division represents a column

      // check user permissions


      // Show add task button
      if (checkAuth(CREATE_TASK))
        $('#AddTaskButton').show();
      else
        $('#AddTaskButton').hide();

      // generate row
      let row = `<tr>
              <td>${task.TaskId}</td>
              <td>${task.TaskDescription}</td>
              <td>${task.TaskPriority}</td>`;

      // if user has permission to update - add the edit button
      if (showUpdate)
        row += `<td><button class="btn btn-xs" data-toggle="modal" 
                data-target="#TaskFormDialog" onclick="prepareTaskUpdate(${task.TaskId})">
                <span class="oi oi-pencil" data-toggle="tooltip" title="Edit Task"></span></button></td>`
      // if user has permission to delete - add the delete button          
      if (showDelete)
        row += `<td><button class="btn btn-xs" onclick="deleteTask(${task.TaskId},${status})">
                <span class="oi oi-trash" data-toggle="tooltip" title="Delete Task"></span></button></td>`

      if (showStatusChange) {
        row += `<td>`

        if (status != 1) {
          row += `<button class="buttonStatus amarelo" onclick="UpdateTaskStatus(${task.TaskId},${1},${status})">
        <span data-toggle="tooltip" title="Delete Task"></span>Waiting</button> `
        }

        if (status != 2) {
          row += `<button class="buttonStatus verde" onclick="UpdateTaskStatus(${task.TaskId},${2},${status})">
        <span  data-toggle="tooltip" title="Delete Task"></span>In Progress</button>`
        }

        if (status != 3) {
          row += `<button class="buttonStatus vermelho" onclick="UpdateTaskStatus(${task.TaskId},${3},${status})">
        <span  data-toggle="tooltip" title="Delete Task"></span>Closed</button>`
        }

        row += `</td>`
      }
      // finally, end the row and return
      row += '</tr>';
      return row;
    });
    console.log("antes de dar pau 0000002");

    var taskhead =
      `<tr>
    <th>Task ID</th>
    <th>Description</th>
    <th>Priority</th>`;
    if (showUpdate) {
      taskhead += `<th>Update</th>`;
    }
    if (showDelete) {
      taskhead += `<th>Delete</th>`;
    }
    if (showStatusChange) {
      taskhead += `<th>Move To Status</th>`;
    }
    taskhead += `</tr>`;

    document.getElementById('taskHead').innerHTML = taskhead;
    document.getElementById('taskRows').innerHTML = rows.join('');
    document.getElementById('noTasksDiv').innerHTML = ``;
    console.log("antes de dar pau 0000002.1");
  }
  else {

    var noTaskDif = `<div>No task has been created on this status - Yet!</div>`;

    console.log("antes de dar pau 000000003");
    document.getElementById('taskRows').innerHTML = ``;
    document.getElementById('taskHead').innerHTML = ``;
    document.getElementById('noTasksDiv').innerHTML = noTaskDif;
  }

} // end function


// load and display statuss in thhe left menu
function displayStatus(statuss) {
  //console.log(statuss);

  // Cat menu

  // use Array.map() to iterate through the list of statuss
  // Returns an HTML link for each status in the array
  const catLinks = statuss.map(status => {
    // The link has an onclick handler which will call updateTasksView(id) pasing the status id as a parameter
    var nameColor = "action";

    if (status.StatusId == 1) {
      nameColor = "warning active warningColor";
    }
    if (status.StatusId == 2) {
      nameColor = "success";
    }
    if (status.StatusId == 3) {
      nameColor = "danger";
    }

    return `<a href="#" class="list-group-item list-group-item-${nameColor}" onclick="updateTasksView(${status.StatusId})">${status.StatusName}</a>`;
  });

  // use  unshift to add a 'Show all' link at the start of the array of catLinks

  // Set the innerHTML of the taskRows element = the links contained in catlinks
  // .join('') converts an array to a string, replacing the , seperator with blank.
  document.getElementById('statusList').innerHTML = catLinks.join('');

  $(".list-group .list-group-item-warning").click(function (e) {
    $(".list-group .list-group-item").removeClass("active");
    $(".list-group .list-group-item").removeClass("warningColor");
    $(e.target).addClass("active");
    $(e.target).addClass("warningColor");
  });
  $(".list-group .list-group-item-success").click(function (e) {
    $(".list-group .list-group-item").removeClass("active");
    $(".list-group .list-group-item").removeClass("successColor");
    $(e.target).addClass("active");
    $(e.target).addClass("successColor");

  });
  $(".list-group .list-group-item-danger").click(function (e) {
    $(".list-group .list-group-item").removeClass("active");
    $(".list-group .list-group-item").removeClass("dangerColor");
    $(e.target).addClass("active");
    $(e.target).addClass("dangerColor");

  });

  // *** Fill select list in task form ***
  // first get the select input by its id
  let catSelect = document.getElementById("StatusId");

  // clear options
  while (catSelect.firstChild)
    catSelect.removeChild(catSelect.firstChild);

} // end function


// Load Tasks
// Get all statuss and tasks then display
async function loadTasks(status) {
  try {
    console.log("loadTasks");
    console.log("STATUS:");
    console.log(status);
    // Get a list of statuss via the getDataAsync(url) function
    const statuss = await getDataAsync(`${BASE_URL}/status`);
    // Call displaystatus(), passing the retrieved statuss list
    if (statuss != null)
      displayStatus(statuss);

    // Get a list of tasks
    const tasks = await getDataAsync(`${BASE_URL}/task/bystatus/${status}`);
    // Call displayTasks(), passing the retrieved tasks list
    console.log("vai chamar 02");
    console.log(tasks);
    console.log(status);
    displayTasks(tasks, status);

  } // catch and log any errors
  catch (err) {
    console.log(err);
  }
}

// update tasks list when status is selected to show only tasks from that status
async function updateTasksView(id) {
  try {
    console.log("Andre Sanches updateTasksView");
    // call the API enpoint which retrieves tasks by status (id)
    const tasks = await getDataAsync(`${BASE_URL}/task/bystatus/${id}`);
    // Display the list of tasks returned by the API
    console.log("vai chamar 01 ppp + ");
    console.log(tasks);
    console.log(status);
    displayTasks(tasks, id);

  } // catch and log any errors
  catch (err) {
    console.log(err);
  }
}


// Get form data and return as object for POST
// Uppercase first char to match DB
function getTaskForm() {

  // Get form fields
  const pId = document.getElementById('TaskId').value;
  const catId = document.getElementById('StatusId').value;
  const pDesc = document.getElementById('TaskDescription').value;
  const pPriority = document.getElementById('TaskPriority').value;

  // build Task object for Insert or Update
  // required for sending to the API
  const taskObj = {
    TaskId: pId,
    StatusId: catId,
    TaskDescription: pDesc,
    TaskPriority: pPriority
  }

  // return the body data
  return taskObj;
}

// Setup task form
function taskFormSetup(title) {
  // reset the form and change the title
  document.getElementById("taskForm").reset();
  document.getElementById("taskFormTitle").innerHTML = title;

  // form reset doesn't work for hidden inputs!!
  // do this to rreset previous id if set
  document.getElementById("TaskId").value = 0;
}

// Add a new task - called by form submit
// get the form data and send request to the API
async function addOrUpdateTask() {
  // url for api call
  const url = `${BASE_URL}/task`
  let httpMethod = "POST";

  // get new task data as json (the request body)
  const taskObj = getTaskForm();

  // If TaskId > 0 then this is an existing task for update
  if (taskObj.TaskId > 0) {
    httpMethod = "PUT";
  }

  // build the request object - note: POST
  // reqBodyJson added to the req body
  const request = {
    method: httpMethod,
    headers: getHeaders(),
    credentials: 'include',
    mode: 'cors',
    // convert JS Object to JSON and add to request body
    body: JSON.stringify(taskObj)
  };

  // Try catch 
  try {
    // Call fetch and await the respose
    // fetch url using request object
    const response = await fetch(url, request);
    const json = await response.json();

    // Output result to console (for testing purposes) 
    console.log(json);

    // catch and log any errors
  } catch (err) {
    console.log(err);
    return err;
  }
  // Refresh tasks list
  console.log("AQUI EM FIM vamos ver");
  console.log(taskObj);
  console.log("ANTES LOCAL TASK00000002");
  loadTasks(taskObj.StatusId);
}

// When a task is selected for update/ editing, get it by id and fill out the form
async function prepareTaskUpdate(id) {

  try {
    // Get broduct by id
    const task = await getDataAsync(`${BASE_URL}/task/${id}`);

    // Set form defaults
    taskFormSetup(`Update Task ID: ${task.TaskId}`);

    // Fill out the form
    document.getElementById('TaskId').value = task.TaskId; // uses a hidden field - see the form    
    document.getElementById('StatusId').value = task.StatusId;
    document.getElementById('TaskDescription').value = task.TaskDescription;
    document.getElementById('TaskPriority').value = task.TaskPriority;

  } // catch and log any errors
  catch (err) {
    console.log(err);
  }
}

// Delete task by id using an HTTP DELETE request
async function deleteTask(id, status) {

  const request = {
    method: 'DELETE',
    headers: getHeaders(),
    credentials: 'include',
    mode: 'cors',
  };

  if (confirm("Are you sure?")) {
    // url
    const url = `${BASE_URL}/task/${id}`;

    // Try catch 
    try {
      const result = await fetch(url, request);
      const response = await result.json();

      if (response == true) {
        console.log("AQUI EM FIM vamos ver 0000005");
        console.log(status);
        console.log("ANTES LOCAL TASK00000003");
        loadTasks(status);
      }

      // catch and log any errors
    } catch (err) {
      console.log(err);
      return err;
    }

  }
}

async function UpdateTaskStatus(id, status, statusOrigin) {

  // url for api call
  const url = `${BASE_URL}/task`
  let httpMethod = "POST";
  console.log("ANDRE SANCHES");
  console.log(id);
  console.log(status);
  // get new task data as json (the request body)
  const productsToUpdate = await getDataAsync(`${BASE_URL}/task/${id}`);
  console.log("ANDRE SANCHES2 ");
  console.log(productsToUpdate);
  productsToUpdate.StatusId = status;

  const taskObj = productsToUpdate;

  // If TaskId > 0 then this is an existing task for update
  if (taskObj.TaskId > 0) {
    httpMethod = "PUT";
  }

  // build the request object - note: POST
  // reqBodyJson added to the req body
  const request = {
    method: httpMethod,
    headers: getHeaders(),
    credentials: 'include',
    mode: 'cors',
    // convert JS Object to JSON and add to request body
    body: JSON.stringify(taskObj)
  };

  // Try catch 
  try {
    // Call fetch and await the respose
    // fetch url using request object
    const response = await fetch(url, request);
    const json = await response.json();

    // Output result to console (for testing purposes) 
    console.log(json);

    // catch and log any errors
  } catch (err) {
    console.log(err);
    return err;
  }
  // Refresh tasks list
  console.log("AQUI EM FIM vamos ver 0000001");
  console.log(statusOrigin);
  console.log("ANTES LOCAL TASK00000004");
  loadTasks(statusOrigin);
}


// Alternative for getting for data
// used formData object
// https://developer.mozilla.org/en-US/docs/Web/API/FormData/FormData
function getTaskFormAlt() {

  // Get form + data
  const taskForm = document.getElementById("taskForm");
  const formData = new FormData(taskForm);

  // https://stackoverflow.com/questions/41431322/how-to-convert-formdatahtml5-object-to-json
  // Get form fields + values
  let newTask = {};
  formData.forEach((value, key) => newTask[key] = value);

  // return task json
  return JSON.stringify(newTask);
}

// When this script is loaded, call loadTasks() to add tasks to the page
console.log("AQUI EM FIM vamos ver 0000002");
console.log(1);
console.log("ANTES LOCAL TASK00000005");
loadTasks(1);