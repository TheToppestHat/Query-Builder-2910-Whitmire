using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Query.QueryBuilderStarterKit
{
    internal class BannedGame : IClassModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Series { get; set; }
        public string Country { get; set; }
        public string Details { get; set; }

        public BannedGame() { }

        public BannedGame(int id, string title,string series, string country, string details)
        {
            Id = id;
            Title = title;
            Series = series;
            Country = country;
            Details = details;
        }

        public override string ToString()
        {
            var msg = $"Number {Id} is {Title}, which was banned in {Country} for the following reason: \n{Details}\n\n\n";
            return msg;
        }
    }
}

