using KSHIFSYSTEM.Data;
using KSHIFSYSTEM.BackEnd.Interfaces;
using KSHIFSYSTEM.Models;
using Microsoft.EntityFrameworkCore;
using KSHIFSYSTEM.ViewModels;
using Microsoft.AspNetCore.Components.Forms;




namespace KSHIFSYSTEM.BackEnd.Repositories
{
    public class DawaRepo : IDawa
    {
        private readonly ApplicationDbContext _db;
        private IWebHostEnvironment _env;

        public DawaRepo(ApplicationDbContext db, IWebHostEnvironment env)
        {
            _db = db;
            _env = env;

        }
        public async Task<string> AddNewDawaToTheSystem (BookInfo NewBook)
        {   
            
            await _db.BookTable.AddAsync (NewBook);

            await _db.SaveChangesAsync();
            return "تمت اضافة الكتاب الى النظام";
        }
        public async Task<bool> CheckIfDawaExistsInDB(BookInfo Newbook)
        {
            var CheckIfDawaExistsInDB = await _db.BookTable.FirstOrDefaultAsync(a => a.BookNo == Newbook.BookNo);

            if (CheckIfDawaExistsInDB is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public async Task<string> DeleteDawa(int DawaId)
        {
            try
            {
                var DeletedDawa = await _db.SpecialestTable.FirstOrDefaultAsync(a => a.ID == DawaId);
                _db.SpecialestTable.Remove(DeletedDawa);
                await _db.SaveChangesAsync();
                return $"{DawaId} deleted Successfully";
            }
            catch (Exception Error)
            {

                return Error.Message;
            }

        }
        public async Task<string> DeleteListOfDawas(List<int> ListOfDeletedDawas)
        {
            try
            {
                var ListOfDeletedDawa = new List<BookInfo>();

                foreach (var item in ListOfDeletedDawas)
                {
                    var Dawa = await _db.BookTable.FirstOrDefaultAsync(a => a.Id == item);
                    ListOfDeletedDawa.Add(Dawa);
                }
                _db.BookTable.RemoveRange(ListOfDeletedDawa);
                await _db.SaveChangesAsync();
                return "تم الحذف بنجاح ";

            }
            catch (Exception Error)
            {

                return Error.Message;
            }
        }
        public async Task<bool> EditEmp(DaawaModel EditedData, InputFileChangeEventArgs EditedPic)
        {
            if (EditedPic is null)
            {
                _db.DawwaTable.Update(EditedData);
                await _db.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<List<BookInfo>> GetAllDawas()
        {
            var ListOfDawas = await _db.BookTable.ToListAsync();
            return ListOfDawas;
        }


        private async Task<string> UploadUserImageToFileSystem(InputFileChangeEventArgs UploadedImage, string EmpName)
        {

            var FileName = EmpName + "_" + Guid.NewGuid().ToString() + $"{UploadedImage.File.Name}";
            // MohammedAbdull_109273918628736127835gbegt675e
            var FolderPath = $"{_env.WebRootPath}\\DawaImages";
            // var FullPath = //server/wwwroot/EmpImages/FileName
            var FullPath = Path.Combine(FolderPath, FileName);

            var MemoryStream = new MemoryStream();
            await UploadedImage.File.OpenReadStream(2000000).CopyToAsync(MemoryStream);


            // FileMode : to give permission to the filestream to create files
            await using (var fs = new FileStream(FullPath, FileMode.Create, FileAccess.Write))
            {
                MemoryStream.WriteTo(fs);
            }

            return FolderPath;
        }


        private void DeleteOldUserImage(string OldImagePath)
        {
            if (File.Exists(OldImagePath) == true)
            {
                File.Delete(OldImagePath);
            }
        }

        //public async Task<List<EmpModel>> GetListOfAllEmps()
        //{
        //    var ListOfEmps = await _db.EmpTable.AsNoTracking().Include(a=>a.DeptTable).ThenInclude(a=>a.OfficeTable).ToListAsync();
        //    return ListOfEmps;
        //}




        public async Task<EmpViewModel> GetEmpViewModelByUserId(int Id)
        {
            var Model = await _db.BookTable.FirstOrDefaultAsync(a => a.Id == Id);

            var EmpViewModel = new EmpViewModel();
            EmpViewModel.Id = Model.Id;
            EmpViewModel.BookNo = Model.BookNo;
            EmpViewModel.KashefType = Model.KashefType;
            EmpViewModel.KshefDate = Model.KshefDate;
            EmpViewModel.BookPic = Model.BookPic;
            EmpViewModel.BookDate = Model.BookDate;
            EmpViewModel.JahaName = Model.JahaName;
            EmpViewModel.PlaceNo = Model.PlaceNo;
            EmpViewModel.MokataNO = Model.MokataNO;

            EmpViewModel.AstmaraDateM = Model.AstmaraDateM;
            EmpViewModel.AstmaraDateP = Model.AstmaraDateP;
            EmpViewModel.AstmaraNoP = Model.AstmaraNoP;
            EmpViewModel.AstmaraNoM = Model.AstmaraNoM;
            EmpViewModel.City = Model.City;

            //EmpViewModel.EmpDep = Model.EmpDep;
            EmpViewModel.AddadAlkhobraa = Model.AddadAlkhobraa;
            EmpViewModel.AlwasilDate = Model.AlwasilDate;
            EmpViewModel.AlwasilNo = Model.AlwasilNo;
            EmpViewModel.HayaBookDate = Model.HayaBookDate;
            EmpViewModel.HayaBookNo = Model.HayaBookNo;

            return EmpViewModel;
        }
        public async Task<string> EditEmpViewModel(EmpViewModel EditedEmp)
        {
            try
            {
                var Model = await _db.BookTable.FirstOrDefaultAsync(a => a.Id == EditedEmp.Id);

                Model.BookNo = EditedEmp.BookNo;
                Model.KashefType = EditedEmp.KashefType;
                Model.KshefDate = EditedEmp.KshefDate;
                Model.BookPic = EditedEmp.BookPic;
                Model.BookDate = EditedEmp.BookDate;
                Model.AstmaraDateM = EditedEmp.AstmaraDateM;
                Model.AstmaraDateP = EditedEmp.AstmaraDateP;
                Model.JahaName = EditedEmp.JahaName;
                Model.PlaceNo = EditedEmp.PlaceNo;
                Model.MokataNO = EditedEmp.MokataNO;
                Model.AstmaraNoP = EditedEmp.AstmaraNoP;
                Model.AstmaraNoM = EditedEmp.AstmaraNoM;
                Model.City = EditedEmp.City;
                Model.AddadAlkhobraa = EditedEmp.AddadAlkhobraa;
                Model.AlwasilDate = EditedEmp.AlwasilDate;
                Model.AlwasilNo = EditedEmp.AlwasilNo;
                Model.HayaBookDate = EditedEmp.HayaBookDate;
                Model.HayaBookNo = EditedEmp.HayaBookNo;
                _db.BookTable.Update(Model);
                await _db.SaveChangesAsync();
                return "The Recored has been edited succesfully";

            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public async Task<BookInfo> GetBookInfo(int BookNo)
        {
            var BookRecord = await _db.BookTable.FirstOrDefaultAsync(a=>a.BookNo == BookNo);
           
            return BookRecord;
        }

        public async Task<bool> CheckIfBookExist(int BookNo)
        {
            var CheckIfDawaExistsInDB = await _db.BookTable.FirstOrDefaultAsync(a => a.BookNo == BookNo);

            if (CheckIfDawaExistsInDB is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public async Task<List<BookInfo>> GetSpecificBooks(List<int> SpecificRecords)
        {

            var ListOfSelected = new List<BookInfo>();

            foreach (var item in SpecificRecords)
            {
                var TarshehRecord = await _db.BookTable.FirstOrDefaultAsync(a => a.Id == item);
                ListOfSelected.Add(TarshehRecord);

            }
            return ListOfSelected;

        }

       
    }
}


