namespace LivePerformance.Forms.Partijen
{
  partial class Partijen
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
            this.lijstrekkersGrid = new System.Windows.Forms.DataGridView();
            this.btnAddPartij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lijstrekkersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lijstrekkersGrid
            // 
            this.lijstrekkersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lijstrekkersGrid.Location = new System.Drawing.Point(42, 12);
            this.lijstrekkersGrid.Name = "lijstrekkersGrid";
            this.lijstrekkersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lijstrekkersGrid.Size = new System.Drawing.Size(435, 217);
            this.lijstrekkersGrid.TabIndex = 0;
            this.lijstrekkersGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lijstrekkersGrid_CellClick);
            // 
            // btnAddPartij
            // 
            this.btnAddPartij.Location = new System.Drawing.Point(42, 258);
            this.btnAddPartij.Name = "btnAddPartij";
            this.btnAddPartij.Size = new System.Drawing.Size(127, 23);
            this.btnAddPartij.TabIndex = 1;
            this.btnAddPartij.Text = "Nieuwe partij";
            this.btnAddPartij.UseVisualStyleBackColor = true;
            this.btnAddPartij.Click += new System.EventHandler(this.btnAddPartij_Click);
            // 
            // Partijen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 328);
            this.Controls.Add(this.btnAddPartij);
            this.Controls.Add(this.lijstrekkersGrid);
            this.Name = "Partijen";
            this.Text = "Partijen";
            ((System.ComponentModel.ISupportInitialize)(this.lijstrekkersGrid)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView lijstrekkersGrid;
    private System.Windows.Forms.Button btnAddPartij;
  }
}