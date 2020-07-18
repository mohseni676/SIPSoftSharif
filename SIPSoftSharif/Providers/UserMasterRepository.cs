using System;
using System.Linq;
using SIPSoftSharif.Models;

namespace SIPSoftSharif.Providers
{
    internal class UserMasterRepository : IDisposable
    {
        SharifEntities context = new SharifEntities();
        BpmsSharifDataEntities context_db = new BpmsSharifDataEntities();
        userModel user = new userModel();
        internal userModel ValidateUser(string userName, string password)
        {
            var hashedpass = HashMD5(password);
            var x = context.Users.Where(s => s.UserName == userName && s.UserPass == hashedpass).FirstOrDefault();
            if (x != null)
            {
                user.UserId = x.UserId;
                user.Firstname = x.FirstName;
                user.Lastname = x.LastName;
                var y = (from r in context_db.FG_Madadkars where r.UserId == x.UserId select new { r.MadadkarId, r.MadadkarBirhtdate }).FirstOrDefault();
                if (y != null)
                {
                    user.UserId = x.UserId;
                    user.Firstname = x.FirstName;
                    user.Lastname = x.LastName;
                    user.Username = userName;
                    var z = (from r in context_db.FG_madadkarsInfo where r.UserId == x.UserId select new { r.MadadkarId, r.MadadkarBirhtdate }).FirstOrDefault();
                    if (z != null)
                    {
                        user.MadadkarId = y.MadadkarId;
                        user.Birthdate = y.MadadkarBirhtdate;

                    }
                    else
                    {
                        user.MadadkarId = 0;

                    }


                    
                }
                return user;


            }
            return null;
        }

            public void Dispose()
        {
            context.Dispose();
        }

        private static byte[] HashMD5(string password)
        {
            byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(password);
            try
            {
                System.Security.Cryptography.MD5CryptoServiceProvider cryptHandler;
                cryptHandler = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] hash = cryptHandler.ComputeHash(textBytes);
                return hash;
                /*  string ret = "";
                  foreach (byte a in hash)
                  {
                      if (a < 16)
                          ret += "0" + a.ToString("x");
                      else
                          ret += a.ToString("x");
                  }
                  return("0x" + ret);*/
            }
            catch
            {
                throw;
            }
        }

    }
}