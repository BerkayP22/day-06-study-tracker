using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gün6
{
    public class StudySession 
    { 
        public string Topic { get; set; }
        public decimal Studyminutes { get; set; }
        public bool IsCompleted { get; set; }
    }
    internal class Program
    {
        static StudySession AddStudySession()
        {
            Console.Clear();
            StudySession session = new StudySession();
            Console.Write("Study Topic:"); session.Topic=Console.ReadLine();
            Console.Write("Study Minutes:"); session.Studyminutes=Convert.ToDecimal(Console.ReadLine());
            Console.Write("Is Completed? (y/n):"); session.IsCompleted=Console.ReadLine().ToLower()=="y";

            return session;
        }
        static void WiewReport(StudySession session)
        {
            Console.Clear();
            if (session == null) return;
            Console.WriteLine(
                $"Topic: {session.Topic}\n" +
                $"Minutes: {session.Studyminutes}\n" +
                $"Completed: {session.IsCompleted}"
            );
        }
        static void ProductivityCalculator()
        {
            Console.Clear();
            decimal hours; int days; decimal productivity;
            Console.Write("Enter the hours:"); hours = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter the days:"); days = Convert.ToInt32(Console.ReadLine());
            productivity = days / hours;
            Console.WriteLine($"Productivity: {productivity}"); Console.ReadLine();
        }
        static void Main(string[] args)
        {
            char k;
            StudySession session=new StudySession();
            do
            {
                Console.Clear();
                Console.WriteLine("=========== Study Session Tracker ===========");
                Console.WriteLine("1. Add Study Session");
                Console.WriteLine("2. Wiew Report");
                Console.WriteLine("3. Productivity Calculator");
                Console.WriteLine("4. Exit");
                k=Console.ReadKey().KeyChar;
                if (k == '1')
                {
                   session=AddStudySession();
                }
                else if (k == '2')
                {
                    WiewReport(session);
                }
                else if (k == '3')
                {
                    ProductivityCalculator();
                }
            } while (k != '4');
        }
    }
}
