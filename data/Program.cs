using System;
using System.Linq;
namespace data
{
    class Program
    {
        struct Doma
        {
            public string nameK;
            public string name;
            public int metr;
            public DateTime nach;
            public DateTime kon;
            public string sost;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сколько проектов");
            int k = int.Parse(Console.ReadLine());
            Doma[] doms = new Doma[k];
            for (int i = 0; i < doms.Length; i++)
            {
                
                Console.Write("Введите название компании: ");
                doms[i].nameK = Console.ReadLine();
                Console.Write("Введите название объекта: ");
                doms[i].name = Console.ReadLine();
                Console.Write("Введите сколько метров: ");
                doms[i].metr = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите дату начала: ");
                Console.WriteLine("День");
                int d = int.Parse(Console.ReadLine());
                Console.WriteLine("Месяц");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine("Год");
                int g = int.Parse(Console.ReadLine());                            
                doms[i].nach = new DateTime(g, m, d);
                Console.WriteLine("Введите дату конца: ");
                Console.WriteLine("День");
                int d1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Месяц");
                int m1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Год");
                int g1 = int.Parse(Console.ReadLine());
                doms[i].kon = new DateTime(g1, m1, d1);
                if (doms[i].nach > doms[i].kon)
                {            
                   
                    doms[i].sost = "Закончено строительсво";
                }
                else
                {
                    doms[i].sost = "Сторится";
                }
                foreach (Doma item in doms)
                {
                    Console.WriteLine("Вывести все или в этому году");
                    string f = Console.ReadLine();
                    if (f == "все")
                    {
                        Console.WriteLine(item.nameK + ", " + item.name + ", " + item.metr + "метров, Дата начала:" + item.nach + ", Дата конца" + item.kon + ", " + item.sost);
                    }
                    else
                    {
                        if (g1 == 2021)
                        {
                            Console.WriteLine(item.nameK + ", " + item.name + ", " + item.metr + "метров, Дата начала:" + item.nach + ", Дата конца" + item.kon + ", " + item.sost);
                        }
                    }
                }
            }
        }
    }
}
