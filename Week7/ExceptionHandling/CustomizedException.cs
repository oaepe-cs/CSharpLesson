using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionHandling
{
    public class CustomizedException 
    {

    }

    public class MyCustomizedException : Exception
    {
        public MyCustomizedException(string text)
            : base(text)
        {
        }
    }
}
