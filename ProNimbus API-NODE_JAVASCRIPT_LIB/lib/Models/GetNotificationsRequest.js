/**
 * ProNimbusAPILib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

'use strict';

const BaseModel = require('./BaseModel');

/**
 * Creates an instance of GetNotificationsRequest
 */
class GetNotificationsRequest extends BaseModel {
    /**
     * @constructor
     * @param   {Object}  obj    The object passed to constructor
     */
    constructor(obj) {
        super(obj);
        if (obj === undefined || obj === null) return;
        this.clientCode = this.constructor.getValue(obj.clientCode);
        this.requestType = this.constructor.getValue(obj.requestType);
        this.startTime = this.constructor.getValue(obj.startTime);
        this.endTime = this.constructor.getValue(obj.endTime);
    }

    /**
     * Function containing information about the fields of this model
     * @return   {array}   Array of objects containing information about the fields
     */
    static mappingInfo() {
        return super.mappingInfo().concat([
            { name: 'clientCode', realName: 'clientCode' },
            { name: 'requestType', realName: 'requestType' },
            {
                name: 'startTime',
                realName: 'startTime',
                isDateTime: true,
                dateTimeValue: 'rfc3339',
            },
            { name: 'endTime', realName: 'endTime', isDateTime: true, dateTimeValue: 'rfc3339' },
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

module.exports = GetNotificationsRequest;
