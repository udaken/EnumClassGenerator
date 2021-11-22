using System;
using Xunit;
using Microsoft.CodeAnalysis.CSharp.Testing;
using Microsoft.CodeAnalysis.CSharp.Testing.XUnit;

namespace tests
{
    [EnumClassGenerator.GenerateEnumClass("A", "B")]
    partial class EnumObject
    {

    }

    public class UnitTest1
    {
        [Fact]
        public void HashCodeTest()
        {
            Assert.Equal(EnumObject.A.Instance.GetHashCode(), EnumObject.A.Instance.GetHashCode());
            Assert.NotEqual(EnumObject.A.Instance.GetHashCode(), EnumObject.B.Instance.GetHashCode());
        }

        [Fact]
        public void EquitabilityTest()
        {
            Assert.True(EnumObject.A.Instance == EnumObject.A.Instance);
            Assert.NotEqual(EnumObject.A.Instance, EnumObject.B.Instance);
            Assert.True(EnumObject.A.Instance != EnumObject.B.Instance);
            Assert.False(EnumObject.A.Instance == EnumObject.B.Instance);
            Assert.False(EnumObject.A.Instance.Equals(null));
            Assert.False(EnumObject.A.Instance == null);
            Assert.False(null == EnumObject.A.Instance);
            Assert.True(null == (EnumObject?)null);
        }

        [Fact]
        public void ToStringTest()
        {
            EnumObject A = EnumObject.A.Instance;
            Assert.Equal("A", A.ToString());
            Assert.Equal("A", A.Name);
            Assert.Equal("B", EnumObject.B.Instance.ToString());
            Assert.Equal("B", EnumObject.B.Instance.Name);
        }

        [Fact]
        public void TryParseTest()
        {
            {
                Assert.True(EnumObject.TryParse("A", out var a));
                Assert.NotNull(a);
            }
            {
                Assert.False(EnumObject.TryParse("C", out var c));
                Assert.Null(c);
            }
        }

    }
}
