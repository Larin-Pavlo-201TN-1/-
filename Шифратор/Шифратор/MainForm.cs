using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;

namespace Шифратор
{
    public partial class MainForm : Form
    {
        private string key = "1234567890123456";
        private string encrypt_text = "";
        private string selectedFilePath = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Width = 460;
        }

        private void encryption_btn_Click(object sender, EventArgs e)
        {
            byte[] encryptedText = Encrypt(message_txt.Text, key);

            this.Width = 900;
            this.StartPosition = FormStartPosition.CenterScreen;

            encrypt_message_txt.Text = Convert.ToBase64String(encryptedText);
        }

        private void decrypt_btn_Click(object sender, EventArgs e)
        {
            byte[] encryptedText = Convert.FromBase64String(encrypt_message_txt.Text);
            string decryptedText = Decrypt(encryptedText, key);
            encrypt_message_txt.Text = decryptedText;
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(receiver_txt.Text))
            {
                MessageBox.Show("Поле 'кому' не може бути пустим.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Форматування тексту з відступами
            string combinedText = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\nКому: {receiver_txt.Text}\n\n{message_txt.Text}\n-------------\n";
            byte[] encryptedText = Encrypt(combinedText, key);

            // Додавання зашифрованого тексту з роздільником
            encrypt_text += Convert.ToBase64String(encryptedText) + "\n";
        }

        private static byte[] Encrypt(string plaintext, string key)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(plaintext);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            IBufferedCipher cipher = new PaddedBufferedBlockCipher(new CbcBlockCipher(new TwofishEngine()));
            cipher.Init(true, new KeyParameter(keyBytes));

            return cipher.DoFinal(inputBytes);
        }

        private static string Decrypt(byte[] encrypted, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            IBufferedCipher cipher = new PaddedBufferedBlockCipher(new CbcBlockCipher(new TwofishEngine()));
            cipher.Init(false, new KeyParameter(keyBytes));

            byte[] decryptedBytes = cipher.DoFinal(encrypted);
            return Encoding.UTF8.GetString(decryptedBytes);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                default:
                    this.Width = 460;
                    break;
            }
        }

        private void encryption_txt_btn_Click(object sender, EventArgs e)
        {
            decryption_txt.Text = encrypt_text;
        }

        private void decryption_txt_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Розділяємо зашифровані повідомлення по символу нового рядка
                string[] encryptedMessages = encrypt_text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                StringBuilder decryptedMessages = new StringBuilder();

                foreach (string encryptedMessage in encryptedMessages)
                {
                    // Розшифровуємо кожне повідомлення окремо
                    byte[] encryptedText = Convert.FromBase64String(encryptedMessage);
                    string decryptedText = Decrypt(encryptedText, key);
                    decryptedMessages.AppendLine(decryptedText);
                }

                // Виводимо всі розшифровані повідомлення
                decryption_txt.Text = decryptedMessages.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Невірний формат Base-64: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void choose_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                label5.Text = selectedFilePath;
            }
        }

        private void choose_defile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                label6.Text = selectedFilePath;
            }
        }

        private void encryption_file_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedFilePath))
            {
                EncryptFile(selectedFilePath);
                MessageBox.Show("Файл зашифровано успішно!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void decryption_file_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedFilePath))
            {
                DecryptFile(selectedFilePath);
                MessageBox.Show("Файл розшифровано успішно!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EncryptFile(string filePath)
        {
            string plaintext = File.ReadAllText(filePath);
            byte[] encrypted = Encrypt(plaintext, key);
            File.WriteAllBytes(filePath, encrypted);
        }

        private void DecryptFile(string filePath)
        {
            byte[] encrypted = File.ReadAllBytes(filePath);
            string decrypted = Decrypt(encrypted, key);
            File.WriteAllText(filePath, decrypted);
        }
    }
}
