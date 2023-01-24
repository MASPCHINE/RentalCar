using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResultz<T>:DataResult<T>
    {
        public ErrorDataResultz(T data, string message) : base(data, false, message)
        {

        }
        public ErrorDataResultz(T data) : base(data, false)
        {

        }
        public ErrorDataResultz(string message) : base(default, false, message)
        {

        }
        public ErrorDataResultz() : base(default, false)
        {

        }
    }
}
