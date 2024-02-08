//IoC Container
CustomerManager customerManager = new CustomerManager(new Customer(), new TeacherCreditManager());
customerManager.GiveCredit();

TeacherCreditManager teacherCreditManager = new TeacherCreditManager();
teacherCreditManager.Save();

/* Burası Interface konusundan önceki çalışmaları kapsamaktadır.

int[] numbers1 = new int[] { 1, 2, 3 };
int[] numbers2 = new int[] { 10, 20, 30 };
numbers1 = numbers2;
numbers2[0] = 1000;
Console.WriteLine(numbers1[0]);

CreditManager creditManager = new CreditManager();
creditManager.Calculate();
creditManager.Calculate();
creditManager.Save();

Customer customer = new Customer();
customer.Id = 1;
customer.City = "Kocaeli";

CustomerManager customerManager = new CustomerManager(customer);
customerManager.Save(customer);
customerManager.Delete(customer);

Company company = new Company();
company.TaxNumber = "10000";
company.CompanyName = "Arçelik";
company.Id = 100;

CustomerManager customerManager2 = new CustomerManager(new Person());

Person person = new Person();
person.FirstName = "Melih";
person.LastName = "Dinçer";
person.NationalIdentity = "123456";

Customer c1 = new Customer();
Customer c2 = new Person();
Customer c3 = new Company();
*/
Console.ReadLine();

class CreditManager
{
    public void Calculate(int creditType)
    {
        //sonar qube
        if(creditType == 1) //esnaf kredisi
        {

        }
        if (creditType == 2) //ogretmen kredisi
        {

        }

        Console.WriteLine("Hesaplandı");
    }
    public void Save()
    {
        Console.WriteLine("Kredi verildi");
    }
}

interface ICreditManager
{
    void Calculate();
    void Save();
}

abstract class BaseCreditManager : ICreditManager
{
    public abstract void Calculate();

    public virtual void Save()
    {
        Console.WriteLine("Kaydedildi");
    }
}
class TeacherCreditManager : BaseCreditManager, ICreditManager
{
    public override void Calculate()
    {
        //Hesaplamalar
        Console.WriteLine("Öğretmen kredisi hesaplandı");
    }
    public override void Save()
    {
        Console.WriteLine("Öğretmen kredisi kaydedildi");
    }
}

//Ordudaki askerlere verilen kredi
class MilitaryCreditManager : BaseCreditManager, ICreditManager
{
    public override void Calculate()
    {
        Console.WriteLine("Asker kredisi hesaplandı");
    }
}

//SOLID
class Customer
{
    public Customer()
    {
        Console.WriteLine("Müşteri nesnesi başlatıldı..");
    }
    public int Id { get; set; }
    public string City { get; set; }
}

class Person : Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalIdentity { get; set; }
}

class Company : Customer
{
    public string CompanyName { get; set; }
    public string TaxNumber { get; set; }
}

//Katmanlı mimariler
class CustomerManager
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

