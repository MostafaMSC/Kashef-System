using Microsoft.EntityFrameworkCore;
using KSHIFSYSTEM.BackEnd.Interfaces;
using KSHIFSYSTEM.Data;
using KSHIFSYSTEM.Models;

namespace KSHIFSYSTEM.BackEnd.Repositories
{
    public class KshifInfoRepo : IKshifInfo
    {
        private readonly ApplicationDbContext _db;
        public KshifInfoRepo(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<bool> CheckIfSpecialestExistsInDB(KshfInfoModule NewSpecialest)
        {
            var CheckIfSpeacialestExistsInDB = await _db.SpecialestTable.FirstOrDefaultAsync(a => a.Name == NewSpecialest.Name && a.KshifType==NewSpecialest.KshifType);
            if (CheckIfSpeacialestExistsInDB is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public async Task<string> AddNewSpecialestToTheSystem(KshfInfoModule AddNewSpecialest)
        {
            await _db.SpecialestTable.AddAsync(AddNewSpecialest);
            await _db.SaveChangesAsync();
            return "تمت اضافة الخبير الى النظام";
        }
        public async Task<List<KshfInfoModule>> GetAllSpecialest()
        {

            var ListOfSpecialest = await _db.SpecialestTable.ToListAsync();
            
            return ListOfSpecialest;
        }
        
        public async Task<List<string>> GetRandomSpecialest(int SpecialestCount,string _searchString)
        {
            var ListOfSpecialest = await _db.SpecialestTable.Where(a=>a.SpecialBlock== "متاح للعمل").ToListAsync();

            foreach (var item in ListOfSpecialest)
            {
                var CheckIfSpeacialestExistsInDB = await _db.SpecialestTable.FirstOrDefaultAsync(a => a.Name == item.Name);
                if (CheckIfSpeacialestExistsInDB is not null)
                {
                    var KshofatNO1 = item.KshofatNo;
                    var KshofatNO2 = await _db.SpecialestTable.Where(a => a.KshifType == item.KshifType).Select(a => a.KshofatNo).FirstOrDefaultAsync();
                    //var TotalKshofat = Convert.ToInt32(_db.SpecialestTable.Select(a => a.TotalKSofat));
                    //var TotalKshofat = KshofatNO1 + KshofatNO2.Result;
                    var Total = _db.SpecialestTable.Where(a => a.Name == item.Name).Sum(a => a.KshofatNo);
                    item.TotalKSofat = Total;
                    //_db.SpecialestTable.Select(a => a.TotalKSofat).Append(Total);
                    await _db.SaveChangesAsync();
                }

            }


            if (_searchString == "")
            {
                var listOfRandomSpeciales = await _db.SpecialestTable.OrderBy(a => a.TotalKSofat).Take(SpecialestCount).Select(a => a.Name).ToListAsync();
                return listOfRandomSpeciales;
            }
            else
            {
                var listOfRandomSpeciales = await _db.SpecialestTable.Where(a => a.KshifType == _searchString && a.SpecialBlock == "متاح للعمل").OrderBy(a => a.TotalKSofat).Take(SpecialestCount).Select(a => a.Name).ToListAsync();

                return listOfRandomSpeciales;
            }
            
        }

        public async Task UpdateKshifNo(string SpecialName, string KshifType)
        {
            var SpecialRecord = await _db.SpecialestTable.FirstOrDefaultAsync(a => a.Name == SpecialName && a.KshifType == KshifType);

             SpecialRecord.KshofatNo++; 
            await _db.SaveChangesAsync();
        }

        public async Task<string> DeleteListOfDawas(List<int> ListOfDeletedDawas)
        {
            try
            {
                var ListOfDeletedDawa = new List<KshfInfoModule>();

                foreach (var item in ListOfDeletedDawas)
                {
                    var Dawa = await _db.SpecialestTable.FirstOrDefaultAsync(a => a.ID == item);
                    ListOfDeletedDawa.Add(Dawa);
                }
                _db.SpecialestTable.RemoveRange(ListOfDeletedDawa);
                await _db.SaveChangesAsync();
                return "تم الحذف بنجاح ";

            }
            catch (Exception Error)
            {

                return Error.Message;
            }
        }

        public async Task<string> BlockSpecial(List<int> ListOfBlockedSpecialest)
        {
            if (ListOfBlockedSpecialest == null)
            {
                
                    return "الرجاء اختيار خبير";

            }
            else
            {
                foreach (var item in ListOfBlockedSpecialest)
                {
                    var Record = await _db.SpecialestTable.FirstOrDefaultAsync(a => a.ID == item);
                    Record.SpecialBlock = "ايقاف مؤقت";
                    await _db.SaveChangesAsync();
                    return "تم ايقاف الخبير";

                }
            }

            return "الرجاء اختيار خبير";




        }
        public async Task<string> UnBlockSpecial(List<int> ListOfBlockedSpecialest)
        {
            if (ListOfBlockedSpecialest == null)
            {

                return "الرجاء اختيار خبير";

            }
            else
            {
                foreach (var item in ListOfBlockedSpecialest)
                {
                    var Record = await _db.SpecialestTable.FirstOrDefaultAsync(a => a.ID == item);
                    Record.SpecialBlock = "متاح للعمل";
                    await _db.SaveChangesAsync();
                    return "تم اتاحة الخبير للعمل";
                }
            }
            return "الرجاء اختيار خبير";
        }
        public async Task<List<KshfInfoModule>> GetAllBlockedSpecialest()
        {
            await Task.Delay(2000);

            var ListOfBlockedSpecialest = await _db.SpecialestTable.Where(a=>a.SpecialBlock == "ايقاف مؤقت").ToListAsync();
            
            return ListOfBlockedSpecialest; 
        }


    }
    
}