namespace OOP_Exercises._18._1_Customer;

public class Program
{
    static void Main(string[] args)
    {
        CustomerDatabase customerDatabase = new CustomerDatabase();
        customerDatabase.arrayInit();
        
        Customer aCustomer = new Customer();
        aCustomer.nameID("John", 1234);
        aCustomer.Deposit(525);
        aCustomer.Withdraw(1.5);
        
        customerDatabase.AddCustomer(aCustomer);        
        Console.WriteLine($"Balance for {aCustomer.name}: {aCustomer.GetBalance()}");
        
        Customer anotherCustomer = new Customer();
        anotherCustomer.nameID("Bo", 252);
        anotherCustomer.Deposit(1000);
        customerDatabase.AddCustomer(anotherCustomer); 
        
        customerDatabase.PrintCustomers();
        
        customerDatabase.RemoveCustomer(252);
        customerDatabase.PrintCustomers();

    }
}