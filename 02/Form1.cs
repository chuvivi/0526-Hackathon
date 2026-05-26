namespace _02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double input = double.Parse(txtInput.Text);

            if (rdoCtoF.Checked)
            {
                double f = 9.0 / 5.0 * input + 32;
                lblResult.Text = $"結果: {input} ℃ = {f} ℉ ";
            }
            else if (rdoFtoC.Checked)
            {
                double c = (input - 32) * 5.0 / 9.0;
                lblResult.Text = $"結果: {input} ℉ = {c} ℃ ";
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            lblResult.Text = "";
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button clickedbutton = (Button)sender;
            txtInput.Text += clickedbutton.Text;
        }

    }
}
