Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication8
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.applicationMenu1 = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
			Me.popupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
			CType(Me.applicationMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ApplicationButtonDropDownControl = Me.applicationMenu1
			Me.ribbonControl1.ApplicationButtonKeyTip = ""
			Me.ribbonControl1.ApplicationIcon = Nothing
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barButtonItem4, Me.barButtonItem5})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 5
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonControl1.SelectedPage = Me.ribbonPage1
			Me.ribbonControl1.Size = New System.Drawing.Size(598, 143)
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
			Me.ribbonPage1.KeyTip = ""
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "ribbonPage1"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.KeyTip = ""
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
			' 
			' applicationMenu1
			' 
			Me.applicationMenu1.BottomPaneControlContainer = Nothing
			Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem1)
			Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem2)
			Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem3)
			Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem4)
			Me.applicationMenu1.ItemLinks.Add(Me.barButtonItem5)
			Me.applicationMenu1.Name = "applicationMenu1"
			Me.applicationMenu1.Ribbon = Me.ribbonControl1
			Me.applicationMenu1.RightPaneControlContainer = Me.popupControlContainer1
			Me.applicationMenu1.RightPaneWidth = 240
			Me.applicationMenu1.ShowRightPane = True
			' 
			' popupControlContainer1
			' 
			Me.popupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.popupControlContainer1.Location = New System.Drawing.Point(351, 239)
			Me.popupControlContainer1.Name = "popupControlContainer1"
			Me.popupControlContainer1.Ribbon = Me.ribbonControl1
			Me.popupControlContainer1.Size = New System.Drawing.Size(200, 126)
			Me.popupControlContainer1.TabIndex = 1
			Me.popupControlContainer1.Visible = False
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "barButtonItem1"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "barButtonItem2"
			Me.barButtonItem2.Id = 1
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' barButtonItem3
			' 
			Me.barButtonItem3.Caption = "barButtonItem3"
			Me.barButtonItem3.Id = 2
			Me.barButtonItem3.Name = "barButtonItem3"
			' 
			' barButtonItem4
			' 
			Me.barButtonItem4.Caption = "barButtonItem4"
			Me.barButtonItem4.Id = 3
			Me.barButtonItem4.Name = "barButtonItem4"
			' 
			' barButtonItem5
			' 
			Me.barButtonItem5.Caption = "barButtonItem5"
			Me.barButtonItem5.Id = 4
			Me.barButtonItem5.Name = "barButtonItem5"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(598, 399)
			Me.Controls.Add(Me.popupControlContainer1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "Form1"
			Me.Ribbon = Me.ribbonControl1
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.applicationMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private applicationMenu1 As DevExpress.XtraBars.Ribbon.ApplicationMenu
		Private popupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem4 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem5 As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace

