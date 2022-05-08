namespace DI06_DocumentacionAyuda
{
    partial class PopUp
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
            this.tb_PopUp = new System.Windows.Forms.TextBox();
            this.botonCerrar = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // tb_PopUp
            // 
            this.tb_PopUp.Location = new System.Drawing.Point(12, 12);
            this.tb_PopUp.Multiline = true;
            this.tb_PopUp.Name = "tb_PopUp";
            this.tb_PopUp.Size = new System.Drawing.Size(239, 56);
            this.tb_PopUp.TabIndex = 0;
            // 
            // botonCerrar
            // 
            this.helpProvider1.SetHelpString(this.botonCerrar, "clicame para cerrar");
            this.botonCerrar.Location = new System.Drawing.Point(176, 76);
            this.botonCerrar.Name = "botonCerrar";
            this.helpProvider1.SetShowHelp(this.botonCerrar, true);
            this.botonCerrar.Size = new System.Drawing.Size(75, 23);
            this.botonCerrar.TabIndex = 1;
            this.botonCerrar.Text = "Cerrar";
            this.botonCerrar.UseVisualStyleBackColor = true;
            this.botonCerrar.Click += new System.EventHandler(this.botonCerrar_Click);
            // 
            // PopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 111);
            this.Controls.Add(this.botonCerrar);
            this.Controls.Add(this.tb_PopUp);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PopUp";
            this.Text = "PopUp";
            this.Load += new System.EventHandler(this.PopUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_PopUp;
        private System.Windows.Forms.Button botonCerrar;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}