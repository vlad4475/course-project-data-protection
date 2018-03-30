using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовой_проект_Жилманов_В.Ю._3_Des
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
            KeyGenerator.cipherMode = "ECB";
            KeyGenerator.passwordComplexity = "Easy";
            KeyGenerator.IV = Convert.ToUInt64(t_IV.Text);
            rb_ECB.Checked = true;
            rb_passEasy.Checked = true;
        }

        private void работаСТекстомToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            WorkWithText workWithText = new WorkWithText();
            workWithText.Show();
        }

        private void b_SavaConfig_Click(object sender, EventArgs e)
        {
            int minLeng = Convert.ToInt32(t_minPassWords.Text);

            try
            {
                KeyGenerator.IV = Convert.ToUInt64(t_IV.Text);
            }
            catch (System.OverflowException)
            {
                MessageBox.Show("Вектор инизиализации должен представлять число типа uint64");
                t_IV.Text = "0";
                KeyGenerator.IV = 0;
            }            

            if (minLeng > 0 && minLeng < 100)
                KeyGenerator.minLongPassWords = Convert.ToInt32(t_minPassWords.Text);
            else
            {
                MessageBox.Show("Длинна парольной фразы не корректна. Будет использывана предыдущая длинна или длинна по умолчанию");
                t_minPassWords.Text = "4";
            }

            setCryptMode();

            setPassComplexity();           
        }

        private void setPassComplexity()
        {
            if (rb_passEasy.Checked == true)
                KeyGenerator.passwordComplexity = "Easy";

            if (rb_passMedium.Checked == true)
                KeyGenerator.passwordComplexity = "Medium";

            if (rb_passHard.Checked == true)
                KeyGenerator.passwordComplexity = "Hard";
        }

        private void setCryptMode()
        {
            if (rb_ECB.Checked == true)
                KeyGenerator.cipherMode = "ECB";

            if (rb_CBC.Checked == true)
                KeyGenerator.cipherMode = "CBC";

            if (rb_CFB.Checked == true)
                KeyGenerator.cipherMode = "CFB";

            if (rb_OFB.Checked == true)
                KeyGenerator.cipherMode = "OFB";
        }

        private void работаСФайломToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkWithFile workWithFile = new WorkWithFile();
            workWithFile.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void работаСБинарнымФайломToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkWithBinFile workWithBinFile = new WorkWithBinFile();
            workWithBinFile.Show();
        }
    }
}
