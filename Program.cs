CustomerManager customerManager = new CustomerManager(new Customer(), new TeacherCreditManager());
customerManager.GiveCredit();

TeacherCreditManager teacherCreditManager = new TeacherCreditManager();
teacherCreditManager.Save();

int[] numbers1 = new int[] { 1, 2, 3 };
int[] numbers2 = new int[] { 10, 20, 30 };
numbers1 = numbers2;
numbers2[0] = 1000;
Console.WriteLine(numbers1[0]);

CreditManager creditManager = new CreditManager();
creditManager.Save();

Customer customer = new Customer();
customer.Id = 1;
customer.City = "Kocaeli";

CustomerManager customerManager2 = new CustomerManager(customer, new TeacherCreditManager());
customerManager.Save(customer);
customerManager.Delete(customer);

Company company = new Company();
company.TaxNumber = "10000";
company.CompanyName = "Arçelik";
company.Id = 100;

CustomerManager customerManager3 = new CustomerManager(new Person(), new MilitaryCreditManager());

Person person = new Person();
person.FirstName = "Melih";
person.LastName = "Dinçer";
person.NationalIdentity = "123456";

Customer c1 = new Customer();
Customer c2 = new Person();
Customer c3 = new Company();

Console.ReadLine();