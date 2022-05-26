using Newtonsoft.Json;

namespace WinFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                name = textBox2.Text,
                surname = textBox3.Text,
                fname = textBox4.Text,
                country = textBox5.Text,
                city = textBox6.Text,
            };
            
            string JsonOutput = JsonConvert.SerializeObject(user);
            
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            
        }
    }
}