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
	[Register("MarketoLead", true)]
	public unsafe partial class MarketoLead : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MarketoLead");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MarketoLead () : base (NSObjectFlag.Empty)
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
		protected MarketoLead (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MarketoLead (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setAddress:")]
		[CompilerGenerated]
		public virtual void SetAddress (string address)
		{
			if (address == null)
				throw new ArgumentNullException ("address");
			var nsaddress = NSString.CreateNative (address);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAddress:"), nsaddress);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAddress:"), nsaddress);
			}
			NSString.ReleaseNative (nsaddress);
			
		}
		
		[Export ("setBirthDay:")]
		[CompilerGenerated]
		public virtual void SetBirthDay (string birthday)
		{
			if (birthday == null)
				throw new ArgumentNullException ("birthday");
			var nsbirthday = NSString.CreateNative (birthday);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBirthDay:"), nsbirthday);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBirthDay:"), nsbirthday);
			}
			NSString.ReleaseNative (nsbirthday);
			
		}
		
		[Export ("setCity:")]
		[CompilerGenerated]
		public virtual void SetCity (string city)
		{
			if (city == null)
				throw new ArgumentNullException ("city");
			var nscity = NSString.CreateNative (city);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCity:"), nscity);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCity:"), nscity);
			}
			NSString.ReleaseNative (nscity);
			
		}
		
		[Export ("setCountry:")]
		[CompilerGenerated]
		public virtual void SetCountry (string country)
		{
			if (country == null)
				throw new ArgumentNullException ("country");
			var nscountry = NSString.CreateNative (country);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCountry:"), nscountry);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCountry:"), nscountry);
			}
			NSString.ReleaseNative (nscountry);
			
		}
		
		[Export ("setEmail:")]
		[CompilerGenerated]
		public virtual void SetEmail (string email)
		{
			if (email == null)
				throw new ArgumentNullException ("email");
			var nsemail = NSString.CreateNative (email);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setEmail:"), nsemail);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setEmail:"), nsemail);
			}
			NSString.ReleaseNative (nsemail);
			
		}
		
		[Export ("setFacebookId:")]
		[CompilerGenerated]
		public virtual void SetFacebookId (string facebookId)
		{
			if (facebookId == null)
				throw new ArgumentNullException ("facebookId");
			var nsfacebookId = NSString.CreateNative (facebookId);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFacebookId:"), nsfacebookId);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFacebookId:"), nsfacebookId);
			}
			NSString.ReleaseNative (nsfacebookId);
			
		}
		
		[Export ("setFacebookProfilePicURL:")]
		[CompilerGenerated]
		public virtual void SetFacebookProfilePicURL (string url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			var nsurl = NSString.CreateNative (url);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFacebookProfilePicURL:"), nsurl);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFacebookProfilePicURL:"), nsurl);
			}
			NSString.ReleaseNative (nsurl);
			
		}
		
		[Export ("setFacebookProfileURL:")]
		[CompilerGenerated]
		public virtual void SetFacebookProfileURL (string url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			var nsurl = NSString.CreateNative (url);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFacebookProfileURL:"), nsurl);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFacebookProfileURL:"), nsurl);
			}
			NSString.ReleaseNative (nsurl);
			
		}
		
		[Export ("setFieldName:withValue:")]
		[CompilerGenerated]
		public virtual void SetFieldName (string name, string value)
		{
			if (name == null)
				throw new ArgumentNullException ("name");
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsname = NSString.CreateNative (name);
			var nsvalue = NSString.CreateNative (value);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setFieldName:withValue:"), nsname, nsvalue);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setFieldName:withValue:"), nsname, nsvalue);
			}
			NSString.ReleaseNative (nsname);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[Export ("setFirstName:")]
		[CompilerGenerated]
		public virtual void SetFirstName (string firstName)
		{
			if (firstName == null)
				throw new ArgumentNullException ("firstName");
			var nsfirstName = NSString.CreateNative (firstName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFirstName:"), nsfirstName);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFirstName:"), nsfirstName);
			}
			NSString.ReleaseNative (nsfirstName);
			
		}
		
		[Export ("setGender:")]
		[CompilerGenerated]
		public virtual void SetGender (string gender)
		{
			if (gender == null)
				throw new ArgumentNullException ("gender");
			var nsgender = NSString.CreateNative (gender);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setGender:"), nsgender);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setGender:"), nsgender);
			}
			NSString.ReleaseNative (nsgender);
			
		}
		
		[Export ("setLastName:")]
		[CompilerGenerated]
		public virtual void SetLastName (string lastName)
		{
			if (lastName == null)
				throw new ArgumentNullException ("lastName");
			var nslastName = NSString.CreateNative (lastName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLastName:"), nslastName);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLastName:"), nslastName);
			}
			NSString.ReleaseNative (nslastName);
			
		}
		
		[Export ("setLeadSource:")]
		[CompilerGenerated]
		public virtual void SetLeadSource (string leadSource)
		{
			if (leadSource == null)
				throw new ArgumentNullException ("leadSource");
			var nsleadSource = NSString.CreateNative (leadSource);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLeadSource:"), nsleadSource);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLeadSource:"), nsleadSource);
			}
			NSString.ReleaseNative (nsleadSource);
			
		}
		
		[Export ("setLinkedInId:")]
		[CompilerGenerated]
		public virtual void SetLinkedInId (string LinkedInId)
		{
			if (LinkedInId == null)
				throw new ArgumentNullException ("LinkedInId");
			var nsLinkedInId = NSString.CreateNative (LinkedInId);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLinkedInId:"), nsLinkedInId);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLinkedInId:"), nsLinkedInId);
			}
			NSString.ReleaseNative (nsLinkedInId);
			
		}
		
		[Export ("setPostalCode:")]
		[CompilerGenerated]
		public virtual void SetPostalCode (string postalCode)
		{
			if (postalCode == null)
				throw new ArgumentNullException ("postalCode");
			var nspostalCode = NSString.CreateNative (postalCode);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPostalCode:"), nspostalCode);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPostalCode:"), nspostalCode);
			}
			NSString.ReleaseNative (nspostalCode);
			
		}
		
		[Export ("setState:")]
		[CompilerGenerated]
		public virtual void SetState (string state)
		{
			if (state == null)
				throw new ArgumentNullException ("state");
			var nsstate = NSString.CreateNative (state);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setState:"), nsstate);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setState:"), nsstate);
			}
			NSString.ReleaseNative (nsstate);
			
		}
		
		[Export ("setTwitterId:")]
		[CompilerGenerated]
		public virtual void SetTwitterId (string twitterId)
		{
			if (twitterId == null)
				throw new ArgumentNullException ("twitterId");
			var nstwitterId = NSString.CreateNative (twitterId);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTwitterId:"), nstwitterId);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTwitterId:"), nstwitterId);
			}
			NSString.ReleaseNative (nstwitterId);
			
		}
		
		[Export ("userData")]
		[CompilerGenerated]
		public virtual NSDictionary userData ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userData")));
			} else {
				return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userData")));
			}
		}
		
	} /* class MarketoLead */
}
