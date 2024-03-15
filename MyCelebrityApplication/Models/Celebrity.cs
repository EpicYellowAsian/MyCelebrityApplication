using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyCelebrityApplication.Models
{
        public class Celebrity 
        {
            public string name { get; set; }
            public long net_worth { get; set; }
            public string gender { get; set; }
            public string nationality { get; set; }
            public string[] occupation { get; set; }
            public float height { get; set; }
            public string birthday { get; set; }
        } 
}
