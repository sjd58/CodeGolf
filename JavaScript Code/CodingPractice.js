// Write a method that returns the prime factors of an integer
function returnPrimes(number) {
    let primesArray = [];
    for (let i = 2; i <= number; i++) {
        while (number % i == 0)
        {
            primesArray.push(i);
            number /= i;
        }
    }
    return primesArray;
}
console.log("returnPrimes results")
console.log(returnPrimes(12));

// Write a boolean method that takes in an integer array and returns true if there are no integers that repeat three times in a row
function noTriples(numbers) {
    for (let i = 2; i < numbers.length; i++) {
        let selectedNumber = numbers[i];
        if ((numbers[i - 1] === selectedNumber) && (numbers[i - 2] === selectedNumber)) {
            return false;
        }
    }
    return true;
}
console.log("noTriples results")
let testArray = [1, 2, 3, 4, 4, 4, 6]
console.log(noTriples(testArray));

// Create a boolean method called More14 that takes in an array of ints called "nums."
// Given an array of ints return true if the number of 1s is greater than the number of 4s.
let More14 = (nums) => {
    let oneCounter = 0;
    let fourCounter = 0;
    for (let i = 0; i < nums.length; i++) {
        
    }
}

// Create a function that prints a Floyd triangle onto the console.
// Bonus: do it again but with an array of arrays
let printFloyd = (number) => {
    let counter = 1;
    for (let i = 1; i <= number; i++) {
        let stringToPrint = "";
        for (let j = 1; j <= i; j++) {
            stringToPrint += `${counter} `;
            counter++;
        }
        console.log(stringToPrint);
    }
}
console.log(printFloyd(5));

function printFloydArray(number) {
    let arrayToPrint = [];
    let counter = 1;
    for (let i = 1; i <= number; i++) {
        let arrayToAdd = [];
        for (let j = 1; j <= i; j++) {
            arrayToAdd.push(counter);
            counter++;
        }
        arrayToPrint.push(arrayToAdd);
    }
    console.log(arrayToPrint);
    //arrayToPrint.forEach(array => {console.log(array)});
}

console.log(printFloydArray(6));

