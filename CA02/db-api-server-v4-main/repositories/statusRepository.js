// Dependencies
// require the database connection
const { sql, dbConnPoolPromise } = require('../database/db.js');


// Define SQL statements here for use in function below
// These are parameterised queries note @named parameters.
// Input parameters are parsed and set before queries are executed

// for json path - Tell MS SQL to return results as JSON 
const SQL_SELECT_ALL = 'SELECT * FROM Status ORDER BY StatusId for json path;';

// Get all products
// This is an async function named getStatus defined using ES6 => syntax
let getStatus = async () => {

    // define variable to store status
    let status;

    // Get a DB connection and execute SQL (uses imported database module)
    // Note await in try/catch block
    try {
        const pool = await dbConnPoolPromise
        const result = await pool.request()
            // execute query
            .query(SQL_SELECT_ALL);
        
        // first element of the recordset contains products
        status = result.recordset[0];

    // Catch and log errors to cserver side console 
    } catch (err) {
        console.log('DB Error - get all status: ', err.message);
    }
    // return status
    return status;
};

// Export 
module.exports = {
    getStatus,
};
