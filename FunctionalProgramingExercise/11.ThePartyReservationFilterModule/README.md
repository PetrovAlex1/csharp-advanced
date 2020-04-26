1.
## Party Reservation Filter Module

You need to implement a filtering module to a party reservation software. First, to the Party Reservation Filter Module (PRFM for short) is **passed a list** with invitations. Next the PRFM receives a **sequence of commands** that specify whether you need to add or remove a given filter.

Each PRFM command is in the given format **{command;filter type;filter parameter}**

You can receive the following PRFM commands: &quot; **Add filter**&quot;, &quot; **Remove filter**&quot; or &quot; **Print**&quot;. The possible PRFM filter types are: &quot; **Starts with**&quot;, &quot; **Ends with**&quot;, &quot; **Length**&quot; and &quot; **Contains**&quot;. All PRFM filter parameters will be a string (or an integer only for the &quot; **Length&quot;** filter). Each command will be valid e.g. you won&#39;t be asked to remove a non-existent filter.

The input will **end** with a &quot; **Print**&quot; command after which you should print all the party-goers that are left after the filtration. See the examples below:

### Examples

| **Input** | **Output** |
| --- | --- |
| Pesho Misho SlavAdd filter;Starts with;PAdd filter;Starts with;MPrint | Slav |
| Pesho Misho JicaAdd filter;Starts with;PAdd filter;Starts with;MRemove filter;Starts with;MPrint | Misho Jica |


