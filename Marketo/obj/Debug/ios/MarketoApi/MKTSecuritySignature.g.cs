//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace MarketoApi {
	[Register("MKTSecuritySignature", true)]
	public unsafe partial class MKTSecuritySignature : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MKTSecuritySignature");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MKTSecuritySignature () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MKTSecuritySignature (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MKTSecuritySignature (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAccessKey:signature:timestamp:email:")]
		[CompilerGenerated]
		public MKTSecuritySignature (string accessKey, string signature, string timestamp, string email)
			: base (NSObjectFlag.Empty)
		{
			if (accessKey == null)
				throw new ArgumentNullException ("accessKey");
			if (signature == null)
				throw new ArgumentNullException ("signature");
			if (timestamp == null)
				throw new ArgumentNullException ("timestamp");
			if (email == null)
				throw new ArgumentNullException ("email");
			var nsaccessKey = NSString.CreateNative (accessKey);
			var nssignature = NSString.CreateNative (signature);
			var nstimestamp = NSString.CreateNative (timestamp);
			var nsemail = NSString.CreateNative (email);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithAccessKey:signature:timestamp:email:"), nsaccessKey, nssignature, nstimestamp, nsemail), "initWithAccessKey:signature:timestamp:email:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithAccessKey:signature:timestamp:email:"), nsaccessKey, nssignature, nstimestamp, nsemail), "initWithAccessKey:signature:timestamp:email:");
			}
			NSString.ReleaseNative (nsaccessKey);
			NSString.ReleaseNative (nssignature);
			NSString.ReleaseNative (nstimestamp);
			NSString.ReleaseNative (nsemail);
			
		}
		
		[Export ("getAccessKey")]
		[CompilerGenerated]
		public virtual string getAccessKey ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getAccessKey")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAccessKey")));
			}
		}
		
		[Export ("getEmail")]
		[CompilerGenerated]
		public virtual string getEmail ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getEmail")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getEmail")));
			}
		}
		
		[Export ("getSignature")]
		[CompilerGenerated]
		public virtual string getSignature ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getSignature")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getSignature")));
			}
		}
		
		[Export ("getTimeStamp")]
		[CompilerGenerated]
		public virtual string getTimeStamp ()
		{
			if (IsDirectBinding) {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getTimeStamp")));
			} else {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getTimeStamp")));
			}
		}
		
		[Export ("isValid")]
		[CompilerGenerated]
		public virtual bool isValid ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isValid"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isValid"));
			}
		}
		
	} /* class MKTSecuritySignature */
}
