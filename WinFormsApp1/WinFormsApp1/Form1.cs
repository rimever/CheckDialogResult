using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new Form2())
            {
                var result = form.ShowDialog(this);
                MessageBox.Show(result.ToString());
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ShowMessageBoxResult(MessageBoxButtons.OK);
        }

        private static void ShowMessageBoxResult(MessageBoxButtons buttons)
        {
            var result = MessageBox.Show(buttons.ToString(), "", buttons);
            MessageBox.Show(result.ToString());
        }

        private void buttonYesNo_Click(object sender, EventArgs e)
        {
            ShowMessageBoxResult(MessageBoxButtons.YesNo);


        }

        private void buttonOkCancel_Click(object sender, EventArgs e)
        {
            ShowMessageBoxResult(MessageBoxButtons.OKCancel);
        }
    }
}
