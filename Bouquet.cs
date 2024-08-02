using FlowerShop.CustomExceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    internal class Bouquet
    {
        private List<Flower> flowers = new List<Flower>();

        public void AddFlower(Flower flower)
        {
            try
            {
                if (flower.Color == null || flower.Price == 0 || flower.Name == null )
                {
                    throw new ArgumentNullException();
                }
                else
                    flowers.Add(flower);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Adding a new flower failed. Some properties of the flower are not defined.");
                Console.WriteLine();
                //Environment.Exit(0);
            }
        }

        public void RemoveFlowerByIndex(int index)

        {
            try
            {
                if (index <= 0 && index > flowers.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    Flower flowerToRemove = flowers[index];
                    flowers.RemoveAt(index);
                    Console.WriteLine($"The flower at position {index + 1} has been removed from the bouquet.");
                    Console.WriteLine();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Removing the flower from the bouquet failed. {ex.Message}");
                Console.WriteLine();
                //Environment.Exit(0);
            }

        }

        public void ReplaceFlower(int index, Flower newFlower)
        {
            try
            {
                if (index >= 0 && index < flowers.Count)
                {
                    Flower oldFlower = flowers[index];
                    flowers[index] = newFlower;
                    Console.WriteLine($"Replaced {oldFlower.Name} with {newFlower.Name} at position {index + 1} in the bouquet.");
                    Console.WriteLine();
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Replacing the flower failed: {ex.Message}");
                Console.WriteLine();
                //Environment.Exit(0);
            }
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var flower in flowers)
            {
                total += flower.Price;
            }
            return total;

        }

        public void ShowBouquet()
        {
            try
            {
                if (flowers.Count == 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    var flowerNames = flowers.Select(f => f.Name).ToList();
                    string flowerSummary = string.Join(", ", flowerNames);

                    Console.WriteLine($"The bouquet consists of: {flowerSummary}.");
                    Console.WriteLine($"Total price of the bouquet is {GetTotalPrice():C}.");
                    Console.WriteLine();
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Displaying the bouquet failed. The bouquet is empty.");
                Environment.Exit(0);
            }
        }

        public void FindFlowerByIndex(int index)
        {
            try
            {
                if (index >= 0 && index < flowers.Count)
                {
                    Flower flower = flowers[index];
                    Console.WriteLine($"Flower at number {index + 1}: Name - {flower.Name}, Color - {flower.Color}, Price - {flower.Price:C}.");
                }
                else
                    throw new IndexOutOfRangeException();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Searching for the flower by index failed: {ex.Message}");
                Console.WriteLine();
                //Environment.Exit(0);
            }
        }

        public List<Flower> SearchFlowersByColor(string color)
        {
            List<Flower> matchingFlowers = flowers.Where(flower => flower.Color.Equals(color, StringComparison.OrdinalIgnoreCase)).ToList();

            if (matchingFlowers.Count == 0)
            {
                throw new FlowerNotFoundExceptionColor(color);
            }
            else
            {
                foreach (Flower flower in matchingFlowers)
                {
                    Console.WriteLine($"{flower.Name} matches the color {color}.");
                }
            }

            return matchingFlowers;
        }

        public Flower SearchFlowersByName(string name)
        {
            foreach (Flower flower in flowers)
            {
                if (flower.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"The flower matches the name {name} was found in your bouquet.");
                    return flower;
                }
            }

            throw new FlowerNotFoundExceptionName(name);
        }

        public void FindFlowersByPriceRange(decimal lowerLimit, decimal upperLimit)
        {
            List<Flower> matchingFlowers = flowers.Where(flower => flower.Price >= lowerLimit && flower.Price <= upperLimit).ToList();

            if (matchingFlowers.Count == 0)
            {
                throw new FlowerNotFoundExceptionPrice();
            }
            else
            {
                Console.WriteLine("Matching flowers:");
                foreach (var flower in matchingFlowers)
                {
                    Console.WriteLine($"{flower.Name} - {flower.Price:C}");
                }
            }
        }
    }
}
