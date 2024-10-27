using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal static class CollectionExtension
    {
        public static T GetMax<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber) where T : class
        {
            T maxItem = null;
            float maxValue = float.MinValue; 

            if (collection is null || !collection.Any())
            {
                return null;
            }

            foreach(var collectionItem in collection)
            {
                try
                {
                    float collectionItemValue = convertToNumber(collectionItem);
                    if(collectionItemValue > maxValue)
                    {
                        maxValue = collectionItemValue;
                        maxItem = collectionItem;
                    }
                }
                catch
                {
                }
            }
            
            return maxItem;
        }

        public static void CollectionWrite<T>(this IEnumerable<T> collection) where T : class
        {
            Console.WriteLine(collection.GetType());
            foreach (var collectionItem in collection)
            {
                Console.WriteLine(collectionItem.ToString());
            }
        }
    }
}
