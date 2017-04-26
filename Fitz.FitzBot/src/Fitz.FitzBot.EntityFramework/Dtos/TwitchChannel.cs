using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitz.FitzBot.EntityFramework.Dtos
{
    public class TwitchChannel
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
