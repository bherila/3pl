/**
 * ProNimbusAPILib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

'use strict';

const BaseModel = require('./BaseModel');

/**
 * Creates an instance of BolInboundCreateSuccessResponse
 */
class BolInboundCreateSuccessResponse extends BaseModel {
    /**
     * @constructor
     * @param   {Object}  obj    The object passed to constructor
     */
    constructor(obj) {
        super(obj);
        if (obj === undefined || obj === null) return;
        this.statusCode = this.constructor.getValue(obj.statusCode);
        this.statusMessage = this.constructor.getValue(obj.statusMessage);
        this.result = this.constructor.getValue(obj.result);
    }

    /**
     * Function containing information about the fields of this model
     * @return   {array}   Array of objects containing information about the fields
     */
    static mappingInfo() {
        return super.mappingInfo().concat([
            { name: 'statusCode', realName: 'statusCode' },
            { name: 'statusMessage', realName: 'statusMessage' },
            { name: 'result', realName: 'result', type: 'Result2' },
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

module.exports = BolInboundCreateSuccessResponse;
