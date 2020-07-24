using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorTracker.Models;

namespace VendorTracker.tests
{
  [TestClass]
  public class OrderTest   // soon to add : IDisposable
  {

    // public void Dispose()
    // {
    //   Order.ClearAll();
    // }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  
  
  
  
  
  }

}