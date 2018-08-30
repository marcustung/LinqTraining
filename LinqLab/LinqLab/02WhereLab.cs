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
            var result = new List<Sample>();
            return result;
        }

        public List<Sample> 搜尋Price等於200的資料()
        {
            var result = new List<Sample>();
            return result;
        }

        public List<Sample> 搜尋UserName開頭為d的資料()
        {
            var result = new List<Sample>();
            return result;
        }

        public List<Sample> 搜尋UserName包含e的資料()
        {
            var result = new List<Sample>();
            return result;
        }

        public List<Sample> 搜尋UserName結尾為o的資料()
        {
            var result = new List<Sample>();
            return result;
        }

        public List<Sample> 搜尋UserName是demo和joey的資料()
        {
            var whereStr = new[] {"demo","joey" };
            var result = new List<Sample>();
            return result;
        }

        public bool 判斷是否有Id等於99的資料()
        {
            var result = true;
            return result;
        }
    }
}
