//IoC Container










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