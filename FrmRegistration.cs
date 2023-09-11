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
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StudentInfoClass.StudentNo = Convert.ToInt64(textBox1.Text);
            StudentInfoClass.Program = comboBox1.Text.ToString();
            StudentInfoClass.LastName = textBox2.Text.ToString();
            StudentInfoClass.FirstName = textBox3.Text.ToString();
            StudentInfoClass.MiddleName = textBox4.Text.ToString();
            StudentInfoClass.Age = Convert.ToInt64(textBox5.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(textBox6.Text);
            StudentInfoClass.Address = textBox7.Text.ToString();

            FrmConfirm frmC = new FrmConfirm();

            if(frmC.ShowDialog() == DialogResult.OK)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                comboBox1.SelectedIndex = -1;

            }

        }
    }
}
