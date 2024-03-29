/*
 * pronimbusapi_lib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

package salesorder_pkg


import(
	"time"
	"encoding/json"
	"github.com/apimatic/unirest-go"
	"pronimbusapi_lib/apihelper_pkg"
	"pronimbusapi_lib/configuration_pkg"
	"pronimbusapi_lib/models_pkg"
)
/*
 * Client structure as interface implementation
 */
type SALESORDER_IMPL struct {
     config configuration_pkg.CONFIGURATION
}

/**
 * RESTful web service to get alternate pickup locations.
 * [Download the YAML for this call](API_getAlternatePickupLocations.yaml)
 * @param    *models_pkg.AlternatePickupLocationsRequest        request     parameter: Required
 * @return	Returns the *models_pkg.AlternatePickupLocationsResponse response from the API call
 */
func (me *SALESORDER_IMPL) AlternatePickupLocationWebService (
            request *models_pkg.AlternatePickupLocationsRequest) (*models_pkg.AlternatePickupLocationsResponse, error) {
    //the endpoint path uri
    _pathUrl := "/call/getAlternatePickupLocations"

    //variable to hold errors
    var err error = nil
    //the base uri for api requests
    _queryBuilder := configuration_pkg.GetBaseURI(configuration_pkg.ENUM_DEFAULT,me.config);

    //prepare query string for API call
   _queryBuilder = _queryBuilder + _pathUrl

    //validate and preprocess url
    _queryBuilder, err = apihelper_pkg.CleanUrl(_queryBuilder)
    if err != nil {
        //error in url validation or cleaning
        return nil, err
    }
    //prepare headers for the outgoing request
    headers := map[string]interface{} {
        "user-agent" : "APIMATIC 2.0",
        "accept" : "application/json",
        "content-type" : "application/json; charset=utf-8",
    }

    //prepare API request
    _request := unirest.Post(_queryBuilder, headers, request)
    //and invoke the API call request to fetch the response
    _response, err := unirest.AsString(_request,false);
    if err != nil {
        //error in API invocation
        return nil, err
    }

    //error handling using HTTP status codes
    if (_response.Code == 400) {
        err = apihelper_pkg.NewAPIError("Response on Error", _response.Code, _response.RawBody)
    } else if (_response.Code == 0) {
        err = apihelper_pkg.NewAPIError("Unexpected error", _response.Code, _response.RawBody)
    } else if (_response.Code < 200) || (_response.Code > 206) { //[200,206] = HTTP OK
            err = apihelper_pkg.NewAPIError("HTTP Response Not OK", _response.Code, _response.RawBody)
    }
    if(err != nil) {
        //error detected in status code validation
        return nil, err
    }

    //returning the response
    var retVal *models_pkg.AlternatePickupLocationsResponse = &models_pkg.AlternatePickupLocationsResponse{}
    err = json.Unmarshal(_response.RawBody, &retVal)

    if err != nil {
        //error in parsing
        return nil, err
    }
    return retVal, nil

}

/**
 * RESTful web service to GET order status information.
 * [Download the YAML for this call](API_getOrderStatus.yaml)
 * @param    *models_pkg.OrderStatusRequest        request     parameter: Required
 * @return	Returns the *models_pkg.OrderStatusResponse response from the API call
 */
func (me *SALESORDER_IMPL) CreateOrderStatusWebService (
            request *models_pkg.OrderStatusRequest) (*models_pkg.OrderStatusResponse, error) {
    //the endpoint path uri
    _pathUrl := "/call/getOrderStatus"

    //variable to hold errors
    var err error = nil
    //the base uri for api requests
    _queryBuilder := configuration_pkg.GetBaseURI(configuration_pkg.ENUM_DEFAULT,me.config);

    //prepare query string for API call
   _queryBuilder = _queryBuilder + _pathUrl

    //validate and preprocess url
    _queryBuilder, err = apihelper_pkg.CleanUrl(_queryBuilder)
    if err != nil {
        //error in url validation or cleaning
        return nil, err
    }
    //prepare headers for the outgoing request
    headers := map[string]interface{} {
        "user-agent" : "APIMATIC 2.0",
        "accept" : "application/json",
        "content-type" : "application/json; charset=utf-8",
    }

    //prepare API request
    _request := unirest.Post(_queryBuilder, headers, request)
    //and invoke the API call request to fetch the response
    _response, err := unirest.AsString(_request,false);
    if err != nil {
        //error in API invocation
        return nil, err
    }

    //error handling using HTTP status codes
    if (_response.Code == 0) {
        err = apihelper_pkg.NewAPIError("Unexpected error", _response.Code, _response.RawBody)
    } else if (_response.Code < 200) || (_response.Code > 206) { //[200,206] = HTTP OK
            err = apihelper_pkg.NewAPIError("HTTP Response Not OK", _response.Code, _response.RawBody)
    }
    if(err != nil) {
        //error detected in status code validation
        return nil, err
    }

    //returning the response
    var retVal *models_pkg.OrderStatusResponse = &models_pkg.OrderStatusResponse{}
    err = json.Unmarshal(_response.RawBody, &retVal)

    if err != nil {
        //error in parsing
        return nil, err
    }
    return retVal, nil

}

