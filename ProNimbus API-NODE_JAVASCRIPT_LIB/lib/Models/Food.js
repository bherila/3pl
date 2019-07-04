/**
 * ProNimbusAPILib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

'use strict';

const ProductCreateRequest = require('./ProductCreateRequest');

/**
 * Creates an instance of Food
 */
class Food extends ProductCreateRequest {
    /**
     * @constructor
     * @param   {Object}  obj    The object passed to constructor
     */
    constructor(obj) {
        super(obj);
        if (obj === undefined || obj === null) return;
        this.foodType = this.constructor.getValue(obj.foodType);
        this.foodOrigin = this.constructor.getValue(obj.foodOrigin);
        this.foodRefrigeration = this.constructor.getValue(obj.foodRefrigeration, 'N');
        this.foodPerishable = this.constructor.getValue(obj.foodPerishable, 'N');
    }

    /**
     * Function containing information about the fields of this model
     * @return   {array}   Array of objects containing information about the fields
     */
    static mappingInfo() {
        return super.mappingInfo().concat([
            { name: 'foodType', realName: 'foodType' },
            { name: 'foodOrigin', realName: 'foodOrigin' },
            { name: 'foodRefrigeration', realName: 'foodRefrigeration' },
            { name: 'foodPerishable', realName: 'foodPerishable' },
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
            Food: 'Food',
        };
    }
}

module.exports = Food;
