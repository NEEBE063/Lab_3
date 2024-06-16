namespace Lab3
{
    partial class fMain
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
            this.tbPhonesInfo = new System.Windows.Forms.TextBox();
            this.btnAddPhone = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPhonesInfo
            // 
            this.tbPhonesInfo.Location = new System.Drawing.Point(12, 12);
            this.tbPhonesInfo.Multiline = true;
            this.tbPhonesInfo.Name = "tbPhonesInfo";
            this.tbPhonesInfo.ReadOnly = true;
            this.tbPhonesInfo.Size = new System.Drawing.Size(647, 426);
            this.tbPhonesInfo.TabIndex = 0;
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.Location = new System.Drawing.Point(665, 10);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(138, 27);
            this.btnAddPhone.TabIndex = 1;
            this.btnAddPhone.Text = "Додати велосипед";
            this.btnAddPhone.UseVisualStyleBackColor = true;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddBicycle_Click);
            // 
            // btnClose
            // 
            this.btnClose.CausesValidation = false;
            this.btnClose.Location = new System.Drawing.Point(665, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 27);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCloseClick);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddPhone);
            this.Controls.Add(this.tbPhonesInfo);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPhonesInfo;
        private System.Windows.Forms.Button btnAddPhone;
        private System.Windows.Forms.Button btnClose;
    }
}

