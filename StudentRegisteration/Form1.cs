using System.Windows.Forms;

namespace StudentRegisteration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var firstName = txtFirstName.Text.ToString().Trim();
            var lastName = txtLastName.Text.ToString().Trim();
            var resultString = "Name: " + firstName + " " + lastName + "\n" +
                "Subjects: " + "\n";

            bool errorFlag = false;
            if (!checkBox1.Checked)
            {
                labelResult.Text = "Please Agree to User Agrement.";
                errorFlag = true;
            }
            if (txtFirstName.Text.Length == 0)
            {

                textboxValidator1.Visible = true;
                errorFlag = true;
            }
            if (txtLastName.Text.Length == 0)
            {
                textBoxValidator2.Visible = true;
                errorFlag = true;
            }
            if (listSubject.SelectedItems.Count < 2)
            {
                textBoxValidator3.Visible = true;
                errorFlag = true;
            }
            if (errorFlag)
            {
                return;
            } else
            {
                textboxValidator1.Visible = false;
                textBoxValidator2.Visible= false;  
                textBoxValidator3.Visible= false;  
            }

            foreach (object item in listSubject.SelectedItems)
            {
                resultString += item.ToString() + "\n";
            }

            labelResult.Text = resultString;
        }

        private void comboBoxSubjects_DropDown(object sender, EventArgs e)
        {

            listSubject.Visible = true;
            listSubject.BringToFront();


        }

        private void listSubject_Leave(object sender, EventArgs e)
        {
            listSubject.Visible = false;
            comboBoxSubjects.Items.Clear();
            foreach (var item in listSubject.SelectedItems)
            {
                comboBoxSubjects.Items.Add(item);
            }

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            listSubject.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}