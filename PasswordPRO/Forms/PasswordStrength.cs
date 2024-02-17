using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PasswordPRO.Forms
{
    public partial class PasswordStrength : Form
    {
        public PasswordStrength()
        {
            InitializeComponent();
        }        

        private void PassText_TextChanged(object sender, EventArgs e)
        {
            string password = PassText.Text;
            CheckPasswordSecurity(password);
        }

        private bool IsPasswordSecure(string password)
        {
            bool isSecure = true;

            // Проверка длины пароля
            if (password.Length < 12)
            {
                isSecure = false;
                LengthLabel.ForeColor = Color.Red;
            }
            else
            {
                LengthLabel.ForeColor = Color.Green;
            }

            // Проверка наличия хотя бы одной цифры
            if (!password.Any(char.IsDigit))
            {
                isSecure = false;
                DigitLabel.ForeColor = Color.Red;
            }
            else
            {
                DigitLabel.ForeColor = Color.Green;
            }

            // Проверка наличия хотя бы одной буквы в верхнем регистре
            if (!password.Any(char.IsUpper))
            {
                isSecure = false;
                UpperLabel.ForeColor = Color.Red;
            }
            else
            {
                UpperLabel.ForeColor = Color.Green;
            }

            // Проверка наличия хотя бы одной буквы в нижнем регистре
            if (!password.Any(char.IsLower))
            {
                isSecure = false;
                LowerLabel.ForeColor = Color.Red;
            }
            else
            {
                LowerLabel.ForeColor = Color.Green;
            }

            return isSecure;
        }

        private void CheckPasswordSecurity(string password)
        {
            IsPasswordSecure(password);
        }
    }
}