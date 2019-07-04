/**
  * @module ProNimbusAPILib
  *
  * RESTful web services to communicate with the ProNimbus application. [Download this
  * specification](ProNimbus_API_Swagger.yaml)
  */

'use strict';

const Configuration = require('./configuration');
const Environments = require('./Environments');
const SKUController = require('./Controllers/SKUController');
const NotificationsController = require('./Controllers/NotificationsController');
const InventoryController = require('./Controllers/InventoryController');
const SalesOrderController = require('./Controllers/SalesOrderController');
const Merchandise = require('./Models/Merchandise');
const WmsUpdateStatusEnum = require('./Models/WmsUpdateStatusEnum');
const WineTypeEnum = require('./Models/WineTypeEnum');
const Units1Enum = require('./Models/Units1Enum');
const Units3Enum = require('./Models/Units3Enum');
const Type8Enum = require('./Models/Type8Enum');
const UnitsEnum = require('./Models/UnitsEnum');
const Response = require('./Models/Response');
const Results = require('./Models/Results');
const ProductUpdateResponseSuccess = require('./Models/ProductUpdateResponseSuccess');
const ProductDetailsRequest = require('./Models/ProductDetailsRequest');
const PendingEnum = require('./Models/PendingEnum');
const ParcelStatusItem = require('./Models/ParcelStatusItem');
const ParcelStatus1 = require('./Models/ParcelStatus1');
const ParcelStatus = require('./Models/ParcelStatus');
const ParcelCheckWeightGoodResponse = require('./Models/ParcelCheckWeightGoodResponse');
const OrderStatusResponse1 = require('./Models/OrderStatusResponse1');
const OrderStatusRequest = require('./Models/OrderStatusRequest');
const OnHoldEnum = require('./Models/OnHoldEnum');
const MessageEnum = require('./Models/MessageEnum');
const OrderStatusResponse = require('./Models/OrderStatusResponse');
const LocationTypeEnum = require('./Models/LocationTypeEnum');
const AltLocationTypeEnum = require('./Models/AltLocationTypeEnum');
const Status4Enum = require('./Models/Status4Enum');
const Status3Enum = require('./Models/Status3Enum');
const Status2Enum = require('./Models/Status2Enum');
const Status1Enum = require('./Models/Status1Enum');
const StatusEnum = require('./Models/StatusEnum');
const SalesOrderResponse = require('./Models/SalesOrderResponse');
const StatusCodeEnum = require('./Models/StatusCodeEnum');
const RouteDirectionEnum = require('./Models/RouteDirectionEnum');
const Results5 = require('./Models/Results5');
const Results1 = require('./Models/Results1');
const Result2 = require('./Models/Result2');
const Result = require('./Models/Result');
const Orders = require('./Models/Orders');
const OrderItem1 = require('./Models/OrderItem1');
const RequestTypeEnum = require('./Models/RequestTypeEnum');
const RejectedOrderDescription = require('./Models/RejectedOrderDescription');
const TypeEnum = require('./Models/TypeEnum');
const InventoryItem = require('./Models/InventoryItem');
const Address2 = require('./Models/Address2');
const PickupAddress = require('./Models/PickupAddress');
const ShippingAddress = require('./Models/ShippingAddress');
const Address = require('./Models/Address');
const WineOriginEnum = require('./Models/WineOriginEnum');
const ShipMethodEnum = require('./Models/ShipMethodEnum');
const Order = require('./Models/Order');
const SlotEquivalentEnum = require('./Models/SlotEquivalentEnum');
const Results4 = require('./Models/Results4');
const Results3 = require('./Models/Results3');
const Result1 = require('./Models/Result1');
const ProductUpdateRequest = require('./Models/ProductUpdateRequest');
const OrderStatusItem1 = require('./Models/OrderStatusItem1');
const OrderStatusItem = require('./Models/OrderStatusItem');
const OrderItem = require('./Models/OrderItem');
const BolInboundCreatePayload = require('./Models/BolInboundCreatePayload');
const Wine = require('./Models/Wine');
const ProductCreateRequest = require('./Models/ProductCreateRequest');
const InventoryRequest = require('./Models/InventoryRequest');
const RejectedOrder = require('./Models/RejectedOrder');
const GiftEnum = require('./Models/GiftEnum');
const InventoryResponse = require('./Models/InventoryResponse');
const FoodRefrigerationEnum = require('./Models/FoodRefrigerationEnum');
const ProductDetailsResponse = require('./Models/ProductDetailsResponse');
const FoodPerishableEnum = require('./Models/FoodPerishableEnum');
const ProductDetailsItem = require('./Models/ProductDetailsItem');
const DetailView1Enum = require('./Models/DetailView1Enum');
const GetNotificationsResponse = require('./Models/GetNotificationsResponse');
const ParcelStatusItem1 = require('./Models/ParcelStatusItem1');
const OrderTypeEnum = require('./Models/OrderTypeEnum');
const DetailViewEnum = require('./Models/DetailViewEnum');
const DeficientSku = require('./Models/DeficientSku');
const MessageTypeEnum = require('./Models/MessageTypeEnum');
const CollateralTypeEnum = require('./Models/CollateralTypeEnum');
const CancelRequest = require('./Models/CancelRequest');
const BolInboundCreateSuccessResponse = require('./Models/BolInboundCreateSuccessResponse');
const BolInboundCreateRequest = require('./Models/BolInboundCreateRequest');
const CancelResponse = require('./Models/CancelResponse');
const AlternatePickupLocationsResponse = require('./Models/AlternatePickupLocationsResponse');
const AcceptedOrder = require('./Models/AcceptedOrder');
const Message2 = require('./Models/Message2');
const ProductCreateResponse = require('./Models/ProductCreateResponse');
const BackorderWarningEnum = require('./Models/BackorderWarningEnum');
const MError = require('./Models/MError');
const Location = require('./Models/Location');
const GetNotificationsRequest = require('./Models/GetNotificationsRequest');
const GenericError = require('./Models/GenericError');
const FoodTypeEnum = require('./Models/FoodTypeEnum');
const BolInboundRequestPosition = require('./Models/BolInboundRequestPosition');
const AlternatePickupLocationsRequest = require('./Models/AlternatePickupLocationsRequest');
const ProductTypeEnum = require('./Models/ProductTypeEnum');
const Food = require('./Models/Food');
const TrackingItem = require('./Models/TrackingItem');
const FulfillmentTypeEnum = require('./Models/FulfillmentTypeEnum');
const TrackingResponseItem = require('./Models/TrackingResponseItem');
const TrackingResponse = require('./Models/TrackingResponse');
const Collateral = require('./Models/Collateral');
const TrackingRequest = require('./Models/TrackingRequest');
const WineVarietalEnum = require('./Models/WineVarietalEnum');
const ProductUpdateResponseFailureException =
  require('./Exceptions/ProductUpdateResponseFailureException');
