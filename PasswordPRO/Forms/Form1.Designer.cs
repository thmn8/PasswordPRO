namespace PasswordPRO
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PassText1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PassManMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PassStrenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HomePageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PassText2 = new System.Windows.Forms.TextBox();
            this.PassText3 = new System.Windows.Forms.TextBox();
            this.PassText4 = new System.Windows.Forms.TextBox();
            this.PassText5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PassText6 = new System.Windows.Forms.TextBox();
            this.ClipboardButton = new System.Windows.Forms.Button();
            this.GenerButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.GroupBox();
            this.NonecharsSheckBox = new System.Windows.Forms.CheckBox();
            this.OtherSymbolsTextBox = new System.Windows.Forms.TextBox();
            this.SettingRadio = new System.Windows.Forms.RadioButton();
            this.SymbolsCheckBox = new System.Windows.Forms.CheckBox();
            this.NumCheckBox = new System.Windows.Forms.CheckBox();
            this.OtherSettingsRadio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpperCaseLatincheckBox = new System.Windows.Forms.CheckBox();
            this.LowerCaseLatincheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UpperCaseCyrilliccheckBox = new System.Windows.Forms.CheckBox();
            this.LowerCaseCyrillicCheckBox = new System.Windows.Forms.CheckBox();
            this.lengthPass = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.settings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthPass)).BeginInit();
            this.SuspendLayout();
            // 
            // PassText1
            // 
            this.PassText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassText1.ForeColor = System.Drawing.Color.Red;
            this.PassText1.Location = new System.Drawing.Point(6, 21);
            this.PassText1.Name = "PassText1";
            this.PassText1.Size = new System.Drawing.Size(338, 30);
            this.PassText1.TabIndex = 0;
            this.PassText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassText1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PassText1_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.ToolsMenu,
            this.HelpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(741, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(59, 24);
            this.FileMenu.Text = "Файл";
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(136, 26);
            this.ExitMenu.Text = "Выход";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PassManMenu,
            this.PassStrenMenuItem});
            this.ToolsMenu.Name = "ToolsMenu";
            this.ToolsMenu.Size = new System.Drawing.Size(117, 24);
            this.ToolsMenu.Text = "Инструменты";
            // 
            // PassManMenu
            // 
            this.PassManMenu.Name = "PassManMenu";
            this.PassManMenu.Size = new System.Drawing.Size(232, 26);
            this.PassManMenu.Text = "Менеджер паролей";
            this.PassManMenu.Click += new System.EventHandler(this.PassManMenu_Click);
            // 
            // PassStrenMenuItem
            // 
            this.PassStrenMenuItem.Name = "PassStrenMenuItem";
            this.PassStrenMenuItem.Size = new System.Drawing.Size(232, 26);
            this.PassStrenMenuItem.Text = "Надежность пароля";
            this.PassStrenMenuItem.Click += new System.EventHandler(this.PassStrenMenuItem_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomePageMenu,
            this.toolStripSeparator1,
            this.AboutMenu});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(83, 24);
            this.HelpMenu.Text = "Помощь";
            // 
            // HomePageMenu
            // 
            this.HomePageMenu.Name = "HomePageMenu";
            this.HomePageMenu.Size = new System.Drawing.Size(236, 26);
            this.HomePageMenu.Text = "Домашняя страница";
            this.HomePageMenu.Click += new System.EventHandler(this.HomePageMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(236, 26);
            this.AboutMenu.Text = "О программе...";
            this.AboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // PassText2
            // 
            this.PassText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassText2.ForeColor = System.Drawing.Color.Red;
            this.PassText2.Location = new System.Drawing.Point(6, 57);
            this.PassText2.Name = "PassText2";
            this.PassText2.Size = new System.Drawing.Size(338, 30);
            this.PassText2.TabIndex = 2;
            this.PassText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassText2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PassText2_MouseClick);
            // 
            // PassText3
            // 
            this.PassText3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassText3.ForeColor = System.Drawing.Color.Red;
            this.PassText3.Location = new System.Drawing.Point(6, 93);
            this.PassText3.Name = "PassText3";
            this.PassText3.Size = new System.Drawing.Size(338, 30);
            this.PassText3.TabIndex = 3;
            this.PassText3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassText3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PassText3_MouseClick);
            // 
            // PassText4
            // 
            this.PassText4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassText4.ForeColor = System.Drawing.Color.Red;
            this.PassText4.Location = new System.Drawing.Point(6, 165);
            this.PassText4.Name = "PassText4";
            this.PassText4.Size = new System.Drawing.Size(338, 30);
            this.PassText4.TabIndex = 4;
            this.PassText4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassText4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PassText4_MouseClick);
            // 
            // PassText5
            // 
            this.PassText5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassText5.ForeColor = System.Drawing.Color.Red;
            this.PassText5.Location = new System.Drawing.Point(6, 129);
            this.PassText5.Name = "PassText5";
            this.PassText5.Size = new System.Drawing.Size(338, 30);
            this.PassText5.TabIndex = 5;
            this.PassText5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassText5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PassText5_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PassText6);
            this.groupBox1.Controls.Add(this.PassText1);
            this.groupBox1.Controls.Add(this.PassText5);
            this.groupBox1.Controls.Add(this.PassText2);
            this.groupBox1.Controls.Add(this.PassText4);
            this.groupBox1.Controls.Add(this.PassText3);
            this.groupBox1.Location = new System.Drawing.Point(13, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 244);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список паролей";
            // 
            // PassText6
            // 
            this.PassText6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassText6.ForeColor = System.Drawing.Color.Red;
            this.PassText6.Location = new System.Drawing.Point(6, 201);
            this.PassText6.Name = "PassText6";
            this.PassText6.Size = new System.Drawing.Size(338, 30);
            this.PassText6.TabIndex = 7;
            this.PassText6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassText6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PassText6_MouseClick);
            // 
            // ClipboardButton
            // 
            this.ClipboardButton.Location = new System.Drawing.Point(19, 357);
            this.ClipboardButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClipboardButton.Name = "ClipboardButton";
            this.ClipboardButton.Size = new System.Drawing.Size(151, 28);
            this.ClipboardButton.TabIndex = 23;
            this.ClipboardButton.Text = "Очистить буфер";
            this.ClipboardButton.UseVisualStyleBackColor = true;
            // 
            // GenerButton
            // 
            this.GenerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenerButton.Location = new System.Drawing.Point(176, 301);
            this.GenerButton.Margin = new System.Windows.Forms.Padding(4);
            this.GenerButton.Name = "GenerButton";
            this.GenerButton.Size = new System.Drawing.Size(181, 65);
            this.GenerButton.TabIndex = 19;
            this.GenerButton.Text = "Сгенерировать";
            this.GenerButton.UseVisualStyleBackColor = true;
            this.GenerButton.Click += new System.EventHandler(this.GenerButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(19, 283);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(151, 28);
            this.ClearButton.TabIndex = 21;
            this.ClearButton.Text = "Очистить поля";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(19, 320);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(151, 28);
            this.SaveButton.TabIndex = 22;
            this.SaveButton.Text = "Сохранить пароли";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // settings
            // 
            this.settings.Controls.Add(this.NonecharsSheckBox);
            this.settings.Controls.Add(this.OtherSymbolsTextBox);
            this.settings.Controls.Add(this.SettingRadio);
            this.settings.Controls.Add(this.SymbolsCheckBox);
            this.settings.Controls.Add(this.NumCheckBox);
            this.settings.Controls.Add(this.OtherSettingsRadio);
            this.settings.Controls.Add(this.groupBox2);
            this.settings.Controls.Add(this.groupBox3);
            this.settings.Controls.Add(this.lengthPass);
            this.settings.Controls.Add(this.label1);
            this.settings.Location = new System.Drawing.Point(368, 32);
            this.settings.Margin = new System.Windows.Forms.Padding(4);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(4);
            this.settings.Size = new System.Drawing.Size(359, 369);
            this.settings.TabIndex = 25;
            this.settings.TabStop = false;
            this.settings.Text = "Настройки";
            // 
            // NonecharsSheckBox
            // 
            this.NonecharsSheckBox.AutoSize = true;
            this.NonecharsSheckBox.Checked = true;
            this.NonecharsSheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NonecharsSheckBox.Location = new System.Drawing.Point(17, 157);
            this.NonecharsSheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.NonecharsSheckBox.Name = "NonecharsSheckBox";
            this.NonecharsSheckBox.Size = new System.Drawing.Size(320, 20);
            this.NonecharsSheckBox.TabIndex = 16;
            this.NonecharsSheckBox.Text = "Исключить неоднозначные символы: il1Lo0O";
            this.NonecharsSheckBox.UseVisualStyleBackColor = true;
            // 
            // OtherSymbolsTextBox
            // 
            this.OtherSymbolsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtherSymbolsTextBox.ForeColor = System.Drawing.Color.Red;
            this.OtherSymbolsTextBox.Location = new System.Drawing.Point(8, 321);
            this.OtherSymbolsTextBox.Name = "OtherSymbolsTextBox";
            this.OtherSymbolsTextBox.Size = new System.Drawing.Size(338, 30);
            this.OtherSymbolsTextBox.TabIndex = 15;
            this.OtherSymbolsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OtherSymbolsTextBox.Click += new System.EventHandler(this.OtherSymbolsTextBox_Click);
            // 
            // SettingRadio
            // 
            this.SettingRadio.AutoSize = true;
            this.SettingRadio.Checked = true;
            this.SettingRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingRadio.Location = new System.Drawing.Point(17, 72);
            this.SettingRadio.Margin = new System.Windows.Forms.Padding(4);
            this.SettingRadio.Name = "SettingRadio";
            this.SettingRadio.Size = new System.Drawing.Size(167, 22);
            this.SettingRadio.TabIndex = 12;
            this.SettingRadio.TabStop = true;
            this.SettingRadio.Text = "Параметры пароля:";
            this.SettingRadio.UseVisualStyleBackColor = true;
            // 
            // SymbolsCheckBox
            // 
            this.SymbolsCheckBox.AutoSize = true;
            this.SymbolsCheckBox.Checked = true;
            this.SymbolsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SymbolsCheckBox.Location = new System.Drawing.Point(17, 129);
            this.SymbolsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.SymbolsCheckBox.Name = "SymbolsCheckBox";
            this.SymbolsCheckBox.Size = new System.Drawing.Size(143, 20);
            this.SymbolsCheckBox.TabIndex = 9;
            this.SymbolsCheckBox.Text = "Символы: !#$%^&*()";
            this.SymbolsCheckBox.UseVisualStyleBackColor = true;
            // 
            // NumCheckBox
            // 
            this.NumCheckBox.AutoSize = true;
            this.NumCheckBox.Checked = true;
            this.NumCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NumCheckBox.Location = new System.Drawing.Point(17, 101);
            this.NumCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.NumCheckBox.Name = "NumCheckBox";
            this.NumCheckBox.Size = new System.Drawing.Size(69, 20);
            this.NumCheckBox.TabIndex = 8;
            this.NumCheckBox.Text = "Числа";
            this.NumCheckBox.UseVisualStyleBackColor = true;
            // 
            // OtherSettingsRadio
            // 
            this.OtherSettingsRadio.AutoSize = true;
            this.OtherSettingsRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtherSettingsRadio.Location = new System.Drawing.Point(8, 294);
            this.OtherSettingsRadio.Margin = new System.Windows.Forms.Padding(4);
            this.OtherSettingsRadio.Name = "OtherSettingsRadio";
            this.OtherSettingsRadio.Size = new System.Drawing.Size(272, 22);
            this.OtherSettingsRadio.TabIndex = 13;
            this.OtherSettingsRadio.TabStop = true;
            this.OtherSettingsRadio.Text = "Задать свои символы для пароля:";
            this.OtherSettingsRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UpperCaseLatincheckBox);
            this.groupBox2.Controls.Add(this.LowerCaseLatincheckBox);
            this.groupBox2.Location = new System.Drawing.Point(8, 189);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(157, 90);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Латиница";
            // 
            // UpperCaseLatincheckBox
            // 
            this.UpperCaseLatincheckBox.AutoSize = true;
            this.UpperCaseLatincheckBox.Checked = true;
            this.UpperCaseLatincheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UpperCaseLatincheckBox.Location = new System.Drawing.Point(9, 53);
            this.UpperCaseLatincheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.UpperCaseLatincheckBox.Name = "UpperCaseLatincheckBox";
            this.UpperCaseLatincheckBox.Size = new System.Drawing.Size(138, 20);
            this.UpperCaseLatincheckBox.TabIndex = 1;
            this.UpperCaseLatincheckBox.Text = "верхний регистр";
            this.UpperCaseLatincheckBox.UseVisualStyleBackColor = true;
            // 
            // LowerCaseLatincheckBox
            // 
            this.LowerCaseLatincheckBox.AutoSize = true;
            this.LowerCaseLatincheckBox.Checked = true;
            this.LowerCaseLatincheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LowerCaseLatincheckBox.Location = new System.Drawing.Point(9, 25);
            this.LowerCaseLatincheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.LowerCaseLatincheckBox.Name = "LowerCaseLatincheckBox";
            this.LowerCaseLatincheckBox.Size = new System.Drawing.Size(133, 20);
            this.LowerCaseLatincheckBox.TabIndex = 0;
            this.LowerCaseLatincheckBox.Text = "нижний регистр";
            this.LowerCaseLatincheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UpperCaseCyrilliccheckBox);
            this.groupBox3.Controls.Add(this.LowerCaseCyrillicCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(186, 189);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(160, 90);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Кириллица";
            // 
            // UpperCaseCyrilliccheckBox
            // 
            this.UpperCaseCyrilliccheckBox.AutoSize = true;
            this.UpperCaseCyrilliccheckBox.Location = new System.Drawing.Point(9, 53);
            this.UpperCaseCyrilliccheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.UpperCaseCyrilliccheckBox.Name = "UpperCaseCyrilliccheckBox";
            this.UpperCaseCyrilliccheckBox.Size = new System.Drawing.Size(138, 20);
            this.UpperCaseCyrilliccheckBox.TabIndex = 1;
            this.UpperCaseCyrilliccheckBox.Text = "верхний регистр";
            this.UpperCaseCyrilliccheckBox.UseVisualStyleBackColor = true;
            // 
            // LowerCaseCyrillicCheckBox
            // 
            this.LowerCaseCyrillicCheckBox.AutoSize = true;
            this.LowerCaseCyrillicCheckBox.Location = new System.Drawing.Point(9, 25);
            this.LowerCaseCyrillicCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.LowerCaseCyrillicCheckBox.Name = "LowerCaseCyrillicCheckBox";
            this.LowerCaseCyrillicCheckBox.Size = new System.Drawing.Size(133, 20);
            this.LowerCaseCyrillicCheckBox.TabIndex = 0;
            this.LowerCaseCyrillicCheckBox.Text = "нижний регистр";
            this.LowerCaseCyrillicCheckBox.UseVisualStyleBackColor = true;
            // 
            // lengthPass
            // 
            this.lengthPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lengthPass.ForeColor = System.Drawing.Color.Red;
            this.lengthPass.Location = new System.Drawing.Point(8, 37);
            this.lengthPass.Margin = new System.Windows.Forms.Padding(4);
            this.lengthPass.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.lengthPass.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.lengthPass.Name = "lengthPass";
            this.lengthPass.Size = new System.Drawing.Size(129, 27);
            this.lengthPass.TabIndex = 6;
            this.lengthPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lengthPass.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "длина пароля до 50 символов";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 412);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(741, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 26;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 434);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.ClipboardButton);
            this.Controls.Add(this.GenerButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(759, 476);
            this.MinimumSize = new System.Drawing.Size(759, 476);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordPRO";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lengthPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PassText1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.TextBox PassText2;
        private System.Windows.Forms.TextBox PassText3;
        private System.Windows.Forms.TextBox PassText4;
        private System.Windows.Forms.TextBox PassText5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PassText6;
        private System.Windows.Forms.Button ClipboardButton;
        private System.Windows.Forms.Button GenerButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox settings;
        private System.Windows.Forms.RadioButton SettingRadio;
        private System.Windows.Forms.CheckBox SymbolsCheckBox;
        private System.Windows.Forms.CheckBox NumCheckBox;
        private System.Windows.Forms.RadioButton OtherSettingsRadio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox UpperCaseLatincheckBox;
        private System.Windows.Forms.CheckBox LowerCaseLatincheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox UpperCaseCyrilliccheckBox;
        private System.Windows.Forms.CheckBox LowerCaseCyrillicCheckBox;
        private System.Windows.Forms.NumericUpDown lengthPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OtherSymbolsTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.ToolStripMenuItem HomePageMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenu;
        private System.Windows.Forms.ToolStripMenuItem PassManMenu;
        private System.Windows.Forms.CheckBox NonecharsSheckBox;
        private System.Windows.Forms.ToolStripMenuItem PassStrenMenuItem;
    }
}

