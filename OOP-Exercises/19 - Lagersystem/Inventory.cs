namespace OOP_Exercises._19___Lagersystem;

public class Inventory
{
    public void AddItem(ref Item[] items, Item newItem)
    {
        Array.Resize(ref items, items.Length + 1);
    }
    public void RemoveItem(ref Item[] items, Item itemToRemove)
    { 
        int index = Array.IndexOf(items, itemToRemove);

        for (int i = index; i < items.Length - 1; i++)
        {
            items[i] = items[i + 1];
        }

        Array.Resize(ref items, items.Length - 1);
    }
    double GetInventoryValue(Item[] items)
    {
            double totalValue = 0;
            foreach (var item in items)
            {
                totalValue += item.GetPrice();
            }
            return totalValue;
    }
    public static void PrintInventory<T>(T[]array) // uses t as template for any array
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}