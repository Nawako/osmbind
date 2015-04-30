using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayControlView']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/ItemizedOverlayControlView", DoNotGenerateAcw=true)]
	public partial class ItemizedOverlayControlView : global::Android.Widget.LinearLayout {


		static IntPtr mCenterToButton_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayControlView']/field[@name='mCenterToButton']"
		[Register ("mCenterToButton")]
		protected global::Android.Widget.ImageButton MCenterToButton {
			get {
				if (mCenterToButton_jfieldId == IntPtr.Zero)
					mCenterToButton_jfieldId = JNIEnv.GetFieldID (class_ref, "mCenterToButton", "Landroid/widget/ImageButton;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mCenterToButton_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageButton> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCenterToButton_jfieldId == IntPtr.Zero)
					mCenterToButton_jfieldId = JNIEnv.GetFieldID (class_ref, "mCenterToButton", "Landroid/widget/ImageButton;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mCenterToButton_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mLis_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayControlView']/field[@name='mLis']"
		[Register ("mLis")]
		protected global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener MLis {
			get {
				if (mLis_jfieldId == IntPtr.Zero)
					mLis_jfieldId = JNIEnv.GetFieldID (class_ref, "mLis", "Lorg/osmdroid/views/overlay/ItemizedOverlayControlView$ItemizedOverlayControlViewListener;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mLis_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mLis_jfieldId == IntPtr.Zero)
					mLis_jfieldId = JNIEnv.GetFieldID (class_ref, "mLis", "Lorg/osmdroid/views/overlay/ItemizedOverlayControlView$ItemizedOverlayControlViewListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mLis_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mNavToButton_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayControlView']/field[@name='mNavToButton']"
		[Register ("mNavToButton")]
		protected global::Android.Widget.ImageButton MNavToButton {
			get {
				if (mNavToButton_jfieldId == IntPtr.Zero)
					mNavToButton_jfieldId = JNIEnv.GetFieldID (class_ref, "mNavToButton", "Landroid/widget/ImageButton;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mNavToButton_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageButton> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mNavToButton_jfieldId == IntPtr.Zero)
					mNavToButton_jfieldId = JNIEnv.GetFieldID (class_ref, "mNavToButton", "Landroid/widget/ImageButton;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mNavToButton_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mNextButton_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayControlView']/field[@name='mNextButton']"
		[Register ("mNextButton")]
		protected global::Android.Widget.ImageButton MNextButton {
			get {
				if (mNextButton_jfieldId == IntPtr.Zero)
					mNextButton_jfieldId = JNIEnv.GetFieldID (class_ref, "mNextButton", "Landroid/widget/ImageButton;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mNextButton_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageButton> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mNextButton_jfieldId == IntPtr.Zero)
					mNextButton_jfieldId = JNIEnv.GetFieldID (class_ref, "mNextButton", "Landroid/widget/ImageButton;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mNextButton_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mPreviousButton_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayControlView']/field[@name='mPreviousButton']"
		[Register ("mPreviousButton")]
		protected global::Android.Widget.ImageButton MPreviousButton {
			get {
				if (mPreviousButton_jfieldId == IntPtr.Zero)
					mPreviousButton_jfieldId = JNIEnv.GetFieldID (class_ref, "mPreviousButton", "Landroid/widget/ImageButton;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mPreviousButton_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageButton> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPreviousButton_jfieldId == IntPtr.Zero)
					mPreviousButton_jfieldId = JNIEnv.GetFieldID (class_ref, "mPreviousButton", "Landroid/widget/ImageButton;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mPreviousButton_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='ItemizedOverlayControlView.ItemizedOverlayControlViewListener']"
		[Register ("org/osmdroid/views/overlay/ItemizedOverlayControlView$ItemizedOverlayControlViewListener", "", "Osmdroid.Views.Overlay.ItemizedOverlayControlView/IItemizedOverlayControlViewListenerInvoker")]
		public partial interface IItemizedOverlayControlViewListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='ItemizedOverlayControlView.ItemizedOverlayControlViewListener']/method[@name='onCenter' and count(parameter)=0]"
			[Register ("onCenter", "()V", "GetOnCenterHandler:Osmdroid.Views.Overlay.ItemizedOverlayControlView/IItemizedOverlayControlViewListenerInvoker, OsmdroidAndroidBinding")]
			void OnCenter ();

			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='ItemizedOverlayControlView.ItemizedOverlayControlViewListener']/method[@name='onNavTo' and count(parameter)=0]"
			[Register ("onNavTo", "()V", "GetOnNavToHandler:Osmdroid.Views.Overlay.ItemizedOverlayControlView/IItemizedOverlayControlViewListenerInvoker, OsmdroidAndroidBinding")]
			void OnNavTo ();

			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='ItemizedOverlayControlView.ItemizedOverlayControlViewListener']/method[@name='onNext' and count(parameter)=0]"
			[Register ("onNext", "()V", "GetOnNextHandler:Osmdroid.Views.Overlay.ItemizedOverlayControlView/IItemizedOverlayControlViewListenerInvoker, OsmdroidAndroidBinding")]
			void OnNext ();

			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='ItemizedOverlayControlView.ItemizedOverlayControlViewListener']/method[@name='onPrevious' and count(parameter)=0]"
			[Register ("onPrevious", "()V", "GetOnPreviousHandler:Osmdroid.Views.Overlay.ItemizedOverlayControlView/IItemizedOverlayControlViewListenerInvoker, OsmdroidAndroidBinding")]
			void OnPrevious ();

		}

		[global::Android.Runtime.Register ("org/osmdroid/views/overlay/ItemizedOverlayControlView$ItemizedOverlayControlViewListener", DoNotGenerateAcw=true)]
		internal class IItemizedOverlayControlViewListenerInvoker : global::Java.Lang.Object, IItemizedOverlayControlViewListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/views/overlay/ItemizedOverlayControlView$ItemizedOverlayControlViewListener");
			IntPtr class_ref;

			public static IItemizedOverlayControlViewListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IItemizedOverlayControlViewListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.views.overlay.ItemizedOverlayControlView.ItemizedOverlayControlViewListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IItemizedOverlayControlViewListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IItemizedOverlayControlViewListenerInvoker); }
			}

			static Delegate cb_onCenter;
#pragma warning disable 0169
			static Delegate GetOnCenterHandler ()
			{
				if (cb_onCenter == null)
					cb_onCenter = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCenter);
				return cb_onCenter;
			}

			static void n_OnCenter (IntPtr jnienv, IntPtr native__this)
			{
				global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnCenter ();
			}
#pragma warning restore 0169

			IntPtr id_onCenter;
			public void OnCenter ()
			{
				if (id_onCenter == IntPtr.Zero)
					id_onCenter = JNIEnv.GetMethodID (class_ref, "onCenter", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onCenter);
			}

			static Delegate cb_onNavTo;
#pragma warning disable 0169
			static Delegate GetOnNavToHandler ()
			{
				if (cb_onNavTo == null)
					cb_onNavTo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnNavTo);
				return cb_onNavTo;
			}

			static void n_OnNavTo (IntPtr jnienv, IntPtr native__this)
			{
				global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnNavTo ();
			}
#pragma warning restore 0169

			IntPtr id_onNavTo;
			public void OnNavTo ()
			{
				if (id_onNavTo == IntPtr.Zero)
					id_onNavTo = JNIEnv.GetMethodID (class_ref, "onNavTo", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onNavTo);
			}

			static Delegate cb_onNext;
#pragma warning disable 0169
			static Delegate GetOnNextHandler ()
			{
				if (cb_onNext == null)
					cb_onNext = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnNext);
				return cb_onNext;
			}

			static void n_OnNext (IntPtr jnienv, IntPtr native__this)
			{
				global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnNext ();
			}
#pragma warning restore 0169

			IntPtr id_onNext;
			public void OnNext ()
			{
				if (id_onNext == IntPtr.Zero)
					id_onNext = JNIEnv.GetMethodID (class_ref, "onNext", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onNext);
			}

			static Delegate cb_onPrevious;
#pragma warning disable 0169
			static Delegate GetOnPreviousHandler ()
			{
				if (cb_onPrevious == null)
					cb_onPrevious = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPrevious);
				return cb_onPrevious;
			}

			static void n_OnPrevious (IntPtr jnienv, IntPtr native__this)
			{
				global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnPrevious ();
			}
#pragma warning restore 0169

			IntPtr id_onPrevious;
			public void OnPrevious ()
			{
				if (id_onPrevious == IntPtr.Zero)
					id_onPrevious = JNIEnv.GetMethodID (class_ref, "onPrevious", "()V");
				JNIEnv.CallVoidMethod (Handle, id_onPrevious);
			}

		}

		[global::Android.Runtime.Register ("mono/org/osmdroid/views/overlay/ItemizedOverlayControlView_ItemizedOverlayControlViewListenerImplementor")]
		internal sealed class IItemizedOverlayControlViewListenerImplementor : global::Java.Lang.Object, IItemizedOverlayControlViewListener {

			object sender;

			public IItemizedOverlayControlViewListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/osmdroid/views/overlay/ItemizedOverlayControlView_ItemizedOverlayControlViewListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler OnCenterHandler;
#pragma warning restore 0649

			public void OnCenter ()
			{
				var __h = OnCenterHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnNavToHandler;
#pragma warning restore 0649

			public void OnNavTo ()
			{
				var __h = OnNavToHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnNextHandler;
#pragma warning restore 0649

			public void OnNext ()
			{
				var __h = OnNextHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}
#pragma warning disable 0649
			public EventHandler OnPreviousHandler;
#pragma warning restore 0649

			public void OnPrevious ()
			{
				var __h = OnPreviousHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IItemizedOverlayControlViewListenerImplementor value)
			{
				return value.OnCenterHandler == null && value.OnNavToHandler == null && value.OnNextHandler == null && value.OnPreviousHandler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/ItemizedOverlayControlView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ItemizedOverlayControlView); }
		}

		protected ItemizedOverlayControlView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayControlView']/constructor[@name='ItemizedOverlayControlView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;Lorg/osmdroid/ResourceProxy;)V", "")]
		public ItemizedOverlayControlView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, global::Osmdroid.IResourceProxy pResourceProxy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ItemizedOverlayControlView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;Lorg/osmdroid/ResourceProxy;)V", new JValue (context), new JValue (attrs), new JValue (pResourceProxy)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;Lorg/osmdroid/ResourceProxy;)V", new JValue (context), new JValue (attrs), new JValue (pResourceProxy));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_Lorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_Lorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;Lorg/osmdroid/ResourceProxy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_Lorg_osmdroid_ResourceProxy_, new JValue (context), new JValue (attrs), new JValue (pResourceProxy)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_Lorg_osmdroid_ResourceProxy_, new JValue (context), new JValue (attrs), new JValue (pResourceProxy));
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayControlView']/constructor[@name='ItemizedOverlayControlView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public ItemizedOverlayControlView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ItemizedOverlayControlView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (context), new JValue (attrs)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (context), new JValue (attrs));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (context), new JValue (attrs)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (context), new JValue (attrs));
		}

		static Delegate cb_setItemizedOverlayControlViewListener_Lorg_osmdroid_views_overlay_ItemizedOverlayControlView_ItemizedOverlayControlViewListener_;
#pragma warning disable 0169
		static Delegate GetSetItemizedOverlayControlViewListener_Lorg_osmdroid_views_overlay_ItemizedOverlayControlView_ItemizedOverlayControlViewListener_Handler ()
		{
			if (cb_setItemizedOverlayControlViewListener_Lorg_osmdroid_views_overlay_ItemizedOverlayControlView_ItemizedOverlayControlViewListener_ == null)
				cb_setItemizedOverlayControlViewListener_Lorg_osmdroid_views_overlay_ItemizedOverlayControlView_ItemizedOverlayControlViewListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetItemizedOverlayControlViewListener_Lorg_osmdroid_views_overlay_ItemizedOverlayControlView_ItemizedOverlayControlViewListener_);
			return cb_setItemizedOverlayControlViewListener_Lorg_osmdroid_views_overlay_ItemizedOverlayControlView_ItemizedOverlayControlViewListener_;
		}

		static void n_SetItemizedOverlayControlViewListener_Lorg_osmdroid_views_overlay_ItemizedOverlayControlView_ItemizedOverlayControlViewListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lis)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlayControlView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlayControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener lis = (global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener)global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener> (native_lis, JniHandleOwnership.DoNotTransfer);
			__this.SetItemizedOverlayControlViewListener (lis);
		}
