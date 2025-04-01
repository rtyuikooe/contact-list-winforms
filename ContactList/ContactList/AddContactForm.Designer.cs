namespace ContactList
{
    partial class AddContactForm
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
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(78, 121);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(100, 22);
            this.txtphone.TabIndex = 0;
            this.txtphone.Text = "Phone";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(78, 66);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 22);
            this.txtname.TabIndex = 1;
            this.txtname.Text = "Name";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(637, 54);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(112, 90);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtphone);
            this.Name = "AddContactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnluu;
    }
}