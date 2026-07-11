using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager.Domain.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;   
        public string Representative { get; set; } = string.Empty;  
        public string TeamGuid { get; set; } = string.Empty;
        public string DateCreated { get; set; } = string.Empty;

        public List<Player> Players { get; set; } = new ();
    }
}
