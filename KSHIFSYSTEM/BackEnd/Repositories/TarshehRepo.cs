using Microsoft.EntityFrameworkCore;
using KSHIFSYSTEM.BackEnd.Interfaces;
using KSHIFSYSTEM.Data;
using KSHIFSYSTEM.Models;
using KSHIFSYSTEM.ViewModels;

namespace KSHIFSYSTEM.BackEnd.Repositories
{
    public class TarshehRepo : ITarsheh
    {
        private readonly ApplicationDbContext _db;
        public TarshehRepo(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<bool> CheckIfSpecialestExistsInDB(TarshehBook NewSpecialest)
        {
            var existingSpecialist = await _db.TarshehBookTable
            .FirstOrDefaultAsync(a => a.ID == NewSpecialest.ID);

            return existingSpecialist != null;

        }

        public async Task<bool> CheckIfBookExistsInDB(int BookNo)
        {
            var CheckIfSpeacialestExistsInDB = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.BookNo == BookNo);
            return CheckIfSpeacialestExistsInDB != null;

        }
        public async Task<string> AddNewSpecialestToTheSystem(TarshehBook AddNewSpecialest)
        {

            await _db.TarshehBookTable.AddAsync(AddNewSpecialest);
            await _db.SaveChangesAsync();
            return "تمت اضافة الكتاب الى النظام";
        }

        public async Task<List<TarshehBook>> GetAllTarshehBooks()
        {
            return await _db.TarshehBookTable.ToListAsync();

        }

        public async Task<bool> GetOneBook(int BOOKNO)
        {
            var record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.BookNo == BOOKNO);
            return record != null && record.KshifResult != null;

        }

        public async Task<List<TarshehBook>> GetSpecificBooks(List<int> SpecificRecords)
        {

            var listOfSelected = await _db.TarshehBookTable
                .Where(a => SpecificRecords.Contains(a.ID))
                .ToListAsync();

            return listOfSelected;


        }
        public async Task<string> DeleteListOfDawas(List<int> ListOfDeletedDawas)
        {
            try
            {
                var listOfDeletedDawa = await _db.TarshehBookTable
                    .Where(a => ListOfDeletedDawas.Contains(a.ID))
                    .ToListAsync();

                _db.TarshehBookTable.RemoveRange(listOfDeletedDawa);
                await _db.SaveChangesAsync();

                return "تم الحذف بنجاح";
            }
            catch (DbUpdateException ex)
            {
                // Log the exception or handle it as appropriate for your application
                return "حدث خطأ أثناء الحذف: " + ex.Message;
            }

        }
        public async Task<TarshehViewModel> GetTarshehViewModelByUserId(int Id)
        {
            var model = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == Id);

            var empViewModel = new TarshehViewModel
            {
                Id = model.ID,
                BookNo = model.BookNo,
                KshifType = model.KshifType,
                JehaName = model.JehaName,
                KshefDate = model.KshefDate,
                BookDate = model.BookDate,
                SpecaialName1 = model.SpecaialName1,
                WasilNoP = model.WasilNoP,
                AlwasilNo = model.AlwasilNo,
                AlwasilDate = model.AlwasilDate,
                WasilDateP = model.WasilDateP,
                WasilDateM = model.WasilDateM,
                WasilNoM = model.WasilNoM,
                city = model.city,
                SpecaialName2 = model.SpecaialName2,
                SpecaialName3 = model.SpecaialName3,
                SpecaialName4 = model.SpecaialName4,
                SpecaialName5 = model.SpecaialName5,
                SpecaialName6 = model.SpecaialName6,
                SpecaialName7 = model.SpecaialName7,
                SpecaialName8 = model.SpecaialName8,
                SpecaialName9 = model.SpecaialName9,
                SpecaialName10 = model.SpecaialName10,
                SpecaialName11 = model.SpecaialName11,
                SpecaialName12 = model.SpecaialName12,
                SpecaialName13 = model.SpecaialName13,
                SpecaialName14 = model.SpecaialName14,

                SpecaialName15 = model.SpecaialName15,


                PlaceNo = model.PlaceNo,
                MokataNO = model.MokataNO,

                HayaBookDate = model.HayaBookDate,
                HayaBookNo = model.HayaBookNo
            };

