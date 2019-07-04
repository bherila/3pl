# Getting started

RESTful web services to communicate with the ProNimbus application. [Download this specification](ProNimbus_API_Swagger.yaml)

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (ProNimbusAPI.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=ProNimbus%20API-CSharp&workspaceName=ProNimbusAPI&projectName=ProNimbusAPI.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the ProNimbusAPI library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=ProNimbus%20API-CSharp&workspaceName=ProNimbusAPI&projectName=ProNimbusAPI.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=ProNimbus%20API-CSharp&workspaceName=ProNimbusAPI&projectName=ProNimbusAPI.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=ProNimbus%20API-CSharp&workspaceName=ProNimbusAPI&projectName=ProNimbusAPI.Standard)

### 3. Add reference of the library project

In order to use the ProNimbusAPI library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=ProNimbus%20API-CSharp&workspaceName=ProNimbusAPI&projectName=ProNimbusAPI.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` ProNimbusAPI.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```ProNimbusAPI.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=ProNimbus%20API-CSharp&workspaceName=ProNimbusAPI&projectName=ProNimbusAPI.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=ProNimbus%20API-CSharp&workspaceName=ProNimbusAPI&projectName=ProNimbusAPI.Standard)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### 

API client can be initialized as following.

```csharp

ProNimbusAPIClient client = new ProNimbusAPIClient();
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [SKUController](#sku_controller)
* [NotificationsController](#notifications_controller)
* [InventoryController](#inventory_controller)
* [SalesOrderController](#sales_order_controller)

## <a name="sku_controller"></a>![Class: ](https://apidocs.io/img/class.png "ProNimbusAPI.Standard.Controllers.SKUController") SKUController

### Get singleton instance

The singleton instance of the ``` SKUController ``` class can be accessed from the API Client.

```csharp
SKUController sKU = client.SKU;
```

### <a name="create_product_details_web_service"></a>![Method: ](https://apidocs.io/img/method.png "ProNimbusAPI.Standard.Controllers.SKUController.CreateProductDetailsWebService") CreateProductDetailsWebService

> RESTful web service to fetch information about SKUs.
> [Download the YAML for this call](API_productDetails.yaml)
> 


```csharp
Task<Models.ProductDetailsResponse> CreateProductDetailsWebService(Models.ProductDetailsRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var request = new Models.ProductDetailsRequest();

Models.ProductDetailsResponse result = await sKU.CreateProductDetailsWebService(request);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Response on Failure |
| 0 | Unexpected error |


### <a name="create_product_create_web_service"></a>![Method: ](https://apidocs.io/img/method.png "ProNimbusAPI.Standard.Controllers.SKUController.CreateProductCreateWebService") CreateProductCreateWebService

> RESTful web service to create new SKUs.
> 


```csharp
Task<Models.ProductCreateResponse> CreateProductCreateWebService(Models.ProductCreateRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | The product you want to add |


#### Example Usage

```csharp
var request = new Models.ProductCreateRequest();

Models.ProductCreateResponse result = await sKU.CreateProductCreateWebService(request);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Response on Failure |
| 0 | Unexpected error |


### <a name="update_product_update"></a>![Method: ](https://apidocs.io/img/method.png "ProNimbusAPI.Standard.Controllers.SKUController.UpdateProductUpdate") UpdateProductUpdate

> RESTful web service to update product information.
> [Download the YAML for this call](API_product.yaml)
> 


```csharp
Task<Models.ProductUpdateResponseSuccess> UpdateProductUpdate(Models.ProductUpdateRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | The product you want to update |


#### Example Usage

```csharp
var request = new Models.ProductUpdateRequest();

Models.ProductUpdateResponseSuccess result = await sKU.UpdateProductUpdate(request);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Response on Failure |
| 0 | Unexpected error |


[Back to List of Controllers](#list_of_controllers)

## <a name="notifications_controller"></a>![Class: ](https://apidocs.io/img/class.png "ProNimbusAPI.Standard.Controllers.NotificationsController") NotificationsController

### Get singleton instance

The singleton instance of the ``` NotificationsController ``` class can be accessed from the API Client.

```csharp
NotificationsController notifications = client.Notifications;
```

### <a name="create_fetch_info_about_email_notifications_sent_on_behalf_of_a_client"></a>![Method: ](https://apidocs.io/img/method.png "ProNimbusAPI.Standard.Controllers.NotificationsController.CreateFetchInfoAboutEmailNotificationsSentOnBehalfOfAClient") CreateFetchInfoAboutEmailNotificationsSentOnBehalfOfAClient

> RESTful web service to fetch info about email notificatios sent on behalf of a client. [Download the YAML for this call](API_getNotifications.yaml)


```csharp
Task<Models.GetNotificationsResponse> CreateFetchInfoAboutEmailNotificationsSentOnBehalfOfAClient(Models.GetNotificationsRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var request = new Models.GetNotificationsRequest();

Models.GetNotificationsResponse result = await notifications.CreateFetchInfoAboutEmailNotificationsSentOnBehalfOfAClient(request);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |


[Back to List of Controllers](#list_of_controllers)

## <a name="inventory_controller"></a>![Class: ](https://apidocs.io/img/class.png "ProNimbusAPI.Standard.Controllers.InventoryController") InventoryController

### Get singleton instance

The singleton instance of the ``` InventoryController ``` class can be accessed from the API Client.

```csharp
InventoryController inventory = client.Inventory;
```

### <a name="create_inbound_bill_of_lading_web_service"></a>![Method: ](https://apidocs.io/img/method.png "ProNimbusAPI.Standard.Controllers.InventoryController.CreateInboundBillOfLadingWebService") CreateInboundBillOfLadingWebService

> RESTful web service to create inbound BOLs.
> [Download the YAML for this call](API_bolInboundCreate.yaml)
> 


```csharp
Task<Models.BolInboundCreateSuccessResponse> CreateInboundBillOfLadingWebService(Models.BolInboundCreateRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var request = new Models.BolInboundCreateRequest();

Models.BolInboundCreateSuccessResponse result = await inventory.CreateInboundBillOfLadingWebService(request);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |


### <a name="create_inventory_web_service"></a>![Method: ](https://apidocs.io/img/method.png "ProNimbusAPI.Standard.Controllers.InventoryController.CreateInventoryWebService") CreateInventoryWebService

> RESTful web service to GET inventory information.
> [Download the YAML for this call](API_getInventoryStatus.yaml)
> 


```csharp
Task<Models.InventoryResponse> CreateInventoryWebService(Models.InventoryRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var request = new Models.InventoryRequest();

Models.InventoryResponse result = await inventory.CreateInventoryWebService(request);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |


[Back to List of Controllers](#list_of_controllers)

## <a name="sales_order_controller"></a>![Class: ](https://apidocs.io/img/class.png "ProNimbusAPI.Standard.Controllers.SalesOrderController") SalesOrderController

### Get singleton instance

The singleton instance of the ``` SalesOrderController ``` class can be accessed from the API Client.

```csharp
SalesOrderController salesOrder = client.SalesOrder;
```

### <a name="alternate_pickup_location_web_service"></a>![Method: ](https://apidocs.io/img/method.png "ProNimbusAPI.Standard.Controllers.SalesOrderController.AlternatePickupLocationWebService") AlternatePickupLocationWebService

> RESTful web service to get alternate pickup locations.
> [Download the YAML for this call](API_getAlternatePickupLocations.yaml)
> 


```csharp
Task<Models.AlternatePickupLocationsResponse> AlternatePickupLocationWebService(Models.AlternatePickupLocationsRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var request = new Models.AlternatePickupLocationsRequest();

Models.AlternatePickupLocationsResponse result = await salesOrder.AlternatePickupLocationWebService(request);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Response on Error |
| 0 | Unexpected error |


### <a name="create_order_status_web_service"></a>![Method: ](https://apidocs.io/img/method.png "ProNimbusAPI.Standard.Controllers.SalesOrderController.CreateOrderStatusWebService") CreateOrderStatusWebService

> RESTful web service to GET order status information.
> [Download the YAML for this call](API_getOrderStatus.yaml)
> 


```csharp
Task<Models.OrderStatusResponse> CreateOrderStatusWebService(Models.OrderStatusRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var request = new Models.OrderStatusRequest();

Models.OrderStatusResponse result = await salesOrder.CreateOrderStatusWebService(request);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |


### <a name="create_cancel_order_web_service"></a>![Method: ](https://apidocs.io/img/method.png "ProNimbusAPI.Standard.Controllers.SalesOrderController.CreateCancelOrderWebService") CreateCancelOrderWebService

> RESTful web service to cancel a specific order or multiple orders.
> [Download the YAML for this call](API_cancelOrder.yaml)
> 


```csharp
Task<Models.CancelResponse> CreateCancelOrderWebService(Models.CancelRequest request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var request = new Models.CancelRequest();

Models.CancelResponse result = await salesOrder.CreateCancelOrderWebService(request);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |


### <a name="create_replace_order_web_service"></a>![Method: ](https://apidocs.io/img/method.png "ProNimbusAPI.Standard.Controllers.SalesOrderController.CreateReplaceOrderWebService") CreateReplaceOrderWebService

> RESTful web service to replace a specific order or multiple orders.
> [Download the YAML for this call](API_orderReplace.yaml)
> 


```csharp
Task<Models.SalesOrderResponse> CreateReplaceOrderWebService(Models.Orders request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var request = new Models.Orders();

Models.SalesOrderResponse result = await salesOrder.CreateReplaceOrderWebService(request);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |


### <a name="get_order_status"></a>![Method: ](https://apidocs.io/img/method.png "ProNimbusAPI.Standard.Controllers.SalesOrderController.GetOrderStatus") GetOrderStatus

> RESTful web service to get order status information.
> [Download the YAML for this call](API_order.yaml)
> 


```csharp
Task<Models.OrderStatusResponse1> GetOrderStatus(
        string clientCode,
        Models.DetailView1Enum? detailView = null,
        DateTime? startTime = null,
        DateTime? endTime = null,
        List<string> orderNo = null,
        int? limit = null,
        int? offset = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| clientCode |  ``` Required ```  | Unique client identifier |
| detailView |  ``` Optional ```  | Return extra details in the response, not just the
status of the order. |
| startTime |  ``` Optional ```  | Return all orders during the date range starting at
`startTime` and ending at `endTime`. Timestamp must be
in [RFC3339](https://tools.ietf.org/html/rfc3339) format, i.e. `2018-02-18T00:00:00EST`. |
| endTime |  ``` Optional ```  | Required if `startTime` is specified.
Return all orders during the date range starting at
`startTime` and ending at `endTime`. Timestamp must be
in [RFC3339](https://tools.ietf.org/html/rfc3339) format, i.e. `2018-02-18T00:00:00EST`. |
| orderNo |  ``` Optional ```  ``` Collection ```  | Return the statuses of the specified orders. |
| limit |  ``` Optional ```  | Limit the number of results to the specified value. |
| offset |  ``` Optional ```  | Start returning results after skipping the specified number
of results. Only valid when used in conjunction with `limit`;
otherwise it is ignored. |


#### Example Usage

```csharp
string clientCode = "clientCode";
var detailView = Models.DetailView1Enum?Helper.ParseString("false");
DateTime? startTime = DateTime.Now();
DateTime? endTime = DateTime.Now();
List<string> orderNo = new List<string> { "orderNo" };
int? limit = 147;
int? offset = 147;

Models.OrderStatusResponse1 result = await salesOrder.GetOrderStatus(clientCode, detailView, startTime, endTime, orderNo, limit, offset);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Response on Failure |
| 0 | Unexpected error |


### <a name="get_validate_parcel_weight"></a>![Method: ](https://apidocs.io/img/method.png "ProNimbusAPI.Standard.Controllers.SalesOrderController.GetValidateParcelWeight") GetValidateParcelWeight

> RESTful web service to validate the expected weight of a given parcel against a measured value.
> [Download the YAML for this call](API_parcel_getWeight.yaml)
> 


```csharp
Task<Models.ParcelCheckWeightGoodResponse> GetValidateParcelWeight(
        string ulCode,
        string containerId = null,
        long? parcelId = null,
        string scannerId = null,
        double? weight = null,
        Models.UnitsEnum? units = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| ulCode |  ``` Required ```  | The tote ID of the parcel being validated. Cannot be specified if `parcel_id` is specified. |
| containerId |  ``` Optional ```  | A synonym for `ul_code`; will be ignored if `ul_code` is specified. The tote ID of the parcel being validated. |
| parcelId |  ``` Optional ```  | The internal parcel ID of the parcel being validated.
Must not be specified if `ul_code` or `container_id`
are specified, but is REQUIRED if they are not. |
| scannerId |  ``` Optional ```  | The ID of the scale performing the validation. |
| weight |  ``` Optional ```  | The weight of the parcel being validated. |
| units |  ``` Optional ```  | (Optional) For future expansion. Currently, only weights in pounds are supported. |


#### Example Usage

```csharp
string ulCode = "ul_code";
string containerId = "container_id";
long? parcelId = 147;
string scannerId = "scanner_id";
double? weight = 147.321123949867;
var units = Models.UnitsEnum?Helper.ParseString("pounds");

Models.ParcelCheckWeightGoodResponse result = await salesOrder.GetValidateParcelWeight(ulCode, containerId, parcelId, scannerId, weight, units);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Response on Failure |
| 0 | Unexpected error |


### <a name="create_sales_order_web_service"></a>![Method: ](https://apidocs.io/img/method.png "ProNimbusAPI.Standard.Controllers.SalesOrderController.CreateSalesOrderWebService") CreateSalesOrderWebService

> RESTful web service to POST orders.
> [Download the YAML for this call](API_processOrders.yaml)
> 


```csharp
Task<Models.SalesOrderResponse> CreateSalesOrderWebService(Models.Orders request)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var request = new Models.Orders();

Models.SalesOrderResponse result = await salesOrder.CreateSalesOrderWebService(request);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |


[Back to List of Controllers](#list_of_controllers)



