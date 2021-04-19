namespace Array
{
    class XorArray : TArray
    {
        public XorArray(int[] myArray) : base(myArray)
        {
        }
        public override int SumOfArr()
        {
            int[] newArr = new int[myArray.Length + 1];
            for (int i = 0; i < myArray.Length; i++)
            {
                newArr[i] = myArray[i];
                sum = newArr[i] ^ newArr[i];
            }
            return sum;
        }
        public override int[] Foreach()
        {
            int[] newArr = new int[myArray.Length + 1];
            for (int i = 0; i < myArray.Length; i++)
            {
                newArr[i] = myArray[i];
            }
            myArray = newArr;
            return myArray;
        }
    }
}
