namespace LivePerformance
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnPartijen = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 140);
            this.button1.TabIndex = 0;
            this.button1.Text = "Coalities";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPartijen
            // 
            this.btnPartijen.Location = new System.Drawing.Point(34, 190);
            this.btnPartijen.Name = "btnPartijen";
            this.btnPartijen.Size = new System.Drawing.Size(164, 140);
            this.btnPartijen.TabIndex = 1;
            this.btnPartijen.Text = "Partijen";
            this.btnPartijen.UseVisualStyleBackColor = true;
            this.btnPartijen.Click += new System.EventHandler(this.btnPartijen_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 140);
            this.button3.TabIndex = 2;
            this.button3.Text = "Verkiezingen";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(272, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 140);
            this.button4.TabIndex = 3;
            this.button4.Text = "Nieuwe verkiezingen";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 381);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnPartijen);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnPartijen;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
  }
}

