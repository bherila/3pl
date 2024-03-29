/**
 * ProNimbusAPILib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

'use strict';

const BaseModel = require('./BaseModel');

/**
 * Creates an instance of ParcelStatusItem1
 */
class ParcelStatusItem1 extends BaseModel {
    /**
     * @constructor
     * @param   {Object}  obj    The object passed to constructor
     */
    constructor(obj) {
        super(obj);
        if (obj === undefined || obj === null) return;
        this.statusCode = this.constructor.getValue(obj.statusCode);
        this.statusMessage = this.constructor.getValue(obj.statusMessage);
        this.statusDate = this.constructor.getValue(obj.statusDate);
        this.city = this.constructor.getValue(obj.city);
        this.state = this.constructor.getValue(obj.state);
    }

    /**
     * Function containing information about the fields of this model
     * @return   {array}   Array of objects containing information about the fields
     */
    static mappingInfo() {
        return super.mappingInfo().concat([
            { name: 'statusCode', realName: 'statusCode' },
            { name: 'statusMessage', realName: 'statusMessage' },
            { name: 'statusDate', realName: 'statusDate' },
            { name: 'city', realName: 'city' },
            { name: 'state', realName: 'state' },
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

module.exports = ParcelStatusItem1;
