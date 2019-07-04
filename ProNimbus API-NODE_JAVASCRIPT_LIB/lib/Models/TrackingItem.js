/**
 * ProNimbusAPILib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

'use strict';

const BaseModel = require('./BaseModel');

/**
 * Creates an instance of TrackingItem
 */
class TrackingItem extends BaseModel {
    /**
     * @constructor
     * @param   {Object}  obj    The object passed to constructor
     */
    constructor(obj) {
        super(obj);
        if (obj === undefined || obj === null) return;
        this.statusLocation = this.constructor.getValue(obj.statusLocation);
        this.statusMessage = this.constructor.getValue(obj.statusMessage);
        this.statusCode = this.constructor.getValue(obj.statusCode);
        this.statusDate = this.constructor.getValue(obj.statusDate);
    }

    /**
     * Function containing information about the fields of this model
     * @return   {array}   Array of objects containing information about the fields
     */
    static mappingInfo() {
        return super.mappingInfo().concat([
            { name: 'statusLocation', realName: 'statusLocation' },
            { name: 'statusMessage', realName: 'statusMessage' },
            { name: 'statusCode', realName: 'statusCode' },
            { name: 'statusDate', realName: 'statusDate' },
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

module.exports = TrackingItem;
