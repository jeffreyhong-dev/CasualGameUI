using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UIFramework
{
    [DisallowMultipleComponent]
    public class UIManager : MonoBehaviour
    {
        private static UIManager _instance;
        
        
        [SerializeField] private ViewConfig _startView;
        
        [SerializeField] private NavigationManager _navigationManager;
        
        [SerializeField] private InteractionBlocker _interactionBlocker;




        private void Initialize()
        {
            
        }
        
        
        
        #region Debug
        
        [SerializeField] private bool _debug;
        protected void Log(string msg) {
            if (!_debug) return;
            Debug.Log($"[<b>{GetType().Name}</b>]: {msg}");
        }

        protected void LogWarning(string msg) {
            if (!_debug) return;
            Debug.LogWarning($"[<b>{GetType().Name}</b>]: {msg}");
        }   
        
        #endregion
    }
}
