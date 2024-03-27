using KSHIFSYSTEM.Models;
using KSHIFSYSTEM.ViewModels;
using Microsoft.AspNetCore.Components.Forms;

namespace KSHIFSYSTEM.BackEnd.Interfaces
{
    public interface IDawa
    {
        public Task<bool> CheckIfDawaExistsInDB(BookInfo book);
        public Task<bool> CheckIfBookExist(int BookNo);

        public Task<string> AddNewDawaToTheSystem(BookInfo NewBook);

        public Task<BookInfo> GetBookInfo(int BookNo);

        public Task<List<BookInfo>> GetSpecificBooks(List<int> SpecificRecords);

        public Task<List<BookInfo>> GetAllDawas();
        public Task<string> DeleteDawa(int DawaId);
        public Task<string> DeleteListOfDawas(List<int> ListOfDeletedDawas);
        public Task<EmpViewModel> GetEmpViewModelByUserId(int Id);
        public Task<string> EditEmpViewModel(EmpViewModel EditedEmp);
    }
}
