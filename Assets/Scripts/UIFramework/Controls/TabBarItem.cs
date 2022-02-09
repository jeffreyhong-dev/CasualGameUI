using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UIFramework
{
    public class TabBarItem : MonoBehaviour
    {
        public int index;

        public event Action OnDeselected;
        public event Action OnSelected;

        protected bool _selected;



        public void BindToClick(UnityAction<TabBarItem> callback)
        {
            
        }

        public void SetSelected(bool selected)
        {
            
        }


    }
}
