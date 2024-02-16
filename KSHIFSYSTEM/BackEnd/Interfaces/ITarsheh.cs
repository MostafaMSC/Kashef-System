    using KSHIFSYSTEM.Models;
using KSHIFSYSTEM.ViewModels;

namespace KSHIFSYSTEM.BackEnd.Interfaces
{
    public interface ITarsheh
    {
        public Task<bool> CheckIfSpecialestExistsInDB(TarshehBook NewSpecialest);
        public Task<bool> CheckIfBookExistsInDB(int BookNO);
        public Task<bool> GetOneBook(int BOOKNO);
        public Task<List<TarshehBook>> GetSpecificBooks(List<int> SpecificRecords);
        public Task<string> AddNewSpecialestToTheSystem(TarshehBook AddNewSpecialest);
        public Task<List<TarshehBook>> GetAllTarshehBooks();
        public Task<string> DeleteListOfDawas(List<int> ListOfDeletedDawas);

        public Task<TarshehViewModel> GetTarshehViewModelByUserId(int Id);
        public Task<string> EditTarshehViewModel(TarshehViewModel EditedEmp);
        public Task<string> DeleteSpecailestName1(int Id, string? SpecilestName);
        public Task<string> DeleteSpecailestName2(int Id, string? SpecilestName);

        public Task<string> DeleteSpecailestName3(int Id, string? SpecilestName);

        public Task<string> DeleteSpecailestName4(int Id, string? SpecilestName);

        public Task<string> DeleteSpecailestName5(int Id, string? SpecilestName);

        public Task<string> DeleteSpecailestName6(int Id, string? SpecilestName);

        public Task<string> DeleteSpecailestName7(int Id, string? SpecilestName);

        public Task<string> DeleteSpecailestName8(int Id, string? SpecilestName);

        public Task<string> DeleteSpecailestName9(int Id, string? SpecilestName);

        public Task<string> DeleteSpecailestName10(int Id, string? SpecilestName);

        public Task<bool> CheckIfTheBookResultsAddedPIC(int BookNO);
        public Task<List<TarshehBook>> GetSpecialInfoByName(string Name);
        public Task<string> GetSpecialJobTitle(string Name);
        public int TotalUncompleteBooks(IEnumerable<TarshehBook> ListOfTarshehBooks);
    }
}
