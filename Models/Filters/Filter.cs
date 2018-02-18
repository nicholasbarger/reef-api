using System;
namespace Reef.Models.Filters
{
    public class Filter
    {
        public string Search { get; set; }

        public Filter()
        {
        }

        public string[] GetSearchCriteria()
        {
            return this.Search.Split(' ');
        }
    }
}
