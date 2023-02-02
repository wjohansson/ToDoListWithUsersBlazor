using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataLibrary.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Priority
    {
        Low,
        Medium,
        Important,
        Urgent
    }
}
