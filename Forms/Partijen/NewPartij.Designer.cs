﻿namespace LivePerformance.Forms.Partijen
{
  partial class NewPartij
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtListTrekker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddPartij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(88, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtListTrekker
            // 
            this.txtListTrekker.Location = new System.Drawing.Point(88, 69);
            this.txtListTrekker.Name = "txtListTrekker";
            this.txtListTrekker.Size = new System.Drawing.Size(150, 20);
            this.txtListTrekker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lijstrekker";
            // 
            // btnAddPartij
            // 
            this.btnAddPartij.Location = new System.Drawing.Point(75, 129);
            this.btnAddPartij.Name = "btnAddPartij";
            this.btnAddPartij.Size = new System.Drawing.Size(132, 37);
            this.btnAddPartij.TabIndex = 4;
            this.btnAddPartij.Text = "Maak partij";
            this.btnAddPartij.UseVisualStyleBackColor = true;
            this.btnAddPartij.Click += new System.EventHandler(this.btnAddPartij_Click);
            // 
            // NewPartij
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 197);
            this.Controls.Add(this.btnAddPartij);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtListTrekker);
            this.Controls.Add(this.txtName);
            this.Name = "NewPartij";
            this.Text = "Partij toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtListTrekker;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnAddPartij;
  }
}