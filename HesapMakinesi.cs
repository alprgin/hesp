using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class HesapMakinesi
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hos Geldiniz \n");
            Console.WriteLine("Toplama işlemi için \" + \" \n " +
                                      "Çıkarma işlemi için \" - \" \n " +
                                      "Çarpma işlemi için \" * \" \n " +
                                      "Bölme işlemi için \" / \" kullanınız. ");

            Console.WriteLine("Eski işlemleri görmek için h'yi");
            Console.WriteLine("Ekranı temizlemek için c'yi \n");
            Console.WriteLine("Devam etmek için bir tuş giriniz");
            string ilk = Console.ReadLine();
            if (ilk == "c")
            {
                Console.Clear();
            }
            else if (ilk == "h")
            {
                Console.WriteLine("Henüz işlem yapmadınız.");
            }

            double[] sayi1 = new double[999];
            double[] sayi2 = new double[999];
            string[] islemler = new string[999];
            double[] sonuclar = new double[999];

            for (int i = 1; ; i++) //i'yi islem sayısı olarak aldım dizilerde kullandım
            {
                Console.WriteLine("Bir sayı girin");
                try
                {
                    sayi1[i - 1] = Convert.ToDouble(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine("İşlem yapmak için yalnızca sayı giriniz");

                    try
                    {
                        sayi1[i - 1] = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Eski işlemleri görmek istiyorsanız h'yi giriniz");
                        string ara = Console.ReadLine();
                        if (ara == "h")
                        {
                            if (i == 1)
                            {
                                Console.WriteLine("Yapmış olduğunuz herhangi bir işlem bulunmamaktadır");
                            }
                            else
                            {
                                Console.WriteLine("Önceki yapmış olduğunuz işlemler:");
                                for (int j = 0; j < i - 1; j++)
                                {
                                    Console.WriteLine("{0} {1} {2}" + "= " + "{3}", sayi1[j], islemler[j], sayi2[j], sonuclar[j]); //buraya kadar ilk işlemde varsa geçmişi sorgulattı
                                }
                            }
                        }
                        else if (ara == "c")
                        {
                            Console.Clear();
                        }
                    }
                }


                Console.WriteLine("Yapmak istediğiniz dört işlemden birini giriniz"); //string sorunu
                islemler[i - 1] = Console.ReadLine();


                Console.WriteLine("İkinci sayıyı girin");
                try
                {
                    sayi2[i - 1] = Convert.ToDouble(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine("İşlem yapmak için yalnızca sayı giriniz");

                    try
                    {

                        sayi2[i - 1] = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Eski işlemleri görmek istiyorsanız h'yi giriniz");
                        Console.WriteLine("Ekranı temizlemek için c'yi giriniz");
                        string ara2 = Console.ReadLine();
                        if (ara2 == "h")
                        {
                            if (i == 1)
                            {
                                Console.WriteLine("Yapmış olduğunuz herhangi bir işlem bulunmamaktadır");
                            }
                            else
                            {
                                Console.WriteLine("Önceki yapmış olduğunuz işlemler:");
                                for (int k = 0; k < i - 1; k++)
                                {
                                    Console.WriteLine("{0} {1} {2}" + "= " + "{3}", sayi1[k], islemler[k], sayi2[k], sonuclar[k]); //buraya kadar ilk işlemde varsa geçmişi sorgulattı
                                }
                            }
                        }
                        else if (ara2 == "c")
                        {
                            Console.Clear();
                        }
                    }
                }

                if (islemler[i - 1] == "+")
                {
                    sonuclar[i - 1] = sayi1[i - 1] + sayi2[i - 1];
                    Console.WriteLine(sayi1[i - 1] + islemler[i - 1] + sayi2[i - 1] + "=" + sonuclar[i - 1]);
                }


                else if (islemler[i - 1] == "h")
                {
                    Console.WriteLine("Henüz bitmemiş olan bir işleminiz var. \n " +
                        "Yine de geçmiş işlemleri görmek istiyorsanız y' yi giriniz");
                    string ara_islem = Console.ReadLine();
                    if (ara_islem == "y")
                    {
                        {
                            if (i == 1)
                            {
                                Console.WriteLine("Yapmış olduğunuz herhangi bir işlem bulunmamaktadır");
                            }
                            else
                            {
                                for (int s = 0; s < i - 1; s++)
                                {
                                    if (islemler[i - 1] == "h")
                                    {
                                        Console.WriteLine("\n Bu işlem doğru tamamlanmadı! :");
                                    }
                                    Console.WriteLine("Önceki yapmış olduğunuz işlemler:");
                                    Console.WriteLine("{0} {1} {2}" + "= " + "{3}", sayi1[s], islemler[s], sayi2[s], sonuclar[s]);
                                }
                            }
                        }
                    }
                    else if (ara_islem == "c")
                    {
                        Console.Clear();
                    }
                }

                else if (islemler[i - 1] == "-")
                {
                    sonuclar[i - 1] = sayi1[i - 1] - sayi2[i - 1];
                    Console.WriteLine("{0} {1} {2}", sayi1[i - 1], islemler[i - 1], sayi2[i - 1] + "=" + sonuclar[i - 1]);
                }
                else if (islemler[i - 1] == "*")
                {
                    sonuclar[i - 1] = sayi1[i - 1] * sayi2[i - 1];
                    Console.WriteLine("{0} {1} {2}", sayi1[i - 1], islemler[i - 1], sayi2[i - 1] + "=" + sonuclar[i - 1]);
                }
                else if (islemler[i - 1] == "/")
                {
                    sonuclar[i - 1] = sayi1[i - 1] / sayi2[i - 1];
                    Console.WriteLine("{0} {1} {2}", sayi1[i - 1], islemler[i - 1], sayi2[i - 1] + "=" + sonuclar[i - 1]);
                }
            }
        }
    }
}

