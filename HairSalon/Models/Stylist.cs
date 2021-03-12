using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylist
    {
      public string Name { get; set; }
      public string Style { get; set; }
      public string Schedule { get; set; }
      public int StylistId { get; set; }
      public virtual ICollection<Client> Clients { get; set; }

      public Stylist()
      {
        this.Clients = new HashSet<Client>();
      }
    }
}