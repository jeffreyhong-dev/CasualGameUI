using System;
using UnityEngine;

namespace UI.UIElements
{
    public class TabBarViewController : MonoBehaviour
    {
        public bool animationInTransitionOnTabSelection;

        public bool blockSelectionWhileInTransition;

    
        public TabBarView tabBar;

        protected RectTransform viewControllerContainer;


        public int SelectedIndex { get; }
        public ViewController SelectedViewController { get; }
        public ViewController[] ViewControllers { get; }


        public void SetSelectedIndex(int index, bool animated = false, Action completion = null)
        {
            
        }

        public void SetSelectedViewController(ViewController viewController, bool animated = false, Action completion = null)
        {
            
        }
        
        
    }
}