#pragma warning restore 0169

		static IntPtr id_setItemizedOverlayControlViewListener_Lorg_osmdroid_views_overlay_ItemizedOverlayControlView_ItemizedOverlayControlViewListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayControlView']/method[@name='setItemizedOverlayControlViewListener' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.overlay.ItemizedOverlayControlView.ItemizedOverlayControlViewListener']]"
		[Register ("setItemizedOverlayControlViewListener", "(Lorg/osmdroid/views/overlay/ItemizedOverlayControlView$ItemizedOverlayControlViewListener;)V", "GetSetItemizedOverlayControlViewListener_Lorg_osmdroid_views_overlay_ItemizedOverlayControlView_ItemizedOverlayControlViewListener_Handler")]
		public virtual void SetItemizedOverlayControlViewListener (global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener lis)
		{
			if (id_setItemizedOverlayControlViewListener_Lorg_osmdroid_views_overlay_ItemizedOverlayControlView_ItemizedOverlayControlViewListener_ == IntPtr.Zero)
				id_setItemizedOverlayControlViewListener_Lorg_osmdroid_views_overlay_ItemizedOverlayControlView_ItemizedOverlayControlViewListener_ = JNIEnv.GetMethodID (class_ref, "setItemizedOverlayControlViewListener", "(Lorg/osmdroid/views/overlay/ItemizedOverlayControlView$ItemizedOverlayControlViewListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setItemizedOverlayControlViewListener_Lorg_osmdroid_views_overlay_ItemizedOverlayControlView_ItemizedOverlayControlViewListener_, new JValue (lis));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setItemizedOverlayControlViewListener", "(Lorg/osmdroid/views/overlay/ItemizedOverlayControlView$ItemizedOverlayControlViewListener;)V"), new JValue (lis));
		}

		static Delegate cb_setNavToVisible_I;
