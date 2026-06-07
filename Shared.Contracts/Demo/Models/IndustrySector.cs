using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Contracts.Demo.Models
{
    public class IndustrySector
    {
        [Column("IS_Id")]
        public int IndustrySectorId { get; set; }

        [Column("Comp_Id")]
        public int CompanyId { get; set; }

        [Column("IS_Name")]
        public string Name { get; set; }

        [Column("IS_Code")]
        public string Code { get; set; }

        [Column("IS_IsActive")]
        public bool IsActive { get; set; } = true;

        [Column("IS_IsDeleted")]
        public bool IsDeleted { get; set; } = false;
    }
}
