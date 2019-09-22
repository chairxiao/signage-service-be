using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class UserDefineStyle
    {
        public int StyleId { get; set; }
        public string StyleName { get; set; }
        public string StyleInfo { get; set; }
        public string Note { get; set; }
        public string StyleContent { get; set; }
        public string Image { get; set; }
        public string Wid { get; set; }
    }
}
