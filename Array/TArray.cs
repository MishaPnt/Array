namespace Array
{
    abstract class TArray
    {
        protected int sum = 0;
        protected int[] myArray;
        public TArray(int[]myArray)
        {
            this.myArray = myArray;
        }
        public abstract int SumOfArr();
        public abstract int[] Foreach();
    }
}
