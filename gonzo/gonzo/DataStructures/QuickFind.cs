namespace gonzo.DataStructures
{
    class QuickFind : UnionFind
    {
        public override void Union(int p, int q)
        {
            var pid = Id[p];
            var qid = Id[q];
            for (var i = 0; i < Id.Length; i++)
            {
                if (Id[i] == pid)
                {
                    Id[i] = qid;
                }
            }
        }

        public override bool Connected(int p, int q)
        {
            return Id[p] == Id[q];
        }

        public QuickFind(int n)
            : base(n)
        {
        }
    }
}