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
using BCrypt.Net;

namespace Launcher_RadiantRealms
{
    public partial class Login : Form
    {
        private Font defaultFont;
        private Point lastMouseDownLocation;
        private string connectionString = "Data Source=localhost;Initial Catalog=RadiantRealms;User Id=UsuarioGeneralJuego;Password=TuContraseña";
        public Login()
        {
            InitializeComponent();
            InitializePanels();
            InitializeCustomTitleBar();
            // Configurar los TextBox iniciales

            ConfigureTextBox(txtUsername);
            ConfigureTextBox(txtPassword);
            ConfigureTextBox(txtEmail);
            ConfigureTextBox(txtUsernameLogin);
            ConfigureTextBox(txtPasswordLogin);
            CreatePictureBox(pbCerrar);
            CreatePictureBox(pbMinimizar);
            pbCerrar.Image = AdjustBrightness(pbCerrar.Image, .5f);
            pbMinimizar.Image = AdjustBrightness(pbMinimizar.Image, .5f);
            pbCerrar.BringToFront();
            pbMinimizar.BringToFront();
        }

        private void InitializePanels()
        {
            // Panel para el Username
            pnlUsername.Click += PnlUsername_Click;
            pnlUsername.BorderStyle = BorderStyle.None; // No mostrar el borde predeterminado

            txtUsernameLogin.Enter += TextBox_Enter;
            txtUsernameLogin.Leave += TextBox_Leave;
            txtUsernameLogin.BorderStyle = BorderStyle.None; // No mostrar el borde predeterminado

            defaultFont = lblUsername.Font;
            lblUsername.Click += Label_Click;


            // Panel para la Contraseña
            pnlPassword.Click += PnlPassword_Click;
            pnlPassword.BorderStyle = BorderStyle.None; // No mostrar el borde predeterminado

            txtPasswordLogin.UseSystemPasswordChar = true; // Mostrar asteriscos en lugar de caracteres reales
            txtPasswordLogin.Enter += TextBox_Enter;
            txtPasswordLogin.Leave += TextBox_Leave;
            txtPasswordLogin.BorderStyle = BorderStyle.None; // No mostrar el borde predeterminado

            lblPassword.Click += Label_Click;

            //Panel para el usuario registro
            pnlUsernameR.Click += PnlUsername_Click;
            pnlUsernameR.BorderStyle = BorderStyle.None; // No mostrar el borde predeterminado

            txtUsername.Enter += TextBox_Enter;
            txtUsername.Leave += TextBox_Leave;
            txtUsername.BorderStyle = BorderStyle.None; // No mostrar el borde predeterminado

            defaultFont = lblUsernameR.Font;
            lblUsernameR.Click += Label_Click;


            // Panel para la Contraseña Registro
            pnlPasswordR.Click += PnlPassword_Click;
            pnlPasswordR.BorderStyle = BorderStyle.None; // No mostrar el borde predeterminado

            txtPassword.UseSystemPasswordChar = true; // Mostrar asteriscos en lugar de caracteres reales
            txtPassword.Enter += TextBox_Enter;
            txtPassword.Leave += TextBox_Leave;
            txtPassword.BorderStyle = BorderStyle.None; // No mostrar el borde predeterminado

            lblPasswordR.Click += Label_Click;

            //panel para el email registro
            pnlEmail.Click += PnlPassword_Click;
            pnlEmail.BorderStyle = BorderStyle.None; // No mostrar el borde predeterminado

            txtEmail.UseSystemPasswordChar = true; // Mostrar asteriscos en lugar de caracteres reales
            txtEmail.Enter += TextBox_Enter;
            txtEmail.Leave += TextBox_Leave;
            txtEmail.BorderStyle = BorderStyle.None; // No mostrar el borde predeterminado

            lblEmail.Click += Label_Click;


        }

        private void PnlUsername_Click(object sender, EventArgs e)
        {
            txtUsernameLogin.Focus();
        }

        private void PnlPassword_Click(object sender, EventArgs e)
        {
            txtPasswordLogin.Focus();
        }

        private async void TextBox_Enter(object sender, EventArgs e)
        {
            Panel panel = (Panel)((TextBox)sender).Parent;
            TextBox textBox = (TextBox)sender;

            panel.BackColor = Color.White; // Cambia el color de fondo del panel a blanco

            textBox.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle; // Muestra el borde negro
            await AnimateLabelUp(panel);
        }

        private async void TextBox_Leave(object sender, EventArgs e)
        {
            Panel panel = (Panel)((TextBox)sender).Parent;

            panel.BackColor = Color.FromArgb(224, 224, 224); // Cambia el color de fondo del panel a grisaceo transparente
            panel.BorderStyle = BorderStyle.None; // Oculta el borde
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.FromArgb(224, 224, 224);
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                await AnimateLabelDown(panel);
                ConfigureTextBox(textBox);
            }
        }

