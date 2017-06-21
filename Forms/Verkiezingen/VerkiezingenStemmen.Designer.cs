namespace LivePerformance.Forms.Verkiezingen
{
  partial class VerkiezingenStemmen
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
            this.gridStemmen = new System.Windows.Forms.DataGridView();
            this.btnAddPartij = new System.Windows.Forms.Button();
            this.btnMakeCoalitie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridStemmen)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStemmen
            // 
            this.gridStemmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStemmen.Location = new System.Drawing.Point(38, 12);
            this.gridStemmen.Name = "gridStemmen";
            this.gridStemmen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStemmen.Size = new System.Drawing.Size(561, 170);
            this.gridStemmen.TabIndex = 0;
            // 
            // btnAddPartij
            // 
            this.btnAddPartij.Location = new System.Drawing.Point(38, 229);
            this.btnAddPartij.Name = "btnAddPartij";
            this.btnAddPartij.Size = new System.Drawing.Size(142, 47);
            this.btnAddPartij.TabIndex = 1;
            this.btnAddPartij.Text = "Voeg partij/punten toe";
            this.btnAddPartij.UseVisualStyleBackColor = true;
            this.btnAddPartij.Click += new System.EventHandler(this.btnAddPartij_Click);
            // 
            // btnMakeCoalitie
            // 
            this.btnMakeCoalitie.Location = new System.Drawing.Point(482, 229);
            this.btnMakeCoalitie.Name = "btnMakeCoalitie";
            this.btnMakeCoalitie.Size = new System.Drawing.Size(117, 47);
            this.btnMakeCoalitie.TabIndex = 2;
            this.btnMakeCoalitie.Text = "Maak coalitie";
            this.btnMakeCoalitie.UseVisualStyleBackColor = true;
            this.btnMakeCoalitie.Click += new System.EventHandler(this.btnMakeCoalitie_Click);
            // 
            // VerkiezingenStemmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 306);
            this.Controls.Add(this.btnMakeCoalitie);
            this.Controls.Add(this.btnAddPartij);
            this.Controls.Add(this.gridStemmen);
            this.Name = "VerkiezingenStemmen";
            this.Text = "VerkiezingenStemmen";
            ((System.ComponentModel.ISupportInitialize)(this.gridStemmen)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView gridStemmen;
    private System.Windows.Forms.Button btnAddPartij;
    private System.Windows.Forms.Button btnMakeCoalitie;
  }
}