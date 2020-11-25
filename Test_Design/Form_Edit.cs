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
    public partial class Form_Edit : Form
    {
        Test test;
        OpenFileDialog open = new OpenFileDialog();
        int indexIsRightAnswer = 1;

        public Form_Edit()
        {
            InitializeComponent();
        }

        private void Form_Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_File_Click(object sender, EventArgs e)
        {
            textBox_Answer.Text = string.Empty;
            textBox_Author.Text = string.Empty;
            textBox_Title.Text = string.Empty;
            comboBox1.Items.Clear();
            checkBox_IsRight.Checked = false;

            listBox1.Items.Clear();
            XmlSerializer xs = new XmlSerializer(typeof(Test), new XmlRootAttribute("Test"));

            open.Filter = "*.xml|*.xml";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream fs = new FileStream(open.FileName, FileMode.OpenOrCreate))
                    {
                        test = (Test)xs.Deserialize(fs);
                        foreach (var item in test.Question)
                            listBox1.Items.Add(item.Description);

                        textBox_Author.Text = test.Author;
                        textBox_Title.Text = test.TestName;
                        textBox_Qty.Text = test.Qty_questions.ToString();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.Clear();
                comboBox1.Text = string.Empty;
                textBox_Answer.Text = string.Empty;
                checkBox_IsRight.Checked = false;

                var res = test.Question.Where(x => x.Description == listBox1.SelectedItem.ToString()).FirstOrDefault();

                textBox_Question.Text = res.Description;

                numericUpDown_Difficulty.Value = res.Difficulty;

                foreach (var item in res.Answer)
                {
                    comboBox1.Items.Add(item.Description);
                }
            }
            catch { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;
            var res = test.Question[listBox1.SelectedIndex].Answer.Where(x => x.Description == comboBox1.SelectedItem.ToString()).FirstOrDefault();
            textBox_Answer.Text = res.Description;
            if (res.IsRight == "True") checkBox_IsRight.Checked = true;
            if (res.IsRight == "False") checkBox_IsRight.Checked = false;

            for (int i = 0; i < test.Question[listBox1.SelectedIndex].Answer.Count; i++)
                if (test.Question[listBox1.SelectedIndex].Answer[i].IsRight == "True")
                    indexIsRightAnswer = i;
        }

        private void btn_EditQuestion_Click(object sender, EventArgs e)
        {
            if (textBox_Question.Text == string.Empty || listBox1.SelectedIndex < 0) return;

            test.Question[listBox1.SelectedIndex].Description = textBox_Question.Text;
            test.Question[listBox1.SelectedIndex].Difficulty = (int)numericUpDown_Difficulty.Value;
            listBox1.Items[listBox1.SelectedIndex] = textBox_Question.Text;
        }

        private void btn_RemoveQuestion_Click(object sender, EventArgs e)
        {
            if (textBox_Question.Text == string.Empty || listBox1.SelectedIndex < 0) return;

            test.Question.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            textBox_Question.Text = string.Empty;
            numericUpDown_Difficulty.Value = 1;
        }

        private void btn_EditAnswer_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || comboBox1.SelectedIndex < 0 || textBox_Answer.Text == string.Empty) return;

            test.Question[listBox1.SelectedIndex].Answer[comboBox1.SelectedIndex].Description = textBox_Answer.Text;

            var res = test.Question[listBox1.SelectedIndex];

            if (checkBox_IsRight.Checked)
            {
                test.Question[listBox1.SelectedIndex].Answer[indexIsRightAnswer].IsRight = "False";
                test.Question[listBox1.SelectedIndex].Answer[comboBox1.SelectedIndex].IsRight = "True";
            }

            test.Question[listBox1.SelectedIndex].Answer[comboBox1.SelectedIndex].IsRight = checkBox_IsRight.Checked.ToString();
            comboBox1.Items[comboBox1.SelectedIndex] = textBox_Answer.Text;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0 || comboBox1.SelectedIndex < 0 || textBox_Answer.Text == string.Empty) return;

            if (test.Question[listBox1.SelectedIndex].Answer[comboBox1.SelectedIndex].IsRight == "True")
            {
                MessageBox.Show("Еhe correct answer cannot be delete");
                return;
            }

            test.Question[listBox1.SelectedIndex].Answer.RemoveAt(comboBox1.SelectedIndex);

            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (open.FileName == string.Empty) return;

            XmlSerializer xs = new XmlSerializer(typeof(Test), new XmlRootAttribute("Test"));

            try
            {
                using (FileStream fs = new FileStream(open.FileName, FileMode.Truncate))
                {
                    xs.Serialize(fs, test);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            this.Hide();
            form.ShowDialog();
        }
    }
}
