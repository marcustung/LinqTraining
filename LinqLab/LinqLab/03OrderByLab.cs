using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class OrderByLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public OrderByLab()
        {
            Source = new SampleDate().GetData();
        }

        public List<Sample> 請使用Id升冪排序()
        {
            var result = Source.OrderBy(d => d.Id).ToList();
            return result;
        }

        public List<Sample> 請使用Id降冪排序()
        {
            var result = Source.OrderByDescending(d => d.Id).ToList();
            return result;
        }

        public List<Sample> 請使用Price昇冪排序後再使用Id昇冪排序Test()
        {
            var result = Source.OrderBy(d => d.Price).ThenBy(d=>d.Id).ToList();
            return result;
        }
    }
}
