using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstProjectOnMyOwn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Keep calm Thanos...", "MiMensaje", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                Environment.Exit(0);
        }
    }
}
