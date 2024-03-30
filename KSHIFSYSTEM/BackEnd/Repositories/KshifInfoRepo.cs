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
            var existsInDB = await _db.SpecialestTable
                    .FirstOrDefaultAsync(a => a.Name == NewSpecialest.Name && a.KshifType == NewSpecialest.KshifType);

            return existsInDB != null;
        }
        public async Task<string> AddNewSpecialestToTheSystem(KshfInfoModule newSpecialist)
        {
            try
            {
                await _db.SpecialestTable.AddAsync(newSpecialist);
                await _db.SaveChangesAsync();
                return "تمت إضافة الخبير إلى النظام";
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as appropriate for your application
                return $"فشلت عملية إضافة الخبير إلى النظام: {ex.Message}";
            }
        }

        public async Task<List<KshfInfoModule>> GetAllSpecialest()
        {
            try
            {
                var listOfSpecialists = await _db.SpecialestTable.ToListAsync();
                return listOfSpecialists;
            }
            catch (Exception ex)
            {
                return new List<KshfInfoModule>();
            }
        }


        public async Task<List<string>> GetRandomSpecialest(int specialistCount, string searchString)
        {
            var availableSpecialists = await _db.SpecialestTable
                .Where(a => a.SpecialBlock == "متاح للعمل")
                .ToListAsync();

            foreach (var specialist in availableSpecialists)
            {
                var existingSpecialist = await _db.SpecialestTable
                    .FirstOrDefaultAsync(a => a.Name == specialist.Name);

                if (existingSpecialist != null)
                {
                    var totalKshofat = _db.SpecialestTable
                        .Where(a => a.Name == specialist.Name)
                        .Sum(a => a.KshofatNo);

                    specialist.TotalKSofat = totalKshofat;
                    await _db.SaveChangesAsync();
                }
            }

            IQueryable<KshfInfoModule> query;

            if (string.IsNullOrWhiteSpace(searchString))
            {
                query = _db.SpecialestTable;
            }
            else
            {
                query = _db.SpecialestTable
                    .Where(a => a.KshifType == searchString && a.SpecialBlock == "متاح للعمل");
            }

            var listOfRandomSpecialists = await query
                .OrderBy(a => a.TotalKSofat)
                .Take(specialistCount)
                .Select(a => a.Name)
                .ToListAsync();

            return listOfRandomSpecialists;
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
                var deletedDawas = await _db.SpecialestTable
                    .Where(a => ListOfDeletedDawas.Contains(a.ID))
                    .ToListAsync();

                _db.SpecialestTable.RemoveRange(deletedDawas);
                await _db.SaveChangesAsync();

                var deletedDawaNames = string.Join(", ", deletedDawas.Select(d => d.Name));
                return $"تم حذف الدعاوى بنجاح: {deletedDawaNames}";
            }
            catch (Exception error)
            {
                return $"حدث خطأ أثناء الحذف: {error.Message}";
            }
        }


        public async Task<string> BlockSpecial(List<int> listOfBlockedSpecialists)
        {
            if (listOfBlockedSpecialists == null || listOfBlockedSpecialists.Count == 0)
            {
                return "الرجاء اختيار خبير";
            }

            foreach (var item in listOfBlockedSpecialists)
            {
                var record = await _db.SpecialestTable.FirstOrDefaultAsync(a => a.ID == item);

                if (record != null)
                {
                    record.SpecialBlock = "ايقاف مؤقت";
                    await _db.SaveChangesAsync();
                }
            }

            return "تم ايقاف الخبراء بنجاح";
        }

        public async Task<string> UnBlockSpecial(List<int> listOfBlockedSpecialists)
        {
            if (listOfBlockedSpecialists == null || listOfBlockedSpecialists.Count == 0)
            {
                return "الرجاء اختيار خبير";
            }
            else
            {
                foreach (var item in listOfBlockedSpecialists)
                {
                    var record = await _db.SpecialestTable.FirstOrDefaultAsync(a => a.ID == item);

                    if (record != null)
                    {
                        record.SpecialBlock = "متاح للعمل";
                        await _db.SaveChangesAsync();
                    }
                }

                return "تم إتاحة الخبراء للعمل بنجاح";
            }

            return "الرجاء اختيار خبير";
        }

        public async Task<List<KshfInfoModule>> GetAllBlockedSpecialest()
        {
            await Task.Delay(2000);
            var listOfBlockedSpecialists = await _db.SpecialestTable
                .Where(a => a.SpecialBlock == "ايقاف مؤقت")
                .ToListAsync();

            return listOfBlockedSpecialists;
        }


    }

}