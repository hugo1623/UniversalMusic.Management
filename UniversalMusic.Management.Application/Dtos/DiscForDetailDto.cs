namespace UniversalMusic.Management.Application.Dtos
{
    public class DiscForDetailDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Artist { get; set; }

        public string GenreType { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int TotalSales { get; set; }

        public bool IsTopTen { get; set; }
    }
}
