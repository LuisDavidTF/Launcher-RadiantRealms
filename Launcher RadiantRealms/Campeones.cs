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

namespace Launcher_RadiantRealms
{
    public partial class Campeones : Form
    {
        private string connectionString = "Data Source=DESKTOP-19M62MH;Initial Catalog=RadiantRealms; Integrated security=true"; // cadena de conexión
        public Campeones()
        {
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cadena_instruccion = "SELECT * FROM campeones";
                SqlDataAdapter adapter = new SqlDataAdapter(cadena_instruccion, connection);
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds;
                dataGridView1.Refresh();
            }
        }

        private void btnAddCampeon_Click(object sender, EventArgs e)
        {
            string nombre_campeon = txtNombre_Campeon.Text;
            string tipo_campeon = txtTipo_Campeon.Text;
            int puntuacion = Int16.Parse(txtPuntuacion.Text);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string cadena_instruccion = "SELECT * FROM campeones";
                SqlDataAdapter adapter = new SqlDataAdapter(cadena_instruccion, connection);
                DataTable ds = new DataTable();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds;
                dataGridView1.Refresh();

                using (SqlCommand command = new SqlCommand("InsertarCampeon", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@nombre_campeon", nombre_campeon));
                    command.Parameters.Add(new SqlParameter("@tipo_campeon", tipo_campeon));
                    command.Parameters.Add(new SqlParameter("@puntuacion", puntuacion));

                    command.ExecuteNonQuery();
                }

            }
            txtPuntuacion.Clear();
            txtNombre_Campeon.Clear();
            txtTipo_Campeon.Clear();
            MessageBox.Show("Campeon Añadido");
        }
    }
}
