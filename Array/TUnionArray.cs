namespace Array
{
    class TUnionArray : TArray
    {
        public TUnionArray(int[]myArray) : base(myArray)
        {
        }
        public override int SumOfArr()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                sum |= myArray[i];   
            }
            return sum; 
        }   
        public override int[] Foreach()
        {
            int[] newArr = new int[myArray.Length];
            for (int i = 0; i < myArray.Length; i++)
            {
                newArr[i] = myArray[i];
                newArr[i] *= -1;
            }
            myArray = newArr;
            return myArray;
        }
    }
}
