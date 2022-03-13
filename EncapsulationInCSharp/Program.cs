using System;

namespace EncapsulationInCSharp
{
    class employee
    {
        int emp_id;
        string emp_name;

        public void setEmpId(int id)
        {
            this.emp_id = id;
        }

        public void getEmpId()
        {
            Console.WriteLine("Emplpoyee id is: {0}",this.emp_id);
        }

        public void setEmpName(string Name)
        {
            this.emp_name = Name;
        }

        public void getEmpName()
        {
            Console.WriteLine("Emplpoyee name is: {0}", this.emp_name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            employee empobj = new employee();
            empobj.setEmpId(1);
            empobj.getEmpId();
            empobj.setEmpName("Kanshif");
            empobj.getEmpName();
            Console.ReadLine();
        }
    }
}
