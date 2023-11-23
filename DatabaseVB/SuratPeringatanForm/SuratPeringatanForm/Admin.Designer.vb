<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Admin))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        InputSPLNIM = New TextBox()
        InputSPLNama = New TextBox()
        InputSPLKelas = New TextBox()
        InputSPLAlasan = New TextBox()
        SPLKirim = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        InputSPLPelapor = New TextBox()
        InputSPTNIM = New TextBox()
        Label9 = New Label()
        InputSPTNama = New TextBox()
        Label10 = New Label()
        Label11 = New Label()
        InputSPTKelas = New TextBox()
        Label12 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        SPTKirim = New Button()
        InputSPLDate = New DateTimePicker()
        InputSPTDate = New DateTimePicker()
        Label13 = New Label()
        Label16 = New Label()
        InputSPTAlasan = New TextBox()
        InputSPTPelapor = New TextBox()
        DataGridView1 = New DataGridView()
        DataGridView2 = New DataGridView()
        SPLHapus = New Button()
        SPTHapus = New Button()
        HomeButton = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 27)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 23)
        Label1.TabIndex = 0
        Label1.Text = "Menambahkan SP Lisan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 76)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 23)
        Label2.TabIndex = 1
        Label2.Text = "NIM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 109)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 23)
        Label3.TabIndex = 2
        Label3.Text = "Nama"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 145)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 23)
        Label4.TabIndex = 3
        Label4.Text = "Kelas"
        ' 
        ' InputSPLNIM
        ' 
        InputSPLNIM.Location = New Point(107, 68)
        InputSPLNIM.Margin = New Padding(4, 3, 4, 3)
        InputSPLNIM.Name = "InputSPLNIM"
        InputSPLNIM.Size = New Size(278, 29)
        InputSPLNIM.TabIndex = 4
        ' 
        ' InputSPLNama
        ' 
        InputSPLNama.Location = New Point(107, 102)
        InputSPLNama.Margin = New Padding(4, 3, 4, 3)
        InputSPLNama.Name = "InputSPLNama"
        InputSPLNama.Size = New Size(278, 29)
        InputSPLNama.TabIndex = 5
        ' 
        ' InputSPLKelas
        ' 
        InputSPLKelas.Location = New Point(107, 136)
        InputSPLKelas.Margin = New Padding(4, 3, 4, 3)
        InputSPLKelas.Name = "InputSPLKelas"
        InputSPLKelas.Size = New Size(278, 29)
        InputSPLKelas.TabIndex = 6
        ' 
        ' InputSPLAlasan
        ' 
        InputSPLAlasan.Location = New Point(107, 204)
        InputSPLAlasan.Margin = New Padding(4, 3, 4, 3)
        InputSPLAlasan.Name = "InputSPLAlasan"
        InputSPLAlasan.Size = New Size(278, 29)
        InputSPLAlasan.TabIndex = 7
        ' 
        ' SPLKirim
        ' 
        SPLKirim.Location = New Point(107, 287)
        SPLKirim.Margin = New Padding(4, 3, 4, 3)
        SPLKirim.Name = "SPLKirim"
        SPLKirim.Size = New Size(88, 31)
        SPLKirim.TabIndex = 8
        SPLKirim.Text = "Kirim"
        SPLKirim.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(31, 179)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 23)
        Label5.TabIndex = 9
        Label5.Text = "Tanggal"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(31, 213)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 23)
        Label6.TabIndex = 10
        Label6.Text = "Alasan"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(873, 27)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(187, 23)
        Label7.TabIndex = 11
        Label7.Text = "Menambahkan SP Tulis"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(31, 254)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(67, 23)
        Label8.TabIndex = 12
        Label8.Text = "Pelapor"
        ' 
        ' InputSPLPelapor
        ' 
        InputSPLPelapor.Location = New Point(107, 246)
        InputSPLPelapor.Margin = New Padding(4, 3, 4, 3)
        InputSPLPelapor.Name = "InputSPLPelapor"
        InputSPLPelapor.Size = New Size(278, 29)
        InputSPLPelapor.TabIndex = 14
        ' 
        ' InputSPTNIM
        ' 
        InputSPTNIM.Location = New Point(947, 67)
        InputSPTNIM.Margin = New Padding(4, 3, 4, 3)
        InputSPTNIM.Name = "InputSPTNIM"
        InputSPTNIM.Size = New Size(280, 29)
        InputSPTNIM.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(873, 76)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(43, 23)
        Label9.TabIndex = 16
        Label9.Text = "NIM"
        ' 
        ' InputSPTNama
        ' 
        InputSPTNama.Location = New Point(947, 101)
        InputSPTNama.Margin = New Padding(4, 3, 4, 3)
        InputSPTNama.Name = "InputSPTNama"
        InputSPTNama.Size = New Size(280, 29)
        InputSPTNama.TabIndex = 18
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(873, 105)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(56, 23)
        Label10.TabIndex = 19
        Label10.Text = "Nama"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(873, 145)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(49, 23)
        Label11.TabIndex = 20
        Label11.Text = "Kelas"
        ' 
        ' InputSPTKelas
        ' 
        InputSPTKelas.Location = New Point(947, 136)
        InputSPTKelas.Margin = New Padding(4, 3, 4, 3)
        InputSPTKelas.Name = "InputSPTKelas"
        InputSPTKelas.Size = New Size(280, 29)
        InputSPTKelas.TabIndex = 21
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(873, 179)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(69, 23)
        Label12.TabIndex = 22
        Label12.Text = "Tanggal"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(200, 554)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(0, 23)
        Label14.TabIndex = 26
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(200, 589)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(0, 23)
        Label15.TabIndex = 28
        ' 
        ' SPTKirim
        ' 
        SPTKirim.Location = New Point(947, 287)
        SPTKirim.Margin = New Padding(4, 3, 4, 3)
        SPTKirim.Name = "SPTKirim"
        SPTKirim.Size = New Size(91, 31)
        SPTKirim.TabIndex = 29
        SPTKirim.Text = "Kirim"
        SPTKirim.UseVisualStyleBackColor = True
        ' 
        ' InputSPLDate
        ' 
        InputSPLDate.Location = New Point(107, 170)
        InputSPLDate.Margin = New Padding(4, 3, 4, 3)
        InputSPLDate.MaxDate = New Date(2023, 11, 21, 0, 0, 0, 0)
        InputSPLDate.Name = "InputSPLDate"
        InputSPLDate.RightToLeft = RightToLeft.No
        InputSPLDate.Size = New Size(278, 29)
        InputSPLDate.TabIndex = 30
        InputSPLDate.Value = New Date(2023, 11, 21, 0, 0, 0, 0)
        ' 
        ' InputSPTDate
        ' 
        InputSPTDate.Location = New Point(947, 173)
        InputSPTDate.Margin = New Padding(4, 3, 4, 3)
        InputSPTDate.MaxDate = New Date(2023, 11, 21, 0, 0, 0, 0)
        InputSPTDate.Name = "InputSPTDate"
        InputSPTDate.Size = New Size(280, 29)
        InputSPTDate.TabIndex = 31
        InputSPTDate.Value = New Date(2023, 11, 21, 0, 0, 0, 0)
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(873, 218)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(60, 23)
        Label13.TabIndex = 32
        Label13.Text = "Alasan"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(873, 254)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(67, 23)
        Label16.TabIndex = 33
        Label16.Text = "Pelapor"
        ' 
        ' InputSPTAlasan
        ' 
        InputSPTAlasan.Location = New Point(947, 211)
        InputSPTAlasan.Margin = New Padding(4, 3, 4, 3)
        InputSPTAlasan.Name = "InputSPTAlasan"
        InputSPTAlasan.Size = New Size(280, 29)
        InputSPTAlasan.TabIndex = 34
        ' 
        ' InputSPTPelapor
        ' 
        InputSPTPelapor.Location = New Point(947, 246)
        InputSPTPelapor.Margin = New Padding(4, 3, 4, 3)
        InputSPTPelapor.Name = "InputSPTPelapor"
        InputSPTPelapor.Size = New Size(280, 29)
        InputSPTPelapor.TabIndex = 35
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(34, 351)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(674, 201)
        DataGridView1.TabIndex = 38
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(876, 351)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(670, 201)
        DataGridView2.TabIndex = 39
        ' 
        ' SPLHapus
        ' 
        SPLHapus.Location = New Point(297, 287)
        SPLHapus.Name = "SPLHapus"
        SPLHapus.Size = New Size(88, 31)
        SPLHapus.TabIndex = 40
        SPLHapus.Text = "Hapus"
        SPLHapus.UseVisualStyleBackColor = True
        ' 
        ' SPTHapus
        ' 
        SPTHapus.Location = New Point(1136, 287)
        SPTHapus.Name = "SPTHapus"
        SPTHapus.Size = New Size(91, 31)
        SPTHapus.TabIndex = 43
        SPTHapus.Text = "Hapus"
        SPTHapus.UseVisualStyleBackColor = True
        ' 
        ' HomeButton
        ' 
        HomeButton.Location = New Point(1247, 583)
        HomeButton.Name = "HomeButton"
        HomeButton.Size = New Size(172, 29)
        HomeButton.TabIndex = 44
        HomeButton.Text = "Home Admin"
        HomeButton.UseVisualStyleBackColor = True
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1582, 853)
        Controls.Add(HomeButton)
        Controls.Add(SPTHapus)
        Controls.Add(SPLHapus)
        Controls.Add(DataGridView2)
        Controls.Add(DataGridView1)
        Controls.Add(InputSPTPelapor)
        Controls.Add(InputSPTAlasan)
        Controls.Add(Label16)
        Controls.Add(Label13)
        Controls.Add(InputSPTDate)
        Controls.Add(InputSPLDate)
        Controls.Add(SPTKirim)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label12)
        Controls.Add(InputSPTKelas)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(InputSPTNama)
        Controls.Add(Label9)
        Controls.Add(InputSPTNIM)
        Controls.Add(InputSPLPelapor)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(SPLKirim)
        Controls.Add(InputSPLAlasan)
        Controls.Add(InputSPLKelas)
        Controls.Add(InputSPLNama)
        Controls.Add(InputSPLNIM)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents InputSPLNIM As TextBox
    Friend WithEvents InputSPLNama As TextBox
    Friend WithEvents InputSPLKelas As TextBox
    Friend WithEvents InputSPLAlasan As TextBox
    Friend WithEvents SPLKirim As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents InputSPLPelapor As TextBox
    Friend WithEvents InputSPTNIM As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents InputSPTNama As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents InputSPTKelas As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents SPTKirim As Button
    Friend WithEvents InputSPLDate As DateTimePicker
    Friend WithEvents InputSPTDate As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents InputSPTAlasan As TextBox
    Friend WithEvents InputSPTPelapor As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents SPLHapus As Button
    Friend WithEvents SPTHapus As Button
    Friend WithEvents HomeButton As Button
End Class
