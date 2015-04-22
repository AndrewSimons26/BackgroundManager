using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackgroundManager {
    public partial class MainForm : Form {
        ControlHandler GuiHandler;
         
        public MainForm() {
            InitializeComponent();
            GuiHandler = new ControlHandler(this);
            GuiHandler.GetMonitorInfo();
        }

        private void UpdateMonitorInfoButton_Click(object sender, EventArgs e) {
            GuiHandler.RefreshMonitorInfo();
        }

        private void MonitorDropdown_SelectionChanged(object sender, EventArgs e) {
            GuiHandler.SelectMonitor();
        }
    }
}
