using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Marketo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.marketo']/class[@name='MarketoActionMetaData']"
	[global::Android.Runtime.Register ("com/marketo/MarketoActionMetaData", DoNotGenerateAcw=true)]
	public partial class MarketoActionMetaData : global::Org.Json.JSONObject {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoActionMetaData']/field[@name='KEY_ACTION_DETAILS']"
		[Register ("KEY_ACTION_DETAILS")]
		public const string KeyActionDetails = (string) "Action Details";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoActionMetaData']/field[@name='KEY_ACTION_LENGTH']"
		[Register ("KEY_ACTION_LENGTH")]
		public const string KeyActionLength = (string) "Action Length";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoActionMetaData']/field[@name='KEY_ACTION_METRIC']"
		[Register ("KEY_ACTION_METRIC")]
		public const string KeyActionMetric = (string) "Action Metric";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo']/class[@name='MarketoActionMetaData']/field[@name='KEY_ACTION_TYPE']"
		[Register ("KEY_ACTION_TYPE")]
		public const string KeyActionType = (string) "Action Type";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/marketo/MarketoActionMetaData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MarketoActionMetaData); }
		}

		protected MarketoActionMetaData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.marketo']/class[@name='MarketoActionMetaData']/constructor[@name='MarketoActionMetaData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MarketoActionMetaData ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MarketoActionMetaData)) {
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

		static Delegate cb_setActionDetails_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetActionDetails_Ljava_lang_String_Handler ()
		{
			if (cb_setActionDetails_Ljava_lang_String_ == null)
				cb_setActionDetails_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActionDetails_Ljava_lang_String_);
			return cb_setActionDetails_Ljava_lang_String_;
		}

		static void n_SetActionDetails_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoActionMetaData __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoActionMetaData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActionDetails (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setActionDetails_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoActionMetaData']/method[@name='setActionDetails' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setActionDetails", "(Ljava/lang/String;)V", "GetSetActionDetails_Ljava_lang_String_Handler")]
		public virtual unsafe void SetActionDetails (string p0)
		{
			if (id_setActionDetails_Ljava_lang_String_ == IntPtr.Zero)
				id_setActionDetails_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setActionDetails", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActionDetails_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActionDetails", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setActionLength_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetActionLength_Ljava_lang_String_Handler ()
		{
			if (cb_setActionLength_Ljava_lang_String_ == null)
				cb_setActionLength_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActionLength_Ljava_lang_String_);
			return cb_setActionLength_Ljava_lang_String_;
		}

		static void n_SetActionLength_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoActionMetaData __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoActionMetaData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActionLength (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setActionLength_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoActionMetaData']/method[@name='setActionLength' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setActionLength", "(Ljava/lang/String;)V", "GetSetActionLength_Ljava_lang_String_Handler")]
		public virtual unsafe void SetActionLength (string p0)
		{
			if (id_setActionLength_Ljava_lang_String_ == IntPtr.Zero)
				id_setActionLength_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setActionLength", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActionLength_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActionLength", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setActionMetric_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetActionMetric_Ljava_lang_String_Handler ()
		{
			if (cb_setActionMetric_Ljava_lang_String_ == null)
				cb_setActionMetric_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActionMetric_Ljava_lang_String_);
			return cb_setActionMetric_Ljava_lang_String_;
		}

		static void n_SetActionMetric_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoActionMetaData __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoActionMetaData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActionMetric (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setActionMetric_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoActionMetaData']/method[@name='setActionMetric' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setActionMetric", "(Ljava/lang/String;)V", "GetSetActionMetric_Ljava_lang_String_Handler")]
		public virtual unsafe void SetActionMetric (string p0)
		{
			if (id_setActionMetric_Ljava_lang_String_ == IntPtr.Zero)
				id_setActionMetric_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setActionMetric", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActionMetric_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActionMetric", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setActionType_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetActionType_Ljava_lang_String_Handler ()
		{
			if (cb_setActionType_Ljava_lang_String_ == null)
				cb_setActionType_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActionType_Ljava_lang_String_);
			return cb_setActionType_Ljava_lang_String_;
		}

		static void n_SetActionType_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoActionMetaData __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoActionMetaData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActionType (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setActionType_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoActionMetaData']/method[@name='setActionType' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setActionType", "(Ljava/lang/String;)V", "GetSetActionType_Ljava_lang_String_Handler")]
		public virtual unsafe void SetActionType (string p0)
		{
			if (id_setActionType_Ljava_lang_String_ == IntPtr.Zero)
				id_setActionType_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setActionType", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActionType_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActionType", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
