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
            this.btnCoalitie = new System.Windows.Forms.Button();
            this.btnPartijen = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnNewVerkiezing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCoalitie
            // 
            this.btnCoalitie.Location = new System.Drawing.Point(34, 12);
            this.btnCoalitie.Name = "btnCoalitie";
            this.btnCoalitie.Size = new System.Drawing.Size(164, 140);
            this.btnCoalitie.TabIndex = 0;
            this.btnCoalitie.Text = "Coalities";
            this.btnCoalitie.UseVisualStyleBackColor = true;
            this.btnCoalitie.Click += new System.EventHandler(this.btnCoalitie_Click);
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
            this.button3.Text = "Uitslagen";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNewVerkiezing
            // 
            this.btnNewVerkiezing.Location = new System.Drawing.Point(272, 190);
            this.btnNewVerkiezing.Name = "btnNewVerkiezing";
            this.btnNewVerkiezing.Size = new System.Drawing.Size(164, 140);
            this.btnNewVerkiezing.TabIndex = 3;
            this.btnNewVerkiezing.Text = "Nieuwe verkiezing";
            this.btnNewVerkiezing.UseVisualStyleBackColor = true;
            this.btnNewVerkiezing.Click += new System.EventHandler(this.btnNewVerkiezing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 381);
            this.Controls.Add(this.btnNewVerkiezing);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnPartijen);
            this.Controls.Add(this.btnCoalitie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.Button btnCoalitie;
    private System.Windows.Forms.Button btnPartijen;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button btnNewVerkiezing;
  }
}

