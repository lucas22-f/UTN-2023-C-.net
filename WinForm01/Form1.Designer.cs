namespace WinForm01
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
            this.btnHworld = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHworld
            // 
            this.btnHworld.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnHworld.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHworld.Location = new System.Drawing.Point(393, 284);
            this.btnHworld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHworld.Name = "btnHworld";
            this.btnHworld.Size = new System.Drawing.Size(216, 81);
            this.btnHworld.TabIndex = 0;
            this.btnHworld.Text = "button1";
            this.btnHworld.UseVisualStyleBackColor = false;
            this.btnHworld.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1029, 630);
            this.Controls.Add(this.btnHworld);
            this.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnHworld;
    }
}