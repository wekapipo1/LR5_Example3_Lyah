using System;
interface IStat
{
    //методи
    double Help(); //грошей на одну дитину
    string Info(); //інформація про об'єкт
}
class Kindergarten : IStat
{
    //дитячий садок
    double fond; //Держ фонд на весь д/с
    int n; //кількість дітей в садку
    public Kindergarten(double fond, int n)
    {
        this.fond = fond; this.n = n;
    }
    //реалізація методів
    public string Info()
    {
        return $"Д/сад. Держ фонд = {fond} кiлькiсть дiтей = {n}";
    }
    public double Help()
    {
        return fond/n;
    }
}
class Orphanage : IStat
{
    //дитячий будинок
    double fond; //Держ фонд на весь д/б
    int n; //кількість дітей в дитячому будинку
    double sponsor; //допомога спонсорів
    public Orphanage(double fond, int n, double sponsor)
    {
        this.fond = fond; this.n = n; this.sponsor = sponsor;
    }
    //реалізація методів
    public string Info()
    {
        return $"Д/буд. Загальний фонд = {fond} кiлькiсть дiтей = {n}" +
            $" Допомога спонсорiв = {sponsor}";
    }
    public double Help()
    {
        return (fond + sponsor) / n;
    }
}
class Program
{
    static void Main(string[] args)
    {
        IStat obj = null; //змінна інтерфесного класу
        Random o= new Random();
        double f, m, s; int k;
        for (int i=1; i<=5; i++)
        {
            f = o.Next(1, 3); //який об'єкт
            m=o.Next(1, 9)*10000; //Держ фонд
            k = o.Next(1, 5) * 100; //кількість дітей
            if (f == 1)
            {
                obj =new Kindergarten(m,k); // дит/сад
                Console.WriteLine(obj.Info());
            }
            else
            {
                s=o.Next(1,5)*100000; //допомога спонсорів
                obj = new Orphanage(m,k,s); // дит/буд
                Console.WriteLine(obj.Info());
            }
            double p = obj.Help();
            Console.WriteLine("Грошей на одну дитину = {0:F2}", p);
        }
    }
}

