namespace LivePerformance.Forms.Coalities
{
  partial class OneCoalitie
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
            this.gridOneCoalitie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridOneCoalitie)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOneCoalitie
            // 
            this.gridOneCoalitie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOneCoalitie.Location = new System.Drawing.Point(35, 48);
            this.gridOneCoalitie.Name = "gridOneCoalitie";
            this.gridOneCoalitie.Size = new System.Drawing.Size(240, 150);
            this.gridOneCoalitie.TabIndex = 0;
            // 
            // OneCoalitie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 279);
            this.Controls.Add(this.gridOneCoalitie);
            this.Name = "OneCoalitie";
            this.Text = "Coalitie";
            ((System.ComponentModel.ISupportInitialize)(this.gridOneCoalitie)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView gridOneCoalitie;
  }
}