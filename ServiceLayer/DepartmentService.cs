using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class DepartmentService : IDepartmentService
    {
        private AuthenticationContext _context;
        public DepartmentService(AuthenticationContext context)
        {
            _context = context;
        }

        public async Task<bool> Insert(MstDepartment mst)
        {
            bool ret = false;
            MstDepartment mst1 = new MstDepartment();
            try
            {
                if (mst != null)
                {
                    mst1.code = mst.code;
                    mst1.deptName = mst.deptName;
                    mst1.deptHead = mst.deptHead;
                    mst1.deptLevel = mst.deptLevel;
                    mst1.parentDept = mst.parentDept;
                    mst1.createdBy = mst.createdBy;
                    mst1.createdDate = DateTime.Now;
                    await _context.MstDepartment.AddAsync(mst1);
                    await _context.SaveChangesAsync();
                    return ret = true;
                }
            }
            catch (Exception ex)
            {
                return ret = false;
            }
            return ret;
        }

        public async Task<bool> Update(MstDepartment mst)
        {
            bool ret = false;
            MstDepartment mst1 = null;
            try
            {
                if (mst != null)
                {
                    mst1.code = mst.code;
                    mst1.deptName = mst.deptName;
                    mst1.deptHead = mst.deptHead;
                    mst1.deptLevel = mst.deptLevel;
                    mst1.parentDept = mst.parentDept;
                    mst1.createdBy = mst.createdBy;
                    mst1.createdDate = DateTime.Now;
                    mst1.id = mst.id;
                    _context.MstDepartment.Update(mst1);
                    await _context.SaveChangesAsync();
                    return ret = true;
                }
            }
            catch (Exception)
            {
                return ret = false;
            }
            return ret;
        }

        public async Task<bool> Delete(MstDepartment mst)
        {
            bool ret = false;
            MstDepartment mst1 = null;
            try
            {
                if (mst != null)
                {
                    mst1.id = mst.id;
                    _context.MstDepartment.Remove(mst1);
                    await _context.SaveChangesAsync();
                    return ret = true;
                }
            }
            catch (Exception)
            {
                return ret = false;
            }
            return ret;
        }

        public async Task<List<MstDepartment>> GetAll()
        {
            try
            {
                return await _context.MstDepartment.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

    }
}
