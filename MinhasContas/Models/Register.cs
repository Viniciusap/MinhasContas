using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhasContas.Models
{
    public class Register
    {
        public Register(string description, string title, double value, DateTime creationData, DateTime dueData, DateTime payData)
        {
            Description = description;
            Title = title;
            Value = value;
            CreationData = creationData;
            DueData = dueData;
            PayData = payData;
        }

        public int ID { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public double Value { get; set; }
        public DateTime CreationData { get; set; }
        public DateTime DueData { get; set; }
        public DateTime PayData { get; set; }        

    }
}
