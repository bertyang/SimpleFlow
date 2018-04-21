using System;
using System.Collections.Generic;
using System.Text;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessRules
{
    public class User:SysUserInfo
    {
        public User(string userId)
        {
            this.UserId = userId;

            SysUserInfo user = UserDataAccess.GetUser(userId);

            if (user != null)
            {
               this.Account= user.Account;
               this.Active = user.Active;
               this.CreateTime = user.CreateTime;
               this.CreateUser =  user.CreateUser;
               this.DefaultUrl = user.DefaultUrl;
               this.DeptCode = user.DeptCode;
               this.Description = user.Description;
               this.DomainName = user.DomainName;
               this.Email = user.Email;
               this.EntryDate = user.EntryDate;
               this.ExtNo = user.ExtNo;
               this.LanguageId = user.LanguageId;
               this.LastLogonTime = user.LastLogonTime;
               this.LoginName = user.LoginName;
               this.LogonTimes = user.LogonTimes;
               this.Password = user.Password;
               this.SiteSerial = user.SiteSerial;
               this.UserName = user.UserName;
            }
        }
    }
}
