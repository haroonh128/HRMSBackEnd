using Models;
using Helper.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using InterfaceLayer;
using Helper;
using System.Data.Odbc;
using System.Threading.Tasks;
using System.Linq;

namespace ServiceLayer
{
    public class BranchService : IBranchService
    {
        public AuthenticationContext db;
        public BranchService(AuthenticationContext _db)
        {
            db = _db;
        }

        public List<Branches> LoadGrid()
        {
            Branches mst;
            List<Branches> mstLst = new List<Branches>();
            try
            {
                string cmd = "Select OWHS.\"WhsCode\",OWHS.\"WhsName\" from OWHS order by OWHS.\"WhsName\"";

                DataTable table = OdbHelper.GetResults(cmd);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    mst = new Branches();
                    mst.acCode = table.Rows[i]["WhsCode"].ToString();
                    mst.acName = table.Rows[i]["WhsName"].ToString();
                    mstLst.Add(mst);
                }
            }
            catch (Exception Ex)
            {
                mstLst = new List<Branches>();
            }
            return mstLst;
        }

        public List<cashInhandClass> CashInHand()
        {
            var cmd = String.Format("Select OACT.\"AcctCode\",OACT.\"AcctName\",OACT.\"ExportCode\" FROM OACT WHERE OACT.\"AccntntCod\"='{0}'", "Cash");

            DataTable table = OdbHelper.GetResults(cmd);
            List<cashInhandClass> ddList = new List<cashInhandClass>();
            cashInhandClass ddObj;
            try
            {
                if (table.Rows.Count > 0)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        ddObj = new cashInhandClass();
                        ddObj.acCode = table.Rows[i]["AcctCode"].ToString();
                        ddObj.acName = table.Rows[i]["AcctName"].ToString();
                        ddObj.ExportCode = table.Rows[i]["ExportCode"].ToString();
                        ddList.Add(ddObj);
                    }
                }
            }
            catch (Exception e)
            {
                ddList = new List<cashInhandClass>();
                //throw;
            }
            return ddList;
        }

        public List<pettyCashClass> PettyCash()
        {
            var cmd = String.Format("Select OACT.\"AcctCode\",OACT.\"AcctName\",OACT.\"ExportCode\" FROM OACT WHERE OACT.\"AccntntCod\"='{0}'", "Petty");

            DataTable table = OdbHelper.GetResults(cmd);
            List<pettyCashClass> ddList = new List<pettyCashClass>();
            pettyCashClass ddObj;
            try
            {
                if (table.Rows.Count > 0)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        ddObj = new pettyCashClass();
                        ddObj.acCode = table.Rows[i]["AcctCode"].ToString();
                        ddObj.acName = table.Rows[i]["AcctName"].ToString();
                        ddObj.ExportCode = table.Rows[i]["ExportCode"].ToString();
                        ddList.Add(ddObj);
                    }
                }
            }
            catch (Exception e)
            {
                ddList = new List<pettyCashClass>();
                //throw;
            }
            return ddList;
        }

        public List<salaryCashClass> SalaryCash()
        {
            var cmd = String.Format("Select OACT.\"AcctCode\",OACT.\"AcctName\",OACT.\"ExportCode\" FROM OACT WHERE OACT.\"AcctName\" Like 'Salaries Payable%'");

            DataTable table = OdbHelper.GetResults(cmd);
            List<salaryCashClass> ddList = new List<salaryCashClass>();
            salaryCashClass ddObj;
            try
            {
                if (table.Rows.Count > 0)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        ddObj = new salaryCashClass();
                        ddObj.acCode = table.Rows[i]["AcctCode"].ToString();
                        ddObj.acName = table.Rows[i]["AcctName"].ToString();
                        ddObj.ExportCode = table.Rows[i]["ExportCode"].ToString();
                        ddList.Add(ddObj);
                    }
                }
            }
            catch (Exception e)
            {
                ddList = new List<salaryCashClass>();
                //throw;
            }
            return ddList;
        }

        public List<advanceClass> AdvanceCash()
        {
            var cmd = String.Format("Select OACT.\"AcctCode\",OACT.\"AcctName\",OACT.\"ExportCode\" FROM OACT WHERE OACT.\"AcctName\" Like 'Advances to Employees%'");

            DataTable table = OdbHelper.GetResults(cmd);
            List<advanceClass> ddList = new List<advanceClass>();
            advanceClass ddObj;
            try
            {
                if (table.Rows.Count > 0)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        ddObj = new advanceClass();
                        ddObj.acCode = table.Rows[i]["AcctCode"].ToString();
                        ddObj.acName = table.Rows[i]["AcctName"].ToString();
                        ddObj.ExportCode = table.Rows[i]["ExportCode"].ToString();
                        ddList.Add(ddObj);
                    }
                }
            }
            catch (Exception e)
            {
                ddList = new List<advanceClass>();
                //throw;
            }
            return ddList;
        }

        public List<bankClass> BankAccount()
        {
            var cmd = String.Format("Select OACT.\"AcctCode\",OACT.\"AcctName\",OACT.\"ExportCode\" FROM OACT WHERE OACT.\"AccntntCod\"='{0}'", "Bank");

            DataTable table = OdbHelper.GetResults(cmd);
            List<bankClass> ddList = new List<bankClass>();
            bankClass ddObj;
            try
            {
                if (table.Rows.Count > 0)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        ddObj = new bankClass();
                        ddObj.acCode = table.Rows[i]["AcctCode"].ToString();
                        ddObj.acName = table.Rows[i]["AcctName"].ToString();
                        ddObj.ExportCode = table.Rows[i]["ExportCode"].ToString();
                        ddList.Add(ddObj);
                    }
                }
            }
            catch (Exception e)
            {
                ddList = new List<bankClass>();
                //throw;
            }
            return ddList;
        }

        public async Task<int> AddRecord(reqObj obj)
        {
            string DetailKey = "";
            int result = 0;
            try
            {
                MstBranches oNew = new MstBranches();
                oNew.Code = obj.brnchId.ToString();
                oNew.Name = obj.name;
                oNew.BankAccout = obj.baDD.ToString();
                oNew.CashInHandAccount = obj.cshInhndDD.ToString();
                oNew.PettyCash = obj.pettyDD.ToString();
                oNew.SalaryAccount = obj.salDD.ToString();
                oNew.AdvToEmpAcc = obj.advDD.ToString();
                //oNew.CreatedBy = Program.oCurrentUser.UserCode;
                //oNew.UpdatedBy = Program.oCurrentUser.UserCode;
                oNew.CreateDt = DateTime.Now;
                oNew.UpdateDt = DateTime.Now;

                #region Payment
                MstBranchesDetail bDetail = new MstBranchesDetail();
                bDetail.BranchID = oNew.Code;
                //bDetail.CreatedBy = Program.oCurrentUser.UserCode;
                bDetail.CreateDt = DateTime.Now;
                //bDetail.UpdatedBy = Program.oCurrentUser.UserCode;
                bDetail.UpdateDt = DateTime.Now;
                bDetail.DetailKey = bDetail.BranchID + "-" + 1;
                bDetail.DocName = "Incoming Payment";
                bDetail.LineID = 1;
                string seriesInit = "";
                int initialNum = 1;
                int lastNum = 1;
                int seriesID = 1;
                GetSeriesInfo(oNew.Code, 24, out seriesInit, out initialNum, out lastNum, out seriesID);
                bDetail.DocSeries = seriesInit;
                bDetail.StartingNumber = initialNum;
                bDetail.LastNumber = lastNum;
                bDetail.SeriesId = seriesID;
                await db.MstBranchesDetail.AddAsync(bDetail);
                #endregion

                #region ARInvoice
                MstBranchesDetail bDetailx = new MstBranchesDetail();
                bDetailx.BranchID = oNew.Code;
                //bDetailx.CreatedBy = Program.oCurrentUser.UserCode;
                bDetailx.CreateDt = DateTime.Now;
                //bDetailx.UpdatedBy = Program.oCurrentUser.UserCode;
                bDetailx.UpdateDt = DateTime.Now;
                bDetailx.DetailKey = bDetail.BranchID + "-" + 2;
                bDetailx.DocName = "ARInvoice";
                bDetailx.LineID = 2;
                seriesInit = "";
                initialNum = 1;
                GetSeriesInfo(oNew.Code, 13, out seriesInit, out initialNum, out lastNum, out seriesID);
                bDetailx.DocSeries = seriesInit;
                bDetailx.StartingNumber = initialNum;
                bDetailx.LastNumber = lastNum;
                bDetailx.SeriesId = seriesID;
                await db.MstBranchesDetail.AddAsync(bDetailx);
                #endregion

                #region Journal Voucher
                MstBranchesDetail bDetail2 = new MstBranchesDetail();
                bDetail2.BranchID = oNew.Code;
                //bDetail2.CreatedBy = Program.oCurrentUser.UserCode;
                bDetail2.CreateDt = DateTime.Now;
                //bDetail2.UpdatedBy = Program.oCurrentUser.UserCode;
                bDetail2.UpdateDt = DateTime.Now;
                bDetail2.DetailKey = bDetail.BranchID + "-" + 3;
                bDetail2.DocName = "Journal Voucher";
                bDetail2.LineID = 3;
                seriesInit = "";
                initialNum = 1;
                GetSeriesInfo(oNew.Code, 30, out seriesInit, out initialNum, out lastNum, out seriesID);
                bDetail2.DocSeries = seriesInit;
                bDetail2.StartingNumber = initialNum;
                bDetail2.LastNumber = lastNum;
                bDetail2.SeriesId = seriesID;
                await db.MstBranchesDetail.AddAsync(bDetail2);
                #endregion

                #region Bank Deposit
                var bDetail3 = new MstBranchesDetail();
                bDetail3.BranchID = oNew.Code;
                //bDetail3.CreatedBy = Program.oCurrentUser.UserCode;
                bDetail3.CreateDt = DateTime.Now;
                //bDetail3.UpdatedBy = Program.oCurrentUser.UserCode;
                bDetail3.UpdateDt = DateTime.Now;
                bDetail3.DetailKey = bDetail.BranchID + "-" + 4;
                bDetail3.DocName = "Bank Deposit";
                bDetail3.LineID = 4;
                seriesInit = "";
                initialNum = 1;
                GetSeriesInfo(oNew.Code, 25, out seriesInit, out initialNum, out lastNum, out seriesID);
                bDetail3.DocSeries = seriesInit;
                bDetail3.StartingNumber = initialNum;
                bDetail3.LastNumber = lastNum;
                bDetail3.SeriesId = seriesID;

                await db.MstBranchesDetail.AddAsync(bDetail3);
                #endregion
                await db.MstBranches.AddAsync(oNew);
                result = await db.SaveChangesAsync();
                //Program.SuccesesMsg("Record Successfully Added.");
                //GetAllObjects();
            }
            catch (Exception Ex)
            {
            }
            return result;
        }

        public async Task<int> UpdateRecord(reqObj obj)
        {
            //MstBranches oNew = new MstBranches();
            //MstBranchesDetail bDetail = new MstBranchesDetail();
            string OpenObjectID = string.Empty;
            OpenObjectID = obj.brnchId.ToString();
            int result = 0;
            try
            {
                MstBranches oNew = (from a in db.MstBranches where a.Code == OpenObjectID select a).FirstOrDefault();
                if (oNew == null)
                {
                    return 0;
                }
                oNew.Name = obj.name;
                oNew.BankAccout = obj.baDD.ToString();
                oNew.CashInHandAccount = obj.cshInhndDD.ToString();
                oNew.PettyCash = obj.pettyDD.ToString();
                oNew.SalaryAccount = obj.salDD.ToString();
                oNew.AdvToEmpAcc = obj.advDD.ToString();
                //oNew.UpdatedBy = Program.oCurrentUser.UserCode;
                oNew.UpdateDt = DateTime.Now;

                #region Payment
                MstBranchesDetail bDetail = db.MstBranchesDetail.Where(x => x.DocName == "Incoming Payment").FirstOrDefault();
                bDetail.BranchID = oNew.Code;
                //bDetail.CreatedBy = Program.oCurrentUser.UserCode;
                bDetail.CreateDt = DateTime.Now;
                //bDetail.UpdatedBy = Program.oCurrentUser.UserCode;
                bDetail.UpdateDt = DateTime.Now;
                //  bDetail.DetailKey = bDetail.BranchID + "-" + 1;
                bDetail.DocName = "Incoming Payment";
                bDetail.LineID = 1;
                string seriesInit = "";
                int initialNum = 1;
                int lastNum = 1;
                int seriesID = 0;
                GetSeriesInfo(oNew.Code, 24, out seriesInit, out initialNum, out lastNum, out seriesID);
                bDetail.DocSeries = seriesInit;
                bDetail.StartingNumber = initialNum;
                bDetail.LastNumber = lastNum;
                bDetail.SeriesId = seriesID;
                //db.MstBranchesDetail.Update(bDetail);
                //result = await db.SaveChangesAsync();
                #endregion

                #region Outgoing
                MstBranchesDetail bDetail_OP = db.MstBranchesDetail.Where(x => x.DocName == "Outgoing Payment").FirstOrDefault();
                if (bDetail_OP == null)
                {
                    bDetail_OP = new MstBranchesDetail();
                    bDetail_OP.DetailKey = bDetail.BranchID + "-" + 5;
                    await db.MstBranchesDetail.AddAsync(bDetail_OP);
                }
                bDetail_OP.BranchID = oNew.Code;
                //bDetail_OP.CreatedBy = Program.oCurrentUser.UserCode;
                bDetail_OP.CreateDt = DateTime.Now;
                //bDetail_OP.UpdatedBy = Program.oCurrentUser.UserCode;
                bDetail_OP.UpdateDt = DateTime.Now;
                //  bDetail.DetailKey = bDetail.BranchID + "-" + 1;
                bDetail_OP.DocName = "Outgoing Payment";
                bDetail_OP.LineID = 5;
                string seriesInit2 = "";
                int initialNum2 = 1;
                int lastNum2 = 1;
                int seriesID2 = 0;
                GetSeriesInfo(oNew.Code, 46, out seriesInit2, out initialNum2, out lastNum2, out seriesID2);
                bDetail_OP.DocSeries = seriesInit;
                bDetail_OP.StartingNumber = initialNum;
                bDetail_OP.LastNumber = lastNum;
                bDetail_OP.SeriesId = seriesID2;
                //db.MstBranchesDetail.Update(bDetail);
                //result = await db.SaveChangesAsync();

                #endregion

                #region Journal Voucher
                var bDetail2 = db.MstBranchesDetail.Where(x => x.DocName == "Journal Voucher").FirstOrDefault();
                bDetail2.BranchID = oNew.Code;
                //bDetail2.CreatedBy = Program.oCurrentUser.UserCode;
                bDetail2.CreateDt = DateTime.Now;
                //bDetail2.UpdatedBy = Program.oCurrentUser.UserCode;
                bDetail2.UpdateDt = DateTime.Now;
                //  bDetail2.DetailKey = bDetail.BranchID + "-" + 3;
                bDetail2.DocName = "Journal Voucher";
                bDetail2.LineID = 3;
                seriesInit = "";
                initialNum = 1;
                GetSeriesInfo(oNew.Code, 30, out seriesInit, out initialNum, out lastNum, out seriesID);
                bDetail2.DocSeries = seriesInit;
                bDetail2.StartingNumber = initialNum;
                bDetail2.LastNumber = lastNum;
                bDetail2.SeriesId = seriesID;
               // db.MstBranchesDetail.Update(bDetail2);
                //result = await db.SaveChangesAsync();

                #endregion

                #region Bank Deposit
                MstBranchesDetail bDetail3 = db.MstBranchesDetail.Where(x => x.DocName == "Bank Deposit").FirstOrDefault();
                bDetail3.BranchID = oNew.Code;
                //bDetail3.CreatedBy = Program.oCurrentUser.UserCode;
                bDetail3.CreateDt = DateTime.Now;
                //bDetail3.UpdatedBy = Program.oCurrentUser.UserCode;
                bDetail3.UpdateDt = DateTime.Now;
                //   bDetail3.DetailKey = bDetail.BranchID + "-" + 4;
                bDetail3.DocName = "Bank Deposit";
                bDetail3.LineID = 4;
                seriesInit = "";
                initialNum = 1;
                GetSeriesInfo(oNew.Code, 25, out seriesInit, out initialNum, out lastNum, out seriesID);
                bDetail3.DocSeries = seriesInit;
                bDetail3.StartingNumber = initialNum;
                bDetail3.LastNumber = lastNum;
                bDetail3.SeriesId = seriesID;
                //db.MstBranchesDetail.Update(bDetail3);
                #endregion

                result = await db.SaveChangesAsync();
                //Program.SuccesesMsg("Record Successfully Added.");
            }
            catch (Exception Ex)
            {
            }
            return result;
        }

        //private Boolean ValidateRecord()
        //{
        //    try
        //    {
        //        int invDays = 0;

        //        if (string.IsNullOrEmpty(txtCode.Text))
        //        {
        //            erp.SetError(txtCode, "Field is Empty");
        //            return false;
        //        }
        //        else
        //        {
        //            erp.Clear();
        //        }

        //        if (string.IsNullOrEmpty(txtBankAccount.Text))
        //        {
        //            erp.SetError(txtBankAccount, "Field is Empty");
        //            return false;
        //        }
        //        else
        //        {
        //            erp.Clear();
        //        }

        //        if (string.IsNullOrEmpty(txtPettyCash.Text))
        //        {
        //            erp.SetError(txtPettyCash, "Field is Empty");
        //            return false;
        //        }
        //        else
        //        {
        //            erp.Clear();
        //        }
        //        if (string.IsNullOrEmpty(txtCashInHand.Text))
        //        {
        //            erp.SetError(txtCashInHand, "Field is Empty");
        //            return false;
        //        }
        //        else
        //        {
        //            erp.Clear();
        //        }



        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        public void GetSeriesInfo(string branchCode, int objectNo, out string seriesBeginString, out int startNum, out int lastNum, out int seriesID)
        {
            try
            {
                string cmd = "";
                branchCode = branchCode.Substring(2, branchCode.Length - 2);

                cmd = String.Format("Select nnm1.\"InitialNum\",nnm1.\"BeginStr\",nnm1.\"LastNum\",nnm1.\"Series\" from nnm1 where nnm1.\"ObjectCode\"='{0}' and nnm1.\"SeriesName\" = '{1}'", objectNo, branchCode);
                DataTable table = OdbHelper.GetResults(cmd);

                if (table.Rows.Count > 0)
                {
                    seriesBeginString = table.Rows[0]["BeginStr"].ToString();
                    startNum = Convert.ToInt32(table.Rows[0]["InitialNum"]);
                    lastNum = Convert.ToInt32(table.Rows[0]["LastNum"]);
                    seriesID = Convert.ToInt32(table.Rows[0]["Series"]);


                }
                else
                {
                    //MessageBox.Show("Series not found for Object " + objectNo);
                    seriesBeginString = "";
                    startNum = 1;
                    lastNum = 1;
                    seriesID = 0;
                }


            }
            catch (Exception ex)
            {
                //Program.ExceptionMsg("Error GETSERIESINFO.Reason:" + ex.Message);
                seriesBeginString = "";
                startNum = 1;
                seriesID = 1;
                lastNum = 0;
            }
        }


        public async Task<List<reqObj>> GetBranchData() {
            List<reqObj> rspLst = new List<reqObj>();
            reqObj rsp;
            try
            {
                var result = (from x in db.MstBranches select new { x.AdvToEmpAcc,x.BankAccout,x.Code,x.PettyCash,x.SalaryAccount,x.CashInHandAccount});

                foreach (var i in result)
                {
                    rsp = new reqObj();
                    rsp.advDD = i.AdvToEmpAcc;
                    rsp.baDD = i.BankAccout;
                    rsp.brnchId = i.Code;
                    rsp.cshInhndDD = i.CashInHandAccount;
                    rsp.pettyDD = i.PettyCash;
                    rsp.salDD = i.SalaryAccount;
                    rspLst.Add(rsp);
                }
            }
            catch (Exception e)
            {
                rspLst = new List<reqObj>();
                throw;
            }
            return rspLst;
        }

        public List<pettyCashClass> GetAllDDData() 
        {
            var cmd = String.Format("Select OACT.\"AcctCode\",OACT.\"AcctName\",OACT.\"ExportCode\",OACT.\"AccntntCod\" FROM OACT ");

            DataTable table = OdbHelper.GetResults(cmd);
            List<pettyCashClass> ddList = new List<pettyCashClass>();
            pettyCashClass ddObj;
            try
            {
                if (table.Rows.Count > 0)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        ddObj = new pettyCashClass();
                        ddObj.acCode = table.Rows[i]["AcctCode"].ToString();
                        ddObj.acName = table.Rows[i]["AcctName"].ToString();
                        ddObj.ExportCode = table.Rows[i]["ExportCode"].ToString();
                        ddObj.AccntntCod = table.Rows[i]["AccntntCod"].ToString();
                        ddList.Add(ddObj);
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
            return ddList;
        }

    }
}