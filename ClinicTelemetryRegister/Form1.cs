using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClinicTelemetryRegister
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           LoadDevices();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con =
        new SqlConnection(DataBaseHelper.connectionString);

            try
            {
                con.Open();

                string query = @"INSERT INTO MedicalDevices VALUES(@id,@name,@battery,@ward,@type,@special)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@battery", batterylife.Value);
                cmd.Parameters.AddWithValue("@ward", wardnumber.Value);
                cmd.Parameters.AddWithValue("@type", devicetype.Text);
                cmd.Parameters.AddWithValue("@special", special.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Device Registered");

                LoadDevices();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(DataBaseHelper.connectionString);

            try
            {
                con.Open();

                SqlCommand cmd =
                new SqlCommand(
                "DELETE FROM MedicalDevices WHERE DeviceID=@id",
                con);

                cmd.Parameters.AddWithValue("@id", id.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Deleted");

                LoadDevices();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }
        private void LoadDevices()
        {
            SqlConnection con = new SqlConnection(DataBaseHelper.connectionString);

            try
            {
                con.Open();

                string query = "SELECT * FROM MedicalDevices";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvDevices.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDevices();
        }
    }
}
