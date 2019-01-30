using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspnet.Additions.Models.Errors
{
    public class FieldValidationError
    {
        [JsonProperty(NullValueHandling=NullValueHandling.Ignore)]
        public string Field { get; set; }
        public string[] Errors { get; set; }

        public FieldValidationError(IEnumerable<string> errors, string field = null)
        {
            this.Field = field;
            this.Errors = errors.ToArray();
        }
    }
}
