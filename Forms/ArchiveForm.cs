﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projektPKIK.Classes;

namespace projektPKIK.Forms
{
    public partial class ArchiveForm : Form
    {
        MainController compressionController;
        public ArchiveForm()
        {
            InitializeComponent();
            initCombobox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ValidateNames = false;
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = true;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                inputPath.Text = ofd.FileName; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ValidateNames = false;
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                outputPath.Text = ofd.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string compressionType = comboBox1.SelectedItem.ToString();
            switch (compressionType)
            {
                case "Zip":
                    compressionController = new MainController(new ZipHandler());
                    break;
                case "BZip2":
                    compressionController = new MainController(new BZip2Handler());
                    break;
                case "GZip":
                    compressionController = new MainController(new GZipHandler());
                    break;
                default:
                    compressionController = new MainController(new ZipHandler());
                    break;
            }
            if (!(inputPath.Text == "") && !(outputPath.Text == ""))
            {
                if (PasswordController.checkIfUserPasswordAreEqual(password1.Text, password2.Text))
                {
                    try
                    {
                        compressionController.CreateEncryptedArchive(inputPath.Text, outputPath.Text, password1.Text);
                        MessageBox.Show("Tworzenie archiwum powiodło się");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Hasła różnią się od siebie");
                }
            }
            
        }
        private void initCombobox()
        {
            comboBox1.Items.Add("Zip");
            comboBox1.Items.Add("BZip2");
            comboBox1.Items.Add("GZip");
        }

        private void ArchiveForm_Load(object sender, EventArgs e)
        {

        }
    }
}
