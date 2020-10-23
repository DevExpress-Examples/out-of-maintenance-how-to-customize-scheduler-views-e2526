Imports System
Imports System.Windows
Imports DevExpress.XtraScheduler

Namespace WpfApplication1
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()

'			#Region "#CustomWorkingDays "
			schedulerControl1.WorkDays.BeginUpdate()
			schedulerControl1.WorkDays.Clear()
			schedulerControl1.WorkDays.Add(WeekDays.Monday Or WeekDays.Tuesday Or WeekDays.Wednesday Or WeekDays.Thursday)
			schedulerControl1.WorkDays.EndUpdate()
'			#End Region ' #CustomWorkingDays
		End Sub
	End Class

	#Region "#CustomTimeScale"
	Public Class CustomTimeScale
		Inherits TimeScaleFixedInterval

		' Fields
		Private Const defaultEnabled As Boolean = True
		' Methods
		Public Sub New()
			MyBase.New(TimeSpan.FromHours(4.0))
		End Sub
		Protected Overrides ReadOnly Property DefaultDisplayName() As String
			Get
				Return "Custom Scale"
			End Get
		End Property
		Protected Overrides ReadOnly Property DefaultMenuCaption() As String
			Get
				Return "Custom Scale"
			End Get
		End Property
	End Class
	#End Region ' #CustomTimeScale
End Namespace