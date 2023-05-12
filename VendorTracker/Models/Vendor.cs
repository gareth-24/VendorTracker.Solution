using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }
    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    //clears the list of vendors
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    //returns a list of venders
    {
      return _instances;
    }

    public static Vendor Find(int searchId)
    //finds a specific vendor from the static list by its id
    {
      return _instances[searchId-1];
    }

    public void AddOrder(Order order)
    //adds an order to the vendor object
    {
      Orders.Add(order);
    }
  }

}