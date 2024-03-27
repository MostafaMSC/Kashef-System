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
        public async Task<string> AddNewDawaToTheSystem(BookInfo NewBook)
        {
            try
            {

                await _db.BookTable.AddAsync(NewBook);

                await _db.SaveChangesAsync();
                return "تمت اضافة الكتاب الى النظام";
            }
            catch (Exception ex)
            {

                // Log the exception or handle it appropriately
                return $"حدث خطأ أثناء إضافة الكتاب إلى النظام: {ex.Message}";

            }
        }
        public async Task<bool> CheckIfDawaExistsInDB(BookInfo Newbook)
        {
            var existsInDB = await _db.BookTable.AnyAsync(a => a.BookNo == Newbook.BookNo);
            return existsInDB;
        }

        public async Task<string> DeleteDawa(int dawaId)
        {
            try
            {
                var deletedDawa = await _db.SpecialestTable.FirstOrDefaultAsync(a => a.ID == dawaId);

                if (deletedDawa != null)
                {
                    _db.SpecialestTable.Remove(deletedDawa);
                    await _db.SaveChangesAsync();
                    return $"{dawaId} deleted successfully";
                }
                else
                {
                    return $"Dawa with ID {dawaId} not found";
                }
            }
            catch (Exception error)
            {
                return $"An error occurred: {error.Message}";
            }
        }

        public async Task<string> DeleteListOfDawas(List<int> listOfDeletedDawas)
        {
            try
            {
                if (listOfDeletedDawas == null || listOfDeletedDawas.Count == 0)
                {
                    return "List is empty or null.";
                }

                var listOfDeletedDawa = new List<BookInfo>();

                foreach (var item in listOfDeletedDawas)
                {
                    var dawa = await _db.BookTable.FirstOrDefaultAsync(a => a.Id == item);

                    if (dawa != null)
                    {
                        listOfDeletedDawa.Add(dawa);
                    }
                    // Optionally: Handle the case when 'dawa' is null (e.g., log or return an error message)
                }

                if (listOfDeletedDawa.Count > 0)
                {
                    _db.BookTable.RemoveRange(listOfDeletedDawa);
                    await _db.SaveChangesAsync();
                    return "تم الحذف بنجاح";
                }
                else
                {
                    return "No valid Dawas found to delete.";
                }
            }
            catch (Exception error)
            {
                return $"An error occurred: {error.Message}";
            }
        }


        public async Task<List<BookInfo>> GetAllDawas()
        {
            try
            {
                return await _db.BookTable.ToListAsync();
            }
            catch (Exception ex)
            {
                // Log or handle the exception according to your application's error-handling strategy
                throw; // Re-throw the exception to indicate that an error occurred
            }
        }



        private async Task<string> UploadUserImageToFileSystem(InputFileChangeEventArgs UploadedImage, string EmpName)
        {

            var FileName = EmpName + "_" + Guid.NewGuid().ToString() + $"{UploadedImage.File.Name}";
            var FolderPath = $"{_env.WebRootPath}\\DawaImages";
            var FullPath = Path.Combine(FolderPath, FileName);

            var MemoryStream = new MemoryStream();
            await UploadedImage.File.OpenReadStream(2000000).CopyToAsync(MemoryStream);


            await using (var fs = new FileStream(FullPath, FileMode.Create, FileAccess.Write))
            {
                MemoryStream.WriteTo(fs);
            }

            return FolderPath;
        }
        public async Task<EmpViewModel> GetEmpViewModelByUserId(int id)
        {
            var model = await _db.BookTable.FirstOrDefaultAsync(a => a.Id == id);

            if (model == null)
            {
                return null; // or throw an exception, depending on your requirements
            }

            var empViewModel = new EmpViewModel
            {
                Id = model.Id,
                BookNo = model.BookNo,
                KashefType = model.KashefType,
                KshefDate = model.KshefDate,
                BookPic = model.BookPic,
                BookDate = model.BookDate,
                JahaName = model.JahaName,
                PlaceNo = model.PlaceNo,
                MokataNO = model.MokataNO,
                AstmaraDateM = model.AstmaraDateM,
                AstmaraDateP = model.AstmaraDateP,
                AstmaraNoP = model.AstmaraNoP,
                AstmaraNoM = model.AstmaraNoM,
                City = model.City,
                AddadAlkhobraa = model.AddadAlkhobraa,
                AlwasilDate = model.AlwasilDate,
                AlwasilNo = model.AlwasilNo,
                HayaBookDate = model.HayaBookDate,
                HayaBookNo = model.HayaBookNo
            };

            return empViewModel;
        }

        public async Task<string> EditEmpViewModel(EmpViewModel editedEmp)
        {
            try
            {
                var model = await _db.BookTable.FirstOrDefaultAsync(a => a.Id == editedEmp.Id);

                if (model == null)
                {
                    return "Record not found"; // or throw an exception, depending on your requirements
                }

                model.BookNo = editedEmp.BookNo;
                model.KashefType = editedEmp.KashefType;
                model.KshefDate = editedEmp.KshefDate;
                model.BookPic = editedEmp.BookPic;
                model.BookDate = editedEmp.BookDate;
                model.AstmaraDateM = editedEmp.AstmaraDateM;
                model.AstmaraDateP = editedEmp.AstmaraDateP;
                model.JahaName = editedEmp.JahaName;
                model.PlaceNo = editedEmp.PlaceNo;
                model.MokataNO = editedEmp.MokataNO;
                model.AstmaraNoP = editedEmp.AstmaraNoP;
                model.AstmaraNoM = editedEmp.AstmaraNoM;
                model.City = editedEmp.City;
                model.AddadAlkhobraa = editedEmp.AddadAlkhobraa;
                model.AlwasilDate = editedEmp.AlwasilDate;
                model.AlwasilNo = editedEmp.AlwasilNo;
                model.HayaBookDate = editedEmp.HayaBookDate;
                model.HayaBookNo = editedEmp.HayaBookNo;

                _db.BookTable.Update(model);
                await _db.SaveChangesAsync();

                return "The record has been edited successfully";
            }
            catch (Exception e)
            {
                return $"An error occurred: {e.Message}";
            }
        }


        public async Task<BookInfo> GetBookInfo(int BookNo)
        {
            var BookRecord = await _db.BookTable.FirstOrDefaultAsync(a => a.BookNo == BookNo);

            return BookRecord;
        }

        public async Task<bool> CheckIfBookExist(int BookNo)
        {
            var CheckIfDawaExistsInDB = await _db.BookTable.FirstOrDefaultAsync(a => a.BookNo == BookNo);

            return CheckIfDawaExistsInDB != null;

        }
        public async Task<List<BookInfo>> GetSpecificBooks(List<int> SpecificRecords)
        {

            var ListOfSelected = new List<BookInfo>();

            var listOfSelected = await _db.BookTable
        .Where(a => SpecificRecords.Contains(a.Id))
        .ToListAsync();
            return ListOfSelected;

        }


    }
}