            return empViewModel;

        }
        public async Task<string> EditTarshehViewModel(TarshehViewModel EditedEmp)
        {
            try
            {
                var existingModel = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == EditedEmp.Id);

                if (existingModel != null)
                {
                    existingModel.BookNo = EditedEmp.BookNo;
                    existingModel.KshifType = EditedEmp.KshifType;
                    existingModel.KshefDate = EditedEmp.KshefDate;
                    existingModel.BookDate = EditedEmp.BookDate;
                    existingModel.AlwasilDate = EditedEmp.AlwasilDate;
                    existingModel.AlwasilNo = EditedEmp.AlwasilNo;
                    existingModel.city = EditedEmp.city;
                    existingModel.PlaceNo = EditedEmp.PlaceNo;
                    existingModel.MokataNO = EditedEmp.MokataNO;

                    existingModel.WasilDateM = EditedEmp.WasilDateM;
                    existingModel.WasilDateP = EditedEmp.WasilDateP;
                    existingModel.WasilNoM = EditedEmp.WasilNoM;
                    existingModel.WasilNoP = EditedEmp.WasilNoP;
                    existingModel.HayaBookDate = EditedEmp.HayaBookDate;
                    existingModel.HayaBookNo = EditedEmp.HayaBookNo;
                    existingModel.JehaName = EditedEmp.JehaName;

                    existingModel.SpecaialName1 = EditedEmp.SpecaialName1;
                    existingModel.SpecaialName2 = EditedEmp.SpecaialName2;
                    existingModel.SpecaialName3 = EditedEmp.SpecaialName3;
                    existingModel.SpecaialName4 = EditedEmp.SpecaialName4;
                    existingModel.SpecaialName5 = EditedEmp.SpecaialName5;
                    existingModel.SpecaialName6 = EditedEmp.SpecaialName6;
                    existingModel.SpecaialName7 = EditedEmp.SpecaialName7;
                    existingModel.SpecaialName8 = EditedEmp.SpecaialName8;
                    existingModel.SpecaialName9 = EditedEmp.SpecaialName9;
                    existingModel.SpecaialName10 = EditedEmp.SpecaialName10;
                    existingModel.SpecaialName11 = EditedEmp.SpecaialName11;
                    existingModel.SpecaialName12 = EditedEmp.SpecaialName12;
                    existingModel.SpecaialName13 = EditedEmp.SpecaialName13;
                    existingModel.SpecaialName14 = EditedEmp.SpecaialName14;
                    existingModel.SpecaialName15 = EditedEmp.SpecaialName15;

                    _db.TarshehBookTable.Update(existingModel);
                    await _db.SaveChangesAsync();

                    return "The record has been edited successfully";
                }
                else
                {
                    return "Record not found for the given ID";
                }
            }
            catch (Exception e)
            {
                return $"An error occurred while editing the record: {e.Message}";
            }

        }

        public async Task<string> DeleteSpecailestName1(int Id, string SpecilestName)
        {
            var record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == Id);

            if (record == null)
            {
                return "لم يتم الحذف";
            }

            if (record.SpecaialName1 == SpecilestName)
            {
                record.SpecaialName1 = null;
                await _db.SaveChangesAsync();
                return "تم الحذف";
            }

            return "لم يتم الحذف";

        }
        public async Task<string> DeleteSpecailestName2(int Id, string SpecilestName)
        {
            var Record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == Id);


            if (Record == null)
            {
                return "لم يتم الحذف";
            }
            else if (Record.SpecaialName2 == SpecilestName)
            {
                Record.SpecaialName2 = null;
                await _db.SaveChangesAsync();
                return "تم الحذف";


            }
            return "لم يتم الحذف";
        }
        public async Task<string> DeleteSpecailestName3(int Id, string SpecilestName)
        {
            var Record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == Id);


            if (Record == null)
            {
                return "لم يتم الحذف";
            }
            else if (Record.SpecaialName3 == SpecilestName)
            {
                Record.SpecaialName3 = null;
                await _db.SaveChangesAsync();
                return "تم الحذف";


            }
            return "لم يتم الحذف";
        }
        public async Task<string> DeleteSpecailestName4(int Id, string SpecilestName)
        {
            var Record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == Id);


            if (Record == null)
            {
                return "لم يتم الحذف";
            }
            else if (Record.SpecaialName4 == SpecilestName)
            {
                Record.SpecaialName4 = null;
                await _db.SaveChangesAsync();
                return "تم الحذف";


            }
            return "لم يتم الحذف";
        }

        public async Task<string> DeleteSpecailestName5(int Id, string SpecilestName)
        {
            var Record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == Id);


            if (Record == null)
            {
                return "لم يتم الحذف";
            }
            else if (Record.SpecaialName5 == SpecilestName)
            {
                Record.SpecaialName5 = null;
                await _db.SaveChangesAsync();
                return "تم الحذف";


            }
            return "لم يتم الحذف";
        }
        public async Task<string> DeleteSpecailestName6(int Id, string SpecilestName)
        {
            var Record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == Id);


            if (Record == null)
            {
                return "لم يتم الحذف";
            }
            else if (Record.SpecaialName6 == SpecilestName)
            {
                Record.SpecaialName6 = null;
                await _db.SaveChangesAsync();
                return "تم الحذف";


            }
            return "لم يتم الحذف";
        }
        public async Task<string> DeleteSpecailestName7(int Id, string SpecilestName)
        {
            var Record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == Id);


            if (Record == null)
            {
                return "لم يتم الحذف";
            }
            else if (Record.SpecaialName7 == SpecilestName)
            {
                Record.SpecaialName7 = null;
                await _db.SaveChangesAsync();
                return "تم الحذف";


            }
            return "لم يتم الحذف";
        }
        public async Task<string> DeleteSpecailestName8(int Id, string SpecilestName)
        {
            var Record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == Id);


            if (Record == null)
            {
                return "لم يتم الحذف";
            }
            else if (Record.SpecaialName8 == SpecilestName)
            {
                Record.SpecaialName8 = null;
                await _db.SaveChangesAsync();
                return "تم الحذف";


            }
            return "لم يتم الحذف";
        }
        public async Task<string> DeleteSpecailestName9(int Id, string? SpecilestName)
        {
            var Record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == Id);


            if (Record == null)
            {
                return "لم يتم الحذف";
            }
            else if (Record.SpecaialName9 == SpecilestName)
            {
                Record.SpecaialName9 = null;
                await _db.SaveChangesAsync();
                return "تم الحذف";


            }
            return "لم يتم الحذف";
        }
        public async Task<string> DeleteSpecailestName10(int Id, string SpecilestName)
        {
            var Record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == Id);


            if (Record == null)
            {
                return "لم يتم الحذف";
            }
            else if (Record.SpecaialName10 == SpecilestName)
            {
                Record.SpecaialName10 = null;
                await _db.SaveChangesAsync();
                return "تم الحذف";


            }
            return "لم يتم الحذف";
        }
        public async Task<string> DeleteSpecailestName11(int Id, string SpecilestName)
        {
            var Record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == Id);


            if (Record == null)
            {
                return "لم يتم الحذف";
            }
            else if (Record.SpecaialName11 == SpecilestName)
            {
                Record.SpecaialName11 = null;
                await _db.SaveChangesAsync();
                return "تم الحذف";


            }
            return "لم يتم الحذف";
        }
        public async Task<string> DeleteSpecailestName12(int Id, string SpecilestName)
        {
            var Record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == Id);


            if (Record == null)
            {
                return "لم يتم الحذف";
            }
            else if (Record.SpecaialName12 == SpecilestName)
            {
                Record.SpecaialName12 = null;
                await _db.SaveChangesAsync();
                return "تم الحذف";


            }
            return "لم يتم الحذف";
        }
        public async Task<string> DeleteSpecailestName13(int Id, string SpecilestName)
        {
            var Record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == Id);


            if (Record == null)
            {
                return "لم يتم الحذف";
            }
            else if (Record.SpecaialName13 == SpecilestName)
            {
                Record.SpecaialName13 = null;
                await _db.SaveChangesAsync();
                return "تم الحذف";


            }
            return "لم يتم الحذف";
        }
        public async Task<string> DeleteSpecailestName14(int Id, string SpecilestName)
        {
            var Record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == Id);


            if (Record == null)
            {
                return "لم يتم الحذف";
            }
            else if (Record.SpecaialName14 == SpecilestName)
            {
                Record.SpecaialName14 = null;
                await _db.SaveChangesAsync();
                return "تم الحذف";


            }
            return "لم يتم الحذف";
        }
        public async Task<string> DeleteSpecailestName15(int Id, string SpecilestName)
        {
            var Record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == Id);


            if (Record == null)
            {
                return "لم يتم الحذف";
            }
            else if (Record.SpecaialName15 == SpecilestName)
            {
                Record.SpecaialName15 = null;
                await _db.SaveChangesAsync();
                return "تم الحذف";


            }
            return "لم يتم الحذف";
        }
        public async Task<string> DeleteSpecailestName16(int Id, string SpecilestName)
        {
            var Record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == Id);


            if (Record == null)
            {
                return "لم يتم الحذف";
            }
            else if (Record.SpecaialName16 == SpecilestName)
            {
                Record.SpecaialName16 = null;
                await _db.SaveChangesAsync();
                return "تم الحذف";


            }
            return "لم يتم الحذف";
        }
        public async Task<bool> CheckIfTheBookResultsAddedPIC(int BookNO)
        {
            var record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.BookNo == BookNO);

            return record != null && !string.IsNullOrEmpty(record.KshifResultPicture);

        }

        public async Task<List<TarshehBook>> GetSpecialInfoByName(string Name)
        {

            var ListOfTarshehBooks = await _db.TarshehBookTable.Where(a => a.SpecaialName1 == Name || a.SpecaialName2 == Name || a.SpecaialName3 == Name
            || a.SpecaialName4 == Name || a.SpecaialName5 == Name || a.SpecaialName6 == Name || a.SpecaialName7 == Name
            || a.SpecaialName8 == Name || a.SpecaialName9 == Name || a.SpecaialName10 == Name || a.SpecaialName11 == Name
            || a.SpecaialName12 == Name || a.SpecaialName13 == Name || a.SpecaialName14 == Name || a.SpecaialName15 == Name).ToListAsync();
            return ListOfTarshehBooks;

        }

        public async Task<string> GetSpecialJobTitle(string Name)
        {
            var specialRecord = await _db.SpecialestTable.FirstOrDefaultAsync(a => a.Name == Name);

            return specialRecord?.JobTitle ?? "";




        }

        public int TotalUncompleteBooks(IEnumerable<TarshehBook> ListOfTarshehBooks)
        {
            int total = ListOfTarshehBooks.Count(book => book.KshifResultPicture == null);
            return total;

        }
    }
}
