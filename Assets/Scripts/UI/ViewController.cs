using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UI
{
    [RequireComponent(typeof(CanvasGroup))]
    public class ViewController: MonoBehaviour, IView
    {
        
        [SerializeField]private bool _hidePrevious = true;            //  Add to ViewConfig
        
        [SerializeField]private bool _rememberStackHistory = true;          //  Add to ViewConfig
        
        
        
        protected RectTransform _rectTransform;
        protected CanvasGroup _canvasGroup;
        protected CanvasGroup _parent;




        public bool HidePrevious  { get => _hidePrevious; }

        public bool RememberStackHistory { get => _rememberStackHistory; }
        
        
        private void Awake()
        {
            _rectTransform = GetComponent<RectTransform>();
            _canvasGroup = GetComponent<CanvasGroup>();
        }


        public void Initialize(CanvasGroup parent)
        {
            _parent = parent;
            
            _canvasGroup.blocksRaycasts = false;
            _canvasGroup.interactable = false;
            _canvasGroup.alpha = 0;
        }

        public void Show()
        {
            PreShowView();
            ShowView();
            PostShowView();
        }

        public void Hide()
        {
            PreHideView();
            HideView();
            PostHideView();
        }


        
        protected virtual void PreShowView()
        {
            
        }

        protected virtual void ShowView()
        {

            _canvasGroup.alpha = 1;
            
        }
        
        protected virtual void PostShowView()
        {
            _canvasGroup.blocksRaycasts = true;
            _canvasGroup.interactable = true;
        }
        
        protected virtual void PreHideView()
        {
            _canvasGroup.blocksRaycasts = false;
            _canvasGroup.interactable = false;
        }

        protected virtual void HideView()
        {

            _canvasGroup.alpha = 0;
        }
        
        protected virtual void PostHideView()
        {
            
        }
        
        
        
    }
}