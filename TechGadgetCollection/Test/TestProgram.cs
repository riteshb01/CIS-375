using System;

namespace TechGadgetCollection
{
    /// <summary>
    /// Simple test program to demonstrate the TechGadget class inheritance and functionality
    /// </summary>
    class TestProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== TechGadget Collection Test ===\n");

            // Test 1: Create TechGadget with parameterized constructor
            Console.WriteLine("Test 1: Creating TechGadget with parameters");
            TechGadget gadget1 = new TechGadget(
                "iPhone 15 Pro",
                "Apple",
                999.99m,
                "Phone",
                new DateTime(2024, 9, 15),
                12
            );

            Console.WriteLine($"Name: {gadget1.Name}");
            Console.WriteLine($"Brand: {gadget1.Brand}");
            Console.WriteLine($"Price: ${gadget1.Price}");
            Console.WriteLine($"Category: {gadget1.Category}");
            Console.WriteLine($"Purchase Date: {gadget1.PurchaseDate.ToShortDateString()}");
            Console.WriteLine($"Warranty: {gadget1.WarrantyMonths} months");
            Console.WriteLine($"Summary: {gadget1.GetSummary()}");
            Console.WriteLine();

            // Test 2: Create TechGadget with default constructor
            Console.WriteLine("Test 2: Creating TechGadget with default constructor");
            TechGadget gadget2 = new TechGadget();
            gadget2.Name = "MacBook Pro";
            gadget2.Brand = "Apple";
            gadget2.Price = 2499.99m;
            gadget2.Category = "Laptop";
            gadget2.PurchaseDate = new DateTime(2024, 11, 1);
            gadget2.WarrantyMonths = 24;

            Console.WriteLine($"Summary: {gadget2.GetSummary()}");
            Console.WriteLine();

            // Test 3: Demonstrate base class properties
            Console.WriteLine("Test 3: Testing CollectionItem base class");
            CollectionItem baseItem = new CollectionItem(
                "Generic Gadget",
                "Unknown",
                100.00m,
                "Accessory",
                DateTime.Now
            );
            Console.WriteLine($"Base class summary: {baseItem.GetSummary()}");
            Console.WriteLine();

            // Test 4: Polymorphism - TechGadget as CollectionItem
            Console.WriteLine("Test 4: Testing polymorphism");
            CollectionItem polymorphicGadget = gadget1; // TechGadget assigned to CollectionItem reference
            Console.WriteLine($"Polymorphic summary: {polymorphicGadget.GetSummary()}");
            Console.WriteLine("(Notice warranty info is still included due to override)");
            Console.WriteLine();

            Console.WriteLine("=== All Tests Completed Successfully! ===");
        }
    }
}
