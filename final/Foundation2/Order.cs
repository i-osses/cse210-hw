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

  public string GetPackingLabel()
  {
    string label = "Packing Label:\n";
    foreach (Product product in _products)
    {
      label += $"{product.Name} (ID: {product.ProductId})\n";
    }
    return label;
  }

  public string GetShippingLabel()
  {
    return $"Shipping Label:\n{_customer.Name}\n{_customer.Address.GetFullAddress()}";
  }

  public double GetTotalPrice()
  {
    double total = 0;
    foreach (Product product in _products)
    {
      total += product.GetTotalCost();
    }
    total += _customer.LivesInUSA() ? 5 : 35;
    return total;
  }
}