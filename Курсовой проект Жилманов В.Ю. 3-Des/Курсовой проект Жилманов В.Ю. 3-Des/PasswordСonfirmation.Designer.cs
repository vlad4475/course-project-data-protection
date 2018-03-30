namespace Курсовой_проект_Жилманов_В.Ю._3_Des
{
    partial class PasswordСonfirmation
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
            this.b_confirmation = new System.Windows.Forms.Button();
            this.t_confirmation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_confirmation
            // 
            this.b_confirmation.Location = new System.Drawing.Point(12, 39);
            this.b_confirmation.Name = "b_confirmation";
            this.b_confirmation.Size = new System.Drawing.Size(75, 23);
            this.b_confirmation.TabIndex = 0;
            this.b_confirmation.Text = "Подтвердить";
            this.b_confirmation.UseVisualStyleBackColor = true;
            this.b_confirmation.Click += new System.EventHandler(this.b_confirmation_Click);
            // 
            // t_confirmation
            // 
            this.t_confirmation.Location = new System.Drawing.Point(13, 13);
            this.t_confirmation.Name = "t_confirmation";
            this.t_confirmation.PasswordChar = '*';
            this.t_confirmation.Size = new System.Drawing.Size(172, 20);
            this.t_confirmation.TabIndex = 1;
            // 
            // PasswordСonfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 71);
            this.Controls.Add(this.t_confirmation);
            this.Controls.Add(this.b_confirmation);
            this.Name = "PasswordСonfirmation";
            this.Text = "PasswordСonfirmation";
            this.Load += new System.EventHandler(this.PasswordСonfirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_confirmation;
        private System.Windows.Forms.TextBox t_confirmation;
    }
}