using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StepTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            int subjectId;
            subjectId = int.Parse(txtSubId.Text); // this converts int into text format so that it can be displayed in the message box

            String surname;
            surname = txtName.Text;

            int age;
            age = int.Parse(txtAge.Text);

            String gender;
            gender = txtName.Text;

            double maxHr = 220 - age; // This is the max heart rate
            
            double eightyFiveHr = (maxHr * 0.85); // This is 85% of the max heart rate

            double halfHr = (maxHr * 0.50); // This is 50% of the max heart rate

            MessageBox.Show("subject Id- " + subjectId + "\n" + "Name- " + surname + "\n" + "Age- " + age + "\n" + "Max heart rate- " + maxHr + "\n" + "85% of Max heart rate- " + eightyFiveHr );

            int test1, test2, test3, test4, test5;
            test1= int.Parse(txtTstOne.Text);// this converts the interger into text format
            test2 = int.Parse(txtTstTwo.Text);
            test3 = int.Parse(txtTstThree.Text);
            test4 = int.Parse(txtTstFour.Text);
            test5 = int.Parse(txtTstFive.Text);

            if (test1>=maxHr) // this condition applies if the heart rate is greater than maxHr, if its true then it will come up with a message, otherwise it will move onto the next test
            {
                test2 = 0; // This is setting the values for each test
                test3 = 0;
                test4 = 0;
                test5 = 0;
                MessageBox.Show("The test will be concluded at 'test 1' becuase maximum heart rate was reached"); // This message will only come up if the 'if' statement is true
            }
            else if (test1 <= halfHr) //this condition applies only if the heart rate is half of the max heart rate, if it is false it will move onto the next statement 
            {
                test1 = 0;
                MessageBox.Show("Test 1 mark will not be valid due to heart rate being under 50% of max heart rate");
            }

            else if (test1 >= eightyFiveHr) //this condition applies only if the heart rate is 85% of the max heart rate, if false it will still carry on with the tests
            {
                test1 = 0;
                MessageBox.Show("Test 1 mark will not be valid due to heart rate being under 85% of max heart rate");
            }

            if (test2 >= maxHr)
            {
                
                test3 = 0;
                test4 = 0;
                test5 = 0;
                MessageBox.Show("The test will be concluded at 'test 2' becuase maximum heart rate was reached");
            }
            else if (test2 <= halfHr)
            {
                test2 = 0;
                MessageBox.Show("Test 2 mark will not be valid due to heart rate being under 50% of max heart rate");
            }

            else if (test2 >= eightyFiveHr)
            {
                test3 = 0;
                MessageBox.Show("Test 2 mark will not be valid due to heart rate being under 85% of max heart rate");
            }

            if (test3 >= maxHr)
            {

                
                test4 = 0;
                test5 = 0;
                MessageBox.Show("The test will be concluded at 'test 3' becuase maximum heart rate was reached");
            }
            else if (test3 <= halfHr)
            {
                test3 = 0;
                MessageBox.Show("Test 3 mark will not be valid due to heart rate being under 50% of max heart rate");
            }

            else if (test3 >= eightyFiveHr)
            {
                test3 = 0;
                MessageBox.Show("Test 3 mark will not be valid due to heart rate being under 85% of max heart rate");
            }

            if (test4 >= maxHr)
            {

                
                test4 = 0;
                test5 = 0;
                MessageBox.Show("The test will be concluded at 'test 4' becuase maximum heart rate was reached");
            }
            else if (test4 <= halfHr)
            {
                test4 = 0;
                MessageBox.Show("Test 4 mark will not be valid due to heart rate being under 50% of max heart rate");
            }

            else if (test4 >= eightyFiveHr)
            {
                test4 = 0;
                MessageBox.Show("Test 4 mark will not be valid due to heart rate being under 85% of max heart rate");
            }

            if (test5 >= maxHr)
            {

                
                test5 = 0;
                MessageBox.Show("The test will be concluded at 'test 5' becuase maximum heart rate was reached");
            }

            else if (test5 >= eightyFiveHr)
            {
                test5 = 0;
                MessageBox.Show("Test 5 mark will not be valid due to heart rate being under 85% of max heart rate");
            }

            if (radioButton1.Checked = true) // The user will select a radio button, If this button has been selecected the statement is true, it will perfrom the conditions below othwerise it will move onto the next statement if this one is false

            {
                this.chart1.Series["HeartRate"].Points.AddXY(11, test1); // This is setting the points for the chart
                this.chart1.Series["HeartRate"].Points.AddXY(14, test2);
                this.chart1.Series["HeartRate"].Points.AddXY(18, test3);
                this.chart1.Series["HeartRate"].Points.AddXY(21, test4);
                this.chart1.Series["HeartRate"].Points.AddXY(23, test5);
            }

            else if (radioButton2.Checked = true) // If the previous statement was false, it will check the next ones are true and if they are, it will perfrom the conditions below 

            {
                this.chart1.Series["HeartRate"].Points.AddXY(12, test1); // This is setting the points for the chart, the X axis will be the set number in the bracket and the Y axis will be the user input from the tests
                this.chart1.Series["HeartRate"].Points.AddXY(15, test2);
                this.chart1.Series["HeartRate"].Points.AddXY(21, test3);
                this.chart1.Series["HeartRate"].Points.AddXY(25, test4);
                this.chart1.Series["HeartRate"].Points.AddXY(29, test5);
            }

           else if (radioButton3.Checked = true)

            {
                this.chart1.Series["HeartRate"].Points.AddXY(14, test1); 
                this.chart1.Series["HeartRate"].Points.AddXY(19, test2);
                this.chart1.Series["HeartRate"].Points.AddXY(24, test3);
                this.chart1.Series["HeartRate"].Points.AddXY(28, test4);
                this.chart1.Series["HeartRate"].Points.AddXY(33, test5);
            }

            else if (radioButton4.Checked = true)

            {
                this.chart1.Series["HeartRate"].Points.AddXY(17, test1); 
                this.chart1.Series["HeartRate"].Points.AddXY(21, test2);
                this.chart1.Series["HeartRate"].Points.AddXY(27, test3);
                this.chart1.Series["HeartRate"].Points.AddXY(32, test4);
                this.chart1.Series["HeartRate"].Points.AddXY(37, test5);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     
        private void chkFifteen_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void TstTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            this.Close(); // This function will close the application when the button is clicked
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

       