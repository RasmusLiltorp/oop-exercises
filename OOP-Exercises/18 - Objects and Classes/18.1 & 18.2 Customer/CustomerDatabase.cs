namespace OOP_Exercises._18._1_Customer;

public class CustomerDatabase()
{
    public Customer[] customers;
    private int index = 0;

    public void arrayInit()
    {
        customers = new Customer[10];
    }

    public void AddCustomer(Customer newCustomer)
    {
        if (index <= customers.Length)
        {
            customers[index] = newCustomer;
            index++;
        }
        else
        {
            throw new Exception("Array is full");
        }
    }

    public void RemoveCustomer(int customerID)
    {
        for (int i = 0; i < customers.Length; i++)
        {
            if (customerID != null && customers[i].id == customerID)
            {
                customers[i] = null;
                break;
            } 
        }
    }

    public Customer[] GetCustomers()
    {
        return customers;
    }
    
    public void PrintCustomers()
    {
        Console.WriteLine("\nAll customers in the database:");
        for (int i = 0; i < customers.Length; i++)
        {
            if (customers[i] != null)
            {
                Console.WriteLine($"Name: {customers[i].name}, ID: {customers[i].id}, Balance: {customers[i].balance}");            }
        }
    }
}