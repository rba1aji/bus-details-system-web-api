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
    // public DateTime PostDate { get; set; }

    public void doVote(int vote)
    {
        this.Votes += vote;
    }

    // public BusDetail(string origin, string destination, string busOwner, string )
    // {
        
    // }

    // [Required]
    // public string? ForiegnKey { get; set; }
    // public enum EBusOwner
    // {
    //     "Government",
    //     "Private"
    // }
}