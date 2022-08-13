using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DSABeginner.UnitTests
{
    public class Find2MaxTest
    {
        [Theory]
        [InlineData(new int[] { 1, 21, 31, 45, 12, 2, 87, 32 }, new int[] { 87, 45 })]
        public void SuccessFlow(int[] input, int[] result)
        {
            Assert.Equal(result, Find2Max.Calculate(input));
        }
    }
}
