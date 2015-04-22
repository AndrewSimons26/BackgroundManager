using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace BackgroundManager {
    class MonitorsInfo {
        List<Monitor> AllMonitor = new List<Monitor>();

        public MonitorsInfo() {
        }

        private List<Monitor> GetInfo() {
            List<Monitor> newMonitors = new List<Monitor>();
            int i = 1;
            foreach (var screen in System.Windows.Forms.Screen.AllScreens) {
                newMonitors.Add(new Monitor(screen,"Screen" + (i++).ToString()));
            }
            return newMonitors;
        }

        public void PullMonitorInfo(){
            AllMonitor.AddRange(GetInfo());
        }

        public void RefreshInfo(){
            AllMonitor.Clear();
            PullMonitorInfo();
        }

        public List<Monitor> GetMonitors() {
            return AllMonitor;
        }

        public int GetMonitorCount() {
            return AllMonitor.Count();
        }

        public Monitor GetMonitor(string name) {
            return AllMonitor.Find(x => x.Name == name);
        }

    }
}
