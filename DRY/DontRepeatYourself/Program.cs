class Program
{
    public static void Main(string[] args)
    {
        
    }

    public const int TaxaServ = 10;
    public const int Hosp = 200;
    public const int Cafe = 30;
    public const int Almoco = 70;
    public const int Janta = 80;
    public const int VIP = 500;

    public static int ServClasseD()
    {
        return TaxaServ + Hosp;
    }

    public static int ServClasseC()
    {
        return TaxaServ + Hosp + Cafe + Almoco;
    }

    public static int ServClasseB()
    {
        return TaxaServ + Hosp + Cafe + Almoco + Janta;
    }

    public static int ServClasseA()
    {
        return TaxaServ + Hosp + Cafe + Almoco + Janta + VIP;
    }


}

