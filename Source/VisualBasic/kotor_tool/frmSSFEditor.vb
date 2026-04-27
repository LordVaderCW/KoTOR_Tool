Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace kotor_tool
	' Token: 0x02000076 RID: 118
	Public Partial Class frmSSFEditor
		Inherits frmParent

		' Token: 0x06000F1B RID: 3867 RVA: 0x00292A20 File Offset: 0x00291A20
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.frmSSFEditor_Load
			Me.InitializeComponent()
			Me.CurrentSettings = UserSettings.GetSettings()
			Me.KotorVersionIndex = -1
		End Sub

		' Token: 0x1700054D RID: 1357
		' (get) Token: 0x06000F1D RID: 3869 RVA: 0x00292A90 File Offset: 0x00291A90
		' (set) Token: 0x06000F1E RID: 3870 RVA: 0x00292A74 File Offset: 0x00291A74
		Friend Overridable Property nudBat1 As NumericUpDown
			Get
				Return Me._nudBat1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudBat1 IsNot Nothing Then
				End If
				Me._nudBat1 = value
				If Me._nudBat1 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700054E RID: 1358
		' (get) Token: 0x06000F1F RID: 3871 RVA: 0x00292AC0 File Offset: 0x00291AC0
		' (set) Token: 0x06000F20 RID: 3872 RVA: 0x00292AA4 File Offset: 0x00291AA4
		Friend Overridable Property tbBat1ResRef As TextBox
			Get
				Return Me._tbBat1ResRef
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._tbBat1ResRef IsNot Nothing Then
				End If
				Me._tbBat1ResRef = value
				If Me._tbBat1ResRef IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700054F RID: 1359
		' (get) Token: 0x06000F22 RID: 3874 RVA: 0x00292AD4 File Offset: 0x00291AD4
		' (set) Token: 0x06000F21 RID: 3873 RVA: 0x00292AE8 File Offset: 0x00291AE8
		Friend Overridable Property tbBat1Desc As TextBox
			Get
				Return Me._tbBat1Desc
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._tbBat1Desc IsNot Nothing Then
				End If
				Me._tbBat1Desc = value
				If Me._tbBat1Desc IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000550 RID: 1360
		' (get) Token: 0x06000F24 RID: 3876 RVA: 0x00292B20 File Offset: 0x00291B20
		' (set) Token: 0x06000F23 RID: 3875 RVA: 0x00292B04 File Offset: 0x00291B04
		Friend Overridable Property Label1 As Label
			Get
				Return Me._Label1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label1 IsNot Nothing Then
				End If
				Me._Label1 = value
				If Me._Label1 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000551 RID: 1361
		' (get) Token: 0x06000F25 RID: 3877 RVA: 0x00292B50 File Offset: 0x00291B50
		' (set) Token: 0x06000F26 RID: 3878 RVA: 0x00292B34 File Offset: 0x00291B34
		Friend Overridable Property TextBox1 As TextBox
			Get
				Return Me._TextBox1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox1 IsNot Nothing Then
				End If
				Me._TextBox1 = value
				If Me._TextBox1 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000552 RID: 1362
		' (get) Token: 0x06000F27 RID: 3879 RVA: 0x00292B64 File Offset: 0x00291B64
		' (set) Token: 0x06000F28 RID: 3880 RVA: 0x00292B78 File Offset: 0x00291B78
		Friend Overridable Property TextBox2 As TextBox
			Get
				Return Me._TextBox2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox2 IsNot Nothing Then
				End If
				Me._TextBox2 = value
				If Me._TextBox2 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000553 RID: 1363
		' (get) Token: 0x06000F29 RID: 3881 RVA: 0x00292B94 File Offset: 0x00291B94
		' (set) Token: 0x06000F2A RID: 3882 RVA: 0x00292BA8 File Offset: 0x00291BA8
		Friend Overridable Property Label2 As Label
			Get
				Return Me._Label2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label2 IsNot Nothing Then
				End If
				Me._Label2 = value
				If Me._Label2 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000554 RID: 1364
		' (get) Token: 0x06000F2C RID: 3884 RVA: 0x00292BC4 File Offset: 0x00291BC4
		' (set) Token: 0x06000F2B RID: 3883 RVA: 0x00292BD8 File Offset: 0x00291BD8
		Friend Overridable Property TextBox3 As TextBox
			Get
				Return Me._TextBox3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox3 IsNot Nothing Then
				End If
				Me._TextBox3 = value
				If Me._TextBox3 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000555 RID: 1365
		' (get) Token: 0x06000F2E RID: 3886 RVA: 0x00292C10 File Offset: 0x00291C10
		' (set) Token: 0x06000F2D RID: 3885 RVA: 0x00292BF4 File Offset: 0x00291BF4
		Friend Overridable Property TextBox4 As TextBox
			Get
				Return Me._TextBox4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox4 IsNot Nothing Then
				End If
				Me._TextBox4 = value
				If Me._TextBox4 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000556 RID: 1366
		' (get) Token: 0x06000F2F RID: 3887 RVA: 0x00292C24 File Offset: 0x00291C24
		' (set) Token: 0x06000F30 RID: 3888 RVA: 0x00292C38 File Offset: 0x00291C38
		Friend Overridable Property Label3 As Label
			Get
				Return Me._Label3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label3 IsNot Nothing Then
				End If
				Me._Label3 = value
				If Me._Label3 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000557 RID: 1367
		' (get) Token: 0x06000F32 RID: 3890 RVA: 0x00292C54 File Offset: 0x00291C54
		' (set) Token: 0x06000F31 RID: 3889 RVA: 0x00292C68 File Offset: 0x00291C68
		Friend Overridable Property TextBox5 As TextBox
			Get
				Return Me._TextBox5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox5 IsNot Nothing Then
				End If
				Me._TextBox5 = value
				If Me._TextBox5 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000558 RID: 1368
		' (get) Token: 0x06000F34 RID: 3892 RVA: 0x00292CA0 File Offset: 0x00291CA0
		' (set) Token: 0x06000F33 RID: 3891 RVA: 0x00292C84 File Offset: 0x00291C84
		Friend Overridable Property TextBox6 As TextBox
			Get
				Return Me._TextBox6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox6 IsNot Nothing Then
				End If
				Me._TextBox6 = value
				If Me._TextBox6 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000559 RID: 1369
		' (get) Token: 0x06000F35 RID: 3893 RVA: 0x00292CB4 File Offset: 0x00291CB4
		' (set) Token: 0x06000F36 RID: 3894 RVA: 0x00292CC8 File Offset: 0x00291CC8
		Friend Overridable Property Label4 As Label
			Get
				Return Me._Label4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label4 IsNot Nothing Then
				End If
				Me._Label4 = value
				If Me._Label4 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700055A RID: 1370
		' (get) Token: 0x06000F38 RID: 3896 RVA: 0x00292CE4 File Offset: 0x00291CE4
		' (set) Token: 0x06000F37 RID: 3895 RVA: 0x00292CF8 File Offset: 0x00291CF8
		Friend Overridable Property Panel1 As Panel
			Get
				Return Me._Panel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				If Me._Panel1 IsNot Nothing Then
				End If
				Me._Panel1 = value
				If Me._Panel1 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700055B RID: 1371
		' (get) Token: 0x06000F39 RID: 3897 RVA: 0x00292D14 File Offset: 0x00291D14
		' (set) Token: 0x06000F3A RID: 3898 RVA: 0x00292D28 File Offset: 0x00291D28
		Friend Overridable Property Label5 As Label
			Get
				Return Me._Label5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label5 IsNot Nothing Then
				End If
				Me._Label5 = value
				If Me._Label5 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700055C RID: 1372
		' (get) Token: 0x06000F3B RID: 3899 RVA: 0x00292D44 File Offset: 0x00291D44
		' (set) Token: 0x06000F3C RID: 3900 RVA: 0x00292D58 File Offset: 0x00291D58
		Friend Overridable Property TextBox7 As TextBox
			Get
				Return Me._TextBox7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox7 IsNot Nothing Then
				End If
				Me._TextBox7 = value
				If Me._TextBox7 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700055D RID: 1373
		' (get) Token: 0x06000F3D RID: 3901 RVA: 0x00292D74 File Offset: 0x00291D74
		' (set) Token: 0x06000F3E RID: 3902 RVA: 0x00292D88 File Offset: 0x00291D88
		Friend Overridable Property TextBox8 As TextBox
			Get
				Return Me._TextBox8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox8 IsNot Nothing Then
				End If
				Me._TextBox8 = value
				If Me._TextBox8 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700055E RID: 1374
		' (get) Token: 0x06000F3F RID: 3903 RVA: 0x00292DC0 File Offset: 0x00291DC0
		' (set) Token: 0x06000F40 RID: 3904 RVA: 0x00292DA4 File Offset: 0x00291DA4
		Friend Overridable Property TextBox9 As TextBox
			Get
				Return Me._TextBox9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox9 IsNot Nothing Then
				End If
				Me._TextBox9 = value
				If Me._TextBox9 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700055F RID: 1375
		' (get) Token: 0x06000F41 RID: 3905 RVA: 0x00292DD4 File Offset: 0x00291DD4
		' (set) Token: 0x06000F42 RID: 3906 RVA: 0x00292DE8 File Offset: 0x00291DE8
		Friend Overridable Property Label6 As Label
			Get
				Return Me._Label6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label6 IsNot Nothing Then
				End If
				Me._Label6 = value
				If Me._Label6 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000560 RID: 1376
		' (get) Token: 0x06000F43 RID: 3907 RVA: 0x00292E04 File Offset: 0x00291E04
		' (set) Token: 0x06000F44 RID: 3908 RVA: 0x00292E18 File Offset: 0x00291E18
		Friend Overridable Property TextBox10 As TextBox
			Get
				Return Me._TextBox10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox10 IsNot Nothing Then
				End If
				Me._TextBox10 = value
				If Me._TextBox10 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000561 RID: 1377
		' (get) Token: 0x06000F45 RID: 3909 RVA: 0x00292E50 File Offset: 0x00291E50
		' (set) Token: 0x06000F46 RID: 3910 RVA: 0x00292E34 File Offset: 0x00291E34
		Friend Overridable Property TextBox11 As TextBox
			Get
				Return Me._TextBox11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox11 IsNot Nothing Then
				End If
				Me._TextBox11 = value
				If Me._TextBox11 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000562 RID: 1378
		' (get) Token: 0x06000F47 RID: 3911 RVA: 0x00292E64 File Offset: 0x00291E64
		' (set) Token: 0x06000F48 RID: 3912 RVA: 0x00292E78 File Offset: 0x00291E78
		Friend Overridable Property TextBox12 As TextBox
			Get
				Return Me._TextBox12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox12 IsNot Nothing Then
				End If
				Me._TextBox12 = value
				If Me._TextBox12 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000563 RID: 1379
		' (get) Token: 0x06000F49 RID: 3913 RVA: 0x00292E94 File Offset: 0x00291E94
		' (set) Token: 0x06000F4A RID: 3914 RVA: 0x00292EA8 File Offset: 0x00291EA8
		Friend Overridable Property TextBox13 As TextBox
			Get
				Return Me._TextBox13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox13 IsNot Nothing Then
				End If
				Me._TextBox13 = value
				If Me._TextBox13 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000564 RID: 1380
		' (get) Token: 0x06000F4B RID: 3915 RVA: 0x00292EC4 File Offset: 0x00291EC4
		' (set) Token: 0x06000F4C RID: 3916 RVA: 0x00292ED8 File Offset: 0x00291ED8
		Friend Overridable Property TextBox14 As TextBox
			Get
				Return Me._TextBox14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox14 IsNot Nothing Then
				End If
				Me._TextBox14 = value
				If Me._TextBox14 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000565 RID: 1381
		' (get) Token: 0x06000F4E RID: 3918 RVA: 0x00292F10 File Offset: 0x00291F10
		' (set) Token: 0x06000F4D RID: 3917 RVA: 0x00292EF4 File Offset: 0x00291EF4
		Friend Overridable Property Label7 As Label
			Get
				Return Me._Label7
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label7 IsNot Nothing Then
				End If
				Me._Label7 = value
				If Me._Label7 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000566 RID: 1382
		' (get) Token: 0x06000F4F RID: 3919 RVA: 0x00292F40 File Offset: 0x00291F40
		' (set) Token: 0x06000F50 RID: 3920 RVA: 0x00292F24 File Offset: 0x00291F24
		Friend Overridable Property TextBox15 As TextBox
			Get
				Return Me._TextBox15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox15 IsNot Nothing Then
				End If
				Me._TextBox15 = value
				If Me._TextBox15 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000567 RID: 1383
		' (get) Token: 0x06000F51 RID: 3921 RVA: 0x00292F54 File Offset: 0x00291F54
		' (set) Token: 0x06000F52 RID: 3922 RVA: 0x00292F68 File Offset: 0x00291F68
		Friend Overridable Property TextBox16 As TextBox
			Get
				Return Me._TextBox16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox16 IsNot Nothing Then
				End If
				Me._TextBox16 = value
				If Me._TextBox16 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000568 RID: 1384
		' (get) Token: 0x06000F53 RID: 3923 RVA: 0x00292FA0 File Offset: 0x00291FA0
		' (set) Token: 0x06000F54 RID: 3924 RVA: 0x00292F84 File Offset: 0x00291F84
		Friend Overridable Property Label8 As Label
			Get
				Return Me._Label8
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label8 IsNot Nothing Then
				End If
				Me._Label8 = value
				If Me._Label8 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000569 RID: 1385
		' (get) Token: 0x06000F56 RID: 3926 RVA: 0x00292FB4 File Offset: 0x00291FB4
		' (set) Token: 0x06000F55 RID: 3925 RVA: 0x00292FC8 File Offset: 0x00291FC8
		Friend Overridable Property Label9 As Label
			Get
				Return Me._Label9
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label9 IsNot Nothing Then
				End If
				Me._Label9 = value
				If Me._Label9 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700056A RID: 1386
		' (get) Token: 0x06000F57 RID: 3927 RVA: 0x00292FE4 File Offset: 0x00291FE4
		' (set) Token: 0x06000F58 RID: 3928 RVA: 0x00292FF8 File Offset: 0x00291FF8
		Friend Overridable Property TextBox17 As TextBox
			Get
				Return Me._TextBox17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox17 IsNot Nothing Then
				End If
				Me._TextBox17 = value
				If Me._TextBox17 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700056B RID: 1387
		' (get) Token: 0x06000F5A RID: 3930 RVA: 0x00293014 File Offset: 0x00292014
		' (set) Token: 0x06000F59 RID: 3929 RVA: 0x00293028 File Offset: 0x00292028
		Friend Overridable Property TextBox18 As TextBox
			Get
				Return Me._TextBox18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox18 IsNot Nothing Then
				End If
				Me._TextBox18 = value
				If Me._TextBox18 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700056C RID: 1388
		' (get) Token: 0x06000F5B RID: 3931 RVA: 0x00293044 File Offset: 0x00292044
		' (set) Token: 0x06000F5C RID: 3932 RVA: 0x00293058 File Offset: 0x00292058
		Friend Overridable Property Label10 As Label
			Get
				Return Me._Label10
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label10 IsNot Nothing Then
				End If
				Me._Label10 = value
				If Me._Label10 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700056D RID: 1389
		' (get) Token: 0x06000F5E RID: 3934 RVA: 0x00293090 File Offset: 0x00292090
		' (set) Token: 0x06000F5D RID: 3933 RVA: 0x00293074 File Offset: 0x00292074
		Friend Overridable Property Label11 As Label
			Get
				Return Me._Label11
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label11 IsNot Nothing Then
				End If
				Me._Label11 = value
				If Me._Label11 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700056E RID: 1390
		' (get) Token: 0x06000F60 RID: 3936 RVA: 0x002930A4 File Offset: 0x002920A4
		' (set) Token: 0x06000F5F RID: 3935 RVA: 0x002930B8 File Offset: 0x002920B8
		Friend Overridable Property TextBox19 As TextBox
			Get
				Return Me._TextBox19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox19 IsNot Nothing Then
				End If
				Me._TextBox19 = value
				If Me._TextBox19 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700056F RID: 1391
		' (get) Token: 0x06000F62 RID: 3938 RVA: 0x002930D4 File Offset: 0x002920D4
		' (set) Token: 0x06000F61 RID: 3937 RVA: 0x002930E8 File Offset: 0x002920E8
		Friend Overridable Property TextBox20 As TextBox
			Get
				Return Me._TextBox20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox20 IsNot Nothing Then
				End If
				Me._TextBox20 = value
				If Me._TextBox20 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000570 RID: 1392
		' (get) Token: 0x06000F63 RID: 3939 RVA: 0x00293104 File Offset: 0x00292104
		' (set) Token: 0x06000F64 RID: 3940 RVA: 0x00293118 File Offset: 0x00292118
		Friend Overridable Property TextBox21 As TextBox
			Get
				Return Me._TextBox21
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox21 IsNot Nothing Then
				End If
				Me._TextBox21 = value
				If Me._TextBox21 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000571 RID: 1393
		' (get) Token: 0x06000F66 RID: 3942 RVA: 0x00293134 File Offset: 0x00292134
		' (set) Token: 0x06000F65 RID: 3941 RVA: 0x00293148 File Offset: 0x00292148
		Friend Overridable Property TextBox22 As TextBox
			Get
				Return Me._TextBox22
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox22 IsNot Nothing Then
				End If
				Me._TextBox22 = value
				If Me._TextBox22 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000572 RID: 1394
		' (get) Token: 0x06000F68 RID: 3944 RVA: 0x00293180 File Offset: 0x00292180
		' (set) Token: 0x06000F67 RID: 3943 RVA: 0x00293164 File Offset: 0x00292164
		Friend Overridable Property Label12 As Label
			Get
				Return Me._Label12
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label12 IsNot Nothing Then
				End If
				Me._Label12 = value
				If Me._Label12 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000573 RID: 1395
		' (get) Token: 0x06000F6A RID: 3946 RVA: 0x002931B0 File Offset: 0x002921B0
		' (set) Token: 0x06000F69 RID: 3945 RVA: 0x00293194 File Offset: 0x00292194
		Friend Overridable Property Label13 As Label
			Get
				Return Me._Label13
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label13 IsNot Nothing Then
				End If
				Me._Label13 = value
				If Me._Label13 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000574 RID: 1396
		' (get) Token: 0x06000F6C RID: 3948 RVA: 0x002931E0 File Offset: 0x002921E0
		' (set) Token: 0x06000F6B RID: 3947 RVA: 0x002931C4 File Offset: 0x002921C4
		Friend Overridable Property Label14 As Label
			Get
				Return Me._Label14
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label14 IsNot Nothing Then
				End If
				Me._Label14 = value
				If Me._Label14 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000575 RID: 1397
		' (get) Token: 0x06000F6E RID: 3950 RVA: 0x002931F4 File Offset: 0x002921F4
		' (set) Token: 0x06000F6D RID: 3949 RVA: 0x00293208 File Offset: 0x00292208
		Friend Overridable Property TextBox23 As TextBox
			Get
				Return Me._TextBox23
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox23 IsNot Nothing Then
				End If
				Me._TextBox23 = value
				If Me._TextBox23 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000576 RID: 1398
		' (get) Token: 0x06000F6F RID: 3951 RVA: 0x00293224 File Offset: 0x00292224
		' (set) Token: 0x06000F70 RID: 3952 RVA: 0x00293238 File Offset: 0x00292238
		Friend Overridable Property TextBox24 As TextBox
			Get
				Return Me._TextBox24
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox24 IsNot Nothing Then
				End If
				Me._TextBox24 = value
				If Me._TextBox24 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000577 RID: 1399
		' (get) Token: 0x06000F71 RID: 3953 RVA: 0x00293270 File Offset: 0x00292270
		' (set) Token: 0x06000F72 RID: 3954 RVA: 0x00293254 File Offset: 0x00292254
		Friend Overridable Property TextBox25 As TextBox
			Get
				Return Me._TextBox25
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox25 IsNot Nothing Then
				End If
				Me._TextBox25 = value
				If Me._TextBox25 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000578 RID: 1400
		' (get) Token: 0x06000F74 RID: 3956 RVA: 0x00293284 File Offset: 0x00292284
		' (set) Token: 0x06000F73 RID: 3955 RVA: 0x00293298 File Offset: 0x00292298
		Friend Overridable Property TextBox26 As TextBox
			Get
				Return Me._TextBox26
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox26 IsNot Nothing Then
				End If
				Me._TextBox26 = value
				If Me._TextBox26 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000579 RID: 1401
		' (get) Token: 0x06000F75 RID: 3957 RVA: 0x002932D0 File Offset: 0x002922D0
		' (set) Token: 0x06000F76 RID: 3958 RVA: 0x002932B4 File Offset: 0x002922B4
		Friend Overridable Property TextBox27 As TextBox
			Get
				Return Me._TextBox27
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox27 IsNot Nothing Then
				End If
				Me._TextBox27 = value
				If Me._TextBox27 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700057A RID: 1402
		' (get) Token: 0x06000F77 RID: 3959 RVA: 0x00293300 File Offset: 0x00292300
		' (set) Token: 0x06000F78 RID: 3960 RVA: 0x002932E4 File Offset: 0x002922E4
		Friend Overridable Property TextBox28 As TextBox
			Get
				Return Me._TextBox28
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox28 IsNot Nothing Then
				End If
				Me._TextBox28 = value
				If Me._TextBox28 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700057B RID: 1403
		' (get) Token: 0x06000F7A RID: 3962 RVA: 0x00293330 File Offset: 0x00292330
		' (set) Token: 0x06000F79 RID: 3961 RVA: 0x00293314 File Offset: 0x00292314
		Friend Overridable Property Label15 As Label
			Get
				Return Me._Label15
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label15 IsNot Nothing Then
				End If
				Me._Label15 = value
				If Me._Label15 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700057C RID: 1404
		' (get) Token: 0x06000F7C RID: 3964 RVA: 0x00293344 File Offset: 0x00292344
		' (set) Token: 0x06000F7B RID: 3963 RVA: 0x00293358 File Offset: 0x00292358
		Friend Overridable Property TextBox29 As TextBox
			Get
				Return Me._TextBox29
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox29 IsNot Nothing Then
				End If
				Me._TextBox29 = value
				If Me._TextBox29 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700057D RID: 1405
		' (get) Token: 0x06000F7D RID: 3965 RVA: 0x00293390 File Offset: 0x00292390
		' (set) Token: 0x06000F7E RID: 3966 RVA: 0x00293374 File Offset: 0x00292374
		Friend Overridable Property TextBox30 As TextBox
			Get
				Return Me._TextBox30
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox30 IsNot Nothing Then
				End If
				Me._TextBox30 = value
				If Me._TextBox30 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700057E RID: 1406
		' (get) Token: 0x06000F7F RID: 3967 RVA: 0x002933C0 File Offset: 0x002923C0
		' (set) Token: 0x06000F80 RID: 3968 RVA: 0x002933A4 File Offset: 0x002923A4
		Friend Overridable Property Label16 As Label
			Get
				Return Me._Label16
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label16 IsNot Nothing Then
				End If
				Me._Label16 = value
				If Me._Label16 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700057F RID: 1407
		' (get) Token: 0x06000F81 RID: 3969 RVA: 0x002933F0 File Offset: 0x002923F0
		' (set) Token: 0x06000F82 RID: 3970 RVA: 0x002933D4 File Offset: 0x002923D4
		Friend Overridable Property TextBox31 As TextBox
			Get
				Return Me._TextBox31
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox31 IsNot Nothing Then
				End If
				Me._TextBox31 = value
				If Me._TextBox31 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000580 RID: 1408
		' (get) Token: 0x06000F84 RID: 3972 RVA: 0x00293420 File Offset: 0x00292420
		' (set) Token: 0x06000F83 RID: 3971 RVA: 0x00293404 File Offset: 0x00292404
		Friend Overridable Property TextBox32 As TextBox
			Get
				Return Me._TextBox32
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox32 IsNot Nothing Then
				End If
				Me._TextBox32 = value
				If Me._TextBox32 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000581 RID: 1409
		' (get) Token: 0x06000F85 RID: 3973 RVA: 0x00293434 File Offset: 0x00292434
		' (set) Token: 0x06000F86 RID: 3974 RVA: 0x00293448 File Offset: 0x00292448
		Friend Overridable Property Label17 As Label
			Get
				Return Me._Label17
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label17 IsNot Nothing Then
				End If
				Me._Label17 = value
				If Me._Label17 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000582 RID: 1410
		' (get) Token: 0x06000F88 RID: 3976 RVA: 0x00293480 File Offset: 0x00292480
		' (set) Token: 0x06000F87 RID: 3975 RVA: 0x00293464 File Offset: 0x00292464
		Friend Overridable Property TextBox33 As TextBox
			Get
				Return Me._TextBox33
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox33 IsNot Nothing Then
				End If
				Me._TextBox33 = value
				If Me._TextBox33 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000583 RID: 1411
		' (get) Token: 0x06000F89 RID: 3977 RVA: 0x00293494 File Offset: 0x00292494
		' (set) Token: 0x06000F8A RID: 3978 RVA: 0x002934A8 File Offset: 0x002924A8
		Friend Overridable Property Label18 As Label
			Get
				Return Me._Label18
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label18 IsNot Nothing Then
				End If
				Me._Label18 = value
				If Me._Label18 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000584 RID: 1412
		' (get) Token: 0x06000F8C RID: 3980 RVA: 0x002934C4 File Offset: 0x002924C4
		' (set) Token: 0x06000F8B RID: 3979 RVA: 0x002934D8 File Offset: 0x002924D8
		Friend Overridable Property TextBox34 As TextBox
			Get
				Return Me._TextBox34
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox34 IsNot Nothing Then
				End If
				Me._TextBox34 = value
				If Me._TextBox34 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000585 RID: 1413
		' (get) Token: 0x06000F8D RID: 3981 RVA: 0x002934F4 File Offset: 0x002924F4
		' (set) Token: 0x06000F8E RID: 3982 RVA: 0x00293508 File Offset: 0x00292508
		Friend Overridable Property TextBox35 As TextBox
			Get
				Return Me._TextBox35
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox35 IsNot Nothing Then
				End If
				Me._TextBox35 = value
				If Me._TextBox35 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000586 RID: 1414
		' (get) Token: 0x06000F8F RID: 3983 RVA: 0x00293540 File Offset: 0x00292540
		' (set) Token: 0x06000F90 RID: 3984 RVA: 0x00293524 File Offset: 0x00292524
		Friend Overridable Property TextBox36 As TextBox
			Get
				Return Me._TextBox36
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox36 IsNot Nothing Then
				End If
				Me._TextBox36 = value
				If Me._TextBox36 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000587 RID: 1415
		' (get) Token: 0x06000F92 RID: 3986 RVA: 0x00293554 File Offset: 0x00292554
		' (set) Token: 0x06000F91 RID: 3985 RVA: 0x00293568 File Offset: 0x00292568
		Friend Overridable Property Label19 As Label
			Get
				Return Me._Label19
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label19 IsNot Nothing Then
				End If
				Me._Label19 = value
				If Me._Label19 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000588 RID: 1416
		' (get) Token: 0x06000F94 RID: 3988 RVA: 0x002935A0 File Offset: 0x002925A0
		' (set) Token: 0x06000F93 RID: 3987 RVA: 0x00293584 File Offset: 0x00292584
		Friend Overridable Property TextBox37 As TextBox
			Get
				Return Me._TextBox37
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox37 IsNot Nothing Then
				End If
				Me._TextBox37 = value
				If Me._TextBox37 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000589 RID: 1417
		' (get) Token: 0x06000F95 RID: 3989 RVA: 0x002935D0 File Offset: 0x002925D0
		' (set) Token: 0x06000F96 RID: 3990 RVA: 0x002935B4 File Offset: 0x002925B4
		Friend Overridable Property Label20 As Label
			Get
				Return Me._Label20
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label20 IsNot Nothing Then
				End If
				Me._Label20 = value
				If Me._Label20 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700058A RID: 1418
		' (get) Token: 0x06000F97 RID: 3991 RVA: 0x002935E4 File Offset: 0x002925E4
		' (set) Token: 0x06000F98 RID: 3992 RVA: 0x002935F8 File Offset: 0x002925F8
		Friend Overridable Property TextBox38 As TextBox
			Get
				Return Me._TextBox38
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox38 IsNot Nothing Then
				End If
				Me._TextBox38 = value
				If Me._TextBox38 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700058B RID: 1419
		' (get) Token: 0x06000F99 RID: 3993 RVA: 0x00293614 File Offset: 0x00292614
		' (set) Token: 0x06000F9A RID: 3994 RVA: 0x00293628 File Offset: 0x00292628
		Friend Overridable Property nudBat2 As NumericUpDown
			Get
				Return Me._nudBat2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudBat2 IsNot Nothing Then
				End If
				Me._nudBat2 = value
				If Me._nudBat2 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700058C RID: 1420
		' (get) Token: 0x06000F9B RID: 3995 RVA: 0x00293660 File Offset: 0x00292660
		' (set) Token: 0x06000F9C RID: 3996 RVA: 0x00293644 File Offset: 0x00292644
		Friend Overridable Property nudBat3 As NumericUpDown
			Get
				Return Me._nudBat3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudBat3 IsNot Nothing Then
				End If
				Me._nudBat3 = value
				If Me._nudBat3 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700058D RID: 1421
		' (get) Token: 0x06000F9D RID: 3997 RVA: 0x00293674 File Offset: 0x00292674
		' (set) Token: 0x06000F9E RID: 3998 RVA: 0x00293688 File Offset: 0x00292688
		Friend Overridable Property nudBat4 As NumericUpDown
			Get
				Return Me._nudBat4
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudBat4 IsNot Nothing Then
				End If
				Me._nudBat4 = value
				If Me._nudBat4 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700058E RID: 1422
		' (get) Token: 0x06000FA0 RID: 4000 RVA: 0x002936A4 File Offset: 0x002926A4
		' (set) Token: 0x06000F9F RID: 3999 RVA: 0x002936B8 File Offset: 0x002926B8
		Friend Overridable Property nudBat5 As NumericUpDown
			Get
				Return Me._nudBat5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudBat5 IsNot Nothing Then
				End If
				Me._nudBat5 = value
				If Me._nudBat5 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700058F RID: 1423
		' (get) Token: 0x06000FA1 RID: 4001 RVA: 0x002936D4 File Offset: 0x002926D4
		' (set) Token: 0x06000FA2 RID: 4002 RVA: 0x002936E8 File Offset: 0x002926E8
		Friend Overridable Property nudBat6 As NumericUpDown
			Get
				Return Me._nudBat6
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudBat6 IsNot Nothing Then
				End If
				Me._nudBat6 = value
				If Me._nudBat6 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000590 RID: 1424
		' (get) Token: 0x06000FA3 RID: 4003 RVA: 0x00293704 File Offset: 0x00292704
		' (set) Token: 0x06000FA4 RID: 4004 RVA: 0x00293718 File Offset: 0x00292718
		Friend Overridable Property nudSel1 As NumericUpDown
			Get
				Return Me._nudSel1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudSel1 IsNot Nothing Then
				End If
				Me._nudSel1 = value
				If Me._nudSel1 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000591 RID: 1425
		' (get) Token: 0x06000FA5 RID: 4005 RVA: 0x00293734 File Offset: 0x00292734
		' (set) Token: 0x06000FA6 RID: 4006 RVA: 0x00293748 File Offset: 0x00292748
		Friend Overridable Property nudSel3 As NumericUpDown
			Get
				Return Me._nudSel3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudSel3 IsNot Nothing Then
				End If
				Me._nudSel3 = value
				If Me._nudSel3 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000592 RID: 1426
		' (get) Token: 0x06000FA8 RID: 4008 RVA: 0x00293780 File Offset: 0x00292780
		' (set) Token: 0x06000FA7 RID: 4007 RVA: 0x00293764 File Offset: 0x00292764
		Friend Overridable Property nudSel2 As NumericUpDown
			Get
				Return Me._nudSel2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudSel2 IsNot Nothing Then
				End If
				Me._nudSel2 = value
				If Me._nudSel2 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000593 RID: 1427
		' (get) Token: 0x06000FA9 RID: 4009 RVA: 0x00293794 File Offset: 0x00292794
		' (set) Token: 0x06000FAA RID: 4010 RVA: 0x002937A8 File Offset: 0x002927A8
		Friend Overridable Property nudAtk2 As NumericUpDown
			Get
				Return Me._nudAtk2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudAtk2 IsNot Nothing Then
				End If
				Me._nudAtk2 = value
				If Me._nudAtk2 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000594 RID: 1428
		' (get) Token: 0x06000FAB RID: 4011 RVA: 0x002937C4 File Offset: 0x002927C4
		' (set) Token: 0x06000FAC RID: 4012 RVA: 0x002937D8 File Offset: 0x002927D8
		Friend Overridable Property nudAtk1 As NumericUpDown
			Get
				Return Me._nudAtk1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudAtk1 IsNot Nothing Then
				End If
				Me._nudAtk1 = value
				If Me._nudAtk1 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000595 RID: 1429
		' (get) Token: 0x06000FAD RID: 4013 RVA: 0x00293810 File Offset: 0x00292810
		' (set) Token: 0x06000FAE RID: 4014 RVA: 0x002937F4 File Offset: 0x002927F4
		Friend Overridable Property nudAtk3 As NumericUpDown
			Get
				Return Me._nudAtk3
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudAtk3 IsNot Nothing Then
				End If
				Me._nudAtk3 = value
				If Me._nudAtk3 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000596 RID: 1430
		' (get) Token: 0x06000FAF RID: 4015 RVA: 0x00293840 File Offset: 0x00292840
		' (set) Token: 0x06000FB0 RID: 4016 RVA: 0x00293824 File Offset: 0x00292824
		Friend Overridable Property nudHit2 As NumericUpDown
			Get
				Return Me._nudHit2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudHit2 IsNot Nothing Then
				End If
				Me._nudHit2 = value
				If Me._nudHit2 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000597 RID: 1431
		' (get) Token: 0x06000FB1 RID: 4017 RVA: 0x00293854 File Offset: 0x00292854
		' (set) Token: 0x06000FB2 RID: 4018 RVA: 0x00293868 File Offset: 0x00292868
		Friend Overridable Property nudHit1 As NumericUpDown
			Get
				Return Me._nudHit1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudHit1 IsNot Nothing Then
				End If
				Me._nudHit1 = value
				If Me._nudHit1 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000598 RID: 1432
		' (get) Token: 0x06000FB3 RID: 4019 RVA: 0x00293884 File Offset: 0x00292884
		' (set) Token: 0x06000FB4 RID: 4020 RVA: 0x00293898 File Offset: 0x00292898
		Friend Overridable Property nudDead As NumericUpDown
			Get
				Return Me._nudDead
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudDead IsNot Nothing Then
				End If
				Me._nudDead = value
				If Me._nudDead IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x17000599 RID: 1433
		' (get) Token: 0x06000FB6 RID: 4022 RVA: 0x002938B4 File Offset: 0x002928B4
		' (set) Token: 0x06000FB5 RID: 4021 RVA: 0x002938C8 File Offset: 0x002928C8
		Friend Overridable Property nudLowHlth As NumericUpDown
			Get
				Return Me._nudLowHlth
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudLowHlth IsNot Nothing Then
				End If
				Me._nudLowHlth = value
				If Me._nudLowHlth IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700059A RID: 1434
		' (get) Token: 0x06000FB7 RID: 4023 RVA: 0x002938E4 File Offset: 0x002928E4
		' (set) Token: 0x06000FB8 RID: 4024 RVA: 0x002938F8 File Offset: 0x002928F8
		Friend Overridable Property nudCrit As NumericUpDown
			Get
				Return Me._nudCrit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudCrit IsNot Nothing Then
				End If
				Me._nudCrit = value
				If Me._nudCrit IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700059B RID: 1435
		' (get) Token: 0x06000FB9 RID: 4025 RVA: 0x00293914 File Offset: 0x00292914
		' (set) Token: 0x06000FBA RID: 4026 RVA: 0x00293928 File Offset: 0x00292928
		Friend Overridable Property nudTIA As NumericUpDown
			Get
				Return Me._nudTIA
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudTIA IsNot Nothing Then
				End If
				Me._nudTIA = value
				If Me._nudTIA IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700059C RID: 1436
		' (get) Token: 0x06000FBB RID: 4027 RVA: 0x00293944 File Offset: 0x00292944
		' (set) Token: 0x06000FBC RID: 4028 RVA: 0x00293958 File Offset: 0x00292958
		Friend Overridable Property nudLMin As NumericUpDown
			Get
				Return Me._nudLMin
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudLMin IsNot Nothing Then
				End If
				Me._nudLMin = value
				If Me._nudLMin IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700059D RID: 1437
		' (get) Token: 0x06000FBD RID: 4029 RVA: 0x00293974 File Offset: 0x00292974
		' (set) Token: 0x06000FBE RID: 4030 RVA: 0x00293988 File Offset: 0x00292988
		Friend Overridable Property nudDMin As NumericUpDown
			Get
				Return Me._nudDMin
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudDMin IsNot Nothing Then
				End If
				Me._nudDMin = value
				If Me._nudDMin IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700059E RID: 1438
		' (get) Token: 0x06000FBF RID: 4031 RVA: 0x002939A4 File Offset: 0x002929A4
		' (set) Token: 0x06000FC0 RID: 4032 RVA: 0x002939B8 File Offset: 0x002929B8
		Friend Overridable Property TextBox39 As TextBox
			Get
				Return Me._TextBox39
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox39 IsNot Nothing Then
				End If
				Me._TextBox39 = value
				If Me._TextBox39 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x1700059F RID: 1439
		' (get) Token: 0x06000FC2 RID: 4034 RVA: 0x002939F0 File Offset: 0x002929F0
		' (set) Token: 0x06000FC1 RID: 4033 RVA: 0x002939D4 File Offset: 0x002929D4
		Friend Overridable Property Label21 As Label
			Get
				Return Me._Label21
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label21 IsNot Nothing Then
				End If
				Me._Label21 = value
				If Me._Label21 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005A0 RID: 1440
		' (get) Token: 0x06000FC3 RID: 4035 RVA: 0x00293A04 File Offset: 0x00292A04
		' (set) Token: 0x06000FC4 RID: 4036 RVA: 0x00293A18 File Offset: 0x00292A18
		Friend Overridable Property TextBox40 As TextBox
			Get
				Return Me._TextBox40
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox40 IsNot Nothing Then
				End If
				Me._TextBox40 = value
				If Me._TextBox40 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005A1 RID: 1441
		' (get) Token: 0x06000FC6 RID: 4038 RVA: 0x00293A34 File Offset: 0x00292A34
		' (set) Token: 0x06000FC5 RID: 4037 RVA: 0x00293A48 File Offset: 0x00292A48
		Friend Overridable Property Label22 As Label
			Get
				Return Me._Label22
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label22 IsNot Nothing Then
				End If
				Me._Label22 = value
				If Me._Label22 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005A2 RID: 1442
		' (get) Token: 0x06000FC7 RID: 4039 RVA: 0x00293A80 File Offset: 0x00292A80
		' (set) Token: 0x06000FC8 RID: 4040 RVA: 0x00293A64 File Offset: 0x00292A64
		Friend Overridable Property TextBox41 As TextBox
			Get
				Return Me._TextBox41
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox41 IsNot Nothing Then
				End If
				Me._TextBox41 = value
				If Me._TextBox41 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005A3 RID: 1443
		' (get) Token: 0x06000FC9 RID: 4041 RVA: 0x00293AB0 File Offset: 0x00292AB0
		' (set) Token: 0x06000FCA RID: 4042 RVA: 0x00293A94 File Offset: 0x00292A94
		Friend Overridable Property TextBox42 As TextBox
			Get
				Return Me._TextBox42
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox42 IsNot Nothing Then
				End If
				Me._TextBox42 = value
				If Me._TextBox42 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005A4 RID: 1444
		' (get) Token: 0x06000FCB RID: 4043 RVA: 0x00293AC4 File Offset: 0x00292AC4
		' (set) Token: 0x06000FCC RID: 4044 RVA: 0x00293AD8 File Offset: 0x00292AD8
		Friend Overridable Property TextBox43 As TextBox
			Get
				Return Me._TextBox43
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox43 IsNot Nothing Then
				End If
				Me._TextBox43 = value
				If Me._TextBox43 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005A5 RID: 1445
		' (get) Token: 0x06000FCD RID: 4045 RVA: 0x00293AF4 File Offset: 0x00292AF4
		' (set) Token: 0x06000FCE RID: 4046 RVA: 0x00293B08 File Offset: 0x00292B08
		Friend Overridable Property Label23 As Label
			Get
				Return Me._Label23
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label23 IsNot Nothing Then
				End If
				Me._Label23 = value
				If Me._Label23 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005A6 RID: 1446
		' (get) Token: 0x06000FD0 RID: 4048 RVA: 0x00293B40 File Offset: 0x00292B40
		' (set) Token: 0x06000FCF RID: 4047 RVA: 0x00293B24 File Offset: 0x00292B24
		Friend Overridable Property TextBox44 As TextBox
			Get
				Return Me._TextBox44
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox44 IsNot Nothing Then
				End If
				Me._TextBox44 = value
				If Me._TextBox44 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005A7 RID: 1447
		' (get) Token: 0x06000FD1 RID: 4049 RVA: 0x00293B54 File Offset: 0x00292B54
		' (set) Token: 0x06000FD2 RID: 4050 RVA: 0x00293B68 File Offset: 0x00292B68
		Friend Overridable Property Label24 As Label
			Get
				Return Me._Label24
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label24 IsNot Nothing Then
				End If
				Me._Label24 = value
				If Me._Label24 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005A8 RID: 1448
		' (get) Token: 0x06000FD4 RID: 4052 RVA: 0x00293BA0 File Offset: 0x00292BA0
		' (set) Token: 0x06000FD3 RID: 4051 RVA: 0x00293B84 File Offset: 0x00292B84
		Friend Overridable Property TextBox45 As TextBox
			Get
				Return Me._TextBox45
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox45 IsNot Nothing Then
				End If
				Me._TextBox45 = value
				If Me._TextBox45 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005A9 RID: 1449
		' (get) Token: 0x06000FD5 RID: 4053 RVA: 0x00293BD0 File Offset: 0x00292BD0
		' (set) Token: 0x06000FD6 RID: 4054 RVA: 0x00293BB4 File Offset: 0x00292BB4
		Friend Overridable Property TextBox46 As TextBox
			Get
				Return Me._TextBox46
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox46 IsNot Nothing Then
				End If
				Me._TextBox46 = value
				If Me._TextBox46 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005AA RID: 1450
		' (get) Token: 0x06000FD8 RID: 4056 RVA: 0x00293C00 File Offset: 0x00292C00
		' (set) Token: 0x06000FD7 RID: 4055 RVA: 0x00293BE4 File Offset: 0x00292BE4
		Friend Overridable Property TextBox47 As TextBox
			Get
				Return Me._TextBox47
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox47 IsNot Nothing Then
				End If
				Me._TextBox47 = value
				If Me._TextBox47 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005AB RID: 1451
		' (get) Token: 0x06000FDA RID: 4058 RVA: 0x00293C14 File Offset: 0x00292C14
		' (set) Token: 0x06000FD9 RID: 4057 RVA: 0x00293C28 File Offset: 0x00292C28
		Friend Overridable Property TextBox48 As TextBox
			Get
				Return Me._TextBox48
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox48 IsNot Nothing Then
				End If
				Me._TextBox48 = value
				If Me._TextBox48 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005AC RID: 1452
		' (get) Token: 0x06000FDB RID: 4059 RVA: 0x00293C44 File Offset: 0x00292C44
		' (set) Token: 0x06000FDC RID: 4060 RVA: 0x00293C58 File Offset: 0x00292C58
		Friend Overridable Property TextBox49 As TextBox
			Get
				Return Me._TextBox49
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox49 IsNot Nothing Then
				End If
				Me._TextBox49 = value
				If Me._TextBox49 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005AD RID: 1453
		' (get) Token: 0x06000FDE RID: 4062 RVA: 0x00293C74 File Offset: 0x00292C74
		' (set) Token: 0x06000FDD RID: 4061 RVA: 0x00293C88 File Offset: 0x00292C88
		Friend Overridable Property TextBox50 As TextBox
			Get
				Return Me._TextBox50
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox50 IsNot Nothing Then
				End If
				Me._TextBox50 = value
				If Me._TextBox50 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005AE RID: 1454
		' (get) Token: 0x06000FDF RID: 4063 RVA: 0x00293CA4 File Offset: 0x00292CA4
		' (set) Token: 0x06000FE0 RID: 4064 RVA: 0x00293CB8 File Offset: 0x00292CB8
		Friend Overridable Property Label25 As Label
			Get
				Return Me._Label25
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label25 IsNot Nothing Then
				End If
				Me._Label25 = value
				If Me._Label25 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005AF RID: 1455
		' (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00293CF0 File Offset: 0x00292CF0
		' (set) Token: 0x06000FE1 RID: 4065 RVA: 0x00293CD4 File Offset: 0x00292CD4
		Friend Overridable Property Label26 As Label
			Get
				Return Me._Label26
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label26 IsNot Nothing Then
				End If
				Me._Label26 = value
				If Me._Label26 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005B0 RID: 1456
		' (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00293D20 File Offset: 0x00292D20
		' (set) Token: 0x06000FE3 RID: 4067 RVA: 0x00293D04 File Offset: 0x00292D04
		Friend Overridable Property TextBox51 As TextBox
			Get
				Return Me._TextBox51
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox51 IsNot Nothing Then
				End If
				Me._TextBox51 = value
				If Me._TextBox51 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005B1 RID: 1457
		' (get) Token: 0x06000FE5 RID: 4069 RVA: 0x00293D50 File Offset: 0x00292D50
		' (set) Token: 0x06000FE6 RID: 4070 RVA: 0x00293D34 File Offset: 0x00292D34
		Friend Overridable Property TextBox52 As TextBox
			Get
				Return Me._TextBox52
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox52 IsNot Nothing Then
				End If
				Me._TextBox52 = value
				If Me._TextBox52 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005B2 RID: 1458
		' (get) Token: 0x06000FE7 RID: 4071 RVA: 0x00293D80 File Offset: 0x00292D80
		' (set) Token: 0x06000FE8 RID: 4072 RVA: 0x00293D64 File Offset: 0x00292D64
		Friend Overridable Property TextBox53 As TextBox
			Get
				Return Me._TextBox53
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox53 IsNot Nothing Then
				End If
				Me._TextBox53 = value
				If Me._TextBox53 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005B3 RID: 1459
		' (get) Token: 0x06000FE9 RID: 4073 RVA: 0x00293DB0 File Offset: 0x00292DB0
		' (set) Token: 0x06000FEA RID: 4074 RVA: 0x00293D94 File Offset: 0x00292D94
		Friend Overridable Property TextBox54 As TextBox
			Get
				Return Me._TextBox54
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				If Me._TextBox54 IsNot Nothing Then
				End If
				Me._TextBox54 = value
				If Me._TextBox54 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005B4 RID: 1460
		' (get) Token: 0x06000FEB RID: 4075 RVA: 0x00293DE0 File Offset: 0x00292DE0
		' (set) Token: 0x06000FEC RID: 4076 RVA: 0x00293DC4 File Offset: 0x00292DC4
		Friend Overridable Property Label28 As Label
			Get
				Return Me._Label28
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._Label28 IsNot Nothing Then
				End If
				Me._Label28 = value
				If Me._Label28 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005B5 RID: 1461
		' (get) Token: 0x06000FED RID: 4077 RVA: 0x00293E10 File Offset: 0x00292E10
		' (set) Token: 0x06000FEE RID: 4078 RVA: 0x00293DF4 File Offset: 0x00292DF4
		Friend Overridable Property nudStlh As NumericUpDown
			Get
				Return Me._nudStlh
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudStlh IsNot Nothing Then
				End If
				Me._nudStlh = value
				If Me._nudStlh IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005B6 RID: 1462
		' (get) Token: 0x06000FEF RID: 4079 RVA: 0x00293E24 File Offset: 0x00292E24
		' (set) Token: 0x06000FF0 RID: 4080 RVA: 0x00293E38 File Offset: 0x00292E38
		Friend Overridable Property nudSrch As NumericUpDown
			Get
				Return Me._nudSrch
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudSrch IsNot Nothing Then
				End If
				Me._nudSrch = value
				If Me._nudSrch IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005B7 RID: 1463
		' (get) Token: 0x06000FF2 RID: 4082 RVA: 0x00293E54 File Offset: 0x00292E54
		' (set) Token: 0x06000FF1 RID: 4081 RVA: 0x00293E68 File Offset: 0x00292E68
		Friend Overridable Property nudTryUnlock As NumericUpDown
			Get
				Return Me._nudTryUnlock
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudTryUnlock IsNot Nothing Then
				End If
				Me._nudTryUnlock = value
				If Me._nudTryUnlock IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005B8 RID: 1464
		' (get) Token: 0x06000FF3 RID: 4083 RVA: 0x00293E84 File Offset: 0x00292E84
		' (set) Token: 0x06000FF4 RID: 4084 RVA: 0x00293E98 File Offset: 0x00292E98
		Friend Overridable Property nudFailUnlock As NumericUpDown
			Get
				Return Me._nudFailUnlock
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudFailUnlock IsNot Nothing Then
				End If
				Me._nudFailUnlock = value
				If Me._nudFailUnlock IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005B9 RID: 1465
		' (get) Token: 0x06000FF6 RID: 4086 RVA: 0x00293EB4 File Offset: 0x00292EB4
		' (set) Token: 0x06000FF5 RID: 4085 RVA: 0x00293EC8 File Offset: 0x00292EC8
		Friend Overridable Property nudSucceedUnlock As NumericUpDown
			Get
				Return Me._nudSucceedUnlock
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudSucceedUnlock IsNot Nothing Then
				End If
				Me._nudSucceedUnlock = value
				If Me._nudSucceedUnlock IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005BA RID: 1466
		' (get) Token: 0x06000FF7 RID: 4087 RVA: 0x00293EE4 File Offset: 0x00292EE4
		' (set) Token: 0x06000FF8 RID: 4088 RVA: 0x00293EF8 File Offset: 0x00292EF8
		Friend Overridable Property nudLeaveParty As NumericUpDown
			Get
				Return Me._nudLeaveParty
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudLeaveParty IsNot Nothing Then
				End If
				Me._nudLeaveParty = value
				If Me._nudLeaveParty IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005BB RID: 1467
		' (get) Token: 0x06000FF9 RID: 4089 RVA: 0x00293F14 File Offset: 0x00292F14
		' (set) Token: 0x06000FFA RID: 4090 RVA: 0x00293F28 File Offset: 0x00292F28
		Friend Overridable Property nudRejoinParty As NumericUpDown
			Get
				Return Me._nudRejoinParty
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudRejoinParty IsNot Nothing Then
				End If
				Me._nudRejoinParty = value
				If Me._nudRejoinParty IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005BC RID: 1468
		' (get) Token: 0x06000FFC RID: 4092 RVA: 0x00293F44 File Offset: 0x00292F44
		' (set) Token: 0x06000FFB RID: 4091 RVA: 0x00293F58 File Offset: 0x00292F58
		Friend Overridable Property nudPoisoned As NumericUpDown
			Get
				Return Me._nudPoisoned
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				If Me._nudPoisoned IsNot Nothing Then
				End If
				Me._nudPoisoned = value
				If Me._nudPoisoned IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005BD RID: 1469
		' (get) Token: 0x06000FFE RID: 4094 RVA: 0x00293F74 File Offset: 0x00292F74
		' (set) Token: 0x06000FFD RID: 4093 RVA: 0x00293F88 File Offset: 0x00292F88
		Friend Overridable Property label111 As Label
			Get
				Return Me._label111
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				If Me._label111 IsNot Nothing Then
				End If
				Me._label111 = value
				If Me._label111 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005BE RID: 1470
		' (get) Token: 0x06000FFF RID: 4095 RVA: 0x00293FA4 File Offset: 0x00292FA4
		' (set) Token: 0x06001000 RID: 4096 RVA: 0x00293FB8 File Offset: 0x00292FB8
		Friend Overridable Property MainMenu1 As MainMenu
			Get
				Return Me._MainMenu1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MainMenu)
				If Me._MainMenu1 IsNot Nothing Then
				End If
				Me._MainMenu1 = value
				If Me._MainMenu1 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005BF RID: 1471
		' (get) Token: 0x06001001 RID: 4097 RVA: 0x00293FD4 File Offset: 0x00292FD4
		' (set) Token: 0x06001002 RID: 4098 RVA: 0x00293FE8 File Offset: 0x00292FE8
		Friend Overridable Property MenuItem1 As MenuItem
			Get
				Return Me._MenuItem1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._MenuItem1 IsNot Nothing Then
				End If
				Me._MenuItem1 = value
				If Me._MenuItem1 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005C0 RID: 1472
		' (get) Token: 0x06001003 RID: 4099 RVA: 0x00294058 File Offset: 0x00293058
		' (set) Token: 0x06001004 RID: 4100 RVA: 0x00294004 File Offset: 0x00293004
		Friend Overridable Property miSave As MenuItem
			Get
				Return Me._miSave
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miSave IsNot Nothing Then
					RemoveHandler Me._miSave.Click, AddressOf Me.miSave_Click
				End If
				Me._miSave = value
				If Me._miSave IsNot Nothing Then
					AddHandler Me._miSave.Click, AddressOf Me.miSave_Click
				End If
			End Set
		End Property

		' Token: 0x170005C1 RID: 1473
		' (get) Token: 0x06001005 RID: 4101 RVA: 0x0029406C File Offset: 0x0029306C
		' (set) Token: 0x06001006 RID: 4102 RVA: 0x00294080 File Offset: 0x00293080
		Friend Overridable Property MenuItem5 As MenuItem
			Get
				Return Me._MenuItem5
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._MenuItem5 IsNot Nothing Then
				End If
				Me._MenuItem5 = value
				If Me._MenuItem5 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005C2 RID: 1474
		' (get) Token: 0x06001007 RID: 4103 RVA: 0x0029409C File Offset: 0x0029309C
		' (set) Token: 0x06001008 RID: 4104 RVA: 0x002940B0 File Offset: 0x002930B0
		Friend Overridable Property miNew As MenuItem
			Get
				Return Me._miNew
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miNew IsNot Nothing Then
					RemoveHandler Me._miNew.Click, AddressOf Me.miNew_Click
				End If
				Me._miNew = value
				If Me._miNew IsNot Nothing Then
					AddHandler Me._miNew.Click, AddressOf Me.miNew_Click
				End If
			End Set
		End Property

		' Token: 0x170005C3 RID: 1475
		' (get) Token: 0x0600100A RID: 4106 RVA: 0x00294158 File Offset: 0x00293158
		' (set) Token: 0x06001009 RID: 4105 RVA: 0x00294104 File Offset: 0x00293104
		Friend Overridable Property miOpen As MenuItem
			Get
				Return Me._miOpen
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miOpen IsNot Nothing Then
					RemoveHandler Me._miOpen.Click, AddressOf Me.miOpen_Click
				End If
				Me._miOpen = value
				If Me._miOpen IsNot Nothing Then
					AddHandler Me._miOpen.Click, AddressOf Me.miOpen_Click
				End If
			End Set
		End Property

		' Token: 0x170005C4 RID: 1476
		' (get) Token: 0x0600100C RID: 4108 RVA: 0x002941C0 File Offset: 0x002931C0
		' (set) Token: 0x0600100B RID: 4107 RVA: 0x0029416C File Offset: 0x0029316C
		Friend Overridable Property miQuit As MenuItem
			Get
				Return Me._miQuit
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miQuit IsNot Nothing Then
					RemoveHandler Me._miQuit.Click, AddressOf Me.miQuit_Click
				End If
				Me._miQuit = value
				If Me._miQuit IsNot Nothing Then
					AddHandler Me._miQuit.Click, AddressOf Me.miQuit_Click
				End If
			End Set
		End Property

		' Token: 0x170005C5 RID: 1477
		' (get) Token: 0x0600100D RID: 4109 RVA: 0x002941D4 File Offset: 0x002931D4
		' (set) Token: 0x0600100E RID: 4110 RVA: 0x002941E8 File Offset: 0x002931E8
		Friend Overridable Property miSaveAs As MenuItem
			Get
				Return Me._miSaveAs
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miSaveAs IsNot Nothing Then
					RemoveHandler Me._miSaveAs.Click, AddressOf Me.miSaveAs_Click
				End If
				Me._miSaveAs = value
				If Me._miSaveAs IsNot Nothing Then
					AddHandler Me._miSaveAs.Click, AddressOf Me.miSaveAs_Click
				End If
			End Set
		End Property

		' Token: 0x170005C6 RID: 1478
		' (get) Token: 0x06001010 RID: 4112 RVA: 0x0029423C File Offset: 0x0029323C
		' (set) Token: 0x0600100F RID: 4111 RVA: 0x00294250 File Offset: 0x00293250
		Friend Overridable Property MenuItem2 As MenuItem
			Get
				Return Me._MenuItem2
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._MenuItem2 IsNot Nothing Then
				End If
				Me._MenuItem2 = value
				If Me._MenuItem2 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005C7 RID: 1479
		' (get) Token: 0x06001011 RID: 4113 RVA: 0x002942C0 File Offset: 0x002932C0
		' (set) Token: 0x06001012 RID: 4114 RVA: 0x0029426C File Offset: 0x0029326C
		Friend Overridable Property miUseK1DialogTlk As MenuItem
			Get
				Return Me._miUseK1DialogTlk
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miUseK1DialogTlk IsNot Nothing Then
					RemoveHandler Me._miUseK1DialogTlk.Click, AddressOf Me.UseDialogTlk_Click
				End If
				Me._miUseK1DialogTlk = value
				If Me._miUseK1DialogTlk IsNot Nothing Then
					AddHandler Me._miUseK1DialogTlk.Click, AddressOf Me.UseDialogTlk_Click
				End If
			End Set
		End Property

		' Token: 0x170005C8 RID: 1480
		' (get) Token: 0x06001013 RID: 4115 RVA: 0x002942D4 File Offset: 0x002932D4
		' (set) Token: 0x06001014 RID: 4116 RVA: 0x002942E8 File Offset: 0x002932E8
		Friend Overridable Property miUseK2DialogTlk As MenuItem
			Get
				Return Me._miUseK2DialogTlk
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miUseK2DialogTlk IsNot Nothing Then
					RemoveHandler Me._miUseK2DialogTlk.Click, AddressOf Me.UseDialogTlk_Click
				End If
				Me._miUseK2DialogTlk = value
				If Me._miUseK2DialogTlk IsNot Nothing Then
					AddHandler Me._miUseK2DialogTlk.Click, AddressOf Me.UseDialogTlk_Click
				End If
			End Set
		End Property

		' Token: 0x170005C9 RID: 1481
		' (get) Token: 0x06001016 RID: 4118 RVA: 0x00294390 File Offset: 0x00293390
		' (set) Token: 0x06001015 RID: 4117 RVA: 0x0029433C File Offset: 0x0029333C
		Friend Overridable Property miUseExtDialogTlk As MenuItem
			Get
				Return Me._miUseExtDialogTlk
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miUseExtDialogTlk IsNot Nothing Then
					RemoveHandler Me._miUseExtDialogTlk.Click, AddressOf Me.UseDialogTlk_Click
				End If
				Me._miUseExtDialogTlk = value
				If Me._miUseExtDialogTlk IsNot Nothing Then
					AddHandler Me._miUseExtDialogTlk.Click, AddressOf Me.UseDialogTlk_Click
				End If
			End Set
		End Property

		' Token: 0x170005CA RID: 1482
		' (get) Token: 0x06001018 RID: 4120 RVA: 0x002943A4 File Offset: 0x002933A4
		' (set) Token: 0x06001017 RID: 4119 RVA: 0x002943B8 File Offset: 0x002933B8
		Friend Overridable Property miAskDialogTlk As MenuItem
			Get
				Return Me._miAskDialogTlk
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuItem)
				If Me._miAskDialogTlk IsNot Nothing Then
					RemoveHandler Me._miAskDialogTlk.Click, AddressOf Me.UseDialogTlk_Click
				End If
				Me._miAskDialogTlk = value
				If Me._miAskDialogTlk IsNot Nothing Then
					AddHandler Me._miAskDialogTlk.Click, AddressOf Me.UseDialogTlk_Click
				End If
			End Set
		End Property

		' Token: 0x170005CB RID: 1483
		' (get) Token: 0x0600101A RID: 4122 RVA: 0x0029440C File Offset: 0x0029340C
		' (set) Token: 0x06001019 RID: 4121 RVA: 0x00294420 File Offset: 0x00293420
		Friend Overridable Property StatusBar1 As StatusBar
			Get
				Return Me._StatusBar1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusBar)
				If Me._StatusBar1 IsNot Nothing Then
				End If
				Me._StatusBar1 = value
				If Me._StatusBar1 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x170005CC RID: 1484
		' (get) Token: 0x0600101B RID: 4123 RVA: 0x00294458 File Offset: 0x00293458
		' (set) Token: 0x0600101C RID: 4124 RVA: 0x0029443C File Offset: 0x0029343C
		Friend Overridable Property ToolTip1 As ToolTip
			Get
				Return Me._ToolTip1
			End Get
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolTip)
				If Me._ToolTip1 IsNot Nothing Then
				End If
				Me._ToolTip1 = value
				If Me._ToolTip1 IsNot Nothing Then
				End If
			End Set
		End Property

		' Token: 0x0600101E RID: 4126 RVA: 0x00299CFC File Offset: 0x00298CFC
		Public Sub New(fs As FileStream, KotorVersionIndex As Integer)
			Me.New(New clsSSF(fs, KotorVersionIndex))
			fs.Close()
		End Sub

		' Token: 0x0600101F RID: 4127 RVA: 0x00299D14 File Offset: 0x00298D14
		Public Sub New(filepath As String, KotorVersionIndex As Integer)
			Me.New(New FileStream(filepath, FileMode.Open), KotorVersionIndex)
		End Sub

		' Token: 0x06001020 RID: 4128 RVA: 0x00299D24 File Offset: 0x00298D24
		Public Sub New(SSF As clsSSF)
			Me.New()
			Me._SSF = SSF
			Me.ParseSSF()
		End Sub

		' Token: 0x06001021 RID: 4129 RVA: 0x00299D3C File Offset: 0x00298D3C
		Private Function KotorVersion() As Integer
			Dim frmSpecifyKotorVersion As frmSpecifyKotorVersion = New frmSpecifyKotorVersion()
			frmSpecifyKotorVersion.btnCancel.Visible = False
			If frmSpecifyKotorVersion.ShowDialog(Me) = DialogResult.OK Then
				Return frmSpecifyKotorVersion.KotorVerIndexSelected
			End If
			Return -1
		End Function

        '' Token: 0x06001022 RID: 4130 RVA: 0x00299D70 File Offset: 0x00298D70
        'Private Sub ParseSSF()
        '	Dim num As Integer = 0
        '	Do
        '		Dim control As Control = Me.FindControlAndSetValue(Convert.ToString(num), StringType.FromInteger(Me._SSF.get_RefArray(num)))
        '		Me.FindControlAndSetValue("rr" + StringType.FromInteger(num), Me._SSF.get_RefArraySoundResRef(num))
        '		Dim control2 As Control = Me.FindControlAndSetValue("d" + StringType.FromInteger(num), Me._SSF.get_RefArrayString(num))
        '		AddHandler CType(control, NumericUpDown).ValueChanged, AddressOf Me.nud_ValueChanged
        '		AddHandler CType(control2, TextBox).MouseEnter, AddressOf Me.tbDesc_MouseEnter
        '		control.Enabled = True
        '		num += 1
        '	Loop While num <= 27
        'End Sub

        ' Token: 0x06001022 RID: 4130 RVA: 0x00299D70 File Offset: 0x00298D70
        Private Sub ParseSSF()
            Dim index As Integer = 0

            Do
                Dim nudControl As Control = Me.FindControlAndSetValue( _
                 Convert.ToString(index), _
                 StringType.FromInteger(Me._SSF.RefArray(index)) _
                )

                Me.FindControlAndSetValue( _
                 "rr" + StringType.FromInteger(index), _
                 Me._SSF.RefArraySoundResRef(index) _
                )

                Dim descControl As Control = Me.FindControlAndSetValue( _
                 "d" + StringType.FromInteger(index), _
                 Me._SSF.RefArrayString(index) _
                )

                AddHandler CType(nudControl, NumericUpDown).ValueChanged, AddressOf Me.nud_ValueChanged
                AddHandler CType(descControl, TextBox).MouseEnter, AddressOf Me.tbDesc_MouseEnter

                nudControl.Enabled = True
                index += 1
            Loop While index <= 27
        End Sub

		' Token: 0x06001023 RID: 4131 RVA: 0x00299E38 File Offset: 0x00298E38
		Private Sub LoadDialogTlk(Optional promptForVersion As Boolean = True)
			Dim flag As Boolean = False
			Dim text As String
			If Me.miUseK1DialogTlk.Checked AndAlso (Me.KotorVersionIndex = 1 OrElse Me.KotorVersionIndex = -1) Then
				text = Path.Combine(UserSettings.GetSettings().KotorLocation(0), "dialog.tlk")
				Me.KotorVersionIndex = 0
				flag = True
			End If
			If Me.miUseK2DialogTlk.Checked AndAlso (Me.KotorVersionIndex = 0 OrElse Me.KotorVersionIndex = -1) Then
				text = Path.Combine(UserSettings.GetSettings().KotorLocation(1), "dialog.tlk")
				Me.KotorVersionIndex = 1
				flag = True
			End If
			If Me.miAskDialogTlk.Checked AndAlso promptForVersion Then
				Dim num As Integer = Me.KotorVersion()
				If num = -1 Then
					Return
				End If
				If Me.KotorVersionIndex <> num Then
					Me.KotorVersionIndex = num
					text = Path.Combine(UserSettings.GetSettings().KotorLocation(Me.KotorVersionIndex), "dialog.tlk")
					flag = True
				End If
			End If
			If Me.miUseExtDialogTlk.Checked AndAlso (Me.KotorVersionIndex > -1 OrElse Me.g_dialogtlk Is Nothing) Then
				Me.g_dialogtlk = Nothing
				Me.GetExternalDialogTlk()
				Me.KotorVersionIndex = -1
			ElseIf flag Then
				Me.g_dialogtlk = New clsDialogTlk(text, True)
				Me.StatusBar1.Text = "Dialog.Tlk: " + text + " (KotOR I"
				If Me.KotorVersionIndex = 0 Then
					Dim statusBar As StatusBar = Me.StatusBar1
					statusBar.Text += ")"
				Else
					Dim statusBar As StatusBar = Me.StatusBar1
					statusBar.Text += "I)"
				End If
			End If
		End Sub

		' Token: 0x06001024 RID: 4132 RVA: 0x00299FB0 File Offset: 0x00298FB0
		Private Sub GetExternalDialogTlk()
			Dim text As String
			If frmMain.IsOnly1KotORInstalled() Then
				If frmMain.hasKotor1() Then
					text = UserSettings.GetSettings().KotorLocation(0)
				End If
				If frmMain.hasKotor2() Then
					text = UserSettings.GetSettings().KotorLocation(1)
				End If
			Else
				text = UserSettings.GetSettings().defaultImportLocation
			End If
			Dim objectValue As Object = RuntimeHelpers.GetObjectValue(frmMain.GetFilePath("load", text, "*.tlk", "Open Dialog.Tlk file...", "tlk", False, True))
			If objectValue.[GetType]() Is GetType(String) Then
				If ObjectType.ObjTst(objectValue, "", False) = 0 Then
					Return
				End If
				Dim text2 As String = StringType.FromObject(objectValue)
				If Not text2.ToLower().EndsWith(".tlk") AndAlso Interaction.MsgBox("The file you selected does not have a .TLK extension; do you want to open it?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2, "Questionable file extension") = MsgBoxResult.No Then
					Return
				End If
				Me.g_dialogtlk = New clsDialogTlk(text2, True)
				Me.StatusBar1.Text = "Dialog.Tlk: " + text2 + " (External)"
			End If
		End Sub

		' Token: 0x06001025 RID: 4133 RVA: 0x0029A094 File Offset: 0x00299094
		Public Sub SetFormName(Name As String)
			Me.Text = "SSF Editor - " + Name
		End Sub

		' Token: 0x06001026 RID: 4134 RVA: 0x0029A0A8 File Offset: 0x002990A8
		Private Function FindControlAndSetValue(tagStr As String, value As String) As Control
			Dim control2 As Control
			Try
				For Each obj As Object In Me.Panel1.Controls
					Dim control As Control = CType(obj, Control)
					If control.Tag IsNot Nothing AndAlso StringType.StrCmp(control.Tag.ToString(), tagStr, False) = 0 Then
						If StringType.StrCmp(control.[GetType]().Name, "NumericUpDown", False) = 0 Then
							CType(control, NumericUpDown).Value = New Decimal(Convert.ToDouble(value))
						Else
							control.Text = value
						End If
						control2 = control
						Exit For
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					CType(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return control2
		End Function

		' Token: 0x06001027 RID: 4135 RVA: 0x0029A15C File Offset: 0x0029915C
		Public Sub EnableControls()
			Me.miSave.Enabled = True
			Me.miSaveAs.Enabled = True
		End Sub

        '' Token: 0x06001028 RID: 4136 RVA: 0x0029A184 File Offset: 0x00299184
        'Private Sub miNew_Click(sender As Object, e As EventArgs)
        '	Dim num As Integer = Me.KotorVersion()
        '	If num > -1 Then
        '		Me._SSF = New clsSSF(num)
        '		Dim num2 As Integer = 0
        '		Do
        '			Me._SSF.set_RefArray(num2, -1)
        '			num2 += 1
        '		Loop While num2 <= 39
        '		Me.ParseSSF()
        '		Me.EnableControls()
        '	End If
        'End Sub

        ' Token: 0x06001028 RID: 4136 RVA: 0x0029A184 File Offset: 0x00299184
        Private Sub miNew_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim kotorVersionIndex As Integer = Me.KotorVersion()

            If kotorVersionIndex > -1 Then
                Me._SSF = New clsSSF(kotorVersionIndex)

                Dim index As Integer = 0
                Do
                    Me._SSF.RefArray(index) = -1
                    index += 1
                Loop While index <= 39

                Me.ParseSSF()
                Me.EnableControls()
            End If
        End Sub

		' Token: 0x06001029 RID: 4137 RVA: 0x0029A1D4 File Offset: 0x002991D4
		Private Sub miOpen_Click(sender As Object, e As EventArgs)
			Dim text As String = StringType.FromObject(frmMain.GetFilePath("load", Me.CurrentSettings.defaultSaveLocation, "", "Load SSF file...", "ssf", False, True))
			If StringType.StrCmp(text, "", False) = 0 Then
				Return
			End If
			Me.LoadDialogTlk(True)
			If Me.g_dialogtlk IsNot Nothing Then
				Me._SSF = New clsSSF(New FileStream(text, FileMode.Open), Me.g_dialogtlk)
				Me.ParseSSF()
				Me.SetFormName(text)
				Me.EnableControls()
			Else
				Interaction.MsgBox("Dialog.Tlk not loaded; opening of file aborted!", MsgBoxStyle.Exclamation, Nothing)
			End If
		End Sub

		' Token: 0x0600102A RID: 4138 RVA: 0x0029A268 File Offset: 0x00299268
		Private Sub miSave_Click(sender As Object, e As EventArgs)
			If StringType.StrCmp(Me.g_filepath, "", False) <> 0 Then
				Me._SSF.WriteFile(Me.g_filepath)
			Else
				Me.miSaveAs_Click(RuntimeHelpers.GetObjectValue(sender), e)
			End If
		End Sub

		' Token: 0x0600102B RID: 4139 RVA: 0x0029A2A0 File Offset: 0x002992A0
		Private Sub miSaveAs_Click(sender As Object, e As EventArgs)
			Dim text As String = StringType.FromObject(frmMain.GetFilePath("save", Me.CurrentSettings.defaultSaveLocation, "", "Save SSF file as...", "ssf", False, True))
			If StringType.StrCmp(text, "", False) <> 0 Then
				Me._SSF.WriteFile(text)
				Me.g_filepath = text
			End If
		End Sub

		' Token: 0x0600102C RID: 4140 RVA: 0x0029A2FC File Offset: 0x002992FC
		Private Sub miQuit_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0600102D RID: 4141 RVA: 0x0029A304 File Offset: 0x00299304
		Private Sub UseDialogTlk_Click(sender As Object, e As EventArgs)
			Me.miUseK1DialogTlk.Checked = False
			Me.miUseK2DialogTlk.Checked = False
			Me.miUseExtDialogTlk.Checked = False
			Me.miAskDialogTlk.Checked = False
			CType(sender, MenuItem).Checked = True
			Me.LoadDialogTlk(False)
		End Sub

        '' Token: 0x0600102E RID: 4142 RVA: 0x0029A354 File Offset: 0x00299354
        'Private Sub nud_ValueChanged(sender As Object, e As EventArgs)
        '	Dim num As Integer = Convert.ToInt32(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(sender, Nothing, "tag", New Object(-1) {}, Nothing, Nothing)))
        '	Me._SSF.set_RefArray(num, IntegerType.FromObject(LateBinding.LateGet(sender, Nothing, "Value", New Object(-1) {}, Nothing, Nothing)))
        '	Me.FindControlAndSetValue("rr" + StringType.FromInteger(num), Me._SSF.get_RefArraySoundResRef(num))
        '	Me.FindControlAndSetValue("d" + StringType.FromInteger(num), Me._SSF.get_RefArrayString(num))
        'End Sub

        ' Token: 0x0600102E RID: 4142 RVA: 0x0029A354 File Offset: 0x00299354
        Private Sub nud_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim nud As NumericUpDown = CType(sender, NumericUpDown)
            Dim index As Integer = Convert.ToInt32(nud.Tag)

            Me._SSF.RefArray(index) = Convert.ToInt32(nud.Value)

            Me.FindControlAndSetValue("rr" & StringType.FromInteger(index), Me._SSF.RefArraySoundResRef(index))
            Me.FindControlAndSetValue("d" & StringType.FromInteger(index), Me._SSF.RefArrayString(index))
        End Sub

		' Token: 0x0600102F RID: 4143 RVA: 0x0029A3FC File Offset: 0x002993FC
		Private Sub frmSSFEditor_Load(sender As Object, e As EventArgs)
			Me.miUseK1DialogTlk.Visible = frmMain.hasKotor1()
			Me.miUseK2DialogTlk.Visible = frmMain.hasKotor2()
		End Sub

		' Token: 0x06001030 RID: 4144 RVA: 0x0029A420 File Offset: 0x00299420
		Private Sub tbDesc_MouseEnter(sender As Object, e As EventArgs)
			Me.ToolTip1.SetToolTip(CType(sender, Control), CType(sender, TextBox).Text)
		End Sub

		' Token: 0x04000751 RID: 1873
		<AccessedThroughProperty("TextBox30")>
		Private _TextBox30 As TextBox

		' Token: 0x04000752 RID: 1874
		<AccessedThroughProperty("TextBox41")>
		Private _TextBox41 As TextBox

		' Token: 0x04000753 RID: 1875
		<AccessedThroughProperty("TextBox40")>
		Private _TextBox40 As TextBox

		' Token: 0x04000754 RID: 1876
		<AccessedThroughProperty("TextBox39")>
		Private _TextBox39 As TextBox

		' Token: 0x04000755 RID: 1877
		<AccessedThroughProperty("nudDMin")>
		Private _nudDMin As NumericUpDown

		' Token: 0x04000756 RID: 1878
		<AccessedThroughProperty("nudLMin")>
		Private _nudLMin As NumericUpDown

		' Token: 0x04000757 RID: 1879
		<AccessedThroughProperty("nudTIA")>
		Private _nudTIA As NumericUpDown

		' Token: 0x04000758 RID: 1880
		<AccessedThroughProperty("nudCrit")>
		Private _nudCrit As NumericUpDown

		' Token: 0x04000759 RID: 1881
		<AccessedThroughProperty("miSave")>
		Private _miSave As MenuItem

		' Token: 0x0400075A RID: 1882
		<AccessedThroughProperty("nudLowHlth")>
		Private _nudLowHlth As NumericUpDown

		' Token: 0x0400075B RID: 1883
		<AccessedThroughProperty("miOpen")>
		Private _miOpen As MenuItem

		' Token: 0x0400075C RID: 1884
		<AccessedThroughProperty("nudDead")>
		Private _nudDead As NumericUpDown

		' Token: 0x0400075D RID: 1885
		<AccessedThroughProperty("nudHit1")>
		Private _nudHit1 As NumericUpDown

		' Token: 0x0400075E RID: 1886
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x0400075F RID: 1887
		<AccessedThroughProperty("nudHit2")>
		Private _nudHit2 As NumericUpDown

		' Token: 0x04000760 RID: 1888
		<AccessedThroughProperty("nudAtk3")>
		Private _nudAtk3 As NumericUpDown

		' Token: 0x04000761 RID: 1889
		<AccessedThroughProperty("nudAtk1")>
		Private _nudAtk1 As NumericUpDown

		' Token: 0x04000762 RID: 1890
		<AccessedThroughProperty("nudAtk2")>
		Private _nudAtk2 As NumericUpDown

		' Token: 0x04000763 RID: 1891
		<AccessedThroughProperty("nudSel2")>
		Private _nudSel2 As NumericUpDown

		' Token: 0x04000764 RID: 1892
		<AccessedThroughProperty("nudSel3")>
		Private _nudSel3 As NumericUpDown

		' Token: 0x04000765 RID: 1893
		<AccessedThroughProperty("nudSel1")>
		Private _nudSel1 As NumericUpDown

		' Token: 0x04000766 RID: 1894
		<AccessedThroughProperty("TextBox43")>
		Private _TextBox43 As TextBox

		' Token: 0x04000767 RID: 1895
		<AccessedThroughProperty("nudBat6")>
		Private _nudBat6 As NumericUpDown

		' Token: 0x04000768 RID: 1896
		<AccessedThroughProperty("Label25")>
		Private _Label25 As Label

		' Token: 0x04000769 RID: 1897
		<AccessedThroughProperty("nudBat5")>
		Private _nudBat5 As NumericUpDown

		' Token: 0x0400076A RID: 1898
		<AccessedThroughProperty("Label28")>
		Private _Label28 As Label

		' Token: 0x0400076B RID: 1899
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x0400076C RID: 1900
		<AccessedThroughProperty("nudBat4")>
		Private _nudBat4 As NumericUpDown

		' Token: 0x0400076D RID: 1901
		<AccessedThroughProperty("nudBat3")>
		Private _nudBat3 As NumericUpDown

		' Token: 0x0400076E RID: 1902
		<AccessedThroughProperty("nudBat2")>
		Private _nudBat2 As NumericUpDown

		' Token: 0x0400076F RID: 1903
		<AccessedThroughProperty("TextBox38")>
		Private _TextBox38 As TextBox

		' Token: 0x04000770 RID: 1904
		<AccessedThroughProperty("TextBox37")>
		Private _TextBox37 As TextBox

		' Token: 0x04000771 RID: 1905
		<AccessedThroughProperty("TextBox36")>
		Private _TextBox36 As TextBox

		' Token: 0x04000772 RID: 1906
		<AccessedThroughProperty("Label26")>
		Private _Label26 As Label

		' Token: 0x04000773 RID: 1907
		<AccessedThroughProperty("TextBox35")>
		Private _TextBox35 As TextBox

		' Token: 0x04000774 RID: 1908
		<AccessedThroughProperty("TextBox44")>
		Private _TextBox44 As TextBox

		' Token: 0x04000775 RID: 1909
		<AccessedThroughProperty("TextBox34")>
		Private _TextBox34 As TextBox

		' Token: 0x04000776 RID: 1910
		<AccessedThroughProperty("TextBox33")>
		Private _TextBox33 As TextBox

		' Token: 0x04000777 RID: 1911
		<AccessedThroughProperty("TextBox32")>
		Private _TextBox32 As TextBox

		' Token: 0x04000778 RID: 1912
		<AccessedThroughProperty("TextBox31")>
		Private _TextBox31 As TextBox

		' Token: 0x04000779 RID: 1913
		<AccessedThroughProperty("TextBox29")>
		Private _TextBox29 As TextBox

		' Token: 0x0400077A RID: 1914
		<AccessedThroughProperty("TextBox28")>
		Private _TextBox28 As TextBox

		' Token: 0x0400077B RID: 1915
		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		' Token: 0x0400077C RID: 1916
		<AccessedThroughProperty("TextBox27")>
		Private _TextBox27 As TextBox

		' Token: 0x0400077D RID: 1917
		<AccessedThroughProperty("TextBox26")>
		Private _TextBox26 As TextBox

		' Token: 0x0400077E RID: 1918
		<AccessedThroughProperty("TextBox25")>
		Private _TextBox25 As TextBox

		' Token: 0x0400077F RID: 1919
		<AccessedThroughProperty("TextBox45")>
		Private _TextBox45 As TextBox

		' Token: 0x04000780 RID: 1920
		<AccessedThroughProperty("miNew")>
		Private _miNew As MenuItem

		' Token: 0x04000781 RID: 1921
		<AccessedThroughProperty("TextBox24")>
		Private _TextBox24 As TextBox

		' Token: 0x04000782 RID: 1922
		<AccessedThroughProperty("TextBox23")>
		Private _TextBox23 As TextBox

		' Token: 0x04000783 RID: 1923
		<AccessedThroughProperty("TextBox22")>
		Private _TextBox22 As TextBox

		' Token: 0x04000784 RID: 1924
		<AccessedThroughProperty("TextBox46")>
		Private _TextBox46 As TextBox

		' Token: 0x04000785 RID: 1925
		<AccessedThroughProperty("TextBox21")>
		Private _TextBox21 As TextBox

		' Token: 0x04000786 RID: 1926
		<AccessedThroughProperty("TextBox47")>
		Private _TextBox47 As TextBox

		' Token: 0x04000787 RID: 1927
		<AccessedThroughProperty("Label24")>
		Private _Label24 As Label

		' Token: 0x04000788 RID: 1928
		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		' Token: 0x04000789 RID: 1929
		<AccessedThroughProperty("TextBox20")>
		Private _TextBox20 As TextBox

		' Token: 0x0400078A RID: 1930
		<AccessedThroughProperty("Label23")>
		Private _Label23 As Label

		' Token: 0x0400078B RID: 1931
		<AccessedThroughProperty("TextBox48")>
		Private _TextBox48 As TextBox

		' Token: 0x0400078C RID: 1932
		<AccessedThroughProperty("TextBox49")>
		Private _TextBox49 As TextBox

		' Token: 0x0400078D RID: 1933
		<AccessedThroughProperty("TextBox50")>
		Private _TextBox50 As TextBox

		' Token: 0x0400078E RID: 1934
		<AccessedThroughProperty("TextBox19")>
		Private _TextBox19 As TextBox

		' Token: 0x0400078F RID: 1935
		<AccessedThroughProperty("Label22")>
		Private _Label22 As Label

		' Token: 0x04000790 RID: 1936
		<AccessedThroughProperty("TextBox18")>
		Private _TextBox18 As TextBox

		' Token: 0x04000791 RID: 1937
		<AccessedThroughProperty("TextBox51")>
		Private _TextBox51 As TextBox

		' Token: 0x04000792 RID: 1938
		<AccessedThroughProperty("Label21")>
		Private _Label21 As Label

		' Token: 0x04000793 RID: 1939
		<AccessedThroughProperty("TextBox52")>
		Private _TextBox52 As TextBox

		' Token: 0x04000794 RID: 1940
		<AccessedThroughProperty("TextBox53")>
		Private _TextBox53 As TextBox

		' Token: 0x04000795 RID: 1941
		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		' Token: 0x04000796 RID: 1942
		<AccessedThroughProperty("TextBox54")>
		Private _TextBox54 As TextBox

		' Token: 0x04000797 RID: 1943
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000798 RID: 1944
		<AccessedThroughProperty("nudStlh")>
		Private _nudStlh As NumericUpDown

		' Token: 0x04000799 RID: 1945
		<AccessedThroughProperty("nudSrch")>
		Private _nudSrch As NumericUpDown

		' Token: 0x0400079A RID: 1946
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x0400079B RID: 1947
		<AccessedThroughProperty("nudTryUnlock")>
		Private _nudTryUnlock As NumericUpDown

		' Token: 0x0400079C RID: 1948
		<AccessedThroughProperty("nudFailUnlock")>
		Private _nudFailUnlock As NumericUpDown

		' Token: 0x0400079D RID: 1949
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x0400079E RID: 1950
		<AccessedThroughProperty("nudSucceedUnlock")>
		Private _nudSucceedUnlock As NumericUpDown

		' Token: 0x0400079F RID: 1951
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x040007A0 RID: 1952
		<AccessedThroughProperty("nudLeaveParty")>
		Private _nudLeaveParty As NumericUpDown

		' Token: 0x040007A1 RID: 1953
		<AccessedThroughProperty("nudRejoinParty")>
		Private _nudRejoinParty As NumericUpDown

		' Token: 0x040007A2 RID: 1954
		<AccessedThroughProperty("Label10")>
		Private _Label10 As Label

		' Token: 0x040007A3 RID: 1955
		<AccessedThroughProperty("nudPoisoned")>
		Private _nudPoisoned As NumericUpDown

		' Token: 0x040007A4 RID: 1956
		<AccessedThroughProperty("label111")>
		Private _label111 As Label

		' Token: 0x040007A5 RID: 1957
		<AccessedThroughProperty("miSaveAs")>
		Private _miSaveAs As MenuItem

		' Token: 0x040007A6 RID: 1958
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x040007A7 RID: 1959
		<AccessedThroughProperty("miUseK1DialogTlk")>
		Private _miUseK1DialogTlk As MenuItem

		' Token: 0x040007A8 RID: 1960
		<AccessedThroughProperty("miUseK2DialogTlk")>
		Private _miUseK2DialogTlk As MenuItem

		' Token: 0x040007A9 RID: 1961
		<AccessedThroughProperty("miUseExtDialogTlk")>
		Private _miUseExtDialogTlk As MenuItem

		' Token: 0x040007AA RID: 1962
		<AccessedThroughProperty("TextBox17")>
		Private _TextBox17 As TextBox

		' Token: 0x040007AB RID: 1963
		<AccessedThroughProperty("miAskDialogTlk")>
		Private _miAskDialogTlk As MenuItem

		' Token: 0x040007AC RID: 1964
		<AccessedThroughProperty("nudBat1")>
		Private _nudBat1 As NumericUpDown

		' Token: 0x040007AD RID: 1965
		<AccessedThroughProperty("Label11")>
		Private _Label11 As Label

		' Token: 0x040007AE RID: 1966
		<AccessedThroughProperty("tbBat1ResRef")>
		Private _tbBat1ResRef As TextBox

		' Token: 0x040007AF RID: 1967
		<AccessedThroughProperty("tbBat1Desc")>
		Private _tbBat1Desc As TextBox

		' Token: 0x040007B0 RID: 1968
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x040007B1 RID: 1969
		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		' Token: 0x040007B2 RID: 1970
		<AccessedThroughProperty("TextBox4")>
		Private _TextBox4 As TextBox

		' Token: 0x040007B3 RID: 1971
		<AccessedThroughProperty("Label12")>
		Private _Label12 As Label

		' Token: 0x040007B4 RID: 1972
		<AccessedThroughProperty("MainMenu1")>
		Private _MainMenu1 As MainMenu

		' Token: 0x040007B5 RID: 1973
		<AccessedThroughProperty("StatusBar1")>
		Private _StatusBar1 As StatusBar

		' Token: 0x040007B6 RID: 1974
		<AccessedThroughProperty("TextBox5")>
		Private _TextBox5 As TextBox

		' Token: 0x040007B7 RID: 1975
		<AccessedThroughProperty("TextBox6")>
		Private _TextBox6 As TextBox

		' Token: 0x040007B8 RID: 1976
		<AccessedThroughProperty("TextBox7")>
		Private _TextBox7 As TextBox

		' Token: 0x040007B9 RID: 1977
		<AccessedThroughProperty("TextBox8")>
		Private _TextBox8 As TextBox

		' Token: 0x040007BA RID: 1978
		<AccessedThroughProperty("TextBox9")>
		Private _TextBox9 As TextBox

		' Token: 0x040007BB RID: 1979
		<AccessedThroughProperty("Label13")>
		Private _Label13 As Label

		' Token: 0x040007BC RID: 1980
		<AccessedThroughProperty("MenuItem1")>
		Private _MenuItem1 As MenuItem

		' Token: 0x040007BD RID: 1981
		<AccessedThroughProperty("ToolTip1")>
		Private _ToolTip1 As ToolTip

		' Token: 0x040007BE RID: 1982
		<AccessedThroughProperty("Label20")>
		Private _Label20 As Label

		' Token: 0x040007BF RID: 1983
		<AccessedThroughProperty("TextBox10")>
		Private _TextBox10 As TextBox

		' Token: 0x040007C0 RID: 1984
		<AccessedThroughProperty("Label14")>
		Private _Label14 As Label

		' Token: 0x040007C1 RID: 1985
		<AccessedThroughProperty("TextBox11")>
		Private _TextBox11 As TextBox

		' Token: 0x040007C2 RID: 1986
		<AccessedThroughProperty("Label15")>
		Private _Label15 As Label

		' Token: 0x040007C3 RID: 1987
		<AccessedThroughProperty("TextBox16")>
		Private _TextBox16 As TextBox

		' Token: 0x040007C4 RID: 1988
		<AccessedThroughProperty("TextBox12")>
		Private _TextBox12 As TextBox

		' Token: 0x040007C5 RID: 1989
		<AccessedThroughProperty("MenuItem2")>
		Private _MenuItem2 As MenuItem

		' Token: 0x040007C6 RID: 1990
		<AccessedThroughProperty("Label16")>
		Private _Label16 As Label

		' Token: 0x040007C7 RID: 1991
		<AccessedThroughProperty("TextBox13")>
		Private _TextBox13 As TextBox

		' Token: 0x040007C8 RID: 1992
		<AccessedThroughProperty("Label17")>
		Private _Label17 As Label

		' Token: 0x040007C9 RID: 1993
		<AccessedThroughProperty("miQuit")>
		Private _miQuit As MenuItem

		' Token: 0x040007CA RID: 1994
		<AccessedThroughProperty("Panel1")>
		Private _Panel1 As Panel

		' Token: 0x040007CB RID: 1995
		<AccessedThroughProperty("TextBox14")>
		Private _TextBox14 As TextBox

		' Token: 0x040007CC RID: 1996
		<AccessedThroughProperty("Label18")>
		Private _Label18 As Label

		' Token: 0x040007CD RID: 1997
		<AccessedThroughProperty("MenuItem5")>
		Private _MenuItem5 As MenuItem

		' Token: 0x040007CE RID: 1998
		<AccessedThroughProperty("TextBox15")>
		Private _TextBox15 As TextBox

		' Token: 0x040007CF RID: 1999
		<AccessedThroughProperty("Label19")>
		Private _Label19 As Label

		' Token: 0x040007D0 RID: 2000
		<AccessedThroughProperty("TextBox42")>
		Private _TextBox42 As TextBox

		' Token: 0x040007D1 RID: 2001
		Private _SSF As clsSSF

		' Token: 0x040007D2 RID: 2002
		Private g_dialogtlk As clsDialogTlk

		' Token: 0x040007D3 RID: 2003
		Private g_filepath As String
	End Class
End Namespace
