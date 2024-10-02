namespace OOP_Exercises._18._1_Customer;

public class Program
{
    static void Main(string[] args)
    {
        Customer aCustomer = new Customer();
        
        aCustomer.nameID("John", 1234);
        aCustomer.Deposit(525);
        aCustomer.Withdraw(1.5);
        
        Console.WriteLine(aCustomer.GetBalance());

    }
}