using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Buddy.UI.Core.Tests
{
    [TestClass]
    public class RequiresTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Requires_NotNull_ThrowsWithNullValue()
        {
            object val = null;
            Requires.NotNull(val, nameof(val));
        }

        [TestMethod]
        
        public void Requires_NotNull_PassesWithActualValue()
        {
            object o = new object();
            Requires.NotNull(o, nameof(o));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Requires_NotNullOrEmpty_ThrowsOnEmptyString()
        {
            string s = string.Empty;
            Requires.NotNullOrEmpty(s, nameof(s));
        }

        [TestMethod]
        public void Requires_NotNullOrEmpty_PassesWithValidString()
        {
            string s = "s";
            Requires.NotNullOrEmpty(s, nameof(s));
        }
    }
}
