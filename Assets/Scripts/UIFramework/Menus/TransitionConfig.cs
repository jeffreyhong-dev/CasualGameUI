using System;
using System.Collections;
using UnityEngine;

namespace UIFramework
{

    public abstract class TransitionConfig : ScriptableObject,  ITransition
    {
        
        [SerializeField] protected float _delay = 0.0f;
        
        [SerializeField] protected float _duration = 0.3f;




        public abstract IEnumerator ExecuteTransition(CanvasView view, Action onComplete);

        
        
        
        // private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir)
        // {
        //     if (rect == null)
        //         return Vector3.zero;
        //     if (dir != Vector2.zero)
        //         dir /= Mathf.Max(Mathf.Abs(dir.x), Mathf.Abs(dir.y));
        //     dir = rect.rect.center + Vector2.Scale(rect.rect.size, dir * 0.5f);
        //     return dir;
        // }
    }



    public class InstantTransition : TransitionConfig
    {
        
        
        public override IEnumerator ExecuteTransition(CanvasView view, Action onComplete)
        {
            yield return null;
        }
    }
}