using System;
using System.Globalization;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIPSoftSharif.Models;

namespace SIPSoftSharif.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MadadkarOnlineEntities SipDataEntity = new MadadkarOnlineEntities();
            var zz= DateTime.ParseExact("2020-06-18", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            var result = SipDataEntity.JobSchedule.Where(x => x.JobDate == zz).FirstOrDefault();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
