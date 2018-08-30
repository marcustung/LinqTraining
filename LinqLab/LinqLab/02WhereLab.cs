using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public class WhereLab
    {
        private static IEnumerable<Sample> Source { get; set; }
        public WhereLab()
        {
            Source = new SampleDate().GetData();
        }
        public List<Sample> 搜尋Id大於8的資料()
        {
            var result = Source.Where(d => d.Id > 8).ToList();
            return result;
        }

        public List<Sample> 搜尋Price等於200的資料()
        {
            var result = Source.Where(d => d.Price == 200).ToList();
            return result;
        }

        public List<Sample> 搜尋UserName開頭為d的資料()
        {
            var result = Source.Where(d => d.UserName.StartsWith("d")).ToList();
            return result;
        }

        public List<Sample> 搜尋UserName包含e的資料()
        {
            var result = Source.Where(d => d.UserName.Contains("e")).ToList();
            return result;
        }

        public List<Sample> 搜尋UserName結尾為o的資料()
        {
            var result = Source.Where(d => d.UserName.EndsWith("o")).ToList();
            return result;
        }

        public List<Sample> 搜尋UserName是demo和joey的資料()
        {
            var whereStr = new[] {"demo","joey" };
            var result = Source.Where(d =>whereStr.Contains( d.UserName)).ToList();
            return result;
        }

        public bool 判斷是否有Id等於99的資料()
        {
            var result = Source.Where(d =>d.Id==99).Any();
            //var result = Source.FirstOrDefault(d => d.Id == 99)!=null;
            //var result = Source.Where(d => d.Id == 99).Count()>0;
            return result;
        }
    }
}
