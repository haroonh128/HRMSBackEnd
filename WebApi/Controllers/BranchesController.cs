using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Helper.ViewModels;
using InterfaceLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchesController : ControllerBase
    {
        public IBranchService _service;
        public BranchesController(IBranchService service)
        {
            _service = service;
        }

        [Route("LoadGrids")]
        [HttpGet]
        public List<Branches> LoadGrids() 
        {
            List<Branches> rspList = new List<Branches>();
            try
            {
                rspList=_service.LoadGrid();
            }
            catch (Exception e)
            {
                rspList = _service.LoadGrid();
                throw;
            }
            return rspList;
        }

        [Route("LoadCashInHand")]
        [HttpGet]
        public List<cashInhandClass> LoadCashInHand()
        {
            List<cashInhandClass> rspList = new List<cashInhandClass>();
            try
            {
                rspList = _service.CashInHand();
            }
            catch (Exception e)
            {
                rspList = _service.CashInHand();
                throw;
            }
            return rspList;
        }

        [Route("LoadPettyCash")]
        [HttpGet]
        public List<pettyCashClass> LoadPettyCash()
        {
            List<pettyCashClass> rspList = new List<pettyCashClass>();
            try
            {
                rspList = _service.PettyCash();
            }
            catch (Exception e)
            {
                rspList = _service.PettyCash();
                throw;
            }
            return rspList;
        }

        [Route("LoadSalaryCash")]
        [HttpGet]
        public List<salaryCashClass> LoadSalaryCash()
        {
            List<salaryCashClass> rspList = new List<salaryCashClass>();
            try
            {
                rspList = _service.SalaryCash();
            }
            catch (Exception e)
            {
                rspList = _service.SalaryCash();
                throw;
            }
            return rspList;
        }

        [Route("LoadAdvanceCash")]
        [HttpGet]
        public List<advanceClass> LoadAdvanceCash()
        {
            List<advanceClass> rspList = new List<advanceClass>();
            try
            {
                rspList = _service.AdvanceCash();
            }
            catch (Exception e)
            {
                rspList = _service.AdvanceCash();
                throw;
            }
            return rspList;
        }

        [Route("LoadBankAccount")]
        [HttpGet]
        public List<bankClass> LoadBankAccount()
        {
            List<bankClass> rspList = new List<bankClass>();
            try
            {
                rspList = _service.BankAccount();
            }
            catch (Exception e)
            {
                rspList = _service.BankAccount();
                throw;
            }
            return rspList;
        }

        [Route("InsertBranch")]
        [HttpPost]
        public async Task<int> InsertBranch(reqObj form)
        {
            int result = 0;
            try
            {
                result=await _service.AddRecord(form);
            }
            catch (Exception e)
            {
                //throw;
            }
            return result;
        }

        [Route("UpdateBranch")]
        [HttpPost]
        public async Task<int> UpdateBranch(reqObj form)
        {
            int result = 0;
            try
            {
                result = await _service.UpdateRecord(form);
            }
            catch (Exception e)
            {
                //throw;
            }
            return result;
        }

        [Route("GetBranchData")]
        [HttpGet]
        public async Task<List<reqObj>> GetBranchData() {
            List<reqObj> rspList = new List<reqObj>(); 
            try
            {
               rspList=await _service.GetBranchData();
            }
            catch (Exception e)
            {
                rspList = new List<reqObj>();
                //throw;
            }
            return rspList;
        }

        [Route("LoadAllDDData")]
        [HttpGet]
        public List<pettyCashClass> LoadAllDDData()
        {
            List<pettyCashClass> rspList = new List<pettyCashClass>();
            try
            {
                rspList = _service.GetAllDDData();
            }
            catch (Exception e)
            {
                rspList = new List<pettyCashClass>();
                throw;
            }
            return rspList;
        }
    }
}