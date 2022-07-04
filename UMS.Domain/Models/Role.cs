using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PCP.Persistence.Models;


namespace PCP.Persistence.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public Role(long id, string name)
        {
            Id = id;
            Name = name;
        }
        [Required]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }
    }
}