#pragma warning disable 0169
		static Delegate GetSetNavToVisible_IHandler ()
		{
			if (cb_setNavToVisible_I == null)
				cb_setNavToVisible_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNavToVisible_I);
			return cb_setNavToVisible_I;
		}

		static void n_SetNavToVisible_I (IntPtr jnienv, IntPtr native__this, int pVisibility)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlayControlView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlayControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNavToVisible (pVisibility);
		}
#pragma warning restore 0169

		static IntPtr id_setNavToVisible_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayControlView']/method[@name='setNavToVisible' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNavToVisible", "(I)V", "GetSetNavToVisible_IHandler")]
		public virtual void SetNavToVisible (int pVisibility)
		{
			if (id_setNavToVisible_I == IntPtr.Zero)
				id_setNavToVisible_I = JNIEnv.GetMethodID (class_ref, "setNavToVisible", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setNavToVisible_I, new JValue (pVisibility));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNavToVisible", "(I)V"), new JValue (pVisibility));
		}

		static Delegate cb_setNextEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetNextEnabled_ZHandler ()
		{
			if (cb_setNextEnabled_Z == null)
				cb_setNextEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetNextEnabled_Z);
			return cb_setNextEnabled_Z;
		}

		static void n_SetNextEnabled_Z (IntPtr jnienv, IntPtr native__this, bool pEnabled)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlayControlView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlayControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNextEnabled (pEnabled);
		}
