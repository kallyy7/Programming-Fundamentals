using System;
using System.Linq;

namespace BankCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeee = Intern();
            Credit employeeFromTheBank = Employee();

            Console.WriteLine($"Emloyee Name: {employeee.FirstName} {employeee.LastName}");
            Console.WriteLine($"Working Years: {employeee.IntershipYears}");
            if(employeeFromTheBank.WorkingHere == "yes")
            {
                Console.WriteLine($"You can have {employeee.Lihva} % interest for the credit. And as a result of being an employee you have a {employeeFromTheBank.LihvaForEmployeesFromTheBank} % reduction");
                Console.WriteLine($"Your total card interest is: {(double)(employeee.Lihva * employeeFromTheBank.LihvaForEmployeesFromTheBank) / 100} %");
            }
            else
            {
                Console.WriteLine($"You can have {employeee.Lihva} % interest for the credit.");
            }

        }

        public static Employee Intern()
        {
            Console.Write("First and Last Name: ");
            string[] firstAndLastName = Console.ReadLine().Split().ToArray();
            Console.Write("Working Years: ");
            int intership = int.Parse(Console.ReadLine());
            
            int lihva = CreditInterest(intership);

            Employee empl = new Employee
            {
                FirstName = firstAndLastName[0],
                LastName = firstAndLastName[1],
                IntershipYears = intership,
                Lihva = lihva
            };

            return empl;
        }
        public static Credit Employee()
        {
            Console.WriteLine("Are you working here: Yes /No");
            string WorkingHereYesOrNo = Console.ReadLine();
            int bankWorkingYears = 0;
            if (WorkingHereYesOrNo.Equals("yes"))
            {
                Console.WriteLine("For How Many Years?");
                bankWorkingYears = int.Parse(Console.ReadLine());
            }
       

            Credit employeeFromBank = new Credit
            {
                WorkingHere = WorkingHereYesOrNo,
                LihvaForEmployeesFromTheBank = bankWorkingYears
            };

            return employeeFromBank;
        }
        static int CreditInterest(int intership)
        {
            int lihva = 0;
            if(intership < 1)
            {
                lihva = 5;
            }
            else if (intership < 2)
            {
                lihva = 7;
            }
            else
            {
                lihva = 9;
            }
            return lihva;
        }
        static int CreditInterestForEmployees(int inter)
        {
            int lihva = 0;
            if (inter < 3)
            {
                lihva = 10;
            }
            else if (inter < 10)
            {
                lihva = 30;
            }
            else
            {
                lihva = 50;
            }
            return lihva;
        }

    }

    public class Employee
    {
        internal int IntershipYears;
        //internal int Lihva;

        //public string FirstName { get; internal set; }
        //public string LastName { get; internal set; }

        private string firstName;
        public string FirstName
        {
            get => this.firstName;
            set => this.firstName = value;
        }
        private string lastName;
        public string LastName
        {
            get => this.lastName;
            set => this.lastName = value;
        }
        private int lihva;
        public int Lihva
        {
            get => this.lihva;
            set => this.lihva = value;
        }

    }
    public class Credit
    {
        public string WorkingHere { get; internal set; }
        public int LihvaForEmployeesFromTheBank { get; internal set; }
    }
}
