﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_1
{
    public class Doc : Document
    {
        public override string file_name { get; set; }
        public override void Create(string file_path)
        {
            throw new NotImplementedException();
        }
        public override void Open(string file_path)
        {
            throw new NotImplementedException();
        }
        public override string Read()
        {
            throw new NotImplementedException();
        }
        public override void Write(string file_change)
        {
            throw new NotImplementedException();
        }
    }
}