#pragma warning restore 0169

		static IntPtr id_setNextEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayControlView']/method[@name='setNextEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNextEnabled", "(Z)V", "GetSetNextEnabled_ZHandler")]
		public virtual void SetNextEnabled (bool pEnabled)
		{
			if (id_setNextEnabled_Z == IntPtr.Zero)
				id_setNextEnabled_Z = JNIEnv.GetMethodID (class_ref, "setNextEnabled", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setNextEnabled_Z, new JValue (pEnabled));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setNextEnabled", "(Z)V"), new JValue (pEnabled));
		}

		static Delegate cb_setPreviousEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetPreviousEnabled_ZHandler ()
		{
			if (cb_setPreviousEnabled_Z == null)
				cb_setPreviousEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPreviousEnabled_Z);
			return cb_setPreviousEnabled_Z;
		}

		static void n_SetPreviousEnabled_Z (IntPtr jnienv, IntPtr native__this, bool pEnabled)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlayControlView __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlayControlView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPreviousEnabled (pEnabled);
		}
#pragma warning restore 0169

		static IntPtr id_setPreviousEnabled_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayControlView']/method[@name='setPreviousEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPreviousEnabled", "(Z)V", "GetSetPreviousEnabled_ZHandler")]
		public virtual void SetPreviousEnabled (bool pEnabled)
		{
			if (id_setPreviousEnabled_Z == IntPtr.Zero)
				id_setPreviousEnabled_Z = JNIEnv.GetMethodID (class_ref, "setPreviousEnabled", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPreviousEnabled_Z, new JValue (pEnabled));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPreviousEnabled", "(Z)V"), new JValue (pEnabled));
		}

