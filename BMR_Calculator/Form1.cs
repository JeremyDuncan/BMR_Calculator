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
            int age = int.Parse(CheckBox.Text);
            int weight = int.Parse(CheckBox.Text);
            int height = int.Parse();
            int result = 0;
            string sex = "";



            resultsLabel.Text = "Your BMR is: " + result;
        }
    }
}