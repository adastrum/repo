namespace gonzo.DataStructures
{
    abstract class UnionFind
    {
        protected int[] Id;

        protected void PopulateArray(int n)
        {
            Id = new int[n];
            for (var i = 0; i < n; i++)
            {
                Id[i] = i;
            }
        }

        public abstract void Union(int p, int q);

        public abstract bool Connected(int p, int q);

        protected UnionFind(int n)
        {
            PopulateArray(n);
        }
    }
}
