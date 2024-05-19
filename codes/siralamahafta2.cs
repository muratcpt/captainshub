using System;

namespace Sil1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  bool b1;        //1 bitlik
              Boolean b2;

              b1 = true;
              b2 = false;

             byte b3;    //1 Byte lık, 8 bitlik, işaretsiz tamsayı
                         //0 - 255
                         //Byte b3;

             sbyte b4;   //1 Byte, 8 bitlik, işaretli tamsayı
                         //-128,+127
             b3 = 156;
             b4 = -34;*/
            // short, int, long //işaretli 16,32,64 bitlik tamsayı
            //    ushort, uint, ulong;
            //Int16, Int32, Int64;
            //UInt16; UInt32;UInt64;
            /* Int16 x;
             UInt16 y;
             float, double, decimal;*/  //32,64,80 bitlik
                                        //Double; Decimal;
            /*  char x = '4';     
              string s = "engin şahin";
              char[] d = new char[5];
              int[] f = new int[5];*/

            //d[0] = '?';

            //  int[,] m = new int[3,4];
            // int[,,,] m2 = new int[3, 4,5,6];
            // m[0, 0] = 12;
            /*int[][] z = new int[3][];
             z[0] = new int[4];
             z[1] = new int[2];
             z[2] = new int[3];
             z[2][1] = 12;*/
            /*  Console.WriteLine("Bir sayı giriniz");
              int x = Convert.ToInt32(Console.ReadLine());
              if (x > 0)       //true   % --> mod
              {
                  Console.WriteLine("POZİTİF");
              }
              else if (x < 0)
              {
                  Console.WriteLine("NEGATİF");
              }
              else
              {
                  //yukarıdaki if deki şart true üretmiyorsa
                  //komutlar
                  Console.WriteLine("SIFIR");
              }
              Console.WriteLine("devam");*/

            /* if (f <= 0 && f > 0 || f == 0)
             {

             }
             else if (f==100)
             { 

             }
             else
             {

             }*/
            /* for (int i = 0; i < 10; i = 2 * i + 3) ;
              {
                 Console.WriteLine("merhaba");
              }*/

            /* for (int i = 5; i <= 1000; i = 2 * i + 3)
             {
                 Console.WriteLine(i);
             }*/

            /* while (b < 0) 
             { 

             }

             do {
                 komutlar
             } while (şart);*/

            //Console.Write("Merhaba");
            //Console.WriteLine("Merhaba"+" x");
            // Console.WriteLine(b3+"***"+b4);
            //string s1 = Console.ReadLine();
            /* int a = Console.Read();
             Console.WriteLine("Girilen değer: "+a);*/

            /* int a, b, c;
             Console.Write("1. Sayıyı Giriniz: ");
             string s1 = Console.ReadLine(); // "5"
             int a = int.Parse(s1);
             double x = double.Parse(s1);
             //a = Convert.ToInt32(s1);
             Console.Write("2. Sayıyı Giriniz: ");
             string s2 = Console.ReadLine(); // "3"
             b = Convert.ToInt32(s2);
             Console.Write(a+b); // "5"+"3" -->  "53"*/

            /* Console.Write("1. Sayıyı Giriniz: ");
             double d = Convert.ToDouble(Console.ReadLine());
             int x = Convert.ToInt32(d);
             Console.WriteLine("Tam sayı= "+x);*/
            // Convert.ToInt32(d); // d ondalıklı sayı ise, >=.5 yukarı, < aşağı
            //d=4.52    --> a=5
            //d=4.34    --> a=4
            /*Console.Write("2. Sayıyı Giriniz: ");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            //Console.Write(a + b); 
            Console.Write("Sonuç= "+c);*/

            /*Console.WriteLine("Aşağı="+Math.Floor(4.5));
            Console.WriteLine("Yukarı= "+Math.Ceiling(4.5));
            Console.WriteLine("Orta= "+Math.Round(5.5));*/

            //int[] d = new int[5];

            /*Array.Sort(d);//diziyi küçükten büyüğe sıralar
            Array.Reverse(d); //diziyi ters çevirir
            Array.Clear(d, 3, 6); // 3,4,5,6,7,8*/

            //Random r = new Random();
            //int a = r.Next(); // 0 ile +2 milyar 147..
            //int a = r.Next(10); // 0 ile max-1 arası
            //int a = r.Next(5,15); // min ile max-1 arası, 5,6,7,..,13,14
            //double a = r.NextDouble();
            //a = 23;
            //Console.WriteLine("Rastgele sayı= "+a.ToString());

            /* Random r = new Random(); //1. saniye ,2. dakika  ,3. saniye+dakika...                          
             for (int i = 0; i < 10; i++)
              {                
                 int d = r.Next(1,11);
                 Console.WriteLine(d);
              }*/
            /*Ödev
             * a,b aralığında tekrarsız olarak n tane üretip
             * ekrana yazan program
             * [1,20] arasında 15 tane
             */

            /* int[] d = new int[10];
             Random r = new Random();*/

            /* for (int i = 0; i < 10; i++)
             {
                 // int a = r.Next(1, 2000);
                 // d[i] = a;
                 d[i] = r.Next(1, 2000);
             }*/

            /*for (int i = 0; i < 10; i++)
            {
                Console.Write(d[i]+"  ");
            }*/
            // diziBilgiYaz(d);

            //rastgele tekrarsız sayı üretme - 1
            /* int n = 15;
             int[] d = new int[n];

             Random r = new Random();
             Console.WriteLine("For öncesi");
             int sayac = 0;
             for (int i = 0; i < n; i++)
             {
                 Console.WriteLine("i= "+i);
                 int deger;
                 bool varmi = false;
                 do
                 {
                     varmi = false;
                     deger = r.Next(1, 16);
                     sayac++;
                     Console.WriteLine(deger);
                     for (int j = 0; j < n; j++)
                     {
                         if (deger == d[j])
                         {
                             varmi = true;
                             break;
                             //continue;
                         }
                     }
                 } while (varmi == true);
                 d[i] = deger;

             }*/
            //rastgele tekrarsız sayı üretme - 2
            /* int n = 15;
             int[] d = new int[n];
             int indis = 20;
             int[] sayilar = new int[indis];

             int sayac = 0;
             Random r = new Random();

             for (int i = 0; i < indis; i++)
             {
                 sayilar[i] = i + 11;
             }

             for (int i=0;i<n;i++)
             {
                 int deger = r.Next(indis);
                 sayac++;
                 d[i] = sayilar[deger];
                 for (int j = deger; j < indis - 1; j++)
                 {
                     sayilar[j] = sayilar[j + 1];
                 }
                 indis--;
             }

             diziEkranaYaz(d);
             Console.WriteLine();
             Console.WriteLine(sayac);*/
            /* int[,,,] d = new int[4,15,3,6];
              var d = fonk();
              Console.WriteLine("Dizinin boyutu = "+d.Rank);*/
            int n = 15;
            int[] d = new int[n];
            int[] d2 = new int[n];
            int[] d3 = new int[n];
            Random r = new Random();
            int step = 0;

            for (int i = 0; i < n; i++)
            {
                d[i] = r.Next(10, 500);
            }
            d2 = d;
            d3 = d;
            diziEkranaYaz(d);
            Console.WriteLine();

            //bubble sort
             for (int j=n-2;j>=1;j--)
               {
                   for (int i = 0; i <= j; i++)
                   {
                       if (d[i] > d[i + 1])
                       {
                           int temp = d[i];
                           d[i] = d[i + 1];
                           d[i + 1] = temp;
                       }
                       step++;
                   }
                //diziEkranaYaz(d);
                //Console.WriteLine();
            }
            Console.WriteLine("Adım = " + step);
            step = 0;


            //selection sort
            for (int j = 0; j <= n - 2; j++)
             {
                 int kucukindis = j;
                 for (int i = j + 1; i <= n - 1; i++)
                 {
                     if (d2[i] < d2[kucukindis]) kucukindis = i;
                     step++;
                 }
                 //kucukindis = 5
                 int temp = d2[j];
                 d2[j] = d2[kucukindis];
                 d2[kucukindis] = temp;
                 //diziEkranaYaz(d);
                 //Console.WriteLine();
             }
            Console.WriteLine("Adım = " + step);
            step = 0;

            //insertion sort
            for (int j = 1; j <= n - 1; j++)
            {
                
                int temp = d3[j];
                int i = 0;
                for ( i = j - 1; i >= 0; i--)
                {

                    step++;
                    if (temp < d3[i]) d3[i + 1] = d3[i];
                    else break;
                   
                    
                }
                d3[i + 1] = temp;
               // diziEkranaYaz(d);
               // Console.WriteLine();
            }

            Console.WriteLine("Adım = "+step);
            diziEkranaYaz(d);
            Console.WriteLine();
            Console.ReadKey();
                        
        }

        static void diziEkranaYaz(int[] arr)
        {            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
            //cevap göndermek için --> return cevap;
        }
    }
}
