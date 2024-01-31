using KSHIFSYSTEM.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace KSHIFSYSTEM.ViewModels
{
    public class JazaeaViewModel
    {
        public int Id { get; set; }

        //الدعوى
        public string SelectDawa { get; set; }

        //رقم الدعوى
        public string DawaNumber { get; set; }

        //المشتكي
        public string Name1 { get; set; }

        //المشكوى منه
        public string Name2 { get; set; }

        //موضوع الشكوى
        public string DawaSubject { get; set; }



        //اسم التشكيل
        public string Office { get; set; }

        //المحكمة المختصة
        public string Court { get; set; }

        //رقم القرار الجزائي
        public string Decision1Num { get; set; }

        //صورة القرار الجزائي
        public string Decision1ImagePath { get; set; }

        public int AstanafNO { get; set; }


        public int TameezNO { get; set; }


        public int TashehNO { get; set; }


        public int qraraadaNO { get; set; }


        public string AkherALajraaat { get; set; }
        //الملاحظات
        public string Notes { get; set; }



        //تاريخ التحديث
        public DateTime LastUpdate { get; set; }
    }
}
