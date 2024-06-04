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
    public partial class Inicio : Form
    {
        private string connectionString = "Data Source=DESKTOP-19M62MH;Initial Catalog=RadiantRealms; Integrated security=true"; // cadena de conexión
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnReduceLog_Click(object sender, EventArgs e)
        {
            try
            {
                string reduceLogQuery = @"
                USE RadiantRealms;
                DBCC SHRINKFILE (N'RadiantRealms_log' , 1);
                BACKUP LOG RadiantRealms WITH TRUNCATE_ONLY;
                DBCC SHRINKFILE (N'RadiantRealms_log' , 1);";

                ExecuteNonQuery(reduceLogQuery);
                MessageBox.Show("Log file reduced successfully.");
            }
            catch
            {
                MessageBox.Show("No se pudo completar la operación");
            }
        }
        private void ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
