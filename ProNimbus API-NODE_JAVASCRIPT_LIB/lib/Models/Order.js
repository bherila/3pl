/**
 * ProNimbusAPILib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

'use strict';

const BaseModel = require('./BaseModel');

/**
 * Creates an instance of Order
 */
class Order extends BaseModel {
    /**
     * @constructor
     * @param   {Object}  obj    The object passed to constructor
     */
    constructor(obj) {
        super(obj);
        if (obj === undefined || obj === null) return;
        this.orderNo = this.constructor.getValue(obj.orderNo);
        this.orderType = this.constructor.getValue(obj.orderType, 'N/A');
        this.brandCode = this.constructor.getValue(obj.brandCode);
        this.subClub = this.constructor.getValue(obj.subClub);
        this.orderDate = this.constructor.getValue(obj.orderDate);
        this.shipMethod = this.constructor.getValue(obj.shipMethod);
        this.fulfillmentType = this.constructor.getValue(obj.fulfillmentType);
        this.fulfillmentLocation = this.constructor.getValue(obj.fulfillmentLocation);
        this.manifestLocation = this.constructor.getValue(obj.manifestLocation);
        this.transferDestination = this.constructor.getValue(obj.transferDestination);
        this.requestedShipDate = this.constructor.getValue(obj.requestedShipDate);
        this.shipToAddress = this.constructor.getValue(obj.shipToAddress);
        this.billToAddress = this.constructor.getValue(obj.billToAddress);
        this.altPickupAddress = this.constructor.getValue(obj.altPickupAddress);
        this.onHoldMessage = this.constructor.getValue(obj.onHoldMessage);
        this.specialInstructions = this.constructor.getValue(obj.specialInstructions);
        this.doNotReconfigure = this.constructor.getValue(obj.doNotReconfigure);
        this.licenseType = this.constructor.getValue(obj.licenseType);
        this.gift = this.constructor.getValue(obj.gift, 'N');
        this.giftMessage = this.constructor.getValue(obj.giftMessage);
        this.orderNo3P = this.constructor.getValue(obj.orderNo3P);
        this.shippingTotal = this.constructor.getValue(obj.shippingTotal);
        this.freightTax = this.constructor.getValue(obj.freightTax);
        this.additionalFields = this.constructor.getValue(obj.additionalFields);
        this.orderItems = this.constructor.getValue(obj.orderItems);
    }

    /**
     * Function containing information about the fields of this model
     * @return   {array}   Array of objects containing information about the fields
     */
    static mappingInfo() {
        return super.mappingInfo().concat([
            { name: 'orderNo', realName: 'orderNo' },
            { name: 'orderType', realName: 'orderType' },
            { name: 'brandCode', realName: 'brandCode' },
            { name: 'subClub', realName: 'subClub' },
            { name: 'orderDate', realName: 'orderDate' },
            { name: 'shipMethod', realName: 'shipMethod' },
            { name: 'fulfillmentType', realName: 'fulfillmentType' },
            { name: 'fulfillmentLocation', realName: 'fulfillmentLocation' },
            { name: 'manifestLocation', realName: 'manifestLocation' },
            { name: 'transferDestination', realName: 'transferDestination' },
            { name: 'requestedShipDate', realName: 'requestedShipDate' },
            { name: 'shipToAddress', realName: 'shipToAddress', type: 'ShippingAddress' },
            { name: 'billToAddress', realName: 'billToAddress', type: 'Address' },
            { name: 'altPickupAddress', realName: 'altPickupAddress', type: 'PickupAddress' },
            { name: 'onHoldMessage', realName: 'onHoldMessage' },
            { name: 'specialInstructions', realName: 'specialInstructions' },
            { name: 'doNotReconfigure', realName: 'doNotReconfigure' },
            { name: 'licenseType', realName: 'licenseType' },
            { name: 'gift', realName: 'gift' },
            { name: 'giftMessage', realName: 'giftMessage' },
            { name: 'orderNo3P', realName: 'orderNo3P' },
            { name: 'shippingTotal', realName: 'shippingTotal' },
            { name: 'freightTax', realName: 'freightTax' },
            { name: 'additionalFields', realName: 'additionalFields' },
            { name: 'orderItems', realName: 'orderItems', array: true, type: 'OrderItem' },
        ]);
    }

    /**
     * Function containing information about discriminator values
     * mapped with their corresponding model class names
     *
     * @return   {object}  Object containing Key-Value pairs mapping discriminator
     *                     values with their corresponding model classes
     */
    static discriminatorMap() {
        return {};
    }
}

module.exports = Order;
