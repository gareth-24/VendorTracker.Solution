using System;
using System.Collections;
using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public int Price { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };
    public Order(string title, string description, string date, int price)
    {
      Title = title;
      Description = description;
      Date = date;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    //returns list of orders
    {
      return _instances;
    }

    public static void ClearAll()
    //clears the list of orders
    {
      _instances.Clear();
    }

    public static Order Find(int searchId)
    //finds a specific order from the static list by its id
    {
      return _instances[searchId-1];
    }
  }
}