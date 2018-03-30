using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Курсовой_проект_Жилманов_В.Ю._3_Des
{
    public partial class WorkWithFile : Form
    {
        public WorkWithFile()
        {
            InitializeComponent();
        }

        private void b_chooseSourseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                t_SourseFile.Text = dialog.FileName;
            }
        }

        private void b_couseReturnFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                t_ReturnFile.Text = dialog.FileName;
            }
        }

        private void b_Encr_Click(object sender, EventArgs e)
        {
            if (!KeyGenerator.isConfirmation(t_passwordWord.Text))
            {
                return;
            }

            if (KeyGenerator.generetKeys(t_passwordWord.Text) != 0)
            {
                return;
            }
            
            ulong []sourseBlock;
            ulong []criptBlock;
            string[] readText;

            try
            {
                readText = File.ReadAllLines(t_SourseFile.Text);
            }            
            catch
            {
                MessageBox.Show("Имя исходного файла указано не верно.");
                return;
            }

            String allStr = "";
            for (int i = 0; i < readText.Length; i++)
            {
                allStr += readText[i];
                allStr += Environment.NewLine;
            }
                
            String[] criptoText16 = new String[1];
            WorkWithString.convertStrToBlocks(allStr, out sourseBlock);

            if (sourseBlock == null)
                return;

            DES.TripleDesIncode(sourseBlock, out criptBlock);
            criptoText16[0] = WorkWithString.convertBlocksTo16str(criptBlock);

            try
            {
                File.WriteAllLines(t_ReturnFile.Text, criptoText16);
            }
            catch
            {
                MessageBox.Show("Имя файла результатов указано не верно.");
            }
          
        }

        private void b_DeCript_Click(object sender, EventArgs e)
        {
            if (KeyGenerator.generetKeys(t_passwordWord.Text) != 0)
            {
                return;
            }

            ulong[] deCriptBlock;
            ulong[] criptBlock;
            string[] readText;
            try
            {
                 readText = File.ReadAllLines(t_SourseFile.Text);
            }
            catch
            {
                MessageBox.Show("Имя исходного файла указано не верно.");
                return;
            }

            String[] deCriptoText = new String[1];
            String allStr = "";
            for (int i = 0; i < readText.Length; i++)
                allStr += readText[i];

            criptBlock = WorkWithString.convert16strToBlocks(allStr);

            if (criptBlock == null)
            {
                return;
            }

            DES.TripleDesDecode(criptBlock, out deCriptBlock);
            deCriptoText[0] = WorkWithString.convertBlocksToStr(deCriptBlock);
            try
            {
                File.WriteAllLines(t_ReturnFile.Text, deCriptoText);
            }
            catch
            {
                MessageBox.Show("Имя файла результатов указано не верно.");
                return;
            }
            
        }
    }
}
