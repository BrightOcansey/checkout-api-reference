// For more information please refer to https://github.com/checkout/checkout-sdk-net
using Checkout.Payments.Previous.Response;

Previous.ICheckoutApi api = CheckoutSdk.Builder()
    .Previous()
    .StaticKeys()
    .SecretKey("secret_key")
    .Environment(Environment.Sandbox)
    .HttpClientFactory(new DefaultHttpClientFactory())
    .Build();

try
{
    GetPaymentResponse response = await api.PaymentsClient().GetPaymentDetails("payment_id");
}
catch (CheckoutApiException e)
{
    // API error
    string requestId = e.RequestId;
    var statusCode = e.HttpStatusCode;
    IDictionary<string, object> errorDetails = e.ErrorDetails;
}
catch (CheckoutArgumentException e)
{
    // Bad arguments
}
catch (CheckoutAuthorizationException e)
{
    // Invalid authorization
}