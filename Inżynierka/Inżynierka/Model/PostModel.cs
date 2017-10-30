using System;
using System.Collections.Generic;
using System.Text;

namespace Inżynierka.Model
{
    class PostModel
    {
        public int id { get; set; }
        public string path { get; set; }
        public DateTime createDate { get; set; }
        public DateTime publishDate { get; set; }
        public bool isVisible { get; set; }
        public string author { get; set; }

    }
}
