using Modern_Flat_UI___NSlink;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\SANKALPA\OneDrive\Desktop\Modern Flat UI - NSlink\Modern Flat UI - NSlink\Database1.mdf"";Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Register_Form register_Form = new Register_Form();
            this.Hide();
            register_Form.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtStudentID.Text.Trim();


            string query = "SELECT * FROM Registration WHERE UserName = @username AND StudentID = @password";

            try
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {

                        FrmMain form = new FrmMain();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }

                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

