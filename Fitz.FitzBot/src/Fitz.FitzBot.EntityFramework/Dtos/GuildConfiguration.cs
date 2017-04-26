using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitz.FitzBot.EntityFramework.Dtos
{
    public class GuildConfiguration
    {
        public int id { get; set; }
        // Used to navigate channels
        public string GeneralChannel { get; set; }
        //public string AnnouncementsChannel { get; set; }
        //public string LiveChannel { get; set; }
        //public string OwnerLiveChannel { get; set; }
        //public string VodChannel { get; set; }
        public bool AllowEveryone { get; set; }

    }
}
