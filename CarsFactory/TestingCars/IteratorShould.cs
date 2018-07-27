using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TestingPatterns
{
    [TestFixture]
    public class IteratorShould
    {

        public void MenuIteratorShouldReturnCorrectMenuLengthsWhenCalledWithDinerAndBarItems()
        {

            var expected = new ArrayList();

            ArrayList dinerArray = new ArrayList();
            dinerArray.Add("pizza");
            dinerArray.Add("pasta");

            string[] barArray = new string[3];
            barArray[0] = "martini";
            barArray[1] = "fireball";
            barArray[2] = "jaeger bomb";

            DinerIterator dinerIterator = new DinerIterator(dinerArray);

            dinerIterator.



        }


    }

    public class DinerIterator : Iterator 
    {
        private ArrayList DinerMenu { get; set; }

        public DinerIterator(ArrayList dinerMenu)
        {
            DinerMenu = dinerMenu;
        }

        public object Next()
        {
            DinerMenu
        }

        public bool HasNext()
        {
            throw new NotImplementedException();
        }
    }

    public interface Iterator
    {
        object Next();
        bool HasNext();
    }
}
