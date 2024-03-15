namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int compChoice;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            userChoicelbl.Text = "rock";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            userChoicelbl.Text = "scissor";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            userChoicelbl.Text = "paper";
        }

        private void generateRandom()
        {
            
            var rand = new Random();
            compChoice = rand.Next(1, 4);
            
        }

        private void computerChoice()
        {
            generateRandom();

            if (compChoice == 1)
            {
                compChoicelbl.Text = "rock";
            }
            else if (compChoice == 2)
            {
                compChoicelbl.Text = "scissor";
            }
            else if (compChoice == 3)
            {
                compChoicelbl.Text = "paper";
            }
            
        }



        private void playBtn_Click(object sender, EventArgs e)
        {
            computerChoice();

            if (userChoicelbl.Text == "rock" && compChoicelbl.Text == "scissor")
            {
                compChoicelbl.Text = "scissor";
                MessageBox.Show(" rock Smashes "+" scissor," + " Chris Kuete won !!");

            }else if (userChoicelbl.Text == "scissor" && compChoicelbl.Text == "rock")
            {
                compChoicelbl.Text = "rock";
                MessageBox.Show(" rock Smashes " + " scissor," + " computer WON !!");

            }
            else if(userChoicelbl.Text == "rock" && compChoicelbl.Text == "paper")
            {
                compChoicelbl.Text = "paper";
                MessageBox.Show(" paper wraps rock, computer WON");

            }else if(userChoicelbl.Text == "paper" && compChoicelbl.Text == "rock")
            {
                compChoicelbl.Text = "rock";
                MessageBox.Show(" paper wraps rock, Chris kuete WON");


            }else if(userChoicelbl.Text == "scissor" && compChoicelbl.Text == "paper")
            {
                compChoicelbl.Text = "paper";
                MessageBox.Show(" scissor cuts paper, Chris kuete WON");

            }else if(userChoicelbl.Text == "paper" && compChoicelbl.Text == "scissor")
            {
                compChoicelbl.Text = "scissor";
                MessageBox.Show(" scissor cuts paper, computer WON");
            }
            else if (userChoicelbl.Text == "scissor" && compChoicelbl.Text == "scissor")
            {
                compChoicelbl.Text = "scissor";
                MessageBox.Show(" Tie game, Start again");
            }
            else if (userChoicelbl.Text == "rock" && compChoicelbl.Text == "rock")
            {
                compChoicelbl.Text = "rock";
                MessageBox.Show(" Tie game, Start again");
            }
            else if (userChoicelbl.Text == "paper" && compChoicelbl.Text == "paper")
            {
                compChoicelbl.Text = "paper";
                MessageBox.Show(" Tie game, Start again");
            }

            compChoicelbl.Text = "";

        }
    

    private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
