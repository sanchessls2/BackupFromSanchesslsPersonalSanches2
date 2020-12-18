// require the database connection
const taskRepository = require('../repositories/taskRepository.js');
const taskValidator = require('../validators/taskValidators.js');

// Input validation package
// https://www.npmjs.com/package/validator
const validator = require('validator');


// Get all tasks via the repository
// return tasks
let getTasks = async () => {
    let tasks = await taskRepository.getTasks();
    return tasks;
};


// Get task by id via the repository
// Validate input
// return task
let getTaskById = async (taskId) => {

    let task;

    // Validate input - important as a bad input could crash the server or lead to an attack
    // appending + '' to numbers as the validator only works with strings
    if (!taskValidator.validateId(taskId)) {
        console.log("getTasks service error: invalid id parameter");
        return "invalid parameter";
    }

    // get task
    task = await taskRepository.getTaskById(taskId);

    return task;
};

// Get tasks in a category via the repository
// Validate input
// return tasks
let getTaskByCatId = async (catId) => {

    let tasks;

    // Validate input - important as a bad input could crash the server or lead to an attack
    // appending + '' to numbers as the validator only works with strings
    if (!taskValidator.validateId(catId)) {
        console.log("getTasks service error: invalid id parameter");
        return "invalid parameter";
    }

    tasks = await taskRepository.getTaskByCatId(catId);

    return tasks;
};


// Insert a new task
// This function accepts task data as a paramter from the controller.
let createTask = async (task) => {

    // declare variables
    let newlyInsertedTask;

    // Call the task validator - kept seperate to avoid clutter here
    let validatedTask = taskValidator.validateNewTask(task);

    // If validation returned a task object - save to database
    if (validatedTask != null) {
        newlyInsertedTask = await taskRepository.createTask(validatedTask);
    } else {

        // Task data failed validation 
        newlyInsertedTask = {"error": "invalid task"};

        // debug info
        console.log("taskService.createTask(): form data validate failed");
    }

    // return the newly inserted task
    return newlyInsertedTask;
};

// task update service
let updateTask = async (task) => {

    // Declare variables and consts
    let updatedTask;

    // call the task validator
    let validatedTask = taskValidator.validateUpdateTask(task);

    // If validation returned a task object - save to database
    if (validatedTask != null) {
        updatedTask = await taskRepository.updateTask(validatedTask);
    } else {

        // Task data failed validation 
        updatedTask = {"error": "Task update failed"};

        // debug info
        console.log("taskService.updateTask(): form data validate failed");
    }

    // return the newly inserted task
    return updatedTask;
};

let deleteTask = async (taskId) => {

    let deleteResult = false;

    // Validate input - important as a bad input could crash the server or lead to an attack
    // appending + '' to numbers as the validator only works with strings
    if (!taskValidator.validateId(taskId)) {
        console.log("deleteTasks service error: invalid id parameter");
        return false;
    }

    // delete task by id
    // result: true or false
    deleteResult = await taskRepository.deleteTask(taskId);

    // sucess
    return deleteResult;
};

// Module exports
// expose these functions
module.exports = {
    getTasks,
    getTaskById,
    getTaskByCatId,
    createTask,
    updateTask,
    deleteTask
};