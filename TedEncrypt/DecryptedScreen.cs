﻿using System;
using System.IO;
using System.Windows.Forms;

namespace TedEncrypt
{
    public partial class DecryptedScreen : Form
    {
        public DecryptedScreen()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            // Checks for key before attempting decryption
            if (File.Exists(Directory.GetCurrentDirectory() + "\\key"))
            {
                this.Hide();
                EncryptionScreen encryptionScreen = new EncryptionScreen();
                encryptionScreen.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please put the key into the directory.", "Key not found");
            }
        }
    }
}
