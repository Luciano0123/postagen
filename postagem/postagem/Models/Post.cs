using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postagem.Models
{
    public class Post
    {
        public int Userid{ get; set; }
        public int Id { get => Id; set => Id = value; }
        public String Name { get; set; }
        public String body { get; set; }

    }
}
