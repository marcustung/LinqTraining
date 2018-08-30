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
            var result = new Sample();
            return result;
        }

        public Sample 搜尋UserName等於skilltree的資料使用FirstOrDefault()
        {
            var result = new Sample();
            return result;
        }

        public Sample 搜尋UserName等於skilltree的資料使用First()
        {
            var result = new Sample();
            return result;
        }

        public Sample 搜尋UserName等於demo的資料使用Single()
        {
            var result = new Sample();
            return result;
        }

        public Sample 搜尋UserName等於bill的資料使用Single()
        {
            var result = new Sample();
            return result;
        }
        public Sample 搜尋UserName等於bill的資料使用SingleOrDefault()
        {
            var result = new Sample();
            return result;
        }

        public Sample 搜尋UserName等於skilltree的資料使用SingleOrDefault()
        {
            var result = new Sample();
            return result;
        }
    }
}
