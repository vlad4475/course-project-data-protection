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
    public partial class PasswordСonfirmation : Form
    {
        String password;
        public PasswordСonfirmation(String pass)
        {
            password = pass;
            InitializeComponent();
        }

        private void PasswordСonfirmation_Load(object sender, EventArgs e)
        {

        }

        private void b_confirmation_Click(object sender, EventArgs e)
        {
            if (password == t_confirmation.Text)
            {
                KeyGenerator.setConfirmation();
            }

            Close();
        }
    }
}
