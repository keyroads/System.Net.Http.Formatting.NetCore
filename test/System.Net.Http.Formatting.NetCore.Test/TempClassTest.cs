using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Formatting.NetCore;
using Xunit;

namespace System.Net.Http.Formatting.NetCore.Test
{
    public class TempClassTest
    {
        [Fact]
        public void TempClass_AssertFail_Should_Fail()
        {
            var o = new TempClass();
            o.AssertFail();
        }
    }
}
