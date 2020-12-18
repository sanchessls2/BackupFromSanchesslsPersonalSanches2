const router = require('express').Router();
const taskService = require('../services/taskService.js');
const userService = require('../services/userService.js');

// Auth0
const { authConfig, checkJwt, checkAuth, getUser } = require('../middleware/jwtAuth.js');

// check auth for all routes in this controller
//router.use(checkJwt);

// GET listing of all tasks
// Address http://server:port/task
// returns JSON
router.get('/', async (req, res) => {
    let result;


    // Get info from user profile
    // if logged in (therefore access token exists)
    // get token from request
    try {
        if (req.headers['authorization']) {
            let token = req.headers['authorization'].replace('Bearer ', '');
            const userProfile = await userService.getAuthUser(token);
            console.log("user profile: ", userProfile);
            console.log("user email: ", userProfile.email);
        }

    }catch(err) {
        console.log(`ERROR getting user profile: ${err.message}`);
    }


    // Get tasks
    try {

        result = await taskService.getTasks();
        res.json(result);

      // Catch and send errors  
      } catch (err) {
        res.status(500);
        res.send(err.message);
      }
});

// GET a single task by id
// id passed as parameter via url
// Address http://server:port/task/:id
// returns JSON
router.get('/:id', async (req, res) => {

    let result;
    // read value of id parameter from the request url
    const taskId = req.params.id;

    // If validation passed execute query and return results
    // returns a single task with matching id
    try {
        // Send response with JSON result    
        result = await taskService.getTaskById(taskId);
        res.json(result);

        } catch (err) {
            res.status(500);
            res.send(err.message);
        }
});

// GET tasks by category id
// id passed as parameter via url
// Address http://server:port/task/:id
// returns JSON
router.get('/bycat/:id', async (req, res) => {

    let result;

    // read value of id parameter from the request url
    const categoryId = req.params.id;

    // If validation passed execute query and return results
    // returns a single task with matching id
    try {
        // Send response with JSON result    
        result = await taskService.getTaskByCatId(categoryId);
        res.json(result);

        } catch (err) {
            res.status(500)
            res.send(err.message)
        }
});


// POST - Insert a new task.
// This async function sends a HTTP POST request
// checkJwt authenticates the user - ddid the request include a valid JWT?
// checkAuth checks permissions - does the JWT include create:tasks (authConfig.create)
router.post('/', checkJwt, checkAuth([authConfig.create]), async (req, res) => {

    // the request body contains the new task values - copy it
    const newTask = req.body;

    // show what was copied in the console (server side)
    console.log("taskController: ", newTask);

    // Pass the new task data to the service and await the result
    try {
        // Send response with JSON result    
        result = await taskService.createTask(newTask);

        // send a json response back to the client
        res.json(result);

        // handle server (status 500) errors
        } catch (err) {
            res.status(500)
            res.send(err.message)
        }
});

// PUT update task
// Like post but taskId is provided and method = put
router.put('/', checkJwt, checkAuth([authConfig.update]), async (req, res) => {

    // the request body contains the new task values - copy it
    const task = req.body;

    // show what was copied in the console (server side)
    console.log("taskController update: ", task);

    // Pass the new task data to the service and await the result
    try {
        // Send response with JSON result    
        result = await taskService.updateTask(task);

        // send a json response back to the client
        res.json(result);

        // handle server (status 500) errors
        } catch (err) {
            res.status(500)
            res.send(err.message)
        }
});

// DELETE single task.
router.delete('/:id', checkJwt, checkAuth([authConfig.delete]), async (req, res) => {

    let result;
    // read value of id parameter from the request url
    const taskId = req.params.id;
    // If validation passed execute query and return results
    // returns a single task with matching id
    try {
        // Send response with JSON result    
        result = await taskService.deleteTask(taskId);
        res.json(result);

        } catch (err) {
            res.status(500);
            res.send(err.message);
        }
});

// Export as a module
module.exports = router;
