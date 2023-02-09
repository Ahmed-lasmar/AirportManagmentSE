<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<title>Airport Management Project Readme</title>
</head>
<body>
	<h1>Airport Management Project</h1>
	<p>The purpose of this project is to create an application to manage the activities of an airport, defined by the class diagram below.</p>
	<h2>I. Data Layer Implementation</h2>
	<ol>
		<li>Create a solution named "AirportManagement" that contains the following two projects:
			<ol type="a">
				<li>AM.UI.Console: Console Application project (.NET 6.0)</li>
				<li>AM.ApplicationCore: Class Library project (.NET 6.0)</li>
			</ol>
			<p>Note that the Console project should reference the ApplicationCore project.</p>
		</li>
		<li>Under the AM.ApplicationCore project, create the "Domain" folder and implement the different classes from the class diagram above.</li>
		<li>Represent inheritance between the Passenger class and the two classes Staff and Traveller.</li>
		<li>Implement the properties that represent the different attributes and their accessors.</li>
		<li>Represent the relationships through navigation objects.
			<ol type="a">
				<li>For example, the 1-* relationship between Plane and Flight will be represented by the following navigation objects:
					<ol type="i">
						<li>A property of type ICollection<Flight> in the Plane class</li>
						<li>A property of type Plane in the Flight class</li>
					</ol>
				</li>
			</ol>
		</li>
		<li>Reimplement the ToString() method for all classes.</li>
	</ol>
	<h2>II. Object Instanciation</h2>
	<ol>
		<li>Create an uninitialized object of type Plane using the non-parameterized constructor of the class, then initialize its attributes through its properties.</li>
		<li>Create the following constructor for the Plane class:
			<p>public Plane (PlaneType pt, int capacity, DateTime date)</p>
			<p>Then create another plane using this constructor.</p>
		</li>
		<li>Delete the constructor created previously and instantiate another plane using object initializers. What do you notice?</li>
	</ol>
	<h2>III. Polymorphism</h2>
	<ol>
		<li>Signature Polymorphism
			<p>In the Passenger entity, create the following three CheckProfile(...) bool methods:</p>
			<ol type="a">
				<li>A method to verify the profile using two parameters: passenger name and passenger first name.</li>
				<li>A method to verify the profile using three parameters: passenger name, passenger first name, and passenger email.</li>
				<li>A method to
