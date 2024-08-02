// See https://aka.ms/new-console-template for more information
using FlowerShop;
using FlowerShop.CustomExceptions;
using System.Reflection.PortableExecutable;
using static System.Net.Mime.MediaTypeNames;

var rose = new Rose("Rose", "red", true, 12.5m);
var standardRose = new Rose("Standard Rose", "yellow", true, 8.5m);
var lily = new Lily("True Lily", "white", "sweet", 15.0m);
var hybridLily = new Lily("Hybrid Lily", "orange", "fresh", 25.0m);
var sunflower = new Sunflower("Suntastic Sunflower", "yellow", 160.0, 10.0m);
var americanSunflower = new Sunflower("American Sunflowers", "yellow", 150.0, 10.0m);
var nullFlowerForTestException = new Sunflower(null, "yellow", 150.0, 10.0m);

var myFirstBouquet = new Bouquet();

myFirstBouquet.AddFlower(rose);
myFirstBouquet.AddFlower(standardRose);
myFirstBouquet.AddFlower(lily);
myFirstBouquet.AddFlower(hybridLily);
myFirstBouquet.AddFlower(sunflower);
myFirstBouquet.AddFlower(americanSunflower);
//myFirstBouquet.AddFlower(nullFlowerForTestException);

//displaying the bouquet
myFirstBouquet.ShowBouquet();

//search the flower in the bouquet by index
myFirstBouquet.FindFlowerByIndex(1);

//replacing the flower in the bouquet, displaying the bouquet
myFirstBouquet.ReplaceFlower(1, lily);
myFirstBouquet.ShowBouquet();

//removing the flower from the bouquet
myFirstBouquet.RemoveFlowerByIndex(1);
myFirstBouquet.ShowBouquet();

//search the flower in the bouquet by criteria
Console.WriteLine("Do you want to find a flower by criteria in the bouquet? (Y/N)");
if (Console.ReadLine().ToUpper() == "Y")
{
    while (true)
    {
        Console.WriteLine("Enter 1,2 or 3 (search criterias are name, color, price): ");
        string input = Console.ReadLine();
        
        if (input == "1")
        {
            Console.WriteLine("Enter the name of the flower you want to search:");
            string name = Console.ReadLine();

            try
            {
                myFirstBouquet.SearchFlowersByName(name);
            }
            catch (FlowerNotFoundExceptionName ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else if (input == "2")
        {
            Console.WriteLine("Enter the color of the flower you want to search:");
            string color = Console.ReadLine();

            try
            {
                myFirstBouquet.SearchFlowersByColor(color);
            }
            catch (FlowerNotFoundExceptionColor ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else if (input == "3")
        {
            Console.WriteLine("Enter the lower price limit:");
            decimal lowerLimit = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the upper price limit:");
            decimal upperLimit = decimal.Parse(Console.ReadLine());

            try
            {
                myFirstBouquet.FindFlowersByPriceRange(lowerLimit, upperLimit);
            }
            catch (FlowerNotFoundExceptionPrice ex)
            {
                Console.WriteLine(ex.Message);
            }
        } 
        else
        {
            Console.WriteLine("Invalid value. The program is finished.");
            return;
        }
    }
}
else
    Console.WriteLine("Invalid value. The program is finished.");
    return;
