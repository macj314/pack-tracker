// using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;

namespace PackerTracker.Tests
{
  [TestClass]
  public class SuppliesTests
  {
    [TestMethod]
    public void SuppliesConstructor_CreatesInstanceOfSupplies_Supplies()
    {
      string description = "this is something you eat";
      Supplies supply = new Supplies("food", description, 2, 100);

      string nameTest = "food";
      int priceTest = 2, idTest = 100;

      Assert.AreEqual(nameTest, supply.Name);
      Assert.AreEqual(description, supply.Description);
      Assert.AreEqual(priceTest, supply.Price);
      Assert.AreEqual(idTest, supply.ID);
    }
    [TestMethod]
    public void PackConstructor_HoldsInstanceOfSupplies_Pack()
    {
      string description = "this is something you eat";
      Supplies supply = new Supplies("food", description, 2, 100);

      string nameTest = "food";
      int priceTest = 2, idTest = 100;
    }
  }
}