/**
 * ProNimbusAPILib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

'use strict';

const BaseModel = require('./BaseModel');

/**
 * Creates an instance of BolInboundRequestPosition
 */
class BolInboundRequestPosition extends BaseModel {
    /**
     * @constructor
     * @param   {Object}  obj    The object passed to constructor
     */
    constructor(obj) {
        super(obj);
        if (obj === undefined || obj === null) return;
        this.referenceId = this.constructor.getValue(obj.referenceId || obj.reference_id);
        this.sku = this.constructor.getValue(obj.sku);
        this.boxId = this.constructor.getValue(obj.boxId || obj.box_id);
        this.amountOfBoxes = this.constructor.getValue(obj.amountOfBoxes || obj.amount_of_boxes, 3);
        this.amountOfBottles =
          this.constructor.getValue(obj.amountOfBottles
     || obj.amount_of_bottles, 36);
    }

    /**
     * Function containing information about the fields of this model
     * @return   {array}   Array of objects containing information about the fields
     */
    static mappingInfo() {
        return super.mappingInfo().concat([
            { name: 'referenceId', realName: 'reference_id' },
            { name: 'sku', realName: 'sku' },
            { name: 'boxId', realName: 'box_id' },
            { name: 'amountOfBoxes', realName: 'amount_of_boxes' },
            { name: 'amountOfBottles', realName: 'amount_of_bottles' },
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

module.exports = BolInboundRequestPosition;
