using PasswordPRO.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace PasswordPRO
{
    public partial class Form1 : Form
    {

        private Random rnd;

        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string GeneratePassword()
        {
            int len = (int)lengthPass.Value; //переменная для хранения длины пароля (из lengthPass)
            var myValue = OtherSymbolsTextBox.Text; //переменная для хранения своих символов
            string chars = ""; //переменная для хранения выбранных символов
            string result = ""; //переменная для хранения результата

            if (SettingRadio.Checked == true)
            {
                if (NumCheckBox.Checked || SymbolsCheckBox.Checked || UpperCaseCyrilliccheckBox.Checked || UpperCaseLatincheckBox.Checked || LowerCaseCyrillicCheckBox.Checked || LowerCaseLatincheckBox.Checked || NonecharsSheckBox.Checked)
                {
                    if (NumCheckBox.Checked)
                        chars += "0123456789";
                    if (SymbolsCheckBox.Checked)
                        chars += "!#$%^&*()";
                    if (UpperCaseCyrilliccheckBox.Checked)
                        chars += "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЫЬЭЮЯ";
                    if (UpperCaseLatincheckBox.Checked)
                        chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    if (LowerCaseCyrillicCheckBox.Checked)
                        chars += "абвгдежзийклмнопрстуфхцчшщыьэюя";
                    if (LowerCaseLatincheckBox.Checked)
                        chars += "abcdefghijklmnopqrstuvwxyz";
                    if (NonecharsSheckBox.Checked)
                    {
                        chars = chars.Replace("i", "").Replace("l", "").Replace("1", "").Replace("L", "").Replace("o", "").Replace("0", "").Replace("O", "");
                    }

                    int lng = chars.Length;
                    for (int i = 0; i < len; i++)
                        result += chars[rnd.Next(lng)];
                    return result;
                }
                else
                    return "Установите параметры пароля";
            }
            else
            {
                if (OtherSymbolsTextBox.Text == "")
                    return "Задайте символы для пароля";
                else
                {
                    int lng = myValue.Length;
                    for (int i = 0; i < len; i++)
                        result += myValue[rnd.Next(lng)];
                    return result;
                }
            }
        }

        private void GenerButton_Click(object sender, EventArgs e)
        {
            PassText1.Text = GeneratePassword();
            PassText2.Text = GeneratePassword();
            PassText3.Text = GeneratePassword();
            PassText4.Text = GeneratePassword();
            PassText5.Text = GeneratePassword();
            PassText6.Text = GeneratePassword();
        }

        private void CopyToClipboardWithNotification(string text, Control control)
        {
            if (!string.IsNullOrEmpty(text))
            {
                // Копируем текст в буфер обмена
                Clipboard.SetText(text);

                // Отображаем уведомление в Tooltip
                toolTip1.SetToolTip(control, "Пароль скопирован");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //очистка всех textbox
            PassText1.Clear();
            PassText2.Clear();
            PassText3.Clear();
            PassText4.Clear();
            PassText5.Clear();
            PassText6.Clear();
            OtherSymbolsTextBox.Clear();
        }

        private void OtherSymbolsTextBox_Click(object sender, EventArgs e)
        {
            //Задать свои символы для пароля, отмечается автоматчески по клику на OtherSymbolsTextBox
            OtherSettingsRadio.Checked = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                FileName = "Пароли",
                DefaultExt = "*.txt",
                Filter = "Текстовый файл|*.txt"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName, true))
                {
                    streamWriter.WriteLine("===" + "\r\n");

                    streamWriter.WriteLine("Пароль: " + PassText1.Text);
                    streamWriter.WriteLine("Пароль: " + PassText2.Text);
                    streamWriter.WriteLine("Пароль: " + PassText3.Text);
                    streamWriter.WriteLine("Пароль: " + PassText4.Text);
                    streamWriter.WriteLine("Пароль: " + PassText5.Text);
                    streamWriter.WriteLine("Пароль: " + PassText6.Text);

                    streamWriter.Close();
                }

                MessageBox.Show("Пароли сохранены.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PassText1_MouseClick(object sender, MouseEventArgs e)
        {
            CopyToClipboardWithNotification(PassText1.Text, PassText1);
        }

        private void PassText2_MouseClick(object sender, MouseEventArgs e)
        {
            CopyToClipboardWithNotification(PassText2.Text, PassText2);
        }

        private void PassText3_MouseClick(object sender, MouseEventArgs e)
        {
            CopyToClipboardWithNotification(PassText3.Text, PassText3);
        }
        private void PassText4_MouseClick(object sender, MouseEventArgs e)
        {
            CopyToClipboardWithNotification(PassText4.Text, PassText4);
        }

        private void PassText5_MouseClick(object sender, MouseEventArgs e)
        {
            CopyToClipboardWithNotification(PassText5.Text, PassText5);
        }

        private void PassText6_MouseClick(object sender, MouseEventArgs e)
        {
            CopyToClipboardWithNotification(PassText6.Text, PassText6);
        }

        private void HomePageMenu_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tehadm.ru/");
        }

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            Form ifrm = new AboutForm();
            ifrm.ShowDialog();
        }

        private void PassManMenu_Click(object sender, EventArgs e)
        {
            PassMan ifrm = new PassMan();
            ifrm.Show();
        }

        private void PassStrenMenuItem_Click(object sender, EventArgs e)
        {
            PasswordStrength ifrm = new PasswordStrength();
            ifrm.Show();
        }
    }
}