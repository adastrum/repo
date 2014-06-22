namespace gonzo.DataStructures
{
    class QuickUnion : UnionFind
    {
        public override void Union(int p, int q)
        {
            var i = Root(p);
            var j = Root(q);
            Id[i] = j;
        }

        public override bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public int Root(int i)
        {
            while (Id[i] != i)
            {
                i = Id[i];
            }
            return i;
        }

        public QuickUnion(int n)
            : base(n)
        {
        }
    }
}
