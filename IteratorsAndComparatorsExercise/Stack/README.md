1.
## Stack

Since you have passed the basic algorithms course, now you have a task to create your custom stack. You are aware of the Stack&#39;s structure. There is a collection to store the elements and two functions (not from the functional programming) - to push an element and to pop it. Keep in mind that the first element, which is popped is the last in the collection. The Push method adds an element at the top of the collection and the Pop method returns the top element and removes it.

Write your custom implementation of **Stack\&lt;T\&gt;** and implement **IEnumerable\&lt;T\&gt;** interface. Your implementation of the **GetEnumerator()** method should follow the rules of the Abstract Data Type – **Stack** (return the elements in reverse order of adding them to the stack)

### Input

The input will come from the console as lines of commands. Commands will only be **push** and **pop** , followed by integers for the **push** command and no another input for the **pop** command.

Format:

- **Push {element1}, {element2}, … {elementN} –** add given elements to the stack
- **Pop –** removes the last pushed element from the stack

### Output

When you receive **END** , the input is over. Foreach the stack **twice** and print all elements each on new line.

### Constraints

- The elements in the push command will be valid integers between **[2****-31 ****…2**** 31****-1]**.
- The commands will always be valid (always be either **Push, Pop** or **END** ).
- If Pop command could not be executed as expected (e.g. no elements in the stack), print on the console: &quot; **No elements**&quot;.

### Examples

| **Input** | **Output** |
| --- | --- |
| Push 1, 2, 3, 4PopPopEND | 2121 |
| Push 1, 2, 3, 4 PopPush 1END | 13211321 |
| Push 1, 2, 3, 4 PopPopPopPopPopEND | No elements |

