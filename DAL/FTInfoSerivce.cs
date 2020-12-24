using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class FTInfoSerivce
    {
        //登录
        public static int Login(string name,string pwd)
        {
            WangYiEntities test = new WangYiEntities();
            var obj = (from p in test.Login
                       where p.userZH == name && p.userPwd == pwd
                       select p).Count();
            return obj;
        }

        public static IQueryable LoginInfo(string name, string pwd)
        {
            WangYiEntities test = new WangYiEntities();
            var obj = from p in test.Login
                       where p.userZH == name && p.userPwd == pwd
                       select new
                       {
                           id = p.id,
                           userZH = p.userZH,
                           userPwd = p.userPwd
                       };
            return obj;
        }
        //主页显示
        public static IQueryable SelectNew()
        {
            WangYiEntities test = new WangYiEntities();
            var obj = from p in test.newOne
                      select new
                      {
                          id = p.id,
                          newBT = p.newBT,
                          newZT = p.newZT,
                          newZZ = p.newZZ,
                          newDay = p.newDay,
                          gtCount = (from pp in p.GTtable
                                     select pp.id).Count(),
                          hfCount = (from pt in p.HFtable
                                     select pt.id).Count()
                      };
            return obj;
        }

        //跟帖发表（新增）
        public static int AddGT(GTtable gt)
        {
            WangYiEntities test = new WangYiEntities();
            test.GTtable.Add(gt);
            return test.SaveChanges();
        }

        //回复发表（新增）
        public static int AddHF(HFtable hf)
        {
            WangYiEntities test = new WangYiEntities();
            test.HFtable.Add(hf);
            return test.SaveChanges();
        }

        //显示跟帖
        public static IQueryable SelctGT()
        {
            WangYiEntities test = new WangYiEntities();
            var obj = from p in test.GTtable
                      select new
                      {
                          id = p.id,
                          gtNR = p.gtNR,
                          gtZZ = p.gtZZ,
                          gtDay = p.gtDay,
                          hf=from pp in p.HFtable where pp.gtId==p.id
                             select pp.hfNR
                      };
            return obj;
        }
    }
}
