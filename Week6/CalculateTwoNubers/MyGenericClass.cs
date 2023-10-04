using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateTwoNubers
{
    public class MyGenericClass<T>
    {
        private T _myValue;

        public MyGenericClass(T userInputValue)
        {
            this._myValue = userInputValue;
        }

        public T GetValue()
        {
            return _myValue;
        }
    }
}
