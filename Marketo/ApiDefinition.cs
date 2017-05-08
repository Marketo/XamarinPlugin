using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;
using CoreGraphics;
using UserNotifications;

namespace MarketoApi
{

	[BaseType(typeof(NSObject))]
	interface MKTSecuritySignature
	{
		[Export("initWithAccessKey:signature:timestamp:email:")]
		IntPtr Constructor(string accessKey, string signature, string timestamp, string email);

		[Export("getAccessKey")]
		string getAccessKey();

		[Export("getSignature")]
		string getSignature();

		[Export("getTimeStamp")]
		string getTimeStamp();

		[Export("getEmail")]
		string getEmail();

		[Export("isValid")]
		bool isValid();
	}

	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface Marketo
	{
		[Export("appSecret")]
		string AppSecret { get; }

		[Static]
		[Export("sharedInstance")]
		Marketo sharedInstance();

		[Export("initializeWithMunchkinID:appSecret:launchOptions:")]
		void InitializeWithMunchkinID(string munchkinID, string appSecret, NSDictionary launchOptions);

		[Export("setTimeoutInterval:")]
		void SetTimeoutInterval(nint seconds);

		[Export("reportAction:withMetaData:")]
		void ReportAction(string actionName, MarketoActionMetaData metaData);

		[Export("associateLead:")]
		void AssociateLead(NSObject lead);

		[Export("registerPushDeviceToken:")]
		void RegisterPushDeviceToken(NSData deviceToken);

		[Export ("unregisterPushDeviceToken")]
		void UnregisterPushDeviceToken ();

		[Export("trackPushNotification:")]
		void TrackPushNotification(NSDictionary userInfo);

		[Export("handlePushNotification:")]
		void HandlePushNotification(NSDictionary userInfo);

		[Export("isPushRegistered")]
		bool IsPushRegistered();

		[Export("application:openURL:sourceApplication:annotation:")]
		bool Application(UIApplication application, NSUrl url, string sourceApplication, NSObject annotation);

		[Export("application:didReceiveLocalNotification:")]
		void Application(UIApplication application, UILocalNotification notification);

		[Export("userNotificationCenter: didReceiveNotificationResponse:withCompletionHandler:")]
		void UserNotificationCenter(UNUserNotificationCenter center, UNNotificationResponse response, Action completionHandler);

		[Export("setSecureSignature:")]
		void SetSecureSignature(MKTSecuritySignature conf);

		[Export("removeSecureSignature")]
		void RemoveSecureSignature();

		[Export("isSecureModeEnabled")]
		bool isSecureModeEnabled();

		[Export("getDeviceId")]
		string getDeviceId();

		[Export ("reportAll")]
		void ReportAll ();
	}

	[BaseType(typeof(NSObject))]
	interface MarketoActionMetaData
	{
		[Export("setType:")]
		void SetType(string type);

		[Export("setDetails:")]
		void SetDetails(string details);

		[Export("setMetric:")]
		void SetMetric(NSNumber metric);

		[Export("setLength:")]
		void SetLength(NSNumber length);

		[Export("actionMetadata")]
		NSDictionary actionMetadata();
	}

	[BaseType(typeof(NSObject))]
	interface MarketoLead
	{
		[Export("setEmail:")]
		void SetEmail(string email);

		[Export("setGender:")]
		void SetGender(string gender);

		[Export("setFirstName:")]
		void SetFirstName(string firstName);

		[Export("setLastName:")]
		void SetLastName(string lastName);

		[Export("setAddress:")]
		void SetAddress(string address);

		[Export("setCity:")]
		void SetCity(string city);

		[Export("setState:")]
		void SetState(string state);

		[Export("setCountry:")]
		void SetCountry(string country);

		[Export("setPostalCode:")]
		void SetPostalCode(string postalCode);

		[Export("setLeadSource:")]
		void SetLeadSource(string leadSource);

		[Export("setFacebookId:")]
		void SetFacebookId(string facebookId);

		[Export("setTwitterId:")]
		void SetTwitterId(string twitterId);

		[Export("setLinkedInId:")]
		void SetLinkedInId(string LinkedInId);

		[Export("setBirthDay:")]
		void SetBirthDay(string birthday);

		[Export("setFacebookProfileURL:")]
		void SetFacebookProfileURL(string url);

		[Export("setFacebookProfilePicURL:")]
		void SetFacebookProfilePicURL(string url);

		[Export("setFieldName:withValue:")]
		void SetFieldName(string name, string value);

		[Export("userData")]
		NSDictionary userData();
	}
}
