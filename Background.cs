using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BackgroundManager {
    public class Background {
        int Width;
        int Height;
        string ImageFilePath;

        public Background() : this(0,0,"") {
        }

        public Background(string path) :this(0,0,path) {
        }

        public Background(int width, int height, string path) {
            this.Width = width;
            this.Height = height;
            this.ImageFilePath = path;
        }

        public string getFilepath() {
            return ImageFilePath;
        }
        
    }
}
