1. 4.Cities by Continent and Country

Write a program to read **continents** , **countries** and their **cities** , put them in a **nested dictionary** and **print** them.

#### Examples

| **Input** | **Output** |
| --- | --- |
| 9Europe Bulgaria SofiaAsia China BeijingAsia Japan TokyoEurope Poland WarsawEurope Germany BerlinEurope Poland PoznanEurope Bulgaria PlovdivAfrica Nigeria AbujaAsia China Shanghai | Europe:  Bulgaria -\&gt; Sofia, Plovdiv  Poland -\&gt; Warsaw, Poznan  Germany -\&gt; BerlinAsia:  China -\&gt; Beijing, Shanghai  Japan -\&gt; TokyoAfrica:  Nigeria -\&gt; Abuja |
| 3Europe Germany BerlinEurope Bulgaria VarnaAfrica Egypt Cairo | Europe:  Germany -\&gt; Berlin  Bulgaria -\&gt; VarnaAfrica:  Egypt -\&gt; Cairo |
| 8Africa Somalia MogadishuAsia India MumbaiAsia India DelhiEurope France ParisAsia India NagpurEurope Germany HamburgEurope Poland GdanskEurope Germany Danzig | Africa:  Somalia -\&gt; MogadishuAsia:  India -\&gt; Mumbai, Delhi, NagpurEurope:  France -\&gt; Paris  Germany -\&gt; Hamburg, Danzig  Poland -\&gt; Gdansk |

#### Hints

- Use a **nested**** dictionary**(**string**(**Dictionary **** List\&lt;string\&gt;****)**)
- Check if the continent exists before adding the country. If it doesn&#39;t, add it to the dictionary.
- Check if the country exists, before adding the city. If it doesn&#39;t, add it to the dictionary.
- Pass through all **key-value pairs** in the dictionary and the values&#39; key-value pairs and print the results.

1. II.Sets


