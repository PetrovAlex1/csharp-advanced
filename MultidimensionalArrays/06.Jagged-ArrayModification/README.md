1. 6.Jagged-Array Modification

Write a program that **reads a matrix** from the console. On the first line you will get matrix **rows**.On next **rows** lines you will get elements for each **column** separated with **space**. You will be receiving commands in the following format:

- **Add {row} {col} {value}** – **Increase** the number at the given **coordinates** with the **value.**
- **Subtract {row} {col} {value}** – **Decrease** the number at the given **coordinates** by the **value**.

Coordinates might be invalid. In this case you should print &quot; **Invalid**  **coordinates**&quot;. When you receive &quot; **END**&quot; you should print the matrix and stop the program.

### Examples

| **Input** | **Output** |
| --- | --- |
| 31 2 34 5 67 8 9Add 0 0 5Subtract 1 1 2END  | 6 2 34 3 67 8 9 |
| 41 2 3 45 6 7 88 7 6 54 3 2 1Add 4 4 100Add 3 3 100Subtract -1 -1 42Subtract 0 0 42END | Invalid coordinatesInvalid coordinates-41 2 3 45 6 7 88 7 6 54 3 2 101 |
