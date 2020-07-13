
1.
## Tuple

There is something, really annoying in C#. It is called a [**Tuple**](https://msdn.microsoft.com/en-us/library/system.tuple(v=vs.110).aspx). It is a class, which may store a few objects but let&#39;s focus on the type of Tuple which contains two objects. The first one is &quot; **item1**&quot; and the second one is &quot; **item2**&quot;. It is kind of like a **KeyValuePair** except – it **simply has items,** which are **neither key nor value**. The annoyance is coming from the fact, that you have no idea what these objects are holding. The class name is telling you nothing, the methods, which it has – also. So, let&#39;s say for some reason we would like to try to implement it by ourselves.

The task: Create a class &quot; **Tuple**&quot;, which is holding two objects. Like we said, the first one, will be &quot; **item1**&quot; and the second one - &quot; **item2**&quot;. The tricky part here is to make the class hold generics. This means, that when you create a new object of class - &quot; **Tuple**&quot;, there should be a way to explicitly, specify both the items&#39; type separately.

### Input

The input consists of three lines:

- The first one is holding a person name and an address. They are separated by space(s). Your task is to collect them in the tuple and print them on the console. Format of the input:

**\&lt;first name\&gt; \&lt;last**  **name**** \&gt;\&gt; ****\&lt;**** address ****\&gt;**

- The second line holds a **name** of a personand the **amount of beer** (int) he can drink. Format:

**\&lt;**** name ****\&gt; \&lt;**** liters of beer ****\&gt;**

- The last line will hold an **Integer** and a **Double**. Format:

**\&lt;**** Integer ****\&gt; \&lt;**** Double ****\&gt;**

### Output

- Print the tuples&#39; items in format: { **item1** } -\&gt; { **item2** }

### Constraints

Use the good practices we have learned. Create the class and make it have getters and setters for its class variables. The input will be valid, no need to check it explicitly!

### Example

| **Input** | **Output** |
| --- | --- |
| Sofka Tripova StolipinovoAz 223 21.23212321 | Sofka Tripova -\&gt; StolipinovoAz -\&gt; 2
1. -\&gt; 21.23212321
 |

