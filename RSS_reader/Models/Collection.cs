using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSS_reader.Models
{
    public class Collection
    {

        public int Id { set; get; }
        public string Name { set; get; } = "";
        public User Owner { set; get; }
        public List<Channel> Channels { set; get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