/**
 * RESTful web service to cancel a specific order or multiple orders.
 * [Download the YAML for this call](API_cancelOrder.yaml)
 * @param    *models_pkg.CancelRequest        request     parameter: Required
 * @return	Returns the *models_pkg.CancelResponse response from the API call
 */
func (me *SALESORDER_IMPL) CreateCancelOrderWebService (
            request *models_pkg.CancelRequest) (*models_pkg.CancelResponse, error) {
    //the endpoint path uri
    _pathUrl := "/call/cancelOrder"

    //variable to hold errors
    var err error = nil
    //the base uri for api requests
    _queryBuilder := configuration_pkg.GetBaseURI(configuration_pkg.ENUM_DEFAULT,me.config);

    //prepare query string for API call
   _queryBuilder = _queryBuilder + _pathUrl

    //validate and preprocess url
    _queryBuilder, err = apihelper_pkg.CleanUrl(_queryBuilder)
    if err != nil {
        //error in url validation or cleaning
        return nil, err
    }
    //prepare headers for the outgoing request
    headers := map[string]interface{} {
        "user-agent" : "APIMATIC 2.0",
        "accept" : "application/json",
        "content-type" : "application/json; charset=utf-8",
    }

    //prepare API request
    _request := unirest.Post(_queryBuilder, headers, request)
    //and invoke the API call request to fetch the response
    _response, err := unirest.AsString(_request,false);
    if err != nil {
        //error in API invocation
        return nil, err
    }

    //error handling using HTTP status codes
    if (_response.Code == 0) {
        err = apihelper_pkg.NewAPIError("Unexpected error", _response.Code, _response.RawBody)
    } else if (_response.Code < 200) || (_response.Code > 206) { //[200,206] = HTTP OK
            err = apihelper_pkg.NewAPIError("HTTP Response Not OK", _response.Code, _response.RawBody)
    }
    if(err != nil) {
        //error detected in status code validation
        return nil, err
    }

    //returning the response
    var retVal *models_pkg.CancelResponse = &models_pkg.CancelResponse{}
    err = json.Unmarshal(_response.RawBody, &retVal)

    if err != nil {
        //error in parsing
        return nil, err
    }
    return retVal, nil

}

/**
 * RESTful web service to replace a specific order or multiple orders.
 * [Download the YAML for this call](API_orderReplace.yaml)
 * @param    *models_pkg.Orders        request     parameter: Required
 * @return	Returns the *models_pkg.SalesOrderResponse response from the API call
 */
func (me *SALESORDER_IMPL) CreateReplaceOrderWebService (
            request *models_pkg.Orders) (*models_pkg.SalesOrderResponse, error) {
    //the endpoint path uri
    _pathUrl := "/call/orderReplace"

    //variable to hold errors
    var err error = nil
    //the base uri for api requests
    _queryBuilder := configuration_pkg.GetBaseURI(configuration_pkg.ENUM_DEFAULT,me.config);

    //prepare query string for API call
   _queryBuilder = _queryBuilder + _pathUrl

    //validate and preprocess url
    _queryBuilder, err = apihelper_pkg.CleanUrl(_queryBuilder)
    if err != nil {
        //error in url validation or cleaning
        return nil, err
    }
    //prepare headers for the outgoing request
    headers := map[string]interface{} {
        "user-agent" : "APIMATIC 2.0",
        "accept" : "application/json",
        "content-type" : "application/json; charset=utf-8",
    }

    //prepare API request
    _request := unirest.Post(_queryBuilder, headers, request)
    //and invoke the API call request to fetch the response
    _response, err := unirest.AsString(_request,false);
    if err != nil {
        //error in API invocation
        return nil, err
    }

    //error handling using HTTP status codes
    if (_response.Code == 0) {
        err = apihelper_pkg.NewAPIError("Unexpected error", _response.Code, _response.RawBody)
    } else if (_response.Code < 200) || (_response.Code > 206) { //[200,206] = HTTP OK
            err = apihelper_pkg.NewAPIError("HTTP Response Not OK", _response.Code, _response.RawBody)
    }
    if(err != nil) {
        //error detected in status code validation
        return nil, err
    }

    //returning the response
    var retVal *models_pkg.SalesOrderResponse = &models_pkg.SalesOrderResponse{}
    err = json.Unmarshal(_response.RawBody, &retVal)

    if err != nil {
        //error in parsing
        return nil, err
    }
    return retVal, nil

}

