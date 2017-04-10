using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Marketo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.marketo']/class[@name='MarketoConfig']"
	[global::Android.Runtime.Register ("com/marketo/MarketoConfig", DoNotGenerateAcw=true)]
	public partial class MarketoConfig : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.marketo']/class[@name='MarketoConfig.Notification']"
		[global::Android.Runtime.Register ("com/marketo/MarketoConfig$Notification", DoNotGenerateAcw=true)]
		public partial class Notification : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/marketo/MarketoConfig$Notification", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Notification); }
			}

			protected Notification (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.marketo']/class[@name='MarketoConfig.Notification']/constructor[@name='MarketoConfig.Notification' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Notification ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Notification)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

			static Delegate cb_getNotificationLargeIcon;
#pragma warning disable 0169
			static Delegate GetGetNotificationLargeIconHandler ()
			{
				if (cb_getNotificationLargeIcon == null)
					cb_getNotificationLargeIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNotificationLargeIcon);
				return cb_getNotificationLargeIcon;
			}

			static IntPtr n_GetNotificationLargeIcon (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Marketo.MarketoConfig.Notification __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoConfig.Notification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.NotificationLargeIcon);
			}
#pragma warning restore 0169

			static Delegate cb_setNotificationLargeIcon_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetSetNotificationLargeIcon_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_setNotificationLargeIcon_Landroid_graphics_Bitmap_ == null)
					cb_setNotificationLargeIcon_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNotificationLargeIcon_Landroid_graphics_Bitmap_);
				return cb_setNotificationLargeIcon_Landroid_graphics_Bitmap_;
			}

			static void n_SetNotificationLargeIcon_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Marketo.MarketoConfig.Notification __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoConfig.Notification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.NotificationLargeIcon = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getNotificationLargeIcon;
			static IntPtr id_setNotificationLargeIcon_Landroid_graphics_Bitmap_;
			public virtual unsafe global::Android.Graphics.Bitmap NotificationLargeIcon {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoConfig.Notification']/method[@name='getNotificationLargeIcon' and count(parameter)=0]"
				[Register ("getNotificationLargeIcon", "()Landroid/graphics/Bitmap;", "GetGetNotificationLargeIconHandler")]
				get {
					if (id_getNotificationLargeIcon == IntPtr.Zero)
						id_getNotificationLargeIcon = JNIEnv.GetMethodID (class_ref, "getNotificationLargeIcon", "()Landroid/graphics/Bitmap;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNotificationLargeIcon), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotificationLargeIcon", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoConfig.Notification']/method[@name='setNotificationLargeIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
				[Register ("setNotificationLargeIcon", "(Landroid/graphics/Bitmap;)V", "GetSetNotificationLargeIcon_Landroid_graphics_Bitmap_Handler")]
				set {
					if (id_setNotificationLargeIcon_Landroid_graphics_Bitmap_ == IntPtr.Zero)
						id_setNotificationLargeIcon_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setNotificationLargeIcon", "(Landroid/graphics/Bitmap;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationLargeIcon_Landroid_graphics_Bitmap_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotificationLargeIcon", "(Landroid/graphics/Bitmap;)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_getNotificationSmallIcon;
#pragma warning disable 0169
			static Delegate GetGetNotificationSmallIconHandler ()
			{
				if (cb_getNotificationSmallIcon == null)
					cb_getNotificationSmallIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNotificationSmallIcon);
				return cb_getNotificationSmallIcon;
			}

			static int n_GetNotificationSmallIcon (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Marketo.MarketoConfig.Notification __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoConfig.Notification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NotificationSmallIcon;
			}
#pragma warning restore 0169

			static Delegate cb_setNotificationSmallIcon_I;
#pragma warning disable 0169
			static Delegate GetSetNotificationSmallIcon_IHandler ()
			{
				if (cb_setNotificationSmallIcon_I == null)
					cb_setNotificationSmallIcon_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNotificationSmallIcon_I);
				return cb_setNotificationSmallIcon_I;
			}

			static void n_SetNotificationSmallIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Marketo.MarketoConfig.Notification __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoConfig.Notification> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.NotificationSmallIcon = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getNotificationSmallIcon;
			static IntPtr id_setNotificationSmallIcon_I;
			public virtual unsafe int NotificationSmallIcon {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoConfig.Notification']/method[@name='getNotificationSmallIcon' and count(parameter)=0]"
				[Register ("getNotificationSmallIcon", "()I", "GetGetNotificationSmallIconHandler")]
				get {
					if (id_getNotificationSmallIcon == IntPtr.Zero)
						id_getNotificationSmallIcon = JNIEnv.GetMethodID (class_ref, "getNotificationSmallIcon", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNotificationSmallIcon);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNotificationSmallIcon", "()I"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoConfig.Notification']/method[@name='setNotificationSmallIcon' and count(parameter)=1 and parameter[1][@type='int']]"
				[Register ("setNotificationSmallIcon", "(I)V", "GetSetNotificationSmallIcon_IHandler")]
				set {
					if (id_setNotificationSmallIcon_I == IntPtr.Zero)
						id_setNotificationSmallIcon_I = JNIEnv.GetMethodID (class_ref, "setNotificationSmallIcon", "(I)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setNotificationSmallIcon_I, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNotificationSmallIcon", "(I)V"), __args);
					} finally {
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.marketo']/class[@name='MarketoConfig.SecureMode']"
		[global::Android.Runtime.Register ("com/marketo/MarketoConfig$SecureMode", DoNotGenerateAcw=true)]
		public partial class SecureMode : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/marketo/MarketoConfig$SecureMode", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SecureMode); }
			}

			protected SecureMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.marketo']/class[@name='MarketoConfig.SecureMode']/constructor[@name='MarketoConfig.SecureMode' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe SecureMode ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (SecureMode)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
						return;
					}

					if (id_ctor == IntPtr.Zero)
						id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
				} finally {
				}
			}

			static Delegate cb_getAccessKey;
#pragma warning disable 0169
			static Delegate GetGetAccessKeyHandler ()
			{
				if (cb_getAccessKey == null)
					cb_getAccessKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAccessKey);
				return cb_getAccessKey;
			}

			static IntPtr n_GetAccessKey (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Marketo.MarketoConfig.SecureMode __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoConfig.SecureMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.AccessKey);
			}
