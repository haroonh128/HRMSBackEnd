using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceLayer;

namespace ServiceLayer
{
    public class DeductionTypesService : IDeductionTypesService
    {
        private AuthenticationContext context;
        public DeductionTypesService(AuthenticationContext _context)
        {
            context = _context;
        }

        public async Task<string> CreateDeductionType(DeductionTypes model)
        {
            var result = 0;
            try
            {
                if (model != null)
                {
                    await context.DeductionTypes.AddAsync(model);
                    result = await context.SaveChangesAsync();
                }
                return result.ToString();
            }
            catch (Exception e)
            {
                return result.ToString();
            }
        }

        public async Task<string> UpdateDeductionType(DeductionTypes model)
        {
            var result = 0;
            try
            {
                if (model != null)
                {
                    context.DeductionTypes.Update(model);
                    result = await context.SaveChangesAsync();
                }
                result.ToString();
            }
            catch (Exception e)
            {
                result.ToString();
            }
            return result.ToString();
        }

        public async Task<string> DeleteDeductionType(DeductionTypes model)
        {
            var result = 0;
            try
            {
                if (model != null)
                {
                    context.DeductionTypes.Remove(model);
                    result = await context.SaveChangesAsync();
                }
                return result.ToString();
            }
            catch (Exception e)
            {
                return result.ToString();
            }
        }

        public List<DeductionTypes> GetAllDeductionType()
        {
            List<DeductionTypes> dedctLst = new List<DeductionTypes>();
            try
            {
                dedctLst = context.DeductionTypes.ToList();//OrderBy(x=>x.parentId)
            }
            catch (Exception e)
            {
                dedctLst = new List<DeductionTypes>();
            }
            return dedctLst;
        }
    }
}


