using System;
using System.Collections.Generic;
using System.Text;
using AbstractCookie;
using FluentAssertions;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TestingPatterns
{
    [TestFixture]
    public class ChocolateCookieTemplateShouldcs
    {
        
        [TestCase("Milk Chocolate Chips Plain Cookie Base baked for 15 minutes")]
        public void ReturnCorrectCookieType_WhenCorrespondingAbstractClassIsCalled(string expected)
        {

            AbstractChocolateCookie concreteAbstractChocolateCookie = new ConcreteMilkChocolateCookie();

            concreteAbstractChocolateCookie.CreateCookieTemplate();

            var result = concreteAbstractChocolateCookie.CreatedCookie;

            result.ShouldBeEquivalentTo(expected);

        }

    }
}
