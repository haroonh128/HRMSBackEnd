using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using ServiceLayer;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _deptService;
        public DepartmentController(IDepartmentService deptService)
        
        {
            this._deptService = deptService;

        }

        public async Task<ActionResult<List<MstDepartment>>> GetDepartmentList()
        {
            return await _deptService.GetAll();
        }

        
        [Route("InsertDepartment")]
        [HttpPost]
        public async Task<Object> InsertDepartment(MstDepartment formData)
        {
            try
            {
                var department = new MstDepartment()
                {
                    deptHead = formData.deptHead,
                    deptName = formData.deptName,
                    deptLevel = formData.deptLevel,
                    parentDept = formData.parentDept,
                    flgActive = formData.flgActive,
                    code = formData.code,
                    deptPrefix = formData.deptPrefix
                };
                var result = await _deptService.Insert(department);
                return Ok(result);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public async Task<Object> Update(MstDepartment model)
        {
            try
            {
                var department = new MstDepartment()
                {
                    deptHead = model.deptHead,
                    deptName = model.deptName,
                    deptLevel = model.deptLevel,
                    parentDept = model.parentDept,
                    flgActive = model.flgActive,
                    code = model.code,
                    deptPrefix = model.deptPrefix
                };
                var result = await _deptService.Update(department);
                return Ok(result);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}