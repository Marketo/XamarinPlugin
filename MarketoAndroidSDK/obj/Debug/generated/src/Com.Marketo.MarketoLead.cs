using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Marketo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']"
	[global::Android.Runtime.Register ("com/marketo/MarketoLead", DoNotGenerateAcw=true)]
	public partial class MarketoLead : global::Org.Json.JSONObject {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/field[@name='KEY_ADDRESS']"
		[Register ("KEY_ADDRESS")]
		public const string KeyAddress = (string) "address";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/field[@name='KEY_BIRTHDAY']"
		[Register ("KEY_BIRTHDAY")]
		public const string KeyBirthday = (string) "dateOfBirth";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/field[@name='KEY_CITY']"
		[Register ("KEY_CITY")]
		public const string KeyCity = (string) "city";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/field[@name='KEY_COUNTRY']"
		[Register ("KEY_COUNTRY")]
		public const string KeyCountry = (string) "country";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/field[@name='KEY_EMAIL']"
		[Register ("KEY_EMAIL")]
		public const string KeyEmail = (string) "email";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/field[@name='KEY_FACEBOOK']"
		[Register ("KEY_FACEBOOK")]
		public const string KeyFacebook = (string) "facebookId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/field[@name='KEY_FACEBOOK_PROFILE_PIC']"
		[Register ("KEY_FACEBOOK_PROFILE_PIC")]
		public const string KeyFacebookProfilePic = (string) "facebookPhotoURL";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/field[@name='KEY_FACEBOOK_PROFILE_URL']"
		[Register ("KEY_FACEBOOK_PROFILE_URL")]
		public const string KeyFacebookProfileUrl = (string) "facebookProfileURL";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/field[@name='KEY_FIRST_NAME']"
		[Register ("KEY_FIRST_NAME")]
		public const string KeyFirstName = (string) "firstName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/field[@name='KEY_GENDER']"
		[Register ("KEY_GENDER")]
		public const string KeyGender = (string) "gender";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/field[@name='KEY_LAST_NAME']"
		[Register ("KEY_LAST_NAME")]
		public const string KeyLastName = (string) "lastName";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/field[@name='KEY_LEAD_SOURCE']"
		[Register ("KEY_LEAD_SOURCE")]
		public const string KeyLeadSource = (string) "leadSource";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/field[@name='KEY_LINKEDIN']"
		[Register ("KEY_LINKEDIN")]
		public const string KeyLinkedin = (string) "linkedinId";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/field[@name='KEY_POSTAL_CODE']"
		[Register ("KEY_POSTAL_CODE")]
		public const string KeyPostalCode = (string) "postalCode";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/field[@name='KEY_STATE']"
		[Register ("KEY_STATE")]
		public const string KeyState = (string) "state";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/field[@name='KEY_TWITTER']"
		[Register ("KEY_TWITTER")]
		public const string KeyTwitter = (string) "twitterId";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/marketo/MarketoLead", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MarketoLead); }
		}

		protected MarketoLead (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/constructor[@name='MarketoLead' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MarketoLead ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MarketoLead)) {
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

		static Delegate cb_setAddress_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAddress_Ljava_lang_String_Handler ()
		{
			if (cb_setAddress_Ljava_lang_String_ == null)
				cb_setAddress_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAddress_Ljava_lang_String_);
			return cb_setAddress_Ljava_lang_String_;
		}

		static void n_SetAddress_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoLead __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoLead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAddress (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAddress_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/method[@name='setAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAddress", "(Ljava/lang/String;)V", "GetSetAddress_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAddress (string p0)
		{
			if (id_setAddress_Ljava_lang_String_ == IntPtr.Zero)
				id_setAddress_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAddress", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAddress_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAddress", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setBirthDay_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBirthDay_Ljava_lang_String_Handler ()
		{
			if (cb_setBirthDay_Ljava_lang_String_ == null)
				cb_setBirthDay_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBirthDay_Ljava_lang_String_);
			return cb_setBirthDay_Ljava_lang_String_;
		}

		static void n_SetBirthDay_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoLead __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoLead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBirthDay (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBirthDay_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/method[@name='setBirthDay' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setBirthDay", "(Ljava/lang/String;)V", "GetSetBirthDay_Ljava_lang_String_Handler")]
		public virtual unsafe void SetBirthDay (string p0)
		{
			if (id_setBirthDay_Ljava_lang_String_ == IntPtr.Zero)
				id_setBirthDay_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBirthDay", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBirthDay_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBirthDay", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCity_Ljava_lang_String_Handler ()
		{
			if (cb_setCity_Ljava_lang_String_ == null)
				cb_setCity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCity_Ljava_lang_String_);
			return cb_setCity_Ljava_lang_String_;
		}

		static void n_SetCity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoLead __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoLead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCity (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCity_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/method[@name='setCity' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCity", "(Ljava/lang/String;)V", "GetSetCity_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCity (string p0)
		{
			if (id_setCity_Ljava_lang_String_ == IntPtr.Zero)
				id_setCity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCity", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCity_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCity", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCountry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCountry_Ljava_lang_String_Handler ()
		{
			if (cb_setCountry_Ljava_lang_String_ == null)
				cb_setCountry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCountry_Ljava_lang_String_);
			return cb_setCountry_Ljava_lang_String_;
		}

		static void n_SetCountry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoLead __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoLead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCountry (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCountry_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/method[@name='setCountry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCountry", "(Ljava/lang/String;)V", "GetSetCountry_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCountry (string p0)
		{
			if (id_setCountry_Ljava_lang_String_ == IntPtr.Zero)
				id_setCountry_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCountry", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCountry_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCountry", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCustomField_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCustomField_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setCustomField_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setCustomField_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomField_Ljava_lang_String_Ljava_lang_String_);
			return cb_setCustomField_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetCustomField_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Marketo.MarketoLead __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoLead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomField (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setCustomField_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/method[@name='setCustomField' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setCustomField", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetCustomField_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCustomField (string p0, string p1)
		{
			if (id_setCustomField_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setCustomField_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCustomField", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCustomField_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomField", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

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
			global::Com.Marketo.MarketoLead __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoLead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetEmail (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setEmail_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/method[@name='setEmail' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setEmail", "(Ljava/lang/String;)V", "GetSetEmail_Ljava_lang_String_Handler")]
		public virtual unsafe void SetEmail (string p0)
		{
			if (id_setEmail_Ljava_lang_String_ == IntPtr.Zero)
				id_setEmail_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setEmail", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEmail_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEmail", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setFacebookId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFacebookId_Ljava_lang_String_Handler ()
		{
			if (cb_setFacebookId_Ljava_lang_String_ == null)
				cb_setFacebookId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFacebookId_Ljava_lang_String_);
			return cb_setFacebookId_Ljava_lang_String_;
		}

		static void n_SetFacebookId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoLead __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoLead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFacebookId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFacebookId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/method[@name='setFacebookId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFacebookId", "(Ljava/lang/String;)V", "GetSetFacebookId_Ljava_lang_String_Handler")]
		public virtual unsafe void SetFacebookId (string p0)
		{
			if (id_setFacebookId_Ljava_lang_String_ == IntPtr.Zero)
				id_setFacebookId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFacebookId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFacebookId_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFacebookId", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setFacebookProfilePicURL_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFacebookProfilePicURL_Ljava_lang_String_Handler ()
		{
			if (cb_setFacebookProfilePicURL_Ljava_lang_String_ == null)
				cb_setFacebookProfilePicURL_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFacebookProfilePicURL_Ljava_lang_String_);
			return cb_setFacebookProfilePicURL_Ljava_lang_String_;
		}

		static void n_SetFacebookProfilePicURL_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoLead __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoLead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFacebookProfilePicURL (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFacebookProfilePicURL_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/method[@name='setFacebookProfilePicURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFacebookProfilePicURL", "(Ljava/lang/String;)V", "GetSetFacebookProfilePicURL_Ljava_lang_String_Handler")]
		public virtual unsafe void SetFacebookProfilePicURL (string p0)
		{
			if (id_setFacebookProfilePicURL_Ljava_lang_String_ == IntPtr.Zero)
				id_setFacebookProfilePicURL_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFacebookProfilePicURL", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFacebookProfilePicURL_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFacebookProfilePicURL", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setFacebookProfileURL_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFacebookProfileURL_Ljava_lang_String_Handler ()
		{
			if (cb_setFacebookProfileURL_Ljava_lang_String_ == null)
				cb_setFacebookProfileURL_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFacebookProfileURL_Ljava_lang_String_);
			return cb_setFacebookProfileURL_Ljava_lang_String_;
		}

		static void n_SetFacebookProfileURL_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoLead __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoLead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFacebookProfileURL (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFacebookProfileURL_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/method[@name='setFacebookProfileURL' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFacebookProfileURL", "(Ljava/lang/String;)V", "GetSetFacebookProfileURL_Ljava_lang_String_Handler")]
		public virtual unsafe void SetFacebookProfileURL (string p0)
		{
			if (id_setFacebookProfileURL_Ljava_lang_String_ == IntPtr.Zero)
				id_setFacebookProfileURL_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFacebookProfileURL", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFacebookProfileURL_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFacebookProfileURL", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setFirstName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFirstName_Ljava_lang_String_Handler ()
		{
			if (cb_setFirstName_Ljava_lang_String_ == null)
				cb_setFirstName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFirstName_Ljava_lang_String_);
			return cb_setFirstName_Ljava_lang_String_;
		}

		static void n_SetFirstName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoLead __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoLead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFirstName (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFirstName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/method[@name='setFirstName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setFirstName", "(Ljava/lang/String;)V", "GetSetFirstName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetFirstName (string p0)
		{
			if (id_setFirstName_Ljava_lang_String_ == IntPtr.Zero)
				id_setFirstName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setFirstName", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFirstName_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFirstName", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setGender_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetGender_Ljava_lang_String_Handler ()
		{
			if (cb_setGender_Ljava_lang_String_ == null)
				cb_setGender_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGender_Ljava_lang_String_);
			return cb_setGender_Ljava_lang_String_;
		}

		static void n_SetGender_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoLead __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoLead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetGender (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setGender_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/method[@name='setGender' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setGender", "(Ljava/lang/String;)V", "GetSetGender_Ljava_lang_String_Handler")]
		public virtual unsafe void SetGender (string p0)
		{
			if (id_setGender_Ljava_lang_String_ == IntPtr.Zero)
				id_setGender_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setGender", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGender_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGender", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setLastName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLastName_Ljava_lang_String_Handler ()
		{
			if (cb_setLastName_Ljava_lang_String_ == null)
				cb_setLastName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastName_Ljava_lang_String_);
			return cb_setLastName_Ljava_lang_String_;
		}

		static void n_SetLastName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoLead __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoLead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLastName (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLastName_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/method[@name='setLastName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLastName", "(Ljava/lang/String;)V", "GetSetLastName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetLastName (string p0)
		{
			if (id_setLastName_Ljava_lang_String_ == IntPtr.Zero)
				id_setLastName_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLastName", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastName_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastName", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setLeadSource_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLeadSource_Ljava_lang_String_Handler ()
		{
			if (cb_setLeadSource_Ljava_lang_String_ == null)
				cb_setLeadSource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLeadSource_Ljava_lang_String_);
			return cb_setLeadSource_Ljava_lang_String_;
		}

		static void n_SetLeadSource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoLead __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoLead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLeadSource (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLeadSource_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/method[@name='setLeadSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLeadSource", "(Ljava/lang/String;)V", "GetSetLeadSource_Ljava_lang_String_Handler")]
		public virtual unsafe void SetLeadSource (string p0)
		{
			if (id_setLeadSource_Ljava_lang_String_ == IntPtr.Zero)
				id_setLeadSource_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLeadSource", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLeadSource_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLeadSource", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setLinkedinId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLinkedinId_Ljava_lang_String_Handler ()
		{
			if (cb_setLinkedinId_Ljava_lang_String_ == null)
				cb_setLinkedinId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLinkedinId_Ljava_lang_String_);
			return cb_setLinkedinId_Ljava_lang_String_;
		}

		static void n_SetLinkedinId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoLead __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoLead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetLinkedinId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setLinkedinId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/method[@name='setLinkedinId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setLinkedinId", "(Ljava/lang/String;)V", "GetSetLinkedinId_Ljava_lang_String_Handler")]
		public virtual unsafe void SetLinkedinId (string p0)
		{
			if (id_setLinkedinId_Ljava_lang_String_ == IntPtr.Zero)
				id_setLinkedinId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLinkedinId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLinkedinId_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLinkedinId", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setPostalCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPostalCode_Ljava_lang_String_Handler ()
		{
			if (cb_setPostalCode_Ljava_lang_String_ == null)
				cb_setPostalCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPostalCode_Ljava_lang_String_);
			return cb_setPostalCode_Ljava_lang_String_;
		}

		static void n_SetPostalCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoLead __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoLead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPostalCode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPostalCode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/method[@name='setPostalCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPostalCode", "(Ljava/lang/String;)V", "GetSetPostalCode_Ljava_lang_String_Handler")]
		public virtual unsafe void SetPostalCode (string p0)
		{
			if (id_setPostalCode_Ljava_lang_String_ == IntPtr.Zero)
				id_setPostalCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPostalCode", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPostalCode_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPostalCode", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setState_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetState_Ljava_lang_String_Handler ()
		{
			if (cb_setState_Ljava_lang_String_ == null)
				cb_setState_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetState_Ljava_lang_String_);
			return cb_setState_Ljava_lang_String_;
		}

		static void n_SetState_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoLead __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoLead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setState_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/method[@name='setState' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setState", "(Ljava/lang/String;)V", "GetSetState_Ljava_lang_String_Handler")]
		public virtual unsafe void SetState (string p0)
		{
			if (id_setState_Ljava_lang_String_ == IntPtr.Zero)
				id_setState_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setState", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setState_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setState", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setTwitterId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTwitterId_Ljava_lang_String_Handler ()
		{
			if (cb_setTwitterId_Ljava_lang_String_ == null)
				cb_setTwitterId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTwitterId_Ljava_lang_String_);
			return cb_setTwitterId_Ljava_lang_String_;
		}

		static void n_SetTwitterId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoLead __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoLead> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetTwitterId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setTwitterId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoLead']/method[@name='setTwitterId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setTwitterId", "(Ljava/lang/String;)V", "GetSetTwitterId_Ljava_lang_String_Handler")]
		public virtual unsafe void SetTwitterId (string p0)
		{
			if (id_setTwitterId_Ljava_lang_String_ == IntPtr.Zero)
				id_setTwitterId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setTwitterId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTwitterId_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTwitterId", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
