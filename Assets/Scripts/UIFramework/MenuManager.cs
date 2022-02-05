using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UIFramework
{
    public class MenuManager : MonoBehaviour
    {
        public static MenuManager Instance { get; private set; }


        private Stack<View> _viewHistory;
        
        private void Awake()
        {
            Instance = this;
            
        }
        
        


        public void ShowView(View view)
        {
            
        }


        public void ShowPreviousView()
        {
            
        }


        public void HideView()
        {
            
        }
        
        
        
        
    }
}