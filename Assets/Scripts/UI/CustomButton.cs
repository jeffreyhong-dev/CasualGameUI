using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using TMPro;

namespace UI
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomButton : MonoBehaviour, 
        IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, 
        IPointerExitHandler, IPointerDownHandler
    {

        [SerializeField] private string _label;
        [Header("Font Colors")]
        [SerializeField] private Color _defaultTextColor = Color.white;
        [SerializeField] private Color _hoverTextColor = Color.white;
        [SerializeField] private Color _clickTextColor = Color.white;
        
        [Header("Background Colors")]
        [SerializeField] private Color _defaultBackgroundColor = Color.white;
        [SerializeField] private Color _hoverBackgroundColor = Color.white;
        [SerializeField] private Color _clickBackgroundColor = Color.white;

        [Header("Animation Settings")]
        [SerializeField] private float _hoverAnimationDuration = 0.5f;
        [SerializeField] private float _defaultAnimationDuration = 0.5f;
        [SerializeField] private float _clickAnimationDuration = 0.5f;

        [Header("Controls")]
        private TextMeshProUGUI _titleControl;
        private Image _defaultBackgroundImage;
        private Image _hoverBackgroundImage;
        private CanvasGroup _defaultCanvasGroup;
        private CanvasGroup _hoverCanvasGroup;

        [Header("Callbacks")]
        private UnityAction _callBackAction;


        
        private void OnValidate()
        {
            if (_titleControl != null)
            {
                _titleControl.SetText(_label);
                _titleControl.color = _defaultTextColor;
            }

            if (_defaultBackgroundImage != null)
            {
                _defaultBackgroundImage.color = _defaultBackgroundColor;
            }
            if (_hoverBackgroundImage != null)
            {
                _hoverBackgroundImage.color = _hoverBackgroundColor;
            }

            
        }

        protected virtual void DefaultState()
        {
            
        }
        
        protected virtual void HoverState()
        {
            
        }
        
        protected virtual void ClickState()
        {
            
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            HoverState();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            DefaultState();
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            ClickState();
        }


        public void OnPointerUp(PointerEventData eventData)
        {
            HoverState();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            ClickState();
        }
        
        
        
        
        
        

        /// <summary>
        /// Registers call back for click event.
        /// </summary>
        /// <param name="callBack"></param>
        public void RegisterCallback(UnityAction callBack)
        {
            _callBackAction = callBack;
        }
    }
}
