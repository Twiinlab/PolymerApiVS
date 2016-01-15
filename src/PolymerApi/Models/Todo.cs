using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolymerApi.Models
{
    public class Todo
    {
        public int rid { get; set; }

        public string task { get; set; }

        public string user { get; set; }

        public string time { get; set; }
    }
}
