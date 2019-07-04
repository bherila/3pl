# Getting started

RESTful web services to communicate with the ProNimbus application. [Download this specification](ProNimbus_API_Swagger.yaml)

## How to Build

The generated SDK relies on [Node Package Manager](https://www.npmjs.com/) (NPM) being available to resolve dependencies. If you don't already have NPM installed, please go ahead and follow instructions to install NPM from [here](https://nodejs.org/en/download/).
The SDK also requires Node to be installed. If Node isn't already installed, please install it from [here](https://nodejs.org/en/download/)
> NPM is installed by default when Node is installed

To check if node and npm have been successfully installed, write the following commands in command prompt:

* `node --version`
* `npm -version`

![Version Check](https://apidocs.io/illustration/nodejs?step=versionCheck&workspaceFolder=ProNimbus%20API-Node)

Now use npm to resolve all dependencies by running the following command in the root directory (of the SDK folder):

```bash
npm install
```

![Resolve Dependencies](https://apidocs.io/illustration/nodejs?step=resolveDependency1&workspaceFolder=ProNimbus%20API-Node)

![Resolve Dependencies](https://apidocs.io/illustration/nodejs?step=resolveDependency2)

This will install all dependencies in the `node_modules` folder.

Once dependencies are resolved, you will need to move the folder `ProNimbusAPILib ` in to your `node_modules` folder.

## How to Use

The following section explains how to use the library in a new project.

### 1. Open Project Folder
Open an IDE/Text Editor for JavaScript like Sublime Text. The basic workflow presented here is also applicable if you prefer using a different editor or IDE.

Click on `File` and select `Open Folder`.

![Open Folder](https://apidocs.io/illustration/nodejs?step=openFolder)

Select the folder of your SDK and click on `Select Folder` to open it up in Sublime Text. The folder will become visible in the bar on the left.

![Open Project](https://apidocs.io/illustration/nodejs?step=openProject&workspaceFolder=ProNimbus%20API-Node)

### 2. Creating a Test File

Now right click on the folder name and select the `New File` option to create a new test file. Save it as `index.js` Now import the generated NodeJS library using the following lines of code:

```js
var lib = require('lib');
```

Save changes.

![Create new file](https://apidocs.io/illustration/nodejs?step=createNewFile&workspaceFolder=ProNimbus%20API-Node)

![Save new file](https://apidocs.io/illustration/nodejs?step=saveNewFile&workspaceFolder=ProNimbus%20API-Node)

### 3. Running The Test File

To run the `index.js` file, open up the command prompt and navigate to the Path where the SDK folder resides. Type the following command to run the file:

```
node index.js
```

![Run file](https://apidocs.io/illustration/nodejs?step=runProject&workspaceFolder=ProNimbus%20API-Node)


## How to Test

These tests use Mocha framework for testing, coupled with Chai for assertions. These dependencies need to be installed for tests to run.
Tests can be run in a number of ways:

### Method 1 (Run all tests)

1. Navigate to the root directory of the SDK folder from command prompt.
2. Type `mocha --recursive` to run all the tests.

### Method 2 (Run all tests)

1. Navigate to the `../test/Controllers/` directory from command prompt.
2. Type `mocha *` to run all the tests.

### Method 3 (Run specific controller's tests)

1. Navigate to the `../test/Controllers/` directory from command prompt.
2. Type `mocha  ProNimbus APIController`  to run all the tests in that controller file.

> To increase mocha's default timeout, you can change the `TEST_TIMEOUT` parameter's value in `TestBootstrap.js`.

![Run Tests](https://apidocs.io/illustration/nodejs?step=runTests&controllerName=ProNimbus%20APIController)

## Initialization

### 

API client can be initialized as following:

```JavaScript
const lib = require('lib');


```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [SKUController](#sku_controller)
* [NotificationsController](#notifications_controller)
* [InventoryController](#inventory_controller)
* [SalesOrderController](#sales_order_controller)

## <a name="sku_controller"></a>![Class: ](https://apidocs.io/img/class.png ".SKUController") SKUController

### Get singleton instance

The singleton instance of the ``` SKUController ``` class can be accessed from the API Client.

```javascript
var controller = lib.SKUController;
```

### <a name="create_product_details_web_service"></a>![Method: ](https://apidocs.io/img/method.png ".SKUController.createProductDetailsWebService") createProductDetailsWebService

> RESTful web service to fetch information about SKUs.
> [Download the YAML for this call](API_productDetails.yaml)
> 


```javascript
function createProductDetailsWebService(request, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage

```javascript

    var request = new ProductDetailsRequest({"key":"value"});

    controller.createProductDetailsWebService(request, function(error, response, context) {

    
    });
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Response on Failure |
| 0 | Unexpected error |




### <a name="create_product_create_web_service"></a>![Method: ](https://apidocs.io/img/method.png ".SKUController.createProductCreateWebService") createProductCreateWebService

> RESTful web service to create new SKUs.
> 


```javascript
function createProductCreateWebService(request, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | The product you want to add |



#### Example Usage

```javascript

    var request = new ProductCreateRequest({"key":"value"});

    controller.createProductCreateWebService(request, function(error, response, context) {

    
    });
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Response on Failure |
| 0 | Unexpected error |




### <a name="update_product_update"></a>![Method: ](https://apidocs.io/img/method.png ".SKUController.updateProductUpdate") updateProductUpdate

> RESTful web service to update product information.
> [Download the YAML for this call](API_product.yaml)
> 


```javascript
function updateProductUpdate(request, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | The product you want to update |



#### Example Usage

```javascript

    var request = new ProductUpdateRequest({"key":"value"});

    controller.updateProductUpdate(request, function(error, response, context) {

    
    });
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Response on Failure |
| 0 | Unexpected error |




[Back to List of Controllers](#list_of_controllers)

## <a name="notifications_controller"></a>![Class: ](https://apidocs.io/img/class.png ".NotificationsController") NotificationsController

### Get singleton instance

The singleton instance of the ``` NotificationsController ``` class can be accessed from the API Client.

```javascript
var controller = lib.NotificationsController;
```

### <a name="create_fetch_info_about_email_notifications_sent_on_behalf_of_a_client"></a>![Method: ](https://apidocs.io/img/method.png ".NotificationsController.createFetchInfoAboutEmailNotificationsSentOnBehalfOfAClient") createFetchInfoAboutEmailNotificationsSentOnBehalfOfAClient

> RESTful web service to fetch info about email notificatios sent on behalf of a client. [Download the YAML for this call](API_getNotifications.yaml)


```javascript
function createFetchInfoAboutEmailNotificationsSentOnBehalfOfAClient(request, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage

```javascript

    var request = new GetNotificationsRequest({"key":"value"});

    controller.createFetchInfoAboutEmailNotificationsSentOnBehalfOfAClient(request, function(error, response, context) {

    
    });
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |




[Back to List of Controllers](#list_of_controllers)

## <a name="inventory_controller"></a>![Class: ](https://apidocs.io/img/class.png ".InventoryController") InventoryController

### Get singleton instance

The singleton instance of the ``` InventoryController ``` class can be accessed from the API Client.

```javascript
var controller = lib.InventoryController;
```

### <a name="create_inbound_bill_of_lading_web_service"></a>![Method: ](https://apidocs.io/img/method.png ".InventoryController.createInboundBillOfLadingWebService") createInboundBillOfLadingWebService

> RESTful web service to create inbound BOLs.
> [Download the YAML for this call](API_bolInboundCreate.yaml)
> 


```javascript
function createInboundBillOfLadingWebService(request, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage

```javascript

    var request = new BolInboundCreateRequest({"key":"value"});

    controller.createInboundBillOfLadingWebService(request, function(error, response, context) {

    
    });
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |




### <a name="create_inventory_web_service"></a>![Method: ](https://apidocs.io/img/method.png ".InventoryController.createInventoryWebService") createInventoryWebService

> RESTful web service to GET inventory information.
> [Download the YAML for this call](API_getInventoryStatus.yaml)
> 


```javascript
function createInventoryWebService(request, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage

```javascript

    var request = new InventoryRequest({"key":"value"});

    controller.createInventoryWebService(request, function(error, response, context) {

    
    });
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |




[Back to List of Controllers](#list_of_controllers)

## <a name="sales_order_controller"></a>![Class: ](https://apidocs.io/img/class.png ".SalesOrderController") SalesOrderController

### Get singleton instance

The singleton instance of the ``` SalesOrderController ``` class can be accessed from the API Client.

```javascript
var controller = lib.SalesOrderController;
```

### <a name="alternate_pickup_location_web_service"></a>![Method: ](https://apidocs.io/img/method.png ".SalesOrderController.alternatePickupLocationWebService") alternatePickupLocationWebService

> RESTful web service to get alternate pickup locations.
> [Download the YAML for this call](API_getAlternatePickupLocations.yaml)
> 


```javascript
function alternatePickupLocationWebService(request, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage

```javascript

    var request = new AlternatePickupLocationsRequest({"key":"value"});

    controller.alternatePickupLocationWebService(request, function(error, response, context) {

    
    });
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Response on Error |
| 0 | Unexpected error |




### <a name="create_order_status_web_service"></a>![Method: ](https://apidocs.io/img/method.png ".SalesOrderController.createOrderStatusWebService") createOrderStatusWebService

> RESTful web service to GET order status information.
> [Download the YAML for this call](API_getOrderStatus.yaml)
> 


```javascript
function createOrderStatusWebService(request, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage

```javascript

    var request = new OrderStatusRequest({"key":"value"});

    controller.createOrderStatusWebService(request, function(error, response, context) {

    
    });
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |




### <a name="create_cancel_order_web_service"></a>![Method: ](https://apidocs.io/img/method.png ".SalesOrderController.createCancelOrderWebService") createCancelOrderWebService

> RESTful web service to cancel a specific order or multiple orders.
> [Download the YAML for this call](API_cancelOrder.yaml)
> 


```javascript
function createCancelOrderWebService(request, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage

```javascript

    var request = new CancelRequest({"key":"value"});

    controller.createCancelOrderWebService(request, function(error, response, context) {

    
    });
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |




### <a name="create_replace_order_web_service"></a>![Method: ](https://apidocs.io/img/method.png ".SalesOrderController.createReplaceOrderWebService") createReplaceOrderWebService

> RESTful web service to replace a specific order or multiple orders.
> [Download the YAML for this call](API_orderReplace.yaml)
> 


```javascript
function createReplaceOrderWebService(request, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage

```javascript

    var request = new Orders({"key":"value"});

    controller.createReplaceOrderWebService(request, function(error, response, context) {

    
    });
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |




### <a name="get_order_status"></a>![Method: ](https://apidocs.io/img/method.png ".SalesOrderController.getOrderStatus") getOrderStatus

> RESTful web service to get order status information.
> [Download the YAML for this call](API_order.yaml)
> 


```javascript
function getOrderStatus(clientCode, detailView, startTime, endTime, orderNo, limit, offset, callback)
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

```javascript

    var clientCode = 'clientCode';
    var detailView = Object.keys(detailView1)[0];
    var startTime = date("D M d, Y G:i");
    var endTime = date("D M d, Y G:i");
    var orderNo = ['orderNo'];
    var limit = 144;
    var offset = 144;

    controller.getOrderStatus(clientCode, detailView, startTime, endTime, orderNo, limit, offset, function(error, response, context) {

    
    });
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Response on Failure |
| 0 | Unexpected error |




### <a name="get_validate_parcel_weight"></a>![Method: ](https://apidocs.io/img/method.png ".SalesOrderController.getValidateParcelWeight") getValidateParcelWeight

> RESTful web service to validate the expected weight of a given parcel against a measured value.
> [Download the YAML for this call](API_parcel_getWeight.yaml)
> 


```javascript
function getValidateParcelWeight(ulCode, containerId, parcelId, scannerId, weight, units, callback)
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

```javascript

    var ulCode = ul_code;
    var containerId = container_id;
    var parcelId = 144;
    var scannerId = scanner_id;
    var weight = 144.406358778666;
    var units = Object.keys(units)[0];

    controller.getValidateParcelWeight(ulCode, containerId, parcelId, scannerId, weight, units, function(error, response, context) {

    
    });
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Response on Failure |
| 0 | Unexpected error |




### <a name="create_sales_order_web_service"></a>![Method: ](https://apidocs.io/img/method.png ".SalesOrderController.createSalesOrderWebService") createSalesOrderWebService

> RESTful web service to POST orders.
> [Download the YAML for this call](API_processOrders.yaml)
> 


```javascript
function createSalesOrderWebService(request, callback)
```
#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage

```javascript

    var request = new Orders({"key":"value"});

    controller.createSalesOrderWebService(request, function(error, response, context) {

    
    });
```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |




[Back to List of Controllers](#list_of_controllers)



