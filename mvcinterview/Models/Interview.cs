using System.ComponentModel.DataAnnotations;

namespace mvcinterview.Models
{
    public class Interview
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
