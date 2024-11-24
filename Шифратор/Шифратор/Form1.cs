using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Шифратор
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string login = login_txt.Text;
            string password = password_txt.Text;
            if (login.Length == password.Length && login.Length>0)
            {                
                //показ форми
                this.Hide();

                MainForm mainForm = new MainForm();
                mainForm.Show();
                mainForm.FormClosed += (s, args) => this.Close();
            }
            else
            {
                MessageBox.Show("Неправильне ім'я користувача або пароль.", "Помилка входу", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
