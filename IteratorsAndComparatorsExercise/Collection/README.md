1.
## Collection

Using the ListyIterator from the last problem, extend it by **implementing** the **IEnumerable\&lt;T\&gt;** interface, implement all methods desired by the interface manually (use **yield return** for **GetEnumerator()** method). Add a new command **PrintAll** that should foreach the collection and **print all of the elements** on a **single line separated by a space**.

### Input

Input will come from the console as lines of commands. The first line will always be the **only** Create command in the input. The last command received will always be the only **END** command.

### Output

For every command from the input (with the exception of the **END** and **Create** commands) print the result of that command on the console, each on a new line. In case of **Move** or **HasNext** commands print the return value of the method, in case of a **Print** command you don&#39;t have to do anything additional as the method itself should already print on the console. In case of a **PrintAll** command you should print all of the elements on a single line separated by spaces. Your program should catch any exceptions thrown because of validations and print their messages instead.

### Constraints

- **Do NOTuse the GetEnumerator() method from the base class. Use your own implementation using &quot;yield return&quot;**
- There will always be only **1**** Create** command and it will always be the first command passed.
- The number of commands received will be between **[1…100]**.
- The last command will always be the only **END** command.

### Examples

| **Input** | **Output** |
| --- | --- |
| Create 1 2 3 4 5MovePrintAllEND | True1 2 3 4 5 |
| Create Stefcho Goshky PeshuPrintAllMoveMovePrintHasNextEND | Stefcho Goshky PeshuTrueTruePeshuFalse |

