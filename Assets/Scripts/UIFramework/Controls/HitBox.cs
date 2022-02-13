using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using TMPro;

namespace UIFramework
{

    public class HitBox : Graphic, 
        IPointerUpHandler, IPointerDownHandler
    {
        
        
        
        
        public virtual void OnPointerUp(PointerEventData eventData)
        {
            throw new System.NotImplementedException();
        }

        public virtual void OnPointerDown(PointerEventData eventData)
        {
            throw new System.NotImplementedException();
        }
    }
}