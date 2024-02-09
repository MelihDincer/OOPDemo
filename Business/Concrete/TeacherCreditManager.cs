//IoC Container












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

