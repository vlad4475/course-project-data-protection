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
    public partial class WorkWithText : Form
    {
        
        public WorkWithText()
        {
            InitializeComponent();
        }

        private void b_Encr_Click(object sender, EventArgs e)
        {
            if (!KeyGenerator.isConfirmation(t_passwordWord.Text))
            {
                return;
            }

            if(KeyGenerator.generetKeys(t_passwordWord.Text) != 0)
            {
                return;
            }

            ulong[] notCriptBlocks;
            ulong[] criptBlocks;

            WorkWithString.convertStrToBlocks(t_ToEncr.Text, out notCriptBlocks);

            criptBlocks = new ulong[notCriptBlocks.Length];

            DES.TripleDesIncode(notCriptBlocks, out criptBlocks);

            t_DeCript.Text = WorkWithString.convertBlocksTo16str(criptBlocks);

        }

        private void b_DeCript_Click(object sender, EventArgs e)
        {
            if (KeyGenerator.generetKeys(t_passwordWord.Text) != 0)
            {
                return;
            }

            ulong[] criptBlocks;
            ulong[] deCriptBlocks;

            criptBlocks = WorkWithString.convert16strToBlocks(t_ToEncr.Text);

            if (criptBlocks == null)
            {
                t_DeCript.Text = "";
                return;
            }
                

            deCriptBlocks = new ulong[criptBlocks.Length];

            DES.TripleDesDecode(criptBlocks, out deCriptBlocks);

            t_DeCript.Text = WorkWithString.convertBlocksToStr(deCriptBlocks);

        }

        private void b_loadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            String[] buf = File.ReadAllLines(dialog.FileName);

            if (buf.Length == 0)
                return;

            t_ToEncr.Text = buf[0];
        }

        private void b_saveInFile_Click(object sender, EventArgs e)
        {
            if (t_DeCript.Text == "")
            {
                MessageBox.Show("Ошибка. Строка пуста.");
                return;
            }

            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            String[] buf = new String[1];
            buf[0] = t_DeCript.Text;
            File.WriteAllLines(dialog.FileName, buf, Encoding.UTF8);

            MessageBox.Show("Сохрание произведено успешно");

        }

        
    }
}
