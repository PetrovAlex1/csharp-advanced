# Defining Classes - Lab

Problems for exercises and homework for the [&quot;CSharp Advanced&quot; course @ Software University](https://softuni.bg/courses/csharp-advanced).

You can check your solutions here: [https://judge.softuni.bg/Contests/1478/Defining-Classes-Lab](https://judge.softuni.bg/Contests/1478/Defining-Classes-Lab)

## Problem 1. Car

**NOTE** : You need a **StartUp** class with the namespace **CarManufacturer**.

Create a **class** named **Car**.

The class should have **private**** fields** for:

- **make**** : **** string**
- **model**** : ****string**
- **year:**  **int**

The class should also have **public**** properties** for:

- **Make**** : **** string**
- **Model**** : ****string**
- **Year:**  **int**

You should be able to use the class like this:

## Problem 2. Car Extension

**NOTE** : You need a **StartUp** class with the namespace **CarManufacturer**.

Create a class **Car** (you can use the class from the previous task)

The class should have private fields for:

- **make**** : **** string**
- **model**** : ****string**
- **year:**  **int**
- **fuelQuantity: double**
- **fuelConsumption: double**

The class should also have properties for:

- **Make**** : **** string**
- **Model**** : ****string**
- **Year:**  **int**
- **FuelQuantity: double**
- **FuelConsumption: double**

The class should also have methods for:

- **Drive(double distance): void**– this method checks if the car fuel quantity minus the distance multiplied by the car fuel consumption is bigger than zero. If it is remove from the fuel quantity the result of the multiplication between the distance and the fuel consumption. Otherwise write on the console the following message: **&quot;Not enough fuel to perform this trip!&quot;**
- **WhoAmI(): string**  **–** returns the following message: **&quot;Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L&quot;**

You should be able to use the class like this:

## Problem 3. Car Constructors

Using the class from the previous problem create one parametless constructor with default values:

**Make – VW, Model – Golf, Year – 2025, FuelQuantity – 200, FuelConsumption – 10**

Create second constructor accepting **make, model** and **year** upon initialization and calls the base constructor with it&#39;s default values for **fuelQuantity** and **fuelConsumption**.

Create third constructor accepting **make, model, year, fuelQuantity** and **fuelConsumption** upon initialization and reuses the second constructor to set the make, model and year values.

Go to **StartUp.cs** file and make 3 different instance of the **Class Car** using the **different** overloads of the constructor.

## Problem 4. Car Engine And Tires

Using the Car class, you already created, define another class **Engine**.

The class should have private fields for:

- **horsePower**** : **** int**
- **cubicCapacity**** : ****double**

The class should also have properties for:

- **HorsePower**** : **** int**
- **CubicCapacity**** : ****double**

The class should also have constructor which accepts horsepower and cubicCapacity upon initialization:

Now create class **Tire**.

The class should have private fields for:

- **year**** : **** int**
- **pressure**** : ****double**

The class should also have properties for:

- **Year**** : **** int**
- **Pressure: double**

The class should also have constructor which accepts year and pressure upon initialization:

Finally go to **Car** class and create **private fields for engine and tire array** and **public properties for Engine and Tire array**. Create another constructor which **accepts make, model, year, fuelQuantity, fuelConsumption, Engine** and **Tire** array upon initialization:

You should be able to use the classes like this:

## Problem 5. Special Cars

This is the final and most interesting problem in this lab. Until you receive the command **&quot;No more tires&quot;** you will be given tire info in the format:

**{year} {pressure}**

**{year} {pressure}**

…

**&quot;No more tires&quot;**

You have to collect all the tires provided because you gonna need them all. Next until you receive the command **&quot;Engines done&quot;** you will be given engine info and you also have to collect all that info.

**{horsePower} {cubicCapacity}**

**{horsePower} {cubicCapacity}**

…

**&quot;Engines done&quot;**

The final step is until you receive **&quot;Show special&quot;** you will be given information about cars in the format:

**{make} {model} {year} {fuelQuantity} {fuelConsumption} {engineIndex} {tiresIndex}**

…

**&quot;Show special&quot;**

Each time you have to create new car new Car with the information provided. The car engine is the one on the engine index provided and the tires are the ones on the tiresIndex provided. Finally collect all the cars created. When you receive the command **&quot;Show special&quot;** drive 20 kilometers all cars where their year is above or equal to 2017, have horse power above 330 and the sum of tire pressure is between 9 and 10. Finally print information about each special car in the following format:

**&quot;Make: {specialCar.Make}&quot;**

**&quot;Model: {specialCar.Model}&quot;**

**&quot;Year: {specialCar.Year}&quot;**

**&quot;HorsePowers: {specialCar.Engine.HorsePower}&quot;**

**&quot;FuelQuantity: {specialCar.FuelQuantity}&quot;**

| **Input** | **Output** |
| --- | --- |
| 2 2.6 3 1.6 2 3.6 3 1.61 3.3 2 1.6 5 2.4 1 3.2No more tires331 2.2145 2.0Engines doneAudi A5 2017 200 12 0 0BMW X5 2007 175 18 1 1Show special | Make: AudiModel: A5Year: 2017HorsePowers: 331FuelQuantity: 197.6 |

![](RackMultipart20200610-4-fhqgs9_html_4062ce8ea76a185d.png) ![](RackMultipart20200610-4-fhqgs9_html_9b0988e43f50c79b.gif) ![](RackMultipart20200610-4-fhqgs9_html_8e84094ace6df644.gif) ![](RackMultipart20200610-4-fhqgs9_html_75bb621a2d054d6e.gif) ![](RackMultipart20200610-4-fhqgs9_html_f746d52952cd7e91.gif)

© [Software University Foundation](http://softuni.foundation/). This work is licensed under the [CC-BY-NC-SA](http://creativecommons.org/licenses/by-nc-sa/4.0/) license.

![](RackMultipart20200610-4-fhqgs9_html_17fe808e24cdd6c6.png) ![](RackMultipart20200610-4-fhqgs9_html_2a07e57d0737966a.png) ![](RackMultipart20200610-4-fhqgs9_html_94be3df36d913358.png) ![](RackMultipart20200610-4-fhqgs9_html_ff9c629b0a21eb6b.png) ![](RackMultipart20200610-4-fhqgs9_html_7db86a748da0e575.png) ![](RackMultipart20200610-4-fhqgs9_html_a9d346b26d97741d.png) ![](RackMultipart20200610-4-fhqgs9_html_9758e785eadf0cc.png) ![](RackMultipart20200610-4-fhqgs9_html_660141fbd6d8d4a8.png) ![](RackMultipart20200610-4-fhqgs9_html_d7fa82ab7332f3fa.png)

Follow us:

Page 2 of 2
