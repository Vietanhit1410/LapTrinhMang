using BUS;
namespace QuanLiTuDien
{
    public partial class Form1 : Form
    {
        string id = "";
        string tu = "";
        string nghia = "";
        BUS_query busQuery = new BUS_query();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busQuery.Hienthi();
            label4.Text = "";
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && richTextBox1.Text != "")
            {
                if (busQuery.Them(textBox1.Text,richTextBox1.Text)) MessageBox.Show("Them thanh cong");
                else MessageBox.Show("Them khong thanh cong");
                dataGridView1.DataSource = busQuery.Hienthi();
                label4.Text = "";
                textBox1.Text = "";
                richTextBox1.Text = "";

            }
            else label4.Text = "Vui long nhap thong tin";


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = row.Cells[0].Value.ToString();
                tu = row.Cells[1].Value.ToString();
                nghia = row.Cells[2].Value.ToString();
                textBox1.Text = tu;
                richTextBox1.Text = nghia;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && richTextBox1.Text != "")
            {
                if (busQuery.Sua(int.Parse(id), tu, nghia)) MessageBox.Show("Sua thanh cong");
                else MessageBox.Show("Sua khong thanh cong");
                dataGridView1.DataSource = busQuery.Hienthi();
                label4.Text = "";
                textBox1.Text = "";
                richTextBox1.Text = "";
            }
            else label4.Text = "Vui long nhap thong tin";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && richTextBox1.Text != "")
            {
                if (busQuery.Xoa(int.Parse(id))) MessageBox.Show("Xoa thanh cong");
                else MessageBox.Show("Xoa khong thanh cong");
                dataGridView1.DataSource = busQuery.Hienthi();
                label4.Text = "";
                textBox1.Text = "";
                richTextBox1.Text = "";

            }
            else label4.Text = "Vui long nhap thong tin";
        }
    }
}
