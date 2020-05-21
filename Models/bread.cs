
namespace BakeryContents.Models
{
  public class Bread
  {
    public string BreadType { get; set; }
    public int BreadCost { get; set; }
    public int BreadAmount { get; set; }

    public Bread(string breadtype, int breadcost, int breadamount)
    {

      BreadType = breadtype;
      BreadCost = breadcost;
      BreadAmount = breadamount;

    }

      public int CostBeforeDeal()
      {
        int breadCost = BreadCost;
        int breadamount = BreadAmount;
        return breadCost*breadamount;
      }
      public int DealApplied()
    {
      int breadCost = BreadCost;
      int breadamount = BreadAmount;

      if(breadamount >= 2 )
      {
      return ((breadCost*breadamount) / 2)  + breadCost;

      }
      else
      {
        return breadCost*breadamount;
      }
    }

  }
}
