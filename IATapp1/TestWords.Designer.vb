﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestWords
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestWords))
        Me.WdSetLabel2 = New System.Windows.Forms.Label
        Me.WdSetLabel1 = New System.Windows.Forms.Label
        Me.WordLabel1 = New System.Windows.Forms.Label
        Me.WordLabel2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StimWord = New System.Windows.Forms.Label
        Me.WrongBoxRt = New System.Windows.Forms.PictureBox
        Me.WrongBoxLeft = New System.Windows.Forms.PictureBox
        Me.aPanel = New System.Windows.Forms.Panel
        Me.startLabel = New System.Windows.Forms.Label
        CType(Me.WrongBoxRt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WrongBoxLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.aPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'WdSetLabel2
        '
        Me.WdSetLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WdSetLabel2.ForeColor = System.Drawing.Color.White
        Me.WdSetLabel2.Location = New System.Drawing.Point(314, 12)
        Me.WdSetLabel2.Name = "WdSetLabel2"
        Me.WdSetLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WdSetLabel2.Size = New System.Drawing.Size(284, 29)
        Me.WdSetLabel2.TabIndex = 3
        Me.WdSetLabel2.Text = "WdSet Label 2"
        Me.WdSetLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'WdSetLabel1
        '
        Me.WdSetLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WdSetLabel1.ForeColor = System.Drawing.Color.White
        Me.WdSetLabel1.Location = New System.Drawing.Point(14, 12)
        Me.WdSetLabel1.Name = "WdSetLabel1"
        Me.WdSetLabel1.Size = New System.Drawing.Size(284, 29)
        Me.WdSetLabel1.TabIndex = 4
        Me.WdSetLabel1.Text = "WdSet Label 1"
        '
        'WordLabel1
        '
        Me.WordLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WordLabel1.ForeColor = System.Drawing.Color.LimeGreen
        Me.WordLabel1.Location = New System.Drawing.Point(14, 46)
        Me.WordLabel1.Name = "WordLabel1"
        Me.WordLabel1.Size = New System.Drawing.Size(284, 29)
        Me.WordLabel1.TabIndex = 6
        Me.WordLabel1.Text = "Stim Word Label 1"
        Me.WordLabel1.Visible = False
        '
        'WordLabel2
        '
        Me.WordLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WordLabel2.ForeColor = System.Drawing.Color.LimeGreen
        Me.WordLabel2.Location = New System.Drawing.Point(314, 46)
        Me.WordLabel2.Name = "WordLabel2"
        Me.WordLabel2.Size = New System.Drawing.Size(284, 29)
        Me.WordLabel2.TabIndex = 7
        Me.WordLabel2.Text = "Label1"
        Me.WordLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.WordLabel2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(106, 408)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Keep your index fingers on the 'e' and 'i' keys"
        '
        'StimWord
        '
        Me.StimWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StimWord.ForeColor = System.Drawing.Color.White
        Me.StimWord.Location = New System.Drawing.Point(159, 195)
        Me.StimWord.Name = "StimWord"
        Me.StimWord.Size = New System.Drawing.Size(302, 83)
        Me.StimWord.TabIndex = 11
        Me.StimWord.Text = "StimWord"
        Me.StimWord.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.StimWord.Visible = False
        '
        'WrongBoxRt
        '
        Me.WrongBoxRt.Image = Global.IATapplication1.My.Resources.Resources.redx1
        Me.WrongBoxRt.Location = New System.Drawing.Point(447, 218)
        Me.WrongBoxRt.Name = "WrongBoxRt"
        Me.WrongBoxRt.Size = New System.Drawing.Size(150, 150)
        Me.WrongBoxRt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.WrongBoxRt.TabIndex = 10
        Me.WrongBoxRt.TabStop = False
        Me.WrongBoxRt.Visible = False
        '
        'WrongBoxLeft
        '
        Me.WrongBoxLeft.Image = Global.IATapplication1.My.Resources.Resources.redx1
        Me.WrongBoxLeft.Location = New System.Drawing.Point(17, 214)
        Me.WrongBoxLeft.Name = "WrongBoxLeft"
        Me.WrongBoxLeft.Size = New System.Drawing.Size(150, 150)
        Me.WrongBoxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.WrongBoxLeft.TabIndex = 9
        Me.WrongBoxLeft.TabStop = False
        Me.WrongBoxLeft.Visible = False
        '
        'aPanel
        '
        Me.aPanel.Controls.Add(Me.startLabel)
        Me.aPanel.Controls.Add(Me.WdSetLabel1)
        Me.aPanel.Controls.Add(Me.Label1)
        Me.aPanel.Controls.Add(Me.WrongBoxRt)
        Me.aPanel.Controls.Add(Me.StimWord)
        Me.aPanel.Controls.Add(Me.WrongBoxLeft)
        Me.aPanel.Controls.Add(Me.WdSetLabel2)
        Me.aPanel.Controls.Add(Me.WordLabel1)
        Me.aPanel.Controls.Add(Me.WordLabel2)
        Me.aPanel.Location = New System.Drawing.Point(258, 37)
        Me.aPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.aPanel.Name = "aPanel"
        Me.aPanel.Size = New System.Drawing.Size(614, 487)
        Me.aPanel.TabIndex = 12
        '
        'startLabel
        '
        Me.startLabel.BackColor = System.Drawing.Color.White
        Me.startLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.startLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startLabel.ForeColor = System.Drawing.SystemColors.Highlight
        Me.startLabel.Location = New System.Drawing.Point(175, 345)
        Me.startLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.startLabel.Name = "startLabel"
        Me.startLabel.Size = New System.Drawing.Size(265, 37)
        Me.startLabel.TabIndex = 13
        Me.startLabel.Text = "Press Space"
        Me.startLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TestWords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1084, 715)
        Me.Controls.Add(Me.aPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TestWords"
        Me.Text = "FreeIAT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.WrongBoxRt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WrongBoxLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.aPanel.ResumeLayout(False)
        Me.aPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WdSetLabel2 As System.Windows.Forms.Label
    Friend WithEvents WdSetLabel1 As System.Windows.Forms.Label
    Friend WithEvents WordLabel1 As System.Windows.Forms.Label
    Friend WithEvents WordLabel2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StimWord As System.Windows.Forms.Label
    Friend WithEvents WrongBoxRt As System.Windows.Forms.PictureBox
    Friend WithEvents WrongBoxLeft As System.Windows.Forms.PictureBox
    Friend WithEvents aPanel As System.Windows.Forms.Panel
    Friend WithEvents startLabel As System.Windows.Forms.Label
End Class
