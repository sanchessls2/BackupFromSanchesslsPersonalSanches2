
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Working_with_Objects#Using_a_constructor_function
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Functions/default_parameters

function Task(id = 0, cat = 0,  desc,  priority) {

    this.TaskId = id;
    this.StatusId = cat;
    this.TaskDescription = desc;
    this.TaskPriority = priority;
}

module.exports = Task;

