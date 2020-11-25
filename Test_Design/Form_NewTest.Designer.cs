namespace Test_Design
{
    partial class Form_NewTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Answer = new System.Windows.Forms.GroupBox();
            this.checkBox_IsRight = new System.Windows.Forms.CheckBox();
            this.btn_AddAnswer = new System.Windows.Forms.Button();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Qty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.groupBox_Question = new System.Windows.Forms.GroupBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.numericUpDown_Difficulty = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Question = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox_CorrectAnswer = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_ChekedListOK = new System.Windows.Forms.Button();
            this.textBox_FileName = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.groupBox_Answer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Question.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Difficulty)).BeginInit();
            this.groupBox_CorrectAnswer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Answer
            // 
            this.groupBox_Answer.Controls.Add(this.checkBox_IsRight);
            this.groupBox_Answer.Controls.Add(this.btn_AddAnswer);
            this.groupBox_Answer.Controls.Add(this.textBox_Answer);
            this.groupBox_Answer.Controls.Add(this.label5);
            this.groupBox_Answer.Controls.Add(this.btn_Next);
            this.groupBox_Answer.Location = new System.Drawing.Point(251, 199);
            this.groupBox_Answer.Name = "groupBox_Answer";
            this.groupBox_Answer.Size = new System.Drawing.Size(409, 113);
            this.groupBox_Answer.TabIndex = 26;
            this.groupBox_Answer.TabStop = false;
            this.groupBox_Answer.Text = "Answers";
            // 
            // checkBox_IsRight
            // 
            this.checkBox_IsRight.AutoSize = true;
            this.checkBox_IsRight.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox_IsRight.Location = new System.Drawing.Point(87, 55);
            this.checkBox_IsRight.Name = "checkBox_IsRight";
            this.checkBox_IsRight.Size = new System.Drawing.Size(59, 17);
            this.checkBox_IsRight.TabIndex = 3;
            this.checkBox_IsRight.Text = "IsRight";
            this.checkBox_IsRight.UseVisualStyleBackColor = true;
            // 
            // btn_AddAnswer
            // 
            this.btn_AddAnswer.Location = new System.Drawing.Point(87, 78);
            this.btn_AddAnswer.Name = "btn_AddAnswer";
            this.btn_AddAnswer.Size = new System.Drawing.Size(75, 23);
            this.btn_AddAnswer.TabIndex = 2;
            this.btn_AddAnswer.Text = "Add";
            this.btn_AddAnswer.UseVisualStyleBackColor = true;
            this.btn_AddAnswer.Click += new System.EventHandler(this.btn_AddAnswer_Click);
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Location = new System.Drawing.Point(87, 29);
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(315, 20);
            this.textBox_Answer.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Answer";
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(180, 78);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 7;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Qty);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_Title);
            this.groupBox1.Controls.Add(this.textBox_Author);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 113);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // textBox_Qty
            // 
            this.textBox_Qty.Location = new System.Drawing.Point(90, 78);
            this.textBox_Qty.Name = "textBox_Qty";
            this.textBox_Qty.ReadOnly = true;
            this.textBox_Qty.Size = new System.Drawing.Size(44, 20);
            this.textBox_Qty.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Qty of question";
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(90, 52);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(136, 20);
            this.textBox_Title.TabIndex = 3;
            // 
            // textBox_Author
            // 
            this.textBox_Author.Location = new System.Drawing.Point(90, 28);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(136, 20);
            this.textBox_Author.TabIndex = 2;
            // 
            // groupBox_Question
            // 
            this.groupBox_Question.Controls.Add(this.btn_OK);
            this.groupBox_Question.Controls.Add(this.numericUpDown_Difficulty);
            this.groupBox_Question.Controls.Add(this.label4);
            this.groupBox_Question.Controls.Add(this.textBox_Question);
            this.groupBox_Question.Controls.Add(this.label3);
            this.groupBox_Question.Location = new System.Drawing.Point(251, 17);
            this.groupBox_Question.Name = "groupBox_Question";
            this.groupBox_Question.Size = new System.Drawing.Size(409, 168);
            this.groupBox_Question.TabIndex = 25;
            this.groupBox_Question.TabStop = false;
            this.groupBox_Question.Text = "Question";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(87, 137);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 7;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // numericUpDown_Difficulty
            // 
            this.numericUpDown_Difficulty.Location = new System.Drawing.Point(87, 100);
            this.numericUpDown_Difficulty.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_Difficulty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Difficulty.Name = "numericUpDown_Difficulty";
            this.numericUpDown_Difficulty.Size = new System.Drawing.Size(55, 20);
            this.numericUpDown_Difficulty.TabIndex = 6;
            this.numericUpDown_Difficulty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Difficulty";
            // 
            // textBox_Question
            // 
            this.textBox_Question.Location = new System.Drawing.Point(87, 29);
            this.textBox_Question.Multiline = true;
            this.textBox_Question.Name = "textBox_Question";
            this.textBox_Question.Size = new System.Drawing.Size(315, 56);
            this.textBox_Question.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Question";
            // 
            // groupBox_CorrectAnswer
            // 
            this.groupBox_CorrectAnswer.Controls.Add(this.comboBox1);
            this.groupBox_CorrectAnswer.Controls.Add(this.btn_ChekedListOK);
            this.groupBox_CorrectAnswer.Location = new System.Drawing.Point(13, 341);
            this.groupBox_CorrectAnswer.Name = "groupBox_CorrectAnswer";
            this.groupBox_CorrectAnswer.Size = new System.Drawing.Size(232, 93);
            this.groupBox_CorrectAnswer.TabIndex = 29;
            this.groupBox_CorrectAnswer.TabStop = false;
            this.groupBox_CorrectAnswer.Text = "Сhoose the correct answer";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // btn_ChekedListOK
            // 
            this.btn_ChekedListOK.Location = new System.Drawing.Point(18, 56);
            this.btn_ChekedListOK.Name = "btn_ChekedListOK";
            this.btn_ChekedListOK.Size = new System.Drawing.Size(75, 23);
            this.btn_ChekedListOK.TabIndex = 1;
            this.btn_ChekedListOK.Text = "OK";
            this.btn_ChekedListOK.UseVisualStyleBackColor = true;
            this.btn_ChekedListOK.Click += new System.EventHandler(this.btn_ChekedListOK_Click);
            // 
            // textBox_FileName
            // 
            this.textBox_FileName.Location = new System.Drawing.Point(262, 385);
            this.textBox_FileName.Name = "textBox_FileName";
            this.textBox_FileName.Size = new System.Drawing.Size(255, 20);
            this.textBox_FileName.TabIndex = 28;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(262, 411);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 27;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(220, 170);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(13, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 189);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Answers";
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(712, 18);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 31;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Form_NewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_Answer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Question);
            this.Controls.Add(this.groupBox_CorrectAnswer);
            this.Controls.Add(this.textBox_FileName);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Back);
            this.Name = "Form_NewTest";
            this.Text = "Form_NewTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_NewTest_FormClosing);
            this.groupBox_Answer.ResumeLayout(false);
            this.groupBox_Answer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Question.ResumeLayout(false);
            this.groupBox_Question.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Difficulty)).EndInit();
            this.groupBox_CorrectAnswer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Answer;
        private System.Windows.Forms.CheckBox checkBox_IsRight;
        private System.Windows.Forms.Button btn_AddAnswer;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Qty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.GroupBox groupBox_Question;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.NumericUpDown numericUpDown_Difficulty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Question;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox_CorrectAnswer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_ChekedListOK;
        private System.Windows.Forms.TextBox textBox_FileName;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Back;
    }
}