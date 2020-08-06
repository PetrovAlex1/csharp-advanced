1.
## Comparing Objects

Create a **class Person**. Each person should have a **name** , an **age** and a **town**. You should implement the interface – **IComparable\&lt;T\&gt;** and implement the **CompareTo** method. When you compare two people, first you should **compare their names** , after that – **their age** and finally – **their towns**.

### Input

On every line, you will be given people in format:

**{name} {age} {town}**

Collect them till you receive **&quot;END&quot;**

After that, you will receive an integer **N** – the **N**** th **person in your collection.** Starting from 1.**

### Output

On the single output line, you should bring statistics, how many people are equal to him, how many people are not equal to him and the total people in your collection.

Format: **{number of equal people} {number of not equal people} {total number of people}**

### Constraints

Input names, ages and addresses will be valid. Input number will always be а valid integer in range **[2…100]**

If there are no equal people print: **&quot;No matches&quot;**

### Examples

| **Input** | **Output** |
| --- | --- |
| Pesho 22 VracaGogo 14 SofetoEND2 | No matches |
| Pesho 22 VracaGogo 22 VracaGogo 22 VracaEND2 | 2 1 3 |

