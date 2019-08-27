1. 2.Stack Sum

Write program that:

- **Reads** an **input of integer numbers** and **adds** them to a **stack**
- **Reads commands** until **&quot;end&quot;** is received
- **Prints** the **sum** of the remaining elements of the **stack**

### Input

- On the **first**** line **you will receive** an array of integers**
- On the **next**** lines **, until the &quot;** end **&quot; command is given, you will receive** commands **– a** single ****command** and **one** r **two** numbers after the **command, depending** n what **command** you are given
- If the **command** is &quot; **add**&quot;, you will **always** receive **exactly two** numbers after the command which you need to **add** in the **stack**
- If the **command** is &quot; **remove**&quot;, you will **always** receive **exactly**** one **number after the command which represents the** count **of the numbers you need to** remove **from the** stack. **If there are** not enough elements** skip the command.

### Output

- When the **command**&quot; **end**&quot; is received, you need to **print the sum** of the **remaining** elements in the **stack**

### Examples

| **Input** | **Output** |
| --- | --- |
| 1 2 3 4adD 5 6REmove 3eNd | Sum: 6 |
| 3 5 8 4 1 9add 19 32remove 10add 89 22remove 4remove 3end | Sum: 16 |

### Hints

- Use a **Stack\&lt;int\&gt;**
- Use the methods **Push()**, **Pop()**
- Commands **may** be given in **mixed case**

