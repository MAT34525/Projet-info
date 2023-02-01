using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projects
{
    public class BitMap
    {
        public byte[] Header { get; set; }
        public byte[] ImageInfo { get; set; }
        public byte[] Image { get; set; }

        public BitMap(string Path){
            byte[] myfile = File.ReadAllBytes(Path);
            this.Header= myfile.Where((x, i) => i < 14).ToArray();
            this.ImageInfo= myfile.Where((x, i) => i >= 14 && i < 54).ToArray();
            this.Image= myfile.Where((x, i) => i >= 54).ToArray();
        }
    }
}