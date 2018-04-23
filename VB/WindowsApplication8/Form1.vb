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
	Partial Public Class Form1
		Inherits RibbonForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			For i As Integer = 0 To 9
				Dim f As New AppMenuFileLabel()
				popupControlContainer1.Controls.Add(f)
				f.Dock = DockStyle.Top
				f.Text = "Document " & i.ToString()
				If (i + 1) Mod 3 = 0 Then
					f.AddSeparator()
				End If
			Next i
		End Sub
	End Class
End Namespace