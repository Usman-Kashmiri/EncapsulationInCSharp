using System;

namespace EncapsulationInCSharp
{
    class employee
    {
        int emp_id;
        string emp_name;

        public void setEmpId(int id)
        {
            if (emp_id >= 0)
            {
                this.emp_id = id;
            } else
            {
                Console.WriteLine("Employee id cannot be a negative number...!");
            }
        }

        public void getEmpId()
        {
            if (emp_id >= 0)
            {
                Console.WriteLine("Emplpoyee id is: {0}", this.emp_id);
            }
        }

        public void setEmpName(string Name)
        {
            if (string.IsNullOrEmpty(Name) == true)
            {
                Console.WriteLine("Employee name is required...!");
            } else
            {
                this.emp_name = Name;
            }
        }

        public void getEmpName()
        {
            if (string.IsNullOrEmpty(emp_name) == true)
            {
               // Console.WriteLine("Employee name is required...!");
            }
            else
            {
                Console.WriteLine("Emplpoyee name is: {0}", this.emp_name);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            employee empobj = new employee();
            Console.WriteLine("Please enter employee id:");
            empobj.setEmpId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter employee name:");
            empobj.setEmpName(Console.ReadLine());
            empobj.getEmpId();
            empobj.getEmpName();
            Console.ReadLine();
        }
    }
}
