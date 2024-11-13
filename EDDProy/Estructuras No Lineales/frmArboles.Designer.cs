
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnPodar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.lblDatos = new System.Windows.Forms.Label();
            this.btnCrearArbol = new System.Windows.Forms.Button();
            this.txtNodos = new System.Windows.Forms.NumericUpDown();
            this.lblPostOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPostOrden = new System.Windows.Forms.Label();
            this.lblInOrden = new System.Windows.Forms.Label();
            this.lblPreOrden = new System.Windows.Forms.Label();
            this.lblRecorridoInOrden = new System.Windows.Forms.Label();
            this.lblRecorridoPreOrden = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblRecorridoPorNiveles = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lblAltura = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.lblCantidadHojas = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.lblCantidadNodos = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.lblEsCompleto = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.lblEsLleno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(47, 44);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(299, 37);
            this.txtDato.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAgregar.Location = new System.Drawing.Point(47, 86);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(68, 34);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArbol.Location = new System.Drawing.Point(17, 267);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtArbol.MaximumSize = new System.Drawing.Size(271, 229);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtArbol.Size = new System.Drawing.Size(271, 229);
            this.txtArbol.TabIndex = 2;
            this.txtArbol.TextChanged += new System.EventHandler(this.txtArbol_TextChanged);
            // 
            // btnPodar
            // 
            this.btnPodar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPodar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnPodar.Location = new System.Drawing.Point(265, 85);
            this.btnPodar.Margin = new System.Windows.Forms.Padding(2);
            this.btnPodar.Name = "btnPodar";
            this.btnPodar.Size = new System.Drawing.Size(68, 34);
            this.btnPodar.TabIndex = 1;
            this.btnPodar.Text = "Podar";
            this.btnPodar.UseVisualStyleBackColor = false;
            this.btnPodar.Click += new System.EventHandler(this.btnPodar_Click_1);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrafica.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGrafica.Location = new System.Drawing.Point(193, 85);
            this.btnGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(68, 34);
            this.btnGrafica.TabIndex = 3;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = false;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRecorrer.Location = new System.Drawing.Point(506, 447);
            this.btnRecorrer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(85, 49);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = false;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(153, 15);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(61, 25);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Dato";
            // 
            // btnCrearArbol
            // 
            this.btnCrearArbol.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCrearArbol.Location = new System.Drawing.Point(120, 226);
            this.btnCrearArbol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearArbol.Name = "btnCrearArbol";
            this.btnCrearArbol.Size = new System.Drawing.Size(69, 37);
            this.btnCrearArbol.TabIndex = 6;
            this.btnCrearArbol.Text = "Crear Arbol";
            this.btnCrearArbol.UseVisualStyleBackColor = false;
            this.btnCrearArbol.Click += new System.EventHandler(this.btnCrearArbol_Click);
            // 
            // txtNodos
            // 
            this.txtNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodos.Location = new System.Drawing.Point(36, 232);
            this.txtNodos.Margin = new System.Windows.Forms.Padding(2);
            this.txtNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNodos.Name = "txtNodos";
            this.txtNodos.Size = new System.Drawing.Size(60, 24);
            this.txtNodos.TabIndex = 8;
            this.txtNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPostOrden
            // 
            this.lblPostOrden.AutoSize = true;
            this.lblPostOrden.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblPostOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostOrden.Location = new System.Drawing.Point(455, 401);
            this.lblPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPostOrden.Name = "lblPostOrden";
            this.lblPostOrden.Size = new System.Drawing.Size(84, 18);
            this.lblPostOrden.TabIndex = 9;
            this.lblPostOrden.Text = "PostOrden:";
            // 
            // lblRecorridoPostOrden
            // 
            this.lblRecorridoPostOrden.AutoSize = true;
            this.lblRecorridoPostOrden.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblRecorridoPostOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorridoPostOrden.Location = new System.Drawing.Point(563, 401);
            this.lblRecorridoPostOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPostOrden.Name = "lblRecorridoPostOrden";
            this.lblRecorridoPostOrden.Size = new System.Drawing.Size(16, 18);
            this.lblRecorridoPostOrden.TabIndex = 10;
            this.lblRecorridoPostOrden.Text = "..";
            // 
            // lblInOrden
            // 
            this.lblInOrden.AutoSize = true;
            this.lblInOrden.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblInOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInOrden.Location = new System.Drawing.Point(465, 377);
            this.lblInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInOrden.Name = "lblInOrden";
            this.lblInOrden.Size = new System.Drawing.Size(64, 18);
            this.lblInOrden.TabIndex = 11;
            this.lblInOrden.Text = "InOrden:";
            // 
            // lblPreOrden
            // 
            this.lblPreOrden.AutoSize = true;
            this.lblPreOrden.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblPreOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreOrden.Location = new System.Drawing.Point(460, 351);
            this.lblPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreOrden.Name = "lblPreOrden";
            this.lblPreOrden.Size = new System.Drawing.Size(76, 18);
            this.lblPreOrden.TabIndex = 12;
            this.lblPreOrden.Text = "PreOrden:";
            // 
            // lblRecorridoInOrden
            // 
            this.lblRecorridoInOrden.AutoSize = true;
            this.lblRecorridoInOrden.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblRecorridoInOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorridoInOrden.Location = new System.Drawing.Point(563, 377);
            this.lblRecorridoInOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoInOrden.Name = "lblRecorridoInOrden";
            this.lblRecorridoInOrden.Size = new System.Drawing.Size(16, 18);
            this.lblRecorridoInOrden.TabIndex = 13;
            this.lblRecorridoInOrden.Text = "..";
            // 
            // lblRecorridoPreOrden
            // 
            this.lblRecorridoPreOrden.AutoSize = true;
            this.lblRecorridoPreOrden.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblRecorridoPreOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorridoPreOrden.Location = new System.Drawing.Point(563, 351);
            this.lblRecorridoPreOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecorridoPreOrden.Name = "lblRecorridoPreOrden";
            this.lblRecorridoPreOrden.Size = new System.Drawing.Size(16, 18);
            this.lblRecorridoPreOrden.TabIndex = 14;
            this.lblRecorridoPreOrden.Text = "..";
            // 
            // btBuscar
            // 
            this.btBuscar.BackColor = System.Drawing.Color.YellowGreen;
            this.btBuscar.Location = new System.Drawing.Point(120, 86);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(68, 33);
            this.btBuscar.TabIndex = 15;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = false;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "EliminarSucesor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "ElimianrPredecesor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Amplitud";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblRecorridoPorNiveles
            // 
            this.lblRecorridoPorNiveles.AutoSize = true;
            this.lblRecorridoPorNiveles.Location = new System.Drawing.Point(547, 123);
            this.lblRecorridoPorNiveles.Name = "lblRecorridoPorNiveles";
            this.lblRecorridoPorNiveles.Size = new System.Drawing.Size(16, 13);
            this.lblRecorridoPorNiveles.TabIndex = 19;
            this.lblRecorridoPorNiveles.Text = "...";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(454, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Altura";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(537, 87);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(16, 13);
            this.lblAltura.TabIndex = 21;
            this.lblAltura.Text = "...";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(430, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Calcular Hoja";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblCantidadHojas
            // 
            this.lblCantidadHojas.AutoSize = true;
            this.lblCantidadHojas.Location = new System.Drawing.Point(540, 58);
            this.lblCantidadHojas.Name = "lblCantidadHojas";
            this.lblCantidadHojas.Size = new System.Drawing.Size(16, 13);
            this.lblCantidadHojas.TabIndex = 23;
            this.lblCantidadHojas.Text = "...";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(430, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "Calcular Nodos";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblCantidadNodos
            // 
            this.lblCantidadNodos.AutoSize = true;
            this.lblCantidadNodos.Location = new System.Drawing.Point(535, 34);
            this.lblCantidadNodos.Name = "lblCantidadNodos";
            this.lblCantidadNodos.Size = new System.Drawing.Size(16, 13);
            this.lblCantidadNodos.TabIndex = 25;
            this.lblCantidadNodos.Text = "...";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(434, 193);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 23);
            this.button7.TabIndex = 26;
            this.button7.Text = "Revisar-Completo";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // lblEsCompleto
            // 
            this.lblEsCompleto.AutoSize = true;
            this.lblEsCompleto.Location = new System.Drawing.Point(547, 198);
            this.lblEsCompleto.Name = "lblEsCompleto";
            this.lblEsCompleto.Size = new System.Drawing.Size(16, 13);
            this.lblEsCompleto.TabIndex = 27;
            this.lblEsCompleto.Text = "...";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(434, 232);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 23);
            this.button8.TabIndex = 28;
            this.button8.Text = "Revisar-Lleno";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // lblEsLleno
            // 
            this.lblEsLleno.AutoSize = true;
            this.lblEsLleno.Location = new System.Drawing.Point(540, 241);
            this.lblEsLleno.Name = "lblEsLleno";
            this.lblEsLleno.Size = new System.Drawing.Size(16, 13);
            this.lblEsLleno.TabIndex = 29;
            this.lblEsLleno.Text = "...";
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(683, 519);
            this.Controls.Add(this.lblEsLleno);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.lblEsCompleto);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.lblCantidadNodos);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.lblCantidadHojas);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblRecorridoPorNiveles);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.lblRecorridoPreOrden);
            this.Controls.Add(this.lblRecorridoInOrden);
            this.Controls.Add(this.lblPreOrden);
            this.Controls.Add(this.lblInOrden);
            this.Controls.Add(this.lblRecorridoPostOrden);
            this.Controls.Add(this.lblPostOrden);
            this.Controls.Add(this.txtNodos);
            this.Controls.Add(this.btnCrearArbol);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnPodar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            this.Load += new System.EventHandler(this.frmArboles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnPodar;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Button btnCrearArbol;
        private System.Windows.Forms.NumericUpDown txtNodos;
        private System.Windows.Forms.Label lblPostOrden;
        private System.Windows.Forms.Label lblRecorridoPostOrden;
        private System.Windows.Forms.Label lblInOrden;
        private System.Windows.Forms.Label lblPreOrden;
        private System.Windows.Forms.Label lblRecorridoInOrden;
        private System.Windows.Forms.Label lblRecorridoPreOrden;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblRecorridoPorNiveles;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblCantidadHojas;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblCantidadNodos;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lblEsCompleto;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lblEsLleno;
    }
}