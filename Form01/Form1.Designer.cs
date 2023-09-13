namespace Form01
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
            this.btnSaludar = new System.Windows.Forms.Button();
            this.lblHolaMundo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaludar
            // 
            this.btnSaludar.BackColor = System.Drawing.Color.DarkGray;
            this.btnSaludar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSaludar.Location = new System.Drawing.Point(318, 197);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(164, 54);
            this.btnSaludar.TabIndex = 0;
            this.btnSaludar.Text = "Hola gente";
            this.btnSaludar.UseVisualStyleBackColor = false;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // lblHolaMundo
            // 
            this.lblHolaMundo.AutoSize = true;
            this.lblHolaMundo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHolaMundo.Location = new System.Drawing.Point(312, 114);
            this.lblHolaMundo.Name = "lblHolaMundo";
            this.lblHolaMundo.Size = new System.Drawing.Size(170, 54);
            this.lblHolaMundo.TabIndex = 1;
            this.lblHolaMundo.Text = "BUENAS";
            this.lblHolaMundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHolaMundo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHolaMundo);
            this.Controls.Add(this.btnSaludar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSaludar;
        private Label lblHolaMundo;
    }
}