/**
 * RESTful web service to get order status information.
 * [Download the YAML for this call](API_order.yaml)
 * @param    string                            clientCode     parameter: Required
 * @param    models_pkg.DetailView1Enum        detailView     parameter: Optional
 * @param    *time.Time                        startTime      parameter: Optional
 * @param    *time.Time                        endTime        parameter: Optional
 * @param    []string                          orderNo        parameter: Optional
 * @param    *int64                            limit          parameter: Optional
 * @param    *int64                            offset         parameter: Optional
 * @return	Returns the *models_pkg.OrderStatusResponse1 response from the API call
 */
func (me *SALESORDER_IMPL) GetOrderStatus (
            clientCode string,
            detailView models_pkg.DetailView1Enum,
            startTime *time.Time,
            endTime *time.Time,
            orderNo []string,
            limit *int64,
            offset *int64) (*models_pkg.OrderStatusResponse1, error) {
    //the endpoint path uri
    _pathUrl := "/v2/order"

    //variable to hold errors
    var err error = nil
    //the base uri for api requests
    _queryBuilder := configuration_pkg.GetBaseURI(configuration_pkg.ENUM_DEFAULT,me.config);

    //prepare query string for API call
   _queryBuilder = _queryBuilder + _pathUrl

    //process optional query parameters
    _queryBuilder, err = apihelper_pkg.AppendUrlWithQueryParameters(_queryBuilder, map[string]interface{} {
        "clientCode" : clientCode,
        "detailView" : models_pkg.DetailView1EnumToValue(detailView),
        "startTime" : startTime,
        "endTime" : endTime,
        "orderNo" : orderNo,
        "limit" : limit,
        "offset" : offset,
    })
    if err != nil {
        //error in query param handling
        return nil, err
    }

    //validate and preprocess url
    _queryBuilder, err = apihelper_pkg.CleanUrl(_queryBuilder)
    if err != nil {
        //error in url validation or cleaning
        return nil, err
    }
    //prepare headers for the outgoing request
    headers := map[string]interface{} {
        "user-agent" : "APIMATIC 2.0",
        "accept" : "application/json",
    }

    //prepare API request
    _request := unirest.Get(_queryBuilder, headers)
    //and invoke the API call request to fetch the response
    _response, err := unirest.AsString(_request,false);
    if err != nil {
        //error in API invocation
        return nil, err
    }

    //error handling using HTTP status codes
    if (_response.Code == 400) {
        err = apihelper_pkg.NewAPIError("Response on Failure", _response.Code, _response.RawBody)
    } else if (_response.Code == 0) {
        err = apihelper_pkg.NewAPIError("Unexpected error", _response.Code, _response.RawBody)
    } else if (_response.Code < 200) || (_response.Code > 206) { //[200,206] = HTTP OK
            err = apihelper_pkg.NewAPIError("HTTP Response Not OK", _response.Code, _response.RawBody)
    }
    if(err != nil) {
        //error detected in status code validation
        return nil, err
    }

    //returning the response
    var retVal *models_pkg.OrderStatusResponse1 = &models_pkg.OrderStatusResponse1{}
    err = json.Unmarshal(_response.RawBody, &retVal)

    if err != nil {
        //error in parsing
        return nil, err
    }
    return retVal, nil

}

/**
 * RESTful web service to validate the expected weight of a given parcel against a measured value.
 * [Download the YAML for this call](API_parcel_getWeight.yaml)
 * @param    string                      ulCode           parameter: Required
 * @param    *string                     containerId      parameter: Optional
 * @param    *int64                      parcelId         parameter: Optional
 * @param    *string                     scannerId        parameter: Optional
 * @param    *float64                    weight           parameter: Optional
 * @param    models_pkg.UnitsEnum        units            parameter: Optional
 * @return	Returns the *models_pkg.ParcelCheckWeightGoodResponse response from the API call
 */