        private async Task AnimateLabelUp(Panel panel)
        {
            Label label = panel.Controls.OfType<Label>().FirstOrDefault();
            while (label.Location.Y > 0)
            {
                label.Location = new Point(label.Location.X, label.Location.Y - 1);
                label.Font = new Font(defaultFont.FontFamily, label.Font.Size - 0.1f, FontStyle.Regular);
                await Task.Delay(1);
            }
        }

        private async Task AnimateLabelDown(Panel panel)
        {
            Label label = panel.Controls.OfType<Label>().FirstOrDefault();
            while (label.Location.Y < 18)
            {
                label.Location = new Point(label.Location.X, label.Location.Y + 1);
                label.Font = new Font(defaultFont.FontFamily, label.Font.Size + 0.1f, FontStyle.Regular);
                await Task.Delay(1);
            }
        }
        private void ConfigureTextBox(TextBox textBox)
        {
            textBox.Text = "";
            textBox.ForeColor = SystemColors.WindowText;
        }

        private void Label_Click(object sender, EventArgs e)
        {
            TextBox textBox = ((Label)sender).Parent.Controls.OfType<TextBox>().FirstOrDefault();
            textBox.Focus();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            panel1.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Focus();
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
            Panel titleBar = new Panel();
            titleBar.Size = new Size((this.Width / 4) + 38, 30);
            titleBar.Location = new Point(0, 0);
            titleBar.BackColor = Color.White; // Transparente

            pbMove.MouseDown += TitleBar_MouseDown;
            pbMove.MouseMove += TitleBar_MouseMove;
            pbMove.MouseUp += TitleBar_MouseUp;

            titleBar.MouseDown += TitleBar_MouseDown;
            titleBar.MouseMove += TitleBar_MouseMove;
            titleBar.MouseUp += TitleBar_MouseUp;

            this.Controls.Add(titleBar);
            titleBar.BringToFront();
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Obtener el hash y el salt almacenado en la base de datos para el usuario actual
                string getUserDataQuery = "SELECT PasswordHash, Salt FROM Usuarios WHERE Username = @Username";
                using (SqlCommand getUserDataCommand = new SqlCommand(getUserDataQuery, connection))
                {
                    getUserDataCommand.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = getUserDataCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHashedPassword = reader["PasswordHash"].ToString();
                            string saltFromDatabase = reader["Salt"].ToString();

                            // Concatenar la contraseña proporcionada con el salt y verificar el hash
                            string hashedPasswordFromInput =(password + saltFromDatabase);

                            // Comparar el hash generado con el hash almacenado en la base de datos
                            if (BCrypt.Net.BCrypt.Verify(hashedPasswordFromInput, storedHashedPassword))
                            {
                                
                                // La contraseña es válida
                                MessageBox.Show("Inicio de sesión exitoso.");

                                Launcher launcher = new Launcher();
                                launcher.Show();
                                this.Visible=false;
                            }
                            else
                            {
                                // La contraseña es incorrecta
                                MessageBox.Show("Inicio de sesión fallido. Verifica tu nombre de usuario y contraseña.");
                            }
                        }
                        else
                        {
                            // El usuario no existe
                            MessageBox.Show("Inicio de sesión fallido. Verifica tu nombre de usuario");
                        }
                    }
                }
            }





        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            pnlRegistro.Visible = true;
        }

        private void pnlUsernameR_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void pnlPasswordR_Click(object sender, EventArgs e)
        {

            txtPassword.Focus();
        }

        private void pnlEmail_Click(object sender, EventArgs e)
        {

            txtEmail.Focus();
        }




        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            DateTime fechaNacimiento = dtpFechaNacimiento.Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Generar un salt aleatorio
                string salt = BCrypt.Net.BCrypt.GenerateSalt(12);

                // Concatenar la contraseña con el salt y aplicar hashing
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password + salt);

                // Obtener la fecha de registro actual
                DateTime fechaRegistro = DateTime.Now;

                // Llamar al procedimiento almacenado
                using (SqlCommand command = new SqlCommand("sp_RegistrarUsuario", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                    command.Parameters.AddWithValue("@Salt", salt);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@FechaRegistro", fechaRegistro);

                    try
                    {
                        command.ExecuteNonQuery();
                        
                        MessageBox.Show("Registro exitoso.");
                        pnlRegistro.Visible = false;
                    }
                    catch (SqlException ex)
                    {
                        // Manejar cualquier error en la ejecución del procedimiento almacenado
                        MessageBox.Show("Error al registrar usuario: " + ex.Message);
                    }
                }
            }
        }

        private void pbCerrarR_Click(object sender, EventArgs e)
        {
            pnlRegistro.Visible = false;
        }
    }
}
