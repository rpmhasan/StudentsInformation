using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInformationApp
{
    public partial class StudentsInformationUI : Form
    {
        public StudentsInformationUI()
        {
            InitializeComponent();
        }
        Hashtable myHashtable=new Hashtable(); 
        private void showButton_Click(object sender, EventArgs e)
        {
            if (regNoTextBox.Text != "" || firstNameTextBox.Text != "" || lastNameTextBox.Text != "")
            {
                int regNo = Convert.ToInt32(regNoTextBox.Text);
                string fName = firstNameTextBox.Text;
                string lName = lastNameTextBox.Text;

                myHashtable.Add("regNo", regNo);
                myHashtable.Add("fName", fName);
                myHashtable.Add("lName", lName);

                MessageBox.Show("Reg No. is " + myHashtable["regNo"] + " " + "and Name is " + myHashtable["fName"] + " " +
                                myHashtable["lName"]);

                regNoTextBox.Text = "";
                firstNameTextBox.Text = "";
                lastNameTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Enter all items!!");
            }
        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            regNoTextBox.Text = Convert.ToString(myHashtable["regNo"]);
            firstNameTextBox.Text = Convert.ToString(myHashtable["fName"]);
            lastNameTextBox.Text = Convert.ToString(myHashtable["lName"]);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
           myHashtable.Clear();

           regNoTextBox.Clear();
           firstNameTextBox.Clear();
           lastNameTextBox.Clear();
        }
    }
}