const ParcelCheckWeightBadResponseException =
  require('./Exceptions/ParcelCheckWeightBadResponseException');
const OrderStatusResponse1ErrorException =
  require('./Exceptions/OrderStatusResponse1ErrorException');
const Error1Exception = require('./Exceptions/Error1Exception');
const ProductDetailsErrorResponseException =
  require('./Exceptions/ProductDetailsErrorResponseException');
const AlternatePickupLocationsErrorResponseException =
  require('./Exceptions/AlternatePickupLocationsErrorResponseException');
const ProductCreateFailureResponseException =
  require('./Exceptions/ProductCreateFailureResponseException');
const GenericError2Exception = require('./Exceptions/GenericError2Exception');
const APIException = require('./Exceptions/APIException');


const initializer = {
    // functional components of ProNimbusAPILib
    Configuration,
    Environments,
    // controllers of ProNimbusAPILib
    SKUController,
    NotificationsController,
    InventoryController,
    SalesOrderController,
    // models of ProNimbusAPILib
    Merchandise,
    WmsUpdateStatusEnum,
    WineTypeEnum,
    Units1Enum,
    Units3Enum,
    Type8Enum,
    UnitsEnum,
    Response,
    Results,
    ProductUpdateResponseSuccess,
    ProductDetailsRequest,
    PendingEnum,
    ParcelStatusItem,
    ParcelStatus1,
    ParcelStatus,
    ParcelCheckWeightGoodResponse,
    OrderStatusResponse1,
    OrderStatusRequest,
    OnHoldEnum,
    MessageEnum,
    OrderStatusResponse,
    LocationTypeEnum,
    AltLocationTypeEnum,
    Status4Enum,
    Status3Enum,
    Status2Enum,
    Status1Enum,
    StatusEnum,
    SalesOrderResponse,
    StatusCodeEnum,
    RouteDirectionEnum,
    Results5,
    Results1,
    Result2,
    Result,
    Orders,
    OrderItem1,
    RequestTypeEnum,
    RejectedOrderDescription,
    TypeEnum,
    InventoryItem,
    Address2,
    PickupAddress,
    ShippingAddress,
    Address,
    WineOriginEnum,
    ShipMethodEnum,
    Order,
    SlotEquivalentEnum,
    Results4,
    Results3,
    Result1,
    ProductUpdateRequest,
    OrderStatusItem1,
    OrderStatusItem,
    OrderItem,
    BolInboundCreatePayload,
    Wine,
    ProductCreateRequest,
    InventoryRequest,
    RejectedOrder,
    GiftEnum,
    InventoryResponse,
    FoodRefrigerationEnum,
    ProductDetailsResponse,
    FoodPerishableEnum,
    ProductDetailsItem,
    DetailView1Enum,
    GetNotificationsResponse,
    ParcelStatusItem1,
    OrderTypeEnum,
    DetailViewEnum,
    DeficientSku,
    MessageTypeEnum,
    CollateralTypeEnum,
    CancelRequest,
    BolInboundCreateSuccessResponse,
    BolInboundCreateRequest,
    CancelResponse,
    AlternatePickupLocationsResponse,
    AcceptedOrder,
    Message2,
    ProductCreateResponse,
    BackorderWarningEnum,
    MError,
    Location,
    GetNotificationsRequest,
    GenericError,
    FoodTypeEnum,
    BolInboundRequestPosition,
    AlternatePickupLocationsRequest,
    ProductTypeEnum,
    Food,
    TrackingItem,
    FulfillmentTypeEnum,
    TrackingResponseItem,
    TrackingResponse,
    Collateral,
    TrackingRequest,
    WineVarietalEnum,
    // exceptions of ProNimbusAPILib
    ProductUpdateResponseFailureException,
    ParcelCheckWeightBadResponseException,
    OrderStatusResponse1ErrorException,
    Error1Exception,
    ProductDetailsErrorResponseException,
    AlternatePickupLocationsErrorResponseException,
    ProductCreateFailureResponseException,
    GenericError2Exception,
    APIException,
};

module.exports = initializer;
