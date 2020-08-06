1.
## ListyIterator

Create a **generic** class &quot;ListyIterator&quot;. The collection, which it will iterate through, should be received in the **constructor**. You should **store** the elements in a List. The class should have **three** main functions:

- **Move** - should move an internal index position to the next index in the list. The method should return true, if it had successfully moved the index and false if there is no next index.
- **HasNext** - should return true, if there is a next index and false, if the index is already at the last element of the list.
- **Print** - should print the element at the current internal index. Calling Print on a collection without elements should throw an appropriate exception with the message &quot; **Invalid Operation!**&quot;.

By default, the internal index should be pointing to the **0**** th **** index** of the List. Your program should support the following commands:

| **Command** | **Return Type** | **Description** |
| --- | --- | --- |
| Create {e1 e2 …} | void | Creates a ListyIterator from the specified collection. In case of a Create command without any elements, you should create a ListyIterator with an empty collection. |
| Move | boolean | This command should move the internal index to the next index. |
| Print | void | This command should print the element at the current internal index. |
| HasNext | boolean | Returns whether the collection has a next element. |
| END | void | Stops the input. |

### Input

Input will come from the console as lines of commands. The first line will always be the **only** Create command in the input. The last command received will always be the only **END** command.

### Output

For every command from the input (with the exception of the **END** and **Create** commands) print the result of that command on the console, each on a new line. In case of **Move** or **HasNext** commands, print the return value of the methods, in case of a **Print** command you don&#39;t have to do anything additional as the method itself should already print on the console. Your program should catch any exceptions thrown because of validations (calling Print on an empty collection) and print their messages instead.

### Constraints

- There will always be only **1**** Create** command and it will always be the first command passed.
- The number of commands received will be between **[1…100]**.
- The last command will always be the only **END** command.

### Examples

| **Input** | **Output** |
| --- | --- |
| CreatePrintEND | Invalid Operation! |
| Create Stefcho GoshkyHasNextPrintMovePrintEND | TrueStefchoTrueGoshky |
| Create 1 2 3HasNextMoveHasNextHasNextMoveHasNextEND | TrueTrueTrueTrueTrueFalse |

