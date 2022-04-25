using SkandinavAdat.Data;
using SkandinavAdat.Models;
using System;
using System.IO;
using System.Linq;

namespace SkandinavLottoFeltolt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SkandinavAdatContext db = new SkandinavAdatContext();

            //if (!db.LottoSzamok.Any())
            //{
            string[] sorok = File.ReadAllLines("SkandinavLottoSzamok.csv").Skip(1).ToArray();
            int[] tombSzam = new int[7];
            foreach (var sor in sorok)
            {
                string[] tombSor = sor.Split(";");

                for (int i = 0; i <= 7; i++)
                {
                    tombSzam[i] = int.Parse(tombSor[i]);
                    db.LottoSzamok.Add(new LottoSzam(tombSzam));
                }

                for (int i = 0; i <= 7; i++)
                {
                    tombSzam[i] = int.Parse(tombSor[i + 7]);
                    db.LottoSzamok.Add(new LottoSzam(tombSzam));
                }
            }
            db.SaveChanges();
            //}
            //    else
            //    {
            //        Console.WriteLine("A Lottó Számok tábla már tartalmaz adatokat!");
            //    }


            Console.ReadKey();
        }
    }
}
