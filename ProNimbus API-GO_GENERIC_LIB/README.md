# Getting started

RESTful web services to communicate with the ProNimbus application. [Download this specification](ProNimbus_API_Swagger.yaml)

## How to Build


* In order to successfully build and run your SDK files, you are required to have the following setup in your system:
    * **Go**  (Visit [https://golang.org/doc/install](https://golang.org/doc/install) for more details on how to install Go)
    * **Java VM** Version 8 or later
    * **Eclipse 4.6 (Neon)** or later ([http://www.eclipse.org/neon/](http://www.eclipse.org/neon/))
    * **GoClipse** setup within above installed Eclipse (Follow the instructions at [this link](https://github.com/GoClipse/goclipse/blob/latest/documentation/Installation.md#instructions) to setup GoClipse)
* Ensure that ```GOPATH``` environment variable is set in the system variables. If not, set it to your workspace directory where you will be adding your Go projects.
* The generated code uses unirest-go http library. Therefore, you will need internet access to resolve this dependency. If Go is properly installed and configured, run the following command to pull the dependency:

```Go
go get github.com/apimatic/unirest-go
```

This will install unirest-go in the ```GOPATH``` you specified in the system variables.

Now follow the steps mentioned below to build your SDK:

1. Open eclipse in the Go language perspective and click on the ```Import``` option in ```File``` menu.

![Importing SDK into Eclipse - Step 1](https://apidocs.io/illustration/go?step=import0)

2. Select ```General -> Existing Projects into Workspace``` option from the tree list.

![Importing SDK into Eclipse - Step 2](https://apidocs.io/illustration/go?step=import1)

3. In ```Select root directory```, provide path to the unzipped archive for the generated code. Once the path is set and the Project becomes visible under ```Projects``` click ```Finish```

![Importing SDK into Eclipse - Step 3](https://apidocs.io/illustration/go?step=import2&workspaceFolder=ProNimbus%20API-GoLang&projectName=pronimbusapi_lib)

4. The Go library will be imported and its files will be visible in the Project Explorer

![Importing SDK into Eclipse - Step 4](https://apidocs.io/illustration/go?step=import3&projectName=pronimbusapi_lib)

## How to Use

The following section explains how to use the PronimbusapiLib library in a new project.

### 1. Add a new Test Project

Create a new project in Eclipse by ```File``` -> ```New``` -> ```Go Project```

![Add a new project in Eclipse](https://apidocs.io/illustration/go?step=createNewProject0)

Name the Project as ```Test``` and click ```Finish```

![Create a new Maven Project - Step 1](https://apidocs.io/illustration/go?step=createNewProject1)

Create a new directory in the ```src``` directory of this project

![Create a new Maven Project - Step 2](https://apidocs.io/illustration/go?step=createNewProject2&projectName=pronimbusapi_lib)

Name it ```test.com```

![Create a new Maven Project - Step 3](https://apidocs.io/illustration/go?step=createNewProject3&projectName=pronimbusapi_lib)

Now create a new file inside ```src/test.com```

![Create a new Maven Project - Step 4](https://apidocs.io/illustration/go?step=createNewProject4&projectName=pronimbusapi_lib)

Name it ```testsdk.go```

![Create a new Maven Project - Step 5](https://apidocs.io/illustration/go?step=createNewProject5&projectName=pronimbusapi_lib)

In this Go file, you can start adding code to initialize the client library. Sample code to initialize the client library and using its methods is given in the subsequent sections.

### 2. Configure the Test Project

You need to import your generated library in this project in order to make use of its functions. In order to import the library, you can add its path in the ```GOPATH``` for this project. Follow the below steps:

Right click on the project name and click on ```Properties```

![Adding dependency to the client library - Step 1](https://apidocs.io/illustration/go?step=testProject0&projectName=pronimbusapi_lib)

Choose ```Go Compiler``` from the side menu. Check ```Use project specific settings``` and uncheck ```Use same value as the GOPATH environment variable.```. By default, the GOPATH value from the environment variables will be visible in ```Eclipse GOPATH```. Do not remove this as this points to the unirest dependency.

![Adding dependency to the client library - Step 2](https://apidocs.io/illustration/go?step=testProject1)

Append the library path to this GOPATH

![Adding dependency to the client library - Step 3](https://apidocs.io/illustration/go?step=testProject2&workspaceFolder=ProNimbus%20API-GoLang)

Once the path is appended, click on ```OK```

### 3. Build the Test Project

Right click on the project name and click on ```Build Project```

![Build Project](https://apidocs.io/illustration/go?step=buildProject&projectName=pronimbusapi_lib)

### 4. Run the Test Project

If the build is successful, right click on your Go file and click on ```Run As``` -> ```Go Application```

![Run Project](https://apidocs.io/illustration/go?step=runProject&projectName=pronimbusapi_lib)

# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [sku_pkg](#sku_pkg)
* [notifications_pkg](#notifications_pkg)
* [inventory_pkg](#inventory_pkg)
* [salesorder_pkg](#salesorder_pkg)

## <a name="sku_pkg"></a>![Class: ](https://apidocs.io/img/class.png ".sku_pkg") sku_pkg

### Get instance

Factory for the ``` SKU ``` interface can be accessed from the package sku_pkg.

```go
sKU := sku_pkg.NewSKU()
```

### <a name="create_product_details_web_service"></a>![Method: ](https://apidocs.io/img/method.png ".sku_pkg.CreateProductDetailsWebService") CreateProductDetailsWebService

> RESTful web service to fetch information about SKUs.
> [Download the YAML for this call](API_productDetails.yaml)
> 


```go
func (me *SKU_IMPL) CreateProductDetailsWebService(request *models_pkg.ProductDetailsRequest)(*models_pkg.ProductDetailsResponse,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```go
var request *models_pkg.ProductDetailsRequest

var result *models_pkg.ProductDetailsResponse
result,_ = sKU.CreateProductDetailsWebService(request)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 400 | Response on Failure |
| 0 | Unexpected error |



### <a name="create_product_create_web_service"></a>![Method: ](https://apidocs.io/img/method.png ".sku_pkg.CreateProductCreateWebService") CreateProductCreateWebService

> RESTful web service to create new SKUs.
> 


```go
func (me *SKU_IMPL) CreateProductCreateWebService(request *models_pkg.ProductCreateRequest)(*models_pkg.ProductCreateResponse,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | The product you want to add |


#### Example Usage

```go
var request *models_pkg.ProductCreateRequest

var result *models_pkg.ProductCreateResponse
result,_ = sKU.CreateProductCreateWebService(request)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 400 | Response on Failure |
| 0 | Unexpected error |



### <a name="update_product_update"></a>![Method: ](https://apidocs.io/img/method.png ".sku_pkg.UpdateProductUpdate") UpdateProductUpdate

> RESTful web service to update product information.
> [Download the YAML for this call](API_product.yaml)
> 


```go
func (me *SKU_IMPL) UpdateProductUpdate(request *models_pkg.ProductUpdateRequest)(*models_pkg.ProductUpdateResponseSuccess,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | The product you want to update |


#### Example Usage

```go
var request *models_pkg.ProductUpdateRequest

var result *models_pkg.ProductUpdateResponseSuccess
result,_ = sKU.UpdateProductUpdate(request)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 400 | Response on Failure |
| 0 | Unexpected error |



[Back to List of Controllers](#list_of_controllers)

## <a name="notifications_pkg"></a>![Class: ](https://apidocs.io/img/class.png ".notifications_pkg") notifications_pkg

### Get instance

Factory for the ``` NOTIFICATIONS ``` interface can be accessed from the package notifications_pkg.

```go
notifications := notifications_pkg.NewNOTIFICATIONS()
```

### <a name="create_fetch_info_about_email_notifications_sent_on_behalf_of_a_client"></a>![Method: ](https://apidocs.io/img/method.png ".notifications_pkg.CreateFetchInfoAboutEmailNotificationsSentOnBehalfOfAClient") CreateFetchInfoAboutEmailNotificationsSentOnBehalfOfAClient

> RESTful web service to fetch info about email notificatios sent on behalf of a client. [Download the YAML for this call](API_getNotifications.yaml)


```go
func (me *NOTIFICATIONS_IMPL) CreateFetchInfoAboutEmailNotificationsSentOnBehalfOfAClient(request *models_pkg.GetNotificationsRequest)(*models_pkg.GetNotificationsResponse,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```go
var request *models_pkg.GetNotificationsRequest

var result *models_pkg.GetNotificationsResponse
result,_ = notifications.CreateFetchInfoAboutEmailNotificationsSentOnBehalfOfAClient(request)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |



[Back to List of Controllers](#list_of_controllers)

## <a name="inventory_pkg"></a>![Class: ](https://apidocs.io/img/class.png ".inventory_pkg") inventory_pkg

### Get instance

Factory for the ``` INVENTORY ``` interface can be accessed from the package inventory_pkg.

```go
inventory := inventory_pkg.NewINVENTORY()
```

### <a name="create_inbound_bill_of_lading_web_service"></a>![Method: ](https://apidocs.io/img/method.png ".inventory_pkg.CreateInboundBillOfLadingWebService") CreateInboundBillOfLadingWebService

> RESTful web service to create inbound BOLs.
> [Download the YAML for this call](API_bolInboundCreate.yaml)
> 


```go
func (me *INVENTORY_IMPL) CreateInboundBillOfLadingWebService(request *models_pkg.BolInboundCreateRequest)(*models_pkg.BolInboundCreateSuccessResponse,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```go
var request *models_pkg.BolInboundCreateRequest

var result *models_pkg.BolInboundCreateSuccessResponse
result,_ = inventory.CreateInboundBillOfLadingWebService(request)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |



### <a name="create_inventory_web_service"></a>![Method: ](https://apidocs.io/img/method.png ".inventory_pkg.CreateInventoryWebService") CreateInventoryWebService

> RESTful web service to GET inventory information.
> [Download the YAML for this call](API_getInventoryStatus.yaml)
> 


```go
func (me *INVENTORY_IMPL) CreateInventoryWebService(request *models_pkg.InventoryRequest)(*models_pkg.InventoryResponse,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```go
var request *models_pkg.InventoryRequest

var result *models_pkg.InventoryResponse
result,_ = inventory.CreateInventoryWebService(request)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |



[Back to List of Controllers](#list_of_controllers)

## <a name="salesorder_pkg"></a>![Class: ](https://apidocs.io/img/class.png ".salesorder_pkg") salesorder_pkg

### Get instance

Factory for the ``` SALESORDER ``` interface can be accessed from the package salesorder_pkg.

```go
salesOrder := salesorder_pkg.NewSALESORDER()
```

### <a name="alternate_pickup_location_web_service"></a>![Method: ](https://apidocs.io/img/method.png ".salesorder_pkg.AlternatePickupLocationWebService") AlternatePickupLocationWebService

> RESTful web service to get alternate pickup locations.
> [Download the YAML for this call](API_getAlternatePickupLocations.yaml)
> 


```go
func (me *SALESORDER_IMPL) AlternatePickupLocationWebService(request *models_pkg.AlternatePickupLocationsRequest)(*models_pkg.AlternatePickupLocationsResponse,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```go
var request *models_pkg.AlternatePickupLocationsRequest

var result *models_pkg.AlternatePickupLocationsResponse
result,_ = salesOrder.AlternatePickupLocationWebService(request)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 400 | Response on Error |
| 0 | Unexpected error |



### <a name="create_order_status_web_service"></a>![Method: ](https://apidocs.io/img/method.png ".salesorder_pkg.CreateOrderStatusWebService") CreateOrderStatusWebService

> RESTful web service to GET order status information.
> [Download the YAML for this call](API_getOrderStatus.yaml)
> 


```go
func (me *SALESORDER_IMPL) CreateOrderStatusWebService(request *models_pkg.OrderStatusRequest)(*models_pkg.OrderStatusResponse,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```go
var request *models_pkg.OrderStatusRequest

var result *models_pkg.OrderStatusResponse
result,_ = salesOrder.CreateOrderStatusWebService(request)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |



### <a name="create_cancel_order_web_service"></a>![Method: ](https://apidocs.io/img/method.png ".salesorder_pkg.CreateCancelOrderWebService") CreateCancelOrderWebService

> RESTful web service to cancel a specific order or multiple orders.
> [Download the YAML for this call](API_cancelOrder.yaml)
> 


```go
func (me *SALESORDER_IMPL) CreateCancelOrderWebService(request *models_pkg.CancelRequest)(*models_pkg.CancelResponse,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```go
var request *models_pkg.CancelRequest

var result *models_pkg.CancelResponse
result,_ = salesOrder.CreateCancelOrderWebService(request)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |



### <a name="create_replace_order_web_service"></a>![Method: ](https://apidocs.io/img/method.png ".salesorder_pkg.CreateReplaceOrderWebService") CreateReplaceOrderWebService

> RESTful web service to replace a specific order or multiple orders.
> [Download the YAML for this call](API_orderReplace.yaml)
> 


```go
func (me *SALESORDER_IMPL) CreateReplaceOrderWebService(request *models_pkg.Orders)(*models_pkg.SalesOrderResponse,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```go
var request *models_pkg.Orders

var result *models_pkg.SalesOrderResponse
result,_ = salesOrder.CreateReplaceOrderWebService(request)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |



### <a name="get_order_status"></a>![Method: ](https://apidocs.io/img/method.png ".salesorder_pkg.GetOrderStatus") GetOrderStatus

> RESTful web service to get order status information.
> [Download the YAML for this call](API_order.yaml)
> 


```go
func (me *SALESORDER_IMPL) GetOrderStatus(
            clientCode string,
            detailView models_pkg.DetailView1Enum,
            startTime *time.Time,
            endTime *time.Time,
            orderNo []string,
            limit *int64,
            offset *int64)(*models_pkg.OrderStatusResponse1,error)
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

```go
clientCode := "clientCode"
detailView := models_pkg.detailView1_FALSE
startTime := time.Now()
endTime := time.Now()
orderNo := []string{"orderNo"}
limit,_ := strconv.ParseInt("99", 10, 8)
offset,_ := strconv.ParseInt("99", 10, 8)

var result *models_pkg.OrderStatusResponse1
result,_ = salesOrder.GetOrderStatus(clientCode, detailView, startTime, endTime, orderNo, limit, offset)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 400 | Response on Failure |
| 0 | Unexpected error |



### <a name="get_validate_parcel_weight"></a>![Method: ](https://apidocs.io/img/method.png ".salesorder_pkg.GetValidateParcelWeight") GetValidateParcelWeight

> RESTful web service to validate the expected weight of a given parcel against a measured value.
> [Download the YAML for this call](API_parcel_getWeight.yaml)
> 


```go
func (me *SALESORDER_IMPL) GetValidateParcelWeight(
            ulCode string,
            containerId *string,
            parcelId *int64,
            scannerId *string,
            weight *float64,
            units models_pkg.UnitsEnum)(*models_pkg.ParcelCheckWeightGoodResponse,error)
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

```go
ulCode := "ul_code"
containerId := "container_id"
parcelId,_ := strconv.ParseInt("99", 10, 8)
scannerId := "scanner_id"
weight := 99.961137252376
units := models_pkg.units_POUNDS

var result *models_pkg.ParcelCheckWeightGoodResponse
result,_ = salesOrder.GetValidateParcelWeight(ulCode, containerId, parcelId, scannerId, weight, units)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 400 | Response on Failure |
| 0 | Unexpected error |



### <a name="create_sales_order_web_service"></a>![Method: ](https://apidocs.io/img/method.png ".salesorder_pkg.CreateSalesOrderWebService") CreateSalesOrderWebService

> RESTful web service to POST orders.
> [Download the YAML for this call](API_processOrders.yaml)
> 


```go
func (me *SALESORDER_IMPL) CreateSalesOrderWebService(request *models_pkg.Orders)(*models_pkg.SalesOrderResponse,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| request |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```go
var request *models_pkg.Orders

var result *models_pkg.SalesOrderResponse
result,_ = salesOrder.CreateSalesOrderWebService(request)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 0 | Unexpected error |



[Back to List of Controllers](#list_of_controllers)



