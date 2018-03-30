using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовой_проект_Жилманов_В.Ю._3_Des
{
    public static class KeyGenerator
    {
        public static ulong[] keys;
        public static String cipherMode;
        public static int minLongPassWords = 5;
        public static String passwordComplexity;
        public static ulong IV = 0;
        private static bool conf = false;

        public static bool isConfirmation(String pass)
        {
            PasswordСonfirmation pc = new PasswordСonfirmation(pass);
            pc.ShowDialog();

            if (conf)
            {
                conf = false;
                return true;
            }

            MessageBox.Show("Парольная фраза подтверждена не верно.");
            return false;
        }

        public static void setConfirmation()
        {
            conf = true;  
        }

        private static int isComplexityCorrect(String passWords)
        {
            if (passwordComplexity == "Easy")
                return 0;

            bool isHaveNumeric = false;
            bool isHaveLetter = false;
            bool isHaveSpecialCharacters = false;

            for (int i = 0; i < passWords.Length; i++)
            {
                if (passWords[i] >= '0' && passWords[i] <= '9')
                    isHaveNumeric = true;

                if ((passWords[i] >= 'a' && passWords[i] <= 'z') || (passWords[i] >= 'а' && passWords[i] <= 'я') || (passWords[i] >= 'A' && passWords[i] <= 'Z') || (passWords[i] >= 'А' && passWords[i] <= 'Я'))
                    isHaveLetter = true;

                if ((passWords[i] >= '!' && passWords[i] <= '/') || (passWords[i] >= ':' && passWords[i] <= '?'))
                    isHaveSpecialCharacters = true;
            }

            if (passwordComplexity == "Medium")
            {
                if(isHaveNumeric && isHaveLetter)
                    return 0;

                return 1;
            }

            if (passwordComplexity == "Hard")
            {
                if (isHaveNumeric && isHaveLetter && isHaveSpecialCharacters)
                    return 0;

                return 1;
            }

            return 2;
        }

        public static int generetKeys(String passWords)
        {
            ulong[] bufMasKeys;
            if (passWords.Length < minLongPassWords)
            {
                MessageBox.Show("Парольная фраза должна быть не меньше " + minLongPassWords + " символов");
                return 1;
            }

            int isCompPassResult = isComplexityCorrect(passWords);
            if (isCompPassResult == 1)
            {
                MessageBox.Show("Не соответствует выбранной сложности: " + passwordComplexity);
                return 1;
            }
            if (isCompPassResult == 2)
            {
                MessageBox.Show("Неизвестная ошибка с парольной фразой.");
                return 1;
            }

            WorkWithString.convertStrToBlocks(passWords, out bufMasKeys);

            keys = new ulong[3];

            switch(bufMasKeys.Length)
            {
                case 1:
                     keys[0] = bufMasKeys[0];
                     keys[1] = 0x0000000000000000;
                     keys[2] = 0x0000000000000000;
                     break;

                case 2:
                     keys[0] = bufMasKeys[0];
                     keys[1] = bufMasKeys[1];
                     keys[2] = 0x0000000000000000;
                     break;

                default:
                     keys[0] = bufMasKeys[0];
                     keys[1] = bufMasKeys[1];
                     keys[2] = bufMasKeys[2];
                     break;
            }

            return 0;
        }
    }
}
