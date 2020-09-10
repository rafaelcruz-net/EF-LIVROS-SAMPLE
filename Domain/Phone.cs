using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Domain
{
    public class Phone
    {
        public int Id { get; set; }

        public String Number { get; set; }

        public PhoneType Type { get; set; }

        [JsonIgnore]
        public virtual Author Author { get; set; }

    }

    public enum PhoneType
    {
        COMERCIAL = 1,
        RESIDENCIAL = 2,
        OUTROS = 3

    }
}
