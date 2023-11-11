using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back.src.Tests.Unit.API
{
    [TestFixture]
    public class AccountControllerTests
    {
        private AccountController _accountController;
        private IAccountService _accountService;
        private ITokenService _tokenService;
        private IUtil _util;

        [SetUp]
        public void SetUp()
        {
            _accountService = new AccountServiceFake(); // Implemente uma classe fake para o IAccountService
            _tokenService = new TokenServiceFake(); // Implemente uma classe fake para o ITokenService
            _util = new UtilFake(); // Implemente uma classe fake para o IUtil

            _accountController = new AccountController(_accountService, _tokenService, _util);
        }

        [Test]
        public async Task GetUser_ReturnsOkResult()
        {
            // Arrange

            // Act
            var result = await _accountController.GetUser();

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result);
        }

        [Test]
        public async Task Register_ReturnsOkResult()
        {
            // Arrange
            var userDto = new UserDto { /* Preencha com os dados necessários */ };

            // Act
            var result = await _accountController.Register(userDto);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result);
        }

        [Test]
        public async Task Login_ReturnsOkResult()
        {
            // Arrange
            var userLoginDto = new UserLoginDto { /* Preencha com os dados necessários */ };

            // Act
            var result = await _accountController.Login(userLoginDto);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result);
        }

        [Test]
        public async Task UpdateUser_ReturnsOkResult()
        {
            // Arrange
            var userUpdateDto = new UserUpdateDto { /* Preencha com os dados necessários */ };

            // Act
            var result = await _accountController.UpdateUser(userUpdateDto);

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result);
        }

        [Test]
        public async Task UploadImage_ReturnsOkResult()
        {
            // Arrange

            // Act
            var result = await _accountController.UploadImage();

            // Assert
            Assert.IsInstanceOf<OkObjectResult>(result);
        }
    }
}