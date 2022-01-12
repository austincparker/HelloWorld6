// See https://aka.ms/new-console-template for more information
Console.WriteLine("Howdy Y'all!!");
Console.ReadKey();
var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

foreach (var animal in animals)
{
	if (animal.Length > 5)
    {
	Console.WriteLine(animal);
    }
    else
    {
        Console.WriteLine("too short");
    }
}