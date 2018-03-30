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
    public partial class WorkWithBinFile : Form
    {
        public WorkWithBinFile()
        {
            InitializeComponent();
        }

        private void b_chooseSourseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                t_SourseFile.Text = dialog.FileName;
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

            List<ulong> ul = new List<ulong>();

            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(t_SourseFile.Text, FileMode.Append)))
                            {
                                while (writer.BaseStream.Length % 8 != 0)
                                    writer.Write(false);
                            }
            }
            catch
            {
                MessageBox.Show("Имя исходного файла указано не верно.");
            }
            
            try
            {
                using (BinaryReader reader = new BinaryReader(File.Open(t_SourseFile.Text, FileMode.Open)))
                {
                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                        ul.Add(reader.ReadUInt64());
                }
            }
            catch
            {
                MessageBox.Show("Имя файла результатов указано не верно.");
            }

            ulong[] ulongToCript = new ulong[ul.Count];
            ulong[] ulongCript = new ulong[ul.Count];

            for (int i = 0; i < ul.Count; i++)
                ulongToCript[i] = ul[i];

            DES.TripleDesIncode(ulongToCript, out ulongCript);

            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(t_ReturnFile.Text, FileMode.Create)))
                        {
                            for (int i = 0; i < ulongCript.Length; i++)
                                writer.Write(ulongCript[i]);
                        }
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

            List<ulong> ul = new List<ulong>();

            using (BinaryWriter writer = new BinaryWriter(File.Open(t_SourseFile.Text, FileMode.Append)))
            {
                while (writer.BaseStream.Length % 8 != 0)
                    writer.Write(false);
            }

            using (BinaryReader reader = new BinaryReader(File.Open(t_SourseFile.Text, FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                    ul.Add(reader.ReadUInt64());
            }

            ulong[] ulongToCript = new ulong[ul.Count];
            ulong[] ulongCript = new ulong[ul.Count];

            for (int i = 0; i < ul.Count; i++)
                ulongToCript[i] = ul[i];

            DES.TripleDesDecode(ulongToCript, out ulongCript);

            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(t_ReturnFile.Text, FileMode.Create)))
                {
                    for (int i = 0; i < ulongCript.Length; i++)
                        writer.Write(ulongCript[i]);
                }
            }            
            catch
            {
                MessageBox.Show("Имя файла результатов указано не верно.");
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
    }
}
