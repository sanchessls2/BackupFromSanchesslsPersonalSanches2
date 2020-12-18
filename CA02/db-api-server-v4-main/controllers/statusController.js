// Depencencies
const router = require('express').Router();

const statusService = require('../services/statusService.js');

// GET listing of all status
// Address http://server:port/status
// returns JSON
router.get('/', async (req, res) => {

    let result;
    // Get status
    try {

      // Call the status service to get all status 
      result = await statusService.getStatus()
      res.json(result);

      // Catch and send errors  
      } catch (err) {
        res.status(500);
        res.send(err.message);
      }
});

// Export as a module
module.exports = router;
