﻿namespace ContactList
{
    partial class MainForm
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
            this.btnthemlienhe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnthemlienhe
            // 
            this.btnthemlienhe.Location = new System.Drawing.Point(40, 92);
            this.btnthemlienhe.Name = "btnthemlienhe";
            this.btnthemlienhe.Size = new System.Drawing.Size(210, 23);
            this.btnthemlienhe.TabIndex = 0;
            this.btnthemlienhe.Text = "Thêm liên hệ";
            this.btnthemlienhe.UseVisualStyleBackColor = true;
            this.btnthemlienhe.Click += new System.EventHandler(this.btnthemlienhe_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthemlienhe);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnthemlienhe;
    }
}

