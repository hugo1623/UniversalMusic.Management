using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalMusic.Management.Application.Dtos
{
    internal class DiscForCreateDto
    {
        public string Name { get; set; }

        public string Artist { get; set; }

        public string GenreType { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int TotalSales { get; set; }

        public bool IsTopTen { get; set; }
    }
}
