
namespace praktikum13
{
    partial class Form1
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
            this.labelinputdata = new System.Windows.Forms.Label();
            this.buttonproses = new System.Windows.Forms.Button();
            this.textBoxpesan = new System.Windows.Forms.TextBox();
            this.labelpesan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelinputdata
            // 
            this.labelinputdata.AutoSize = true;
            this.labelinputdata.Location = new System.Drawing.Point(12, 9);
            this.labelinputdata.Name = "labelinputdata";
            this.labelinputdata.Size = new System.Drawing.Size(93, 20);
            this.labelinputdata.TabIndex = 0;
            this.labelinputdata.Text = "Input Data: ";
            this.labelinputdata.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonproses
            // 
            this.buttonproses.Location = new System.Drawing.Point(12, 88);
            this.buttonproses.Name = "buttonproses";
            this.buttonproses.Size = new System.Drawing.Size(90, 35);
            this.buttonproses.TabIndex = 1;
            this.buttonproses.Text = "proses";
            this.buttonproses.UseVisualStyleBackColor = true;
            this.buttonproses.Click += new System.EventHandler(this.buttonproses_Click);
            // 
            // textBoxpesan
            // 
            this.textBoxpesan.Location = new System.Drawing.Point(12, 41);
            this.textBoxpesan.Name = "textBoxpesan";
            this.textBoxpesan.Size = new System.Drawing.Size(306, 26);
            this.textBoxpesan.TabIndex = 2;
            // 
            // labelpesan
            // 
            this.labelpesan.AutoSize = true;
            this.labelpesan.Location = new System.Drawing.Point(12, 155);
            this.labelpesan.Name = "labelpesan";
            this.labelpesan.Size = new System.Drawing.Size(71, 20);
            this.labelpesan.TabIndex = 3;
            this.labelpesan.Text = "[EMPTY]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelpesan);
            this.Controls.Add(this.textBoxpesan);
            this.Controls.Add(this.buttonproses);
            this.Controls.Add(this.labelinputdata);
            this.Name = "Form1";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelinputdata;
        private System.Windows.Forms.Button buttonproses;
        private System.Windows.Forms.TextBox textBoxpesan;
        private System.Windows.Forms.Label labelpesan;
    }
}

