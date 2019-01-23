//Program Name:     PowerBallWinFormsV7Skeleton.
//
//Description:      
//                  
//                 
//                 
//                  
//                  
//
//Date Written:     20180219.
//
//Programmer:       Patrick Hill
//
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PowerBallWinFormsV7
{
    public partial class PowerballForm : Form
    {    
        //69 white balls, 26 red balls, 5 white balls drawn, 1 red ball drawn.
        //We use const because we never want to use "magic numbers."
        private const int whiteBallHopperCount = 69;

        private const int redBallHopperCount = 26;

        private const int numOfWhiteBallsToBeDrawn = 5;

        //Create random number generators references for white balls and red balls.
        private Random whiteBallPicker = null;

        private Random redBallPicker = null;

        //Counter and const for counting "dots" displayed
        //in the "Working" animation on the form.
        private int workingDotCount = 0;
        private const int workingDotMax = 65;

        private int totalNumberOfDraws = 0;

        //Delay method millisecond delay constant.
        private int delayConstTimeMilliseconds = 500;

        //Animation timer interval constant.
        private int animationConstIntervalMilliseconds = 250;

        //Create timer object to use to fire an event
        //we can use to display animations on the form
        //while we randomly draw Powerball picks.
        Timer animationTimer = new Timer();

        //>>>>>>You will need to declare varibles you need here.<<<<<<
        public static int lastIndex = -1;

        public static int[] redBall = new int[redBallHopperCount];

        public static int[] whiteBall = new int[whiteBallHopperCount];

        public static int[] whiteBallPicks = new int[numOfWhiteBallsToBeDrawn];

        public static int[] whiteBall2 = new int[whiteBallHopperCount];

        public static int[] whiteBallPicks2 = new int[numOfWhiteBallsToBeDrawn];


        //Empty constructor for PowerballForm.
        public PowerballForm()
        {
            InitializeComponent();

            //Set the title caption on the form.
            this.Text = "PowerBall Simulator - Written by Patrick Hill";
        }

        //This event fires as the form first loads into memory.
        private void PowerballForm_Load(object sender, EventArgs e)
        {
            //Make sure the Reset button is disabled on startup.
            resetButton.Enabled = false;

            //Set the focus to the Simulate Game button.
            simulateGameButton.Focus();
        }

        //This event fires when the user clicks the button to simulate the game.
        private void simulateGameButton_Click(object sender, EventArgs e)
        {
            //Create new random number generator to pick white balls.
            whiteBallPicker = new Random();

            //Run a delay of 1/2 second to ensure that the white ball
            //random number generator and the red ball random number
            //generator are created with different seed values.  Since
            //the constructor for Random uses a date/time stamp as the
            //seed value, it is possible for two random generators created
            //one after the other to have the same seed and therefore
            //generate the same random number sequence.  The delay
            //keeps that from happening.
            Delay(delayConstTimeMilliseconds);

            //Create new random number generator to pick red balls.
            redBallPicker = new Random();

            //Disable the Simulate Game button.
            simulateGameButton.Enabled = false;

            //Disable the Reset button.
            resetButton.Enabled = false;

            //Disable the Display Odds button.
            displayOddsButton.Enabled = false;

            //Set the cursor on the form to the spinning circle thing.
            Cursor = Cursors.WaitCursor;

            //Add the event handler for our animation timer.
            animationTimer.Tick += new EventHandler(AnimateTheForm);

            //Set the animation timer to the specified interval constant.
            animationTimer.Interval = animationConstIntervalMilliseconds;

            //Initially display the "Working" animation on the form.
            workingDotCount = 0;
            workingMsgLabel.Text = "Working.";
            workingMsgLabel.Visible = true;

            totalNumberOfDraws = 0;

            //>>>>>>You will need to declare any local varibles you need here<<<<<<
            //>>>>>>as well as the coding to pick the "Winners".             <<<<<<

            //Red Ball Winning Number
            int redBallWinner = redBallPicker.Next(1, (redBallHopperCount + 1));
            redWinnerLabel.Text = redBallWinner.ToString();


            //White Ball Winning Numbers
            for (int i = 0; i < whiteBall.Length; i++)
            {
                whiteBall[i] = i + 1;//filling the array from 1-69
            }

            lastIndex = (whiteBall.Length - 1);

            int pickIndex = -1;

            //Loop 5 times to get 5 White Ball Winners
            for (int i = 0; i < numOfWhiteBallsToBeDrawn; i++)
            {
                pickIndex = whiteBallPicker.Next(0, (lastIndex + 1));

                whiteBallPicks[i] = whiteBall[pickIndex]; //Places the pickindex value into the whiteballpicks array

                for (int a = 0; a < lastIndex; a++)
                {
                    whiteBall[a] = whiteBall[(a + 1)];
                }

                lastIndex --;

            }

            //sort the 5 winning numbers
            Array.Sort(whiteBallPicks);
            //Display each winning Number 
            whiteWinnerLabel01.Text = whiteBallPicks[0].ToString();
            whiteWinnerLabel02.Text = whiteBallPicks[1].ToString();
            whiteWinnerLabel03.Text = whiteBallPicks[2].ToString();
            whiteWinnerLabel04.Text = whiteBallPicks[3].ToString();
            whiteWinnerLabel05.Text = whiteBallPicks[4].ToString();
            //Refresh our "winner" labels so they will show the
            //winning numbers we just picked.
            whiteWinnerLabel01.Refresh();
            whiteWinnerLabel02.Refresh();
            whiteWinnerLabel03.Refresh();
            whiteWinnerLabel04.Refresh();
            whiteWinnerLabel05.Refresh();
            redWinnerLabel.Refresh();

            //Start the animation timer:
            animationTimer.Start();

            //Driving loop to keep drawing until we match all 5 winning white balls and
            //the 1 winning red ball - at $2 a draw, get your wallet out!!
            while (true)
            {
                //Call the DoEvents method once each loop to allow the form
                //to process all queued events in the event queue (needed
                //for our "animation" of the draw count and "Working" animation.
                Application.DoEvents();
                totalNumberOfDraws++;
                //>>>>>>You will need to declare any local varibles you need here<<<<<<
                //>>>>>>as well as the coding to pick the "Our Picks"            <<<<<<

                //Red Ball Pick 
                int redBallPick = redBallPicker.Next(1, (redBallHopperCount + 1));
                //Check for Red Ball Match first - then continue to White Ball Match
                if (redBallWinner == redBallPick)
                {
                    for (int i = 0; i < whiteBall.Length; i++)
                    {
                    whiteBall2[i] = i + 1;//filling the array from 1-69
                    }

                    lastIndex = (whiteBall2.Length - 1);

                     int pickIndex2 = -1;

                //Loop 5 times to get 5 White Ball Winners

                     for (int i = 0; i < numOfWhiteBallsToBeDrawn; i++)
                    {
                         pickIndex2 = whiteBallPicker.Next(0, (lastIndex + 1));

                         whiteBallPicks2[i] = whiteBall2[pickIndex2]; //Places the pickindex value into the whiteballpicks array

                      for (int a = 0; a < lastIndex; a++)
                     {
                        whiteBall2[a] = whiteBall2[(a + 1)];
                     }

                    lastIndex--;

                }
                //sort the 5 winning numbers
                Array.Sort(whiteBallPicks2);

                    if (
                        whiteBallPicks2[0] == whiteBallPicks[0]
                        && whiteBallPicks2[1] == whiteBallPicks[1]
                        && whiteBallPicks2[2] == whiteBallPicks[2]
                        && whiteBallPicks2[3] == whiteBallPicks[3]
                        && whiteBallPicks2[4] == whiteBallPicks[4]
                        )
                    {
                        //  Display each pick Number 
                        redPickLabel.Text = redBallPick.ToString();
                        whitePickLabel01.Text = whiteBallPicks2[0].ToString();
                        whitePickLabel02.Text = whiteBallPicks2[1].ToString();
                        whitePickLabel03.Text = whiteBallPicks2[2].ToString();
                        whitePickLabel04.Text = whiteBallPicks2[3].ToString();
                        whitePickLabel05.Text = whiteBallPicks2[4].ToString();
                        //Refresh our "pick" labels so they will show the
                        //matching winning numbers we just picked.
                        whitePickLabel01.Refresh();
                        whitePickLabel02.Refresh();
                        whitePickLabel03.Refresh();
                        whitePickLabel04.Refresh();
                        whitePickLabel05.Refresh();

                        redPickLabel.Refresh();


                        //>>>>>>You will need a break somewhere once                     <<<<<<
                        //>>>>>>you match the winning picks.                             <<<<<<
                        break;
                    }
                }
                else
                {
                    continue;
                }
            }

            //Stop the animation timer since we don't want any more
            //animations once we have drawn the picks that match the
            //winning numbers.
            animationTimer.Stop();

            //Hide the "Working" animation.
            workingMsgLabel.Visible = false;

            //Enable the Reset button.
            resetButton.Enabled = true;

            //Enable the Reset button.
            displayOddsButton.Enabled = true;

            //Set the focus to the Reset button.
            resetButton.Focus();

            //Set the form cursor back to the arrow.
            Cursor = Cursors.Default;
        }

        //Event handler that is fired by our animationTimer each time the Interval elapses.
        private void AnimateTheForm(Object myObject, EventArgs myEventArgs)
        {
            //Display the current draw count on the windows form:
         
            drawCountLabel.Text = totalNumberOfDraws.ToString("n0");

            //Refresh the draw count label so it will display.
            drawCountLabel.Refresh();

            //Increment the "dot" count for our "Working" animation.
            workingDotCount++;

            //If the display of "dots" gets near the right side of the form,
            //clear it and start again right after the "Working" text.
            if (workingDotCount > 65)
            {
                workingDotCount = 0;
                workingMsgLabel.Text = "Working.";
            }
            else
            {
                //Otherwise, add one more "dot" to the "Working" display.
                workingMsgLabel.Text = workingMsgLabel.Text + ".";
            }

            //Refresh the "Working" label.
            workingMsgLabel.Refresh();
        }

        //A simple delay method that lets us delay the program
        //by the specified milliseconds.  We use this method
        //to cause a delay between creating the two random number
        //generator objects used to draw the white balls and the
        //red balls so that we can ensure that the generators are
        //created with different seed values.
        private void Delay(int delayInMilliseconds)
        {
            int i = 0;

            //Create a timer object to use for the delay.
            System.Timers.Timer delayTimer = new System.Timers.Timer();

            //Set the firing interval to the incoming value.
            delayTimer.Interval = delayInMilliseconds;

            //Tell the timer to run only once.
            delayTimer.AutoReset = false;

            //After the timer has run for the specified interval,
            //tell it what event handler to run.  In this case,
            //we set it to an anounymous event handler that simply
            //sets i to 1.
            delayTimer.Elapsed += (s, args) => i = 1;

            //Start the timer.
            delayTimer.Start();

            //Give the Delay method something to do while
            //the timer is running.  Once .Elapsed fires,
            //it will be set to 1 and this loop will end and
            //thus the entire method will end.
            while (i == 0)
            {
            }
        }

        //Event handler that calculates and displays a message box with the odds
        //for winning the PowerBall game.
        private void displayOddsButton_Click(object sender, EventArgs e)
        {
            int workWhiteBalls = whiteBallHopperCount;
            
            int workRedBalls = redBallHopperCount;

            int workWhiteBallPicks = numOfWhiteBallsToBeDrawn;

            double probabilityOfWinning = 1;

            int oddsOfWinning = 0;

            string s = "The odds of winning the PowerBall jackpot are calculated as follows:\n\n";

            /*  5 out of 69 probability for the first white ball.
                4 out of 68 probability for the second white ball.
                3 out of 67 probability for the third white ball.
                2 out of 66 probability for the fourth white ball.
                1 out of 65 probability for the fifth white ball.

                We multiply each of these probabilities together since
                this is an "and" condition - 5 out of 69 AND 4 out of 68, etc.
            */
            for (int i = workWhiteBallPicks; i >= 1; i--)
            {
                probabilityOfWinning = probabilityOfWinning * ((double)i / (workWhiteBalls - (5 - i)));

                s = s + i + "/" + (workWhiteBalls - (5 - i)) + " * ";
            }

            //Red ball only has one draw, so it is straight probability but we multiply
            //it times the probability calculated above since, again, it is an "and" condition.
            probabilityOfWinning = probabilityOfWinning * ((double)1 / workRedBalls);

            s = s + 1 + "/" + workRedBalls + " = " + probabilityOfWinning.ToString("n20") + "!\n\n";

            //To calculate the odds of winning, take the probability and divide it into 1.
            oddsOfWinning = (int)(1 / probabilityOfWinning);

            s = s + "Or, expressed in odds format, we have 1 chance in every " + oddsOfWinning.ToString("n0") + " draws of picking the winning numbers!!!";

            MessageBox.Show(s,"Odds of Winning",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        //Reset button click event handler.
        private void resetButton_Click(object sender, EventArgs e)
        {
            //Enable the Simulate Game button.
            simulateGameButton.Enabled = true;

            //Set the focus to the Simulate Game button.
            simulateGameButton.Focus();

            //Loop through the winforms controls collection to clear each of the
            //12 labels that display the powerball picks. We could reference
            //each of the labels by name, but this seemed simpler.
            foreach (var ctrl in Controls)
            {
                if (ctrl.GetType() == typeof(GroupBox))
                {
                    GroupBox gbx = ctrl as GroupBox;

                    foreach (var gbxCtrl in gbx.Controls)
                    {
                        Label lbl = (Label)gbxCtrl;

                        if (lbl.BackColor == Color.Yellow || lbl.BackColor == Color.Red)
                        {
                            lbl.Text = "";
                        }        
                    }                   
                }      
            }

            //Clear the draw count label.
            drawCountLabel.Text = "";

            //Disable the Reset button before we leave.
            resetButton.Enabled = false;
        }
    }
}
