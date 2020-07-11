1.
## Generic Scale

**NOTE** : You need a public **StartUp** class with the namespace **GenericScale**.

Create a class **Equality**** Scale\&lt;T\&gt;** that holds two elements - left and right. The scale should receive the elements through its single constructor:

- **EqualityScale(T left, T right)**

The scale should have a single method:

- **bool AreEqual()**

The greater of the two elements is the heavier. The method should return **null** if the elements are equal.