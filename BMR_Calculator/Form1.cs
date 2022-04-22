namespace BMR_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            int age = int.Parse(inputAge.Text);
            int weight = int.Parse(inputWeight.Text);
            int height = int.Parse(inputHeight.Text);
            int result = 0;

            string sex = "";
            if (maleCheckbox.Checked)
            {
                sex = "m";
            }
            if (femaleCheckbox.Checked)
            {
                sex = "f";
            }

            resultsLabel.Text = "Your BMR is: " + result;
        }
    }
}