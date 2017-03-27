﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMxAutomationFramework;
using System.Threading;

namespace RMxTests
{
    [TestClass]
    public class CreateTradeAgreementTest : RMxTestsBaseClass
    {
        [TestMethod]
        public void Can_Create_A_Simple_TA()
        {
            ListTradeAgreementPage.GoTo();
            ListTradeAgreementPage.CreateTradeAgreement("AutomatedTestName")
                .WithDescription("Automated Test creation")
                .SaveChanges();
            Driver.Wait(TimeSpan.FromSeconds(1));
           
            Assert.AreEqual(TradeAgreementPage.Name, "AutomatedTestName", "Name did not match with new agreement");
        }
    }
}
