using System;


namespace Practice2.Repository
{
    public static class Storage
    {
        public static readonly ClientStorage clientStorage = new();
        public static readonly OrderStorage orderStorage = new();
    }
}
