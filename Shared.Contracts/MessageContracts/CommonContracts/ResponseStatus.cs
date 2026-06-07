using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Contracts.MessageContracts.CommonContracts
{
    public class ResponseStatus
    {
        [Column("ID")]
        public int Id { get; set; } 
        public bool IsSuccess { get; set; } = true;

        [Column("IsError")]
        public bool IsError { get; set; } = false;

        [Column("IsValidation")]
        public bool IsValidation { get; set; } = false;

        [Column("Comment")]
        public string Comment { get; set; } = string.Empty;
        public List<ErrorOrValidationMessage> lstErrorsOrValidations { get; set; } = new List<ErrorOrValidationMessage>();
        public string AuthToken { get; set; } = string.Empty;
        public string SessionID { get; set; } = string.Empty;
    }
}
