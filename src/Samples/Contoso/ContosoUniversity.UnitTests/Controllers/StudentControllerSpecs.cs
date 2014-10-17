﻿using System.Net;
using System.Web.Mvc;
using ContosoUniversity.Controllers;
using FluentAssertions;
using Specify.NUnit;

namespace ContosoUniversity.UnitTests.Controllers
{
    public class WhenGettingDetailsForNullId : SpecificationFor<StudentController>
    {
        ActionResult _result;

        public void When_a_null_Id_is_requested()
        {
            _result = SUT.Details(null);
        }

        public void Then_a_bad_request_is_returned()
        {
            _result.Should().BeOfType<HttpStatusCodeResult>();
        }
    }
}
