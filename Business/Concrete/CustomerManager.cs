//IoC Container


// Burası Interface konusundan önceki çalışmaları kapsamaktadır.












//Ordudaki askerlere verilen kredi

//SOLID


//Katmanlı mimariler
public class CustomerManager
{
    private Customer _customer;
    private ICreditManager _creditManager;
    public CustomerManager(Customer customer, ICreditManager creditManager)
    {
        _customer = customer;
        _creditManager = creditManager;
    }
    public void Save(Customer customer)
    {
        Console.WriteLine("Müşteri kaydedildi.");
    }

    public void Delete(Customer customer)
    {
        Console.WriteLine("Müşteri silindi.");
    }

    public void GiveCredit()
    {
        _creditManager.Calculate();
        Console.WriteLine("Kredi verildi.");
    }
}

