using System.ComponentModel.DataAnnotations;

namespace KSHIFSYSTEM.Models
{
    public class TarshehBook
    {
        public int ID { get; set; }
        [Required]
        public int  BookNo { get; set; }
        public DateTime? BookDate { get; set; }
        public int? HayaBookNo { get; set; }
        public DateTime? HayaBookDate { get; set; } = DateTime.Now.Date;
        public string? JehaName { get; set; }
        public DateTime? KshefDate { get; set; }
        public string? PlaceNo { get; set; }
        public string? MokataNO { get; set; }
        public int?  AddadAlkhobraa { get; set; }
        public int? AlwasilNo { get; set; }
        public DateTime? AlwasilDate { get;set; }
       
        public string? city { get; set; }
        public int? WasilNoM { get; set; }
        public DateTime? WasilDateM { get; set; }
        public int? WasilNoP { get; set; }
        public DateTime? WasilDateP { get; set; }
        public string? KshifType { get; set; }
        public string? SpecaialName1 { get; set; }
        public string? SpecaialName2 { get; set; }
        public string? SpecaialName3 { get; set; }
        public string? SpecaialName4 { get; set; }
        public string? SpecaialName5 { get; set; }
        public string? SpecaialName6 { get; set; }
        public string? SpecaialName7 { get; set; }
        public string? SpecaialName8 { get; set; }
        public string? SpecaialName9 { get; set; }
        public string? SpecaialName10{ get; set; }
        public string? SpecaialName11 { get; set; }

        public string? SpecaialName12 { get; set; }

        public string? SpecaialName13 { get; set; }

        public string? SpecaialName14 { get; set; }

        public string? SpecaialName15 { get; set; }
        public string? SpecaialName16 { get; set; }



        public string? KshifResult { get; set; }
        public string? KshifResultPicture { get; set; }
        public DateTime? Update_Date { get; set; } = DateTime.Now;
        public string? UserName { get; set; }
    }
}
