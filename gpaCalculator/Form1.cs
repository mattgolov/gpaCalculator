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
    public partial class Form1 : Form
    {
        //Lists can expand
        List<int> grades = new List<int>();
        List<double> gradePoints = new List<double>();
        //Arrays cannot expand, function similar to code.org
        int[] percentageList = { 93, 90, 87, 83, 80, 77, 73, 70, 67, 65 };
        double[] gpList = { 4, 3.7, 3.3, 3, 2.7, 2.3, 2, 1.7, 1.3, 1, 0 };
        double GPA;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] == percentageList[i])
                {
                    gradePoints.Add(gpList[i]);
                }
            }
            Console.WriteLine(gradePoints);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                try
                {
                    grades.Add(Int32.Parse(textBox1.Text));
                    textBox1.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot convert "+ textBox1.Text + "to integer.",
                        "Invalid input",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Then Do your Thang
            }
        }
    }
}
