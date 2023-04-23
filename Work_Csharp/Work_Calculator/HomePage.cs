using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Work_Loop;
using Work_Struct;

namespace Work_Calculator
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        Form saveform = null;
        private void Checkform(Form form)
        {
            if (saveform != null) 
            {
                saveform.Close();
                saveform = null;
            }
        }
        private void Addform(Form addform)
        {
            addform.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(addform);
            addform.Show();
            saveform = addform;
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            Work_Hello hello = new Work_Hello();
            Checkform(hello);
            Addform(hello);
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Work_Loan loan = new Work_Loan();
            Checkform(loan);
            Addform(loan);
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            POS pos = new POS();
            Checkform(pos);
            Addform(pos);
        }

        private void btnStruct_Click(object sender, EventArgs e)
        {
            StudentStruct studentstruct = new StudentStruct();
            Checkform(studentstruct);
            Addform(studentstruct);
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            StudentGrades grade = new StudentGrades();
            Checkform(grade);
            Addform(grade);
        }

        private void btnGradelist_Click(object sender, EventArgs e)
        {
            StudentGrade_List gradelist = new StudentGrade_List();
            Checkform(gradelist);
            Addform(gradelist);
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            Checkform(cal);
            Addform(cal);
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            Loop loop = new Loop();
            Checkform(loop);
            Addform(loop);
        }

        private void btnXO_Click(object sender, EventArgs e)
        {
            Work_XOgame game = new Work_XOgame();
            Checkform(game);
            Addform(game);
        }

        private void btnSaver_Click(object sender, EventArgs e)
        {
            ScreenSaver saver = new ScreenSaver();
            Checkform(saver);
            saver.Show();
        }

        private void btnViewer_Click(object sender, EventArgs e)
        {
            PictureViewer viewer = new PictureViewer();
            Checkform(viewer);
            Addform(viewer);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Work_Guess guess = new Work_Guess();
            Checkform(guess);
            Addform(guess);
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            AlarmClock alarm = new AlarmClock();
            Checkform(alarm);
            Addform(alarm);
        }
    }
}
