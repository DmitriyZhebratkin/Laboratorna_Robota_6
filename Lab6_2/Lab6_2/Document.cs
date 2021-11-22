using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_1
{
    public abstract class Document
    {
        public abstract string file_name { get; set; }
        public abstract void Open(string file_path);
        public abstract void Create(string file_path);
        public abstract string Read();
        public abstract void Write(string file_change);
    }
}
