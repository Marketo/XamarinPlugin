using System;
using UserNotifications;
using MarketoApi;

namespace TestMarketo
{
	public class Notifications
	{
		public Notifications()
		{
		}
	}
	public class MyUNUserNotificationCenterDelegate : UNUserNotificationCenterDelegate
	{
		#region Override Methods
		public override void WillPresentNotification(UNUserNotificationCenter center, UNNotification notification, Action<UNNotificationPresentationOptions> completionHandler)
		{
			//Validate if the app is active and not sending the notification??
			//UIApplication.SharedApplication.ApplicationState == UIApplicationState.Active
			//completionHandler(UNNotificationPresentationOptions.None);
			//always send the notification
			completionHandler(UNNotificationPresentationOptions.Alert);
		}
		#endregion


		public override void DidReceiveNotificationResponse(UNUserNotificationCenter center, UNNotificationResponse response, System.Action completionHandler)
		{
			//NSMutableDictionary res = (NSMutableDictionary) response.Notification.Request.Content.UserInfo.MutableCopy();
			//res.SetValueForKey(new NSString("checked"), new NSString("checked"));
			Marketo.sharedInstance().UserNotificationCenter(center, response, completionHandler);

		}	
	}
}
