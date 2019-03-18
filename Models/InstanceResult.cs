using System.Collections.Generic;
using Comp4920_SAS.Common;

namespace Comp4920_SAS.Models
{
    public class InstanceResult<T>
    {
        public Result<List<T>> resultList { get; set; }
        public Result<int> resultint { get; set; }
        public Result<T> TResult { get; set; }
    }
}