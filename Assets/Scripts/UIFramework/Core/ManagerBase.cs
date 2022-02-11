using UnityEngine;

namespace UIFramework
{
    [DisallowMultipleComponent]
    public abstract class ManagerBase<T> : MonoBehaviour where T : MonoBehaviour
    {
        protected static T _instance;

        public static T instance {
            get {
                if (_instance == null) {
                    _instance = FindObjectOfType<T>();
                }

                return _instance;
            }
        }
        
        
        
        

    }
}