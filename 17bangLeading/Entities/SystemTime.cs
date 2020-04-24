using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPage.Entities
{
    public class SystemTime
    {
        static private DateTime? _now;
        static public DateTime Now()
        {
            if (!_now.HasValue)
            {
                return DateTime.Now;
            }
            else
            {
                return _now.Value;
            }
        }



        public SystemTime(DateTime now)
        {
            _now = now;
        }
    }
}
