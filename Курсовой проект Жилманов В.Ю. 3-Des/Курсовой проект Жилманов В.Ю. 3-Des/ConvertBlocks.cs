using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Курсовой_проект_Жилманов_В.Ю._3_Des
{
    public static class WorkWithString
    {
        public static String convertBlocksToStr(ulong[] inputBlocks)
        {
            char buf;
            List<Char> lch = new List<Char>();
            String returnStr = "";

            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    using (BinaryWriter ww = new BinaryWriter(stream))
                    {
                        for (int i = 0; i < inputBlocks.Length; i++)
                            ww.Write(inputBlocks[i]);

                        ww.Flush();

                        using (BinaryReader wr = new BinaryReader(ww.BaseStream))
                        {
                            wr.BaseStream.Position = 0;
                            while (wr.BaseStream.Position != wr.BaseStream.Length)
                            {
                                buf = wr.ReadChar();
                                lch.Add(buf);
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("парольная фраза не верна.");
                return "";
            }            

            for (int i = 0; i < lch.Count; i++)
                returnStr += lch[i];

                return returnStr;
        }

        public static String convertBlocksTo16str(ulong[] criptBlocks)
        {
            String returnX16str = "";
            String bufStr = "";
            for (int i = 0; i < criptBlocks.Length; i++)
            {
                bufStr = criptBlocks[i].ToString("X");
                while (bufStr.Length != 16)
                    bufStr = "0" + bufStr;
                returnX16str += bufStr;
            }

            return returnX16str;
        }

        public static ulong[] convert16strToBlocks(String cript16Str)
        {
            String bufStr = "";
            ulong[] returnBlocks;
            returnBlocks = new ulong[cript16Str.Length / 16];
            for (int i = 0; i < cript16Str.Length / 16; i++)
            {
                bufStr = cript16Str.Substring(i * 16, 16);

                try
                {
                    returnBlocks[i] = Convert.ToUInt64(bufStr, 16);
                }
                catch(System.FormatException)
                {
                    MessageBox.Show("Строка для расшифровки должна быть в виде числа в 16ричной с.с..");
                    return null;
                }
            }
                

            return returnBlocks;
        }

        public static void convertStrToBlocks(String sourseString, out ulong[] returnBlocks)
        {
            List<UInt64> lu = new List<UInt64>();

            try
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    using (BinaryWriter ww = new BinaryWriter(stream))
                    {
                        for (int i = 0; i < sourseString.Length; i++)
                        {
                            ww.Write(sourseString[i]);
                        }

                        while (ww.BaseStream.Length % 8 != 0)
                        {
                            ww.Write(false);
                        }
                        ww.Flush();

                        using (BinaryReader wr = new BinaryReader(ww.BaseStream))
                        {
                            wr.BaseStream.Position = 0;
                            while (wr.BaseStream.Position != wr.BaseStream.Length)
                            {
                                lu.Add(wr.ReadUInt64());
                            }

                        }
                    }
                }
            }
            catch
            {
                returnBlocks = null;
                MessageBox.Show("Ошибка. Файл не является текстовым.");
                return;
            }

            

            returnBlocks = new ulong[lu.Count];
            for (int i = 0; i < lu.Count; i++)
                returnBlocks[i] = lu[i];
        }

       
    }
}
