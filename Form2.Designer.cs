namespace CAESAR_lisflood_1._0
{
    partial class Form2
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
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            ElevcheckBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(31, 13);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(219, 122);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(31, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(44, 20);
            textBox2.TabIndex = 1;
            textBox2.Text = "0.0";
            // 
            // ElevcheckBox1
            // 
            ElevcheckBox1.AutoSize = true;
            ElevcheckBox1.Location = new System.Drawing.Point(31, 159);
            ElevcheckBox1.Name = "ElevcheckBox1";
            ElevcheckBox1.Size = new System.Drawing.Size(188, 17);
            ElevcheckBox1.TabIndex = 2;
            ElevcheckBox1.Text = "Check to edit elevation by clicking";
            ElevcheckBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount elev altered by (+/-)";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.label1);
            this.Controls.Add(ElevcheckBox1);
            this.Controls.Add(textBox2);
            this.Controls.Add(textBox1);
            this.Name = "Form2";
            this.Text = "Cell Properties";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public static System.Windows.Forms.CheckBox ElevcheckBox1;
        public static System.Windows.Forms.TextBox textBox2;
        public static System.Windows.Forms.TextBox textBox1;


    }
}