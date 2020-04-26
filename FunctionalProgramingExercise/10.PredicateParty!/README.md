1.
## Predicate Party!

Ivancho&#39;s parents are on a vacation for the holidays and he is planning an epic party at home. Unfortunately, his organizational skills are next to non-existent, so you are given the task to help him with the reservations.

On the **first line** you get a **list with all the people** that are coming. On the **next lines** , until you get the **&quot;Party!&quot; command** , you may be asked to **double** or **remove**** all the people **that apply to given** criteria **. There are** three different ****criteria** : 1. everyone that has his **name**** starting **with a** given string **; 2. everyone that has a** name ****ending** with a **given string** ; 3. everyone that has a **name** with a **given length**.

Finally **print all the guests** who are going to the party **separated by**&quot;,&quot; and then **add the ending**&quot;are going to the party!&quot;. If there are **no guests** going to the party print &quot;Nobody is going to the party!&quot;. See the examples below:

### Examples

| **Input** | **Output** |
| --- | --- |
| Pesho Misho StefanRemove StartsWith PDouble Length 5Party! | Misho, Misho, Stefan are going to the party! |
| PeshoDouble StartsWith PeshDouble EndsWith eshoParty! | Pesho, Pesho, Pesho, Pesho are going to the party! |
| PeshoRemove StartsWith PParty! | Nobody is going to the party! |


