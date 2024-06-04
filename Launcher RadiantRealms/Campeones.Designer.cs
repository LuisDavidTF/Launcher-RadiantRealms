
namespace Launcher_RadiantRealms
{
    partial class Campeones
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPuntuacion = new System.Windows.Forms.TextBox();
            this.txtTipo_Campeon = new System.Windows.Forms.TextBox();
            this.txtNombre_Campeon = new System.Windows.Forms.TextBox();
            this.btnAddCampeon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(427, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "puntuacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(427, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "tipo de campeon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(427, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "nombre de campeon";
            // 
            // txtPuntuacion
            // 
            this.txtPuntuacion.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtPuntuacion.Location = new System.Drawing.Point(422, 128);
            this.txtPuntuacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPuntuacion.Name = "txtPuntuacion";
            this.txtPuntuacion.Size = new System.Drawing.Size(170, 32);
            this.txtPuntuacion.TabIndex = 37;
            // 
            // txtTipo_Campeon
            // 
            this.txtTipo_Campeon.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtTipo_Campeon.Location = new System.Drawing.Point(422, 79);
            this.txtTipo_Campeon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTipo_Campeon.Name = "txtTipo_Campeon";
            this.txtTipo_Campeon.Size = new System.Drawing.Size(170, 32);
            this.txtTipo_Campeon.TabIndex = 36;
            // 
            // txtNombre_Campeon
            // 
            this.txtNombre_Campeon.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtNombre_Campeon.Location = new System.Drawing.Point(422, 28);
            this.txtNombre_Campeon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre_Campeon.Name = "txtNombre_Campeon";
            this.txtNombre_Campeon.Size = new System.Drawing.Size(170, 32);
            this.txtNombre_Campeon.TabIndex = 35;
            // 
            // btnAddCampeon
            // 
            this.btnAddCampeon.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCampeon.Location = new System.Drawing.Point(429, 186);
            this.btnAddCampeon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddCampeon.Name = "btnAddCampeon";
            this.btnAddCampeon.Size = new System.Drawing.Size(148, 89);
            this.btnAddCampeon.TabIndex = 34;
            this.btnAddCampeon.Text = "Añadir un Nuevo Campeon";
            this.btnAddCampeon.UseVisualStyleBackColor = true;
            this.btnAddCampeon.Click += new System.EventHandler(this.btnAddCampeon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-27, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 41;
            // 
            // Campeones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launcher_RadiantRealms.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(603, 436);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPuntuacion);
            this.Controls.Add(this.txtTipo_Campeon);
            this.Controls.Add(this.txtNombre_Campeon);
            this.Controls.Add(this.btnAddCampeon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Campeones";
            this.Text = "Campeones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPuntuacion;
        private System.Windows.Forms.TextBox txtTipo_Campeon;
        private System.Windows.Forms.TextBox txtNombre_Campeon;
        private System.Windows.Forms.Button btnAddCampeon;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}