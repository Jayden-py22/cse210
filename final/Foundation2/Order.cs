using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal CalculateTotalCost()
        {
            decimal total = 0;
            foreach (var product in _products)
            {
                total += product.GetTotalCost();
            }
            // Add shipping cost: $5 for USA, $35 for others.
            total += _customer.IsInUSA() ? 5 : 35;
            return total;
        }

        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";
            foreach (var product in _products)
            {
                label += $"- {product.GetProductInfo()}\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            string label = "Shipping Label:\n";
            label += $"Customer: {_customer.GetName()}\n";
            label += _customer.GetAddress().GetFullAddress();
            return label;
        }
    }
}