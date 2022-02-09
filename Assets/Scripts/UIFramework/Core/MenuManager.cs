using System;
using System.Collections.Generic;
using UnityCore.Util;
using UnityEngine;
using UnityEngine.UI;

namespace UIFramework
{
    [DisallowMultipleComponent]
    public class MenuManager : MonoBehaviour
    {
        public static MenuManager Instance { get; private set; }

        
        
        [SerializeField] private View _initialView;
        
        [SerializeField] private RectTransform _viewContainer;

        [SerializeField] private View[] _viewConfigs;
        
        [SerializeField] private bool _debug;
        
        
        private Stack<View> _viewHistory;

        
        

        private void Awake()
        {
            if (Instance == null) {
                Instance = this;
            }
            
            if (Instance != null && Instance != this) {
                LogWarning($"Another instance of {this} has already been registered for this scene, destroying this one");
                Destroy(gameObject);
            }
            
        }


        private void OnDestroy()
        {
            Instance = null;
        }


        private void Configure()
        {
            
        }


        
        
        
        
        
        
        public void ShowView(View view)
        {
            view.Show();

            if (view.HidePrevious && _viewHistory.Count > 0) {
                //  Get the last item from the stack.
                View previousView = _viewHistory.Peek();
                if (previousView != null) {
                    previousView.Hide();
                }
            }

            if (view.RememberStackHistory) {
                //  Add view to the view history stack.
                _viewHistory.Push(view);
            }
        }


        public void HideView()
        {
            
        }
        
        
        public void ShowPreviousView()
        {
            //  We add the initial page to the history stack during Start.
            if (_viewHistory.Count > 1)     
            {
                //  Remove current view from the stack.
                View previousView = _viewHistory.Pop();
                previousView.Hide();

                View currentView = _viewHistory.Peek();
                currentView.Show();
            }
            else
            {
                LogWarning("Trying to go back when there is no more in the history stack.");
            }
        }




        #region Debug
        private void Log(string msg)
        {
            if (!_debug) return;
            Debug.Log($"[<b>{GetType().Name}</b>]: {msg}");
        }

        private void LogWarning(string msg)
        {
            if (!_debug) return;
            Debug.LogWarning($"[<b>{GetType().Name}</b>]: {msg}");
        }   
        
        #endregion

        
    }
}