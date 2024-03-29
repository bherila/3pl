/**
 * ProNimbusAPILib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

'use strict';

const APIException = require('./APIException');
/**
 * Creates an instance of ParcelCheckWeightBadResponseException
 */
class ParcelCheckWeightBadResponseException extends APIException {
    /**
     * @constructor
     */
    constructor() {
        super();
        /**
         * The status of the call.
         * * `failure` - The parcel weight is NOT withing acceptable tolerance, or there was an error
         * with one of the input fields.
         */
        this.status = null;

        /**
         * TODO: Write general description for this field
         */
        this.results = null;

        /**
         * An array of objects describing what input parameters caused errors.
         */
        this.errors = null;
    }

    /**
     * Function containing information about the fields of this model
     * @return   {array}   Array of objects containing information about the fields
     */
    static mappingInfo() {
        return super.mappingInfo().concat([
            { name: 'status', realName: 'status' },
            { name: 'results', realName: 'results', type: 'Results4' },
            { name: 'errors', realName: 'errors', array: true, type: 'GenericError' },
        ]);
    }
}

module.exports = ParcelCheckWeightBadResponseException;
