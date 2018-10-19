using Remote.Domain.Entities;
using Remote.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remote.Application.Adapters
{
    public class Class1Adapter : MarshalByRefObject, IClass1Adapter
    {
        #region IClass1Adapter Methods

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public Class2 Sum2(int a, int b)
        {
            return new Class2()
            {
                Id = Guid.NewGuid().ToString(),
                Result = Sum(a, b)
            };
        }

        public Class2 Sum3(Class2 o, int a)
        {
            o.Result += a;

            return o;
        }

        public Class2 CreateClass2()
        {
            return new Class2()
            {
                Id = Guid.NewGuid().ToString()
            };
        }

        #endregion IClass1Adapter Methods
    }
}
