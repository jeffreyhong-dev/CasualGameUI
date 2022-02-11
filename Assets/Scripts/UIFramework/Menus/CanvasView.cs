using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace UIFramework
{

    
    public class CanvasView : MonoBehaviour
    {
        [SerializeField] private string _viewName;
        
        [SerializeField] private List<Camera> _cameraList;

        private List<Canvas> _canvas;
        
        private List<PanelView> _panelViews;

        

        

    }
}