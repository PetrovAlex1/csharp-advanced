# Problem 4.Problem 6.  Auto Repair and Service

_Winter is coming. All vehicles must prepare for it by changing their tires and other necessary procedures. It&#39;s a very busy time of the year for all of the auto services and they need help with the organization of their work._

Write a program that keeps track of the vehicles. The **first** vehicle that arrives for service, should be the **first** that **gets served**. After a vehicle gets served **it leaves** the auto service, but the workers also **keep** track of the **served**** vehicles **.  If a client calls and asks for his vehicle, you should** look for** it and tell the client if it already has gotten served.

You will be given **a sequence of car models** , separated by a single space. After that you will be given a **few commands** until you receive the command &quot;End&quot;. The commands are - &quot; **Service**&quot;, &quot; **CarInfo** -{ **modelName** }&quot; and &quot; **History**&quot;.  If you receive the command &quot; **Service**&quot;, you should serve the **first received vehicle** and afterwards **print** :

&quot;Vehicle {vehicleName} got served.&quot;

and **delete** it from the awaiting vehicles. If you receive the command &quot; **CarInfo**&quot;, **check** if the car is waiting for service.  If it is – print:

**&quot;Still waiting for service.&quot; and if not, print &quot;Served.&quot;**

If you receive the command &quot;History&quot;, print the served vehicles starting from **the last served to the first**. After the End command, first print the **waiting** (if there are any left) and then the **served**** vehicles** in the following format:

&quot;Vehicles for service: {modelName}, {modelName}, ....., {modelName}&quot;

&quot;Served vehicles: {modelName}, {modelName}, ....., {modelName}&quot;

### Input

- On the first line, you will be given a sequence of strings
- On the next n lines you will be given commands

### Output

- While receiving the commands, print the proper messages described above
- After the command &quot;End&quot;, print the waiting vehicles from the **first**** to **the** last **and the served vehicles from the** last **to the** first**

### Constraints

- The input **will always be valid** and in the **formats** described above
- The **count** of the commands might be **more** than the **count of the vehicles**
- There will always be **at least one** served vehicle
- The vehicles that you should check for will always **exist** in the **list of vehicles** given to you

### Examples

| **Input** | **Output** |
| --- | --- |
| BMWE60 SKODAOctavia MERCEDESClk PEUGEOT607 AUDI80 FIATPuntoServiceServiceServiceCarInfo-MERCEDESClkCarInfo-AUDI80HistoryEnd | Vehicle BMWE60 got served.Vehicle SKODAOctavia got served.Vehicle MERCEDESClk got served.Served.Still waiting for service.MERCEDESClk, SKODAOctavia, BMWE60Vehicles for service: PEUGEOT607, AUDI80, FIATPuntoServed vehicles: MERCEDESClk, SKODAOctavia, BMWE60 |