func (me *SALESORDER_IMPL) GetValidateParcelWeight (
            ulCode string,
            containerId *string,
            parcelId *int64,
            scannerId *string,
            weight *float64,
            units models_pkg.UnitsEnum) (*models_pkg.ParcelCheckWeightGoodResponse, error) {
    //the endpoint path uri
    _pathUrl := "/v2/parcel/checkWeight"

    //variable to hold errors
    var err error = nil
    //the base uri for api requests
    _queryBuilder := configuration_pkg.GetBaseURI(configuration_pkg.ENUM_DEFAULT,me.config);

    //prepare query string for API call
   _queryBuilder = _queryBuilder + _pathUrl

    //process optional query parameters
    _queryBuilder, err = apihelper_pkg.AppendUrlWithQueryParameters(_queryBuilder, map[string]interface{} {
        "ul_code" : ulCode,
        "container_id" : containerId,
        "parcel_id" : parcelId,
        "scanner_id" : scannerId,
        "weight" : weight,
        "units" : models_pkg.UnitsEnumToValue(units),
    })
    if err != nil {
        //error in query param handling
        return nil, err
    }

    //validate and preprocess url
    _queryBuilder, err = apihelper_pkg.CleanUrl(_queryBuilder)
    if err != nil {
        //error in url validation or cleaning
        return nil, err
    }
    //prepare headers for the outgoing request
    headers := map[string]interface{} {
        "user-agent" : "APIMATIC 2.0",
        "accept" : "application/json",
    }

    //prepare API request
    _request := unirest.Get(_queryBuilder, headers)
    //and invoke the API call request to fetch the response
    _response, err := unirest.AsString(_request,false);
    if err != nil {
        //error in API invocation
        return nil, err
    }

    //error handling using HTTP status codes
    if (_response.Code == 400) {
        err = apihelper_pkg.NewAPIError("Response on Failure", _response.Code, _response.RawBody)
    } else if (_response.Code == 0) {
        err = apihelper_pkg.NewAPIError("Unexpected error", _response.Code, _response.RawBody)
    } else if (_response.Code < 200) || (_response.Code > 206) { //[200,206] = HTTP OK
            err = apihelper_pkg.NewAPIError("HTTP Response Not OK", _response.Code, _response.RawBody)
    }
    if(err != nil) {
        //error detected in status code validation
        return nil, err
    }

    //returning the response
    var retVal *models_pkg.ParcelCheckWeightGoodResponse = &models_pkg.ParcelCheckWeightGoodResponse{}
    err = json.Unmarshal(_response.RawBody, &retVal)

    if err != nil {
        //error in parsing
        return nil, err
    }
    return retVal, nil

}

/**
 * RESTful web service to POST orders.
 * [Download the YAML for this call](API_processOrders.yaml)
 * @param    *models_pkg.Orders        request     parameter: Required
 * @return	Returns the *models_pkg.SalesOrderResponse response from the API call
 */
func (me *SALESORDER_IMPL) CreateSalesOrderWebService (
            request *models_pkg.Orders) (*models_pkg.SalesOrderResponse, error) {
    //the endpoint path uri
    _pathUrl := "/call/processOrders"

    //variable to hold errors
    var err error = nil
    //the base uri for api requests
    _queryBuilder := configuration_pkg.GetBaseURI(configuration_pkg.ENUM_DEFAULT,me.config);

    //prepare query string for API call
   _queryBuilder = _queryBuilder + _pathUrl

    //validate and preprocess url
    _queryBuilder, err = apihelper_pkg.CleanUrl(_queryBuilder)
    if err != nil {
        //error in url validation or cleaning
        return nil, err
    }
    //prepare headers for the outgoing request
    headers := map[string]interface{} {
        "user-agent" : "APIMATIC 2.0",
        "accept" : "application/json",
        "content-type" : "application/json; charset=utf-8",
    }

    //prepare API request
    _request := unirest.Post(_queryBuilder, headers, request)
    //and invoke the API call request to fetch the response
    _response, err := unirest.AsString(_request,false);
    if err != nil {
        //error in API invocation
        return nil, err
    }

    //error handling using HTTP status codes
    if (_response.Code == 0) {
        err = apihelper_pkg.NewAPIError("Unexpected error", _response.Code, _response.RawBody)
    } else if (_response.Code < 200) || (_response.Code > 206) { //[200,206] = HTTP OK
            err = apihelper_pkg.NewAPIError("HTTP Response Not OK", _response.Code, _response.RawBody)
    }
    if(err != nil) {
        //error detected in status code validation
        return nil, err
    }

    //returning the response
    var retVal *models_pkg.SalesOrderResponse = &models_pkg.SalesOrderResponse{}
    err = json.Unmarshal(_response.RawBody, &retVal)

    if err != nil {
        //error in parsing
        return nil, err
    }
    return retVal, nil

}

