//pprnugon
//pranavi penugonda
//week5_homework
//This file contains program where we can parse the email nd give the username and domain name in seperate and also combines the city,state &zipcode, gives us as address.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            string userName = "";
            string domainName = "";
            string email = txtEmail.Text.Trim();   //Trim(), removes the spaces at begining and also at the end and returns the text.
            if (email.Contains("@"))
            {
                string[] splitEmail = email.Split('@');  //Split(), it splits the string at the delimiter provided in the braces and gives the substring as an array.
                userName = splitEmail[0];
                domainName = splitEmail[1];
                MessageBox.Show("User name: " + userName +"\n" + "Domain name: " + domainName,"Parsed String" );   
            }
            else
            {
                MessageBox.Show("Please enter a valid email.", "Invalid email");
            }
           
            txtEmail.Focus();
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;
            string state = (txtState.Text).ToUpper();
            string zipCode = txtZipCode.Text;
            
           
            string addressValue = city + state + zipCode;
            addressValue=addressValue.Insert(city.Length, ", ");
            addressValue = addressValue.Insert((city.Length + 2 + state.Length), " ");
            string address = "City, State, Zip: " + addressValue;

            

            MessageBox.Show(address, "Formatted String");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
