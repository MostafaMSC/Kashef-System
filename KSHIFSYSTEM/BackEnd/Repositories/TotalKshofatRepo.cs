using Microsoft.EntityFrameworkCore;
using KSHIFSYSTEM.BackEnd.Interfaces;
using KSHIFSYSTEM.Data;
using KSHIFSYSTEM.Models;

namespace KSHIFSYSTEM.BackEnd.Repositories
{
    public class TotalKshofatRepo : ITotalKshofat
    {
        private readonly ApplicationDbContext _db;
        public TotalKshofatRepo(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<bool> CheckIfSpecialestExistsInDB(TotalKsofatModule NewSpecialest)
        {
            var CheckIfSpeacialestExistsInDB = await _db.TotalKshofatTable.FirstOrDefaultAsync(a =>a.Name == NewSpecialest.Name);
            if (CheckIfSpeacialestExistsInDB is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public async Task<string> AddNewSpecialestToTheSystem(TotalKsofatModule AddNewSpecialest)
        {
            await _db.TotalKshofatTable.AddAsync(AddNewSpecialest);
            await _db.SaveChangesAsync();
            return "تمت اضافة الخبير الى النظام";
        }
        public async Task<List<KshfInfoModule>> GetAllSpecialest()
        {

            var ListOfSpecialest = await _db.SpecialestTable.ToListAsync();

            return ListOfSpecialest;
        }

        public async Task<List<string>> GetRandomSpecialest(int SpecialestCount, string _searchString)
        {
            var ListOfSpecialest = await _db.SpecialestTable.ToListAsync();

            foreach (var item in ListOfSpecialest)
            {
                var CheckIfSpeacialestExistsInDB = _db.SpecialestTable.FirstOrDefaultAsync(a => a.Name == item.Name);
                if (CheckIfSpeacialestExistsInDB is not null)
                {
                    var KshofatNO1 = item.KshofatNo;
                    var KshofatNO2 = _db.SpecialestTable.Where(a => a.KshifType == item.KshifType).Select(a => a.KshofatNo).FirstOrDefaultAsync();
                    //var TotalKshofat = Convert.ToInt32(_db.SpecialestTable.Select(a => a.TotalKSofat));
                    //var TotalKshofat = KshofatNO1 + KshofatNO2.Result;
                    var Total = _db.SpecialestTable.Where(a => a.Name == item.Name).Sum(a => a.KshofatNo);
                    //_db.SpecialestTable.Select(a => a.TotalKSofat).Append(Total);
                    //await _db.SaveChangesAsync();
                }

            }
            var listOfRandomSpeciales = await _db.SpecialestTable.Where(a => a.KshifType == _searchString).OrderBy(a => a.KshofatNo).Take(SpecialestCount).Select(a => a.Name).ToListAsync();


            return listOfRandomSpeciales;
        }

        

        Task<List<TotalKsofatModule>> ITotalKshofat.GetAllSpecialest()
        {
            throw new NotImplementedException();
        }


    }
}
