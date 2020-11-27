using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _261120PakjesLeveren.Models
{
    public static class Transactions       //HELPER CLASS
    {
        public static void BpostUI()
        {
            string line = new string('*', 55);

            Bpost bpost = new Bpost();

            Database db = new Database();
            Console.ForegroundColor = ConsoleColor.Yellow;
            bpost.DeliverAddress = "HalveMaanstraat 12 Gent";
            bpost.TransactionId = "123456789/2020/11";
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(db.GetAdress((int)Firma.Bpost));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(500);
            bpost.PackageRecived();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(500);
            bpost.PackagaOnTheWay();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Thread.Sleep(500);
            bpost.Deliverd();
            Console.ResetColor();
            Console.WriteLine($"\n{line}");
        }

        public static void DhlUI()
        {
            string line = new string('*', 55);

            Dhl dhl = new Dhl();

            Database db = new Database();
            Console.ForegroundColor = ConsoleColor.Yellow;
            dhl.DeliverAddress = "Zondernaamstraat 12 Antwerpen";
            dhl.TransactionId = "7788991122/2020/07";
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(db.GetAdress((int)Firma.Dhl));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(500);
            dhl.PackageRecived();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(500);
            dhl.PackagaOnTheWay();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Thread.Sleep(500);
            dhl.Deliverd();
            Console.ResetColor();
            Console.WriteLine($"\n{line}");

        }

        public static void NLpostUI()
        {
            string line = new string('*', 55);

            NLPost nlpost = new NLPost();

            Database db = new Database();
            Console.ForegroundColor = ConsoleColor.Yellow;
            nlpost.DeliverAddress = "hollandstraat 12 Vlissingen";
            nlpost.TransactionId = "33333344444/2020/09";
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(db.GetAdress((int)Firma.NLPost));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(500);
            nlpost.PackageRecived();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(500);
            nlpost.PackagaOnTheWay();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Thread.Sleep(500);
            nlpost.Deliverd();
            Console.ResetColor();
            Console.WriteLine($"\n{line}");

        }

        public static void ExpressUI()
        {
            string line = new string('*', 55);

            Express express = new Express();

            Database db = new Database();
            Console.ForegroundColor = ConsoleColor.Yellow;
            express.DeliverAddress = "Presstraat 33 Expresstad";
            express.TransactionId = "88888888888/2019/02";
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(db.GetAdress((int)Firma.Express));
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(500);
            express.PackageRecived();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(500);
            express.PackagaOnTheWay();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Thread.Sleep(500);
            express.Deliverd();
            Console.ResetColor();
            Console.WriteLine($"\n{line}");

        }

        public static int count;
    }
}
