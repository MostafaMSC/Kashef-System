using System.ComponentModel.DataAnnotations;

namespace KSHIFSYSTEM.Models
{
    public class KshfInfoModule
    {
        public int ID { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]

        public string KshifType { get; set; }
        [Required]

        public int KshofatNo { get; set; }
        public int TotalKSofat { get; set; }
        public string SpecialBlock { get; set; } = "متاح للعمل";
    }
}
