﻿namespace AbstractCookie
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractChocolateCookie abstractChocolateCookieA = new ConcreteWhiteChocolateCookie();
            abstractChocolateCookieA.CreateCookieTemplate();

            AbstractChocolateCookie  abstractChocolateCookieB = new ConcreteDoubleChocolateCookie();
            abstractChocolateCookieB.CreateCookieTemplate();

            AbstractChocolateCookie abstractChocolateCookieC = new ConcreteMilkChocolateCookie();
            abstractChocolateCookieC.CreateCookieTemplate();

        }
    }
}
