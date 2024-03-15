using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCelebrityApplication.ViewModels
{
    class CelebrityPageViewModel
    {
        public static List<Models.Celebrity> TheCelebrities { get; set; }
        public Models.Celebrity Celebrity { get; set; }

        public CelebrityPageViewModel()
        {
            TheCelebrities = new List<Models.Celebrity>();

            var task = Task.Run(() => TheCelebrities); 
            task.Wait();
        }
    }
}
