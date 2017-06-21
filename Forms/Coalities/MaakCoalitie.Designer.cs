namespace LivePerformance.Forms.Coalities
{
  partial class MaakCoalitie
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
            this.gridPartijen = new System.Windows.Forms.DataGridView();
            this.gridCoalities = new System.Windows.Forms.DataGridView();
            this.btnMake = new System.Windows.Forms.Button();
            this.btnExportCoalitie = new System.Windows.Forms.Button();
            this.txtCoalitieNaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridPartijen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCoalities)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPartijen
            // 
            this.gridPartijen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPartijen.Location = new System.Drawing.Point(69, 12);
            this.gridPartijen.Name = "gridPartijen";
            this.gridPartijen.Size = new System.Drawing.Size(491, 88);
            this.gridPartijen.TabIndex = 0;
            this.gridPartijen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPartijen_CellClick);
            // 
            // gridCoalities
            // 
            this.gridCoalities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCoalities.Location = new System.Drawing.Point(69, 120);
            this.gridCoalities.Name = "gridCoalities";
            this.gridCoalities.Size = new System.Drawing.Size(491, 78);
            this.gridCoalities.TabIndex = 1;
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(69, 254);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(113, 29);
            this.btnMake.TabIndex = 2;
            this.btnMake.Text = "Maak coalitie";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // btnExportCoalitie
            // 
            this.btnExportCoalitie.Location = new System.Drawing.Point(447, 222);
            this.btnExportCoalitie.Name = "btnExportCoalitie";
            this.btnExportCoalitie.Size = new System.Drawing.Size(113, 29);
            this.btnExportCoalitie.TabIndex = 3;
            this.btnExportCoalitie.Text = "Exporteer coalitie";
            this.btnExportCoalitie.UseVisualStyleBackColor = true;
            this.btnExportCoalitie.Click += new System.EventHandler(this.btnExportCoalitie_Click);
            // 
            // txtCoalitieNaam
            // 
            this.txtCoalitieNaam.Location = new System.Drawing.Point(69, 228);
            this.txtCoalitieNaam.Name = "txtCoalitieNaam";
            this.txtCoalitieNaam.Size = new System.Drawing.Size(100, 20);
            this.txtCoalitieNaam.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Coalitie naam";
            // 
            // MaakCoalitie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCoalitieNaam);
            this.Controls.Add(this.btnExportCoalitie);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.gridCoalities);
            this.Controls.Add(this.gridPartijen);
            this.Name = "MaakCoalitie";
            this.Text = "MaakCoalitie";
            ((System.ComponentModel.ISupportInitialize)(this.gridPartijen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCoalities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView gridPartijen;
    private System.Windows.Forms.DataGridView gridCoalities;
    private System.Windows.Forms.Button btnMake;
    private System.Windows.Forms.Button btnExportCoalitie;
    private System.Windows.Forms.TextBox txtCoalitieNaam;
    private System.Windows.Forms.Label label1;
  }
}