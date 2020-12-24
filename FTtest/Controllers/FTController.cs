using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;
namespace FTtest.Controllers
{
    public class FTController : Controller
    {
        // GET: FT
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Show()
        {
            return View();
        }

        //登录
        public ActionResult Login(string name, string pwd)
        {
            return Json(FTInfoManager.Login(name, pwd),JsonRequestBehavior.AllowGet);
        }
        public ActionResult LoginInfo(string name, string pwd)
        {
            return Json(FTInfoManager.LoginInfo(name, pwd), JsonRequestBehavior.AllowGet);
        }

        //主页显示
        public ActionResult SelectNew()
        {
            return Json(FTInfoManager.SelectNew(), JsonRequestBehavior.AllowGet);
        }

        //跟帖发表（新增）
        public ActionResult AddGT(GTtable gt)
        {
            return Json(FTInfoManager.AddGT(gt), JsonRequestBehavior.AllowGet);
        }

        //回复发表（新增）
        public ActionResult AddHF(HFtable hf)
        {
            return Json(FTInfoManager.AddHF(hf), JsonRequestBehavior.AllowGet);
        }

        //显示跟帖
        public ActionResult SelctGT()
        {
            return Json(FTInfoManager.SelctGT(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult SelctGTT()
        {
            return Json(FTInfoManager.SelctGT(), JsonRequestBehavior.AllowGet);
        }
    }
}