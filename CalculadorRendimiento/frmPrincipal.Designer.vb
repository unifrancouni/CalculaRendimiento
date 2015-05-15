<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblNA = New System.Windows.Forms.Label()
        Me.lblNb = New System.Windows.Forms.Label()
        Me.lblCPIa = New System.Windows.Forms.Label()
        Me.lblCPIb = New System.Windows.Forms.Label()
        Me.lblFa = New System.Windows.Forms.Label()
        Me.lblFb = New System.Windows.Forms.Label()
        Me.lbl_n_b_a = New System.Windows.Forms.Label()
        Me.txtNa = New System.Windows.Forms.TextBox()
        Me.txtNb = New System.Windows.Forms.TextBox()
        Me.txtCPIa = New System.Windows.Forms.TextBox()
        Me.txtCPIb = New System.Windows.Forms.TextBox()
        Me.txtFa = New System.Windows.Forms.TextBox()
        Me.txtFb = New System.Windows.Forms.TextBox()
        Me.txt_n_b_a = New System.Windows.Forms.TextBox()
        Me.btnAddNb = New System.Windows.Forms.Button()
        Me.btnClearNa = New System.Windows.Forms.Button()
        Me.btnClearNb = New System.Windows.Forms.Button()
        Me.btnAddNa = New System.Windows.Forms.Button()
        Me.btnClearCPIa = New System.Windows.Forms.Button()
        Me.btnAddCPIb = New System.Windows.Forms.Button()
        Me.btnClearCPIb = New System.Windows.Forms.Button()
        Me.btnAddCPIa = New System.Windows.Forms.Button()
        Me.btnClearFa = New System.Windows.Forms.Button()
        Me.btnAddFb = New System.Windows.Forms.Button()
        Me.btnClearFb = New System.Windows.Forms.Button()
        Me.btnAddFa = New System.Windows.Forms.Button()
        Me.btnClear_n_b_a = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.errSintaxisTxt = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errSintaxisTxt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(23, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(342, 24)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "CALCULADORA DE RENDIMIENTO"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNA
        '
        Me.lblNA.AutoSize = True
        Me.lblNA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNA.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblNA.Location = New System.Drawing.Point(29, 58)
        Me.lblNA.Name = "lblNA"
        Me.lblNA.Size = New System.Drawing.Size(24, 13)
        Me.lblNA.TabIndex = 0
        Me.lblNA.Text = "NA"
        '
        'lblNb
        '
        Me.lblNb.AutoSize = True
        Me.lblNb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNb.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblNb.Location = New System.Drawing.Point(29, 84)
        Me.lblNb.Name = "lblNb"
        Me.lblNb.Size = New System.Drawing.Size(24, 13)
        Me.lblNb.TabIndex = 0
        Me.lblNb.Text = "NB"
        '
        'lblCPIa
        '
        Me.lblCPIa.AutoSize = True
        Me.lblCPIa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPIa.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblCPIa.Location = New System.Drawing.Point(29, 110)
        Me.lblCPIa.Name = "lblCPIa"
        Me.lblCPIa.Size = New System.Drawing.Size(35, 13)
        Me.lblCPIa.TabIndex = 0
        Me.lblCPIa.Text = "CPIA"
        '
        'lblCPIb
        '
        Me.lblCPIb.AutoSize = True
        Me.lblCPIb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPIb.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblCPIb.Location = New System.Drawing.Point(29, 136)
        Me.lblCPIb.Name = "lblCPIb"
        Me.lblCPIb.Size = New System.Drawing.Size(35, 13)
        Me.lblCPIb.TabIndex = 0
        Me.lblCPIb.Text = "CPIB"
        '
        'lblFa
        '
        Me.lblFa.AutoSize = True
        Me.lblFa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFa.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblFa.Location = New System.Drawing.Point(29, 162)
        Me.lblFa.Name = "lblFa"
        Me.lblFa.Size = New System.Drawing.Size(22, 13)
        Me.lblFa.TabIndex = 0
        Me.lblFa.Text = "FA"
        '
        'lblFb
        '
        Me.lblFb.AutoSize = True
        Me.lblFb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFb.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblFb.Location = New System.Drawing.Point(29, 188)
        Me.lblFb.Name = "lblFb"
        Me.lblFb.Size = New System.Drawing.Size(22, 13)
        Me.lblFb.TabIndex = 0
        Me.lblFb.Text = "FB"
        '
        'lbl_n_b_a
        '
        Me.lbl_n_b_a.AutoSize = True
        Me.lbl_n_b_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_n_b_a.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lbl_n_b_a.Location = New System.Drawing.Point(29, 214)
        Me.lbl_n_b_a.Name = "lbl_n_b_a"
        Me.lbl_n_b_a.Size = New System.Drawing.Size(47, 13)
        Me.lbl_n_b_a.TabIndex = 0
        Me.lbl_n_b_a.Text = "N%B/A"
        '
        'txtNa
        '
        Me.txtNa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNa.BackColor = System.Drawing.Color.White
        Me.txtNa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNa.Location = New System.Drawing.Point(96, 58)
        Me.txtNa.Name = "txtNa"
        Me.txtNa.Size = New System.Drawing.Size(142, 20)
        Me.txtNa.TabIndex = 1
        Me.txtNa.Tag = "0"
        '
        'txtNb
        '
        Me.txtNb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNb.BackColor = System.Drawing.Color.White
        Me.txtNb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNb.Location = New System.Drawing.Point(96, 84)
        Me.txtNb.Name = "txtNb"
        Me.txtNb.Size = New System.Drawing.Size(142, 20)
        Me.txtNb.TabIndex = 2
        Me.txtNb.Tag = "0"
        '
        'txtCPIa
        '
        Me.txtCPIa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCPIa.BackColor = System.Drawing.Color.White
        Me.txtCPIa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCPIa.Location = New System.Drawing.Point(96, 110)
        Me.txtCPIa.Name = "txtCPIa"
        Me.txtCPIa.Size = New System.Drawing.Size(142, 20)
        Me.txtCPIa.TabIndex = 3
        Me.txtCPIa.Tag = "0"
        '
        'txtCPIb
        '
        Me.txtCPIb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCPIb.BackColor = System.Drawing.Color.White
        Me.txtCPIb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCPIb.Location = New System.Drawing.Point(96, 136)
        Me.txtCPIb.Name = "txtCPIb"
        Me.txtCPIb.Size = New System.Drawing.Size(142, 20)
        Me.txtCPIb.TabIndex = 4
        Me.txtCPIb.Tag = "0"
        '
        'txtFa
        '
        Me.txtFa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFa.BackColor = System.Drawing.Color.White
        Me.txtFa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFa.Location = New System.Drawing.Point(96, 162)
        Me.txtFa.Name = "txtFa"
        Me.txtFa.Size = New System.Drawing.Size(142, 20)
        Me.txtFa.TabIndex = 5
        Me.txtFa.Tag = "0"
        '
        'txtFb
        '
        Me.txtFb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFb.BackColor = System.Drawing.Color.White
        Me.txtFb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFb.Location = New System.Drawing.Point(96, 188)
        Me.txtFb.Name = "txtFb"
        Me.txtFb.Size = New System.Drawing.Size(142, 20)
        Me.txtFb.TabIndex = 6
        Me.txtFb.Tag = "0"
        '
        'txt_n_b_a
        '
        Me.txt_n_b_a.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_n_b_a.BackColor = System.Drawing.Color.White
        Me.txt_n_b_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_n_b_a.Location = New System.Drawing.Point(96, 214)
        Me.txt_n_b_a.Name = "txt_n_b_a"
        Me.txt_n_b_a.Size = New System.Drawing.Size(142, 20)
        Me.txt_n_b_a.TabIndex = 7
        Me.txt_n_b_a.Tag = "0"
        '
        'btnAddNb
        '
        Me.btnAddNb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddNb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNb.Location = New System.Drawing.Point(271, 56)
        Me.btnAddNb.Name = "btnAddNb"
        Me.btnAddNb.Size = New System.Drawing.Size(56, 23)
        Me.btnAddNb.TabIndex = 8
        Me.btnAddNb.Text = "×NB"
        Me.btnAddNb.UseVisualStyleBackColor = True
        '
        'btnClearNa
        '
        Me.btnClearNa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearNa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearNa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearNa.Image = CType(resources.GetObject("btnClearNa.Image"), System.Drawing.Image)
        Me.btnClearNa.Location = New System.Drawing.Point(333, 56)
        Me.btnClearNa.Name = "btnClearNa"
        Me.btnClearNa.Size = New System.Drawing.Size(39, 23)
        Me.btnClearNa.TabIndex = 14
        Me.btnClearNa.UseVisualStyleBackColor = True
        '
        'btnClearNb
        '
        Me.btnClearNb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearNb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearNb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearNb.Image = CType(resources.GetObject("btnClearNb.Image"), System.Drawing.Image)
        Me.btnClearNb.Location = New System.Drawing.Point(333, 82)
        Me.btnClearNb.Name = "btnClearNb"
        Me.btnClearNb.Size = New System.Drawing.Size(39, 23)
        Me.btnClearNb.TabIndex = 15
        Me.btnClearNb.UseVisualStyleBackColor = True
        '
        'btnAddNa
        '
        Me.btnAddNa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddNa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddNa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNa.Location = New System.Drawing.Point(271, 82)
        Me.btnAddNa.Name = "btnAddNa"
        Me.btnAddNa.Size = New System.Drawing.Size(56, 23)
        Me.btnAddNa.TabIndex = 9
        Me.btnAddNa.Text = "×NA"
        Me.btnAddNa.UseVisualStyleBackColor = True
        '
        'btnClearCPIa
        '
        Me.btnClearCPIa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearCPIa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearCPIa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearCPIa.Image = CType(resources.GetObject("btnClearCPIa.Image"), System.Drawing.Image)
        Me.btnClearCPIa.Location = New System.Drawing.Point(333, 108)
        Me.btnClearCPIa.Name = "btnClearCPIa"
        Me.btnClearCPIa.Size = New System.Drawing.Size(39, 23)
        Me.btnClearCPIa.TabIndex = 16
        Me.btnClearCPIa.UseVisualStyleBackColor = True
        '
        'btnAddCPIb
        '
        Me.btnAddCPIb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCPIb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCPIb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCPIb.Location = New System.Drawing.Point(271, 108)
        Me.btnAddCPIb.Name = "btnAddCPIb"
        Me.btnAddCPIb.Size = New System.Drawing.Size(56, 23)
        Me.btnAddCPIb.TabIndex = 10
        Me.btnAddCPIb.Text = "×CPIB"
        Me.btnAddCPIb.UseVisualStyleBackColor = True
        '
        'btnClearCPIb
        '
        Me.btnClearCPIb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearCPIb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearCPIb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearCPIb.Image = CType(resources.GetObject("btnClearCPIb.Image"), System.Drawing.Image)
        Me.btnClearCPIb.Location = New System.Drawing.Point(333, 134)
        Me.btnClearCPIb.Name = "btnClearCPIb"
        Me.btnClearCPIb.Size = New System.Drawing.Size(39, 23)
        Me.btnClearCPIb.TabIndex = 17
        Me.btnClearCPIb.UseVisualStyleBackColor = True
        '
        'btnAddCPIa
        '
        Me.btnAddCPIa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCPIa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCPIa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCPIa.Location = New System.Drawing.Point(271, 134)
        Me.btnAddCPIa.Name = "btnAddCPIa"
        Me.btnAddCPIa.Size = New System.Drawing.Size(56, 23)
        Me.btnAddCPIa.TabIndex = 11
        Me.btnAddCPIa.Text = "×CPIA"
        Me.btnAddCPIa.UseVisualStyleBackColor = True
        '
        'btnClearFa
        '
        Me.btnClearFa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearFa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearFa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearFa.Image = CType(resources.GetObject("btnClearFa.Image"), System.Drawing.Image)
        Me.btnClearFa.Location = New System.Drawing.Point(333, 160)
        Me.btnClearFa.Name = "btnClearFa"
        Me.btnClearFa.Size = New System.Drawing.Size(39, 23)
        Me.btnClearFa.TabIndex = 18
        Me.btnClearFa.UseVisualStyleBackColor = True
        '
        'btnAddFb
        '
        Me.btnAddFb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddFb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddFb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFb.Location = New System.Drawing.Point(271, 160)
        Me.btnAddFb.Name = "btnAddFb"
        Me.btnAddFb.Size = New System.Drawing.Size(56, 23)
        Me.btnAddFb.TabIndex = 12
        Me.btnAddFb.Text = "×FB"
        Me.btnAddFb.UseVisualStyleBackColor = True
        '
        'btnClearFb
        '
        Me.btnClearFb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearFb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearFb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearFb.Image = CType(resources.GetObject("btnClearFb.Image"), System.Drawing.Image)
        Me.btnClearFb.Location = New System.Drawing.Point(333, 186)
        Me.btnClearFb.Name = "btnClearFb"
        Me.btnClearFb.Size = New System.Drawing.Size(39, 23)
        Me.btnClearFb.TabIndex = 19
        Me.btnClearFb.UseVisualStyleBackColor = True
        '
        'btnAddFa
        '
        Me.btnAddFa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddFa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddFa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddFa.Location = New System.Drawing.Point(271, 186)
        Me.btnAddFa.Name = "btnAddFa"
        Me.btnAddFa.Size = New System.Drawing.Size(56, 23)
        Me.btnAddFa.TabIndex = 13
        Me.btnAddFa.Text = "×FA"
        Me.btnAddFa.UseVisualStyleBackColor = True
        '
        'btnClear_n_b_a
        '
        Me.btnClear_n_b_a.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear_n_b_a.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear_n_b_a.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear_n_b_a.Image = CType(resources.GetObject("btnClear_n_b_a.Image"), System.Drawing.Image)
        Me.btnClear_n_b_a.Location = New System.Drawing.Point(333, 212)
        Me.btnClear_n_b_a.Name = "btnClear_n_b_a"
        Me.btnClear_n_b_a.Size = New System.Drawing.Size(39, 23)
        Me.btnClear_n_b_a.TabIndex = 20
        Me.btnClear_n_b_a.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(148, 257)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(90, 23)
        Me.btnCalcular.TabIndex = 21
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnClearAll
        '
        Me.btnClearAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.Location = New System.Drawing.Point(244, 257)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(128, 23)
        Me.btnClearAll.TabIndex = 22
        Me.btnClearAll.Text = "LIMPIAR TODO"
        Me.btnClearAll.UseVisualStyleBackColor = True
        '
        'errSintaxisTxt
        '
        Me.errSintaxisTxt.ContainerControl = Me
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(377, 287)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnClear_n_b_a)
        Me.Controls.Add(Me.btnClearFb)
        Me.Controls.Add(Me.btnAddFa)
        Me.Controls.Add(Me.btnClearFa)
        Me.Controls.Add(Me.btnAddFb)
        Me.Controls.Add(Me.btnClearCPIb)
        Me.Controls.Add(Me.btnAddCPIa)
        Me.Controls.Add(Me.btnClearCPIa)
        Me.Controls.Add(Me.btnAddCPIb)
        Me.Controls.Add(Me.btnClearNb)
        Me.Controls.Add(Me.btnAddNa)
        Me.Controls.Add(Me.btnClearNa)
        Me.Controls.Add(Me.btnAddNb)
        Me.Controls.Add(Me.txt_n_b_a)
        Me.Controls.Add(Me.txtFb)
        Me.Controls.Add(Me.txtFa)
        Me.Controls.Add(Me.txtCPIb)
        Me.Controls.Add(Me.txtCPIa)
        Me.Controls.Add(Me.txtNb)
        Me.Controls.Add(Me.txtNa)
        Me.Controls.Add(Me.lbl_n_b_a)
        Me.Controls.Add(Me.lblFb)
        Me.Controls.Add(Me.lblFa)
        Me.Controls.Add(Me.lblCPIb)
        Me.Controls.Add(Me.lblCPIa)
        Me.Controls.Add(Me.lblNb)
        Me.Controls.Add(Me.lblNA)
        Me.Controls.Add(Me.lblTitulo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 325)
        Me.MinimumSize = New System.Drawing.Size(393, 325)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora de Rendimiento"
        CType(Me.errSintaxisTxt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblNA As System.Windows.Forms.Label
    Friend WithEvents lblNb As System.Windows.Forms.Label
    Friend WithEvents lblCPIa As System.Windows.Forms.Label
    Friend WithEvents lblCPIb As System.Windows.Forms.Label
    Friend WithEvents lblFa As System.Windows.Forms.Label
    Friend WithEvents lblFb As System.Windows.Forms.Label
    Friend WithEvents lbl_n_b_a As System.Windows.Forms.Label
    Friend WithEvents txtNa As System.Windows.Forms.TextBox
    Friend WithEvents txtNb As System.Windows.Forms.TextBox
    Friend WithEvents txtCPIa As System.Windows.Forms.TextBox
    Friend WithEvents txtCPIb As System.Windows.Forms.TextBox
    Friend WithEvents txtFa As System.Windows.Forms.TextBox
    Friend WithEvents txtFb As System.Windows.Forms.TextBox
    Friend WithEvents txt_n_b_a As System.Windows.Forms.TextBox
    Friend WithEvents btnAddNb As System.Windows.Forms.Button
    Friend WithEvents btnClearNa As System.Windows.Forms.Button
    Friend WithEvents btnClearNb As System.Windows.Forms.Button
    Friend WithEvents btnAddNa As System.Windows.Forms.Button
    Friend WithEvents btnClearCPIa As System.Windows.Forms.Button
    Friend WithEvents btnAddCPIb As System.Windows.Forms.Button
    Friend WithEvents btnClearCPIb As System.Windows.Forms.Button
    Friend WithEvents btnAddCPIa As System.Windows.Forms.Button
    Friend WithEvents btnClearFa As System.Windows.Forms.Button
    Friend WithEvents btnAddFb As System.Windows.Forms.Button
    Friend WithEvents btnClearFb As System.Windows.Forms.Button
    Friend WithEvents btnAddFa As System.Windows.Forms.Button
    Friend WithEvents btnClear_n_b_a As System.Windows.Forms.Button
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents errSintaxisTxt As System.Windows.Forms.ErrorProvider

End Class
