namespace height
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            string height = txtbox.Text;
            try
            {
                if (Convert.ToInt64(height) <= 5)
                {

                    MessageBox.Show("L short");
                    MessageBox.Show("Your height is " + height + " feet");
                }
                else if (Convert.ToInt64(height) >= 6) 
                {
                    
                    MessageBox.Show("W tall");
                    MessageBox.Show("Your height is " + height + " feet");
                    
                }
            }
            catch 
            {
                MessageBox.Show("hmmmm it seems like that wasnt a number...");
            }
            

        }
    }
}