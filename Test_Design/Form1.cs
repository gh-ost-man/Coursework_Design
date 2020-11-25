using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_NewTest_Click(object sender, EventArgs e)
        {
            Form_NewTest newTest = new Form_NewTest();
            this.Hide();
            newTest.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Form_Edit edit = new Form_Edit();
            this.Hide();
            edit.ShowDialog();
        }
    }
}
