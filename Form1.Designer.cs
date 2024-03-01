namespace ColorPicker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelColor = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStartAndStop = new System.Windows.Forms.Button();
            this.lblCoordinateX = new System.Windows.Forms.Label();
            this.lblCoordinateY = new System.Windows.Forms.Label();
            this.lblColorRGB = new System.Windows.Forms.Label();
            this.lblColorHEX = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.темаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.светлаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разработчикТайлогсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxCoordinateX = new System.Windows.Forms.TextBox();
            this.textBoxCoordinateY = new System.Windows.Forms.TextBox();
            this.textBoxColorRGB = new System.Windows.Forms.TextBox();
            this.textBoxColorHEX = new System.Windows.Forms.TextBox();
            this.btnCoordinateX = new System.Windows.Forms.Button();
            this.btnCoordinateY = new System.Windows.Forms.Button();
            this.btnColorRGB = new System.Windows.Forms.Button();
            this.btnColorHEX = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(12, 243);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(427, 76);
            this.panelColor.TabIndex = 0;
            this.panelColor.Click += new System.EventHandler(this.panelColor_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStartAndStop
            // 
            this.btnStartAndStop.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnStartAndStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartAndStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartAndStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartAndStop.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStartAndStop.Location = new System.Drawing.Point(12, 37);
            this.btnStartAndStop.Name = "btnStartAndStop";
            this.btnStartAndStop.Size = new System.Drawing.Size(427, 35);
            this.btnStartAndStop.TabIndex = 1;
            this.btnStartAndStop.Text = "Старт сканирования цветов";
            this.btnStartAndStop.UseVisualStyleBackColor = false;
            this.btnStartAndStop.Click += new System.EventHandler(this.btnStartAndStop_Click);
            // 
            // lblCoordinateX
            // 
            this.lblCoordinateX.AutoSize = true;
            this.lblCoordinateX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCoordinateX.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCoordinateX.Location = new System.Drawing.Point(12, 95);
            this.lblCoordinateX.Name = "lblCoordinateX";
            this.lblCoordinateX.Size = new System.Drawing.Size(167, 24);
            this.lblCoordinateX.TabIndex = 3;
            this.lblCoordinateX.Text = "Кординаты по X: ";
            // 
            // lblCoordinateY
            // 
            this.lblCoordinateY.AutoSize = true;
            this.lblCoordinateY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCoordinateY.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCoordinateY.Location = new System.Drawing.Point(12, 127);
            this.lblCoordinateY.Name = "lblCoordinateY";
            this.lblCoordinateY.Size = new System.Drawing.Size(165, 24);
            this.lblCoordinateY.TabIndex = 4;
            this.lblCoordinateY.Text = "Кординаты по Y: ";
            // 
            // lblColorRGB
            // 
            this.lblColorRGB.AutoSize = true;
            this.lblColorRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblColorRGB.ForeColor = System.Drawing.SystemColors.Control;
            this.lblColorRGB.Location = new System.Drawing.Point(12, 159);
            this.lblColorRGB.Name = "lblColorRGB";
            this.lblColorRGB.Size = new System.Drawing.Size(115, 24);
            this.lblColorRGB.TabIndex = 5;
            this.lblColorRGB.Text = "Цвет (RGB):";
            // 
            // lblColorHEX
            // 
            this.lblColorHEX.AutoSize = true;
            this.lblColorHEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblColorHEX.ForeColor = System.Drawing.SystemColors.Control;
            this.lblColorHEX.Location = new System.Drawing.Point(12, 191);
            this.lblColorHEX.Name = "lblColorHEX";
            this.lblColorHEX.Size = new System.Drawing.Size(117, 24);
            this.lblColorHEX.TabIndex = 6;
            this.lblColorHEX.Text = "Цвет (HEX):";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.темаToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.разработчикТайлогсToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(454, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // темаToolStripMenuItem
            // 
            this.темаToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.темаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.темнаяToolStripMenuItem,
            this.светлаяToolStripMenuItem});
            this.темаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.темаToolStripMenuItem.Name = "темаToolStripMenuItem";
            this.темаToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.темаToolStripMenuItem.Text = "Тема";
            // 
            // темнаяToolStripMenuItem
            // 
            this.темнаяToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.темнаяToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.темнаяToolStripMenuItem.Name = "темнаяToolStripMenuItem";
            this.темнаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.темнаяToolStripMenuItem.Text = "Темный";
            this.темнаяToolStripMenuItem.Click += new System.EventHandler(this.темнаяToolStripMenuItem_Click);
            // 
            // светлаяToolStripMenuItem
            // 
            this.светлаяToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.светлаяToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.светлаяToolStripMenuItem.Name = "светлаяToolStripMenuItem";
            this.светлаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.светлаяToolStripMenuItem.Text = "Светлый";
            this.светлаяToolStripMenuItem.Click += new System.EventHandler(this.светлаяToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // разработчикТайлогсToolStripMenuItem
            // 
            this.разработчикТайлогсToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrchid;
            this.разработчикТайлогсToolStripMenuItem.Name = "разработчикТайлогсToolStripMenuItem";
            this.разработчикТайлогсToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.разработчикТайлогсToolStripMenuItem.Text = "Разработчик: Tailogs";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.справкаToolStripMenuItem.Text = "Помощь";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // textBoxCoordinateX
            // 
            this.textBoxCoordinateX.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBoxCoordinateX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCoordinateX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoordinateX.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxCoordinateX.Location = new System.Drawing.Point(174, 93);
            this.textBoxCoordinateX.Name = "textBoxCoordinateX";
            this.textBoxCoordinateX.ReadOnly = true;
            this.textBoxCoordinateX.Size = new System.Drawing.Size(148, 29);
            this.textBoxCoordinateX.TabIndex = 8;
            // 
            // textBoxCoordinateY
            // 
            this.textBoxCoordinateY.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBoxCoordinateY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCoordinateY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCoordinateY.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxCoordinateY.Location = new System.Drawing.Point(174, 125);
            this.textBoxCoordinateY.Name = "textBoxCoordinateY";
            this.textBoxCoordinateY.ReadOnly = true;
            this.textBoxCoordinateY.Size = new System.Drawing.Size(148, 29);
            this.textBoxCoordinateY.TabIndex = 9;
            // 
            // textBoxColorRGB
            // 
            this.textBoxColorRGB.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBoxColorRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxColorRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxColorRGB.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxColorRGB.Location = new System.Drawing.Point(133, 157);
            this.textBoxColorRGB.Name = "textBoxColorRGB";
            this.textBoxColorRGB.ReadOnly = true;
            this.textBoxColorRGB.Size = new System.Drawing.Size(189, 29);
            this.textBoxColorRGB.TabIndex = 10;
            // 
            // textBoxColorHEX
            // 
            this.textBoxColorHEX.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBoxColorHEX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxColorHEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxColorHEX.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxColorHEX.Location = new System.Drawing.Point(133, 189);
            this.textBoxColorHEX.Name = "textBoxColorHEX";
            this.textBoxColorHEX.ReadOnly = true;
            this.textBoxColorHEX.Size = new System.Drawing.Size(189, 29);
            this.textBoxColorHEX.TabIndex = 11;
            // 
            // btnCoordinateX
            // 
            this.btnCoordinateX.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCoordinateX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoordinateX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCoordinateX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCoordinateX.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCoordinateX.Location = new System.Drawing.Point(328, 93);
            this.btnCoordinateX.Name = "btnCoordinateX";
            this.btnCoordinateX.Size = new System.Drawing.Size(111, 29);
            this.btnCoordinateX.TabIndex = 12;
            this.btnCoordinateX.Text = "Копировать";
            this.btnCoordinateX.UseVisualStyleBackColor = false;
            this.btnCoordinateX.Click += new System.EventHandler(this.btnCoordinateX_Click);
            this.btnCoordinateX.MouseEnter += new System.EventHandler(this.btnCoordinateX_MouseEnter);
            this.btnCoordinateX.MouseLeave += new System.EventHandler(this.btnCoordinateX_MouseLeave);
            // 
            // btnCoordinateY
            // 
            this.btnCoordinateY.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCoordinateY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoordinateY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCoordinateY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCoordinateY.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCoordinateY.Location = new System.Drawing.Point(328, 125);
            this.btnCoordinateY.Name = "btnCoordinateY";
            this.btnCoordinateY.Size = new System.Drawing.Size(111, 29);
            this.btnCoordinateY.TabIndex = 13;
            this.btnCoordinateY.Text = "Копировать";
            this.btnCoordinateY.UseVisualStyleBackColor = false;
            this.btnCoordinateY.Click += new System.EventHandler(this.btnCoordinateY_Click);
            this.btnCoordinateY.MouseEnter += new System.EventHandler(this.btnCoordinateY_MouseEnter);
            this.btnCoordinateY.MouseLeave += new System.EventHandler(this.btnCoordinateY_MouseLeave);
            // 
            // btnColorRGB
            // 
            this.btnColorRGB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnColorRGB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorRGB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColorRGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnColorRGB.ForeColor = System.Drawing.SystemColors.Control;
            this.btnColorRGB.Location = new System.Drawing.Point(328, 157);
            this.btnColorRGB.Name = "btnColorRGB";
            this.btnColorRGB.Size = new System.Drawing.Size(111, 29);
            this.btnColorRGB.TabIndex = 14;
            this.btnColorRGB.Text = "Копировать";
            this.btnColorRGB.UseVisualStyleBackColor = false;
            this.btnColorRGB.Click += new System.EventHandler(this.btnColorRGB_Click);
            this.btnColorRGB.MouseEnter += new System.EventHandler(this.btnColorRGB_MouseEnter);
            this.btnColorRGB.MouseLeave += new System.EventHandler(this.btnColorRGB_MouseLeave);
            // 
            // btnColorHEX
            // 
            this.btnColorHEX.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnColorHEX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColorHEX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColorHEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnColorHEX.ForeColor = System.Drawing.SystemColors.Control;
            this.btnColorHEX.Location = new System.Drawing.Point(328, 189);
            this.btnColorHEX.Name = "btnColorHEX";
            this.btnColorHEX.Size = new System.Drawing.Size(111, 29);
            this.btnColorHEX.TabIndex = 15;
            this.btnColorHEX.Text = "Копировать";
            this.btnColorHEX.UseVisualStyleBackColor = false;
            this.btnColorHEX.Click += new System.EventHandler(this.brnColorHEX_Click);
            this.btnColorHEX.MouseEnter += new System.EventHandler(this.btnColorHEX_MouseEnter);
            this.btnColorHEX.MouseLeave += new System.EventHandler(this.btnColorHEX_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(454, 331);
            this.Controls.Add(this.btnColorHEX);
            this.Controls.Add(this.btnColorRGB);
            this.Controls.Add(this.btnCoordinateY);
            this.Controls.Add(this.btnCoordinateX);
            this.Controls.Add(this.textBoxColorHEX);
            this.Controls.Add(this.textBoxColorRGB);
            this.Controls.Add(this.textBoxCoordinateY);
            this.Controls.Add(this.textBoxCoordinateX);
            this.Controls.Add(this.lblColorHEX);
            this.Controls.Add(this.lblColorRGB);
            this.Controls.Add(this.lblCoordinateY);
            this.Controls.Add(this.lblCoordinateX);
            this.Controls.Add(this.btnStartAndStop);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(470, 370);
            this.MinimumSize = new System.Drawing.Size(470, 370);
            this.Name = "Form1";
            this.Text = "ColorPicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStartAndStop;
        private System.Windows.Forms.Label lblCoordinateX;
        private System.Windows.Forms.Label lblCoordinateY;
        private System.Windows.Forms.Label lblColorRGB;
        private System.Windows.Forms.Label lblColorHEX;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem темаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem светлаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разработчикТайлогсToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxCoordinateX;
        private System.Windows.Forms.TextBox textBoxCoordinateY;
        private System.Windows.Forms.TextBox textBoxColorRGB;
        private System.Windows.Forms.TextBox textBoxColorHEX;
        private System.Windows.Forms.Button btnCoordinateX;
        private System.Windows.Forms.Button btnCoordinateY;
        private System.Windows.Forms.Button btnColorRGB;
        private System.Windows.Forms.Button btnColorHEX;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

