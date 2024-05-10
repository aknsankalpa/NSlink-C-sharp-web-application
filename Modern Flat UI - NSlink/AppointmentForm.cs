using System.Data.SqlClient;

namespace Modern_Flat_UI___NSlink
{
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
        }

        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\SANKALPA\OneDrive\Desktop\Modern Flat UI - NSlink\Modern Flat UI - NSlink\Database1.mdf"";Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                {
                    string StudentID = textBox2.Text;
                    string Date = dateTimePicker1.Value.ToString();
                    string Comments = textBox4.Text;
                    string StudentName = textBox1.Text;
                    string Email = textBox3.Text;

                    string query = "INSERT INTO  Appointments(StudentID,Date,Comments,StudentName,Email) VALUES (@StudentID,@Date,@Comments,@StudentName,@Email)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", StudentID);
                        command.Parameters.AddWithValue("@Date", Date);
                        command.Parameters.AddWithValue("@Comments", Comments);
                        command.Parameters.AddWithValue("@StudentName", StudentName);
                        command.Parameters.AddWithValue("@Email", Email);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("You have successfully made an appointment!!");
                        }
                        else
                        {
                            MessageBox.Show("Error inserting record");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            FrmMain form1 = new FrmMain();
            form1.Show();
            this.Hide();
        }
    }
}

