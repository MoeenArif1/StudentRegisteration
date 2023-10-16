namespace StudentRegisteration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelSubjects = new Label();
            labelResult = new Label();
            btnSubmit = new Button();
            comboBoxSubjects = new ComboBox();
            listSubject = new ListBox();
            checkBox1 = new CheckBox();
            textboxValidator1 = new TextBox();
            textBoxValidator2 = new TextBox();
            textBoxValidator3 = new TextBox();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(156, 39);
            txtFirstName.Margin = new Padding(3, 2, 3, 2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(247, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(156, 94);
            txtLastName.Margin = new Padding(3, 2, 3, 2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(247, 23);
            txtLastName.TabIndex = 1;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(52, 44);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(64, 15);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "First Name";
          
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(52, 100);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(63, 15);
            labelLastName.TabIndex = 3;
            labelLastName.Text = "Last Name";
            // 
            // labelSubjects
            // 
            labelSubjects.AutoSize = true;
            labelSubjects.Location = new Point(52, 158);
            labelSubjects.Name = "labelSubjects";
            labelSubjects.Size = new Size(51, 15);
            labelSubjects.TabIndex = 4;
            labelSubjects.Text = "Subjects";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(156, 362);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(143, 15);
            labelResult.TabIndex = 5;
            labelResult.Text = "Result will be Shown Here";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ActiveCaption;
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.Location = new Point(129, 322);
            btnSubmit.Margin = new Padding(3, 2, 3, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(82, 22);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // comboBoxSubjects
            // 
            comboBoxSubjects.DropDownHeight = 1;
            comboBoxSubjects.DropDownWidth = 1;
            comboBoxSubjects.FormattingEnabled = true;
            comboBoxSubjects.IntegralHeight = false;
            comboBoxSubjects.Items.AddRange(new object[] { "" });
            comboBoxSubjects.Location = new Point(156, 158);
            comboBoxSubjects.Margin = new Padding(3, 2, 3, 2);
            comboBoxSubjects.Name = "comboBoxSubjects";
            comboBoxSubjects.Size = new Size(247, 23);
            comboBoxSubjects.TabIndex = 8;
            comboBoxSubjects.DropDown += comboBoxSubjects_DropDown;
            // 
            // listSubject
            // 
            listSubject.FormattingEnabled = true;
            listSubject.ItemHeight = 15;
            listSubject.Items.AddRange(new object[] { "Technical and Business Writing", "Quran Translation", "Enterprise Application Development", "Mobile Application Development", "Computer Vision", "Machine Learning", "Numerical Computing" });
            listSubject.Location = new Point(156, 183);
            listSubject.Margin = new Padding(3, 2, 3, 2);
            listSubject.Name = "listSubject";
            listSubject.SelectionMode = SelectionMode.MultiSimple;
            listSubject.Size = new Size(247, 109);
            listSubject.TabIndex = 9;
            listSubject.Visible = false;
            listSubject.Leave += listSubject_Leave;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Location = new Point(156, 298);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(131, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "I agree to Agrement";
            checkBox1.UseVisualStyleBackColor = true;
         
            // 
            // textboxValidator1
            // 
            textboxValidator1.ForeColor = Color.Red;
            textboxValidator1.Location = new Point(156, 12);
            textboxValidator1.Name = "textboxValidator1";
            textboxValidator1.Size = new Size(247, 23);
            textboxValidator1.TabIndex = 11;
            textboxValidator1.Text = "Please Enter Valid First Name";
            textboxValidator1.Visible = false;
          
            // 
            // textBoxValidator2
            // 
            textBoxValidator2.ForeColor = Color.Red;
            textBoxValidator2.Location = new Point(156, 67);
            textBoxValidator2.Name = "textBoxValidator2";
            textBoxValidator2.Size = new Size(247, 23);
            textBoxValidator2.TabIndex = 12;
            textBoxValidator2.Text = "Please Enter Valid Last Name";
            textBoxValidator2.Visible = false;
            // 
            // textBoxValidator3
            // 
            textBoxValidator3.ForeColor = Color.Red;
            textBoxValidator3.Location = new Point(156, 130);
            textBoxValidator3.Name = "textBoxValidator3";
            textBoxValidator3.Size = new Size(247, 23);
            textBoxValidator3.TabIndex = 13;
            textBoxValidator3.Text = "Please Select alteast 2 Subjects";
            textBoxValidator3.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 505);
            Controls.Add(textBoxValidator3);
            Controls.Add(textBoxValidator2);
            Controls.Add(textboxValidator1);
            Controls.Add(checkBox1);
            Controls.Add(listSubject);
            Controls.Add(comboBoxSubjects);
            Controls.Add(btnSubmit);
            Controls.Add(labelResult);
            Controls.Add(labelSubjects);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "`";

            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelSubjects;
        private Label labelResult;
        private Button btnSubmit;
        private ComboBox comboBoxSubjects;
        private ListBox listSubject;
        private CheckBox checkBox1;
        private TextBox textboxValidator1;
        private TextBox textBoxValidator2;
        private TextBox textBoxValidator3;
    }
}