﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSTATION_1A
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
        Me.pictboxCVS_InsightST1B = New System.Windows.Forms.PictureBox()
        CType(Me.pictboxCVS_InsightST1B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictboxCVS_InsightST1B
        '
        Me.pictboxCVS_InsightST1B.Location = New System.Drawing.Point(12, 12)
        Me.pictboxCVS_InsightST1B.Name = "pictboxCVS_InsightST1B"
        Me.pictboxCVS_InsightST1B.Size = New System.Drawing.Size(800, 600)
        Me.pictboxCVS_InsightST1B.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictboxCVS_InsightST1B.TabIndex = 2
        Me.pictboxCVS_InsightST1B.TabStop = False
        '
        'formSTATION_1A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(842, 623)
        Me.ControlBox = False
        Me.Controls.Add(Me.pictboxCVS_InsightST1B)
        Me.Name = "formSTATION_1A"
        Me.Text = "Station 1A: (Electric Test & Label Print/Inspection)"
        Me.TopMost = True
        CType(Me.pictboxCVS_InsightST1B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pictboxCVS_InsightST1B As System.Windows.Forms.PictureBox
End Class
