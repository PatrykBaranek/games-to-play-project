using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesToPlayProject.Entities
{
    public class GamesEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TimeSpent { get; set; }
        public string ImgUrl { get; set; }
        public bool IsFinished { get; set; }
        public IdentityUser Owner { get; set; }
    }
}
