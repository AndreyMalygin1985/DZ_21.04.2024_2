using Microsoft.VisualBasic.ApplicationServices;
using System.Text.Json;
using System.Text;
using System.Xml.Serialization;

namespace DZ_21._04._2024_2
{
    public partial class Form1 : Form
    {
        private List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
            AddUserButton.Click += AddUserButton_Click;
            RemoveUserButton.Click += RemoveUserButton_Click;
            EditUserButton.Click += EditUserButton_Click;
            SaveUserButton.Click += SaveUserButton_Click;
            ExportToTextButton.Click += ExportToTextButton_Click;
            ImportFromTextButton.Click += ImportFromTextButton_Click;
            ExportToXmlButton.Click += ExportToXmlButton_Click;
            ImportFromXmlButton.Click += ImportFromXmlButton_Click;
            ExportToJsonButton.Click += ExportToJsonButton_Click;
            ImportFromJsonButton.Click += ImportFromJsonButton_Click;
            UpdateUserListBox();
        }
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string email = EmailTextBox.Text;
            string phone = PhoneTextBox.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            User user = new User(name, surname, email, phone);
            users.Add(user);
            UpdateUserListBox();
            ClearUserFields();
        }

        private void UpdateUserListBox()
        {
            UserListBox.Items.Clear();
            foreach (User user in users)
            {
                UserListBox.Items.Add(user);
            }
        }

        private void ClearUserFields()
        {
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            EmailTextBox.Clear();
            PhoneTextBox.Clear();
        }

        private void RemoveUserButton_Click(object sender, EventArgs e)
        {
            if (UserListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите пользователя для удаления.");
                return;
            }

            User selectedUser = (User)UserListBox.SelectedItem;
            users.Remove(selectedUser);
            UpdateUserListBox();
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            if (UserListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите пользователя для редактирования.");
                return;
            }

            User selectedUser = (User)UserListBox.SelectedItem;
            NameTextBox.Text = selectedUser.Name;
            SurnameTextBox.Text = selectedUser.Surname;
            EmailTextBox.Text = selectedUser.Email;
            PhoneTextBox.Text = selectedUser.Phone;
        }

        private void SaveUserButton_Click(object sender, EventArgs e)
        {
            if (UserListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите пользователя для редактирования.");
                return;
            }

            User selectedUser = (User)UserListBox.SelectedItem;
            selectedUser.Name = NameTextBox.Text;
            selectedUser.Surname = SurnameTextBox.Text;
            selectedUser.Email = EmailTextBox.Text;
            selectedUser.Phone = PhoneTextBox.Text;

            UpdateUserListBox();
            ClearUserFields();
        }

        private void ExportToTextButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToTextFile(filePath);
            }
        }

        private void ExportToTextFile(string filePath)
        {
            StringBuilder sb = new StringBuilder();
            foreach (User user in users)
            {
                sb.AppendLine($"{user.Name},{user.Surname},{user.Email},{user.Phone}");
            }

            File.WriteAllText(filePath, sb.ToString());
        }

        private void ImportFromTextButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ImportFromTextFile(filePath);
            }
        }

        private void ImportFromTextFile(string filePath)
        {
            users.Clear();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 4)
                {
                    User user = new User(parts[0], parts[1], parts[2], parts[3]);
                    users.Add(user);
                }
            }
            UpdateUserListBox();
        }

        private void ExportToXmlButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML файл (*.xml)|*.xml";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToXmlFile(filePath);
            }
        }

        private void ExportToXmlFile(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fileStream, users);
            }
        }

        private void ImportFromXmlButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML файл (*.xml)|*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ImportFromXmlFile(filePath);
            }
        }

        private void ImportFromXmlFile(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                users = (List<User>)serializer.Deserialize(fileStream);
            }
            UpdateUserListBox();
        }

        private void ExportToJsonButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON файл (*.json)|*.json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExportToJsonFile(filePath);
            }
        }

        private void ExportToJsonFile(string filePath)
        {
            string json = JsonSerializer.Serialize(users);
            File.WriteAllText(filePath, json);
        }

        private void ImportFromJsonButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON файл (*.json)|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                ImportFromJsonFile(filePath);
            }
        }

        private void ImportFromJsonFile(string filePath)
        {
            string json = File.ReadAllText(filePath);
            users = JsonSerializer.Deserialize<List<User>>(json);
            UpdateUserListBox();
        }
    }

    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public User()
        {
        }
        public User(string name, string surname, string email, string phone)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} ({Email}, {Phone})";
        }
    }
}