#pragma warning restore 0169

			static Delegate cb_setAccessKey_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetAccessKey_Ljava_lang_String_Handler ()
			{
				if (cb_setAccessKey_Ljava_lang_String_ == null)
					cb_setAccessKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAccessKey_Ljava_lang_String_);
				return cb_setAccessKey_Ljava_lang_String_;
			}

			static void n_SetAccessKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Marketo.MarketoConfig.SecureMode __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoConfig.SecureMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.AccessKey = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getAccessKey;
			static IntPtr id_setAccessKey_Ljava_lang_String_;
			public virtual unsafe string AccessKey {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoConfig.SecureMode']/method[@name='getAccessKey' and count(parameter)=0]"
				[Register ("getAccessKey", "()Ljava/lang/String;", "GetGetAccessKeyHandler")]
				get {
					if (id_getAccessKey == IntPtr.Zero)
						id_getAccessKey = JNIEnv.GetMethodID (class_ref, "getAccessKey", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAccessKey), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAccessKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoConfig.SecureMode']/method[@name='setAccessKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setAccessKey", "(Ljava/lang/String;)V", "GetSetAccessKey_Ljava_lang_String_Handler")]
				set {
					if (id_setAccessKey_Ljava_lang_String_ == IntPtr.Zero)
						id_setAccessKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAccessKey", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAccessKey_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAccessKey", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getEmail;
#pragma warning disable 0169
			static Delegate GetGetEmailHandler ()
			{
				if (cb_getEmail == null)
					cb_getEmail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEmail);
				return cb_getEmail;
			}

			static IntPtr n_GetEmail (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Marketo.MarketoConfig.SecureMode __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoConfig.SecureMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Email);
			}
#pragma warning restore 0169

			static Delegate cb_setEmail_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetEmail_Ljava_lang_String_Handler ()
			{
				if (cb_setEmail_Ljava_lang_String_ == null)
					cb_setEmail_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEmail_Ljava_lang_String_);
				return cb_setEmail_Ljava_lang_String_;
			}

			static void n_SetEmail_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Marketo.MarketoConfig.SecureMode __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoConfig.SecureMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Email = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getEmail;
			static IntPtr id_setEmail_Ljava_lang_String_;
			public virtual unsafe string Email {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoConfig.SecureMode']/method[@name='getEmail' and count(parameter)=0]"
				[Register ("getEmail", "()Ljava/lang/String;", "GetGetEmailHandler")]
				get {
					if (id_getEmail == IntPtr.Zero)
						id_getEmail = JNIEnv.GetMethodID (class_ref, "getEmail", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEmail), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEmail", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoConfig.SecureMode']/method[@name='setEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setEmail", "(Ljava/lang/String;)V", "GetSetEmail_Ljava_lang_String_Handler")]
				set {
					if (id_setEmail_Ljava_lang_String_ == IntPtr.Zero)
						id_setEmail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmail", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmail_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmail", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_isValid;
#pragma warning disable 0169
			static Delegate GetIsValidHandler ()
			{
				if (cb_isValid == null)
					cb_isValid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsValid);
				return cb_isValid;
			}

			static bool n_IsValid (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Marketo.MarketoConfig.SecureMode __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoConfig.SecureMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsValid;
			}
