# Scenario 1: Calculate from a String
In this challenge you will implement the Answer method that can make simple calculations from a given string.

The input strings will follow a specific pattern: 
- What is [expression]? where [expression] represents a valid mathematical expression involving
- addition
- subtraction
- multiplication
- division 

The operands and operators in the expression will always be separated by spaces.

- The code should work for simple examples: When the input string is What is 5? then the expected result is 5.
- The code also should work for simple operations: When the input string is What is 1 plus 1? Then the expected result is 2.
- When the input string is What is 53 plus 2? then the expected result is 55.
- When the input string is What is 4 minus -12? and the expected result is 16.
- When the input string is What is -3 multiplied by 25? and the expected result is -75.
- When the input string is What is 33 divided by -3? and the expected result is -11.

This should also work for other examples too.


# Scenario 2: Multiple Calculations
Until now we only had simple calculations. 
In this scenario we will add a second operation to our calculation.
**We assume that they are chained verbally so all equations are read from left to right. I.e. we ignore the order of operations.**
- When the input string is What is 1 plus 1 plus 1? then the expected result is 3.
- When the input string is What is 1 plus 5 minus -2? and the expected result is 8.
- When the input string is What is -3 plus 7 multiplied by -2? and the expected result is -8.

This should also work for other examples too.


# Scenario 3: Exception Handling
Of course we cannot rely on the correct user input. 
We have to do some handling of incorrect input strings.

An ArgumentException should be thrown when:
- Unspported operations are used (e.g. What is 52 cubed?)
- Unsupported questions (e.g. What is Love?, What is the answer to the ultimate question of life, the universe, and everything?)
- Syntactically incorrect questions (e.g. What is 1 plus?)
