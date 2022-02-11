using UnityEngine;

namespace UIFramework
{
    public static class GameObjectExtensions
    {
        
        public static T GetOrAddComponent<T>( this GameObject obj ) where T : Component
        {
            T result = obj.GetComponent<T>();
            if ( result == null )
            {
                result = obj.AddComponent<T>();
            }
      
            return result;
        }
    }
}