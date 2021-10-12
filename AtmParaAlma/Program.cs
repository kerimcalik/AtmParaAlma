using System;
using System.Collections.Generic;
using System.Text;

namespace AtmParaAlma
{
    class Program
    {
        /// <summary>
        /// ATM'den istenilen değeri mevcut para birimine göre 200, 100, 500, 200, 10, 5 lira ve 
        /// ayrıca 1 lira, 50 kuruş, 25 kuruş, 10 kuruş, 5 kuruş ve 1 kuruş olarak verimesini gerçekleştirir
        /// </summary>
        /// <param name="cekilecekDeger"></param>
        static void AskForMoney(double getMoney)
        {
            double[] moneyArray = new double[] { 200, 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
            Dictionary<string, double> moneyDictionary = new Dictionary<string, double>
            {
                {"200 lira", 200 },
                {"100 lira", 100 },
                {"50 lira", 50 },
                {"20 lira", 20 },
                {"10 lira", 10 },
                {"5 lira", 5 },
                {"1 lira", 1 },
                {"50 kr", 0.5 },
                {"25 kr", 0.25 },
                {"10 kr", 0.1 },
                {"5 kr", 0.05 },
                {"1 kr", 0.01 }
            };

            StringBuilder textToMoney = new StringBuilder();
            double kurusTotal = (int)(((decimal)getMoney - (int)getMoney) * 100);

            foreach (var item in moneyArray)
            {
                double count;
                if (item >= 1)
                {
                    count = Math.Floor(getMoney / item);
                    getMoney = Math.Floor(getMoney - (count * item));
                }
                else
                {
                    count = Math.Floor(kurusTotal / (item * 100));
                    kurusTotal = Math.Floor(kurusTotal - (count * (item * 100)));
                }

                textToMoney.AppendLine($"{count} adet {item} {(item >=1 ? "lira" : "kuruş")}");
            }

            var result = textToMoney.ToString();

            Console.Write(result);

            /*
            double
                toplam200 = 0d, toplam100 = 0d, toplam50 = 0d,
                toplam20 = 0d, toplam10 = 0d, toplam5 = 0d,
                toplam1 = 0d, toplam50Kurus = 0d, toplam25Kurus = 0d,
                toplam10Kurus = 0d, toplam5Kurus = 0d, toplam1Kurus = 0d;

            toplam200   = Math.Floor( cekilecekDeger / 200);
            toplam100   = Math.Floor((cekilecekDeger - (toplam200 * 200)) / 100);
            toplam50    = Math.Floor((cekilecekDeger - (toplam200 * 200 + toplam100 * 100)) / 50);
            toplam20    = Math.Floor((cekilecekDeger - (toplam200 * 200 + toplam100 * 100 + toplam50 * 50)) / 20);
            toplam10    = Math.Floor((cekilecekDeger - (toplam200 * 200 + toplam100 * 100 + toplam50 * 50 + toplam20 * 20)) / 10);
            toplam5     = Math.Floor((cekilecekDeger - (toplam200 * 200 + toplam100 * 100 + toplam50 * 50 + toplam20 * 20 + toplam10 * 10)) / 5);
            toplam1     = Math.Floor( cekilecekDeger - (toplam200 * 200 + toplam100 * 100 + toplam50 * 50 + toplam20 * 20 + toplam10 * 10 + toplam5 * 5));
            
            double kurusToplam = (int)(((decimal)cekilecekDeger - (int)cekilecekDeger) * 100);
            toplam50Kurus   = Math.Floor( kurusToplam / 50);
            toplam25Kurus   = Math.Floor((kurusToplam - (toplam50Kurus * 50)) / 25);
            toplam10Kurus   = Math.Floor((kurusToplam - (toplam50Kurus * 50 + toplam25Kurus * 25)) / 10);
            toplam5Kurus    = Math.Floor((kurusToplam - (toplam50Kurus * 50 + toplam25Kurus * 25 + toplam10Kurus * 10)) / 5);
            toplam1Kurus    = Math.Floor((kurusToplam - (toplam50Kurus * 50 + toplam25Kurus * 25 + toplam10Kurus * 10 + toplam5Kurus * 5)) / 1);

            Console.Write($"{cekilecekDeger} lirayı size; " +
                $"{toplam200} adet 200TL, " +
                $"{toplam100} adet 100TL, " +
                $"{toplam50} adet 50TL, " +
                $"{toplam20} adet 20TL, " +
                $"{toplam10} adet 10TL, " +
                $"{toplam5} adet 5TL, " +
                $"{toplam1} adet 1TL ve " +
                $"{toplam50Kurus} adet 50Kr, " +
                $"{toplam25Kurus} adet 25Kr, " +
                $"{toplam10Kurus} adet 10Kr, " +
                $"{toplam5Kurus} adet 5Kr ve " +
                $"{toplam1Kurus} adet 1Kr olarak vereceğim.");
            */


        }

        static void Main(string[] args)
        {
            AskForMoney(1997.77d);

            Console.Read();
        }
    }
}
