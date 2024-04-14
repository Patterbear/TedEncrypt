﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TedEncrypt
{
    public partial class EncryptionScreen : Form
    {
        public EncryptionScreen()
        {
            InitializeComponent();

            // Prevent resizing
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            // Encrypts files
            new Cryptography().EncryptFiles();

            // Updates progress bar
            statusBar.PerformStep();

            // Enables 'finish' button
            encryptionDoneButton.Enabled = true;
        }

        private void encryptionDoneButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EncryptedScreen encryptedScreen = new EncryptedScreen();
            encryptedScreen.ShowDialog();
            this.Close();
        }
    }
}