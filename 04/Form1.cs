namespace _04
{
    public partial class Form1 : Form
    {
        private string answer = "";

        public Form1()
        {
            InitializeComponent();
            btnCheck.Enabled = false;
            btnRestart.Enabled = false;
        }

        private void CreateAnswer()
        {
            Random random = new Random();

            List<int> numbers = new List<int>();

            while (numbers.Count < 4)
            {
                int number = random.Next(0, 10);

                if (!numbers.Contains(number))
                {
                    numbers.Add(number);
                }
            }

            answer = string.Join("", numbers);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            CreateAnswer();

            lstHistory.Items.Clear();
            txtGuess.Text = "";

            btnStart.Enabled = false;
            btnCheck.Enabled = true;
            btnRestart.Enabled = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text;

            int a = 0;
            int b = 0;

            if (guess.Length != 4)
            {
                MessageBox.Show("請輸入4個數字");
                return;
            }

            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == answer[i])
                {
                    a++;
                }
                else if (answer.Contains(guess[i]))
                {
                    b++;
                }
            }

            string result = $"{guess} : {a}A{b}B";
            lstHistory.Items.Add(result);

            if (a == 4)
            {
                MessageBox.Show("過關！！！");
                btnCheck.Enabled = false;
                btnStart.Enabled = true;
                btnRestart.Enabled = false;
            }
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            if (answer == "")
            {
                MessageBox.Show("請先開始遊戲！");
                return;
            }

            MessageBox.Show($"答案是:{answer}");
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            CreateAnswer();

            txtGuess.Text = "";
            lstHistory.Items.Clear();

            btnStart.Enabled = false;
            btnCheck.Enabled = true;
            btnRestart.Enabled = true;

            MessageBox.Show("已重新開始~");
        }
    }
}
