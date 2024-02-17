using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace PasswordPRO.Forms
{
    public partial class PassMan : Form
    {
        private string xmlFilePath = "data.xml";

        public PassMan()
        {
            InitializeComponent();

            // Добавляем столбцы в DataGridView
            dataGridView1.Columns.Add("pass", "Пароль");
            dataGridView1.Columns.Add("comm", "Комментарий");
        }

        private void AddButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(passTextBox.Text) || string.IsNullOrEmpty(commTextBox.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка.");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Вы действительно хотите добавить запись:\nПароль: {passTextBox.Text}\nКомментарий: {commTextBox.Text}", "Подтверждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = passTextBox.Text;
                    dataGridView1.Rows[n].Cells[1].Value = commTextBox.Text;

                    SaveData();
                }
            }
        }
        private void EditButton_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                if (string.IsNullOrEmpty(passTextBox.Text) || string.IsNullOrEmpty(commTextBox.Text))
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка.");
                }
                else
                {
                    string oldPass = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                    string oldComm = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();

                    DialogResult result = MessageBox.Show($"Вы действительно хотите изменить запись:\nПароль: {oldPass}\nКомментарий: {oldComm}", "Подтверждение", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        dataGridView1.Rows[rowIndex].Cells[0].Value = passTextBox.Text;
                        dataGridView1.Rows[rowIndex].Cells[1].Value = commTextBox.Text;

                        EditData(rowIndex, passTextBox.Text, commTextBox.Text);
                        SaveData();
                    }
                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Проверяем, что клик производится в ячейке, а не в заголовке 
            if (e.RowIndex >= 0)
            {
                // Заполняем текстовые поля данными из выбранной ячейки 
                passTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                commTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
            }
        }

        private void DelButton_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;

                string pass = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                string comm = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();

                DialogResult result = MessageBox.Show($"Вы действительно хотите удалить запись:\nПароль: {pass}\nКомментарий: {comm}", "Подтверждение", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(rowIndex);
                    DeleteData(rowIndex);
                    SaveData();
                }
            }
        }

        private void SaveData()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("data");
            doc.AppendChild(root);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                XmlElement record = doc.CreateElement("record");
                root.AppendChild(record);

                XmlElement pass = doc.CreateElement("pass");
                pass.InnerText = row.Cells[0].Value?.ToString();
                record.AppendChild(pass);

                XmlElement comm = doc.CreateElement("comm");
                comm.InnerText = row.Cells[1].Value?.ToString();
                record.AppendChild(comm);
            }

            doc.Save(xmlFilePath);
        }

        private void EditData(int rowIndex, string pass, string comm)
        {
            if (File.Exists(xmlFilePath))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlFilePath);

                XmlNode node = doc.SelectSingleNode("data/record[position()=" + (rowIndex + 1) + "]");

                XmlNode passNode = node.SelectSingleNode("pass");
                passNode.InnerText = pass;

                XmlNode commNode = node.SelectSingleNode("comm");
                commNode.InnerText = comm;

                doc.Save(xmlFilePath);
            }
        }

        private void DeleteData(int rowIndex)
        {
            if (File.Exists(xmlFilePath))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlFilePath);

                XmlNode node = doc.SelectSingleNode("data/record[position()=" + (rowIndex + 1) + "]");
                node.ParentNode.RemoveChild(node);

                doc.Save(xmlFilePath);
            }
        }

        private void LoadXMLData()
        {
            if (File.Exists(xmlFilePath))
            {
                // Загружаем данные из файла data.xml без запроса пароля
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(xmlFilePath);
                    foreach (XmlNode node in doc.SelectNodes("data/record"))
                    {
                        string pass = node.SelectSingleNode("pass").InnerText;
                        string comm = node.SelectSingleNode("comm").InnerText;
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = pass;
                        dataGridView1.Rows[n].Cells[1].Value = comm;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PassMan_Load(object sender, EventArgs e)
        {
            LoadXMLData(); // загружаем данные из XML файла
        }
    }
}