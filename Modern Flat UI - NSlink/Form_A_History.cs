namespace Modern_Flat_UI___NSlink
{
    public partial class Form_A_History : Form
    {
        public Form_A_History()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form_A_History form_A_History = new Form_A_History();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
