using System;
using Xunit;
using ClosestToZeroService;

namespace ClosestToZeroService.Test
{
    public class UnitTest1
    {

        [Fact]
        public void TestShouldThrowExceptionForNoValue() {
            ClosestToZero closestToZero = new ClosestToZero();
            Assert.Throws<ArgumentException>(() => closestToZero.GetClosest(null));
        }

        [Fact]
        public void TestShouldThrowExceptionforAnEmptyArray() {
            ClosestToZero closestToZero = new ClosestToZero();
            Assert.Throws<ArgumentException>(() => closestToZero.GetClosest(new int[0]));
        }

        [Fact]
        public void FunctionGetClosestGivenArrayWithOneElementReturnsOneElement(){
            ClosestToZero closestToZero = new ClosestToZero();
            Assert.Equal(3, closestToZero.GetClosest(new int[1] {3}));
        }

        [Fact]
        public void FunctionGetClosestGivenArrayWithTwoPositiveElementsReturnsClosetToZero(){
            ClosestToZero closestToZero = new ClosestToZero();
            Assert.Equal(4, closestToZero.GetClosest(new int[2] {4, 5}));
        }

        [Fact]
        public void FunctionGetClosestGivenArrayWithThreePositiveElementsReturnsClosestToZero(){
            ClosestToZero closestToZero = new ClosestToZero();
            Assert.Equal(3, closestToZero.GetClosest(new int[3] {4, 3, 5}));
        }

        [Fact]
        public void FunctionGetClosestGivenArrayWithThreePositiveElementsContainingZeroReturnsZero() {
            ClosestToZero closestToZero = new ClosestToZero();
            Assert.Equal(0, closestToZero.GetClosest(new int[3] {7, 0, 8}));
        }

        [Fact]
        public void FunctionGetClosestGivenArrayWithTwoNegativeElementsReturnsTheElementClosestToZero() {
            ClosestToZero closestToZero = new ClosestToZero();
            Assert.Equal(-1, closestToZero.GetClosest(new int[2] {-4, -1}));
        }

        [Fact]
        public void FunctionGetClosestGivenArrayWithOneNegativeElementAndOnePositiveElementReturnsTheElementClosestToZero() {
            ClosestToZero closestToZero = new ClosestToZero();
            Assert.Equal(2, closestToZero.GetClosest(new int[2] {-2, 2}));
        }

    }
}
