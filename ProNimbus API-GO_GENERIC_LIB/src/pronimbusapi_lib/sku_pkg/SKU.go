/*
 * pronimbusapi_lib
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */

package sku_pkg

import "pronimbusapi_lib/configuration_pkg"
import "pronimbusapi_lib/models_pkg"

/*
 * Interface for the SKU_IMPL
 */
type SKU interface {
    CreateProductDetailsWebService (*models_pkg.ProductDetailsRequest) (*models_pkg.ProductDetailsResponse, error)

    CreateProductCreateWebService (*models_pkg.ProductCreateRequest) (*models_pkg.ProductCreateResponse, error)

    UpdateProductUpdate (*models_pkg.ProductUpdateRequest) (*models_pkg.ProductUpdateResponseSuccess, error)
}

/*
 * Factory for the SKU interaface returning SKU_IMPL
 */
func NewSKU(config configuration_pkg.CONFIGURATION) *SKU_IMPL {
    client := new(SKU_IMPL)
    client.config = config
    return client
}