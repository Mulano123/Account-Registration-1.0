using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {

        private DelagateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;


        private DelagateNumber DelNumAge, DelNumContactNo, DelStudNo;
        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelagateText(StudentInfoClass.GetProgram);
            DelLastName = new DelagateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelagateText (StudentInfoClass.GetFirstName);
            DelMiddleName = new DelagateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelagateText(StudentInfoClass.GetAddress);

            DelNumAge = new DelagateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelagateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelagateNumber(StudentInfoClass.GetStudentNo);
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            label9.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            label10.Text = DelProgram(StudentInfoClass.Program);
            label11.Text = DelLastName(StudentInfoClass.LastName);
            label12.Text = DelFirstName(StudentInfoClass.FirstName);
            label13.Text = DelMiddleName(StudentInfoClass.MiddleName);
            label14.Text = DelNumAge(StudentInfoClass.Age).ToString();
            label15.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            label16.Text = DelAddress(StudentInfoClass.Address);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
