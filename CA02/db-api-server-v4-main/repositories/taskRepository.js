
// Dependencies

// require the database connection
const { sql, dbConnPoolPromise } = require('../database/db.js');

// models
const Task = require('../models/task.js');
const Status = require('../models/status.js');

// Define SQL statements here for use in function below
// These are parameterised queries note @named parameters.
// Input parameters are parsed and set before queries are executed

// for json path - Tell MS SQL to return results as JSON 
const SQL_SELECT_ALL = 'SELECT * FROM Task ORDER BY TaskPriority ASC for json path;';

// for json path, without_array_wrapper - use for single json result
const SQL_SELECT_BY_ID = 'SELECT * FROM Task WHERE TaskId = @id for json path, without_array_wrapper;';

// for json path, without_array_wrapper - use for single json result
const SQL_SELECT_BY_CATID = 'SELECT * FROM Task WHERE StatusId = @id ORDER BY TaskPriority ASC for json path;';

// Second statement (Select...) returns inserted record identified by TaskId = SCOPE_IDENTITY()
const SQL_INSERT = 'INSERT INTO Task (StatusId,TaskDescription, TaskPriority) VALUES (@statusId, @taskDescription, @TaskPriority); SELECT * from dbo.Task WHERE TaskId = SCOPE_IDENTITY();';
const SQL_UPDATE = 'UPDATE Task SET StatusId = @statusId, TaskDescription = @taskDescription, TaskPriority = @TaskPriority WHERE TaskId = @id; SELECT * FROM dbo.Task WHERE TaskId = @id;';
const SQL_DELETE = 'DELETE FROM Task WHERE TaskId = @id;';


// Get all tasks
// This is an async function named getTasks defined using ES6 => syntax
let getTasks = async () => {

    // define variable to store tasks
    let tasks;

    // Get a DB connection and execute SQL (uses imported database module)
    // Note await in try/catch block
    try {
        const pool = await dbConnPoolPromise
        const result = await pool.request()
            // execute query
            .query(SQL_SELECT_ALL);
        
        // first element of the recordset contains tasks
        tasks = result.recordset[0];

    // Catch and log errors to cserver side console 
    } catch (err) {
        console.log('DB Error - get all tasks: ', err.message);
    }

    // return tasks
    return tasks;
};

// get task by id
// This is an async function named getTaskById defined using ES6 => syntax
let getTaskById = async (taskId) => {

    let task;

    // returns a single task with matching id
    try {
        // Get a DB connection and execute SQL
        const pool = await dbConnPoolPromise
        const result = await pool.request()
            // set @id parameter in the query
            .input('id', sql.Int, taskId)
            // execute query
            .query(SQL_SELECT_BY_ID);

        // Send response with JSON result    
        task = result.recordset[0];

        } catch (err) {
            console.log('DB Error - get task by id: ', err.message);
        }
        
        // return the task
        return task;
};

// Get tasks by status
let getTaskByCatId = async (statusId) => {

    let tasks;

    // returns tasks with matching status id
    try {
        // Get a DB connection and execute SQL
        const pool = await dbConnPoolPromise
        const result = await pool.request()
            // set named parameter(s) in query
            .input('id', sql.Int, statusId)
            // execute query
            .query(SQL_SELECT_BY_CATID);

        // Send response with JSON result    
        tasks = result.recordset[0];

        } catch (err) {
            console.log('DB Error - get task by status id: ', err.message);
        }

    return tasks;
};


// insert/ create a new task
// parameter: a validated task model object
let createTask = async (task) => {

    // Declare constants and variables
    let insertedTask;

    // Insert a new task
    // Note: no Task yet
    try {
        // Get a DB connection and execute SQL
        const pool = await dbConnPoolPromise
        const result = await pool.request()

            // set named parameter(s) in query
            // checks for potential sql injection
            .input('statusId', sql.Int, task.StatusId)    
            .input('taskDescription', sql.NVarChar, task.TaskDescription)
            .input('taskPriority', sql.Int,  task.TaskPriority)

            // Execute Query
            .query(SQL_INSERT);      

        // The newly inserted task is returned by the query    
        insertedTask = result.recordset[0];

        // catch and log DB errors
        } catch (err) {
            console.log('DB Error - error inserting a new task: ', err.message);
        }

        // Return the task data
        return insertedTask;
};

// update an existing task
let updateTask = async (task) => {

   // Declare constanrs and variables
   let updatedTask;

   // Insert a new task
   // Note: no Task yet
   try {
       // Get a DB connection and execute SQL
       const pool = await dbConnPoolPromise
       const result = await pool.request()

           // set named parameter(s) in query
           // checks for potential sql injection
           .input('id', sql.Int, task.TaskId)  
           .input('statusId', sql.Int, task.StatusId)    
           .input('taskDescription', sql.NVarChar, task.TaskDescription)
           .input('taskPriority', sql.Int,  task.TaskPriority)

           // Execute Query
           .query(SQL_UPDATE);      

       // The newly inserted task is returned by the query    
       updatedTask = result.recordset[0];

       // catch and log DB errors
       } catch (err) {
           console.log('DB Error - error updating task: ', err.message);
       }

       // Return the task data
       return updatedTask;
};

// delete a task
let deleteTask = async (taskId) => {

    // record how many rows were deleted  > 0 = success
    let rowsAffected;

    // returns a single task with matching id
    try {
        // Get a DB connection and execute SQL
        const pool = await dbConnPoolPromise
        const result = await pool.request()
            // set @id parameter in the query
            .input('id', sql.Int, taskId)
            // execute query
            .query(SQL_DELETE);

        // Was the task deleted?    
        rowsAffected = Number(result.rowsAffected);     

        } catch (err) {
            console.log('DB Error - get task by id: ', err.message);
        }
        // Nothing deleted
        if (rowsAffected === 0)
            return false;
        // successful delete
        return true;    
};

// Export 
module.exports = {
    getTasks,
    getTaskById,
    getTaskByCatId,
    createTask,
    updateTask,
    deleteTask
};
