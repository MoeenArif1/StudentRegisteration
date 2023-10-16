using System.Collections;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentRegisteration
{
    public partial class Form1 : Form
    {
        private ArrayList textBoxList = new ArrayList();
        private List<string> subjectsList = new List<string>();
        public Form1()
        {
            InitializeComponent();
            InitializeTextBoxes();
            InitializeList();
        }
        private void InitializeList()
        {
            subjectsList.Add("Technical and Business Writing ");
 
            subjectsList.Add("Quran Translation");
            subjectsList.Add("Enterprise Application Development");
            subjectsList.Add("Mobile Application Development");
            subjectsList.Add("Computer Vision");
            subjectsList.Add("Machine Learning");
            subjectsList.Add("Numerical Computing");
            UpdateListBox();
        }
        private void UpdateListBox()
        {
            listSubject.Items.Clear(); // Clear the ListBox.

            // Add items from the List to the ListBox.
            foreach (string item in subjectsList)
            {
                listSubject.Items.Add(item);
            }
        }
        private void InitializeTextBoxes()
        {
            textBoxList.Add(txtFirstName);
            textBoxList.Add(txtLastName);
  

        }

      
    

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var resultString = "Name: ";
            foreach (System.Windows.Forms.TextBox textbox in textBoxList)
            {
                resultString += textbox.Text.ToString().Trim() + " ";
                
            }
           
            resultString +=   "\n" + "Subjects: " + "\n";

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
            comboBoxSubjects.SelectedIndex = 0;

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            listSubject.Visible = false;
        }

       
    }
}