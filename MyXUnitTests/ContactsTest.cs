using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Collections;

namespace MyXUnitTests
{
    public class ContactsTest
    {
        [Fact]
        public static void OptimizeContactsTest()
        {
            // Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
            List<string> contacts=new List<string>{"a:a@amil.ru","a122:a@1.ru", "a123:a123:a@2.ru" };
            Dictionary<string, List<string>> vActual = Contacts.OptimizeContacts(contacts);
            Dictionary<string, List<string>> vExpected = new Dictionary<string, List<string>>
            {
                {"a",new List<string>{"a:a@amil.ru"}},
                {"a1",new List<string>{ "a122:a@1.ru", "a123:a123:a@2.ru"}},
            };
            Assert.Equal(vExpected, vActual);
        }
    }
}
