using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
    public class MenuController : MonoBehaviour
    {

        [SerializeField] private ViewController _initialView;



        private Stack<IView> _viewHistory;


        private void Awake()
        {
            _viewHistory = new Stack<IView>();


        }

        private void Start()
        {
            Init();
        }


        public void Init()
        {
            if (_initialView != null) {
                ShowView(_initialView);
            }
        }


        public void ShowView(ViewController view)
        {
            view.Show();

            if (view.HidePrevious && _viewHistory.Count > 0)
            {
                //  Get the last item from the stack.
                IView previousView = _viewHistory.Peek();
                Debug.AssertFormat(previousView != null, "previous view is null");
                previousView.Hide();
            }
            
            if (view.RememberStackHistory)
            {
                //  Add view to the view history stack.
                _viewHistory.Push(view);
            }

            
        }


        public void ShowPreviousView()
        {  
            //  We add the initial page to the history stack during Start.
            if (_viewHistory.Count > 1)     
            {
                //  Remove current view from the stack.
                IView previousView = _viewHistory.Pop();
                previousView.Hide();

                IView currentView = _viewHistory.Peek();
                currentView.Show();
            }
            else
            {
                Debug.LogWarning("Trying to go back when there is no more in the history stack.");
            }
        }


        
    }
}
