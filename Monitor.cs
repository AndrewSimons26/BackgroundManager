using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace BackgroundManager {
    public class Monitor {
        Screen MonitorScreen;
        public String Name;

        public Monitor(Screen newScreen)
            : this(newScreen, "") {
        }

        public Monitor(Screen newScreen, String name) {
            this.MonitorScreen = newScreen;
            this.Name = name;
        }

        public Rectangle getScreenSize(){
            return MonitorScreen.Bounds;
        }
    }
}
