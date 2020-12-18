// require the database connection
const taskRepository = require('../repositories/statusRepository.js');

// Get all status via the repository
// return status
let getStatus = async () => {

    let status = await taskRepository.getStatus();
    return status;
};

// Module exports
// expose these functions
module.exports = {
    getStatus
};