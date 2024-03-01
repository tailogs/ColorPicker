using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            textBoxMax.Select(0, 0);
        }

        // Публичный метод, который меняет тему на светлую
        // Public method changing the theme to light
        public void setWhite()
        {
            textBoxMax.BackColor = Color.White;
            textBoxMax.ForeColor = SystemColors.Desktop;
        }
    }
}
