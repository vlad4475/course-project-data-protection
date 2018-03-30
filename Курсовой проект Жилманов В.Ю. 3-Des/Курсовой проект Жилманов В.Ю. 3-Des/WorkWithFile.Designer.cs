namespace Курсовой_проект_Жилманов_В.Ю._3_Des
{
    partial class WorkWithFile
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
            this.t_passwordWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.b_DeCript = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.t_ReturnFile = new System.Windows.Forms.TextBox();
            this.b_Encr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.t_SourseFile = new System.Windows.Forms.TextBox();
            this.b_chooseSourseFile = new System.Windows.Forms.Button();
            this.b_couseReturnFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // t_passwordWord
            // 
            this.t_passwordWord.Location = new System.Drawing.Point(127, 94);
            this.t_passwordWord.Name = "t_passwordWord";
            this.t_passwordWord.PasswordChar = '*';
            this.t_passwordWord.Size = new System.Drawing.Size(291, 20);
            this.t_passwordWord.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Пароьльная фраза";
            // 
            // b_DeCript
            // 
            this.b_DeCript.Location = new System.Drawing.Point(218, 121);
            this.b_DeCript.Name = "b_DeCript";
            this.b_DeCript.Size = new System.Drawing.Size(200, 29);
            this.b_DeCript.TabIndex = 13;
            this.b_DeCript.Text = "Расшифровать исходный файл";
            this.b_DeCript.UseVisualStyleBackColor = true;
            this.b_DeCript.Click += new System.EventHandler(this.b_DeCript_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Файл результата";
            // 
            // t_ReturnFile
            // 
            this.t_ReturnFile.Location = new System.Drawing.Point(127, 65);
            this.t_ReturnFile.Name = "t_ReturnFile";
            this.t_ReturnFile.Size = new System.Drawing.Size(291, 20);
            this.t_ReturnFile.TabIndex = 11;
            // 
            // b_Encr
            // 
            this.b_Encr.Location = new System.Drawing.Point(12, 121);
            this.b_Encr.Name = "b_Encr";
            this.b_Encr.Size = new System.Drawing.Size(200, 29);
            this.b_Encr.TabIndex = 10;
            this.b_Encr.Text = "Зашфровать исходный файл";
            this.b_Encr.UseVisualStyleBackColor = true;
            this.b_Encr.Click += new System.EventHandler(this.b_Encr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Исходный файл";
            // 
            // t_SourseFile
            // 
            this.t_SourseFile.Location = new System.Drawing.Point(127, 41);
            this.t_SourseFile.Name = "t_SourseFile";
            this.t_SourseFile.Size = new System.Drawing.Size(291, 20);
            this.t_SourseFile.TabIndex = 8;
            // 
            // b_chooseSourseFile
            // 
            this.b_chooseSourseFile.Location = new System.Drawing.Point(424, 39);
            this.b_chooseSourseFile.Name = "b_chooseSourseFile";
            this.b_chooseSourseFile.Size = new System.Drawing.Size(102, 23);
            this.b_chooseSourseFile.TabIndex = 16;
            this.b_chooseSourseFile.Text = "Выбрать файл";
            this.b_chooseSourseFile.UseVisualStyleBackColor = true;
            this.b_chooseSourseFile.Click += new System.EventHandler(this.b_chooseSourseFile_Click);
            // 
            // b_couseReturnFile
            // 
            this.b_couseReturnFile.Location = new System.Drawing.Point(424, 68);
            this.b_couseReturnFile.Name = "b_couseReturnFile";
            this.b_couseReturnFile.Size = new System.Drawing.Size(102, 23);
            this.b_couseReturnFile.TabIndex = 17;
            this.b_couseReturnFile.Text = "Выбрать файл";
            this.b_couseReturnFile.UseVisualStyleBackColor = true;
            this.b_couseReturnFile.Click += new System.EventHandler(this.b_couseReturnFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Желательная кодировка исходного файла UTF-8.";
            // 
            // WorkWithFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 160);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_couseReturnFile);
            this.Controls.Add(this.b_chooseSourseFile);
            this.Controls.Add(this.t_passwordWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_DeCript);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_ReturnFile);
            this.Controls.Add(this.b_Encr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_SourseFile);
            this.Name = "WorkWithFile";
            this.Text = "Режим работы с текстовыми файлами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_passwordWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_DeCript;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_ReturnFile;
        private System.Windows.Forms.Button b_Encr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_SourseFile;
        private System.Windows.Forms.Button b_chooseSourseFile;
        private System.Windows.Forms.Button b_couseReturnFile;
        private System.Windows.Forms.Label label4;
    }
}