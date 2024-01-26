# Mathematical Expression Evaluator

## Scenario 1: Calculate from a String

In this challenge, the `Answer` method that can perform simple calculations from a given string.

The input strings follow a specific pattern: `What is [expression]?` where `[expression]` represents a valid mathematical expression involving addition, subtraction, multiplication, and division. The operands and operators in the expression will always be separated by spaces.

### Examples:

- Input: `What is 5?` 
  - Expected Result: `5`

- Input: `What is 1 plus 1?`
  - Expected Result: `2`

- Input: `What is 53 plus 2?`
  - Expected Result: `55`

- Input: `What is 4 minus -12?`
  - Expected Result: `16`

- Input: `What is -3 multiplied by 25?`
  - Expected Result: `-75`

- Input: `What is 33 divided by -3?`
  - Expected Result: `-11`

## Scenario 2: Multiple Calculations

Now, let's extend our capabilities to handle multiple operations in a chain.

### Examples:

- Input: `What is 1 plus 1 plus 1?`
  - Expected Result: `3`

- Input: `What is 1 plus 5 minus -2?`
  - Expected Result: `8`

- Input: `What is -3 plus 7 multiplied by -2?`
  - Expected Result: `-8`

## Scenario 3: Exception Handling

To handle incorrect input strings, we'll throw an `ArgumentException` for the following cases:

- Unsupported operations (e.g., `What is 52 cubed?`)
- Unsupported questions (e.g., `What is Love?`, `What is the answer to the ultimate question of life, the universe, and everything?`)
- Syntactically incorrect questions (e.g., `What is 1 plus?`)

Feel free to explore more examples and contribute to enhancing the functionality!
