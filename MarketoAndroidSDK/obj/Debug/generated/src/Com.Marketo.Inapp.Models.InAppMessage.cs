using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Marketo.Inapp.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']"
	[global::Android.Runtime.Register ("com/marketo/inapp/models/InAppMessage", DoNotGenerateAcw=true)]
	public sealed partial class InAppMessage : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/marketo/inapp/models/InAppMessage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (InAppMessage); }
		}

		internal InAppMessage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/constructor[@name='InAppMessage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InAppMessage ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (InAppMessage)) {
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

		static IntPtr id_ctor_Lorg_json_JSONObject_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/constructor[@name='InAppMessage' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(Lorg/json/JSONObject;Landroid/content/Context;)V", "")]
		public unsafe InAppMessage (global::Org.Json.JSONObject p0, global::Android.Content.Context p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (InAppMessage)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lorg/json/JSONObject;Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lorg/json/JSONObject;Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Lorg_json_JSONObject_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Lorg_json_JSONObject_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/json/JSONObject;Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_json_JSONObject_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lorg_json_JSONObject_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_b;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Z", "")]
		public unsafe bool B ()
		{
			if (id_b == IntPtr.Zero)
				id_b = JNIEnv.GetMethodID (class_ref, "b", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_b);
			} finally {
			}
		}

		static IntPtr id_c;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Ljava/lang/String;", "")]
		public unsafe string C ()
		{
			if (id_c == IntPtr.Zero)
				id_c = JNIEnv.GetMethodID (class_ref, "c", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_c), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_d;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()V", "")]
		public unsafe void D ()
		{
			if (id_d == IntPtr.Zero)
				id_d = JNIEnv.GetMethodID (class_ref, "d", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_d);
			} finally {
			}
		}

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
			} finally {
			}
		}

		static IntPtr id_e;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/method[@name='e' and count(parameter)=0]"
		[Register ("e", "()V", "")]
		public unsafe void E ()
		{
			if (id_e == IntPtr.Zero)
				id_e = JNIEnv.GetMethodID (class_ref, "e", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_e);
			} finally {
			}
		}

		static IntPtr id_f;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/method[@name='f' and count(parameter)=0]"
		[Register ("f", "()V", "")]
		public unsafe void F ()
		{
			if (id_f == IntPtr.Zero)
				id_f = JNIEnv.GetMethodID (class_ref, "f", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_f);
			} finally {
			}
		}

		static IntPtr id_g;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/method[@name='g' and count(parameter)=0]"
		[Register ("g", "()V", "")]
		public unsafe void G ()
		{
			if (id_g == IntPtr.Zero)
				id_g = JNIEnv.GetMethodID (class_ref, "g", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_g);
			} finally {
			}
		}

		static IntPtr id_h;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/method[@name='h' and count(parameter)=0]"
		[Register ("h", "()V", "")]
		public unsafe void H ()
		{
			if (id_h == IntPtr.Zero)
				id_h = JNIEnv.GetMethodID (class_ref, "h", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_h);
			} finally {
			}
		}

		static IntPtr id_i;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/method[@name='i' and count(parameter)=0]"
		[Register ("i", "()V", "")]
		public unsafe void I ()
		{
			if (id_i == IntPtr.Zero)
				id_i = JNIEnv.GetMethodID (class_ref, "i", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_i);
			} finally {
			}
		}

		static IntPtr id_j;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/method[@name='j' and count(parameter)=0]"
		[Register ("j", "()Z", "")]
		public unsafe bool J ()
		{
			if (id_j == IntPtr.Zero)
				id_j = JNIEnv.GetMethodID (class_ref, "j", "()Z");
			try {
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_j);
			} finally {
			}
		}

		static IntPtr id_k;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/method[@name='k' and count(parameter)=0]"
		[Register ("k", "()Lcom/marketo/inapp/models/InAppBackground;", "")]
		public unsafe global::Com.Marketo.Inapp.Models.InAppBackground K ()
		{
			if (id_k == IntPtr.Zero)
				id_k = JNIEnv.GetMethodID (class_ref, "k", "()Lcom/marketo/inapp/models/InAppBackground;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Marketo.Inapp.Models.InAppBackground> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_k), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_l;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/method[@name='l' and count(parameter)=0]"
		[Register ("l", "()Lcom/marketo/inapp/models/InAppImage;", "")]
		public unsafe global::Com.Marketo.Inapp.Models.InAppImage L ()
		{
			if (id_l == IntPtr.Zero)
				id_l = JNIEnv.GetMethodID (class_ref, "l", "()Lcom/marketo/inapp/models/InAppImage;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Marketo.Inapp.Models.InAppImage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_l), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_m;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/method[@name='m' and count(parameter)=0]"
		[Register ("m", "()Lcom/marketo/inapp/models/InAppCloseButton;", "")]
		public unsafe global::Com.Marketo.Inapp.Models.InAppCloseButton M ()
		{
			if (id_m == IntPtr.Zero)
				id_m = JNIEnv.GetMethodID (class_ref, "m", "()Lcom/marketo/inapp/models/InAppCloseButton;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Marketo.Inapp.Models.InAppCloseButton> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_m), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_n;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/method[@name='n' and count(parameter)=0]"
		[Register ("n", "()Lcom/marketo/inapp/models/InAppText;", "")]
		public unsafe global::Com.Marketo.Inapp.Models.InAppText N ()
		{
			if (id_n == IntPtr.Zero)
				id_n = JNIEnv.GetMethodID (class_ref, "n", "()Lcom/marketo/inapp/models/InAppText;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Marketo.Inapp.Models.InAppText> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_n), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_o;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/method[@name='o' and count(parameter)=0]"
		[Register ("o", "()Lcom/marketo/inapp/models/InAppButton;", "")]
		public unsafe global::Com.Marketo.Inapp.Models.InAppButton O ()
		{
			if (id_o == IntPtr.Zero)
				id_o = JNIEnv.GetMethodID (class_ref, "o", "()Lcom/marketo/inapp/models/InAppButton;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Marketo.Inapp.Models.InAppButton> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_o), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_p;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/method[@name='p' and count(parameter)=0]"
		[Register ("p", "()Lcom/marketo/inapp/models/InAppText;", "")]
		public unsafe global::Com.Marketo.Inapp.Models.InAppText P ()
		{
			if (id_p == IntPtr.Zero)
				id_p = JNIEnv.GetMethodID (class_ref, "p", "()Lcom/marketo/inapp/models/InAppText;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Marketo.Inapp.Models.InAppText> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_p), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_q;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/method[@name='q' and count(parameter)=0]"
		[Register ("q", "()Lcom/marketo/inapp/models/InAppButton;", "")]
		public unsafe global::Com.Marketo.Inapp.Models.InAppButton Q ()
		{
			if (id_q == IntPtr.Zero)
				id_q = JNIEnv.GetMethodID (class_ref, "q", "()Lcom/marketo/inapp/models/InAppButton;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Marketo.Inapp.Models.InAppButton> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_q), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.marketo.inapp.models']/class[@name='InAppMessage']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
			} finally {
			}
		}

	}
}
