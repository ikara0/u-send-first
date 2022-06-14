using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using U_Send_First.Common;
using U_Send_First.Entities.Profile;

namespace U_Send_First.Entities.Media;
[Table("Messages",Schema ="Media")]
public class Message :EntityBase
{
    [Required]
    public Guid UserId { get; set; }
    [Required]
    [MaxLength(1024)]
    public string Content { get; set; }
    [MaxLength(256)]
    public string Subject { get; set; }
    public bool IsRead { get; set; }
    [ForeignKey(nameof(UserId))]
    public User User { get; set; }
}