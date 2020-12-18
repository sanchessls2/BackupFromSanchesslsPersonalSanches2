// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Working_with_Objects#Using_a_constructor_function
// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Functions/default_parameters

let Status = (statusId = 0, statusName, statusDescription) => {

    this.StatusId = statusId;
    this.StatusName = statusName;
    this.StatusDescription = statusDescription;
};

module.exports = Status;


