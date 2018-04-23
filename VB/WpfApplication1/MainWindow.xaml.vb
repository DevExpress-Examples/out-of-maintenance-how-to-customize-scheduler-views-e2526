Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.XtraScheduler

Namespace WpfApplication1
    Partial Public Class MainWindow
        Inherits Window

#Region "#CustomWorkingDays"
        Public Sub New()
            InitializeComponent()

            schedulerControl1.WorkDays.BeginUpdate()
            schedulerControl1.WorkDays.Clear()
            schedulerControl1.WorkDays.Add(WeekDays.Monday Or WeekDays.Tuesday Or _
                                           WeekDays.Wednesday Or WeekDays.Thursday)
            schedulerControl1.WorkDays.EndUpdate()

        End Sub
#End Region

    End Class
End Namespace