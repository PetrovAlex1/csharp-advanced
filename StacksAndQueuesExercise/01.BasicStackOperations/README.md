1. Problem 1.Basic Stack Operations

Play around with a stack. You will be given an integer **N** representing the number of elements to push into the stack, an integer **S** representing the number of elements to pop from the stack and finally an integer **X** , an element that you should look for in the stack. If it&#39;s found, print &quot; **true**&quot;on the console. If it isn&#39;t, print the **smallest** element currently present in the stack.

### Input

- On the first line you will be given **N** , **S** and **X,** separated by a single space
- On the next line you will be given **N** number of integers

### Output

- On a single line print either **true** if **X** is present in the stack, otherwise print the **smallest** element in the stack. If the stack is **empty** , print 0

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 5 2 131 13 45 32 4 | true | We have to **push 5** elements. Then we **pop 2** of them. Finally, we have to check whether 13 is present in the stack. Since it is we print **true**. |
| 4 1 666420 69 13 666 | 13 |   |

