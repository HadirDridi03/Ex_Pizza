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
        lsttaille = New ComboBox()
        rdprop1 = New RadioButton()
        rdprop3 = New RadioButton()
        rdprop2 = New RadioButton()
        chk1 = New CheckBox()
        chk3 = New CheckBox()
        chk4 = New CheckBox()
        btnafficher = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        chk2 = New CheckBox()
        affichage = New Label()
        SuspendLayout()
        ' 
        ' lsttaille
        ' 
        lsttaille.FormattingEnabled = True
        lsttaille.Items.AddRange(New Object() {"petite", "moyenne", "grande"})
        lsttaille.Location = New Point(543, 107)
        lsttaille.Name = "lsttaille"
        lsttaille.Size = New Size(151, 28)
        lsttaille.TabIndex = 0
        ' 
        ' rdprop1
        ' 
        rdprop1.AutoSize = True
        rdprop1.BackColor = Color.Bisque
        rdprop1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rdprop1.Location = New Point(174, 200)
        rdprop1.Name = "rdprop1"
        rdprop1.Size = New Size(121, 29)
        rdprop1.TabIndex = 1
        rdprop1.TabStop = True
        rdprop1.Text = "Croûte fine"
        rdprop1.UseVisualStyleBackColor = False
        ' 
        ' rdprop3
        ' 
        rdprop3.AutoSize = True
        rdprop3.BackColor = Color.Bisque
        rdprop3.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rdprop3.Location = New Point(174, 270)
        rdprop3.Name = "rdprop3"
        rdprop3.Size = New Size(150, 29)
        rdprop3.TabIndex = 2
        rdprop3.TabStop = True
        rdprop3.Text = "Croûte epaisse"
        rdprop3.UseVisualStyleBackColor = False
        ' 
        ' rdprop2
        ' 
        rdprop2.AutoSize = True
        rdprop2.BackColor = Color.Bisque
        rdprop2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rdprop2.Location = New Point(174, 235)
        rdprop2.Name = "rdprop2"
        rdprop2.Size = New Size(164, 29)
        rdprop2.TabIndex = 3
        rdprop2.TabStop = True
        rdprop2.Text = "Croûte classique"
        rdprop2.UseVisualStyleBackColor = False
        ' 
        ' chk1
        ' 
        chk1.AutoSize = True
        chk1.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        chk1.Location = New Point(111, 345)
        chk1.Name = "chk1"
        chk1.Size = New Size(144, 29)
        chk1.TabIndex = 4
        chk1.Text = "Champignons"
        chk1.UseVisualStyleBackColor = True
        ' 
        ' chk3
        ' 
        chk3.AutoSize = True
        chk3.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        chk3.Location = New Point(375, 345)
        chk3.Name = "chk3"
        chk3.Size = New Size(104, 29)
        chk3.TabIndex = 6
        chk3.Text = "Poivrons"
        chk3.UseVisualStyleBackColor = True
        ' 
        ' chk4
        ' 
        chk4.AutoSize = True
        chk4.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        chk4.Location = New Point(500, 345)
        chk4.Name = "chk4"
        chk4.Size = New Size(234, 29)
        chk4.TabIndex = 7
        chk4.Text = "Fromage supplémentaire"
        chk4.UseVisualStyleBackColor = True
        ' 
        ' btnafficher
        ' 
        btnafficher.BackColor = Color.Crimson
        btnafficher.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnafficher.ForeColor = Color.Bisque
        btnafficher.Location = New Point(249, 403)
        btnafficher.Name = "btnafficher"
        btnafficher.Size = New Size(268, 57)
        btnafficher.TabIndex = 8
        btnafficher.Text = "afficher"
        btnafficher.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Crimson
        Label1.Location = New Point(120, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(397, 32)
        Label1.TabIndex = 9
        Label1.Text = "Sélectionner la taille de la pizza:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Bisque
        Label2.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Crimson
        Label2.Location = New Point(174, 165)
        Label2.Name = "Label2"
        Label2.Size = New Size(304, 32)
        Label2.TabIndex = 10
        Label2.Text = "choisir le type de croute:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Bisque
        Label3.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Crimson
        Label3.Location = New Point(149, 310)
        Label3.Name = "Label3"
        Label3.Size = New Size(545, 32)
        Label3.TabIndex = 11
        Label3.Text = "sélectionnez les ingrédients supplémentaires:"
        ' 
        ' chk2
        ' 
        chk2.AutoSize = True
        chk2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        chk2.Location = New Point(261, 345)
        chk2.Name = "chk2"
        chk2.Size = New Size(84, 29)
        chk2.TabIndex = 12
        chk2.Text = "Olives"
        chk2.UseVisualStyleBackColor = True
        ' 
        ' affichage
        ' 
        affichage.AutoSize = True
        affichage.Location = New Point(459, 403)
        affichage.Name = "affichage"
        affichage.Size = New Size(0, 20)
        affichage.TabIndex = 13
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources._2a7cafb07093ddb6555bf81f55144be3
        ClientSize = New Size(800, 472)
        Controls.Add(affichage)
        Controls.Add(chk2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnafficher)
        Controls.Add(chk4)
        Controls.Add(chk3)
        Controls.Add(chk1)
        Controls.Add(rdprop2)
        Controls.Add(rdprop3)
        Controls.Add(rdprop1)
        Controls.Add(lsttaille)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lsttaille As ComboBox
    Friend WithEvents rdprop1 As RadioButton
    Friend WithEvents rdprop3 As RadioButton
    Friend WithEvents rdprop2 As RadioButton
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents btnafficher As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents affichage As Label

End Class
