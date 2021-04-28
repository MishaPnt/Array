using System.Linq;

namespace Array
{
    class XorArray : TArray
    {
        public XorArray(int[] myArray) : base(myArray)
        {
        }
        public override int SumOfArr()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                sum = myArray[i] ^ myArray[i]; 
            }
            return sum;
        }
        public override int[] Foreach()
        {
            var sorted = myArray.OrderBy(d => d);
            double dataMax = sorted.First();
            double dataMin = sorted.Last(); 
            int[] newArr = new int[myArray.Length];
            for (int i = 0; i < myArray.Length; i++)
            {
                newArr[i] = myArray[i];
            }
            return newArr;
        }
    }
}
