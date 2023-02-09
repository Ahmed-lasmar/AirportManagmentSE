Airport Management
This project is an implementation of an airport activity management application. The project is split into two parts: AM.UI.Console and AM.ApplicationCore.

AM.ApplicationCore
This project contains the domain classes for the airport management application as described in the class diagram.

The inheritance between the Passenger class and the Staff and Traveller classes is represented.
Properties that represent the attributes of each class and their accessors are implemented.
Relations between classes are represented through navigation objects, for example, the 1-* relationship between Plane and Flight is represented by the following objects:
A property of type ICollection<Flight> in the Plane class
A property of type Plane in the Flight class
The ToString() method is reimplemented for all classes.
AM.UI.Console
This project is a console application that utilizes the AM.ApplicationCore project.

Objects of the Plane class are created using the non-parameterized constructor and object initializers.
The CheckProfile method of the Passenger class is polymorphic, with three different implementations to verify the profile of the passenger.
The PassengerType method of the Passenger class is polymorphic, with different implementations in the Passenger, Staff, and Traveller classes. The method displays a message indicating the type of passenger.
Usage
To use this project, clone the repository, open the solution in Visual Studio and build the solution. The console application can be run to test the implementation of the airport management application.
