namespace Шифратор
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.encryption_txt = new System.Windows.Forms.TabPage();
            this.decrypt_btn = new System.Windows.Forms.Button();
            this.send_btn = new System.Windows.Forms.Button();
            this.encryption_btn = new System.Windows.Forms.Button();
            this.Group_message_encryption = new System.Windows.Forms.Panel();
            this.encrypt_message_txt = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.receiver_txt = new System.Windows.Forms.TextBox();
            this.message_txt = new System.Windows.Forms.RichTextBox();
            this.decryption_group = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.decryption_txt = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.encryption_txt_btn = new System.Windows.Forms.Button();
            this.decryption_txt_btn = new System.Windows.Forms.Button();
            this.tab_file = new System.Windows.Forms.TabPage();
            this.coose_file = new System.Windows.Forms.Button();
            this.encryption_file_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.decryption_file_btn = new System.Windows.Forms.Button();
            this.choose_defile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.encryption_txt.SuspendLayout();
            this.Group_message_encryption.SuspendLayout();
            this.decryption_group.SuspendLayout();
            this.tab_file.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.encryption_txt);
            this.tabControl1.Controls.Add(this.decryption_group);
            this.tabControl1.Controls.Add(this.tab_file);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(452, 353);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // encryption_txt
            // 
            this.encryption_txt.Controls.Add(this.decrypt_btn);
            this.encryption_txt.Controls.Add(this.send_btn);
            this.encryption_txt.Controls.Add(this.encryption_btn);
            this.encryption_txt.Controls.Add(this.Group_message_encryption);
            this.encryption_txt.Controls.Add(this.label2);
            this.encryption_txt.Controls.Add(this.label1);
            this.encryption_txt.Controls.Add(this.receiver_txt);
            this.encryption_txt.Controls.Add(this.message_txt);
            this.encryption_txt.Location = new System.Drawing.Point(4, 25);
            this.encryption_txt.Name = "encryption_txt";
            this.encryption_txt.Padding = new System.Windows.Forms.Padding(3);
            this.encryption_txt.Size = new System.Drawing.Size(867, 324);
            this.encryption_txt.TabIndex = 0;
            this.encryption_txt.Text = "Шифрування тексту";
            this.encryption_txt.UseVisualStyleBackColor = true;
            // 
            // decrypt_btn
            // 
            this.decrypt_btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.decrypt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decrypt_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.decrypt_btn.Location = new System.Drawing.Point(713, 255);
            this.decrypt_btn.Name = "decrypt_btn";
            this.decrypt_btn.Size = new System.Drawing.Size(155, 37);
            this.decrypt_btn.TabIndex = 7;
            this.decrypt_btn.Text = "Розшифрувати";
            this.decrypt_btn.UseVisualStyleBackColor = false;
            this.decrypt_btn.Click += new System.EventHandler(this.decrypt_btn_Click);
            // 
            // send_btn
            // 
            this.send_btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.send_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.send_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.send_btn.Location = new System.Drawing.Point(173, 255);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(251, 37);
            this.send_btn.TabIndex = 7;
            this.send_btn.Text = "Зашифрувати та відправити";
            this.send_btn.UseVisualStyleBackColor = false;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // encryption_btn
            // 
            this.encryption_btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.encryption_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryption_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.encryption_btn.Location = new System.Drawing.Point(10, 255);
            this.encryption_btn.Name = "encryption_btn";
            this.encryption_btn.Size = new System.Drawing.Size(132, 37);
            this.encryption_btn.TabIndex = 6;
            this.encryption_btn.Text = "Зашифрувати";
            this.encryption_btn.UseVisualStyleBackColor = false;
            this.encryption_btn.Click += new System.EventHandler(this.encryption_btn_Click);
            // 
            // Group_message_encryption
            // 
            this.Group_message_encryption.Controls.Add(this.encrypt_message_txt);
            this.Group_message_encryption.Controls.Add(this.label3);
            this.Group_message_encryption.Location = new System.Drawing.Point(446, 37);
            this.Group_message_encryption.Name = "Group_message_encryption";
            this.Group_message_encryption.Size = new System.Drawing.Size(422, 207);
            this.Group_message_encryption.TabIndex = 5;
            // 
            // encrypt_message_txt
            // 
            this.encrypt_message_txt.Location = new System.Drawing.Point(3, 49);
            this.encrypt_message_txt.Name = "encrypt_message_txt";
            this.encrypt_message_txt.Size = new System.Drawing.Size(413, 150);
            this.encrypt_message_txt.TabIndex = 5;
            this.encrypt_message_txt.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Зашифроване повідомлення:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Повідомлення:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Кому:";
            // 
            // receiver_txt
            // 
            this.receiver_txt.Location = new System.Drawing.Point(67, 14);
            this.receiver_txt.Name = "receiver_txt";
            this.receiver_txt.Size = new System.Drawing.Size(133, 22);
            this.receiver_txt.TabIndex = 1;
            // 
            // message_txt
            // 
            this.message_txt.Location = new System.Drawing.Point(8, 85);
            this.message_txt.Name = "message_txt";
            this.message_txt.Size = new System.Drawing.Size(416, 150);
            this.message_txt.TabIndex = 0;
            this.message_txt.Text = "";
            // 
            // decryption_group
            // 
            this.decryption_group.Controls.Add(this.decryption_txt_btn);
            this.decryption_group.Controls.Add(this.encryption_txt_btn);
            this.decryption_group.Controls.Add(this.label4);
            this.decryption_group.Controls.Add(this.decryption_txt);
            this.decryption_group.Location = new System.Drawing.Point(4, 25);
            this.decryption_group.Name = "decryption_group";
            this.decryption_group.Padding = new System.Windows.Forms.Padding(3);
            this.decryption_group.Size = new System.Drawing.Size(444, 324);
            this.decryption_group.TabIndex = 1;
            this.decryption_group.Text = "Дешифрування тексту";
            this.decryption_group.UseVisualStyleBackColor = true;
            // 
            // decryption_txt
            // 
            this.decryption_txt.Location = new System.Drawing.Point(8, 41);
            this.decryption_txt.Name = "decryption_txt";
            this.decryption_txt.Size = new System.Drawing.Size(416, 218);
            this.decryption_txt.TabIndex = 1;
            this.decryption_txt.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Повідомлення";
            // 
            // encryption_txt_btn
            // 
            this.encryption_txt_btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.encryption_txt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryption_txt_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.encryption_txt_btn.Location = new System.Drawing.Point(8, 265);
            this.encryption_txt_btn.Name = "encryption_txt_btn";
            this.encryption_txt_btn.Size = new System.Drawing.Size(151, 46);
            this.encryption_txt_btn.TabIndex = 7;
            this.encryption_txt_btn.Text = "Зашифроване повідомлення";
            this.encryption_txt_btn.UseVisualStyleBackColor = false;
            this.encryption_txt_btn.Click += new System.EventHandler(this.encryption_txt_btn_Click);
            // 
            // decryption_txt_btn
            // 
            this.decryption_txt_btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.decryption_txt_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryption_txt_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.decryption_txt_btn.Location = new System.Drawing.Point(278, 265);
            this.decryption_txt_btn.Name = "decryption_txt_btn";
            this.decryption_txt_btn.Size = new System.Drawing.Size(146, 46);
            this.decryption_txt_btn.TabIndex = 8;
            this.decryption_txt_btn.Text = "Розшифрувати";
            this.decryption_txt_btn.UseVisualStyleBackColor = false;
            this.decryption_txt_btn.Click += new System.EventHandler(this.decryption_txt_btn_Click);
            // 
            // tab_file
            // 
            this.tab_file.Controls.Add(this.pictureBox2);
            this.tab_file.Controls.Add(this.pictureBox1);
            this.tab_file.Controls.Add(this.label6);
            this.tab_file.Controls.Add(this.decryption_file_btn);
            this.tab_file.Controls.Add(this.choose_defile);
            this.tab_file.Controls.Add(this.label5);
            this.tab_file.Controls.Add(this.encryption_file_btn);
            this.tab_file.Controls.Add(this.coose_file);
            this.tab_file.Location = new System.Drawing.Point(4, 25);
            this.tab_file.Name = "tab_file";
            this.tab_file.Padding = new System.Windows.Forms.Padding(3);
            this.tab_file.Size = new System.Drawing.Size(444, 324);
            this.tab_file.TabIndex = 2;
            this.tab_file.Text = "Шифрування файлу";
            this.tab_file.UseVisualStyleBackColor = true;
            // 
            // coose_file
            // 
            this.coose_file.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.coose_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coose_file.ForeColor = System.Drawing.SystemColors.Window;
            this.coose_file.Location = new System.Drawing.Point(12, 25);
            this.coose_file.Name = "coose_file";
            this.coose_file.Size = new System.Drawing.Size(151, 46);
            this.coose_file.TabIndex = 8;
            this.coose_file.Text = "Обрати файл для шифрування";
            this.coose_file.UseVisualStyleBackColor = false;
            this.coose_file.Click += new System.EventHandler(this.choose_file_Click);
            // 
            // encryption_file_btn
            // 
            this.encryption_file_btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.encryption_file_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encryption_file_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.encryption_file_btn.Location = new System.Drawing.Point(12, 143);
            this.encryption_file_btn.Name = "encryption_file_btn";
            this.encryption_file_btn.Size = new System.Drawing.Size(151, 46);
            this.encryption_file_btn.TabIndex = 9;
            this.encryption_file_btn.Text = "Зашифрувати файл";
            this.encryption_file_btn.UseVisualStyleBackColor = false;
            this.encryption_file_btn.Click += new System.EventHandler(this.encryption_file_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Обраний файл:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Обраний файл:";
            // 
            // decryption_file_btn
            // 
            this.decryption_file_btn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.decryption_file_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decryption_file_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.decryption_file_btn.Location = new System.Drawing.Point(12, 261);
            this.decryption_file_btn.Name = "decryption_file_btn";
            this.decryption_file_btn.Size = new System.Drawing.Size(151, 46);
            this.decryption_file_btn.TabIndex = 12;
            this.decryption_file_btn.Text = "Зашифрувати файл";
            this.decryption_file_btn.UseVisualStyleBackColor = false;
            this.decryption_file_btn.Click += new System.EventHandler(this.decryption_file_btn_Click);
            // 
            // choose_defile
            // 
            this.choose_defile.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.choose_defile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose_defile.ForeColor = System.Drawing.SystemColors.Window;
            this.choose_defile.Location = new System.Drawing.Point(244, 143);
            this.choose_defile.Name = "choose_defile";
            this.choose_defile.Size = new System.Drawing.Size(163, 46);
            this.choose_defile.TabIndex = 11;
            this.choose_defile.Text = "Обрати файл для дешифрування";
            this.choose_defile.UseVisualStyleBackColor = false;
            this.choose_defile.Click += new System.EventHandler(this.choose_defile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(325, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(325, 218);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(452, 353);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.encryption_txt.ResumeLayout(false);
            this.encryption_txt.PerformLayout();
            this.Group_message_encryption.ResumeLayout(false);
            this.Group_message_encryption.PerformLayout();
            this.decryption_group.ResumeLayout(false);
            this.decryption_group.PerformLayout();
            this.tab_file.ResumeLayout(false);
            this.tab_file.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage encryption_txt;
        private System.Windows.Forms.TabPage decryption_group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox receiver_txt;
        private System.Windows.Forms.RichTextBox message_txt;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel Group_message_encryption;
        private System.Windows.Forms.RichTextBox encrypt_message_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Button encryption_btn;
        private System.Windows.Forms.Button decrypt_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox decryption_txt;
        internal System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button decryption_txt_btn;
        private System.Windows.Forms.Button encryption_txt_btn;
        private System.Windows.Forms.TabPage tab_file;
        private System.Windows.Forms.Button encryption_file_btn;
        private System.Windows.Forms.Button coose_file;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button decryption_file_btn;
        private System.Windows.Forms.Button choose_defile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}