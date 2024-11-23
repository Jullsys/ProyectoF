namespace Trabajo2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this._Pila = new System.Windows.Forms.Button();
            this._Cola = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _Pila
            // 
            this._Pila.Location = new System.Drawing.Point(64, 101);
            this._Pila.Name = "_Pila";
            this._Pila.Size = new System.Drawing.Size(154, 68);
            this._Pila.TabIndex = 0;
            this._Pila.Text = "Pila";
            this._Pila.UseVisualStyleBackColor = true;
            this._Pila.Click += new System.EventHandler(this._Pila_Click);
            // 
            // _Cola
            // 
            this._Cola.Location = new System.Drawing.Point(64, 177);
            this._Cola.Name = "_Cola";
            this._Cola.Size = new System.Drawing.Size(154, 68);
            this._Cola.TabIndex = 1;
            this._Cola.Text = "Cola";
            this._Cola.UseVisualStyleBackColor = true;
            this._Cola.Click += new System.EventHandler(this._Cola_Click_1);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(64, 250);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(154, 68);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Lista simple";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "Lista doble";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 68);
            this.button2.TabIndex = 4;
            this.button2.Text = "Lista circular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(325, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 68);
            this.button3.TabIndex = 5;
            this.button3.Text = "Lista Doble circular";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(525, 381);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this._Cola);
            this.Controls.Add(this._Pila);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _Pila;
        private System.Windows.Forms.Button _Cola;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

