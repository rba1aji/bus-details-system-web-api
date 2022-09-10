using System.ComponentModel.DataAnnotations;

namespace BusDetailsSystem.Models;
public class BusDetail
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Origin { get; set; }
    [Required]
    public string? Destination { get; set; }
 
    [Required]
    public int Votes { get; set; }
    [Required]
    public string? BusOwner { get; set; }
    public string? BusNo { get; set; }
    public string? BusName { get; set; }
    public string? OriginTime { get; set; }
    public string? DestinationTime { get; set; }
    [Required]
    public string? AuthorName { get; set; }
    public string? PostDate { get; set; }

    public void doVote(int vote)
    {
        this.Votes += vote;
    }

    // public BusDetail(PostRequestDetail ob)
    // {
    //     this.Id=0;
    //     this.Origin=ob.Origin;
    //     this.Destination=ob.Destination;
    //     this.Votes=0;
    //     this.BusOwner=ob.BusOwner;
    //     this.BusNo=ob.BusNo;
    //     this.BusName=ob.BusName;
    //     this.OriginTime=ob.OriginTime;
    //     this.DestinationTime=ob.DestinationTime;
    //     this.AuthorName=ob.AuthorName;
    //     this.PostDate=DateTime.Now.ToString("MM/dd/yyyy");

    // }

    // [Required]
    // public string? ForiegnKey { get; set; }
    // public enum EBusOwner
    // {
    //     "Government",
    //     "Private"
    // }
}