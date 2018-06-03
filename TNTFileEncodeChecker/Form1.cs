using System;
using System.Drawing;
using System.Windows.Forms;
using TNTFileEncodeChecker.Properties;

namespace TNTFileEncodeChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedfile = openFileDialog1.FileName;

                lblSelectedFile.Text = selectedfile;
                lblSelectedFile.Visible = true;
                lblSelectedFile.ForeColor = Color.Red;
                btncheck.Visible = true;
                btnSelectFile.Visible = false;
                lblsel.Visible = true;
                btncancel.Visible = true;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            lblSelectedFile.Visible = false;
            btncheck.Visible = false;
            btnSelectFile.Visible = true;
            lblsel.Visible = false;
            btncancel.Visible = false;
        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            EncodingCheck enc = new EncodingCheck();
            string winencoding = enc.GetEncoding(lblSelectedFile.Text).WindowsCodePage.ToString();
            string ianaencoding = enc.GetEncoding(lblSelectedFile.Text).WebName.ToString();
            string humanencoding = enc.GetEncoding(lblSelectedFile.Text).EncodingName.ToString();
            string encoding = enc.GetEncoding(lblSelectedFile.Text).CodePage.ToString();
            lblencoding.Text = "Windows Encoding that Matches File"+ winencoding + Environment.NewLine + "Encoding Web Name " +ianaencoding + Environment.NewLine + "Human Readable Name " + humanencoding + Environment.NewLine + "Encoding Page Type" +encoding; 
            lblencoding.Visible = true;
            btnreset.Visible = true;
            btncancel.Visible = false;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            lblSelectedFile.Visible = false;
            btncheck.Visible = false;
            btnSelectFile.Visible = true;
            lblsel.Visible = false;
            btncancel.Visible = false;
            btnreset.Visible = false;
            lblencoding.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void tNTEncodingCheckerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Just needed a tool to validate the encryption that some of our output files have in response to a customer complaint. GO TROLL!!", "TNT .NET Baby", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void seriouslyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you need help with this, I suggest seeing a professional", "Life Advice for free!", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
