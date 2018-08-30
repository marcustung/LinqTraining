using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
   public class FirstAndSingleLab
    {
        private static IEnumerable<Sample> Source { get; set; }

        public FirstAndSingleLab()
        {
            Source = new SampleDate().GetData();
        }

        public Sample 搜尋UserName等於demo的資料使用First()
        {
            var result = Source.Where(d => d.UserName == "demo").First();
            return result;
        }

        public Sample 搜尋UserName等於skilltree的資料使用FirstOrDefault()
        {
            var result = Source.Where(d => d.UserName == "skilltree").FirstOrDefault();
            return result;
        }

        public Sample 搜尋UserName等於skilltree的資料使用First()
        {
            var result = Source.Where(d => d.UserName == "skilltree").First();
            return result;
        }

        public Sample 搜尋UserName等於demo的資料使用Single()
        {
            var result = Source.Where(d => d.UserName == "demo").Single();
            return result;
        }

        public Sample 搜尋UserName等於bill的資料使用Single()
        {
            var result = Source.Where(d => d.UserName == "bill").Single();
            return result;
        }
        public Sample 搜尋UserName等於bill的資料使用SingleOrDefault()
        {
            var result = Source.Where(d => d.UserName == "bill").SingleOrDefault();
            return result;
        }

        public Sample 搜尋UserName等於skilltree的資料使用SingleOrDefault()
        {
            var result = Source.Where(d => d.UserName == "skilltree").SingleOrDefault();
            return result;
        }
    }
}
