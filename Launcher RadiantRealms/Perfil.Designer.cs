
namespace Launcher_RadiantRealms
{
    partial class Perfil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUsernameR = new System.Windows.Forms.Label();
            this.txtBackupFileName = new System.Windows.Forms.TextBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.lblFechaModificacion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnCreateRoles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsernameR
            // 
            this.lblUsernameR.AutoSize = true;
            this.lblUsernameR.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUsernameR.Location = new System.Drawing.Point(33, 377);
            this.lblUsernameR.Name = "lblUsernameR";
            this.lblUsernameR.Size = new System.Drawing.Size(132, 17);
            this.lblUsernameR.TabIndex = 25;
            this.lblUsernameR.Text = "Backup file name";
            // 
            // txtBackupFileName
            // 
            this.txtBackupFileName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtBackupFileName.Location = new System.Drawing.Point(12, 338);
            this.txtBackupFileName.Name = "txtBackupFileName";
            this.txtBackupFileName.Size = new System.Drawing.Size(225, 39);
            this.txtBackupFileName.TabIndex = 24;
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(12, 397);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(135, 75);
            this.btnBackup.TabIndex = 23;
            this.btnBackup.Text = "Realizar Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // lblFechaModificacion
            // 
            this.lblFechaModificacion.AutoSize = true;
            this.lblFechaModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaModificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFechaModificacion.Location = new System.Drawing.Point(33, 491);
            this.lblFechaModificacion.Name = "lblFechaModificacion";
            this.lblFechaModificacion.Size = new System.Drawing.Size(310, 17);
            this.lblFechaModificacion.TabIndex = 26;
            this.lblFechaModificacion.Text = "Ultima fecha de modificacion del backup: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre de usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nombre del Rol";
            // 
            // txtRoleName
            // 
            this.txtRoleName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtRoleName.Location = new System.Drawing.Point(12, 100);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(225, 39);
            this.txtRoleName.TabIndex = 29;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtUserName.Location = new System.Drawing.Point(12, 29);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(225, 39);
            this.txtUserName.TabIndex = 28;
            // 
            // btnCreateRoles
            // 
            this.btnCreateRoles.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRoles.Location = new System.Drawing.Point(12, 191);
            this.btnCreateRoles.Name = "btnCreateRoles";
            this.btnCreateRoles.Size = new System.Drawing.Size(153, 110);
            this.btnCreateRoles.TabIndex = 27;
            this.btnCreateRoles.Text = "Crear Roles";
            this.btnCreateRoles.UseVisualStyleBackColor = true;
            this.btnCreateRoles.Click += new System.EventHandler(this.btnCreateRoles_Click);
            // 
            // Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launcher_RadiantRealms.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(804, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnCreateRoles);
            this.Controls.Add(this.lblFechaModificacion);
            this.Controls.Add(this.lblUsernameR);
            this.Controls.Add(this.txtBackupFileName);
            this.Controls.Add(this.btnBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Perfil";
            this.Text = "Perfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsernameR;
        private System.Windows.Forms.TextBox txtBackupFileName;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label lblFechaModificacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnCreateRoles;
    }
}