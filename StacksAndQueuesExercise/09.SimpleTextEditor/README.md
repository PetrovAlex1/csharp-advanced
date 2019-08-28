# Problem 7.Problem 9.  Simple Text Editor

You are given an empty text. Your task is to implement 4 commands related to manipulating the text

- 1 someString - **appends** someString to the end of the text
- 2 count - **erases** the last _count_ elements from the text
- 3 index - **returns** the element at position _index_ from the text
- 4 - **undoes** the last not undone command of type _1 / 2_ and returns the text to the state before that operation

### Input

- The first line contains **n** , the number of operations.
- Each of the following **n** lines contains the name of the operation followed by the command argument, if any, separated by space in the following format **CommandName Argument**.

### Output

- For each operation of type **3** print a single line with the returned character of that operation.

### Constraints

- 1 ≤ N ≤ 105
- The length of the text will not exceed 1000000
- All input characters are English letters.
- It is guaranteed that the sequence of input operation is possible to perform.

### Examples

| **Input** | **Output** |
| --- | --- |
| 81 abc3 32 31 xy3 244 3 1 | cya |

### Explanation

- There are 8 operations. Initially, the text is empty.
- In the first operation, we append **abc** to the text.
- Then, we print its 3rd character,which is  **c**  at this point.
- Next, we erase its last 3 characters,  **abc**.
- After that, we append  **xy** to the text.
- The text becomes  **xy**  after these previous two modifications.
- Then, we are asked to return the 2nd character of the text, which is  **y**.
- After that, we have to undo the last update to the text, so it becomes empty.
- The next operation asks us to undo the update before that, so the text becomes **abc**
- Finally, we are asked to print its 1st character, which is  **a**  at this point.