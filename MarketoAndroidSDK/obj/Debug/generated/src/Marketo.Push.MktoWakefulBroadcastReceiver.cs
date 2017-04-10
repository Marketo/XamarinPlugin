using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Marketo.Push {

	// Metadata.xml XPath class reference: path="/api/package[@name='marketo.push']/class[@name='MktoWakefulBroadcastReceiver']"
	[global::Android.Runtime.Register ("marketo/push/MktoWakefulBroadcastReceiver", DoNotGenerateAcw=true)]
	public abstract partial class MktoWakefulBroadcastReceiver : global::Android.Content.BroadcastReceiver {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("marketo/push/MktoWakefulBroadcastReceiver", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MktoWakefulBroadcastReceiver); }
		}

		protected MktoWakefulBroadcastReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='marketo.push']/class[@name='MktoWakefulBroadcastReceiver']/constructor[@name='MktoWakefulBroadcastReceiver' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MktoWakefulBroadcastReceiver ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MktoWakefulBroadcastReceiver)) {
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

		static IntPtr id_a_Landroid_content_Context_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='marketo.push']/class[@name='MktoWakefulBroadcastReceiver']/method[@name='a' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
		[Register ("a", "(Landroid/content/Context;Landroid/content/Intent;)Landroid/content/ComponentName;", "")]
		public static unsafe global::Android.Content.ComponentName A (global::Android.Content.Context p0, global::Android.Content.Intent p1)
		{
			if (id_a_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_a_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Context;Landroid/content/Intent;)Landroid/content/ComponentName;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Android.Content.ComponentName __ret = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (JNIEnv.CallStaticObjectMethod  (class_ref, id_a_Landroid_content_Context_Landroid_content_Intent_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_a_Landroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='marketo.push']/class[@name='MktoWakefulBroadcastReceiver']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("a", "(Landroid/content/Intent;)Z", "")]
		public static unsafe bool A (global::Android.Content.Intent p0)
		{
			if (id_a_Landroid_content_Intent_ == IntPtr.Zero)
				id_a_Landroid_content_Intent_ = JNIEnv.GetStaticMethodID (class_ref, "a", "(Landroid/content/Intent;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_a_Landroid_content_Intent_, __args);
				return __ret;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("marketo/push/MktoWakefulBroadcastReceiver", DoNotGenerateAcw=true)]
	internal partial class MktoWakefulBroadcastReceiverInvoker : MktoWakefulBroadcastReceiver {

		public MktoWakefulBroadcastReceiverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MktoWakefulBroadcastReceiverInvoker); }
		}

		static IntPtr id_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public override unsafe void OnReceive (global::Android.Content.Context context, global::Android.Content.Intent intent)
		{
			if (id_onReceive_Landroid_content_Context_Landroid_content_Intent_ == IntPtr.Zero)
				id_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (intent);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onReceive_Landroid_content_Context_Landroid_content_Intent_, __args);
			} finally {
			}
		}

	}

}
