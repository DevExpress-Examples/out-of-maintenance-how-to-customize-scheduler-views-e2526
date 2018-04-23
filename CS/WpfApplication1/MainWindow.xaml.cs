using System.Windows;
using DevExpress.XtraScheduler;

namespace WpfApplication1 {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            #region #CustomWorkingDays 
            schedulerControl1.WorkDays.BeginUpdate();
            schedulerControl1.WorkDays.Clear();
            schedulerControl1.WorkDays.Add(WeekDays.Monday | WeekDays.Tuesday | 
                WeekDays.Wednesday | WeekDays.Thursday);
            schedulerControl1.WorkDays.EndUpdate();
            #endregion #CustomWorkingDays
        }
    }
}