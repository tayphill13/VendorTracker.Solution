using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorTracker.Models;

namespace VendorTracker.tests
{
  [TestClass]
  public class OrderTest : IDisposable  // soon to add : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "Order expected Monday.";

      //Act
      Order newOrder = new Order(description);
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void SetDescription_WillSetDescription_String()
    {
      //Arrange
      string description = "Orders to be delivered soon.";
      Order newOrder = new Order(description);

      //Act
      string updatedDescription = "Orders delivered on time";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyOrdersList_OrderList()
    {
      List<Order> newList = new List<Order> {};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnAllOrders_OrderList()
    {
      string description01 = "50 bagels";
      string descritpion02 = "40 croissants";
      Order newOrder1 = new Order(description01);
      Order newOrder2 = new Order(descritpion02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2};

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndIdReturnedByGetter_Int()
    {
      string description = "40 croissants for Tuesday";
      Order newOrder = new Order(description);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsTheCorrectOrder_Order()
    {
      string description01 = "30 lbs of flour";
      string descritpion02 = "batch of cookies";
      Order newOrder1 = new Order(description01);
      Order newOrder2 = new Order(descritpion02);   //Making multiple order to test indexing, but only use 1
      
      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }
  
  }

}