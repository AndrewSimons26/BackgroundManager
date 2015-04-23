using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackgroundManager {
    static class BackgroundCollection {
        static Dictionary<string, Background> Images;

        static BackgroundCollection() {
            Images = new Dictionary<string,Background>();
        }

        static void AddBackground(Background newBackground) {
            Images.Add(newBackground.getFilepath(), newBackground);
        }

        static Background getBackground(string filepath) {
            return Images[filepath];
        }
    }
}
