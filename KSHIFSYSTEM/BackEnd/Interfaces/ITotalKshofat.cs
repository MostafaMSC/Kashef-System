using KSHIFSYSTEM.Models;

namespace KSHIFSYSTEM.BackEnd.Interfaces
{
    public interface ITotalKshofat
    {
        public Task<bool> CheckIfSpecialestExistsInDB(TotalKsofatModule NewSpecialest);
        public Task<string> AddNewSpecialestToTheSystem(TotalKsofatModule AddNewSpecialest);
        public Task<List<TotalKsofatModule>> GetAllSpecialest();
    }
}
