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
            Assert.Null(tree.Root);
        }
        [Fact]
        public void Can_add_to_root()
        {
            // Arrange
            Tree<int> tree = new Tree<int>();
            // Act
            tree.AddValue(1);
            // Assert
            Assert.NotNull(tree.Root);
            Assert.Equal(1, tree.Root.Value);
        }
        [Fact]
        public void Can_instanciate_with_root()
        {
            // Arrange
            // Act
            // Assert
        }
        [Fact]
        public void Can_add_to_existing_node()
        {
            // Arrange
            // Act
            // Assert
        }
        [Fact]
        public void Count_returns_the_amount_of_nodes()
        {
            // Arrange
            // Act
            // Assert
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
