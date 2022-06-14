using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using U_Send_First.Common;
using U_Send_First.Entities.Media;

namespace U_Send_First.Entities.Profile;
[Table("Users",Schema ="Profile")]
public class User : EntityBase
{
    [Required]
    [MaxLength(24)]
    public string UserName { get; set; }
    [Required]
    [MaxLength(64)]
    public string EMail { get; set; }
    [MaxLength(128)]
    public string Password { get; set; }
    public string Hash { get; set; }
}