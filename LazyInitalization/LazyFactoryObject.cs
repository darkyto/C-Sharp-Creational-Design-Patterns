namespace LazyInitalization
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Source http://en.wikipedia.org/wiki/Lazy_initialization
    /// </summary>
    public class LazyFactoryObject
    {
        private readonly IDictionary<LazyObjectType, LazyObject> lazyObjectList = new Dictionary<LazyObjectType, LazyObject>();

        public LazyObject GetLazyFactoryObject(LazyObjectType name)
        {
            LazyObject noGoodSomeOne;
            if (!this.lazyObjectList.TryGetValue(name, out noGoodSomeOne))
            {
                noGoodSomeOne = new LazyObject { Name = name, Result = this.Result(name) };

                this.lazyObjectList.Add(name, noGoodSomeOne);
            }

            return noGoodSomeOne;
        }

        // takes type and create 'expensive' list
        private IList<int> Result(LazyObjectType name)
        {
            IList<int> result;

            switch (name)
            {
                case LazyObjectType.Small:
                    result = this.CreateSomeExpensiveList(1, 100);
                    break;
                case LazyObjectType.Medium:
                    result = this.CreateSomeExpensiveList(1, 1000);
                    break;
                case LazyObjectType.Big:
                    result = this.CreateSomeExpensiveList(1, 10000);
                    break;
                case LazyObjectType.Huge:
                    result = this.CreateSomeExpensiveList(1, 100000);
                    break;
                case LazyObjectType.None:
                    result = null;
                    break;
                default:
                    result = null;
                    break;
            }

            return result;
        }

        // not an expensive item to create, but you get the point
        // delays creation of some expensive object until needed
        private IList<int> CreateSomeExpensiveList(int start, int end)
        {
            IList<int> result = new List<int>();

            for (int counter = 0; counter < (end - start); counter++)
            {
                result.Add(start + counter);
            }

            return result;
        }
    }
}
