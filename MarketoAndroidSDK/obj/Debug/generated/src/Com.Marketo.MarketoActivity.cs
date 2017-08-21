using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Marketo {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.marketo']/class[@name='MarketoActivity']"
	[global::Android.Runtime.Register ("com/marketo/MarketoActivity", DoNotGenerateAcw=true)]
	public partial class MarketoActivity : global::Android.App.Activity {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/marketo/MarketoActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MarketoActivity); }
		}

		protected MarketoActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.marketo']/class[@name='MarketoActivity']/constructor[@name='MarketoActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MarketoActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (MarketoActivity)) {
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

		static Delegate cb_a_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_os_Bundle_Handler ()
		{
			if (cb_a_Landroid_os_Bundle_ == null)
				cb_a_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_A_Landroid_os_Bundle_);
			return cb_a_Landroid_os_Bundle_;
		}

		static IntPtr n_A_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Marketo.MarketoActivity __this = global::Java.Lang.Object.GetObject<global::Com.Marketo.MarketoActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.A (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_a_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo']/class[@name='MarketoActivity']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("a", "(Landroid/os/Bundle;)Ljava/lang/String;", "GetA_Landroid_os_Bundle_Handler")]
		public virtual unsafe string A (global::Android.OS.Bundle p0)
		{
			if (id_a_Landroid_os_Bundle_ == IntPtr.Zero)
				id_a_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "a", "(Landroid/os/Bundle;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_a_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "a", "(Landroid/os/Bundle;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
