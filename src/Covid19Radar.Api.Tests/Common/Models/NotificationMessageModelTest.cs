﻿using System;
using Covid19Radar.Api.Common;
using Covid19Radar.Api.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Covid19Radar.Api.Tests.Common.Models
{
    [TestClass]
    [TestCategory("Models")]
    public class NotificationMessageModelTest
    {
        [TestMethod]
        public void CreateMethod()
        {
            // action
            var model = new NotificationMessageModel();
        }

        [TestMethod]
        public void PropertiesTest()
        {
            // preparation
            var model = new NotificationMessageModel();
            // model property access
            Helper.ModelTestHelper.PropetiesTest(model);
        }


    }
}
