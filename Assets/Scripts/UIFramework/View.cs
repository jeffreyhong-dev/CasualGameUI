using UnityEngine;
using UnityEngine.UI;


namespace UIFramework
{
    public class View : MonoBehaviour
    {
        [SerializeField] private string _label;
        [SerializeField] private bool _hidePrevious = true;
        [SerializeField] private bool _rememberStackHistory = true;
        
        
        
        public string Identifier {
            get => _label;
        }
        public bool HidePrevious  { get => _hidePrevious; }
        public bool RememberStackHistory { get => _rememberStackHistory; }






        public void Show()
        {
            
        }

        public void Hide()
        {
            
        }
        
        
        
        
    }
}