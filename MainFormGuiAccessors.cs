using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackgroundManager {
    partial class MainForm {
        public void AddMonitorDropdownItem(Monitor newMonitor) {
            MonitorSelectDropDown.Items.Add(newMonitor.Name);
        }

        public void ClearMonitorDropdown() {
            MonitorSelectDropDown.Items.Clear();
        }

        public void SetMonitorCount(string text) {
            NumberOfMonitorValue.Text = text;
        }

        public String GetSelectedItem() {
            return (string)MonitorSelectDropDown.SelectedItem;
        }

        public void SetMonitorXValue(int width) {
            MonitorXValue.Text = width.ToString();
        }

        public void SetMonitorYValue(int height) {
            MonitorYValue.Text = height.ToString();
        }
    }
}
