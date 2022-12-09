// Programmer: Bryan Miranda
//Project : Miranda_2
//Due Date: 03/01/2021
//Description: Individual Assignment #2



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Miranda_2
{
    public partial class Form1 : Form
    {
        //Declaring Class-level constants for future uses in the program
        private const decimal IN_STATE_TUITION_PRICE = 49.00m; //Price of in state
        private const decimal OUT_OF_STATE_TUITION_PRICE = 99.00m; // Price of out of state
        private const decimal STARTUP_BASE_PRICE = 0.00m;
        private const int MAXIMUM_COURSES = 3;

        //Declaring local variables as well   
        string registrationTerm = ""; //Declaring variable for the term        
        string creditCardType = "";
        string residenceStatus = "";
        private int totalCourses; // Amount selection of the courses
        decimal pricePerCourse = 49.00m; // Cost per course In state
        decimal totalOrderPrice; // Final price of all courses purchased

        public Form1()
        {
            InitializeComponent();
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
            // When the form loads up automatically Execute the following

            priceperCourseLabel.Text = IN_STATE_TUITION_PRICE.ToString("c");
            

            totalCoursesLabel.Text = totalCourses.ToString();
            totalOrderPriceLabel.Text = STARTUP_BASE_PRICE.ToString("c");
        }
        // Event change automatically for Fall radio button

        private void fallRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fallRadioButton.Checked)
                registrationTerm = "Fall";
            else if(springRadioButton.Checked)
                registrationTerm = "Spring";
               
        }
        // In state event changed if user selects other option
        private void inStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {            
            if (inStateRadioButton.Checked)
            {
                residenceStatus = "In State";
                pricePerCourse = 49.00m;
            }                     
            //Checkbox update in relation to student residence status
            {
                priceperCourseLabel.Text = IN_STATE_TUITION_PRICE.ToString("c");
                
            }
        }
        //Handler for out of state cost change
        private void outOfStateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (outOfStateRadioButton.Checked)
            {
                residenceStatus = "Out of State";
                pricePerCourse = 99.00m;
            }
            //Checkbox update in relation to student residency
            {
                priceperCourseLabel.Text = OUT_OF_STATE_TUITION_PRICE.ToString("c");
            }
           
           
        }
        //execution when check box is selected or deselected
        //Shared event handler with the other language check boxes
              private void frenchCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // French event handler with the if/else statement for selecting language and showing totals

            if (frenchCheckBox.Checked)
            {
                totalCourses +=1;
                totalOrderPriceLabel.Text = (totalCourses * pricePerCourse).ToString("c");
            }
            else
            {
                totalCourses = totalCourses-1;
                totalOrderPriceLabel.Text = (totalCourses * pricePerCourse).ToString("c");
            }
            //update display value when selected
            totalCoursesLabel.Text = totalCourses.ToString();
                     
        }
        private void germanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //german event handler with the if/else statement for selecting language and showing totals

            if (germanCheckBox.Checked)
            {
                totalCourses += 1;
                totalOrderPriceLabel.Text = (totalCourses * pricePerCourse).ToString("c");
            }
            else
            {
                totalCourses = totalCourses - 1;
                totalOrderPriceLabel.Text = (totalCourses * pricePerCourse).ToString("c");
            }

            //update display value when selected
            totalCoursesLabel.Text = totalCourses.ToString();
        }
        private void italianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //italian event handler with the if/else statement for selecting language and showing totals

            if (italianCheckBox.Checked)
            {
                totalCourses += 1;
                totalOrderPriceLabel.Text = (totalCourses * pricePerCourse).ToString("c");
            }
            else
            {
                totalCourses = totalCourses - 1;
                totalOrderPriceLabel.Text = (totalCourses * pricePerCourse).ToString("c");
            }
            //update display value
            totalCoursesLabel.Text = totalCourses.ToString();
        }
        private void russianCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // russian event handler with the if/else statement for selecting language and showing totals

            if (russianCheckBox.Checked)
            {
                totalCourses += 1;
                totalOrderPriceLabel.Text = (totalCourses * pricePerCourse).ToString("c");
            }
            else
            {
                totalCourses = totalCourses - 1;
                totalOrderPriceLabel.Text = (totalCourses * pricePerCourse).ToString("c");
            }
            //update display value
            totalCoursesLabel.Text = totalCourses.ToString();
        }
        private void spanishCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           //Spanish event handler with the if/else statement for selecting language and showing totals
        
            if (spanishCheckBox.Checked)
            {
                totalCourses += 1;
                totalOrderPriceLabel.Text = (totalCourses * pricePerCourse).ToString("c");
            }
            else
            {
                totalCourses = totalCourses - 1;
                totalOrderPriceLabel.Text = (totalCourses * pricePerCourse).ToString("c");
            }
            //update display value
            totalCoursesLabel.Text = totalCourses.ToString();
        }
        //Radio button confirmation with a if else between the two options
        private void visaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if
               (visaRadioButton.Checked)
            {
                creditCardType = "VISA";
            }           
        }
        private void masterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (masterRadioButton.Checked)
            creditCardType = "Mastercard";
        }
        // Execute when save button clicked
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Order will not process if the orders is less than 1 or greater than 3 in a single order
            if (totalCourses >=0 && totalCourses <= 3)
            {
                MessageBox.Show("Order Summary\n\n" +
                    "Term: " + registrationTerm + "" + yearComboBox.Text + "\n" +
                    "Student ID: " + studentIDMaskedTextBox.Text + "\n" +
                    "Name: " + firstnameTextBox.Text + " " + lastnameTextBox.Text
                    + "\n" +
                    "Email: " + emailTextBox.Text + "\n" +
                    "Residence Status: " + residenceStatus + "\n" +
                    "Total Courses Purchased: " + totalCoursesLabel.Text + "\n" +
                    "Price per Course: " + pricePerCourse + "\n" +
                    "Total Order Price: " + totalOrderPriceLabel.Text + "\n" +
                    "Credit Card Type: " + creditCardType + "\n" +
                    "Card Number: " + cardnumberMaskedTextBox.Text + "\n"+
                    "Credit Card Expiration Date: " + expirationdateMaskedTextBox.Text+ "\n",
                    "LAI Order Form", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Course order must contain at least 1 course but no more than 3 courses",
                    "Order form Invalid", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }

        }
        //Clears all fields to start a new form
        private void clearButton_Click(object sender, EventArgs e)
        {
            yearComboBox.SelectedIndex = -1;
            studentIDMaskedTextBox.Text = "";
            firstnameTextBox.Text = "";
            lastnameTextBox.Text = "";
            emailTextBox.Text = "";
            inStateRadioButton.Checked = true;
            frenchCheckBox.Checked = false;
            germanCheckBox.Checked = false;
            italianCheckBox.Checked = false;
            russianCheckBox.Checked = false;
            spanishCheckBox.Checked = false;
            visaRadioButton.Checked = true;
            cardnumberMaskedTextBox.Text = "";
            expirationdateMaskedTextBox.Text = "";
            totalCoursesLabel.Text = totalCourses.ToString();
            totalOrderPriceLabel.Text = STARTUP_BASE_PRICE.ToString("c");
            //Sending focus back to Fall button when cleared
            fallRadioButton.Focus();
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {          
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Declaring variable to hold user selection in dialog
            DialogResult selection;
            selection = MessageBox.Show("Are you sure you want to quit?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Take action based on user selections
            if (selection == DialogResult.Yes)
            {
                this.Close(); //Close the form (ends program)
            }

        }
    }
}