#region "Event implementation for Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener"
		public event EventHandler Center {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener, global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListenerImplementor>(
						ref weak_implementor_SetItemizedOverlayControlViewListener,
						__CreateIItemizedOverlayControlViewListenerImplementor,
						SetItemizedOverlayControlViewListener,
						__h => __h.OnCenterHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener, global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListenerImplementor>(
						ref weak_implementor_SetItemizedOverlayControlViewListener,
						global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListenerImplementor.__IsEmpty,
						__v => SetItemizedOverlayControlViewListener (null),
						__h => __h.OnCenterHandler -= value);
			}
		}

		public event EventHandler NavTo {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener, global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListenerImplementor>(
						ref weak_implementor_SetItemizedOverlayControlViewListener,
						__CreateIItemizedOverlayControlViewListenerImplementor,
						SetItemizedOverlayControlViewListener,
						__h => __h.OnNavToHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener, global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListenerImplementor>(
						ref weak_implementor_SetItemizedOverlayControlViewListener,
						global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListenerImplementor.__IsEmpty,
						__v => SetItemizedOverlayControlViewListener (null),
						__h => __h.OnNavToHandler -= value);
			}
		}

		public event EventHandler Next {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener, global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListenerImplementor>(
						ref weak_implementor_SetItemizedOverlayControlViewListener,
						__CreateIItemizedOverlayControlViewListenerImplementor,
						SetItemizedOverlayControlViewListener,
						__h => __h.OnNextHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener, global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListenerImplementor>(
						ref weak_implementor_SetItemizedOverlayControlViewListener,
						global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListenerImplementor.__IsEmpty,
						__v => SetItemizedOverlayControlViewListener (null),
						__h => __h.OnNextHandler -= value);
			}
		}

		public event EventHandler Previous {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener, global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListenerImplementor>(
						ref weak_implementor_SetItemizedOverlayControlViewListener,
						__CreateIItemizedOverlayControlViewListenerImplementor,
						SetItemizedOverlayControlViewListener,
						__h => __h.OnPreviousHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListener, global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListenerImplementor>(
						ref weak_implementor_SetItemizedOverlayControlViewListener,
						global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListenerImplementor.__IsEmpty,
						__v => SetItemizedOverlayControlViewListener (null),
						__h => __h.OnPreviousHandler -= value);
			}
		}

		WeakReference weak_implementor_SetItemizedOverlayControlViewListener;

		global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListenerImplementor __CreateIItemizedOverlayControlViewListenerImplementor ()
		{
			return new global::Osmdroid.Views.Overlay.ItemizedOverlayControlView.IItemizedOverlayControlViewListenerImplementor (this);
		}
#endregion
	}
}
