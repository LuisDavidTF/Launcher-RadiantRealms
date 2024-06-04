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
    public partial class Perfil : Form
    {
        private string connectionString = "Data Source=DESKTOP-19M62MH;Initial Catalog=RadiantRealms; Integrated security=true"; // cadena de conexión
        public Perfil()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string backupFileName = txtBackupFileName.Text;
            if (string.IsNullOrEmpty(backupFileName))
            {
                MessageBox.Show("Please enter a backup file name.");
                return;
            }
            string backupQuery = $@"BACKUP DATABASE [RadiantRealms] TO DISK = '{backupFileName}'";

            ExecuteNonQuery(backupQuery);
            MessageBox.Show("Backup completed successfully.");
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

        private void btnCreateRoles_Click(object sender, EventArgs e)
        {
            string roleName = txtRoleName.Text;
            string userName = txtUserName.Text;
            if (string.IsNullOrEmpty(roleName) || string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Please enter a role name and a user name.");
                return;
            }
            string createRolesQuery = $@"
                CREATE ROLE [{roleName}] AUTHORIZATION [dbo];
                ALTER ROLE [{roleName}] ADD MEMBER [{userName}];";

            ExecuteNonQuery(createRolesQuery);
            MessageBox.Show("Roles created successfully.");
        }
    }
}
