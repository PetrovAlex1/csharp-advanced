1. Problem 3.Maximum and Minimum Element

You have an empty sequence, and you will be given  **N**  queries. Each query is one of these three types:

1 x – **Push** the element x into the stack.

2 – **Delete** the element present at the **top** of the **stack**.

3 – **Print** the **maximum** element in the stack.

4 – **Print** the **minimum** element in the stack.

After you go through all of the queries, print the stack in the following format:

&quot;{n}, {n

# 1
}, {n
# 2
}….., {n
# n
}&quot;
### Input

- The first line of input contains an integer,  **N**
- The next  **N** lines each contain an above-mentioned query. _(It is guaranteed that each query is valid.)_

### Output

- For each type 3 or 4 query, print the **maximum** /minimum element in the stack on a new line

### Constraints

- 1 ≤ N ≤ 105

- 1 ≤ x ≤ 109
- 1 ≤ type ≤ 4

### Examples

| **Input** | **Output** |
| --- | --- |
| 91 9721 2021 261 2031 914 | 262091, 20, 26  |
| 1021 471 661 32431 251 161 84 | 326688, 16, 25, 32, 66, 47 |
