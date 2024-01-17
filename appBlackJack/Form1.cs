using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appBlackJack
{
    public partial class Form1 : Form
    {

        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }
        // Modified code after deleting the event handler body
        private void label2_Click(object sender, EventArgs e)
        {
            // Event handler body deleted
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAge.Text, out int age) || age < 18)
            {
                MessageBox.Show(age < 18 ? "Please enter a valid age greater than or equal to 18." : "Please enter a valid age.");
                return;
            }

            if (!checkYes.Checked)
            {
                MessageBox.Show("You did not agree to the terms and conditions.");
                return;
            }



            // Determine gender
            string gender = radMale.Checked ? "He" : "She";

            // Build player information message
            StringBuilder messageBuilder = new StringBuilder();
            messageBuilder.AppendLine($"The active player is {txtFirstN.Text} {txtSecondN.Text}.");
            messageBuilder.AppendLine($"{gender} is {age} years of age.");
            messageBuilder.AppendLine($"{gender} has accepted the terms and conditions of play.");

            // Show player information in MessageBox
            DialogResult result = MessageBox.Show(messageBuilder.ToString(), "Player Information", MessageBoxButtons.OK);

            // Process the result of the MessageBox
            switch (result)

            {
                case DialogResult.OK:
                    // Perform actions after the user clicks "Continue"
                    Form2 form2 = new Form2();  // Create an instance of Form2
                    form2.PlayerName = $"{txtFirstN.Text} {txtSecondN.Text}";  // Pass player name to Form2
                    form2.Show();  // Show Form2
                    this.Hide();  // Hide Form1 (optional, depending on your requirements)
                    break;

                // Handle other DialogResult values as needed.

                default:
                    // Handle other cases if necessary
                    break;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's choice
            if (result == DialogResult.Yes)
            {
                // If yes, close the application
                Application.Exit();
            }
            // If no, do nothing (close the dialog)
        }
    }
}
