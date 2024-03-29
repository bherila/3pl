/**
 * ProNimbusAPILib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

'use strict';

const BaseModel = require('./BaseModel');

/**
 * Creates an instance of OrderStatusItem1
 */
class OrderStatusItem1 extends BaseModel {
    /**
     * @constructor
     * @param   {Object}  obj    The object passed to constructor
     */
    constructor(obj) {
        super(obj);
        if (obj === undefined || obj === null) return;
        this.specialInstructions = this.constructor.getValue(obj.specialInstructions);
        this.address = this.constructor.getValue(obj.address);
        this.orderItems = this.constructor.getValue(obj.orderItems);
        this.deficientSkus = this.constructor.getValue(obj.deficientSkus);
        this.orderNo = this.constructor.getValue(obj.orderNo);
        this.statusCode = this.constructor.getValue(obj.statusCode);
        this.statusMessage = this.constructor.getValue(obj.statusMessage);
        this.carrierId = this.constructor.getValue(obj.carrierId);
        this.fulfillmentType = this.constructor.getValue(obj.fulfillmentType);
        this.shipDate = this.constructor.getValue(obj.shipDate);
        this.orderTrackingURL = this.constructor.getValue(obj.orderTrackingURL);
        this.onHold = this.constructor.getValue(obj.onHold);
        this.parcels = this.constructor.getValue(obj.parcels);
    }

    /**
     * Function containing information about the fields of this model
     * @return   {array}   Array of objects containing information about the fields
     */
    static mappingInfo() {
        return super.mappingInfo().concat([
            { name: 'specialInstructions', realName: 'specialInstructions' },
            { name: 'address', realName: 'address', type: 'Address2' },
            { name: 'orderItems', realName: 'orderItems', array: true, type: 'OrderItem1' },
            { name: 'deficientSkus', realName: 'deficientSkus', array: true, type: 'DeficientSku' },
            { name: 'orderNo', realName: 'orderNo' },
            { name: 'statusCode', realName: 'statusCode' },
            { name: 'statusMessage', realName: 'statusMessage' },
            { name: 'carrierId', realName: 'carrierId' },
            { name: 'fulfillmentType', realName: 'fulfillmentType' },
            { name: 'shipDate', realName: 'shipDate' },
            { name: 'orderTrackingURL', realName: 'orderTrackingURL' },
            { name: 'onHold', realName: 'onHold' },
            { name: 'parcels', realName: 'parcels', array: true, type: 'ParcelStatus1' },
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

module.exports = OrderStatusItem1;
