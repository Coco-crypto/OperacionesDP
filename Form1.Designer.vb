<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.suma = New System.Windows.Forms.Button()
        Me.resta = New System.Windows.Forms.Button()
        Me.multiplicacion = New System.Windows.Forms.Button()
        Me.division = New System.Windows.Forms.Button()
        Me.potencia = New System.Windows.Forms.Button()
        Me.factorial = New System.Windows.Forms.Button()
        Me.raiz = New System.Windows.Forms.Button()
        Me.logn = New System.Windows.Forms.Button()
        Me.logb10 = New System.Windows.Forms.Button()
        Me.residuo = New System.Windows.Forms.Button()
        Me.tresultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(111, 52)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 22)
        Me.txt1.TabIndex = 0
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(111, 99)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 22)
        Me.txt2.TabIndex = 1
        '
        'suma
        '
        Me.suma.Location = New System.Drawing.Point(24, 146)
        Me.suma.Name = "suma"
        Me.suma.Size = New System.Drawing.Size(75, 23)
        Me.suma.TabIndex = 2
        Me.suma.Text = "SUMA"
        Me.suma.UseVisualStyleBackColor = True
        '
        'resta
        '
        Me.resta.Location = New System.Drawing.Point(24, 186)
        Me.resta.Name = "resta"
        Me.resta.Size = New System.Drawing.Size(75, 23)
        Me.resta.TabIndex = 3
        Me.resta.Text = "RESTA"
        Me.resta.UseVisualStyleBackColor = True
        '
        'multiplicacion
        '
        Me.multiplicacion.Location = New System.Drawing.Point(92, 266)
        Me.multiplicacion.Name = "multiplicacion"
        Me.multiplicacion.Size = New System.Drawing.Size(134, 23)
        Me.multiplicacion.TabIndex = 4
        Me.multiplicacion.Text = "MULTIPLICACION"
        Me.multiplicacion.UseVisualStyleBackColor = True
        '
        'division
        '
        Me.division.Location = New System.Drawing.Point(126, 146)
        Me.division.Name = "division"
        Me.division.Size = New System.Drawing.Size(75, 23)
        Me.division.TabIndex = 5
        Me.division.Text = "DIVISION"
        Me.division.UseVisualStyleBackColor = True
        '
        'potencia
        '
        Me.potencia.Location = New System.Drawing.Point(116, 186)
        Me.potencia.Name = "potencia"
        Me.potencia.Size = New System.Drawing.Size(95, 23)
        Me.potencia.TabIndex = 6
        Me.potencia.Text = "POTENCIA"
        Me.potencia.UseVisualStyleBackColor = True
        '
        'factorial
        '
        Me.factorial.Location = New System.Drawing.Point(113, 227)
        Me.factorial.Name = "factorial"
        Me.factorial.Size = New System.Drawing.Size(98, 23)
        Me.factorial.TabIndex = 7
        Me.factorial.Text = "FACTORIAL"
        Me.factorial.UseVisualStyleBackColor = True
        Me.factorial.UseWaitCursor = True
        '
        'raiz
        '
        Me.raiz.Location = New System.Drawing.Point(230, 146)
        Me.raiz.Name = "raiz"
        Me.raiz.Size = New System.Drawing.Size(75, 23)
        Me.raiz.TabIndex = 8
        Me.raiz.Text = "RAIZ 2"
        Me.raiz.UseVisualStyleBackColor = True
        '
        'logn
        '
        Me.logn.Location = New System.Drawing.Point(230, 186)
        Me.logn.Name = "logn"
        Me.logn.Size = New System.Drawing.Size(75, 23)
        Me.logn.TabIndex = 9
        Me.logn.Text = "LOG N "
        Me.logn.UseVisualStyleBackColor = True
        '
        'logb10
        '
        Me.logb10.Location = New System.Drawing.Point(230, 227)
        Me.logb10.Name = "logb10"
        Me.logb10.Size = New System.Drawing.Size(75, 23)
        Me.logb10.TabIndex = 10
        Me.logb10.Text = "LOG_10"
        Me.logb10.UseVisualStyleBackColor = True
        '
        'residuo
        '
        Me.residuo.Location = New System.Drawing.Point(16, 227)
        Me.residuo.Name = "residuo"
        Me.residuo.Size = New System.Drawing.Size(83, 23)
        Me.residuo.TabIndex = 11
        Me.residuo.Text = "RESIDUO"
        Me.residuo.UseVisualStyleBackColor = True
        '
        'tresultado
        '
        Me.tresultado.Location = New System.Drawing.Point(111, 304)
        Me.tresultado.Name = "tresultado"
        Me.tresultado.Size = New System.Drawing.Size(100, 22)
        Me.tresultado.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 408)
        Me.Controls.Add(Me.tresultado)
        Me.Controls.Add(Me.residuo)
        Me.Controls.Add(Me.logb10)
        Me.Controls.Add(Me.logn)
        Me.Controls.Add(Me.raiz)
        Me.Controls.Add(Me.factorial)
        Me.Controls.Add(Me.potencia)
        Me.Controls.Add(Me.division)
        Me.Controls.Add(Me.multiplicacion)
        Me.Controls.Add(Me.resta)
        Me.Controls.Add(Me.suma)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents suma As Button
    Friend WithEvents resta As Button
    Friend WithEvents multiplicacion As Button
    Friend WithEvents division As Button
    Friend WithEvents potencia As Button
    Friend WithEvents factorial As Button
    Friend WithEvents raiz As Button
    Friend WithEvents logn As Button
    Friend WithEvents logb10 As Button
    Friend WithEvents residuo As Button
    Friend WithEvents tresultado As TextBox
End Class
