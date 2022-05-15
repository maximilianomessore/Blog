using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Posts { get; set; }
        public string Comments { get; set; }

        public ICollection<Posts> UserPosts { get; set; }
        public ICollection<Comments> UserComments { get; set; }
    }
}
