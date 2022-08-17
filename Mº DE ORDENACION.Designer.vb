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
        Me.BTN_CARGA_NºS = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMBX_DESORDEN = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CMBX_ORDEN = New System.Windows.Forms.ComboBox()
        Me.BTN_REINICIA = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_QUICKSORT = New System.Windows.Forms.Button()
        Me.BTN_MIDEFRASE = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.BTN_AREA = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTN_CARGA_NºS
        '
        Me.BTN_CARGA_NºS.Location = New System.Drawing.Point(38, 106)
        Me.BTN_CARGA_NºS.Name = "BTN_CARGA_NºS"
        Me.BTN_CARGA_NºS.Size = New System.Drawing.Size(75, 23)
        Me.BTN_CARGA_NºS.TabIndex = 0
        Me.BTN_CARGA_NºS.Text = "BURBUJA"
        Me.BTN_CARGA_NºS.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CARGAR NºS"
        '
        'CMBX_DESORDEN
        '
        Me.CMBX_DESORDEN.FormattingEnabled = True
        Me.CMBX_DESORDEN.Location = New System.Drawing.Point(147, 106)
        Me.CMBX_DESORDEN.Name = "CMBX_DESORDEN"
        Me.CMBX_DESORDEN.Size = New System.Drawing.Size(135, 21)
        Me.CMBX_DESORDEN.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "VECTOR DESORDENADO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(333, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "VECTOR ORDENADO"
        '
        'CMBX_ORDEN
        '
        Me.CMBX_ORDEN.FormattingEnabled = True
        Me.CMBX_ORDEN.Location = New System.Drawing.Point(323, 106)
        Me.CMBX_ORDEN.Name = "CMBX_ORDEN"
        Me.CMBX_ORDEN.Size = New System.Drawing.Size(135, 21)
        Me.CMBX_ORDEN.TabIndex = 4
        '
        'BTN_REINICIA
        '
        Me.BTN_REINICIA.Location = New System.Drawing.Point(694, 104)
        Me.BTN_REINICIA.Name = "BTN_REINICIA"
        Me.BTN_REINICIA.Size = New System.Drawing.Size(75, 23)
        Me.BTN_REINICIA.TabIndex = 6
        Me.BTN_REINICIA.Text = "REINICIA"
        Me.BTN_REINICIA.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(524, 106)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(135, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(38, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "CUENTA VOCALES"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(521, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "COMBOBOX1"
        '
        'BTN_QUICKSORT
        '
        Me.BTN_QUICKSORT.Location = New System.Drawing.Point(38, 267)
        Me.BTN_QUICKSORT.Name = "BTN_QUICKSORT"
        Me.BTN_QUICKSORT.Size = New System.Drawing.Size(85, 23)
        Me.BTN_QUICKSORT.TabIndex = 10
        Me.BTN_QUICKSORT.Text = "QUICKSORT"
        Me.BTN_QUICKSORT.UseVisualStyleBackColor = True
        '
        'BTN_MIDEFRASE
        '
        Me.BTN_MIDEFRASE.Location = New System.Drawing.Point(38, 204)
        Me.BTN_MIDEFRASE.Name = "BTN_MIDEFRASE"
        Me.BTN_MIDEFRASE.Size = New System.Drawing.Size(89, 23)
        Me.BTN_MIDEFRASE.TabIndex = 11
        Me.BTN_MIDEFRASE.Text = "MIDE FRASE"
        Me.BTN_MIDEFRASE.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(147, 206)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(135, 21)
        Me.ComboBox2.TabIndex = 12
        '
        'BTN_AREA
        '
        Me.BTN_AREA.Location = New System.Drawing.Point(356, 214)
        Me.BTN_AREA.Name = "BTN_AREA"
        Me.BTN_AREA.Size = New System.Drawing.Size(102, 23)
        Me.BTN_AREA.TabIndex = 13
        Me.BTN_AREA.Text = "CALCULA AREA"
        Me.BTN_AREA.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BTN_AREA)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.BTN_MIDEFRASE)
        Me.Controls.Add(Me.BTN_QUICKSORT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BTN_REINICIA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CMBX_ORDEN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CMBX_DESORDEN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_CARGA_NºS)
        Me.Name = "Form1"
        Me.Text = "Mº ORDENACIÓN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_CARGA_NºS As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CMBX_DESORDEN As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CMBX_ORDEN As ComboBox
    Friend WithEvents BTN_REINICIA As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BTN_QUICKSORT As Button
    Friend WithEvents BTN_MIDEFRASE As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents BTN_AREA As Button
End Class
