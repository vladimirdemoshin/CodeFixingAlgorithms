using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HemmingApp
{
    public partial class mainForm : Form
    {
        public static int globalK;
        public mainForm()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            String text = inputCodeTextBox.Text;
            int k = 2;
            String hammingCode = HammingCode.GetHammingCode(text,ref k);
            hammingCodeTextBox.Text = hammingCode;
            globalK = k;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            String hammingCode = brokenCodeTextBox.Text;
            int brokenBit = HammingCode.FindMistake(hammingCode,globalK);
            String message = "There is no incorrect bits";
            if(brokenBit != 0)
                 message = "Bit number " + brokenBit.ToString() + " is incorrect";
            MessageBox.Show(message);
        }
    }
}
