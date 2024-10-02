namespace OOP_Exercises._18._1_Customer;

public class Customer
{
    public string name;
    public int id;
    public double balance;

    public void nameID(string nameInput, int idInput)
    {
        name = nameInput;
        id = idInput;
        balance = 0;
    }

    public void balanceID(string nameInput, int idInput, double balanceInput)
    {
        name = nameInput;
        id = idInput;
        balance = balanceInput;
    }

    public void Deposit(double amount)
    {
        balance += amount;
    }
    
    public void Withdraw(double amount)
    {
        balance -= amount;
    }

    public double GetBalance()
    {
        return balance;
    }
}


