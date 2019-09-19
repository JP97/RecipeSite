using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeSite.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public DateTime Timestamp { get; set; }
        public string Text { get; set; }
    }
}
