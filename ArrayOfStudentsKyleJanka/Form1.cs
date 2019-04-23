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

        //Author: Kyle Janka    
        //ID: 565104
        //Date: 4/23/19
        //Goal-Purpose of the Program: Display a list of student data from an array and calculate the total.

        string[] studentNameArray = new string[5];
        int[] studentGradeArray = new int[5];
        int arrayNumber = 0;
        int numberOfStudents = 0;
        int totalGrade = 0;
        const int arrayMax = 5;
        decimal gradeAvg = 0;
        

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
                totalGrade = totalGrade + studentGradeV;
                MessageBox.Show("Student added to the list.");
                numberOfStudents = numberOfStudents + 1;
                
            }
            arrayNumber++;

            //Output

        }

        private void ArrayBtn_Click(object sender, EventArgs e)
        {
            string arrayStatement = "";
            

            for (int i = 0; i < studentGradeArray.Length; i++)
            {
                arrayStatement = arrayStatement + "Student # " + (i + 1);
                
                if (studentGradeArray[i] == 0)
                {
                    arrayStatement = arrayStatement + " (NO STUDENT DATA ENTERED)";

                }
                else
                {
                    arrayStatement = arrayStatement + 
                        " Name: " + studentNameArray[i] + 
                        " Grade: " + studentGradeArray[i];
                }
                arrayStatement = arrayStatement + "\n";
                if (numberOfStudents > 0)
                {
                    gradeAvg =  totalGrade / numberOfStudents ;
                }
            }


            //output
            arrayLabel.Text = arrayStatement  + "Total number of students: " + numberOfStudents + " Student Average Grade " + gradeAvg.ToString("n2");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            arrayLabel.Text = "";
            studentGradeTxt.Text = "";
            studentNameTxt.Text = "";
            studentNameTxt.Focus();
            Array.Clear(studentNameArray, 0 , studentNameArray.Length);
            Array.Clear(studentGradeArray, 0, studentGradeArray.Length);
            arrayNumber = 0;
            numberOfStudents = 0;
            totalGrade = 0;
            gradeAvg = 0;
            

        }
    }
}
