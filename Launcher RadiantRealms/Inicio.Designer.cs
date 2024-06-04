
namespace Launcher_RadiantRealms
{
    partial class Inicio
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
            this.btnJuega = new System.Windows.Forms.Button();
            this.btnReduceLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJuega
            // 
            this.btnJuega.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuega.Location = new System.Drawing.Point(675, 462);
            this.btnJuega.Name = "btnJuega";
            this.btnJuega.Size = new System.Drawing.Size(117, 62);
            this.btnJuega.TabIndex = 13;
            this.btnJuega.Text = "Juega";
            this.btnJuega.UseVisualStyleBackColor = true;
            // 
            // btnReduceLog
            // 
            this.btnReduceLog.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReduceLog.Location = new System.Drawing.Point(639, 12);
            this.btnReduceLog.Name = "btnReduceLog";
            this.btnReduceLog.Size = new System.Drawing.Size(153, 53);
            this.btnReduceLog.TabIndex = 19;
            this.btnReduceLog.Text = "Liberar Espacio en el Log";
            this.btnReduceLog.UseVisualStyleBackColor = true;
            this.btnReduceLog.Click += new System.EventHandler(this.btnReduceLog_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launcher_RadiantRealms.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(804, 536);
            this.ControlBox = false;
            this.Controls.Add(this.btnReduceLog);
            this.Controls.Add(this.btnJuega);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJuega;
        private System.Windows.Forms.Button btnReduceLog;
    }
}