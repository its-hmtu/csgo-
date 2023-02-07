
// BAI TAP VE NHA CONG NGHE .NET N04 - HOANG MINH TU - 21011638

using System;

namespace ConsoleApp
{
    class Program
    {
        static void bai1()
        {
            // bai 1 kiem tra co phai la tam giac can hay khong
            int a, b, c;
            Console.WriteLine("-- Bai 1 --");
            Console.Write("Nhap 3 canh cua tam giac: ");
            var num = Console.ReadLine().Split();
            a = Int32.Parse(num[0]);
            b = Int32.Parse(num[1]);
            c = Int32.Parse(num[2]);

            if (a == b && b == c && a == c)
            {
                Console.WriteLine("Khong phai la tam giac can. Day la tam giac deu.");
            }

            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("Tam giac can");
            }

            else
            {
                Console.WriteLine("Tam giac khong can");
            }

            Console.WriteLine();
        }

        static void bai2()
        {
            // bai 2
            double a, b;
            Console.WriteLine("-- Bai 2 --");
            Console.Write("Nhap 2 so a, b: ");
            var num = Console.ReadLine().Split();

            a = Double.Parse(num[0]);
            b = Double.Parse(num[1]);

            if (a == 0 && b == 0) Console.WriteLine("Phuong trinh vo so nghiem");
            else if (a == 0) Console.WriteLine("Phuong trinh vo nghiem");
            else Console.WriteLine("Phuong trinh co nghiem x = " + (-b / a));

            Console.WriteLine();
        }

        static void bai3()
        {
            // bai 3
            double a, b, c;
            Console.WriteLine("-- Bai 3 --");
            Console.Write("Nhap 3 so a, b, c: ");
            var num = Console.ReadLine().Split();

            a = Double.Parse(num[0]);
            b = Double.Parse(num[1]);
            c = Double.Parse(num[2]);

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                }
                else
                {
                    Console.WriteLine("Phuong trinh co 1 nghiem x = " + ((-c) / b));
                }
            }
            else
            {
                double delta = (b * b) - (4 * a * c);

                double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                double x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                if (delta < 0) Console.WriteLine("Phuong trinh vo nghiem");
                else if (delta == 0) Console.WriteLine("Phuong trinh co nghiem kep x = " + ((-b) / 2 * a));
                else
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet");
                    Console.Write("x1 = " + x1 + " va " + "x2 = " + x2);
                }
            }
            
            Console.WriteLine();
        }

        static void bai4()
        {
            Console.WriteLine("-- Bai 4 --");
            Console.Write("Nhap so luong phan tu mang: ");

            int n;
            int k;
            var num = Console.ReadLine().Split();
            n = Int32.Parse(num[0]);

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Arr[" + i + "]");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Mang da nhap: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            
            Console.Write("\nNhap k: ");
            var num1 = Console.ReadLine().Split();
            k = Int32.Parse(num1[0]);

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (k == arr[i])
                {
                    count++;
                }
                
            }
            if (count == 0)
            {
                Console.WriteLine("Khong co gia tri k = " + k + " trong mang");
            }
            else
            {
                Console.WriteLine("Co gia tri k = " + k + " trong mang. So lan xuat hien: " + count);
            }


            Console.WriteLine();
        }

        static void bai5()
        {
            Console.WriteLine("-- Bai 5 --");
            Console.Write("Nhap so luong phan tu mang: ");

            int n;
            int temp;
            var num = Console.ReadLine().Split();
            n = Int32.Parse(num[0]);

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Arr[" + i + "]");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i < n; i++)
            {
                if (arr[i] >= max) max = arr[i];
                if (arr[i] <= min) min = arr[i];
            }

            Console.WriteLine("Gia tri lon nhat: " + max);
            Console.WriteLine("Gia tri nho nhat: " + min);

            // tang dan
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.Write("-- Mang da nhap sau khi sap xep tang dan: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            // giam dan
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.Write("\n-- Mang da nhap sau khi sap xep giam dan: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            bai1();
            bai2();
            bai3();
            bai4();
            bai5();
        }
    }
}


