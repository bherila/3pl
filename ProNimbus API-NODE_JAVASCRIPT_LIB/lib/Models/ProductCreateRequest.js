/**
 * ProNimbusAPILib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

'use strict';

const BaseModel = require('./BaseModel');

/**
 * Creates an instance of ProductCreateRequest
 */
class ProductCreateRequest extends BaseModel {
    /**
     * @constructor
     * @param   {Object}  obj    The object passed to constructor
     */
    constructor(obj) {
        super(obj);
        if (obj === undefined || obj === null) return;
        this.clientCode = this.constructor.getValue(obj.clientCode);
        this.productSku = this.constructor.getValue(obj.productSku);
        this.productType = this.constructor.getValue(obj.productType);
        this.container = this.constructor.getValue(obj.container);
        this.amountPerContainer = this.constructor.getValue(obj.amountPerContainer);
        this.productName = this.constructor.getValue(obj.productName);
        this.shortDescription = this.constructor.getValue(obj.shortDescription);
        this.longDescription = this.constructor.getValue(obj.longDescription);
        this.labelDescription = this.constructor.getValue(obj.labelDescription);
        this.brandCode = this.constructor.getValue(obj.brandCode);
        this.retailPrice = this.constructor.getValue(obj.retailPrice, '0.00');
        this.backorderWarning = this.constructor.getValue(obj.backorderWarning, 'N');
        this.backorderThreshold = this.constructor.getValue(obj.backorderThreshold);
        this.serviceFee = this.constructor.getValue(obj.serviceFee, '0.00');
        this.weight = this.constructor.getValue(obj.weight, 0);
        this.slotEquivalent = this.constructor.getValue(obj.slotEquivalent);
        this.slotCount = this.constructor.getValue(obj.slotCount, 1);
    }

    /**
     * Function containing information about the fields of this model
     * @return   {array}   Array of objects containing information about the fields
     */
    static mappingInfo() {
        return super.mappingInfo().concat([
            { name: 'clientCode', realName: 'clientCode' },
            { name: 'productSku', realName: 'productSku' },
            { name: 'productType', realName: 'productType', isDiscrim: true },
            { name: 'container', realName: 'container' },
            { name: 'amountPerContainer', realName: 'amountPerContainer' },
            { name: 'productName', realName: 'productName' },
            { name: 'shortDescription', realName: 'shortDescription' },
            { name: 'longDescription', realName: 'longDescription' },
            { name: 'labelDescription', realName: 'labelDescription' },
            { name: 'brandCode', realName: 'brandCode' },
            { name: 'retailPrice', realName: 'retailPrice' },
            { name: 'backorderWarning', realName: 'backorderWarning' },
            { name: 'backorderThreshold', realName: 'backorderThreshold' },
            { name: 'serviceFee', realName: 'serviceFee' },
            { name: 'weight', realName: 'weight' },
            { name: 'slotEquivalent', realName: 'slotEquivalent' },
            { name: 'slotCount', realName: 'slotCount' },
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
        return {
            ProductCreateRequest: 'ProductCreateRequest',
            Merchandise: 'Merchandise',
            Wine: 'Wine',
            Food: 'Food',
            Collateral: 'Collateral',
        };
    }
}

module.exports = ProductCreateRequest;
