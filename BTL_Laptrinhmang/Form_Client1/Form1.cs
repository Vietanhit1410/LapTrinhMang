using Client_tcp;
namespace Form_Client1
{
    public partial class Form1 : Form
    {
        Client client = new Client();
        string id = "";
        string[] trans = new string[3];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            textBox2.Visible = false;
            richTextBox2.Visible = false;
            label3.Visible = false;
            button4.Visible = false;
            listBox1.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                listBox1.Visible = false;
                richTextBox1.Text = "";
                
            }
            else
            {
                listBox1.Items.Clear();
                string[] strings = client.client_request_list(textBox1.Text).Split(',');
                for (int i = 0; i < strings.Length; i++)
                {
                    listBox1.Items.Add(strings[i]);
                }
                foreach (string s in strings)
                {
                    if (s != "") listBox1.Visible = true;
                    else
                    {
                        listBox1.Visible = true;
                        listBox1.Items.Add("Khong tim thay ket qua");
                    };
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Visible = false;
                trans = client.client_request_TraTu(textBox1.Text).Split(',');
                if (trans[0] != "0")
                {
                    richTextBox1.Text = trans[2];
                    button2.Visible = true;
                    id = trans[0];
                    richTextBox1.Enabled = false;
                }
                else
                {
                    richTextBox1.Text = $"Từ {textBox1.Text} không có trong từ điển";
                    button2.Visible = false;
                    richTextBox1.Enabled = false;

                }
            }
            else MessageBox.Show("Không được để trống từ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            textBox2.Visible = true;
            richTextBox2.Visible = true;
            label3.Visible = true;

            textBox1.Enabled = false;
            richTextBox1.Enabled = false;
            textBox2.Text = textBox1.Text;
            textBox2.Enabled = false;
            richTextBox2.Text = richTextBox1.Text;
            button4.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox2 != null)
            {
                List<string> strings = new List<string> { id, textBox2.Text, richTextBox2.Text.ToString() };
                MessageBox.Show(client.client_request_Gopy(strings));
                button2.Visible = false;
                button3.Visible = false;
                textBox2.Visible = false;
                richTextBox2.Visible = false;
                label3.Visible = false;
                textBox1.Enabled = true;
                richTextBox1.Enabled = true;
                button4.Visible = false;

            }
            else { MessageBox.Show("Không được để trống"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            textBox2.Visible = false;
            richTextBox2.Visible = false;
            label3.Visible = false;
            textBox1.Enabled = true;
            richTextBox1.Enabled = true;
            button4.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {  
            
                textBox1.Text = listBox1.SelectedItem.ToString();
                listBox1.Visible = false;
        }
    }
}
