using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalMusic.Management.Application.Dtos
{
    public class ArtistForListDto
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
    }
}
