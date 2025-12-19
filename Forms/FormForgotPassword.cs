using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fightclub_QL_Hang.Forms
{
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void FormForgotPassword_Load(object sender, EventArgs e)
        {
            txt_emailForgotPassword.Text = "Email";
            txt_emailForgotPassword.ForeColor = Color.Gray;

            txt_newPassword.Text = "Mật khẩu mới";
            txt_newPassword.ForeColor = Color.Gray;

            txt_newConfirmPassword.Text = "Xác nhận mật khẩu";
            txt_newConfirmPassword.ForeColor = Color.Gray;

            txt_newPassword.UseSystemPasswordChar = false;
            txt_newConfirmPassword.UseSystemPasswordChar = false;
        }

        private void txt_emailForgotPassword_Leave(object sender, EventArgs e)
        {
            txt_emailForgotPassword.Text = "Email";
            txt_emailForgotPassword.ForeColor = Color.Gray;
        }

        private void txt_newPassword_Enter(object sender, EventArgs e)
        {
            if(txt_newPassword.Text == "Mật khẩu mới")
            {
                txt_newPassword.Text = "";
                txt_newPassword.ForeColor= Color.Black;

                txt_newPassword.UseSystemPasswordChar = true;
            }
        }

        private void txt_emailForgotPassword_Enter(object sender, EventArgs e)
        {
            if (txt_emailForgotPassword.Text == "Email")
            {
                txt_emailForgotPassword.Text = "";
                txt_emailForgotPassword.ForeColor = Color.Black;
            }
        }

        private void txt_newConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txt_newConfirmPassword.Text == "Xác nhận mật khẩu")
            {
                txt_newConfirmPassword.Text = "";
                txt_newConfirmPassword.ForeColor= Color.Black;

                txt_newConfirmPassword.UseSystemPasswordChar= true;
            }
        }

        private void txt_newPassword_Leave(object sender, EventArgs e)
        {
            txt_newPassword.UseSystemPasswordChar = false;
            txt_newPassword.Text = "Mật khẩu mới";
            txt_newPassword.ForeColor = Color.Gray;
        }

        private void txt_newConfirmPassword_Leave(object sender, EventArgs e)
        {
            txt_newConfirmPassword.UseSystemPasswordChar = false;
            txt_newConfirmPassword.Text = "Xác nhận mật khẩu";
            txt_newConfirmPassword.ForeColor = Color.Gray;
        }
    }
}
