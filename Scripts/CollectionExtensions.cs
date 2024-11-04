using System;
using System.Collections.Generic;
using System.Linq;


namespace MyExtensions
{
  public static class CollectionExtensions
  {
    #region Random
    public static T RandomElement<T>( this IEnumerable<T> collection )
    {
      Random rnd = new Random();

      var count = collection.Count();

      if ( count < 2 )
        return collection.First();

      return collection.ElementAt( rnd.Next( 0, count ) );
    }

    public static IEnumerable<T> Shuffle<T>( this IEnumerable<T> source )
    {
      Random rnd = new Random();
      return source.OrderBy( _ => rnd.Next() );
    }
    #endregion
    
    public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
    {
      foreach ( T item in enumeration )
        action( item );
    }
  }
}