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
    public partial class Launcher : Form
    {
        private Form formularioActual;
        private bool enabledInicio = true;
        private bool enabledPerfil = false;
        private bool enabledCampeones = false;
        private List<User> friendList = new List<User>();
        private ImageList imageList = new ImageList();
        private string connectionString = "Data Source=DESKTOP-19M62MH;Initial Catalog=RadiantRealms; Integrated security=true"; // cadena de conexión
        private Point lastMouseDownLocation;

        private void CambiarFormulario(Form nuevoFormulario, PictureBox boton)
        {
            // Ocultar el formulario actual
            formularioActual.Hide();

            // Mostrar el nuevo formulario
            nuevoFormulario.TopLevel = false;
            pForms.Controls.Add(nuevoFormulario);
            nuevoFormulario.Show();

            // Habilitar/deshabilitar los botones
            formularioActual = nuevoFormulario;
            pbInicio.Enabled = (boton != pbInicio);
            pbPerfil.Enabled = (boton != pbPerfil);
            pbCampeones.Enabled = (boton != pbCampeones);
        }

        public Launcher()
        {
            InitializeComponent();
            InitializeImageList();
            LoadFriendsFromDatabase(); // Obtener amigos de la base de datos
            InitializeCustomTitleBar();
            CreatePictureBox(pbInicio);
            CreatePictureBox(pbPerfil);
            CreatePictureBox(pbCerrar);
            CreatePictureBox(pbMinimizar);
            CreatePictureBox(pbCampeones);
            pbCampeones.Image = AdjustBrightness(pbCampeones.Image, 0.5f);
            pbMove.Image = AdjustBrightness(pbMove.Image, 0.5f);
            pbPerfil.Image = AdjustBrightness(pbPerfil.Image, 0.5f);
            pbInicio.Image = AdjustBrightness(pbInicio.Image, .5f);
            pbCerrar.Image = AdjustBrightness(pbCerrar.Image, .5f);
            pbMinimizar.Image = AdjustBrightness(pbMinimizar.Image, .5f);
            pbInicio.BringToFront();
            pbCerrar.BringToFront();
            pbMinimizar.BringToFront();
            formularioActual = new Inicio();
            formularioActual.TopLevel = false;
            pForms.Controls.Add(formularioActual);
            formularioActual.Show();
            pbInicio.Enabled = false;
        }

        private void PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                pictureBox.Image = AdjustBrightness(pictureBox.Image, 2f);
            }
        }
        private PictureBox CreatePictureBox(PictureBox pictureBox)
        {
            // Suscribe eventos del ratón
            pictureBox.MouseEnter += PictureBox_MouseEnter;
            pictureBox.MouseLeave += PictureBox_MouseLeave;

            return pictureBox;
        }

        private void PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                pictureBox.Image = AdjustBrightness(pictureBox.Image, .5f);
            }
        }

        private Image AdjustBrightness(Image image, float brightness)
        {
            Bitmap originalImage = new Bitmap(image.Width, image.Height);

            // Ajusta el brillo de cada píxel directamente
            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color originalColor = ((Bitmap)image).GetPixel(x, y);

                    int newRed = (int)(originalColor.R * brightness);
                    int newGreen = (int)(originalColor.G * brightness);
                    int newBlue = (int)(originalColor.B * brightness);

                    newRed = Math.Min(255, Math.Max(0, newRed));
                    newGreen = Math.Min(255, Math.Max(0, newGreen));
                    newBlue = Math.Min(255, Math.Max(0, newBlue));

                    Color newColor = Color.FromArgb(newRed, newGreen, newBlue);
                    originalImage.SetPixel(x, y, newColor);
                }
            }

            return originalImage;
        }
        private void InitializeCustomTitleBar()
        {

            pbMove.MouseDown += TitleBar_MouseDown;
            pbMove.MouseMove += TitleBar_MouseMove;
            pbMove.MouseUp += TitleBar_MouseUp;
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastMouseDownLocation = e.Location;
            }
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int deltaX = e.X - lastMouseDownLocation.X;
                int deltaY = e.Y - lastMouseDownLocation.Y;

                // Mueve el formulario en función del desplazamiento del ratón
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            // Puedes agregar lógica adicional si es necesario al soltar el botón del ratón
        }


        // BARRA DE AMIGOS

        private void InitializeImageList()
        {
            // Ajusta el tamaño de las imágenes según tus necesidades
            imageList.ImageSize = new Size(32, 32);
            // Puedes ajustar el estilo según tus necesidades (por ejemplo, con transparencia)
            imageList.ColorDepth = ColorDepth.Depth32Bit;
        }

        private void LoadFriendsFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("ObtenerAmigosPorId", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@playerId", 1);//el numero 1 no es fijo, es el id de tu jugador principal

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Crea un objeto User con la información de la base de datos
                            User friend = new User
                            {
                                UserName = reader["username"].ToString(),
                                Status = reader["status"].ToString(),
                                // Asumimos que la columna 'foto' es del tipo VARBINARY en la base de datos
                                // Puedes ajustar esto según la representación de imágenes en tu base de datos
                                ProfileImage = ByteArrayToImage((byte[])reader["foto"])
                            };

                            friendList.Add(friend);
                        }
                    }
                }
            }

            UpdateFriendListView();
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            // Convierte un arreglo de bytes a una imagen
            using (var ms = new System.IO.MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void UpdateFriendListView()
        {
            listViewFriends.Items.Clear();
            imageList.Images.Clear();

            foreach (var friend in friendList)
            {
                // Agrega la imagen a ImageList y obtén el índice
                int imageIndex = imageList.Images.Count;
                imageList.Images.Add(friend.ProfileImage);

                // Crea un ListViewItem con texto y el índice de la imagen
                ListViewItem item = new ListViewItem($"{friend.UserName} - {friend.Status}", imageIndex);
                listViewFriends.Items.Add(item);
            }

            // Asigna el ImageList al ListView
            listViewFriends.SmallImageList = imageList;
        }

        private void listViewFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFriends.SelectedIndices.Count > 0)
            {
                // Aquí puedes obtener el objeto User correspondiente al amigo seleccionado
                User selectedFriend = friendList[listViewFriends.SelectedIndices[0]];

                // Puedes mostrar más detalles o realizar otras acciones según las propiedades del objeto User
                MessageBox.Show($"Detalles de amigo:\nNombre: {selectedFriend.UserName}\nEstado: {selectedFriend.Status}",
                                "Detalles de amigo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // FIN DE BARRA DE AMIGOS


        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            pbMinimizar.Focus();
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            pbCerrar.Focus();
            Application.Exit();
        }

        private void pbPerfil_Click(object sender, EventArgs e)
        {

        }




        //    Codigo para los botones de backup, reduceLog,etc...


        private void btnBackup_Click(object sender, EventArgs e)
        {
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

        private void btnCreateRoles_Click(object sender, EventArgs e)
        {
        }

        private void btnCreateIndexes_Click(object sender, EventArgs e)
        {
            string createIndexesQuery = @"
                CREATE INDEX IX_Amigos_Name ON Amigos(Name);
                CREATE INDEX IX_Campeones_Name ON Campeones(Name);
                CREATE INDEX IX_Jugadores_Name ON Jugadores(Name);
                CREATE INDEX IX_Partidas_Date ON Partidas(Date);
                CREATE INDEX IX_Partidas_Campeones_PartidaId ON Partidas_Campeones(PartidaId);
                CREATE INDEX IX_Usuarios_Username ON Usuarios(Username);";

            ExecuteNonQuery(createIndexesQuery);
            MessageBox.Show("Indexes created successfully.");
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

        private void btnAddCampeon_Click(object sender, EventArgs e)
        {
        }

        private void pbCampeones_Click(object sender, EventArgs e)
        {
            CambiarFormulario(new Campeones(), pbCampeones);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPuntuacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTipo_Campeon_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_Campeon_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsernameR_Click(object sender, EventArgs e)
        {

        }

        private void txtBackupFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbInicio_Click(object sender, EventArgs e)
        {
            CambiarFormulario(new Inicio(), pbInicio);
        }

        private void pbPerfil_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pbPerfil_Click_2(object sender, EventArgs e)
        {
            CambiarFormulario(new Perfil(), pbPerfil);
        }
    }
}
