using System;
using System.Collections.Generic;

namespace hashSets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty HashSet named Showroom that will contain strings.
            HashSet<string> Showroom = new HashSet<string>();

            // Add four of your favorite car model names to the set.
            Showroom.Add("Tesla");
            Showroom.Add("Audi");
            Showroom.Add("Mustang");
            Showroom.Add("Nova");

            // Pick one of the items in your show room and add it to the set again.
            Showroom.Add("Nova");

            // Create another set named UsedLot and add two more car model strings to it.
            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Toyota");
            UsedLot.Add("BMW");

            // Use the UnionWith() method on Showroom to add in the two models you added to UsedLot.
            Showroom.UnionWith(UsedLot);

            // You've sold one of your cars. Remove it from the set with the Remove() method.
            Showroom.Remove("Nova");

            // Now create another HashSet of cars in a variable Junkyard. Someone who owns a junkyard full of old cars has approached you about buying the entire inventory. In the new set, add some different cars, but also add a few that are the same as in the Showroom set.
            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Toyota");
            Junkyard.Add("Mustang");
            Junkyard.Add("Lada");
            Junkyard.Add("Volkswagen");

            // Create a new HashSet of your show room with HashSet<string> clone = new HashSet<string>(Showroom);
            HashSet<string> clone = new HashSet<string>(Showroom);

            // Use the IntersectWith() method on the clone to see which cars exist in both the show room and the junkyard.
            clone.IntersectWith(Junkyard);

            foreach (string car in clone)
            {
                Console.WriteLine($"matching cars: {car}");
            }

            // Now you're ready to buy the cars in the junkyard. Use the UnionWith() method to combine the junkyard into your showroom.
            Showroom.UnionWith(Junkyard);

            // Use the Remove() method to remove any cars that you acquired from the junkyard that you don't want in your showroom.
            Showroom.Remove("Lada");

            // Print to the console how many cars are in your show room.
            // Print your showroom again, and notice how there's still only one representation of that model in there.
            foreach (string car in Showroom)
            {
                Console.WriteLine($"showroom: {car}");
            }

        }
    }
}
