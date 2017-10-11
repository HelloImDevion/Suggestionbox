using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace week9suggestionbox.Models
{
    public class Suggestionmodel
    {
        private string name;
        private string topic;
        private string suggestion;

        [Key]
        public int RecordNum { get; set; }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Topic
        {
            get { return this.topic; }
            set { this.topic = value; }
        }

        public string Suggestion
        {
            get { return this.suggestion; }
            set { this.suggestion = value; }
        }

    }
}