using System;
namespace Password_Generator
{
    public partial class PassGen_Main : Form
    {

        public PassGen_Main()
        {
            InitializeComponent();
        }

        //generates the password
        private void button_generatepass_Click(object sender, EventArgs e)
        {
            //ignore, can be removed
            if (Convert.ToInt16(textbox_PassLen.Text) > 50)
                label_message.Text = textbox_PassLen.Text + "! Really Bruh? Sus";
            else if (Convert.ToInt16(textbox_PassLen.Text) < 50)
                label_message.Text = "";

            //character set
            string lowCase = "abcdefghijklmnopqrstuvxyz";
            string upCase = "ABCDEFGHIJKLMNOPQRSTUVXYZ";
            string Numbers = "0123456789";
            string SpecialChar = "£$&()*+[]@#^-_!?";

            try
            {
                int passLength = Convert.ToInt16(textbox_PassLen.Text);
                string password = "";

                for (int i = 0; i < passLength; i++)
                {
                    Random rand = new Random();
                    int choose_char_set = rand.Next(1, 5); //choose character set randomly
                    switch (choose_char_set)
                    {
                        case 1: //select a random lowercase character
                            int random_character_index = rand.Next(25);
                            if (checkBox_ambiguous.Checked == true)//avoid amgiguous character "l" lowercase L
                                if (lowCase[random_character_index] != 'l')
                                    password = password + lowCase[random_character_index];
                                else passLength++; //if an ambiguous character is selected randomly, the iteration is wasted and hence ++
                            else password = password + lowCase[random_character_index];
                            break;

                        case 2: //select a random uppercase character
                            random_character_index = rand.Next(25);
                            if (checkBox_ambiguous.Checked == true) //avoid ambiguous characters "I" uppercase i and "O" uppercase o
                                if (upCase[random_character_index] != 'I' && upCase[random_character_index] != 'O')
                                    password = password + upCase[random_character_index];
                                else passLength++; //if an ambiguous character is selected randomly, the iteration is wasted and hence ++
                            else password = password + upCase[random_character_index];
                            break;

                        case 3: //select a random number
                            if (checkBox_num.Checked)
                            {
                                random_character_index = rand.Next(10);
                                if (checkBox_ambiguous.Checked == true) //avoid ambiguous characters "0" zero and "1" one
                                    if (Numbers[random_character_index] != '0' && Numbers[random_character_index] != '1')
                                        password = password + Numbers[random_character_index];
                                    else passLength++; //if an ambiguous character is selected randomly, the iteration is wasted and hence ++
                                else password = password + Numbers[random_character_index];
                            }
                            else passLength++; //if Number checkbox is disabled, this current iteration is wasted
                            break;

                        case 4: //select a random special character
                            if (checkBox_spechar.Checked)
                            {
                                random_character_index = rand.Next(16);
                                password = password + SpecialChar[random_character_index];
                            }
                            else passLength++; //if special character checkbox is disabled, this current iteration is wasted
                            break;
                    }
                }
                textBox_password.Text = password;
                button_copy.Text = "Copy";
                password = "";
            }
            catch (Exception ex)
            {
                string errormsg = Convert.ToString(ex);
                MessageBox.Show(errormsg);
            }
        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox_password.Text);
            button_copy.Text = "Copied!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textbox_PassLen.Text = "25";
            checkBox_num.Checked = true;
            checkBox_spechar.Checked = true;
            checkBox_ambiguous.Checked = true;
            button_generatepass.PerformClick();
            textbox_PassLen.Select();
            //set cursor at the end
            textbox_PassLen.Focus();
            textbox_PassLen.SelectionStart = textbox_PassLen.Text.Length;
        }

        private void trackBar1_Scroll(object sender, EventArgs e) //update textBox_passlen value when trackBar_passlen is scrolled
        {
            textbox_PassLen.Text = Convert.ToString(trackBar_passlen.Value);
        }

        private void textbox_PassLen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8); //only numbers and backspace is accepted

            //resets max value to 128 when trying to enter a 4 digit number
            int box_int = 0; Int32.TryParse(textbox_PassLen.Text, out box_int);
            if (box_int > 128 && textbox_PassLen.Text != "") { textbox_PassLen.Text = "128"; }

            //set cursor at the end
            textbox_PassLen.Focus();
            textbox_PassLen.SelectionStart = textbox_PassLen.Text.Length;
        }

        private void textbox_PassLen_TextChanged(object sender, EventArgs e)
        {
            //textbox accepts three digit numbers greater than 128, below code resets that to 128
            if (textbox_PassLen.Text != "")//empty textbox_PassLen throws error in the below if statement
            {
                if (Convert.ToInt16(textbox_PassLen.Text) > 128)
                {
                    //set textbox_passlen and trackbar_passlen to 128
                    textbox_PassLen.Text = "128";
                    trackBar_passlen.Value = 128;

                    //set cursor at the end
                    textbox_PassLen.Focus();
                    textbox_PassLen.SelectionStart = textbox_PassLen.Text.Length;
                }
                else
                    trackBar_passlen.Value = Convert.ToInt16(textbox_PassLen.Text);
            }
        }

        private void button_esc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}