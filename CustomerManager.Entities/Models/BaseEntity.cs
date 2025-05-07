using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager.Entities.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }

    }
}
