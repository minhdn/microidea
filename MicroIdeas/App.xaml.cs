﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.WindowsAzure.MobileServices;

// The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkId=234227

namespace MicroIdeas
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {

        // uncommenting the following code and replacing AppUrl & AppKey with values from  
        // your mobile service, which are obtained from the Windows Azure Management Portal.
        // Do this after you add a reference to the Mobile Services client to your project.

        public static MobileServiceClient MobileService = new MobileServiceClient(
            "https://microideas.azure-mobile.net/",
            "ULhrmylKHPWQbIXvIzkZiKygKUWXGn18"
        );

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used when the application is launched to open a specific file, to display
        /// search results, and so forth.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        //protected override void OnLaunched(LaunchActivatedEventArgs args)
        //{
        //    Frame rootFrame = Window.Current.Content as Frame;

        //    // Do not repeat app initialization when the Window already has content,
        //    // just ensure that the window is active
        //    if (rootFrame == null)
        //    {
        //        // Create a Frame to act as the navigation context and navigate to the first page
        //        rootFrame = new Frame();

        //        if (args.PreviousExecutionState == ApplicationExecutionState.Terminated)
        //        {
        //            //TODO: Load state from previously suspended application
        //        }

        //        // Place the frame in the current Window
        //        Window.Current.Content = rootFrame;
        //    }

        //    if (rootFrame.Content == null)
        //    {
        //        // When the navigation stack isn't restored navigate to the first page,
        //        // configuring the new page by passing required information as a navigation
        //        // parameter
        //        if (!rootFrame.Navigate(typeof(Splash), args.Arguments))
        //        {
        //            throw new Exception("Failed to create initial page");
        //        }
        //    }

        //    // Ensure the current window is active
        //    Window.Current.Activate();
        //}
        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            //First we want to check to see if the application was already running.
            if (args.PreviousExecutionState != ApplicationExecutionState.Running)
            {
                //If it wasn't, then we want to check to see if it was terminated the last time it was run,
                //which we will pass on to our Splash page.
                bool loadState = (args.PreviousExecutionState == ApplicationExecutionState.Terminated);
                //Create a new Splash page object passing the SplashScreen object to the constructor.
                Splash splashPage = new Splash(args.SplashScreen, loadState);
                //Set our current app's content = the new Splash page.
                Window.Current.Content = splashPage;
            }
            Window.Current.Activate();
            RemoveExtendedSplash();
        }

        private static void RemoveExtendedSplash()
        {
            Window.Current.Content = new IdeaView();
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}
