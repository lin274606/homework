using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Form_M26_array : Form
    {
        public Form_M26_array()
        {
            InitializeComponent();
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            int[]arr=new int[5];
            int num=1;
            string result = "";
            for(int i=0; i<arr.Length; i++)
            {
                arr[i]+=num++;
                result += arr[i]+"\n";
            }
            MessageBox.Show(result);
        }

        private void btn2Darray_Click(object sender, EventArgs e)
        {
            int[,] arr =
            {
                {1,2,3,},
                {4,5,6}
            };
            string result = "";
            for(int i=0 ; i<arr.GetLength(0) ; i++)
            {
                for(int j=0 ; j<arr.GetLength(1) ; j++)
                {
                    result += $"arr[{i} , {j}] -> {arr[i,j]}\n";
                }
            }
            MessageBox.Show(result);
        }

        private void btnArrMember_Click(object sender, EventArgs e)
        {
            Member[] members=new Member[2];
            members[0] = new Member();
            members[0].Name = "Joseph";
            members[0].Age = 30;
            members[1] = new Member();
            members[1].Name = "Caesar";
            members[1].Age = 28;
            string result = "";
            for(int i=0; i < members.Length; i++)
            {
                result+= $"{members[i].Name} , {members[i].Age}\n";
            }
            MessageBox.Show(result);

        }

        private void btnMethodArray_Click(object sender, EventArgs e)
        {
            int[] newArr = CreateNewArray(20);
            string result = "";
            foreach (int num in newArr)
            {
                result += $"{num:D2}\n";
            }
            MessageBox.Show(result);
        }
        int[] CreateNewArray(int Len)
        {
            int[] arr = new int[Len];
            for (int i = 0; i < arr.Length;) 
            {
                arr[i] = ++i;
            }
            return arr;
        }
    }
}
