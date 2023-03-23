public class OrderManager
{
    private List<Order> _orders = new List<Order>();


    public OrderManager()
    {

    }
    public void AddOrder(Order order)
    {
        _orders.Add(order);
    }

    public void DisplayOrders()
    {
        foreach (Order order in _orders)
        {
            order.CreatePackingLabel();
            order.CreateShippingLabel();
            order.GetTotalCost();
        }
    }
}