using System;
using System.Windows.Forms;

namespace PasswordPRO
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            // Загружаем информацию об изменениях из ресурсов проекта
            string changes = Properties.Resources.InfoUpdate;

            // Устанавливаем текстовый контрол в соответствии с информацией
            InfoUpdatTtextBox.Text = changes;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://tehadm.ru/");
        }
    }
}