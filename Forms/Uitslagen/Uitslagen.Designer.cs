namespace LivePerformance.Forms.Uitslagen
{
  partial class Uitslagen
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
            this.gridUitslagen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridUitslagen)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUitslagen
            // 
            this.gridUitslagen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUitslagen.Location = new System.Drawing.Point(37, 34);
            this.gridUitslagen.Name = "gridUitslagen";
            this.gridUitslagen.Size = new System.Drawing.Size(475, 150);
            this.gridUitslagen.TabIndex = 0;
            this.gridUitslagen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUitslagen_CellClick);
            // 
            // Uitslagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 234);
            this.Controls.Add(this.gridUitslagen);
            this.Name = "Uitslagen";
            this.Text = "Uitslagen";
            ((System.ComponentModel.ISupportInitialize)(this.gridUitslagen)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView gridUitslagen;
  }
}