/*
 * pronimbusapi_lib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

package ProNimbusAPIClient

import(
	"pronimbusapi_lib/configuration_pkg"
	"pronimbusapi_lib/sku_pkg"
	"pronimbusapi_lib/notifications_pkg"
	"pronimbusapi_lib/inventory_pkg"
	"pronimbusapi_lib/salesorder_pkg"
)
/*
 * Client structure as interface implementation
 */
type PRONIMBUSAPI_IMPL struct {
     sku sku_pkg.SKU
     notifications notifications_pkg.NOTIFICATIONS
     inventory inventory_pkg.INVENTORY
     salesorder salesorder_pkg.SALESORDER
     config  configuration_pkg.CONFIGURATION
}

/**
     * Access to Configuration
     * @return Returns the Configuration instance
*/
func (me *PRONIMBUSAPI_IMPL) Configuration() configuration_pkg.CONFIGURATION {
    return me.config
}
/**
     * Access to SKU controller
     * @return Returns the SKU() instance
*/
func (me *PRONIMBUSAPI_IMPL) SKU() sku_pkg.SKU {
    if(me.sku) == nil {
        me.sku = sku_pkg.NewSKU(me.config)
    }
    return me.sku
}
/**
     * Access to Notifications controller
     * @return Returns the Notifications() instance
*/
func (me *PRONIMBUSAPI_IMPL) Notifications() notifications_pkg.NOTIFICATIONS {
    if(me.notifications) == nil {
        me.notifications = notifications_pkg.NewNOTIFICATIONS(me.config)
    }
    return me.notifications
}
/**
     * Access to Inventory controller
     * @return Returns the Inventory() instance
*/
func (me *PRONIMBUSAPI_IMPL) Inventory() inventory_pkg.INVENTORY {
    if(me.inventory) == nil {
        me.inventory = inventory_pkg.NewINVENTORY(me.config)
    }
    return me.inventory
}
/**
     * Access to SalesOrder controller
     * @return Returns the SalesOrder() instance
*/
func (me *PRONIMBUSAPI_IMPL) SalesOrder() salesorder_pkg.SALESORDER {
    if(me.salesorder) == nil {
        me.salesorder = salesorder_pkg.NewSALESORDER(me.config)
    }
    return me.salesorder
}

