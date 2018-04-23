using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace WindowsApplication8
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) {
                AppMenuFileLabel f = new AppMenuFileLabel();
                popupControlContainer1.Controls.Add(f);
                f.Dock = DockStyle.Top;
                f.Text = "Document " + i.ToString(); 
                if ((i + 1)% 3 == 0)
                    f.AddSeparator();
            }
        }
    }
}