using System;
using System.Collections.Generic;
using UnityCore.Util;
using UnityEngine;
using UnityEngine.UI;

namespace UIFramework
{
    public class NavigationManager : ManagerBase<NavigationManager>
    {
        
        private Stack<CanvasView> _viewStack;

        private RectTransform _viewContainer;
        
        
        public CanvasView RootViewController { get; }
        
        public CanvasView TopViewController { get; }
        
        public CanvasView[] ViewControllers { get; }
        
        
        private void Awake()
        {
            _instance = this;

            _viewStack = new Stack<CanvasView>();

        }





        public void Pop(bool animated = true, Action onComplete = null)
        {
            
        }

        public void PopTo(CanvasView viewController, bool animated = true, Action onComplete = null)
        {
            
        }

        public void PopToRoot(bool animated = true, Action onComplete = null)
        {
            
        }

        public void Pusho(CanvasView viewController, bool animated = true, Action onComplete = null)
        {
            
        }


        protected void ViewDidLoad()
        {
            
        }
        

        
        
        
        
        
        // public void ShowView(CanvasView view)
        // {
        //     view.Show();
        //
        //     if (view.HidePrevious && _viewStack.Count > 0) {
        //         //  Get the last item from the stack.
        //         CanvasView previousView = _viewStack.Peek();
        //         if (previousView != null) {
        //             previousView.Hide();
        //         }
        //     }
        //
        //     if (view.RememberStackHistory) {
        //         //  Add view to the view history stack.
        //         _viewStack.Push(view);
        //     }
        // }
        //
        //
        // public void HideView()
        // {
        //     
        // }
        //
        //
        // public void ShowPreviousView()
        // {
        //     //  We add the initial page to the history stack during Start.
        //     if (_viewStack.Count > 1)     
        //     {
        //         //  Remove current view from the stack.
        //         CanvasView previousView = _viewStack.Pop();
        //         previousView.Hide();
        //
        //         CanvasView currentView = _viewStack.Peek();
        //         currentView.Show();
        //     }
        //     else
        //     {
        //         LogWarning("Trying to go back when there is no more in the history stack.");
        //     }
        // }
        //



        #region Debug
        
        [SerializeField] private bool _debug;
        
        protected void Log(string msg)
        {
            if (!_debug) return;
            Debug.Log($"[<b>{GetType().Name}</b>]: {msg}");
        }

        protected void LogWarning(string msg)
        {
            if (!_debug) return;
            Debug.LogWarning($"[<b>{GetType().Name}</b>]: {msg}");
        }   
        
        #endregion

        
    }
}