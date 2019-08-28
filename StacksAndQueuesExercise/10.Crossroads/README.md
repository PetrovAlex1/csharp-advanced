## Problem 8.Problem 10. \*Crossroads

Our favorite super-spy action hero Sam is back from his mission in the previous exam, and he has finally found some time to go on a **holiday**. He is taking his wife somewhere nice and they&#39;re going to have a really good time, but first, they have to get there. Even on his holiday trip, Sam is still going to run into some **problems** and the first one is, of course, getting to the airport. Right now, he is stuck in a traffic jam at a **very**** active ****crossroads** where a lot of **accidents** happen.

Your job is to keep track of traffic at the crossroads and report whether a **crash happened** or everyone **passed** the **crossroads**** safely** and our hero is one step closer to a much desired vacation.

The road Sam is on has a **single**** lane **where cars queue up until the** light ****goes**** green **. When it does, they start passing one by one during the** green ****light** and the **free window** before the **intersecting**** road&#39;s ****light** goes **green**. During **one**** second **only** one ****part** of a **car** (a **single**** character**) passes the crossroads. If a car is still in the crossroads when the**free ****window** ends, it will get hit at the **first character** that is still in the crossroads.

### Input

- On the **first line** , you will receive the duration of the **green**** light **in seconds – an** integer****in the range [1-100]**
- On the **second line** , you will receive the duration of the **free**** window **in seconds – an** integer****in the range [0-100]**
- On the **following lines** , until you receive the &quot; **END**&quot; command, you will receive one of two things:
  - A **car** – a **string** containing any ASCII character, or
  - The command &quot; **green**&quot; which indicates the **start** of a **green**** light ****cycle**

A **green**** light ****cycle** goes as follows:

- During the **green**** light** cars will enter and exit the crossroads one by one
- During the **free window** cars will only exit the crossroads

### Output

- If a **crash**** happens **,** end the program** and print:
**&quot;A crash happened!&quot;**
**&quot;{car} was hit at {characterHit}.&quot;**
- If everything **goes**** smoothly **and you receive an &quot;** END**&quot; command, print:
**&quot;Everyone is safe.&quot;**
**&quot;**** {totalCarsPassed} total cars passed the crossroads. ****&quot;**

### Constraints

- The input will be **within the constaints** specified above and will **always be valid**. There is **no need** to check it explicitly.

### Examples

| **Input** | **Output** | **Comments** |
| --- | --- | --- |
| 105MercedesgreenMercedesBMWSkodagreenEND | Everyone is safe.3 total cars passed the crossroads. | During the first green light (10 seconds), the Mercedes (8) passes safely.During the second green light, the Mercedes (8) passes safely and there are 2secondsleft.The BMWenters the crossroads and when the green light ends, it still has 1part inside (&#39;W&#39;), but has 5seconds to leave and passes successfully.The Skodaneverenters the crossroads, so 3 cars passed successfully. |
| 93MercedesHummergreenHummerMercedesgreenEND | A crash happened!Hummer was hit at e. | Mercedes (8) passes successfully and Hummer (6) enters the crossroads but only the &#39;H&#39; passes during the green light. There are 3 seconds of free window, so &quot;umm&quot; passes and the Hummer gets hit at &#39;e&#39; and the program ends with a crash.  |

