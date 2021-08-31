using System.Threading.Tasks;
using AddressBook.Models.TokenAuth;
using AddressBook.Web.Controllers;
using Shouldly;
using Xunit;

namespace AddressBook.Web.Tests.Controllers
{
    public class HomeController_Tests: AddressBookWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}