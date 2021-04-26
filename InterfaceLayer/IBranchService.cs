using System.Collections.Generic;
using System.Threading.Tasks;
using Helper.ViewModels;

namespace InterfaceLayer
{
    public interface IBranchService
    {
        List<Branches> LoadGrid();
        List<cashInhandClass> CashInHand();
        List<pettyCashClass> PettyCash();
        List<salaryCashClass> SalaryCash();
        List<advanceClass> AdvanceCash();
        List<bankClass> BankAccount();
        Task<int> AddRecord(reqObj obj);
        void GetSeriesInfo(string branchCode, int objectNo, out string seriesBeginString, out int startNum, out int lastNum, out int seriesID);
        Task<int> UpdateRecord(reqObj obj);
        Task<List<reqObj>> GetBranchData();
        List<pettyCashClass> GetAllDDData();
    }
}