namespace Individual_Assignment_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = calculate(numericUpDown1.Value).ToString();
        }

        private Int64 calculate(decimal value)
        {
            Int64 result = 1;
            for (int i = 1; i < value; i++)
            {
                result += result * i;
            }
            return result;
        }
    }
}