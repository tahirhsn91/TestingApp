using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string XULRunnerPath = Application.StartupPath + "\\xulrunner";
            if (Directory.Exists(XULRunnerPath))
                Skybound.Gecko.Xpcom.Initialize(XULRunnerPath);
            else
                MessageBox.Show("XULRunner Dll's are Missing");

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "http://www.Google.com";
            button3_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.GoForward();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (textBox1.Text.ToLower() == "http://www.")
            //    textBox1.Text = "http://www.";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.ToLower() == "http://www.")
                textBox1.Text = "http://www.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.Navigate(textBox1.Text);
        }
    }
}
