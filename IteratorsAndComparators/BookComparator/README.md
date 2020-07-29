1.
## Book Comparator

**NOTE** : You need the namespace **IteratorsAndComparators**.

Extend your solution from the prevoius task. Create a class **BookComparator,** which should implement the **IComparer\&lt;Book\&gt;** interface and thus include the following method:

- **int Compare(Book, Book)**

**BookComparator** must **compare** two books by:

1. Book title - **alphabetical order**
2. Year of publishing a book - **from the newest to the oldest**

Modify your Library class once again to implement the **new sorting**.

### Examples

| **Startup.cs** |
| --- |
| publicstaticvoid Main(){Book bookOne = newBook(&quot;Animal Farm&quot;, 2003, &quot;George Orwell&quot;);Book bookTwo = newBook(&quot;The Documents in the Case&quot;, 2002, &quot;Dorothy Sayers&quot;, &quot;Robert Eustace&quot;);Book bookThree = newBook(&quot;The Documents in the Case&quot;, 1930);
Library library = newLibrary(bookOne, bookTwo, bookThree);} |

| **Output** |
| --- |
| Animal Farm - 2003The Documents in the Case - 2002The Documents in the Case - 1930 |

### Solution

![](RackMultipart20200729-4-xrlpx7_html_ec2ef3bf30f00a12.png)

[![](RackMultipart20200729-4-xrlpx7_html_4062ce8ea76a185d.png)](http://softuni.foundation/) ![](RackMultipart20200729-4-xrlpx7_html_9b0988e43f50c79b.gif) ![](RackMultipart20200729-4-xrlpx7_html_8e84094ace6df644.gif) ![](RackMultipart20200729-4-xrlpx7_html_75bb621a2d054d6e.gif) ![](RackMultipart20200729-4-xrlpx7_html_f746d52952cd7e91.gif)

© [Software University Foundation](http://softuni.foundation/). This work is licensed under the [CC-BY-NC-SA](http://creativecommons.org/licenses/by-nc-sa/4.0/) license.

[![](RackMultipart20200729-4-xrlpx7_html_17fe808e24cdd6c6.png)](http://softuni.foundation/)[![](RackMultipart20200729-4-xrlpx7_html_2a07e57d0737966a.png)](http://softuni.org/)[![Software University @ Facebook](RackMultipart20200729-4-xrlpx7_html_94be3df36d913358.png)](http://facebook.com/SoftwareUniversity)[![Software University @ Twitter](RackMultipart20200729-4-xrlpx7_html_ff9c629b0a21eb6b.png)](http://twitter.com/softunibg)[![Software University @ YouTube](RackMultipart20200729-4-xrlpx7_html_7db86a748da0e575.png)](http://youtube.com/SoftwareUniversity)[![](RackMultipart20200729-4-xrlpx7_html_a9d346b26d97741d.png)](http://plus.google.com/+SoftuniBg/)[![](RackMultipart20200729-4-xrlpx7_html_9758e785eadf0cc.png)](https://www.linkedin.com/company/18192649/)[![](RackMultipart20200729-4-xrlpx7_html_660141fbd6d8d4a8.png)](http://github.com/softuni)[![Software University: Email Us](RackMultipart20200729-4-xrlpx7_html_d7fa82ab7332f3fa.png)](mailto:university@softuni.bg)

Follow us:

Page 2 of 2
