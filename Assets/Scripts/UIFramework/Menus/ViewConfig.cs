using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace UIFramework
{
    [CreateAssetMenu(fileName = "ViewConfig", menuName = "MENUNAME", order = 0)]
    public class ViewConfig : ScriptableObject, IViewConfig
    {
        private const string k_menu = "uGUI Framework/View Configuration";
        
        
        [SerializeField] private string _title;
        
        [SerializeField] private bool _hidePrevious = true;
        
        [SerializeField] private bool _rememberStackHistory = true;

        [SerializeField] private TransitionConfig _showTransition;
        
        [SerializeField] private TransitionConfig _hideTransition;
        
        [SerializeField] private List<View> _configurations;
        
        
        public bool HidePrevious  { get => _hidePrevious; }
        
        public bool RememberStackHistory { get => _rememberStackHistory; }


        
        
        
        
        
        
        

        #region Create ScriptableObject
        
#if UNITY_EDITOR
        [MenuItem(k_menu)]
        public static void CreateViewConfiguration()
        {
            
        }
        
        [MenuItem(k_menu, validate = true)]
        public static bool CreateViewConfigurationValidate()
        {
            return false;
        }
#endif
        

        #endregion


        
        
    }
}