using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeductionTypesController : ControllerBase
    {
        private IDeductionTypesService service;
        public DeductionTypesController(IDeductionTypesService _service)
        {
            service = _service;
        }

        [HttpPost]
        [Route("CreateDeductionTypes")]
        public async Task<string> CreateDeductionTypes(DeductionTypes model)
        {
            var result = "";
            try
            {
                if (model != null)
                {
                    result = await service.CreateDeductionType(model);
                }
                return result;
            }
            catch (Exception)
            {

                return result;
            }
        }

        [HttpPost]
        [Route("UpdateDeductionTypes")]
        public async Task<string> UpdateDeductionTypes(DeductionTypes model)
        {
            var result = "";
            try
            {
                if (model != null)
                {
                    result = await service.UpdateDeductionType(model);
                }
                return result;
            }
            catch (Exception)
            {

                return result;
            }
        }

        [HttpPost]
        [Route("DeleteDeductionTypes")]
        public async Task<string> DeleteDeductionTypes(DeductionTypes model)
        {
            var result = "";
            try
            {
                if (model != null)
                {
                    result = await service.DeleteDeductionType(model);
                }
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }

        [HttpGet]
        [Route("GetDeductionTypes")]
        public List<DeductionTypes> GetDeductionTypes()
        {
            try
            {
                return service.GetAllDeductionType().ToList();
            }
            catch (Exception)
            {
                return new List<DeductionTypes>();
            }
        }
    }
}