using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TestLib;

namespace Test_Design
{
    public partial class Form_NewTest : Form
    {
        Test test;

        Question question;

        public Form_NewTest()
        {
            InitializeComponent();
            test = new Test();

            groupBox_CorrectAnswer.Visible = false;
            btn_AddAnswer.Enabled = false;
        }

        private void Form_NewTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Clear()
        {
            question = null;
            textBox_Question.Text = string.Empty;
            numericUpDown_Difficulty.Value = 1;
            textBox_Question.ReadOnly = false;
            btn_OK.Enabled = true;
            numericUpDown_Difficulty.Enabled = true;
            btn_AddAnswer.Enabled = false;
            checkBox_IsRight.Checked = false;
            checkBox_IsRight.Enabled = true;

            textBox_Author.Text = string.Empty;
            textBox_FileName.Text = string.Empty;
            textBox_Title.Text = string.Empty;

            textBox_Qty.Text = "0";


        }

        private bool CheckAnswer(Question question)
        {
            foreach (var item in question.Answer)
                if (item.IsRight == "True") return true;

            return false;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Author.Text))
            {
                MessageBox.Show("Enter auhtor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textBox_Title.Text))
            {
                MessageBox.Show("Enter title", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(textBox_Question.Text))
            {
                MessageBox.Show("Enter question", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            question = new Question();
            question.Answer = new List<Answer>();
            question.Description = textBox_Question.Text;
            question.Difficulty = (int)numericUpDown_Difficulty.Value;

            textBox_Question.ReadOnly = true;
            btn_OK.Enabled = false;
            numericUpDown_Difficulty.Enabled = false;

            btn_AddAnswer.Enabled = true;
        }

        private void btn_AddAnswer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Answer.Text))
            {
                MessageBox.Show("Enter answer", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Answer answer = new Answer();
            answer.Description = textBox_Answer.Text;

            if (!checkBox_IsRight.Enabled)
            {
                answer.IsRight = "False";
            }
            else answer.IsRight = checkBox_IsRight.Checked.ToString();



            question.Answer.Add(answer);

            if (checkBox_IsRight.Checked) checkBox_IsRight.Enabled = false;

            TextBox t = new TextBox();
            t.Width = 150;
            t.Text = textBox_Answer.Text;
            t.ReadOnly = true;
            flowLayoutPanel1.Controls.Add(t);



            textBox_Answer.Text = string.Empty;

        }

        private void btn_ChekedListOK_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0) return;

            question.Answer[comboBox1.SelectedIndex].IsRight = "True";

            groupBox_CorrectAnswer.Visible = false;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (question == null) return;

            if (question.Answer.Count <= 1)
            {
                MessageBox.Show("There must be at least two answers", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!CheckAnswer(question))
            {
                MessageBox.Show("Choose one correct answer", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBox_CorrectAnswer.Visible = true;

                foreach (var item in question.Answer)
                    comboBox1.Items.Add(item.Description);

                return;
            }

            test.Question.Add(question);

            comboBox1.Items.Clear();
            textBox_Qty.Text = test.Question.Count.ToString();

            flowLayoutPanel1.Controls.Clear();
            btn_OK.Enabled = true;

            question = null;
            textBox_Question.Text = string.Empty;
            numericUpDown_Difficulty.Value = 1;
            textBox_Question.ReadOnly = false;
            btn_OK.Enabled = true;
            numericUpDown_Difficulty.Enabled = true;
            btn_AddAnswer.Enabled = false;
            checkBox_IsRight.Checked = false;
            checkBox_IsRight.Enabled = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Author.Text) || string.IsNullOrEmpty(textBox_Title.Text))
            {
                MessageBox.Show("Enter info");
                return;
            }

            if (string.IsNullOrEmpty(textBox_FileName.Text))
            {
                MessageBox.Show("Enter filename", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            test.Author = textBox_Author.Text;
            test.TestName = textBox_Title.Text;

            if (!Directory.Exists("Tests")) Directory.CreateDirectory("Tests");

            XmlSerializer xs = new XmlSerializer(typeof(Test), new XmlRootAttribute("Test"));
            if (File.Exists(textBox_FileName.Text))
            {
                using (FileStream fs = new FileStream(@"Tests\" + textBox_FileName.Text, FileMode.Truncate))
                {
                    test.Qty_questions = test.Question.Count;

                    xs.Serialize(fs, test);
                }
            }
            else
            {
                using (FileStream fs = new FileStream(@"Tests\" + textBox_FileName.Text + ".xml", FileMode.OpenOrCreate))
                {
                    test.Qty_questions = test.Question.Count;

                    xs.Serialize(fs, test);
                }
            }

            Clear();

            MessageBox.Show("File saved");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
