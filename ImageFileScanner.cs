using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BackgroundManager {
    class ImageFileScanner {
        string DirectoryPath;

        public void SetDirectory(string path) {
            this.DirectoryPath = path;
        }

        public List<string> Scan() {
            List<string> ImagePaths = new List<string>();
            List<string> ImageDirectories = ScanForSubDirectories(DirectoryPath);

            ImageDirectories.Add(DirectoryPath);

            foreach (string directory in ImageDirectories) {
                ImagePaths.AddRange(ScanForImages(directory));
            }

            return FilterForImages(ImagePaths);
            
        }

        private List<string> FilterForImages(List<string> AllFiles) {
            List<string> JustImageFiles = new List<string>();

            JustImageFiles.AddRange(AllFiles.Where(file => file.ToLower().EndsWith(".png") || file.ToLower().EndsWith(".jpg") || file.ToLower().EndsWith(".jpeg")));


            return JustImageFiles;
        }

        private List<string> ScanForImages(string directory) {
            return Directory.GetFiles(directory).ToList();
        }

        private List<string> ScanForSubDirectories(string ParentDirectory) {
            List<string> NewSubDirectories = new List<string>();
            string[] SubDirectories = Directory.GetDirectories(ParentDirectory);
            if (SubDirectories.Count() > 0) {
                foreach (string path in SubDirectories) {
                    NewSubDirectories.Add(path);
                    List<string> temp = ScanForSubDirectories(path);
                    if (temp != null) {
                        NewSubDirectories.AddRange(temp);
                    }                    
                }
            }
            else {
                return null;
            }

            return NewSubDirectories;
        }
    }
}
