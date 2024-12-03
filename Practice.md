### Book Page 300 

#### Working with Inheritance.
In the following exercise, you’ll define a simple class hierarchy for modeling different types of vehicles. You’ll define a base class named Vehicle and derived classes named Airplane and Car. You will define common methods named StartEngine and StopEngine in the Vehicle class, and you’ll add some methods to both of the derived classes that are specific to those classes. Finally, you’ll add a virtual method named Drive to the Vehicle class and override the default implementation of this method in both of the derived classes.

To create a hierarchy of classes

Start Microsoft Visual Studio 2022, if it is not already running.

Open the Vehicles solution, which is located in the \Microsoft Press\VCSBS\Chapter 12\Vehicles folder in your Documents folder.

The Vehicles project contains the file Program.cs, which defines the Program class with the Main and doWork methods that you have seen in previous exercises.

In Solution Explorer, right-click the Vehicles project, point to Add, and then select Class.

The Add New Item – Vehicles dialog opens.

In the Add New Item – Vehicles dialog, verify that the Class template is highlighted. In the Name box, type Vehicle.cs, and then select Add.

The file Vehicle.cs is created and added to the project and appears in the Code and Text Editor window. The file contains the definition of an empty class named Vehicle.

Add the StartEngine and StopEngine methods to the Vehicle class, as shown next in bold:

Click here to view code image

class Vehicle
{
    public void StartEngine(string noiseToMakeWhenStarting)
    {
        Console.WriteLine($"Starting engine: {noiseToMakeWhenStarting}");
    }

    public void StopEngine(string noiseToMakeWhenStopping)
    {
        Console.WriteLine($"Stopping engine: {noiseToMakeWhenStopping}");
    }
}
All classes that derive from the Vehicle class will inherit these methods. The values for the noiseToMakeWhenStarting and noiseToMakeWhenStopping parameters will be different for each type of vehicle and will help you to identify which vehicle is being started and stopped later.

On the Project menu, select Add Class.

The Add New Item – Vehicles dialog opens again.

In the Name box, type Airplane.cs, and then select Add.

A new file containing a class named Airplane is added to the project and appears in the Code and Text Editor window.

In the Code and Text Editor window, modify the definition of the Airplane class so that it inherits from the Vehicle class, as shown in bold here:

class Airplane : Vehicle
{
}
Add the TakeOff and Land methods to the Airplane class, as shown in bold in the following code:

Click here to view code image

class Airplane : Vehicle
{ 
    public void TakeOff()
    {
        Console.WriteLine("Taking off");
    }

    public void Land()
    {
        Console.WriteLine("Landing");
    }
}
On the Project menu, select Add Class.

The Add New Item – Vehicles dialog opens again.

In the Name text box, type Car.cs, and then select Add.

A new file containing a class named Car is added to the project and appears in the Code and Text Editor window.

In the Code and Text Editor window, modify the definition of the Car class so that it derives from the Vehicle class, as shown here in bold:

class Car : Vehicle
{
}
Add the Accelerate and Brake methods to the Car class, as shown in bold in the following code:

Click here to view code image

class Car : Vehicle
{
    public void Accelerate()
    {
        Console.WriteLine("Accelerating");
    }

    public void Brake()
    {
        Console.WriteLine("Braking");
    }
}
Display the Vehicle.cs file in the Code and Text Editor window.

Add the virtual Drive method to the Vehicle class, as presented here in bold:

Click here to view code image

class Vehicle
{
    ...
    public virtual void Drive()
    {
        Console.WriteLine("Default implementation of the Drive method");
    }
}
