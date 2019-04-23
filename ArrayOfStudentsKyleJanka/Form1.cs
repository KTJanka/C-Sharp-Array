using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayOfStudentsKyleJanka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] studentNameArray = new string[5];
        int[] studentGradeArray = new int[5];
        int arrayNumber;
        const int arrayMax = 5;
        

        private void button1_Click(object sender, EventArgs e)
        {
            //Input

            //Declare Variables
            int studentGradeV;
            string studentNameV;
            bool validateStudentGrade;

            //Validation
            if (studentNameTxt.Text == "")
            {
                MessageBox.Show("Please enter a valid name.");
                return;
            }
            studentNameV = studentNameTxt.Text;
            

            validateStudentGrade = int.TryParse(studentGradeTxt.Text, out studentGradeV);
            if (validateStudentGrade == false || studentGradeV >= 101 || studentGradeV < 0)
            {
                MessageBox.Show("Please enter a valid grade number 0-100.");
                return;
            }


            //Processing Arrays
            if(arrayNumber >= arrayMax)
            {
                MessageBox.Show("Cannot accept any new student information. Max size of 5 reached.");
                return;
            }
            else
            {
                studentNameArray[arrayNumber] = studentNameV;
                studentGradeArray[arrayNumber] = studentGradeV;
            }


            //Output

        }

        private void ArrayBtn_Click(object sender, EventArgs e)
        {
            string arrayStatement = "";

            for (int i = 0; i < arrayMax; i++)
            {
                arrayStatement = arrayStatement + "Array [" + i + "] ==> " + "Student # " + (i + 1);
                
                if (studentGradeArray[i] == 0)
                {
                    arrayStatement = arrayStatement + " No student data entered";

                }
                else
                {
                    arrayStatement = arrayStatement + 
                        "Student # " + studentNameArray[i] + 
                        "Student grade: " + studentGradeArray[i];
                    arrayNumber++;
                }
                arrayStatement = arrayStatement + "\n";
            }


            //output
            arrayLabel.Text = arrayStatement;
        }

    }
}
