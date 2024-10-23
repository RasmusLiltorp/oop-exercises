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