namespace LivePerformance.Forms.Verkiezingen
{
  partial class PartijPunten
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtStemmen = new System.Windows.Forms.NumericUpDown();
            this.gridPartijen = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtStemmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPartijen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Voeg toe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtStemmen
            // 
            this.txtStemmen.Location = new System.Drawing.Point(12, 153);
            this.txtStemmen.Name = "txtStemmen";
            this.txtStemmen.Size = new System.Drawing.Size(202, 20);
            this.txtStemmen.TabIndex = 3;
            // 
            // gridPartijen
            // 
            this.gridPartijen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPartijen.Location = new System.Drawing.Point(12, 30);
            this.gridPartijen.Name = "gridPartijen";
            this.gridPartijen.Size = new System.Drawing.Size(317, 107);
            this.gridPartijen.TabIndex = 4;
            this.gridPartijen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPartijen_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecteer hier partij";
            // 
            // PartijPunten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 249);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridPartijen);
            this.Controls.Add(this.txtStemmen);
            this.Controls.Add(this.btnAdd);
            this.Name = "PartijPunten";
            this.Text = "PartijPunten";
            ((System.ComponentModel.ISupportInitialize)(this.txtStemmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPartijen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.NumericUpDown txtStemmen;
    private System.Windows.Forms.DataGridView gridPartijen;
    private System.Windows.Forms.Label label1;
  }
}