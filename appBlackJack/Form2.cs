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
    public partial class Form2 : Form
    {
        public string PlayerName { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        //Initializing
        int cardNumber, cardValue, dealerCardNumber, dealerCardValue;

        Random randomGen = new Random();

        private int currentCardIndex = -1;
        private int playerTotal = 0;
        private int dealerTotal = 0;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            //Checking for the winner when "stand" is pressed and hiding/showing buttons/labels
            determineWinner();

            btnHit.Visible = false;
            btnStand.Visible = false;
            lblResult.Visible = true;
        }
        //Taking the players first name from form1 and displaying it
        private void Form2_Load(object sender, EventArgs e)
        {
            lblPlayerC.Text = PlayerName + "'s Cards";
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //Resseting Totals
            playerTotal = 0;
            dealerTotal = 0;

            //Resetting card images
            picPlayerC1.Image = null;
            picPlayerC2.Image = null;
            picPlayerC3.Image = null;
            picPlayerC4.Image = null;
            picPlayerC5.Image = null;
            picPlayerC1.Image = null;
            picPlayerC2.Image = null;

            //Hiding cards
            picPlayerC3.Visible = false;
            picPlayerC4.Visible = false;
            picPlayerC5.Visible = false;

            //Resseting card index
            currentCardIndex = -1;

            //Hiding the Play Again button
            btnPlayAgain.Visible = false;

            //Displaying the start button again
            btnBegin.Visible = true;

            //Resseting the score labels and result label
            lblPlayerScore.Text = "Your score: 0";
            lblDealerScore.Text = "Dealers score: 0";
            lblResult.Visible = false;
        }


        private void btnHit_Click(object sender, EventArgs e)
        {
            // If hand slots 3-5 are empty, continue adding cards when "Hit" is pressed
            do
            {
                cardNumber = randomGen.Next(0, 52);
            } while (cardNumber == cardValue ||
                    (picPlayerC3.Image != null && picPlayerC4.Image != null && picPlayerC5.Image != null));

            // Display the randomly drawn card in the first available hand slot
            if  (picPlayerC3.Image == null)
            {
                picPlayerC3.Image = imgListC.Images[cardNumber];
                picPlayerC3.Visible = true;
                cardValue = cardNumber;
            }
            else if (picPlayerC4.Image == null)
            {
                picPlayerC4.Image = imgListC.Images[cardNumber];
                picPlayerC4.Visible = true;
                cardValue = cardNumber;
            }
            else if (picPlayerC5.Image == null)
            {
                picPlayerC5.Image = imgListC.Images[cardNumber];
                picPlayerC5.Visible = true;
                cardValue = cardNumber;
            }

            // Get the numerical value of the drawn card
            cardValue = calcCardValue(cardNumber);

            // Calculate and display the updated total
            playerTotal += cardValue;
            lblPlayerScore.Text = $"Your score: {playerTotal}";

            // Check for an instant win
            instantWin();

        }
        //Rules of the game helping the user
        private void btnHelp_Click(object sender, EventArgs e)
        {
            StringBuilder messageBuilder = new StringBuilder();
            messageBuilder.AppendLine($"Welcome {PlayerName}");
            messageBuilder.AppendLine("The rules will be explained here.");
            messageBuilder.AppendLine("Press Start, and the two cards you are dealt are close to 21, press Stand.");
            messageBuilder.AppendLine("If the cards are not close to 21, press Hit.");
            messageBuilder.AppendLine("If the value of your cards is 21, you win!");
            messageBuilder.AppendLine("If the value of your cards exceeds 21, you lose.");
            messageBuilder.AppendLine("If the value of your cards is the same as the dealer's, it's a tie.");

            MessageBox.Show(messageBuilder.ToString(), "Help Facility", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            //Draw 2 cards for player
            drawPlayerCard(picPlayerC1);
            drawPlayerCard(picPlayerC2);


            //Display the player score
            lblPlayerScore.Text = "Your score: " + playerTotal;

            //Check for instant win
            instantWin();
        }
        private void drawPlayerCard(PictureBox pictureBox)
        {
            //A loop checking if hand 3-5 is empty and showing/hiding buttons and picture boxes
            do
            {
                cardNumber = randomGen.Next(0, 52);
            } while (cardNumber == currentCardIndex ||
            picPlayerC3.Image != null && picPlayerC4.Image != null && picPlayerC5.Image != null);

            pictureBox.Image = imgListC.Images[cardNumber];
            pictureBox.Visible = true;
            currentCardIndex = cardNumber;


            cardValue = calcCardValue(cardNumber);

            picDealerC1.Visible = true;
            picDealerC2.Visible = true;
            btnBegin.Visible = false;
            btnHit.Visible = true;
            btnStand.Visible = true;

            playerTotal += cardValue;
        }

        // Method to draw dealer cards
        private void drawDealerCard(PictureBox pictureBox)
        {
            // Loop giving the dealer a card with an index between 24 and 52

            do
            {
                dealerCardNumber = randomGen.Next(0, 52);
                dealerCardValue = calcCardValue(dealerCardNumber);
            } while (dealerCardValue == 11 || dealerCardValue > 21);

            pictureBox.Image = imgListC.Images[dealerCardNumber];

            // Storing the dealer's score
            dealerTotal += dealerCardValue;
        }

        //Gives values to each index in the image list.
        private int calcCardValue(int cardNumber)
        {
            switch (cardNumber)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    cardValue = 2;
                    break;

                case 4:
                case 5:
                case 6:
                case 7:
                    cardValue = 3;
                    break;

                case 8:
                case 9:
                case 10:
                case 11:
                    cardValue = 4;
                    break;
           case 12:
                case 13:
                case 14:
                case 15:
                    cardValue = 5;
                    break;
case 16:
                case 17:
                case 18:
                case 19:
                    cardValue = 6;
                    break;
                case 20:
                case 21:
                case 22:
                case 23:
                    cardValue = 7;
                    break;
         case 24:
                case 25:
                case 26:
                case 27:
                    cardValue = 8;
                    break;
                case 28:
                case 29:
                case 30:
                case 31:
                    cardValue = 9;
                    break;
                case 32:
                case 33:
                case 34:
                case 35:
                case 36:
                case 37:
                case 38:
                case 39:
                case 40:
                case 41:
                case 42:
                case 43:
                case 44:
                case 45:
                case 46:
                case 47:
                    cardValue = 10;
                    break;
                case 48:
                case 49:
                case 50:
                case 51:
                    cardValue = 11;
                    break;
                default:
                    cardValue = 0;
                    break;
            }

            //Returning the card value
            return cardValue;
        }

        //Checks for an instant win
        private void instantWin()
        {
            if (playerTotal > 21 || playerTotal == 21 || picPlayerC5.Image != null)
            {
                determineWinner();
            }

            else if (dealerTotal > 21 || dealerTotal == 21)
            {
                determineWinner();
            }
        }

        // Determining a winner when "stand" is pressed
        private void determineWinner()
        {
            lblResult.Visible = true;

            // Draw 2 cards for dealer
            drawDealerCard(picDealerC1);
            drawDealerCard(picDealerC2);

            //SHowing label and making the text color different depending on the outcome
            if (playerTotal > 21)
            {
                lblResult.Text = "Player Bust! Dealer Wins!";
                lblResult.ForeColor = Color.Red;
            }
            else if (dealerTotal > 21 || (playerTotal == 21 && dealerTotal == 21))
            {
                lblResult.Text = "Player Wins!";
                lblResult.ForeColor = Color.Green;
            }
            else if (playerTotal == 21 || dealerTotal > 21 || playerTotal > dealerTotal)
            {
                lblResult.Text = "Player Wins!";
                lblResult.ForeColor = Color.Green;
            }
            else if (dealerTotal == 21 || playerTotal < dealerTotal)
            {
                lblResult.Text = "Dealer Wins!";
                lblResult.ForeColor = Color.Red;
            }
            else
            {
                lblResult.Text = "It's a tie!";
                lblResult.ForeColor = Color.Red;
            }
            // Showing dealer's score
            lblDealerScore.Text = "Dealer's score: " + dealerTotal;

            // Hides and displays the buttons allows the user to play again
            btnStand.Visible = false;
            btnHit.Visible = false;
            btnPlayAgain.Visible = true;

        }


    }
    }
