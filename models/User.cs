using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo_rpg_csharp.models
{
    public class User
    {
        
        public string email { get; set; }
        public string password { get; set; }
        public Hero userHero { get; set; }
        
    }
}