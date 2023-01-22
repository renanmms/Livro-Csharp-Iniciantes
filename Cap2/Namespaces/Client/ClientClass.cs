using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Namespaces.Client
{
    public class ClientClass
    {
        SampleClass sample;
        public ClientClass()
        {
            sample = new SampleClass();
            sample.SampleMethod();
        }
    }
}