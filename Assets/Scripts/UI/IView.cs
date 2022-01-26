

using UnityEngine;

namespace UI
{
    public interface IView
    {
        /// <summary>
        /// 
        /// </summary>
        public bool RememberStackHistory { get; }
        /// <summary>
        /// Hides the view if a new view is called.
        /// </summary>
        public bool HidePrevious { get; }
        
        
        
        public void Initialize(CanvasGroup parent);

        public void Show();

        public void Hide();

    }
}
