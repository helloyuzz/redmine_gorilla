using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectoryView {
    public class FileView {
        public FileView(string fileName,string filePath) {
            FileName = fileName;
            FilePath = filePath;
        }

        public string FileName { get; set; }
        public string FilePath { get; set; }
    }
}
