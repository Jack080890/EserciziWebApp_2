using ArrayManagement_2;

namespace TestProject_ArraySorter
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] numeri = [10, 8, 4, 65, 22, 9];
            int fromIndex = 0;
            int toIndex = numeri.Length;
            int numElements = numeri.Length - 1;

            int prova = ArraySorter.FindIndexOfMin(numeri, fromIndex, toIndex);

            Assert.Equal(2, prova);
        }
    }
}