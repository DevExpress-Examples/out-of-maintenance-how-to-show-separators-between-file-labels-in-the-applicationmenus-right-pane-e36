Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraEditors

Namespace WindowsApplication8
	Public Module AppMenuFileLabelExtension

        <System.Runtime.CompilerServices.Extension()> _
        Public Sub AddSeparator(ByVal fileLabel As AppMenuFileLabel)
            Dim l As New LabelControl()
            l.AutoSizeMode = LabelAutoSizeMode.None
            l.Text = String.Empty
            l.Height = 10
            l.LineOrientation = LabelLineOrientation.Horizontal
            l.LineVisible = True
            fileLabel.Parent.Controls.Add(l)
            l.Dock = DockStyle.Top
        End Sub
	End Module
End Namespace
