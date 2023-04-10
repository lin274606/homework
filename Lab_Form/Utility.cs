using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Myclass
    {
        void Method01()
        {
            MessageBox.Show("Method01");
        }
        private void Method02()
        {
            MessageBox.Show("Method02");
        }
        public void Method03()
        {
            MessageBox.Show("Method03 public");
        }
        internal void Method04()
        {
            MessageBox.Show("Method04 internal");
        }
        public void Method05()
        {
            Method01();
            Method02();
        }

    }
    public class Member
    {
        public string Name;
        public int Age;
    }
    public class LabStatic
    {
        public static int StaticNumber;
        public int InstanceNumber;
    }
    public enum UserRole
    {
        Admin,
        User
    }
    public struct Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Employee(string EmployeeName,int EmployeeAge)
        {
            Name = EmployeeName;
            Age = EmployeeAge;
        }
    }
    public struct Product
    {
        public string Name;
        public decimal Price;
        public int Amount;
    }
}
