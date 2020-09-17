using System;

namespace Students.COMMON
{
    public class GuidGenerator
    {
        public string GetGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
