using System.Net.Sockets;
using System.Net;
using System.Text;
using Org.BouncyCastle.Asn1.Ocsp;
using DTO;
using Client_tcp;

namespace BTL_Laptrinhmang
{
    public partial class Client1 : Form
    {
        string id = "";
        Client client = new Client();
        public Client1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            textBox2.Visible = false;
            richTextBox2.Visible = false;
            label3.Visible = false;
            button4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    string[] trans = client.client_request_TraTu(textBox1.Text).Split(',');
                    richTextBox1.Text = trans[2];
                    button2.Visible = true;
                    id = trans[0];
                    richTextBox1.Enabled = false;
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { richTextBox1.Text = ""; }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "") { richTextBox1.Text = ""; }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
