using System;
using EmployeeApi.BusinessServices.Implementation;
using EmployeeApi.BusinessServices.Interface;
using EmployeeApi.DataServices.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EmployeeApi.BusinessServices.Tests
{
    [TestClass]
    public class AccountBusinessServiceTests
    {
        Mock<IAccountDataService> _mockAccountDataService;
        AccountBusinessService _accountBusinessService;

        [TestInitialize]
        public void Setup()
        {
            _mockAccountDataService = new Mock<IAccountDataService>();
            _accountBusinessService = new AccountBusinessService(_mockAccountDataService.Object);
        }

        [TestMethod]
        public void GivenUsernameAndPassword_WhenCalledAuthenticateUser_ThenVerifyCheckUserCalledOnce()
        {
            string username = "rupali";
            string password = "rupali@123";

            _accountBusinessService.AuthenticateUser(username, password);

            _mockAccountDataService.Verify(x => x.CheckUser(username, password), Times.Once);
        }
    }
}
