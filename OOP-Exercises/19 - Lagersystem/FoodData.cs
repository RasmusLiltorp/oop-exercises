using System.Runtime.InteropServices.JavaScript;

namespace OOP_Exercises._19___Lagersystem;

public class Item(string name, double price)
{
    public string GetName()
    {
        Console.WriteLine("Enter Item Name: ");
        name = Console.ReadLine();
        return name;
    }

    public double GetPrice()
    {
        Console.WriteLine("Enter Item Price: ");
        price = double.Parse(Console.ReadLine());
        return price;
    }
}

public class FoodItem(string name, double price) : Item(name, price)
{
    private DateTime expirationDate;

    public void GetExpiration()
    {
        Console.WriteLine("Enter Expiration Date (dd/MM/yyyy): ");
        expirationDate = DateTime.Parse(Console.ReadLine());
    }

    public override string ToString()
    {
        return $"Food Item: {name}, Price: {price:C}, Expiration Date: {expirationDate:dd/MM/yyyy}";

    }
}

public class NonFoodItem(string name, double price) : Item(name, price)
{
    private string[] materials;

    public string[] GetMaterials 
    {
        get
        {
            if (materials == null || materials.Length == 0)
            {
                Console.WriteLine("Enter materials (separated by commas): ");
                string input = Console.ReadLine();
                materials = input.Split(',');
            }
            return materials;
        }
    }
    public override string ToString()
    {
        return $"Item name: {name}, Price: {price:C}, Materials: {string.Join(", ", materials)}";
    }

}