using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fitz.FitzBot.EntityFramework.Dtos
{
    public class YouTubeChannel
    {
        [Column(TypeName = "varchar(24)")]
        public string Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
