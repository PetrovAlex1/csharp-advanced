# Problem 6.Problem 8.  Balanced Parentheses

Given a sequence consisting of parentheses, determine whether the expression is **balanced**. A sequence of parentheses is balanced if every **open**** parenthesis **can be** paired ****uniquely** with a **closed**** parenthesis **that occurs** after **the former. Also, the** interval ****between** them **must** be **balanced**. You will be given **three** types of parentheses: (, {, and [.

**{[()]} - This is a balanced parenthesis.**

**{[(])} - This is not a balanced parenthesis.**

### Input

- Each input consists of a single line, **the sequence of parentheses**.

### Output

- For each test case, print on a new line &quot;YES&quot; if the parentheses are balanced.
Otherwise, print &quot;NO&quot;. Do not print the quotes.

### Constraints

- 1 ≤ len
# s
≤ 1000, where len
# s
 is the length of the sequence.
- Each character of the sequence **will be one of**  {, }, (, ), [, ].

### Examples

| **Input** | **Output** |
| --- | --- |
| {[()]} | YES |
| {[(])} | NO |
| {{[[(())]]}} | YES |