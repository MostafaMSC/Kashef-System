using KSHIFSYSTEM.Models;

namespace KSHIFSYSTEM.BackEnd.Interfaces
{
    public interface IKshifInfo
    {
        public Task<string> DeleteListOfDawas(List<int> ListOfDeletedDawas);

        public Task<bool> CheckIfSpecialestExistsInDB(KshfInfoModule NewSpecialest);
        public Task<string> AddNewSpecialestToTheSystem(KshfInfoModule AddNewSpecialest);
        public Task<List<KshfInfoModule>> GetAllSpecialest();
        public Task UpdateKshifNo(string SpecialName, string KshifType);
        public Task<List<string>> GetRandomSpecialest(int SpecialestCount, string _searchString);
        public Task<string> BlockSpecial(List<int> ListOfBlockedSpecialest);
        public Task<string> UnBlockSpecial(List<int> ListOfBlockedSpecialest);
        public Task<List<KshfInfoModule>> GetAllBlockedSpecialest();

    }
}
