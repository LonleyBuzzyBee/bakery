namespace BakeryContents.Models
{
  public class Pastry
  {

    public string PastryType { get; set; }
    public int PastryCost { get; set; }

    public int PastryAmount { get; set; }
    public Pastry(string pastrytype, int pastrycost, int pastryamount)
    {

      PastryType = pastrytype;
      PastryCost = pastrycost;
      PastryAmount = pastryamount;

    }
     public int CostBeforeDeal()
      {
        int pastrycost = PastryCost;
        int pastryamount = PastryAmount;
        return pastrycost*pastryamount;
      }
    public int DealApplied()
    {
      int pastrycost = PastryCost;
      int pastryamount = PastryAmount;

    
        return (pastrycost * pastryamount) / 2;
    }
  }
}