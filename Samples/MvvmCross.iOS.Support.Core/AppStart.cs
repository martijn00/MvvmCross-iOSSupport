﻿namespace MvvmCross.iOS.Support.Core
{
    using MvvmCross.Core.ViewModels;
    using ViewModels;

    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        /// <summary>
        /// Start is called on startup of the app
        /// Hint contains information in case the app is started with extra parameters
        /// </summary>
        public void Start(object hint = null)
        {            
            ShowViewModel<CenterPanelViewModel>();

            // Loads the flyout menu on the left
            ShowViewModel<LeftPanelViewModel>();

            // Loads the flyout menu on the right
            //ShowViewModel<RightPanelViewModel>();
        }
    }
}