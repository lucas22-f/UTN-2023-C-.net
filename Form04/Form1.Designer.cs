namespace Form04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxEntrada = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBoxLista = new System.Windows.Forms.GroupBox();
            this.listBoxNros = new System.Windows.Forms.ListBox();
            this.groupBoxOrden = new System.Windows.Forms.GroupBox();
            this.radioBtnDesc = new System.Windows.Forms.RadioButton();
            this.radioBtnAsc = new System.Windows.Forms.RadioButton();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBoxEntrada.SuspendLayout();
            this.groupBoxLista.SuspendLayout();
            this.groupBoxOrden.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEntrada
            // 
            this.groupBoxEntrada.Controls.Add(this.textBox1);
            this.groupBoxEntrada.Controls.Add(this.btnAgregar);
            this.groupBoxEntrada.Location = new System.Drawing.Point(42, 33);
            this.groupBoxEntrada.Name = "groupBoxEntrada";
            this.groupBoxEntrada.Size = new System.Drawing.Size(200, 100);
            this.groupBoxEntrada.TabIndex = 0;
            this.groupBoxEntrada.TabStop = false;
            this.groupBoxEntrada.Text = "Ingrese numero";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(125, 37);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBoxLista
            // 
            this.groupBoxLista.Controls.Add(this.listBoxNros);
            this.groupBoxLista.Location = new System.Drawing.Point(269, 33);
            this.groupBoxLista.Name = "groupBoxLista";
            this.groupBoxLista.Size = new System.Drawing.Size(213, 265);
            this.groupBoxLista.TabIndex = 1;
            this.groupBoxLista.TabStop = false;
            this.groupBoxLista.Text = "Numeros";
            // 
            // listBoxNros
            // 
            this.listBoxNros.FormattingEnabled = true;
            this.listBoxNros.ItemHeight = 15;
            this.listBoxNros.Location = new System.Drawing.Point(6, 51);
            this.listBoxNros.Name = "listBoxNros";
            this.listBoxNros.Size = new System.Drawing.Size(207, 214);
            this.listBoxNros.TabIndex = 0;
            // 
            // groupBoxOrden
            // 
            this.groupBoxOrden.Controls.Add(this.radioBtnDesc);
            this.groupBoxOrden.Controls.Add(this.radioBtnAsc);
            this.groupBoxOrden.Controls.Add(this.btnOrdenar);
            this.groupBoxOrden.Location = new System.Drawing.Point(42, 198);
            this.groupBoxOrden.Name = "groupBoxOrden";
            this.groupBoxOrden.Size = new System.Drawing.Size(200, 100);
            this.groupBoxOrden.TabIndex = 1;
            this.groupBoxOrden.TabStop = false;
            this.groupBoxOrden.Text = "Ordenar";
            // 
            // radioBtnDesc
            // 
            this.radioBtnDesc.AutoSize = true;
            this.radioBtnDesc.Location = new System.Drawing.Point(6, 75);
            this.radioBtnDesc.Name = "radioBtnDesc";
            this.radioBtnDesc.Size = new System.Drawing.Size(93, 19);
            this.radioBtnDesc.TabIndex = 3;
            this.radioBtnDesc.TabStop = true;
            this.radioBtnDesc.Text = "Descendente";
            this.radioBtnDesc.UseVisualStyleBackColor = true;
            // 
            // radioBtnAsc
            // 
            this.radioBtnAsc.AutoSize = true;
            this.radioBtnAsc.Location = new System.Drawing.Point(6, 32);
            this.radioBtnAsc.Name = "radioBtnAsc";
            this.radioBtnAsc.Size = new System.Drawing.Size(87, 19);
            this.radioBtnAsc.TabIndex = 2;
            this.radioBtnAsc.TabStop = true;
            this.radioBtnAsc.Text = "Ascendente";
            this.radioBtnAsc.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(125, 49);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(42, 327);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(209, 41);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 398);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBoxOrden);
            this.Controls.Add(this.groupBoxLista);
            this.Controls.Add(this.groupBoxEntrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxEntrada.ResumeLayout(false);
            this.groupBoxEntrada.PerformLayout();
            this.groupBoxLista.ResumeLayout(false);
            this.groupBoxOrden.ResumeLayout(false);
            this.groupBoxOrden.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxEntrada;
        private GroupBox groupBoxLista;
        private GroupBox groupBoxOrden;
        private ListBox listBoxNros;
        private TextBox textBox1;
        private Button btnAgregar;
        private RadioButton radioBtnDesc;
        private RadioButton radioBtnAsc;
        private Button btnOrdenar;
        private Button btnLimpiar;
    }
}