// JavaScript source code


function getBasicDetails() {
    var vname = 'Mike' // old style of using declaring variable
    var vage = 22
    var dob = Date()
    var vprice = 12.500


    let lname = 'name from let keyword'// newer way of declaring variables
    let lage = 22
    let ldob = '2020-02-01'

    let price = 13.500
    console.log('Old price is ', price)
    price = 23.50
    console.log('New price is ', price)
    //let name = 'Mike', age = 22, dob = '2020-02-01', price = 12.500;

    document.write('var name is : ', vname + '</br>');

    document.write('lname name is : ', lname);

    console.log('age of the user is ', lage);

    console.log('Price of the product is  ', price);

    // var allows us to create a varaible with same name and overwrite the values

    // let will not allows to recreate the variable if already created

    // mainly for defining the constants

    const discount = 10

    console.log('discount for the user is ', discount);

    let newdiscount

    let extermediscount = null

    console.log('new discount for the user is ', newdiscount);

    console.log('extermediscount discount for the user is ', extermediscount);

    console.log('Date of birth of the user is ', dob)

    const employee = {
        firstName: "Yuvaraj",
        lastName: "Singh",
        id: 789
    }

    console.log('Name of the user is ', employee.firstName + "," + employee.lastName)

}


let user = {
    firstName: "Yuvaraj",
    lastName: "Singh",
    id: 789,
    greetingsfortheDay: function () {
        console.log('Welcome to the Devleopment and greetings for the day');
    },
    getfullnameofUser: function () {
        return this.firstName + ',' + this.lastName
    }
}

console.log(user.firstName, 'is firstName of the user')
console.log(user.lastName, 'is lastName of the user')

user.greetingsfortheDay();

console.log(user.getfullnameofUser())

function addnumbers(x, y, z = 2) {
    return x + y + z;
}

let mountains = ['Mount Everest', 'xyz', 'abc']

console.log('Sum of numbers is ', addnumbers(10,20))

function welcomeUser() {
    alert('Welcome user');
}