#pragma warning restore 0169

			static IntPtr id_isValid;
			public virtual unsafe bool IsValid {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoConfig.SecureMode']/method[@name='isValid' and count(parameter)=0]"
				[Register ("isValid", "()Z", "GetIsValidHandler")]
				get {
					if (id_isValid == IntPtr.Zero)
						id_isValid = JNIEnv.GetMethodID (class_ref, "isValid", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isValid);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isValid", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_getSignature;
#pragma warning disable 0169
			static Delegate GetGetSignatureHandler ()
			{
				if (cb_getSignature == null)
					cb_getSignature = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSignature);
				return cb_getSignature;
			}

			static IntPtr n_GetSignature (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Marketo.MarketoConfig.SecureMode __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoConfig.SecureMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.Signature);
			}
#pragma warning restore 0169

			static Delegate cb_setSignature_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetSignature_Ljava_lang_String_Handler ()
			{
				if (cb_setSignature_Ljava_lang_String_ == null)
					cb_setSignature_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSignature_Ljava_lang_String_);
				return cb_setSignature_Ljava_lang_String_;
			}

			static void n_SetSignature_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Marketo.MarketoConfig.SecureMode __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoConfig.SecureMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Signature = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getSignature;
			static IntPtr id_setSignature_Ljava_lang_String_;
			public virtual unsafe string Signature {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoConfig.SecureMode']/method[@name='getSignature' and count(parameter)=0]"
				[Register ("getSignature", "()Ljava/lang/String;", "GetGetSignatureHandler")]
				get {
					if (id_getSignature == IntPtr.Zero)
						id_getSignature = JNIEnv.GetMethodID (class_ref, "getSignature", "()Ljava/lang/String;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSignature), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSignature", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoConfig.SecureMode']/method[@name='setSignature' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
				[Register ("setSignature", "(Ljava/lang/String;)V", "GetSetSignature_Ljava_lang_String_Handler")]
				set {
					if (id_setSignature_Ljava_lang_String_ == IntPtr.Zero)
						id_setSignature_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSignature", "(Ljava/lang/String;)V");
					IntPtr native_value = JNIEnv.NewString (value);
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (native_value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSignature_Ljava_lang_String_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSignature", "(Ljava/lang/String;)V"), __args);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static Delegate cb_getTimestamp;
#pragma warning disable 0169
			static Delegate GetGetTimestampHandler ()
			{
				if (cb_getTimestamp == null)
					cb_getTimestamp = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetTimestamp);
				return cb_getTimestamp;
			}

			static long n_GetTimestamp (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Marketo.MarketoConfig.SecureMode __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoConfig.SecureMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Timestamp;
			}
#pragma warning restore 0169

			static Delegate cb_setTimestamp_J;
#pragma warning disable 0169
			static Delegate GetSetTimestamp_JHandler ()
			{
				if (cb_setTimestamp_J == null)
					cb_setTimestamp_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetTimestamp_J);
				return cb_setTimestamp_J;
			}

			static void n_SetTimestamp_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Marketo.MarketoConfig.SecureMode __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoConfig.SecureMode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Timestamp = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getTimestamp;
			static IntPtr id_setTimestamp_J;
			public virtual unsafe long Timestamp {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoConfig.SecureMode']/method[@name='getTimestamp' and count(parameter)=0]"
				[Register ("getTimestamp", "()J", "GetGetTimestampHandler")]
				get {
					if (id_getTimestamp == IntPtr.Zero)
						id_getTimestamp = JNIEnv.GetMethodID (class_ref, "getTimestamp", "()J");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getTimestamp);
						else
							return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTimestamp", "()J"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoConfig.SecureMode']/method[@name='setTimestamp' and count(parameter)=1 and parameter[1][@type='long']]"
				[Register ("setTimestamp", "(J)V", "GetSetTimestamp_JHandler")]
				set {
					if (id_setTimestamp_J == IntPtr.Zero)
						id_setTimestamp_J = JNIEnv.GetMethodID (class_ref, "setTimestamp", "(J)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimestamp_J, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTimestamp", "(J)V"), __args);
					} finally {
					}
				}
			}

		}

		protected MarketoConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
