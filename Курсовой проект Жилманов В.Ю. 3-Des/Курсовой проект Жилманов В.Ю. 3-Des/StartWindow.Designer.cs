namespace Курсовой_проект_Жилманов_В.Ю._3_Des
{
    partial class StartWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.режимРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСТекстомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСФайломToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работаСБинарнымФайломToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_SavaConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.t_minPassWords = new System.Windows.Forms.TextBox();
            this.p_cipherMode = new System.Windows.Forms.Panel();
            this.rb_OFB = new System.Windows.Forms.RadioButton();
            this.rb_CFB = new System.Windows.Forms.RadioButton();
            this.rb_CBC = new System.Windows.Forms.RadioButton();
            this.rb_ECB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t_IV = new System.Windows.Forms.TextBox();
            this.p_passComplexity = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_passEasy = new System.Windows.Forms.RadioButton();
            this.rb_passMedium = new System.Windows.Forms.RadioButton();
            this.rb_passHard = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.p_cipherMode.SuspendLayout();
            this.p_passComplexity.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.режимРаботыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.toolStripMenuItem1.Text = "Закрыть";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // режимРаботыToolStripMenuItem
            // 
            this.режимРаботыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСТекстомToolStripMenuItem,
            this.работаСФайломToolStripMenuItem,
            this.работаСБинарнымФайломToolStripMenuItem});
            this.режимРаботыToolStripMenuItem.Name = "режимРаботыToolStripMenuItem";
            this.режимРаботыToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.режимРаботыToolStripMenuItem.Text = "Режим работы";
            // 
            // работаСТекстомToolStripMenuItem
            // 
            this.работаСТекстомToolStripMenuItem.Name = "работаСТекстомToolStripMenuItem";
            this.работаСТекстомToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.работаСТекстомToolStripMenuItem.Text = "Работа с текстом";
            this.работаСТекстомToolStripMenuItem.Click += new System.EventHandler(this.работаСТекстомToolStripMenuItem_Click);
            // 
            // работаСФайломToolStripMenuItem
            // 
            this.работаСФайломToolStripMenuItem.Name = "работаСФайломToolStripMenuItem";
            this.работаСФайломToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.работаСФайломToolStripMenuItem.Text = "Работа с текстовым файлом";
            this.работаСФайломToolStripMenuItem.Click += new System.EventHandler(this.работаСФайломToolStripMenuItem_Click);
            // 
            // работаСБинарнымФайломToolStripMenuItem
            // 
            this.работаСБинарнымФайломToolStripMenuItem.Name = "работаСБинарнымФайломToolStripMenuItem";
            this.работаСБинарнымФайломToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.работаСБинарнымФайломToolStripMenuItem.Text = "Работа с бинарным файлом";
            this.работаСБинарнымФайломToolStripMenuItem.Click += new System.EventHandler(this.работаСБинарнымФайломToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // b_SavaConfig
            // 
            this.b_SavaConfig.Location = new System.Drawing.Point(12, 187);
            this.b_SavaConfig.Name = "b_SavaConfig";
            this.b_SavaConfig.Size = new System.Drawing.Size(700, 47);
            this.b_SavaConfig.TabIndex = 2;
            this.b_SavaConfig.Text = "Подтвердить";
            this.b_SavaConfig.UseVisualStyleBackColor = true;
            this.b_SavaConfig.Click += new System.EventHandler(this.b_SavaConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Минимальная длинна парольной фразы";
            // 
            // t_minPassWords
            // 
            this.t_minPassWords.Location = new System.Drawing.Point(599, 43);
            this.t_minPassWords.Name = "t_minPassWords";
            this.t_minPassWords.Size = new System.Drawing.Size(100, 20);
            this.t_minPassWords.TabIndex = 4;
            this.t_minPassWords.Text = "4";
            // 
            // p_cipherMode
            // 
            this.p_cipherMode.Controls.Add(this.rb_OFB);
            this.p_cipherMode.Controls.Add(this.rb_CFB);
            this.p_cipherMode.Controls.Add(this.rb_CBC);
            this.p_cipherMode.Controls.Add(this.rb_ECB);
            this.p_cipherMode.Location = new System.Drawing.Point(129, 68);
            this.p_cipherMode.Name = "p_cipherMode";
            this.p_cipherMode.Size = new System.Drawing.Size(200, 91);
            this.p_cipherMode.TabIndex = 5;
            // 
            // rb_OFB
            // 
            this.rb_OFB.AutoSize = true;
            this.rb_OFB.Location = new System.Drawing.Point(3, 71);
            this.rb_OFB.Name = "rb_OFB";
            this.rb_OFB.Size = new System.Drawing.Size(108, 17);
            this.rb_OFB.TabIndex = 3;
            this.rb_OFB.TabStop = true;
            this.rb_OFB.Text = "Output feed back";
            this.rb_OFB.UseVisualStyleBackColor = true;
            // 
            // rb_CFB
            // 
            this.rb_CFB.AutoSize = true;
            this.rb_CFB.Location = new System.Drawing.Point(3, 50);
            this.rb_CFB.Name = "rb_CFB";
            this.rb_CFB.Size = new System.Drawing.Size(136, 17);
            this.rb_CFB.TabIndex = 2;
            this.rb_CFB.TabStop = true;
            this.rb_CFB.Text = "Cipher Feedback Mode";
            this.rb_CFB.UseVisualStyleBackColor = true;
            // 
            // rb_CBC
            // 
            this.rb_CBC.AutoSize = true;
            this.rb_CBC.Location = new System.Drawing.Point(3, 26);
            this.rb_CBC.Name = "rb_CBC";
            this.rb_CBC.Size = new System.Drawing.Size(129, 17);
            this.rb_CBC.TabIndex = 1;
            this.rb_CBC.TabStop = true;
            this.rb_CBC.Text = "Cipher Block Chaining";
            this.rb_CBC.UseVisualStyleBackColor = true;
            // 
            // rb_ECB
            // 
            this.rb_ECB.AutoSize = true;
            this.rb_ECB.Location = new System.Drawing.Point(3, 3);
            this.rb_ECB.Name = "rb_ECB";
            this.rb_ECB.Size = new System.Drawing.Size(128, 17);
            this.rb_ECB.TabIndex = 0;
            this.rb_ECB.TabStop = true;
            this.rb_ECB.Text = "Electronic Code Book";
            this.rb_ECB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Режим шифрования";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вектор инициализации";
            // 
            // t_IV
            // 
            this.t_IV.Location = new System.Drawing.Point(142, 40);
            this.t_IV.Name = "t_IV";
            this.t_IV.Size = new System.Drawing.Size(187, 20);
            this.t_IV.TabIndex = 8;
            this.t_IV.Text = "0";
            // 
            // p_passComplexity
            // 
            this.p_passComplexity.Controls.Add(this.rb_passHard);
            this.p_passComplexity.Controls.Add(this.rb_passMedium);
            this.p_passComplexity.Controls.Add(this.rb_passEasy);
            this.p_passComplexity.Location = new System.Drawing.Point(512, 69);
            this.p_passComplexity.Name = "p_passComplexity";
            this.p_passComplexity.Size = new System.Drawing.Size(229, 100);
            this.p_passComplexity.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Сложность парольной \r\nфразы\r\n";
            // 
            // rb_passEasy
            // 
            this.rb_passEasy.AutoSize = true;
            this.rb_passEasy.Location = new System.Drawing.Point(12, 11);
            this.rb_passEasy.Name = "rb_passEasy";
            this.rb_passEasy.Size = new System.Drawing.Size(169, 17);
            this.rb_passEasy.TabIndex = 0;
            this.rb_passEasy.TabStop = true;
            this.rb_passEasy.Text = "Без ограничений сложность";
            this.rb_passEasy.UseVisualStyleBackColor = true;
            // 
            // rb_passMedium
            // 
            this.rb_passMedium.AutoSize = true;
            this.rb_passMedium.Location = new System.Drawing.Point(12, 35);
            this.rb_passMedium.Name = "rb_passMedium";
            this.rb_passMedium.Size = new System.Drawing.Size(183, 17);
            this.rb_passMedium.TabIndex = 1;
            this.rb_passMedium.TabStop = true;
            this.rb_passMedium.Text = "Обязательны и буквы и цифры";
            this.rb_passMedium.UseVisualStyleBackColor = true;
            // 
            // rb_passHard
            // 
            this.rb_passHard.AutoSize = true;
            this.rb_passHard.Location = new System.Drawing.Point(12, 59);
            this.rb_passHard.Name = "rb_passHard";
            this.rb_passHard.Size = new System.Drawing.Size(212, 30);
            this.rb_passHard.TabIndex = 2;
            this.rb_passHard.TabStop = true;
            this.rb_passHard.Text = "Обязательны заглавные и строчные\r\nбуквы, цифры и спец символы";
            this.rb_passHard.UseVisualStyleBackColor = true;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 240);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.p_passComplexity);
            this.Controls.Add(this.t_IV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p_cipherMode);
            this.Controls.Add(this.t_minPassWords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_SavaConfig);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StartWindow";
            this.Text = "Алгоритм 3DES";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.p_cipherMode.ResumeLayout(false);
            this.p_cipherMode.PerformLayout();
            this.p_passComplexity.ResumeLayout(false);
            this.p_passComplexity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСТекстомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работаСФайломToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button b_SavaConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_minPassWords;
        private System.Windows.Forms.Panel p_cipherMode;
        private System.Windows.Forms.RadioButton rb_CBC;
        private System.Windows.Forms.RadioButton rb_ECB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_IV;
        private System.Windows.Forms.RadioButton rb_CFB;
        private System.Windows.Forms.RadioButton rb_OFB;
        private System.Windows.Forms.ToolStripMenuItem работаСБинарнымФайломToolStripMenuItem;
        private System.Windows.Forms.Panel p_passComplexity;
        private System.Windows.Forms.RadioButton rb_passHard;
        private System.Windows.Forms.RadioButton rb_passMedium;
        private System.Windows.Forms.RadioButton rb_passEasy;
        private System.Windows.Forms.Label label4;
    }
}

