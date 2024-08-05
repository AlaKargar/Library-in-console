using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AlaKargarLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //تعریف آرایه ها و دریافت تعداد دانش آموزان و کتاب ها
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(    "Welcome to our library!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter the count of your students: ");
            byte count = byte.Parse(Console.ReadLine());

            Console.Write("Enter the number of your books: ");
            byte count2 = byte.Parse(Console.ReadLine());

            string[] name = new string[count];
            string[] family = new string[count];

            string[] book = new string[count2];
            string[] sub= new string[count2];

            string s = "Hi!Enter your choice please(1-8): ";
            byte x = 0;

            while (x != 8)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkMagenta;

                Console.WriteLine("     Ala Kargar Library            ");
                Console.WriteLine("------------------------------");
                Console.WriteLine("1) Input user information");
                Console.WriteLine("2) User show");
                Console.WriteLine("3) Edit User");
                Console.WriteLine("4) Find student");
                Console.WriteLine("5) Input book");
                Console.WriteLine("6) Show books");
                Console.WriteLine("7) Show subject books");
                Console.WriteLine("8) Exit");
                Console.WriteLine("------------------------------");
                foreach (char c in s)
                {
                    Console.Write(c);
                    Thread.Sleep(50);
                }
                x = byte.Parse(Console.ReadLine());



                switch (x)
                {
                        //دریافت اطلاعات دانش آموزان
                    case 1:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write("Enter the name of the student {0}: ", i + 1);
                            name[i] = Console.ReadLine();

                            Console.Write("Enter the name of the student {0}: ", i + 1);
                            family[i] = Console.ReadLine();
                        }
                        break;

                    case 2:
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        //نمایش اطلاعات دانش آموزان
                        Console.WriteLine("Students List: ");
                        for (int j = 0; j < count; j++)
                        {
                            Console.WriteLine("Student{0}) {1} {2} ", j+1, name[j], family[j]);
                        }
                        break;

                    case 3:
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        //ویرایش اطلاعات دانش آموزان
                        Console.Write("please enter the student code, who you want edit: ");
                        int code = int.Parse(Console.ReadLine());
                        if (code < 1 || code > count + 1)
                        {
                            Console.WriteLine("Enter the new name: ");
                            name[code - 1] = Console.ReadLine();
                            Console.WriteLine("Enter the new family: ");
                            family[code - 1] = Console.ReadLine();
                        }
                        else
                            Console.WriteLine("Your student is Not Found!");
                        break;

                    case 4:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        //جستجوی دانش آموزان بر اساس نام خانوادگی
                        Console.Write("Enter the student family: ");
                        string st = Console.ReadLine();
                        int sh = Array.IndexOf(family, st);
                        if (sh >= 0)
                            Console.WriteLine("student code for {0} {1} is: {2}", name[sh], family[sh], sh+1);
                        else
                            Console.WriteLine("Your student is Not found!");

                        break;

                    case 5:
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        //دریافت اطلاعات کتاب ها
                        for (int i = 0; i < count2; i++)
                        {
                            Console.Write("Enter the name of book {0}: ", i + 1);
                            book[i] = Console.ReadLine();
                            Console.Write("Enter the subject of book {0}: ", i + 1);
                            sub[i] = Console.ReadLine();
                        }
                        break;

                    case 6:
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        //نمایش تمام کتاب ها
                        Console.WriteLine("Book List: ");
                        for (int j = 0; j < count2; j++)
                        {
                            Console.WriteLine("Book{0}) {1} {2} ", j+1, book[j], sub[j]);
                        }
                        break;

                    case 7:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        //نمایش کتاب های درخواستی
                        Console.Write("Enter the subject: ");
                        string item = Console.ReadLine();
                        bool f = false;
                        for (int i = 0; i < count2; i++)
                        
                            if (item == sub[i])
                            {
                                f = true;
                                Console.WriteLine("{0}) {1} {2}", i + 1, book[i], sub[i]);
                               
                            }
                            if (f == false)
                                Console.WriteLine("No book with this subject!");
                        break;

                    case 8:
                        Console.WriteLine("Bye!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid number!");
                        break;

                }
                Console.ReadKey();
            }
        }
    }
}
