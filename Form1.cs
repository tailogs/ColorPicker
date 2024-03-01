using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        bool startAndStop = true; // Флаг для записи и остановки записи

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Раз в секунду будет выводиться такой текст (с текущим временем) 
            textBoxCoordinateX.Text = Cursor.Position.X.ToString();
            textBoxCoordinateY.Text = Cursor.Position.Y.ToString();

            // Получаем скриншот рабочего стола
            Bitmap screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics graphics = Graphics.FromImage(screenshot))
            {
                graphics.CopyFromScreen(0, 0, 0, 0, screenshot.Size);
            }

            // Получаем цвет пикселя по координатам мыши
            Color pixelColor = screenshot.GetPixel(Cursor.Position.X, Cursor.Position.Y);

            // Задаем фону панели полученный цвет пикселя
            panelColor.BackColor = pixelColor;
            textBoxColorRGB.Text = "(" + pixelColor.R.ToString() + ", " + pixelColor.G.ToString() + ", " + pixelColor.B.ToString() + ")";
            textBoxColorHEX.Text = ColorTranslator.ToHtml(pixelColor);
        }

        private void светлаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = Color.White;
            lblCoordinateX.ForeColor = SystemColors.Desktop;
            lblCoordinateY.ForeColor = SystemColors.Desktop;
            lblColorRGB.ForeColor = SystemColors.Desktop;
            lblColorHEX.ForeColor = SystemColors.Desktop;
            menuStrip1.BackColor = Color.White;
            темаToolStripMenuItem.BackColor = Color.White;
            темаToolStripMenuItem.ForeColor = SystemColors.Desktop;
            темнаяToolStripMenuItem.BackColor = Color.White;
            темнаяToolStripMenuItem.ForeColor = SystemColors.Desktop;
            светлаяToolStripMenuItem.BackColor = Color.White;
            светлаяToolStripMenuItem.ForeColor = SystemColors.Desktop;
            выходToolStripMenuItem.BackColor = Color.White;
            выходToolStripMenuItem.ForeColor = SystemColors.Desktop;
            справкаToolStripMenuItem.BackColor = Color.White;
            справкаToolStripMenuItem.ForeColor = SystemColors.Desktop;
            panelColor.BackColor = Color.White;
            btnStartAndStop.BackColor = Color.SlateBlue;
            btnStartAndStop.ForeColor = Color.White;
            textBoxColorHEX.BackColor = Color.White;
            textBoxColorHEX.ForeColor = SystemColors.Desktop;
            textBoxColorRGB.BackColor = Color.White;
            textBoxColorRGB.ForeColor = SystemColors.Desktop;
            textBoxCoordinateX.BackColor = Color.White;
            textBoxCoordinateX.ForeColor = SystemColors.Desktop;
            textBoxCoordinateY.BackColor = Color.White;
            textBoxCoordinateY.ForeColor = SystemColors.Desktop;
            btnCoordinateX.BackColor = SystemColors.Control;
            btnCoordinateX.ForeColor = SystemColors.Desktop;
            btnCoordinateY.BackColor = SystemColors.Control;
            btnCoordinateY.ForeColor= SystemColors.Desktop;
            btnColorRGB.BackColor = SystemColors.Control;
            btnColorRGB.ForeColor = SystemColors.Desktop;
            btnColorHEX.BackColor = SystemColors.Control;
            btnColorHEX.ForeColor = SystemColors.Desktop;
        }

        private void темнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.Desktop;
            lblCoordinateX.ForeColor = SystemColors.Control;
            lblCoordinateY.ForeColor = SystemColors.Control;
            lblColorRGB.ForeColor = SystemColors.Control;
            lblColorHEX.ForeColor = SystemColors.Control;
            menuStrip1.BackColor = SystemColors.Desktop;
            темаToolStripMenuItem.BackColor = SystemColors.Desktop;
            темаToolStripMenuItem.ForeColor = SystemColors.Control;
            темнаяToolStripMenuItem.BackColor = SystemColors.Desktop;
            темнаяToolStripMenuItem.ForeColor = SystemColors.Control;
            светлаяToolStripMenuItem.BackColor = SystemColors.Desktop;
            светлаяToolStripMenuItem.ForeColor = SystemColors.Control;
            выходToolStripMenuItem.BackColor = SystemColors.Desktop;
            выходToolStripMenuItem.ForeColor = SystemColors.Control;
            справкаToolStripMenuItem.BackColor = SystemColors.Desktop;
            справкаToolStripMenuItem.ForeColor = SystemColors.Control;
            panelColor.BackColor = SystemColors.Desktop;
            btnStartAndStop.BackColor = Color.DarkOrchid;
            btnStartAndStop.ForeColor = SystemColors.Control;
            textBoxColorHEX.BackColor = SystemColors.Desktop;
            textBoxColorHEX.ForeColor = SystemColors.Control;
            textBoxColorRGB.BackColor = SystemColors.Desktop;
            textBoxColorRGB.ForeColor = SystemColors.Control;
            textBoxCoordinateX.BackColor = SystemColors.Desktop;
            textBoxCoordinateX.ForeColor = SystemColors.Control;
            textBoxCoordinateY.BackColor = SystemColors.Desktop;
            textBoxCoordinateY.ForeColor = SystemColors.Control;
            btnCoordinateX.BackColor = SystemColors.ControlDarkDark;
            btnCoordinateX.ForeColor = SystemColors.Control;
            btnCoordinateY.BackColor = SystemColors.ControlDarkDark;
            btnCoordinateY.ForeColor= SystemColors.Control;
            btnColorRGB.BackColor = SystemColors.ControlDarkDark;
            btnColorRGB.ForeColor = SystemColors.Control;
            btnColorHEX.BackColor = SystemColors.ControlDarkDark;
            btnColorHEX.ForeColor = SystemColors.Control;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStartAndStop_Click(object sender, EventArgs e)
        {
            if (startAndStop == true)
            {
                timer1.Enabled = true;
                timer1.Start();
                btnStartAndStop.Text = "Start scanning flowers";
                startAndStop = false;
            }
            else
            {
                timer1.Stop();
                timer1.Enabled = false;
                btnStartAndStop.Text = "Stop scanning flowers";
                startAndStop = true;
            }
        }

        private void Form1_FormClosing(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e) { }

        private void Form1_KeyDown(object sender, KeyEventArgs e) { }

        private void panelColor_Click(object sender, EventArgs e)
        {
            // Display dialog window select color
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get selecter user color
                Color selectedColor = colorDialog1.Color;

                // Set selected color background panel
                panelColor.BackColor = selectedColor;

                textBoxCoordinateX.Text = "";
                textBoxCoordinateY.Text = "";
                textBoxColorRGB.Text = "(" + selectedColor.R.ToString() + ", " + selectedColor.G.ToString() + ", " + selectedColor.B.ToString() + ")";
                textBoxColorHEX.Text = ColorTranslator.ToHtml(selectedColor);
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help_ = new Help();
            // If program = white
            if (BackColor != SystemColors.Desktop)
                help_.setWhite();
            // Open default theme - Black
            help_.ShowDialog();
        }

        private void btnCoordinateX_Click(object sender, EventArgs e)
        {
            btnCoordinateX.BackColor = Color.FromArgb(192, 0, 192);
            btnCoordinateX.ForeColor = Color.Black;
            if (textBoxCoordinateX.Text != "")
                Clipboard.SetText(textBoxCoordinateX.Text);
        }

        private void btnCoordinateY_Click(object sender, EventArgs e)
        {
            btnCoordinateY.BackColor = Color.FromArgb(192, 0, 192);
            btnCoordinateY.ForeColor = Color.Black;
            if (textBoxCoordinateY.Text != "")
                Clipboard.SetText(textBoxCoordinateY.Text);
        }

        private void btnColorRGB_Click(object sender, EventArgs e)
        {
            btnColorRGB.BackColor = Color.FromArgb(192, 0, 192);
            btnColorRGB.ForeColor = Color.Black;
            if (textBoxColorRGB.Text != "")
                Clipboard.SetText(textBoxColorRGB.Text);
        }

        private void brnColorHEX_Click(object sender, EventArgs e)
        {
            btnColorHEX.BackColor = Color.FromArgb(192, 0, 192);
            btnColorHEX.ForeColor = Color.Black;
            if (textBoxColorHEX.Text != "")
                Clipboard.SetText(textBoxColorHEX.Text);
        }

        private void btnCoordinateX_MouseEnter(object sender, EventArgs e)
        {
            btnCoordinateX.BackColor = Color.Purple;
            btnColorRGB.ForeColor = Color.White;
        }

        private void btnCoordinateY_MouseEnter(object sender, EventArgs e)
        {
            btnCoordinateY.BackColor = Color.Purple;
            btnColorRGB.ForeColor = Color.White;
        }

        private void btnColorRGB_MouseEnter(object sender, EventArgs e)
        {
            btnColorRGB.BackColor = Color.Purple;
            btnColorRGB.ForeColor = Color.White;
        }

        private void btnColorHEX_MouseEnter(object sender, EventArgs e)
        {
            btnColorHEX.BackColor = Color.Purple;
            btnColorRGB.ForeColor = Color.White;
        }

        private void btnCoordinateX_MouseLeave(object sender, EventArgs e)
        {
            btnCoordinateX.BackColor = SystemColors.ControlDarkDark;
            btnCoordinateX.ForeColor = SystemColors.Control;
        }

        private void btnCoordinateY_MouseLeave(object sender, EventArgs e)
        {
            btnCoordinateY.BackColor = SystemColors.ControlDarkDark;
            btnCoordinateY.ForeColor = SystemColors.Control;
        }

        private void btnColorRGB_MouseLeave(object sender, EventArgs e)
        {
            btnColorRGB.BackColor = SystemColors.ControlDarkDark;
            btnColorRGB.ForeColor = SystemColors.Control;
        }

        private void btnColorHEX_MouseLeave(object sender, EventArgs e)
        {
            btnColorHEX.BackColor = SystemColors.ControlDarkDark;
            btnColorHEX.ForeColor = SystemColors.Control;
        }
    }
}