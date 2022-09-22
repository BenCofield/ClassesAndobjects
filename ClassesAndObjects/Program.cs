using System;
using System.Transactions;
using Cars;

Console.WriteLine("Enter the make, model, and year of your car:");
var newCar = new Car()
{
    Make = Console.ReadLine(),
    Model = Console.ReadLine(),
    Year = int.Parse(Console.ReadLine())
};
Console.WriteLine($"You have a {newCar.Year} {newCar.Make} {newCar.Model}");