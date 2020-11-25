namespace Test_Design
{
    partial class Form_Edit
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_RemoveQuestion = new System.Windows.Forms.Button();
            this.numericUpDown_Difficulty = new System.Windows.Forms.NumericUpDown();
            this.btn_EditQuestion = new System.Windows.Forms.Button();
            this.textBox_Question = new System.Windows.Forms.TextBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.checkBox_IsRight = new System.Windows.Forms.CheckBox();
            this.btn_EditAnswer = new System.Windows.Forms.Button();
            this.textBox_Qty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_File = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Difficulty)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(12, 161);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 40;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_RemoveQuestion);
            this.groupBox2.Controls.Add(this.numericUpDown_Difficulty);
            this.groupBox2.Controls.Add(this.btn_EditQuestion);
            this.groupBox2.Controls.Add(this.textBox_Question);
            this.groupBox2.Location = new System.Drawing.Point(250, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 367);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Question";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 199);
            this.listBox1.TabIndex = 21;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Difficulty";
            // 
            // btn_RemoveQuestion
            // 
            this.btn_RemoveQuestion.Location = new System.Drawing.Point(151, 316);
            this.btn_RemoveQuestion.Name = "btn_RemoveQuestion";
            this.btn_RemoveQuestion.Size = new System.Drawing.Size(75, 23);
            this.btn_RemoveQuestion.TabIndex = 31;
            this.btn_RemoveQuestion.Text = "Remove";
            this.btn_RemoveQuestion.UseVisualStyleBackColor = true;
            this.btn_RemoveQuestion.Click += new System.EventHandler(this.btn_RemoveQuestion_Click);
            // 
            // numericUpDown_Difficulty
            // 
            this.numericUpDown_Difficulty.Location = new System.Drawing.Point(60, 274);
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
            this.numericUpDown_Difficulty.TabIndex = 23;
            this.numericUpDown_Difficulty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_EditQuestion
            // 
            this.btn_EditQuestion.Location = new System.Drawing.Point(9, 316);
            this.btn_EditQuestion.Name = "btn_EditQuestion";
            this.btn_EditQuestion.Size = new System.Drawing.Size(76, 23);
            this.btn_EditQuestion.TabIndex = 30;
            this.btn_EditQuestion.Text = "Edit";
            this.btn_EditQuestion.UseVisualStyleBackColor = true;
            this.btn_EditQuestion.Click += new System.EventHandler(this.btn_EditQuestion_Click);
            // 
            // textBox_Question
            // 
            this.textBox_Question.Location = new System.Drawing.Point(6, 224);
            this.textBox_Question.Multiline = true;
            this.textBox_Question.Name = "textBox_Question";
            this.textBox_Question.Size = new System.Drawing.Size(220, 49);
            this.textBox_Question.TabIndex = 29;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(192, 159);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.btn_Remove.TabIndex = 32;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Answers";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.btn_Remove);
            this.groupBox3.Controls.Add(this.textBox_Answer);
            this.groupBox3.Controls.Add(this.checkBox_IsRight);
            this.groupBox3.Controls.Add(this.btn_EditAnswer);
            this.groupBox3.Location = new System.Drawing.Point(506, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 211);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Answer";
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Location = new System.Drawing.Point(20, 98);
            this.textBox_Answer.Multiline = true;
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Answer.Size = new System.Drawing.Size(247, 55);
            this.textBox_Answer.TabIndex = 26;
            // 
            // checkBox_IsRight
            // 
            this.checkBox_IsRight.AutoSize = true;
            this.checkBox_IsRight.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox_IsRight.Location = new System.Drawing.Point(88, 64);
            this.checkBox_IsRight.Name = "checkBox_IsRight";
            this.checkBox_IsRight.Size = new System.Drawing.Size(59, 17);
            this.checkBox_IsRight.TabIndex = 28;
            this.checkBox_IsRight.Text = "IsRight";
            this.checkBox_IsRight.UseVisualStyleBackColor = true;
            // 
            // btn_EditAnswer
            // 
            this.btn_EditAnswer.Location = new System.Drawing.Point(20, 159);
            this.btn_EditAnswer.Name = "btn_EditAnswer";
            this.btn_EditAnswer.Size = new System.Drawing.Size(75, 23);
            this.btn_EditAnswer.TabIndex = 27;
            this.btn_EditAnswer.Text = "Edit";
            this.btn_EditAnswer.UseVisualStyleBackColor = true;
            this.btn_EditAnswer.Click += new System.EventHandler(this.btn_EditAnswer_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 113);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // btn_File
            // 
            this.btn_File.Location = new System.Drawing.Point(12, 12);
            this.btn_File.Name = "btn_File";
            this.btn_File.Size = new System.Drawing.Size(75, 23);
            this.btn_File.TabIndex = 36;
            this.btn_File.Text = "File";
            this.btn_File.UseVisualStyleBackColor = true;
            this.btn_File.Click += new System.EventHandler(this.btn_File_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(713, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 41;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Form_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_File);
            this.Name = "Form_Edit";
            this.Text = "Form_Edit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Edit_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Difficulty)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_RemoveQuestion;
        private System.Windows.Forms.NumericUpDown numericUpDown_Difficulty;
        private System.Windows.Forms.Button btn_EditQuestion;
        private System.Windows.Forms.TextBox textBox_Question;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.CheckBox checkBox_IsRight;
        private System.Windows.Forms.Button btn_EditAnswer;
        private System.Windows.Forms.TextBox textBox_Qty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_File;
        private System.Windows.Forms.Button btn_Back;
    }
}