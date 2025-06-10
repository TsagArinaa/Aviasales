using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aviasales
{
    public partial class FormData : Form
    {
        string Name = string.Empty;

        public FormData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name = textBoxName.Text;
            this.Close();
        }
    }
}
