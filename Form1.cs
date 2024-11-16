namespace MyWindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Button rockButton;
        private Button paperButton;
        private Button scissorsButton;
        private Label resultLabel;
        private Label playerChoiceLabel;
        private Label computerChoiceLabel;

        public Form1()
        {
            InitializeComponent();
            SetupForm();
            AddControls();
        }

        private void SetupForm()
        {
            // Basic form settings
            this.Text = "Rock Paper Scissors";
            this.Size = new Size(400, 300);
        }

        private void AddControls()
        {
            // Create and setup Rock Button
            rockButton = new Button
            {
                Text = "Rock",
                Location = new Point(20, 20),
                Size = new Size(100, 30)
            };
            rockButton.Click += RockButton_Click;

            // Create and setup Paper Button
            paperButton = new Button
            {
                Text = "Paper",
                Location = new Point(140, 20),
                Size = new Size(100, 30)
            };
            paperButton.Click += PaperButton_Click;

            // Create and setup Scissors Button
            scissorsButton = new Button
            {
                Text = "Scissors",
                Location = new Point(260, 20),
                Size = new Size(100, 30)
            };
            scissorsButton.Click += ScissorsButton_Click;

            // Create and setup Result Label
            resultLabel = new Label
            {
                Text = "Result will appear here",
                Location = new Point(20, 70),
                Size = new Size(320, 30),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Create and setup Player Choice Label
            playerChoiceLabel = new Label
            {
                Text = "Your Choice: ",
                Location = new Point(20, 120),
                Size = new Size(120, 20)
            };

            // Create and setup Computer Choice Label
            computerChoiceLabel = new Label
            {
                Text = "Computer Choice: ",
                Location = new Point(220, 120),
                Size = new Size(120, 20)
            };

            // Add controls to form
            this.Controls.Add(rockButton);
            this.Controls.Add(paperButton);
            this.Controls.Add(scissorsButton);
            this.Controls.Add(resultLabel);
            this.Controls.Add(playerChoiceLabel);
            this.Controls.Add(computerChoiceLabel);
        }

        private void RockButton_Click(object sender, EventArgs e)
        {
            PlayGame("Rock");
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            PlayGame("Paper");
        }

        private void ScissorsButton_Click(object sender, EventArgs e)
        {
            PlayGame("Scissors");
        }

        private void PlayGame(string playerChoice)
        {
            string[] options = { "Rock", "Paper", "Scissors" };
            string computerChoice = options[new Random().Next(3)];

             Console.WriteLine($"Player choice: {playerChoice}");
            Console.WriteLine($"Computer choice: {computerChoice}");
    

            playerChoiceLabel.Text = $"Your Choice: {playerChoice}";
            computerChoiceLabel.Text = $"Computer Choice: {computerChoice}";

            if (playerChoice == computerChoice)
            {
                resultLabel.Text = "It's a tie!";
            }
            else if (
                (playerChoice == "Rock" && computerChoice == "Scissors") ||
                (playerChoice == "Paper" && computerChoice == "Rock") ||
                (playerChoice == "Scissors" && computerChoice == "Paper"))
            {
                resultLabel.Text = "You win!";
            }
            else
            {
                resultLabel.Text = "Computer wins!";
            }
        }
    }
}