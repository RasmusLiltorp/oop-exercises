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