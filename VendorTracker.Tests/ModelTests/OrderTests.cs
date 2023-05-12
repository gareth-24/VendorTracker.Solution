using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test order", "test description", "May 12", 10);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "test order";
      //Act
      Order newOrder = new Order(title, "test description", "May 12", 10);
      string result = newOrder.Title;
      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetsTitle_String()
    {
      string title = "test order 1";
      Order newOrder = new Order(title, "test description", "May 12", 10);

      string updatedTitle = "test order 2";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "test description";

      Order newOrder = new Order("test order", description, "May 12", 10);
      string result = newOrder.Description;

      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetsDescription_String()
    {
      string description = "test description";
      Order newOrder = new Order("title", description, "May 12", 10);

      string updatedDescription = "test description 2";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string date = "test date";

      Order newOrder = new Order("title", "description", date, 10);
      string result = newOrder.Date;

      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetDate_SetsDate_String()
    {
      string date = "test date";
      Order newOrder = new Order("title", "description", date, 10);

      string updatedDate = "test date 2";
      newOrder.Date = updatedDate;
      string result = newOrder.Date;

      Assert.AreEqual(updatedDate, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      int price = 10;

      Order newOrder = new Order("title", "description", "date", price);
      int result = newOrder.Price;

      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void SetPrice_SetsPrice_Int()
    {
      int price = 10;
      Order newOrder = new Order("title", "description", "date", price);

      int updatedPrice = 50;
      newOrder.Price = updatedPrice;
      int result = newOrder.Price;

      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newOrder = new List<Order> { };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newOrder, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      Order newOrder1 = new Order("title1", "description1", "date1", 10);
      Order newOrder2 = new Order("title2", "description2", "date2", 50);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}