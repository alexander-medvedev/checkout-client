using System.Net;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.DrinksService
{
    [TestFixture(Category = "DrinksApi")]
    public class DrinksServiceTests : BaseServiceTests
    {
        [Test]
        public void InsertDrink()
        {
            var model = TestHelper.GetCartModel();
            var response = CheckoutClient.DrinksService.InsertDrink(model);

            response.Should().BeNull();
        }

        [Test]
        public void UpdateDrink()
        {
            var model = TestHelper.GetCartModel();
            var response1 = CheckoutClient.DrinksService.InsertDrink(model);
            var response2 = CheckoutClient.DrinksService.UpdateDrink(model);

            response2.Should().BeNull();
        }

        [Test]
        public void DeleteDrink()
        {
            var model = TestHelper.GetCartModel();
            var response1 = CheckoutClient.DrinksService.InsertDrink(model);
            var response2 = CheckoutClient.DrinksService.DeleteDrink(model.Drink);

            response2.Should().BeNull();
        }

        [Test]
        public void GetDrink()
        {
            var model = TestHelper.GetCartModel();
            var response1 = CheckoutClient.DrinksService.InsertDrink(model);
            var response2 = CheckoutClient.DrinksService.GetDrink(model.Drink);

            response2.Should().NotBeNull();
            response2.HttpStatusCode.Should().Be(HttpStatusCode.OK);
            response2.Model.Quantity.Should().Be(model.Quantity);
        }

        [Test]
        public void GetDrinks()
        {
            var model = TestHelper.GetCartModel();
            var response1 = CheckoutClient.DrinksService.InsertDrink(model);
            var response2 = CheckoutClient.DrinksService.GetDrinks();

            response2.Should().NotBeNull();
            response2.HttpStatusCode.Should().Be(HttpStatusCode.OK);
            response2.Model.Should().Contain(x => x.Drink == model.Drink && x.Quantity == model.Quantity);
        }
    }
}
