# Problem 2.Problem 4.  Fast Food

You have a fast food restaurant and most of the food that you&#39;re offering is previously prepared.  You need to know if you will have enough food to serve lunch to all of your customers. Write a program that checks the orders&#39; quantity. You also want to know the client with the **biggest** order for the day, because you want to give him a discount the next time he comes.

First, you will be given the **quantity**** of the food**that you have for the day (an integer number).  Next, you will be given**a sequence of integers **, each representing the** quantity of an order **. Keep the orders in a** queue **. Find the** biggest ****order** and **print** it. You will begin servicing your clients from the **first**** one **that came. Before each order,** check **if you have enough food left to complete it. If you have,** remove the order **from the queue and** reduce** the amount of food you have. If you succeeded in servicing all of your clients, print:

&quot;Orders complete&quot;.

 If not, print:

&quot;Orders left: {order1} {order2} .... {orderN}&quot;.

### Input

- On the first line you will be given the quantity of your food - **an integer** in the range [0, 1000]
- On the second line you will receive a sequence of integers, representing each order, **separated by a single space**

### Output

- Print the quantity of biggest order
- Print &quot;Orders complete&quot; if the orders are complete
- If there are orders left, print them in the format given above

### Constraints

- The input will always be valid

### Examples

| **Input** | **Output** |
| --- | --- |
| 34820 54 30 16 7 9 | 54Orders complete |
| 49957 45 62 70 33 90 88 76 | 90Orders left: 76 |