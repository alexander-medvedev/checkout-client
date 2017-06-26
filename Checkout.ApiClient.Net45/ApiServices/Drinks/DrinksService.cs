using Checkout.ApiServices.Drinks.RequestModels;
using Checkout.ApiServices.Drinks.ResponseModels;
using Checkout.ApiServices.SharedModels;

namespace Checkout.ApiServices.Drinks
{
    public class DrinksService
    {
        public HttpResponse<CartListResponse> GetDrinks()
        {
            var uri = ApiUrls.Cart;
            return new ApiHttpClient().GetRequest<CartListResponse>(uri, AppSettings.SecretKey);
        }

        public HttpResponse<DrinkResponse> GetDrink(string name)
        {
            var uri = string.Format(ApiUrls.CartDrink, name);
            return new ApiHttpClient().GetRequest<DrinkResponse>(uri, AppSettings.SecretKey);
        }

        public HttpResponse<OkResponse> InsertDrink(CartRequest request)
        {
            var uri = ApiUrls.Cart;
            return new ApiHttpClient().PostRequest<OkResponse>(uri, AppSettings.SecretKey, request);
        }

        public HttpResponse<OkResponse> UpdateDrink(CartRequest request)
        {
            var uri = ApiUrls.Cart;
            return new ApiHttpClient().PutRequest<OkResponse>(uri, AppSettings.SecretKey, request);
        }

        public HttpResponse<OkResponse> DeleteDrink(string name)
        {
            var uri = string.Format(ApiUrls.CartDrink, name);
            return new ApiHttpClient().DeleteRequest<OkResponse>(uri, AppSettings.SecretKey);
        }
    }
}
