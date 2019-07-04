/**
 * ProNimbusAPILib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

'use strict';

const APIException = require('./APIException');

/**
 * Creates an instance of Error1Exception
 */
class Error1Exception extends APIException {
    /**
     * @constructor
     */
    constructor() {
        super();
        /**
         * TODO: Write general description for this field
         */
        this.code = null;

        /**
         * TODO: Write general description for this field
         */
        this.message = null;

        /**
         * TODO: Write general description for this field
         */
        this.fields = null;
    }

    /**
     * Function containing information about the fields of this model
     * @return   {array}   Array of objects containing information about the fields
     */
    static mappingInfo() {
        return super.mappingInfo().concat([
            { name: 'code', realName: 'code' },
            { name: 'message', realName: 'message' },
            { name: 'fields', realName: 'fields' },
        ]);
    }
}

module.exports = Error1Exception;