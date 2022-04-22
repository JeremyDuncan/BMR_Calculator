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
            int pounds = int.Parse(inputWeight.Text);
            int inches = int.Parse(inputHeight.Text);
            double bmr = 0;
            double kg = 0;
            double cm = 0;

            string sex = "";
            if (maleCheckbox.Checked == true && femaleCheckbox.Checked == true)
            {
                sex = "x";
            }
            else if (maleCheckbox.Checked)
            {
                sex = "m";
            }
            else if (femaleCheckbox.Checked)
            {
                sex = "f";
            }
            else
            {
                sex = "r";
            }

            kg = pounds * .4535927;
            cm = inches * 2.54;
            
            if (sex == "m")
            {
                bmr = 88.362 + (13.397 * kg) + (4.799 * cm) - (5.677 * age);
            }
            if (sex == "f")
            {
                bmr = 88.362 + (13.397 * kg) + (4.799 * cm) - (5.677 * age);
            }

            resultsLabel.Text = "Your BMR is: " + bmr + " calories";
        }
    }
}
