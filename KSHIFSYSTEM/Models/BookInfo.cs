using System.ComponentModel.DataAnnotations;

namespace KSHIFSYSTEM.Models
{
    public class BookInfo
    {
        public int Id { get; set; }
        [Required]
        public int BookNo { get; set; }
        [Required]
        public DateTime? BookDate { get; set; }
        [Required]
        public int? HayaBookNo { get; set; }
        [Required]
        public DateTime? HayaBookDate { get; set; }
        [Required]
        public string? PlaceNo { get; set; }
        [Required]
        public string? MokataNO { get; set; }
        [Required]
        public string? City { get; set; }
        [Required]
        public string? KashefType { get; set; }
        [Required]
        public string JahaName { get; set; }
        public DateTime? KshefDate { get; set; } 
        public int? AddadAlkhobraa { get; set; }
        [Required]
        public int? AstmaraNoP { get; set; }
        [Required]
        public DateTime? AstmaraDateP { get; set; }
        [Required]
        public int? AstmaraNoM { get; set; }
        [Required]
        public DateTime? AstmaraDateM { get; set; }
        [Required]
        public int? AlwasilNo { get; set; }
        [Required]
        public DateTime? AlwasilDate { get; set; }
        public string? BookPic { get; set; }
        public DateTime? Update_Date { get; set; } = DateTime.Now;
        public string? UserName { get; set; }

    }
}
