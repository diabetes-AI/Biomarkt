﻿namespace ProNatur_Biomarkt_GmbH
{
    partial class MainMenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuScreen));
            this.btnBill = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBill
            // 
            this.btnBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBill.BackgroundImage")));
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Location = new System.Drawing.Point(452, 245);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(275, 125);
            this.btnBill.TabIndex = 1;
            this.btnBill.Text = "Rechnung erstellen";
            this.btnBill.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBill.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProducts.BackgroundImage")));
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Location = new System.Drawing.Point(76, 245);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(275, 125);
            this.btnProducts.TabIndex = 0;
            this.btnProducts.Text = "Produkte verwalten";
            this.btnProducts.UseVisualStyleBackColor = true;
            // 
            // MainMenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnProducts);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "MainMenuScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hauptmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnBill;
    }
}