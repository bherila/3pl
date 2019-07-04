/**
 * ProNimbusAPILib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

'use strict';

const APIException = require('./APIException');

/**
 * Creates an instance of AlternatePickupLocationsErrorResponseException
 */
class AlternatePickupLocationsErrorResponseException extends APIException {
    /**
     * @constructor
     */
    constructor() {
        super();
        /**
         * a non-zero number
         */
        this.code = null;

        /**
         * a string indicating where the errors were identified
         */
        this.statusMessage = null;

        /**
         * An object describing the fields in the request that are in error. May contain multiple
         * levels if the fields in error are part of a field that is an object. If there is no error
         * this object is empty.
         */
        this.errors = null;
    }

    /**
     * Function containing information about the fields of this model
     * @return   {array}   Array of objects containing information about the fields
     */
    static mappingInfo() {
        return super.mappingInfo().concat([
            { name: 'code', realName: 'code' },
            { name: 'statusMessage', realName: 'statusMessage' },
            { name: 'errors', realName: 'errors' },
        ]);
    }
}

module.exports = AlternatePickupLocationsErrorResponseException;
