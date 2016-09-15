(function($j) {

    var productSelector = {
        
        settings: {
            queryPaths: {
                product: '.js-product',
                basketItems: '.js-basket-items'
            }
        },

        init: function() {
            var self = this;
            self._initBasket();
        },

        _initBasket: function() {
            var self = this;
            $j(document).on('change', self.settings.queryPaths.product, function() {
                var selectedProducts = $j(self.settings.queryPaths.product + ':checked');
                $j(self.settings.queryPaths.basketItems).empty();
                if (selectedProducts.length === 0) {
                    $j(self.settings.queryPaths.basketItems).html('<li>Your basket is empty</li>');
                } else {
                    $j.each(selectedProducts, function (i, item) {
                        $j(self.settings.queryPaths.basketItems).append('<li>' + $j(item).val() + '</li>');
                    });
                }
            });
        }

    }

    $j(document).ready(function() {
        productSelector.init();
    });

})(jQuery);