namespace DZ_21._04._2024_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameTextBox = new TextBox();
            SurnameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            AddUserButton = new Button();
            UserListBox = new ListBox();
            RemoveUserButton = new Button();
            EditUserButton = new Button();
            SaveUserButton = new Button();
            ExportToTextButton = new Button();
            ImportFromTextButton = new Button();
            ExportToXmlButton = new Button();
            ImportFromXmlButton = new Button();
            ExportToJsonButton = new Button();
            ImportFromJsonButton = new Button();
            labelName = new Label();
            labelSurname = new Label();
            labelEmail = new Label();
            labelPhone = new Label();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(10, 10);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(166, 23);
            NameTextBox.TabIndex = 0;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(182, 10);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(166, 23);
            SurnameTextBox.TabIndex = 1;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(354, 10);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(166, 23);
            EmailTextBox.TabIndex = 2;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(526, 10);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(166, 23);
            PhoneTextBox.TabIndex = 3;
            // 
            // AddUserButton
            // 
            AddUserButton.Location = new Point(706, 10);
            AddUserButton.Name = "AddUserButton";
            AddUserButton.Size = new Size(82, 23);
            AddUserButton.TabIndex = 4;
            AddUserButton.Text = "Добавить";
            AddUserButton.UseVisualStyleBackColor = true;
            // 
            // UserListBox
            // 
            UserListBox.FormattingEnabled = true;
            UserListBox.ItemHeight = 15;
            UserListBox.Location = new Point(10, 70);
            UserListBox.Name = "UserListBox";
            UserListBox.Size = new Size(682, 304);
            UserListBox.TabIndex = 5;
            // 
            // RemoveUserButton
            // 
            RemoveUserButton.Location = new Point(698, 192);
            RemoveUserButton.Name = "RemoveUserButton";
            RemoveUserButton.Size = new Size(100, 55);
            RemoveUserButton.TabIndex = 6;
            RemoveUserButton.Text = "Удалить";
            RemoveUserButton.UseVisualStyleBackColor = true;
            // 
            // EditUserButton
            // 
            EditUserButton.Location = new Point(698, 70);
            EditUserButton.Name = "EditUserButton";
            EditUserButton.Size = new Size(100, 55);
            EditUserButton.TabIndex = 7;
            EditUserButton.Text = "Редактировать";
            EditUserButton.UseVisualStyleBackColor = true;
            // 
            // SaveUserButton
            // 
            SaveUserButton.Location = new Point(698, 131);
            SaveUserButton.Name = "SaveUserButton";
            SaveUserButton.Size = new Size(100, 55);
            SaveUserButton.TabIndex = 8;
            SaveUserButton.Text = "Сохранить";
            SaveUserButton.UseVisualStyleBackColor = true;
            // 
            // ExportToTextButton
            // 
            ExportToTextButton.Location = new Point(177, 386);
            ExportToTextButton.Name = "ExportToTextButton";
            ExportToTextButton.Size = new Size(117, 23);
            ExportToTextButton.TabIndex = 9;
            ExportToTextButton.Text = "Экспорт в Txt";
            ExportToTextButton.UseVisualStyleBackColor = true;
            // 
            // ImportFromTextButton
            // 
            ImportFromTextButton.Location = new Point(177, 415);
            ImportFromTextButton.Name = "ImportFromTextButton";
            ImportFromTextButton.Size = new Size(117, 23);
            ImportFromTextButton.TabIndex = 10;
            ImportFromTextButton.Text = "Импорт из Txt";
            ImportFromTextButton.UseVisualStyleBackColor = true;
            // 
            // ExportToXmlButton
            // 
            ExportToXmlButton.Location = new Point(300, 386);
            ExportToXmlButton.Name = "ExportToXmlButton";
            ExportToXmlButton.Size = new Size(117, 23);
            ExportToXmlButton.TabIndex = 11;
            ExportToXmlButton.Text = "Экспорт в Xml";
            ExportToXmlButton.UseVisualStyleBackColor = true;
            // 
            // ImportFromXmlButton
            // 
            ImportFromXmlButton.Location = new Point(302, 415);
            ImportFromXmlButton.Name = "ImportFromXmlButton";
            ImportFromXmlButton.Size = new Size(115, 23);
            ImportFromXmlButton.TabIndex = 12;
            ImportFromXmlButton.Text = "Импорт из Xml";
            ImportFromXmlButton.UseVisualStyleBackColor = true;
            // 
            // ExportToJsonButton
            // 
            ExportToJsonButton.Location = new Point(423, 386);
            ExportToJsonButton.Name = "ExportToJsonButton";
            ExportToJsonButton.Size = new Size(115, 23);
            ExportToJsonButton.TabIndex = 13;
            ExportToJsonButton.Text = "Экспорт в Json";
            ExportToJsonButton.UseVisualStyleBackColor = true;
            // 
            // ImportFromJsonButton
            // 
            ImportFromJsonButton.Location = new Point(423, 415);
            ImportFromJsonButton.Name = "ImportFromJsonButton";
            ImportFromJsonButton.Size = new Size(115, 23);
            ImportFromJsonButton.TabIndex = 14;
            ImportFromJsonButton.Text = "Импорт из Json";
            ImportFromJsonButton.UseVisualStyleBackColor = true;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(13, 40);
            labelName.Name = "labelName";
            labelName.Size = new Size(31, 15);
            labelName.TabIndex = 15;
            labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(182, 40);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(58, 15);
            labelSurname.TabIndex = 16;
            labelSurname.Text = "Фамилия";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(354, 40);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(113, 15);
            labelEmail.TabIndex = 17;
            labelEmail.Text = "Электронная почта";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(526, 40);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(101, 15);
            labelPhone.TabIndex = 18;
            labelPhone.Text = "Номер телефона";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPhone);
            Controls.Add(labelEmail);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Controls.Add(ImportFromJsonButton);
            Controls.Add(ExportToJsonButton);
            Controls.Add(ImportFromXmlButton);
            Controls.Add(ExportToXmlButton);
            Controls.Add(ImportFromTextButton);
            Controls.Add(ExportToTextButton);
            Controls.Add(SaveUserButton);
            Controls.Add(EditUserButton);
            Controls.Add(RemoveUserButton);
            Controls.Add(UserListBox);
            Controls.Add(AddUserButton);
            Controls.Add(PhoneTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(SurnameTextBox);
            Controls.Add(NameTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTextBox;
        private TextBox SurnameTextBox;
        private TextBox EmailTextBox;
        private TextBox PhoneTextBox;
        private Button AddUserButton;
        private ListBox UserListBox;
        private Button RemoveUserButton;
        private Button EditUserButton;
        private Button SaveUserButton;
        private Button ExportToTextButton;
        private Button ImportFromTextButton;
        private Button ExportToXmlButton;
        private Button ImportFromXmlButton;
        private Button ExportToJsonButton;
        private Button ImportFromJsonButton;
        private Label labelName;
        private Label labelSurname;
        private Label labelEmail;
        private Label labelPhone;
    }
}
