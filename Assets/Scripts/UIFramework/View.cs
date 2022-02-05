using UnityEngine;

namespace UIFramework
{
    public class View : MonoBehaviour
    {
        
        [SerializeField]private bool _hidePrevious = true;
        [SerializeField]private bool _rememberStackHistory = true;
        
        
        
        
        public bool HidePrevious  { get => _hidePrevious; }
        public bool RememberStackHistory { get => _rememberStackHistory; }





        public void Show()
        {
            
        }
        
        
        
    }
}