using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Register_Form : Form
    {
        // string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SANKALPA\OneDrive\Desktop\WinFormsApp1\Registration.mdf;Integrated Security=True";
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\SANKALPA\OneDrive\Desktop\Modern Flat UI - NSlink\Modern Flat UI - NSlink\Database1.mdf"";Integrated Security=True");
        public Register_Form()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Register_Form_Load(object sender, EventArgs e)
        {

        }

        private Guna.UI2.WinForms.Guna2ComboBox GetCboFaculty()
        {
            return cboFaculty;
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {

                {
                    string FirstName = txtFirstName.Text;
                    string LastName = txtLastName.Text;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    string SelectedItem = cboFaculty.SelectedItem.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    string UserName = txtUserName.Text;
                    string PrivateEmail = txtPrivateEmail.Text;
                    string StudentID = txtStudentID.Text;

                    string query = "INSERT INTO  Registration(FirstName,LastName,Batch,UserName,PrivateEmail,StudentID) VALUES (@FirstName,@LastName,@Batch,@UserName,@PrivateEmail,@StudentID)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@Batch", SelectedItem);
                        command.Parameters.AddWithValue("@UserName", UserName);
                        command.Parameters.AddWithValue("@PrivateEmail", PrivateEmail);
                        command.Parameters.AddWithValue("@StudentID", StudentID);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("You have successfully Registered,Please Log in");
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
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
