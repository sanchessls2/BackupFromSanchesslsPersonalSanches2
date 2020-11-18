// Import router package

const router = require('express').Router();

const validator = require('validator');

/* Hand get requests for '/'

/* this is the index or home page

*/

router.get('/', (req, res) => {

    // set content type of response body in the headers

    res.setHeader('Content-Type', 'application/json');

    // Send a JSON response - this app will be a web api so no need to send HTML

    //res.end(JSON.stringify({message: 'This is the home page'}));

    res.json({ content: 'CHanged 3, This is the default route.' });

});


router.get('/add', (req, res) => {

    let numA = "";
    let numB = "";
    let op = req.query.op;

    if (typeof req.query.a != 'undefined') {
        numA = req.query.a;
    }

    if (typeof req.query.b != 'undefined') {
        numB = req.query.b;
    }


    if (!validator.isNumeric(numA, { no_symbols: true }) ||
        !validator.isNumeric(numB, { no_symbols: true })) {
        res.statusMessage = "Bad Request!";
        res.status(400).end();
    }

    const answer = Number(numA) + Number(numB);

    const AddResult = {
        a: Number(numA),
        b: Number(numB),
        answer : answer
    }

    res.json(AddResult);
})


router.get('/subtract', (req, res) => {

    let numA = "";
    let numB = "";
    let op = req.query.op;

    if (typeof req.query.a != 'undefined') {
        numA = req.query.a;
    }

    if (typeof req.query.b != 'undefined') {
        numB = req.query.b;
    }


    if (!validator.isNumeric(numA, { no_symbols: true }) ||
        !validator.isNumeric(numB, { no_symbols: true })) {
        res.statusMessage = "Bad Request!";
        res.status(400).end();
    }

    const answer = Number(numA) - Number(numB);

    const AddResult = {
        a: Number(numA),
        b: Number(numB),
        answer : answer
    }

    res.json(AddResult);
})


router.get('/multiply', (req, res) => {

    let numA = "";
    let numB = "";
    let op = req.query.op;

    if (typeof req.query.a != 'undefined') {
        numA = req.query.a;
    }

    if (typeof req.query.b != 'undefined') {
        numB = req.query.b;
    }


    if (!validator.isNumeric(numA, { no_symbols: true }) ||
        !validator.isNumeric(numB, { no_symbols: true })) {
        res.statusMessage = "Bad Request!";
        res.status(400).end();
    }

    const answer = Number(numA) * Number(numB);

    const AddResult = {
        a: Number(numA),
        b: Number(numB),
        answer : answer
    }

    res.json(AddResult);
})


router.get('/divide', (req, res) => {

    let numA = "";
    let numB = "";
    let op = req.query.op;

    if (typeof req.query.a != 'undefined') {
        numA = req.query.a;
    }

    if (typeof req.query.b != 'undefined') {
        numB = req.query.b;
    }


    if (!validator.isNumeric(numA, { no_symbols: true }) ||
        !validator.isNumeric(numB, { no_symbols: true }) || 
        (numB == 0)){
        res.statusMessage = "Bad Request!";
        res.status(400).end();
    }

    

    const answer = Number(numA) / Number(numB);

    const AddResult = {
        a: Number(numA),
        b: Number(numB),
        answer : answer
    }

    res.json(AddResult);
})



// export

module.exports = router;