COP3503 Computer Science II
Homework 5
Purpose
Practice using the abstraction, encapsulation and inheritance concepts of OOP in a Java program.
Instructions
Create a Shape class
1. Using the abstraction concept of OOP, define variables and methods in the Shape class that are
common to the Circle and Rectangle classes (see UML Class Diagram section)
A. Encapsulate the variables and methods appropriately
1. Public – All objects in the program have access
2. Protected – Only objects that inherit the class have access
3. Private – Only the object has access
2. Update the Circle and Rectangle classes to inherit the Shape class
Note: In Java, a class inherits another class using the “extends” keyword.
3. Remove the common variables and methods from the Circle and Rectangle classes
A. Override methods as needed
Note: Overriding a method is necessary when an object behaves differently from the
inherited object’s behavior.
1. Use “@Override” to indicate the method is overriding an inherited method
4. Create a UML Class Diagram of the Circle, Rectangle and Shape classes
A. Show that the Circle and Rectangle classes inherit the Shape class
Create a Java program that performs the following tasks:
1. Implement the classes defined in the UML Class Diagram created in step 4 above
2. Prompt the user for the following inputs (doubles)
A. The radius (length) of a circle
B. The length and width of a rectangle
3. Create the object instances of the Circle and Rectangle classes
A. Pass the radius (length) as the parameter for the Circle class constructor
1. “Circle circle = new Circle(radius);”
B. Pass the length and width as the parameters for the Rectangle class constructor
1. “Rectangle rectangle = new Rectangle(length, width);”
4. Perform the calculations
A. Calculate Area
1. “circle.calcArea();”
B. Calculate Perimeter
1. “rectangle.calcPerimeter();”
5. Display the results of the Circle and Rectangle calculations (see Example Output section)
A. Display decimal values to three decimal places
Notes
 Display homework number and programmer’s name at top of program output
 Ensure source code comments conform to class commenting standards
 Ensure program development conforms to class programming standards
 Submit the project source code as a single *.java file
 Submit a text capture of the compiler results as a *.txt file
 Submit a capture of the program output as a *.txt file
Example Output
Homework 5
Ima Java Programmer
Enter the radius of a cicle [1 to 10]: 4
Enter the length of a rectangle [1 to 10]: 5
Enter the width of a rectangle [1 to 10]: 8
Circle:
 Area: 50.265
 Perimeter: 25.133
Rectangle:
 Area: 40.000
 Perimeter: 26.000
