1. 2.Average Student Grades

Write a program, which reads the **name** of a student and their **grades** and **adds** them to the **student record** , then **prints**** grades **along with their** average grade**.

#### Examples

| **Input** | **Output** |
| --- | --- |
| 7Ivancho 5.20Mariika 5.50Ivancho 3.20Mariika 2.50Stamat 2.00Mariika 3.46Stamat 3.00 | Ivancho -\&gt; 5.20 3.20 (avg: 4.20)Mariika -\&gt; 5.50 2.50 3.46 (avg: 3.82)Stamat -\&gt; 2.00 3.00 (avg: 2.50) |
| 4Vladimir 4.50Petko 3.00Vladimir 5.00Petko 3.66 | Vladimir -\&gt; 4.50 5.00 (avg: 4.75)Petko -\&gt; 3.00 3.66 (avg: 3.33) |
| 5Gosho 6.00Gosho 5.50Gosho 6.00Ivan 4.40Petko 3.30 | Gosho -\&gt; 6.00 5.50 6.00 (avg: 5.83)Ivan -\&gt; 4.40 (avg: 4.40)Petko -\&gt; 3.30 (avg: 3.30) |

#### Hints

- Use a **dictionary** ( **string**** List\&lt;double\&gt;**)
- Check if the name exists before adding the grade. If it doesn&#39;t, add it to the dictionary.
- Pass through all **key-value pairs** in the dictionary and print the results. You can use the **.Average()** method to quickly calculate the average value from a list.


