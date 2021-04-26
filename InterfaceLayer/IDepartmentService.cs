using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IDepartmentService
    {
        Task<bool> Delete(MstDepartment mst);
        Task<bool> Insert(MstDepartment mst);
        Task<bool> Update(MstDepartment mst);
        Task<List<MstDepartment>> GetAll();
    }
}