using ConsoleApp8;
using System;
using System.Collections.Generic;
using System.Linq;
using static ConsoleApp8.Allergies;

var mary = new Allergies("Mary");
var joe = new Allergies("Joe", 65);
var rob = new Allergies("Rob", "Peanuts Chocolate Pollen Strawberries");

Console.WriteLine(mary.ToString());
Console.WriteLine(joe.ToString());
Console.WriteLine(rob.ToString());