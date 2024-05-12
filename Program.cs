using System;

public class Vechicle
{
    public void tyre()
    {
        Console.WriteLine("It is a tubeless tyre");
    }
}

class Scooter : Vechicle
{
    public  void display() 
    {
        base.tyre();
        Console.WriteLine("It is a scooter class");
    }
}

class Car : Vechicle
{
    public  void display() 
    {
        base.tyre();
        Console.WriteLine("It is a car class");
    }
}

class Program
{
    static void Main()
    {
        Scooter scooter = new Scooter();
        Car car = new Car();
        
        
        Console.WriteLine("Scooter started:");
        scooter.display();
        
        Console.WriteLine("\nCar started:");
        car.display();
    }
}