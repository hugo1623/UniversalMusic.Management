namespace UniversalMusic.Management.Application.Dtos
{
    public class ArtistDetailDto
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
        public string Sex { get; set; }
    }
}
