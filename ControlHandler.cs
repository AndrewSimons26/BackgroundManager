using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BackgroundManager {
    class ControlHandler {
        MonitorsInfo screenInfo = new MonitorsInfo();
        MainForm MainForm;

        public ControlHandler(MainForm main) {
            this.MainForm = main;
        }

        public void GetMonitorInfo() {
            screenInfo.PullMonitorInfo();
            AddInfoToContorls();
        }

        public void RefreshMonitorInfo() {
            screenInfo.RefreshInfo();
            ClearMonitorDropdown();
            AddInfoToContorls();
        }

        private void AddInfoToContorls() {
            MainForm.SetMonitorCount(screenInfo.GetMonitorCount().ToString());
            foreach (Monitor screen in screenInfo.GetMonitors()) {
                MainForm.AddMonitorDropdownItem(screen);
            }
        }

        private void ClearMonitorDropdown() {
            MainForm.ClearMonitorDropdown();
        }

        public void SelectMonitor() {
            Monitor SelectedMonitor = screenInfo.GetMonitor(MainForm.GetSelectedItem());
            SetMonitorSize(SelectedMonitor.getScreenSize());
        }

        private void SetMonitorSize(Rectangle MonitorSize) {
            MainForm.SetMonitorXValue(MonitorSize.Width);
            MainForm.SetMonitorYValue(MonitorSize.Height);
        }

    }
}
