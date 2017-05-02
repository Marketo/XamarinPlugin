using Foundation;
using UIKit;
using MarketoApi;

namespace TestMarketo
{
	// The UIApplicationDelegate for the application. This class is responsible for launching th
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations

		public override UIWindow Window
		{
			get;
			set;
		}

		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
		{
			// Override point for customization after application launch.
			// If not required for your application you can safely delete this method
			Marketo m = Marketo.sharedInstance();
			m.InitializeWithMunchkinID("MUNC", "UnAwSXhja216b1Z5Z0EzbEZKMnNXR08x", launchOptions);

			MarketoLead lead = new MarketoLead();
			lead.SetEmail("xamarin@gmail.com");

			 
			m.AssociateLead(lead);


			return true;
		}

		public override void OnResignActivation(UIApplication application)
		{
			// Invoked when the application is about to move from active to inactive state.
			// This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
			// or when the user quits the application and it begins the transition to the background state.
			// Games should use this method to pause the game.
		}

		public override void DidEnterBackground(UIApplication application)
		{
			// Use this method to release shared resources, save user data, invalidate timers and store the application state.
			// If your application supports background exection this method is called instead of WillTerminate when the user quits.
		}

		public override void WillEnterForeground(UIApplication application)
		{
			// Called as part of the transiton from background to active state.
			// Here you can undo many of the changes made on entering the background.
		}

		public override void OnActivated(UIApplication application)
		{
			// Restart any tasks that were paused (or not yet started) while the application was inactive. 
			// If the application was previously in the background, optionally refresh the user interface.
		}

		public override void WillTerminate(UIApplication application)
		{
			// Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
		}

		public override void DidReceiveRemoteNotification(UIApplication application, NSDictionary userInfo, System.Action<UIBackgroundFetchResult> completionHandler)
		{
			base.DidReceiveRemoteNotification(application, userInfo, completionHandler);
			Marketo.sharedInstance().HandlePushNotification(userInfo);
		}

		public override bool OpenUrl(UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
		{
			Marketo.sharedInstance().Application(application, url, sourceApplication, annotation);
			return base.OpenUrl(application, url, sourceApplication, annotation);

		}

		public override void RegisteredForRemoteNotifications(UIApplication application, NSData deviceToken)
		{
			base.RegisteredForRemoteNotifications(application, deviceToken);
			Marketo.sharedInstance().RegisterPushDeviceToken(deviceToken);
		}

		public override void ReceivedLocalNotification(UIApplication application, UILocalNotification notification)
		{
			base.ReceivedLocalNotification(application, notification);
			Marketo.sharedInstance().Application(application,notification);
		}


	}
}


