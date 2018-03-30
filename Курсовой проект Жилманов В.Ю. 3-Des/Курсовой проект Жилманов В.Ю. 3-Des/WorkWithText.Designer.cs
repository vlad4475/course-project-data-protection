namespace Курсовой_проект_Жилманов_В.Ю._3_Des
{
    partial class WorkWithText
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
            this.t_ToEncr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_Encr = new System.Windows.Forms.Button();
            this.t_DeCript = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b_DeCript = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.t_passwordWord = new System.Windows.Forms.TextBox();
            this.b_loadFromFile = new System.Windows.Forms.Button();
            this.b_saveInFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // t_ToEncr
            // 
            this.t_ToEncr.Location = new System.Drawing.Point(127, 31);
            this.t_ToEncr.Name = "t_ToEncr";
            this.t_ToEncr.Size = new System.Drawing.Size(291, 20);
            this.t_ToEncr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Исходная строка";
            // 
            // b_Encr
            // 
            this.b_Encr.Location = new System.Drawing.Point(11, 111);
            this.b_Encr.Name = "b_Encr";
            this.b_Encr.Size = new System.Drawing.Size(190, 34);
            this.b_Encr.TabIndex = 2;
            this.b_Encr.Text = "Зашфровать исходную строку";
            this.b_Encr.UseVisualStyleBackColor = true;
            this.b_Encr.Click += new System.EventHandler(this.b_Encr_Click);
            // 
            // t_DeCript
            // 
            this.t_DeCript.Location = new System.Drawing.Point(127, 55);
            this.t_DeCript.Name = "t_DeCript";
            this.t_DeCript.Size = new System.Drawing.Size(291, 20);
            this.t_DeCript.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Результат";
            // 
            // b_DeCript
            // 
            this.b_DeCript.Location = new System.Drawing.Point(207, 111);
            this.b_DeCript.Name = "b_DeCript";
            this.b_DeCript.Size = new System.Drawing.Size(207, 33);
            this.b_DeCript.TabIndex = 5;
            this.b_DeCript.Text = "Расшифровать исходную строку";
            this.b_DeCript.UseVisualStyleBackColor = true;
            this.b_DeCript.Click += new System.EventHandler(this.b_DeCript_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароьльная фраза";
            // 
            // t_passwordWord
            // 
            this.t_passwordWord.Location = new System.Drawing.Point(127, 84);
            this.t_passwordWord.Name = "t_passwordWord";
            this.t_passwordWord.PasswordChar = '*';
            this.t_passwordWord.Size = new System.Drawing.Size(291, 20);
            this.t_passwordWord.TabIndex = 7;
            // 
            // b_loadFromFile
            // 
            this.b_loadFromFile.Location = new System.Drawing.Point(425, 29);
            this.b_loadFromFile.Name = "b_loadFromFile";
            this.b_loadFromFile.Size = new System.Drawing.Size(133, 23);
            this.b_loadFromFile.TabIndex = 8;
            this.b_loadFromFile.Text = "Загрузить из файла";
            this.b_loadFromFile.UseVisualStyleBackColor = true;
            this.b_loadFromFile.Click += new System.EventHandler(this.b_loadFromFile_Click);
            // 
            // b_saveInFile
            // 
            this.b_saveInFile.Location = new System.Drawing.Point(425, 55);
            this.b_saveInFile.Name = "b_saveInFile";
            this.b_saveInFile.Size = new System.Drawing.Size(133, 23);
            this.b_saveInFile.TabIndex = 9;
            this.b_saveInFile.Text = "Сохранить в файл";
            this.b_saveInFile.UseVisualStyleBackColor = true;
            this.b_saveInFile.Click += new System.EventHandler(this.b_saveInFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Желательная кодировка исходного файла UTF-8.";
            // 
            // WorkWithText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 152);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_saveInFile);
            this.Controls.Add(this.b_loadFromFile);
            this.Controls.Add(this.t_passwordWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_DeCript);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_DeCript);
            this.Controls.Add(this.b_Encr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_ToEncr);
            this.Name = "WorkWithText";
            this.Text = "Текстовый режим";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_ToEncr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_Encr;
        private System.Windows.Forms.TextBox t_DeCript;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_DeCript;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_passwordWord;
        private System.Windows.Forms.Button b_loadFromFile;
        private System.Windows.Forms.Button b_saveInFile;
        private System.Windows.Forms.Label label4;
    }
}