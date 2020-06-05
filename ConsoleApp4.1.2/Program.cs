using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_19_1
{
    class Program
    {
        class Student
        {
            public string name { get; set; }
            public string lastname { get; set; }
            public string group { get; set; }
            public string adress { get; set; }
            public string passport { get; set; }
            public int age { get; set; }
            public double rating { get; set; }
            public string phone { get; set; }
            public Student()
            {
                this.name = "TempName";
                this.lastname = "TempLastName";
                this.group = "TempGroup";
                this.adress = "TempAdress";
                this.passport = "TempPaspourt";
                this.age = 10;
                this.rating = 90;
                this.phone = "111111111111";
            }
            public Student(string n, string ln, string gr, string a, string p, int ag, double r, string ph)
            {
                this.name = n;
                this.lastname = ln;
                this.group = gr;
                this.adress = a;
                this.passport = p;
                this.age = ag;
                this.rating = r;
                this.phone = ph;
            }

            public void StudentRating()
            {
                Console.WriteLine("Студент - " + this.name + " " + this.lastname + "\n");
                Console.WriteLine("Вік - " + this.age.ToString() + "\n");
                Console.WriteLine("Телефон - " + this.phone.ToString() + "\n");
                Console.WriteLine("Група - " + this.group + "\n");
                Console.WriteLine("Живе за адресою - " + this.adress + "\n");
                Console.WriteLine("Паспортнi данi - " + this.passport + "\n");
                Console.WriteLine("Має рейтинг - " + this.rating + "\n");
                if (this.rating < 75) { Console.WriteLine("Варто бiльше уваги придiляти навчанню!\n"); return; }
                else if (this.rating >= 75 && this.rating < 90) { Console.WriteLine("Можна вчитися краще!\n"); return; }
                else if (this.rating >= 90) { Console.WriteLine("Вiтаємо вiдмiнника!\n"); return; }
            }
        }
        static void Main(string[] args)
        {
            string name, ln, gr, ad, pas, ag, ra, phone;
            Console.WriteLine("Iм'я - ");
            name = Console.ReadLine();
            Console.WriteLine("Прiзвище - ");
            ln = Console.ReadLine();
            Console.WriteLine("Група - ");
            gr = Console.ReadLine();
            Console.WriteLine("Адреса - ");
            ad = Console.ReadLine();
            Console.WriteLine("Паспорт - ");
            pas = Console.ReadLine();
            Console.WriteLine("Вiк - ");
            ag = Console.ReadLine();
            Console.WriteLine("Середнiй бал - ");
            ra = Console.ReadLine();
            Console.WriteLine("Номер телефона - ");
            phone = Console.ReadLine();
            Student s1 = new Student(name, ln, gr, ad, pas, Convert.ToInt32(ag), Convert.ToDouble(ra), phone);

            s1.StudentRating();

            Console.ReadKey();
        }
    }
}
