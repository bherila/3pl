/**
 * ProNimbusAPILib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

'use strict';

const BaseModel = require('./BaseModel');

/**
 * Creates an instance of AlternatePickupLocationsRequest
 */
class AlternatePickupLocationsRequest extends BaseModel {
    /**
     * @constructor
     * @param   {Object}  obj    The object passed to constructor
     */
    constructor(obj) {
        super(obj);
        if (obj === undefined || obj === null) return;
        this.clientCode = this.constructor.getValue(obj.clientCode);
        this.locationType = this.constructor.getValue(obj.locationType);
        this.radius = this.constructor.getValue(obj.radius);
        this.limit = this.constructor.getValue(obj.limit);
        this.location = this.constructor.getValue(obj.location);
    }

    /**
     * Function containing information about the fields of this model
     * @return   {array}   Array of objects containing information about the fields
     */
    static mappingInfo() {
        return super.mappingInfo().concat([
            { name: 'clientCode', realName: 'clientCode' },
            { name: 'locationType', realName: 'locationType' },
            { name: 'radius', realName: 'radius' },
            { name: 'limit', realName: 'limit' },
            { name: 'location', realName: 'location', type: 'Location' },
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

module.exports = AlternatePickupLocationsRequest;