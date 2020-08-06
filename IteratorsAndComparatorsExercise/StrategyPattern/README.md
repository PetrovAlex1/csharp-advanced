1.
## Strategy Pattern

An interesting pattern you may have heard of is the **Strategy Pattern**. If we have multiple ways to do a task (say **sort a collection** ), it allows the client to **choose the way that fits his needs the most**. A famous implementation of the pattern in C# are the [**List\&lt;T\&gt;.Sort()**](https://msdn.microsoft.com/en-us/library/234b841s(v=vs.110).aspx) and [**Array.Sort()**](https://msdn.microsoft.com/en-us/library/aw9s5t8f(v=vs.110).aspx) methods that take an **IComparer** as an argument.

Create a class **Person** that holds a **name** and an **age**. Create 2 Comparators for **Person** (classes, which implement the **IComparer\&lt;Person\&gt;** interface). The first comparator should compare people based on the **length of their name** as a first parameter, if 2 people have a name with the same length, perform a **case-insensitive** compare based on the **first letter** of their name instead. The second comparator should compare them based on their **age**.

Create 2 **SortedSets** of type **Person**. The first should implement the **name comparator** and the second should implement **the age comparator**.

### Input

On the first line of input you will receive a number **N**. On each of the next **N** lines you will receive information about people in the format **&quot;\&lt;name\&gt; \&lt;age\&gt;&quot;**. Add the people from the input into both sets (both sets should hold all the people passed in from the input).

### Output

Print each person from the set on a new line in the same format that you have received them. Start with the set that implements the name comparator.

### Constraints

- A person&#39;s name will be a string that contains only alphanumerical characters with length between **[1…50]** symbols.
- A person&#39;s age will be a positive integer between **[1…100]**.
- The number of people **N** will be a positive integer between **[0…100]**.

### Examples

| **Input** | **Output** |
| --- | --- |
| 3Pesho 20Joro 100Pencho 1 | Joro 100Pesho 20Pencho 1Pencho 1Pesho 20Joro 100 |
| 5Ivan 17asen 33Stoqn 25Nasko 99Joro 3 | asen 33Ivan 17Joro 3Nasko 99Stoqn 25Joro 3Ivan 17Stoqn 25asen 33Nasko 99 |

