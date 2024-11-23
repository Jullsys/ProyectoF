namespace Trabajo2
{
    partial class LaCola
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
            this.button1 = new System.Windows.Forms.Button();
            this.Desencola = new System.Windows.Forms.Button();
            this.Busca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Caja = new System.Windows.Forms.TextBox();
            this.Datos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Desencola
            // 
            this.Desencola.Location = new System.Drawing.Point(215, 158);
            this.Desencola.Name = "Desencola";
            this.Desencola.Size = new System.Drawing.Size(89, 39);
            this.Desencola.TabIndex = 1;
            this.Desencola.Text = "Eliminar";
            this.Desencola.UseVisualStyleBackColor = true;
            this.Desencola.Click += new System.EventHandler(this.Desencola_Click);
            // 
            // Busca
            // 
            this.Busca.Location = new System.Drawing.Point(323, 158);
            this.Busca.Name = "Busca";
            this.Busca.Size = new System.Drawing.Size(95, 39);
            this.Busca.TabIndex = 2;
            this.Busca.Text = "Buscar";
            this.Busca.UseVisualStyleBackColor = true;
            this.Busca.Click += new System.EventHandler(this.Busca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresa el valor";
            // 
            // Caja
            // 
            this.Caja.Location = new System.Drawing.Point(173, 111);
            this.Caja.Name = "Caja";
            this.Caja.Size = new System.Drawing.Size(184, 20);
            this.Caja.TabIndex = 4;
            // 
            // Datos
            // 
            this.Datos.FormattingEnabled = true;
            this.Datos.Location = new System.Drawing.Point(465, 102);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(120, 95);
            this.Datos.TabIndex = 5;
            // 
            // LaCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 262);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.Caja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Busca);
            this.Controls.Add(this.Desencola);
            this.Controls.Add(this.button1);
            this.Name = "LaCola";
            this.Text = "LaCola";
            this.Load += new System.EventHandler(this.LaCola_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Desencola;
        private System.Windows.Forms.Button Busca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Caja;
        private System.Windows.Forms.ListBox Datos;
    }
}