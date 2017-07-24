using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSS_reader.Models
{
    public class Channel
    {
        public int Id { set; get; }
        public string Name { set; get; } = "";
        public string Url { set; get; } = "";
        public Collection Collection { set; get; }
        public List<News> News { set; get; }
        public string Title { set; get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
