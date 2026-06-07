using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Contracts.MessageContracts.CommonContracts
{
    public class ErrorOrValidationMessage
    {
        [Column("ValidationMessage")]
        public string? ErrorMessage { get; set; }

        [Column("RowId")]
        public string Value { get; set; } = string.Empty;
    }
}
