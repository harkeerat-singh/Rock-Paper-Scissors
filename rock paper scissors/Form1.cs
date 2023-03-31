namespace rock_paper_scissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 3;
        


        void computerplay(string p)
        {
            youbox.Text = p ;


            string[] options = { "ROCK", "PAPER", "SCISSORS" };

            Random rnd = new Random();




            

            int pos = rnd.Next(0, 3);
            string c = options[pos];




            compbox.Text = c;

            if (p == "ROCK" && c == "SCISSORS" || p == "PAPER" && c == "ROCK" || p == "SCISSORS" && c == "PAPER" )
            {
                output.Text = "PLAYER WINS";
            }
            else if(c == "ROCK" && p == "SCISSORS" || c == "PAPER" && p == "ROCK" || c == "SCISSORS" && p == "PAPER")
            {
                output.Text = "COMPUTER WINS";
            }
            else
            {
                output.Text = "DRAW";
            }

        }


        private void rockbtn_Click(object sender, EventArgs e)
        {
            computerplay(rockbtn.Text);
        }

        private void paperbtn_Click(object sender, EventArgs e)
        {
            computerplay(paperbtn.Text);
        }

        private void scibtn_Click(object sender, EventArgs e)
        {
            computerplay(scibtn.Text);
        }

        
    }
}