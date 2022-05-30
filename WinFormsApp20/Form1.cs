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
                pnumber = maskedTextBox1.Text,
               
                rdbtn1 = radioButton1.Checked ? "Male" : "Female",
                Birthtime = dateTimePicker1.Value
            
            
            };
             
            
            var nuser = JsonConvert.SerializeObject(user, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText($"{textBox2.Text}.json", nuser);
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            textBox6.ResetText();
            maskedTextBox1.ResetText();
            dateTimePicker1.Value = DateTime.Now;






        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists($"{textBox1.Text.ToUpper()}.json"))
            {
                var user = new User();
                var jsonStr = File.ReadAllText($"{textBox1.Text}.json");
                user = JsonConvert.DeserializeObject<User>(jsonStr);

                textBox2.Text = user?.name;
                textBox3.Text = user?.surname;
                textBox4.Text = user?.fname;
                textBox5.Text = user?.country;
                textBox6.Text = user?.city;
                maskedTextBox1.Text = user?.pnumber;
                //dateTimePicker1.Value = user?.BirthTime;

                if (user?.rdbtn1 == "Male")
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;

            }

            else
            {
                MessageBox.Show("User not find!", "Load Informations", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}