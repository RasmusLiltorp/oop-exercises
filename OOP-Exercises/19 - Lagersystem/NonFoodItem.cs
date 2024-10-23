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