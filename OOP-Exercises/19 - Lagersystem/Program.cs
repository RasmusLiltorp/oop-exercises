namespace OOP_Exercises._19___Lagersystem;

public class Program
{
    static void Main(string[] args)
    {
        FoodItem[] foodItems = new FoodItem[1];
        
        Console.WriteLine("ENTER FOOD INFORMATION");
        for (int i = 0; i < foodItems.Length; i++)
        {
            foodItems[i] = new FoodItem(null, 0);
            
            string name = foodItems[i].GetName();
            double price = foodItems[i].GetPrice();
            foodItems[i] = new FoodItem(name, price);
            foodItems[i].GetExpiration();

        }
        foreach (var item1 in foodItems)
        {
            Console.WriteLine(item1.ToString());
        }
        
        Console.WriteLine("Enter material information");
        NonFoodItem[] nonFoodItems = new NonFoodItem[1];
        for (int i = 0; i < nonFoodItems.Length; i++)
        {
            nonFoodItems[i] = new NonFoodItem(null, 0);
            
            string name = nonFoodItems[i].GetName();
            double price = nonFoodItems[i].GetPrice();
            nonFoodItems[i] = new NonFoodItem(name, price);
            var materials = nonFoodItems[i].GetMaterials; 
            
        }
        foreach (var item2 in nonFoodItems)
        {
            Console.WriteLine(item2.ToString());
        }
        
        
    }
}
