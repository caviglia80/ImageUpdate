<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		uploadBtn = New Button()
		SuspendLayout()
		' 
		' uploadBtn
		' 
		uploadBtn.Location = New Point(35, 12)
		uploadBtn.Name = "uploadBtn"
		uploadBtn.Size = New Size(143, 26)
		uploadBtn.TabIndex = 0
		uploadBtn.Text = "Subir imagen"
		uploadBtn.UseVisualStyleBackColor = True
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(7F, 15F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(231, 45)
		Controls.Add(uploadBtn)
		Name = "Form1"
		Text = "Actualizar imagen"
		ResumeLayout(False)
	End Sub

	Friend WithEvents uploadBtn As Button
End Class
