using Microsoft.EntityFrameworkCore;
using KSHIFSYSTEM.BackEnd.Interfaces;
using KSHIFSYSTEM.Data;
using KSHIFSYSTEM.Models;
using KSHIFSYSTEM.ViewModels;
using MudBlazor.Extensions;

namespace KSHIFSYSTEM.BackEnd.Repositories
{
    public class TarshehRepo :ITarsheh
    {
        private readonly ApplicationDbContext _db;
        public TarshehRepo(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<bool> CheckIfSpecialestExistsInDB(TarshehBook NewSpecialest)
        {
            var CheckIfSpeacialestExistsInDB = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == NewSpecialest.ID);
            if (CheckIfSpeacialestExistsInDB is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public async Task<bool> CheckIfBookExistsInDB(int BookNo)
        {
            var CheckIfSpeacialestExistsInDB = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.BookNo == BookNo);
            if (CheckIfSpeacialestExistsInDB is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public async Task<string> AddNewSpecialestToTheSystem(TarshehBook AddNewSpecialest)
        {

            await _db.TarshehBookTable.AddAsync(AddNewSpecialest);
            await _db.SaveChangesAsync();
            return "تمت اضافة الكتاب الى النظام";
        }

        public async Task<List<TarshehBook>> GetAllTarshehBooks()
        {
            var ListOfTarshehBooks = await _db.TarshehBookTable.ToListAsync();
            return ListOfTarshehBooks;
        }

        public async Task<bool> GetOneBook(int BOOKNO)
        {
            var Record = await _db.TarshehBookTable.FirstOrDefaultAsync(a=>a.BookNo == BOOKNO);
            if (Record is null)
            { return false; }
            else
            {
                if (Record.KshifResult is null)
                { return false; }
                else
                {
                    return true;


                }
            }   
        }

        public async Task<List<TarshehBook>> GetSpecificBooks(List<int> SpecificRecords)
        {
            
                var ListOfSelected = new List<TarshehBook>();

                foreach (var item in SpecificRecords)
                {
                    var TarshehRecord = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == item);
                    ListOfSelected.Add(TarshehRecord);
                       
                }
                return ListOfSelected;            
            
        }
        public async Task<string> DeleteListOfDawas(List<int> ListOfDeletedDawas)
        {
            try
            {
                var ListOfDeletedDawa = new List<TarshehBook>();

                foreach (var item in ListOfDeletedDawas)
                {
                    var Dawa = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == item);
                    ListOfDeletedDawa.Add(Dawa);
                }
                _db.TarshehBookTable.RemoveRange(ListOfDeletedDawa);
                await _db.SaveChangesAsync();
                return "تم الحذف بنجاح ";

            }
            catch (Exception Error)
            {

                return Error.Message;
            }
        }
        public async Task<TarshehViewModel> GetTarshehViewModelByUserId(int Id)
        {
            var Model = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == Id);

            var EmpViewModel = new TarshehViewModel();
            EmpViewModel.Id = Model.ID;
            EmpViewModel.BookNo = Model.BookNo;
            EmpViewModel.KshifType = Model.KshifType;
            EmpViewModel.JehaName = Model.JehaName;

            EmpViewModel.KshefDate = Model.KshefDate;
            EmpViewModel.BookDate = Model.BookDate;
            EmpViewModel.SpecaialName1 = Model.SpecaialName1;
            EmpViewModel.WasilNoP = Model.WasilNoP;
            EmpViewModel.AlwasilNo = Model.AlwasilNo;
            EmpViewModel.AlwasilDate = Model.AlwasilDate;

            EmpViewModel.WasilDateP = Model.WasilDateP;
            EmpViewModel.WasilDateM = Model.WasilDateM;
            EmpViewModel.WasilNoM = Model.WasilNoM;
            EmpViewModel.WasilNoM = Model.WasilNoM;
            EmpViewModel.city = Model.city;
            EmpViewModel.SpecaialName2 = Model.SpecaialName2;
            EmpViewModel.SpecaialName3 = Model.SpecaialName3;
            EmpViewModel.SpecaialName4 = Model.SpecaialName4;
            EmpViewModel.SpecaialName5 = Model.SpecaialName5;
            EmpViewModel.SpecaialName6 = Model.SpecaialName6;
            EmpViewModel.SpecaialName7 = Model.SpecaialName7;
            EmpViewModel.SpecaialName8 = Model.SpecaialName8;
            EmpViewModel.SpecaialName9 = Model.SpecaialName9;
            EmpViewModel.SpecaialName10 = Model.SpecaialName10;


            //EmpViewModel.EmpDep = Model.EmpDep;
            EmpViewModel.KshefDate = Model.KshefDate;
            EmpViewModel.PlaceNo = Model.PlaceNo;
            EmpViewModel.HayaBookDate = Model.HayaBookDate;
            EmpViewModel.HayaBookNo = Model.HayaBookNo;

            return EmpViewModel;
        }
        public async Task<string> EditTarshehViewModel(TarshehViewModel EditedEmp)
        {
            try
            {
                var Model = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.ID == EditedEmp.Id);
                Model.BookNo = EditedEmp.BookNo;
                Model.KshifType = EditedEmp.KshifType;
                Model.KshefDate = EditedEmp.KshefDate;
                Model.BookDate = EditedEmp.BookDate;
                Model.AlwasilDate = EditedEmp.AlwasilDate;
                Model.AlwasilNo = EditedEmp.AlwasilNo;
                Model.city = EditedEmp.city;
                Model.PlaceNo = EditedEmp.PlaceNo;
                Model.WasilDateM = EditedEmp.WasilDateM;
                Model.WasilDateP = EditedEmp.WasilDateP;
                Model.WasilNoM = EditedEmp.WasilNoM;
                Model.WasilNoP = EditedEmp.WasilNoP;
                Model.HayaBookDate = EditedEmp.HayaBookDate;
                Model.HayaBookNo = EditedEmp.HayaBookNo;
                Model.JehaName = EditedEmp.JehaName;

                Model.SpecaialName1 = EditedEmp.SpecaialName1;
                Model.SpecaialName2 = EditedEmp.SpecaialName2;
                Model.SpecaialName3 = EditedEmp.SpecaialName3;
                Model.SpecaialName4 = EditedEmp.SpecaialName4;
                Model.SpecaialName5 = EditedEmp.SpecaialName5;
                Model.SpecaialName6 = EditedEmp.SpecaialName6;
                Model.SpecaialName7 = EditedEmp.SpecaialName7;
                Model.SpecaialName8 = EditedEmp.SpecaialName8;
                Model.SpecaialName9 = EditedEmp.SpecaialName9;
                Model.SpecaialName10 = EditedEmp.SpecaialName10;


                _db.TarshehBookTable.Update(Model);
                await _db.SaveChangesAsync();
                return "The Recored has been edited succesfully";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public async Task<string> DeleteSpecailestName1(int Id, string SpecilestName)
        {
            var Record = await _db.TarshehBookTable.FirstOrDefaultAsync(a=>a.ID == Id);
            

            if (Record == null)
            {
                return "لم يتم الحذف";
            }
            else if (Record.SpecaialName1 == SpecilestName)
            {
                Record.SpecaialName1 = null;
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

        public async Task<bool> CheckIfTheBookResultsAddedPIC(int BookNO)
        {
            var Record = await _db.TarshehBookTable.FirstOrDefaultAsync(a => a.BookNo == BookNO);
            if (Record is null)
            { return false; }
            else
            {
                if (Record.KshifResultPicture is "")
                { 
                    return false; 
                }
                else
                {
                    return true;


                }
            }
        }

        public async Task<List<TarshehBook>> GetSpecialInfoByName(string Name)
        {

            var ListOfTarshehBooks = await _db.TarshehBookTable.Where(a=>a.SpecaialName1 == Name || a.SpecaialName2 == Name || a.SpecaialName3 == Name
            || a.SpecaialName4 == Name || a.SpecaialName5 == Name || a.SpecaialName6 == Name || a.SpecaialName7 == Name
            || a.SpecaialName8 == Name || a.SpecaialName9 == Name || a.SpecaialName10 == Name || a.SpecaialName11 == Name
            || a.SpecaialName12 == Name || a.SpecaialName13 == Name || a.SpecaialName14 == Name || a.SpecaialName15 == Name).ToListAsync();
            return ListOfTarshehBooks;

        }

        public async Task<string> GetSpecialJobTitle(string Name)
        {
            var SpecialRecord = await _db.SpecialestTable.FirstOrDefaultAsync(a=>a.Name == Name);
            if (SpecialRecord != null)
            {
                {
                    var Job = SpecialRecord.JobTitle;
                    return Job;
                }
            }
            else
            {
                return "";
            }
               

           
        }

        public int TotalUncompleteBooks(IEnumerable<TarshehBook> ListOfTarshehBooks)
        {
            int total = 0;
            foreach(var book in ListOfTarshehBooks)
            {
                if (book.KshifResultPicture == null)
                {
                    total++;
                }
                
            }
            return total;
        }
    }
}
