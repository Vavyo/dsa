using DataStructures.LinkedLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataStructures.tests.LinkedLists
{
    
    public class LinkedListTests
    {
        [Fact]
        public void Empty_list_has_null_Head()
        {
            // arrange / act
            LinkedList list = new LinkedList();

            // assert
            Assert.Null(list.Head);
        }
    }
}
