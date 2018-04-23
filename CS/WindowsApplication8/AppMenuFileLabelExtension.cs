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
    public static class AppMenuFileLabelExtension
    {
        
        public static void AddSeparator(this AppMenuFileLabel fileLabel)
        {
            LabelControl l = new LabelControl();
            l.AutoSizeMode = LabelAutoSizeMode.None;
            l.Text = string.Empty;
            l.Height = 10;
            l.LineOrientation = LabelLineOrientation.Horizontal;
            l.LineVisible = true;
            fileLabel.Parent.Controls.Add(l);
            l.Dock = DockStyle.Top;
        }
    }
}
