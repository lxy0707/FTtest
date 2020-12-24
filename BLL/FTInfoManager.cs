using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
namespace BLL
{
    public class FTInfoManager
    {
         //登录
            public static int Login(string name, string pwd)
            {
                return FTInfoSerivce.Login(name,pwd);
            }

            public static IQueryable LoginInfo(string name, string pwd)
            {
                return FTInfoSerivce.LoginInfo(name, pwd);
            }

        //主页显示
        public static IQueryable SelectNew()
            {
                return FTInfoSerivce.SelectNew();
            }

            //跟帖发表（新增）
            public static int AddGT(GTtable gt)
            {
                return FTInfoSerivce.AddGT(gt);
            }

            //回复发表（新增）
            public static int AddHF(HFtable hf)
            {
                return FTInfoSerivce.AddHF(hf);
            }

            //显示跟帖
            public static IQueryable SelctGT()
            {
                return FTInfoSerivce.SelctGT();
            }
        }
}
