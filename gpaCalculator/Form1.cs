using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class gradeInput : Form
    {
        //Lists can expand
        //grades stores user input grades
        List<int> grades = new List<int>();
        //gradePoints stores user grades post grade point conversion
        List<double> gradePoints = new List<double>();
        //Arrays cannot expand, but function similar to code.org lists
        //percentageList and gpList are used to convert, indexes correspond.
        int[] percentageList = { 93, 90, 87, 83, 80, 77, 73, 70, 67, 65, 0 };
        double[] gpList = { 4, 3.7, 3.3, 3, 2.7, 2.3, 2, 1.7, 1.3, 1, 0 };
        //stores final GPA
        double GPA;
        //Unfinished code, user input for how to improve grades to reach a desired gpa
        double desiredGPA;
        public gradeInput()
        {
            InitializeComponent();
        }

        //On click calculate 
        private void calculate_Click(object sender, EventArgs e)
        {
            //Reset
            GPA = 0;
            gradePoints.Clear();
            //Loop for every element in list
            foreach (int grade in grades)
            {
                //traverse percentage to convert
                for(int i = 0; i < percentageList.Length; i++)
                {
                    //if grade matches percentage range, add the corresponding grade point value
                    if (grade >= percentageList[i])
                    {
                        gradePoints.Add(gpList[i]);
                        //break to go to next item in grades list
                        break;
                    }
                }
            }
            //add all grade point values together
            foreach (double gp in gradePoints)
            {
                GPA += gp;

            }
            //divide to find average
            GPA = GPA / gradePoints.Count;

            //temporarily output in console
            Console.WriteLine(GPA);
            gpaLabel.Text = "GPA: " + Convert.ToString(Math.Round(GPA*10)/10); 
        }

        //function for adding input to list display
        private void AddGradeToList(Int32 grade)
        {
            //add grade from input to list
            grades.Add(grade);
            //clear display
            averageListBox.Items.Clear();
            //update display with new values
            foreach (int element in grades)
            {
                averageListBox.Items.Add(element.ToString());
            }    
        }
        //input box
        private void enterGrade(object sender, KeyPressEventArgs e)
        {
            //On enter key pressed
            if (e.KeyChar == (char)Keys.Return)
            {
                //attempt to convert to integer and run AddGradeToList function with converted integer
                try
                {
                    AddGradeToList(Int32.Parse(textBox1.Text));
                    textBox1.Clear();
                }
                //If conversion fails display error message
                catch (Exception)
                {
                    MessageBox.Show("Cannot convert "+ textBox1.Text + " to integer.",
                        "Invalid input",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
               
        }

       

    }
}
