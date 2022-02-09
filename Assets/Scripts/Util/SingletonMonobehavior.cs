using System;
using UnityEngine;

namespace UnityCore.Util
{
    [DisallowMultipleComponent]
    public abstract class SingletonMonobehavior<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;

        public static T Instance {
            get {
                if (_instance == null) {
                    _instance = (T)FindObjectOfType(typeof(T));
                    if (_instance == null) {
                        Debug.LogError($"[<color=red>{typeof(T)}</color>] could not be found.");
                    }
                }

                return _instance;
            }
            private set { _instance = value; }
        }

        
        
        
        protected GameObject _gameObject;
        protected Transform _transform;

        private void Awake()
        {
            if (Instance != null && Instance != this) {
                Debug.LogWarning($"Another instance of {this} has already been registered for this scene, destroying this one");
                Destroy(this.gameObject);
            }
            _instance = gameObject.GetComponent<T>();
            DontDestroyOnLoad(gameObject);
            
            _gameObject = gameObject;
            _transform = transform;
            
            OnAwake();
        }

    

        protected virtual void OnAwake() { }



        // public void Log(string msg = "")
        // {
        //     Debug.Log(msg);
        // }
    }
}