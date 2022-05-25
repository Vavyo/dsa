using DataStructures.Trees;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DataStructures.tests.Trees
{
    public class TreeTests
    {
        [Fact]
        public void Can_instanciate()
        {
            // Arrange/Act
            Tree<int> tree = new Tree<int>();
            // Assert
            Assert.NotNull(tree);
        }
        [Fact]
        public void PreOrder_works()
        {
            // Arrange
            Tree<int> tree = new Tree<int>();
            tree.Root = new Node<int>(5);
            tree.Left = new Node<int>(7);
            tree.Right = new Node<int>(12);
            // Act
            var result = tree.PreOrder();
            // Assert
            Assert.Equal(new[] { 5, 7, 12 }, result);
        }
    }
}
