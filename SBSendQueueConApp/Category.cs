﻿namespace SBSendQueueConApp
{
  public class Category
  {
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
    public string Description { get; set; }
    public override string ToString()
    {
      return $"CatID: {CategoryID}, CatName: {CategoryName} and Description: {Description}";
    }
  }
}
