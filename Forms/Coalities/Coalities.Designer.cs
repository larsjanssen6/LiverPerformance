namespace LivePerformance.Forms.Coalities
{
  partial class Coalities
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
            this.gridCoalities = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCoalities)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCoalities
            // 
            this.gridCoalities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCoalities.Location = new System.Drawing.Point(24, 26);
            this.gridCoalities.Name = "gridCoalities";
            this.gridCoalities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCoalities.Size = new System.Drawing.Size(553, 211);
            this.gridCoalities.TabIndex = 0;
            this.gridCoalities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCoalities_CellClick);
            // 
            // Coalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 287);
            this.Controls.Add(this.gridCoalities);
            this.Name = "Coalities";
            this.Text = "Coalities";
            ((System.ComponentModel.ISupportInitialize)(this.gridCoalities)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView gridCoalities;
  }
}