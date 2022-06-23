using System;
using Payroll;
namespace Payroll
{
    public interface IFullTimeEmployee
    {
        string FTE_name { get; set; }
        double FTE_salary { get; set; }
        string FTE_position { get; }
        void setFTEname(string ftename);
        void setFTEsalary(double ftesalary);
    }
    public interface IPartTimeEmployee
    {
        string PTE_name { get; set; }
        string PTE_position { get;}
        int PTE_NoOfHoursWorked { get; set; }
        double PTE_WagePerHour { get; set; }
        double PTE_salary { get; }
        void setPTEname(string ptename);
        void setPTENoOfHoursWorked(int pteNoOfHoursWorked);
        void setPTEWagePerHour(double pteWagePerHour);
    }

    public class Payroll: IFullTimeEmployee, IPartTimeEmployee
    {
        public string Payroll_ftename;
        public string Payroll_fteposition;
        public string Payroll_ptename;
        public string Payroll_pteposition;
        public double Payroll_ftesalary;
        public int Payroll_pteNoOfHoursWorked;
        public double Payroll_pteWagePerHour;
        public string FTE_name
        {
            get
            {
                return Payroll_ftename;
            }
            set
            {
                Payroll_ftename = value;
            }
        }
        public double FTE_salary
        {
            get
            {
                return Payroll_ftesalary;
            }
            set
            {
                Payroll_ftesalary = value;
            }
        }
        public string FTE_position
        {
            get
            {
                return "Full-Time Employee";
            }
        }
        public void setFTEname(string ftename)
        {
            this.FTE_name = ftename;
        }
        public void setFTEsalary(double ftesalary)
        {
            this.FTE_salary = ftesalary;
        }

        public string PTE_name
        {
            get
            {
                return Payroll_ptename;
            }
            set
            {
                Payroll_ptename = value;
            }
        }
        public string PTE_position
        {
            get
            {
                return "Part-Time Employee";
            }
        }
        public double PTE_salary
        {
            get
            {
                return PTE_NoOfHoursWorked * PTE_WagePerHour;
            }
        }
        public int PTE_NoOfHoursWorked
        {
            get
            {
                return Payroll_pteNoOfHoursWorked;
            }
            set
            {
                Payroll_pteNoOfHoursWorked = value;
            }
        }
        public double PTE_WagePerHour
        {
            get
            {
                return Payroll_pteWagePerHour;
            }
            set
            {
                Payroll_pteWagePerHour = value;
            }
        }
        public void setPTEname(string ptename)
        {
            this.PTE_name = ptename;
        }
        public void setPTENoOfHoursWorked(int pteNoOfHoursWorked)
        {
            this.PTE_NoOfHoursWorked = pteNoOfHoursWorked;
        }
        public void setPTEWagePerHour(double pteWagePerHour)
        {
            this.PTE_WagePerHour = pteWagePerHour;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Payroll P = new Payroll();
            Console.WriteLine("Payroll Program: ");
            Console.WriteLine("Are you a Full-Time Employee or a Part-Time Employee? ");
            Console.Write("Press F for Full-Time Employee and P for Part-Time Employee: ");
            String position = Console.ReadLine();
            Console.WriteLine("");
            if (position.Equals("F") || position.Equals("f"))
            {
                Console.WriteLine("So you are a Full-Time Employee.");
                Console.Write("Please input your name: ");
                P.setFTEname(Console.ReadLine());
                Console.Write("Please input your salary: ");
                P.setFTEsalary(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("");
                Console.WriteLine("You are: " + P.FTE_name);
                Console.WriteLine("Your position is: " + P.FTE_position);
                Console.WriteLine("Your salary is: " + "P" + String.Format("{0:0.00}", P.FTE_salary));
            }
            else if (position.Equals("P") || position.Equals("p"))
            {
                Console.WriteLine("So you are a Part-Time Employee.");
                Console.Write("Please input your name: ");
                P.setPTEname(Console.ReadLine());
                Console.Write("Please input your Hourly Wage: ");
                P.setPTEWagePerHour(Convert.ToDouble(Console.ReadLine()));
                Console.Write("Please input the number of hours you have worked: ");
                P.setPTENoOfHoursWorked(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("");
                Console.WriteLine("You are: " + P.PTE_name);
                Console.WriteLine("Your position is: " + P.PTE_position);
                Console.WriteLine("Your Hourly Wage is: " + "P" + String.Format("{0:0.00}", P.PTE_WagePerHour));
                Console.WriteLine("Your number of Hours Worked is: " + P.PTE_NoOfHoursWorked);
                Console.WriteLine("Your salary is: " + "P" + String.Format("{0:0.00}", P.PTE_salary));
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}
