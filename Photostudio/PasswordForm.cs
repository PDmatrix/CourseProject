using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photostudio
{
    public partial class PasswordForm : Form
    {
        private readonly string _adminPass;
        private readonly string _operatorPass;

        public PasswordForm()
        {
            InitializeComponent();

            _adminPass = "admin";
            _operatorPass = "operator";
        }

        private void checkPassBtn_Click(object sender, EventArgs e)
        {
            if(!passwordTB.Text.Any())
            {
                MessageBox.Show("Пароль не введен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(passwordTB.Text.Equals(_adminPass))
            {
                TablesClass.Rights = "Администратор";
            }
            else if(passwordTB.Text.Equals(_operatorPass))
            {
                TablesClass.Rights = "Оператор";
            }
            else
            {
                MessageBox.Show("Введен неправильный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void PasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
