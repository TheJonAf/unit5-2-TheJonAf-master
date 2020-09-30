# Assignment 5-2 Average Calculator

## Assignment Instructions

For this assignment, you'll work with first creating an array and populating it's values. Then, we'll use the values in the array to calculate the average. Since it's common for an average to result in numbers with decimal points, the array you create should be of type `double[]`. This program will need to use dynamic input from the user so perform the following steps:

1. Ask the user how many numbers need to be added. Use this value to create a new array using the size entered from the user.
2. Adding a looping structure to capture the numbers from the user to populate each position in the array you've created.
3. Calculate the average and print the result.
    - Remember average is `sum / number of items`.
    - Remember that for the number of items you can use the `Length` property on your array variable.
    
### Sample

```text
How many numbers would you like to add? 5
Enter a number: 4
Enter a number: 9
Enter a number: 16
Enter a number: 25
Enter a number: 36
Average: 18
``` 

## Running Unit Tests

To run unit tests in Visual Studio to validate work, there are multiple ways you run the tests:

1. Right click the solution and click `Run Tests`
2. Right click the Test project and click `Run Tests`
3. Click `Run All Tests` from the main Test menu option
4. Running tests from within the Test Explorer

### Test Explorer

I would recommend clicking `Test` from the main menu and open the `Test Explorer`.  This should open a new panel that you can dock wherever you'd like in Visual Studio. From there, you can see all tests within the solution, run the tests, and click to see output for each test.