// Input validation package
// https://www.npmjs.com/package/validator
const validator = require('validator');

// models
const Task = require('../models/Task.js');

// Validate id field
let validateId = (id) => {

    // check if number is numeric
    if (validator.isNumeric(id + '', { no_symbols: true, allow_negatives: false })) {
        return true;
    }
    else {
        console.log("Task validator: invalid id parameter");
    }
    // validation failed
    return false;
}


// Validate the body data, sent by the client, for a new task
// formTask represents the data filled in a form
// It needs to be validated before using in gthe application
let validateNewTask = (formTask) => {

    // Declare constants and variables
    let validatedTask;

    // debug to console - if no data
    if (formTask === null) {
        console.log("validateNewTask(): Parameter is null");
    }

    // Validate form data for new task fields
    // Creating a task does not need a task id
    // Adding '' to the numeric values makes them strings for validation purposes ()
    // appending + '' to numbers as the validator only works with strings
    if (
        validator.isNumeric(formTask.StatusId + '', { no_symbols: true, allow_negatives: false }) && 
        !validator.isEmpty(formTask.TaskDescription) && 
        validator.isNumeric(formTask.TaskPriority + '', { no_symbols: true, allow_negatives: false }))
    {
        // Validation passed
        // create a new Task instance based on Task model object
        // no value for task id (passed as null)
        validatedTask = new Task(
                null,
                formTask.StatusId,
                // escape is to sanitize - it removes/ encodes any html tags
                validator.escape(formTask.TaskDescription),
                formTask.TaskPriority
            );
    } else {
        // debug
        console.log("validateNewTask(): Validation failed");
    }

    // return new validated task object
    return validatedTask;
}

// Validate the body data, sent by the client, for a new task
// formTask represents the data filled in a form
// It needs to be validated before using in gthe application
let validateUpdateTask = (formTask) => {

    // Declare constants and variables
    let validatedTask;

    // debug to console - if no data
    if (formTask === null) {
        console.log("validateNewTask(): Parameter is null");
    }

    // Validate form data for new task fields
    // Creating a task does not need a task id
    // Adding '' to the numeric values makes them strings for validation purposes ()
    // appending + '' to numbers as the validator only works with strings
    if (
        validator.isNumeric(formTask.TaskId + '', { no_symbols: true, allow_negatives: false }) &&
        validator.isNumeric(formTask.StatusId + '', { no_symbols: true, allow_negatives: false }) && 
        !validator.isEmpty(formTask.TaskDescription) && 
        validator.isNumeric(formTask.TaskPriority + '', { no_symbols: true, allow_negatives: false }))
    {
        // Validation passed
        // create a new Task instance based on Task model object
        // no value for task id (passed as null)
        validatedTask = new Task(
                formTask.TaskId,
                formTask.StatusId,

                // escape is to sanitize - it removes/ encodes any html tags
                validator.escape(formTask.TaskDescription),
                formTask.TaskPriority
            );
    } else {
        // debug
        console.log("validateUpdateTask(): Validation failed");
    }

    // return new validated task object
    return validatedTask;
}

// Module exports
// expose these functions
module.exports = {
    validateId,
    validateNewTask,
    validateUpdateTask
}