using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Marketo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']"
	[global::Android.Runtime.Register ("com/marketo/Marketo", DoNotGenerateAcw=true)]
	public sealed partial class Marketo : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/field[@name='SDK_VERSION']"
		[Register ("SDK_VERSION")]
		public const string SdkVersion = (string) "MarketoSDK 0.7.5";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/field[@name='SDK_VERSION_CODE']"
		[Register ("SDK_VERSION_CODE")]
		public const string SdkVersionCode = (string) "0.7.5";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/field[@name='SDK_VERSION_INT']"
		[Register ("SDK_VERSION_INT")]
		public const int SdkVersionInt = (int) 6;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/marketo/Marketo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Marketo); }
		}

		internal Marketo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCurrentActivity;
		public unsafe global::Android.App.Activity CurrentActivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='getCurrentActivity' and count(parameter)=0]"
			[Register ("getCurrentActivity", "()Landroid/app/Activity;", "GetGetCurrentActivityHandler")]
			get {
				if (id_getCurrentActivity == IntPtr.Zero)
					id_getCurrentActivity = JNIEnv.GetMethodID (class_ref, "getCurrentActivity", "()Landroid/app/Activity;");
				try {
					return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentActivity), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDeviceId;
		public unsafe string DeviceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='getDeviceId' and count(parameter)=0]"
			[Register ("getDeviceId", "()Ljava/lang/String;", "GetGetDeviceIdHandler")]
			get {
				if (id_getDeviceId == IntPtr.Zero)
					id_getDeviceId = JNIEnv.GetMethodID (class_ref, "getDeviceId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_isPushRegistered;
		public static unsafe bool IsPushRegistered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='isPushRegistered' and count(parameter)=0]"
			[Register ("isPushRegistered", "()Z", "GetIsPushRegisteredHandler")]
			get {
				if (id_isPushRegistered == IntPtr.Zero)
					id_isPushRegistered = JNIEnv.GetStaticMethodID (class_ref, "isPushRegistered", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isPushRegistered);
				} finally {
				}
			}
		}

		static IntPtr id_isSDKInitalized;
		public static unsafe bool IsSDKInitalized {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='isSDKInitalized' and count(parameter)=0]"
			[Register ("isSDKInitalized", "()Z", "GetIsSDKInitalizedHandler")]
			get {
				if (id_isSDKInitalized == IntPtr.Zero)
					id_isSDKInitalized = JNIEnv.GetStaticMethodID (class_ref, "isSDKInitalized", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSDKInitalized);
				} finally {
				}
			}
		}

		static IntPtr id_isSecureModeEnabled;
		public static unsafe bool IsSecureModeEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='isSecureModeEnabled' and count(parameter)=0]"
			[Register ("isSecureModeEnabled", "()Z", "GetIsSecureModeEnabledHandler")]
			get {
				if (id_isSecureModeEnabled == IntPtr.Zero)
					id_isSecureModeEnabled = JNIEnv.GetStaticMethodID (class_ref, "isSecureModeEnabled", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSecureModeEnabled);
				} finally {
				}
			}
		}

		static IntPtr id_getNetworkTimeout;
		static IntPtr id_setNetworkTimeout_I;
		public static unsafe int NetworkTimeout {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='getNetworkTimeout' and count(parameter)=0]"
			[Register ("getNetworkTimeout", "()I", "GetGetNetworkTimeoutHandler")]
			get {
				if (id_getNetworkTimeout == IntPtr.Zero)
					id_getNetworkTimeout = JNIEnv.GetStaticMethodID (class_ref, "getNetworkTimeout", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getNetworkTimeout);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='setNetworkTimeout' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNetworkTimeout", "(I)V", "GetSetNetworkTimeout_IHandler")]
			set {
				if (id_setNetworkTimeout_I == IntPtr.Zero)
					id_setNetworkTimeout_I = JNIEnv.GetStaticMethodID (class_ref, "setNetworkTimeout", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setNetworkTimeout_I, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getNotificationConfig;
		static IntPtr id_setNotificationConfig_Lcom_marketo_MarketoConfig_Notification_;
		public unsafe global::Com.Marketo.MarketoConfig.Notification NotificationConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='getNotificationConfig' and count(parameter)=0]"
			[Register ("getNotificationConfig", "()Lcom/marketo/MarketoConfig$Notification;", "GetGetNotificationConfigHandler")]
			get {
				if (id_getNotificationConfig == IntPtr.Zero)
					id_getNotificationConfig = JNIEnv.GetMethodID (class_ref, "getNotificationConfig", "()Lcom/marketo/MarketoConfig$Notification;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoConfig.Notification> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotificationConfig), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='setNotificationConfig' and count(parameter)=1 and parameter[1][@type='com.marketo.MarketoConfig.Notification']]"
			[Register ("setNotificationConfig", "(Lcom/marketo/MarketoConfig$Notification;)V", "GetSetNotificationConfig_Lcom_marketo_MarketoConfig_Notification_Handler")]
			set {
				if (id_setNotificationConfig_Lcom_marketo_MarketoConfig_Notification_ == IntPtr.Zero)
					id_setNotificationConfig_Lcom_marketo_MarketoConfig_Notification_ = JNIEnv.GetMethodID (class_ref, "setNotificationConfig", "(Lcom/marketo/MarketoConfig$Notification;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationConfig_Lcom_marketo_MarketoConfig_Notification_, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getTriggerableInAppMessages;
		static IntPtr id_setTriggerableInAppMessages_Ljava_util_HashMap_;
		public unsafe global::System.Collections.Generic.IDictionary<string, global::Com.Marketo.Inapp.Models.InAppMessage> TriggerableInAppMessages {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='getTriggerableInAppMessages' and count(parameter)=0]"
			[Register ("getTriggerableInAppMessages", "()Ljava/util/HashMap;", "GetGetTriggerableInAppMessagesHandler")]
			get {
				if (id_getTriggerableInAppMessages == IntPtr.Zero)
					id_getTriggerableInAppMessages = JNIEnv.GetMethodID (class_ref, "getTriggerableInAppMessages", "()Ljava/util/HashMap;");
				try {
					return global::Android.Runtime.JavaDictionary<string, global::Com.Marketo.Inapp.Models.InAppMessage>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTriggerableInAppMessages), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='setTriggerableInAppMessages' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, com.marketo.inapp.models.InAppMessage&gt;']]"
			[Register ("setTriggerableInAppMessages", "(Ljava/util/HashMap;)V", "GetSetTriggerableInAppMessages_Ljava_util_HashMap_Handler")]
			set {
				if (id_setTriggerableInAppMessages_Ljava_util_HashMap_ == IntPtr.Zero)
					id_setTriggerableInAppMessages_Ljava_util_HashMap_ = JNIEnv.GetMethodID (class_ref, "setTriggerableInAppMessages", "(Ljava/util/HashMap;)V");
				IntPtr native_value = global::Android.Runtime.JavaDictionary<string, global::Com.Marketo.Inapp.Models.InAppMessage>.ToLocalJniHandle (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTriggerableInAppMessages_Ljava_util_HashMap_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr id_associateLead_Lcom_marketo_MarketoLead_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='associateLead' and count(parameter)=1 and parameter[1][@type='com.marketo.MarketoLead']]"
		[Register ("associateLead", "(Lcom/marketo/MarketoLead;)V", "")]
		public unsafe void AssociateLead (global::Com.Marketo.MarketoLead p0)
		{
			if (id_associateLead_Lcom_marketo_MarketoLead_ == IntPtr.Zero)
				id_associateLead_Lcom_marketo_MarketoLead_ = JNIEnv.GetMethodID (class_ref, "associateLead", "(Lcom/marketo/MarketoLead;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_associateLead_Lcom_marketo_MarketoLead_, __args);
			} finally {
			}
		}

		static IntPtr id_cleanMarketoAppSecret;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='cleanMarketoAppSecret' and count(parameter)=0]"
		[Register ("cleanMarketoAppSecret", "()V", "")]
		public unsafe void CleanMarketoAppSecret ()
		{
			if (id_cleanMarketoAppSecret == IntPtr.Zero)
				id_cleanMarketoAppSecret = JNIEnv.GetMethodID (class_ref, "cleanMarketoAppSecret", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cleanMarketoAppSecret);
			} finally {
			}
		}

		static IntPtr id_getInAppMessagesForDevice_ZLjava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='getInAppMessagesForDevice' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getInAppMessagesForDevice", "(ZLjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void GetInAppMessagesForDevice (bool p0, string p1, string p2)
		{
			if (id_getInAppMessagesForDevice_ZLjava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getInAppMessagesForDevice_ZLjava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getInAppMessagesForDevice", "(ZLjava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getInAppMessagesForDevice_ZLjava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_getInstance_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/marketo/Marketo;", "")]
		public static unsafe global::Com.Marketo.Marketo GetInstance (global::Android.Content.Context p0)
		{
			if (id_getInstance_Landroid_content_Context_ == IntPtr.Zero)
				id_getInstance_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "getInstance", "(Landroid/content/Context;)Lcom/marketo/Marketo;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Marketo.Marketo __ret = global::Java.Lang.Object.GetObject<global::Com.Marketo.Marketo> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getInstance_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_initializeMarketoPush_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='initializeMarketoPush' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("initializeMarketoPush", "(Ljava/lang/String;)V", "")]
		public unsafe void InitializeMarketoPush (string p0)
		{
			if (id_initializeMarketoPush_Ljava_lang_String_ == IntPtr.Zero)
				id_initializeMarketoPush_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "initializeMarketoPush", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initializeMarketoPush_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_initializeSDK_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='initializeSDK' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("initializeSDK", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void InitializeSDK (string p0, string p1)
		{
			if (id_initializeSDK_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_initializeSDK_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "initializeSDK", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initializeSDK_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_onStart_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='onStart' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onStart", "(Landroid/app/Activity;)V", "")]
		public static unsafe void OnStart (global::Android.App.Activity p0)
		{
			if (id_onStart_Landroid_app_Activity_ == IntPtr.Zero)
				id_onStart_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "onStart", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onStart_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_onStop_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='onStop' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onStop", "(Landroid/app/Activity;)V", "")]
		public static unsafe void OnStop (global::Android.App.Activity p0)
		{
			if (id_onStop_Landroid_app_Activity_ == IntPtr.Zero)
				id_onStop_Landroid_app_Activity_ = JNIEnv.GetStaticMethodID (class_ref, "onStop", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_onStop_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_removeSecureSignature;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='removeSecureSignature' and count(parameter)=0]"
		[Register ("removeSecureSignature", "()V", "")]
		public unsafe void RemoveSecureSignature ()
		{
			if (id_removeSecureSignature == IntPtr.Zero)
				id_removeSecureSignature = JNIEnv.GetMethodID (class_ref, "removeSecureSignature", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeSecureSignature);
			} finally {
			}
		}

		static IntPtr id_reportAction_Ljava_lang_String_Lcom_marketo_MarketoActionMetaData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='reportAction' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.marketo.MarketoActionMetaData']]"
		[Register ("reportAction", "(Ljava/lang/String;Lcom/marketo/MarketoActionMetaData;)V", "")]
		public static unsafe void ReportAction (string p0, global::Com.Marketo.MarketoActionMetaData p1)
		{
			if (id_reportAction_Ljava_lang_String_Lcom_marketo_MarketoActionMetaData_ == IntPtr.Zero)
				id_reportAction_Ljava_lang_String_Lcom_marketo_MarketoActionMetaData_ = JNIEnv.GetStaticMethodID (class_ref, "reportAction", "(Ljava/lang/String;Lcom/marketo/MarketoActionMetaData;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reportAction_Ljava_lang_String_Lcom_marketo_MarketoActionMetaData_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_reportAll;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='reportAll' and count(parameter)=0]"
		[Register ("reportAll", "()V", "")]
		public static unsafe void ReportAll ()
		{
			if (id_reportAll == IntPtr.Zero)
				id_reportAll = JNIEnv.GetStaticMethodID (class_ref, "reportAll", "()V");
			try {
				JNIEnv.CallStaticVoidMethod  (class_ref, id_reportAll);
			} finally {
			}
		}

		static IntPtr id_setPhonegapCurrentActivity_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='setPhonegapCurrentActivity' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("setPhonegapCurrentActivity", "(Landroid/app/Activity;)V", "")]
		public unsafe void SetPhonegapCurrentActivity (global::Android.App.Activity p0)
		{
			if (id_setPhonegapCurrentActivity_Landroid_app_Activity_ == IntPtr.Zero)
				id_setPhonegapCurrentActivity_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "setPhonegapCurrentActivity", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPhonegapCurrentActivity_Landroid_app_Activity_, __args);
			} finally {
			}
		}

		static IntPtr id_setSecureSignature_Lcom_marketo_MarketoConfig_SecureMode_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='setSecureSignature' and count(parameter)=1 and parameter[1][@type='com.marketo.MarketoConfig.SecureMode']]"
		[Register ("setSecureSignature", "(Lcom/marketo/MarketoConfig$SecureMode;)V", "")]
		public unsafe void SetSecureSignature (global::Com.Marketo.MarketoConfig.SecureMode p0)
		{
			if (id_setSecureSignature_Lcom_marketo_MarketoConfig_SecureMode_ == IntPtr.Zero)
				id_setSecureSignature_Lcom_marketo_MarketoConfig_SecureMode_ = JNIEnv.GetMethodID (class_ref, "setSecureSignature", "(Lcom/marketo/MarketoConfig$SecureMode;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSecureSignature_Lcom_marketo_MarketoConfig_SecureMode_, __args);
			} finally {
			}
		}

		static IntPtr id_uninitializeMarketoPush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='uninitializeMarketoPush' and count(parameter)=0]"
		[Register ("uninitializeMarketoPush", "()V", "")]
		public unsafe void UninitializeMarketoPush ()
		{
			if (id_uninitializeMarketoPush == IntPtr.Zero)
				id_uninitializeMarketoPush = JNIEnv.GetMethodID (class_ref, "uninitializeMarketoPush", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_uninitializeMarketoPush);
			} finally {
			}
		}

		static IntPtr id_updateInAppList_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='Marketo']/method[@name='updateInAppList' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("updateInAppList", "(Landroid/content/Context;)V", "")]
		public static unsafe void UpdateInAppList (global::Android.Content.Context p0)
		{
			if (id_updateInAppList_Landroid_content_Context_ == IntPtr.Zero)
				id_updateInAppList_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "updateInAppList", "(Landroid/content/Context;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_updateInAppList_Landroid_content_Context_, __args);
			} finally {
			}
		}

	}
}
