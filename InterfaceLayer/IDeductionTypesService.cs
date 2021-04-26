using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface IDeductionTypesService
    {
        Task<string> CreateDeductionType(DeductionTypes model);
        Task<string> DeleteDeductionType(DeductionTypes model);
        List<DeductionTypes> GetAllDeductionType();
        Task<string> UpdateDeductionType(DeductionTypes model);
    }
}