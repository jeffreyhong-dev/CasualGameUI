using System;
using System.Collections;
using UnityEngine;

namespace UIFramework
{
    [Serializable]
    public abstract class TransitionConfig : ITransition
    {
        [SerializeField] protected string _label;
        
        [SerializeField] protected float _delay = 0.0f;
        
        [SerializeField] protected float _time = 0.5f;


        protected float duration {
            get => _delay + _time;
        }


        public abstract IEnumerator StartTransitionAnimation(RectTransform rectTransform, Action onComplete);


    }
}