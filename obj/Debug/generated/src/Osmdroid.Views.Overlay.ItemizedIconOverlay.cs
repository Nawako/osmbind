using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/ItemizedIconOverlay", DoNotGenerateAcw=true)]
	public partial class ItemizedIconOverlay : global::Osmdroid.Views.Overlay.ItemizedOverlay {


		static IntPtr mItemList_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/field[@name='mItemList']"
		[Register ("mItemList")]
		protected global::System.Collections.IList MItemList {
			get {
				if (mItemList_jfieldId == IntPtr.Zero)
					mItemList_jfieldId = JNIEnv.GetFieldID (class_ref, "mItemList", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mItemList_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mItemList_jfieldId == IntPtr.Zero)
					mItemList_jfieldId = JNIEnv.GetFieldID (class_ref, "mItemList", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mItemList_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mOnItemGestureListener_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/field[@name='mOnItemGestureListener']"
		[Register ("mOnItemGestureListener")]
		protected global::Osmdroid.Views.Overlay.ItemizedIconOverlay.IOnItemGestureListener MOnItemGestureListener {
			get {
				if (mOnItemGestureListener_jfieldId == IntPtr.Zero)
					mOnItemGestureListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnItemGestureListener", "Lorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mOnItemGestureListener_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedIconOverlay.IOnItemGestureListener> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mOnItemGestureListener_jfieldId == IntPtr.Zero)
					mOnItemGestureListener_jfieldId = JNIEnv.GetFieldID (class_ref, "mOnItemGestureListener", "Lorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mOnItemGestureListener_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='ItemizedIconOverlay.ActiveItem']"
		[Register ("org/osmdroid/views/overlay/ItemizedIconOverlay$ActiveItem", "", "Osmdroid.Views.Overlay.ItemizedIconOverlay/IActiveItemInvoker")]
		public partial interface IActiveItem : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='ItemizedIconOverlay.ActiveItem']/method[@name='run' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("run", "(I)Z", "GetRun_IHandler:Osmdroid.Views.Overlay.ItemizedIconOverlay/IActiveItemInvoker, OsmdroidAndroidBinding")]
			bool Run (int aIndex);

		}

		[global::Android.Runtime.Register ("org/osmdroid/views/overlay/ItemizedIconOverlay$ActiveItem", DoNotGenerateAcw=true)]
		internal class IActiveItemInvoker : global::Java.Lang.Object, IActiveItem {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/views/overlay/ItemizedIconOverlay$ActiveItem");
			IntPtr class_ref;

			public static IActiveItem GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IActiveItem> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.views.overlay.ItemizedIconOverlay.ActiveItem"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IActiveItemInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IActiveItemInvoker); }
			}

			static Delegate cb_run_I;
#pragma warning disable 0169
			static Delegate GetRun_IHandler ()
			{
				if (cb_run_I == null)
					cb_run_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Run_I);
				return cb_run_I;
			}

			static bool n_Run_I (IntPtr jnienv, IntPtr native__this, int aIndex)
			{
				global::Osmdroid.Views.Overlay.ItemizedIconOverlay.IActiveItem __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedIconOverlay.IActiveItem> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Run (aIndex);
			}
#pragma warning restore 0169

			IntPtr id_run_I;
			public bool Run (int aIndex)
			{
				if (id_run_I == IntPtr.Zero)
					id_run_I = JNIEnv.GetMethodID (class_ref, "run", "(I)Z");
				return JNIEnv.CallBooleanMethod (Handle, id_run_I, new JValue (aIndex));
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='ItemizedIconOverlay.OnItemGestureListener']"
		[Register ("org/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener", "", "Osmdroid.Views.Overlay.ItemizedIconOverlay/IOnItemGestureListenerInvoker")]
		public partial interface IOnItemGestureListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='ItemizedIconOverlay.OnItemGestureListener']/method[@name='onItemLongPress' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
			[Register ("onItemLongPress", "(ILjava/lang/Object;)Z", "GetOnItemLongPress_ILjava_lang_Object_Handler:Osmdroid.Views.Overlay.ItemizedIconOverlay/IOnItemGestureListenerInvoker, OsmdroidAndroidBinding")]
			bool OnItemLongPress (int index, global::Java.Lang.Object item);

			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/interface[@name='ItemizedIconOverlay.OnItemGestureListener']/method[@name='onItemSingleTapUp' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object']]"
			[Register ("onItemSingleTapUp", "(ILjava/lang/Object;)Z", "GetOnItemSingleTapUp_ILjava_lang_Object_Handler:Osmdroid.Views.Overlay.ItemizedIconOverlay/IOnItemGestureListenerInvoker, OsmdroidAndroidBinding")]
			bool OnItemSingleTapUp (int index, global::Java.Lang.Object item);

		}

		[global::Android.Runtime.Register ("org/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener", DoNotGenerateAcw=true)]
		internal class IOnItemGestureListenerInvoker : global::Java.Lang.Object, IOnItemGestureListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener");
			IntPtr class_ref;

			public static IOnItemGestureListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnItemGestureListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.views.overlay.ItemizedIconOverlay.OnItemGestureListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnItemGestureListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override System.Type ThresholdType {
				get { return typeof (IOnItemGestureListenerInvoker); }
			}

			static Delegate cb_onItemLongPress_ILjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnItemLongPress_ILjava_lang_Object_Handler ()
			{
				if (cb_onItemLongPress_ILjava_lang_Object_ == null)
					cb_onItemLongPress_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnItemLongPress_ILjava_lang_Object_);
				return cb_onItemLongPress_ILjava_lang_Object_;
			}

			static bool n_OnItemLongPress_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_item)
			{
				global::Osmdroid.Views.Overlay.ItemizedIconOverlay.IOnItemGestureListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedIconOverlay.IOnItemGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object item = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_item, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnItemLongPress (index, item);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onItemLongPress_ILjava_lang_Object_;
			public bool OnItemLongPress (int index, global::Java.Lang.Object item)
			{
				if (id_onItemLongPress_ILjava_lang_Object_ == IntPtr.Zero)
					id_onItemLongPress_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onItemLongPress", "(ILjava/lang/Object;)Z");
				IntPtr native_item = JNIEnv.ToLocalJniHandle (item);
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onItemLongPress_ILjava_lang_Object_, new JValue (index), new JValue (native_item));
				JNIEnv.DeleteLocalRef (native_item);
				return __ret;
			}

			static Delegate cb_onItemSingleTapUp_ILjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnItemSingleTapUp_ILjava_lang_Object_Handler ()
			{
				if (cb_onItemSingleTapUp_ILjava_lang_Object_ == null)
					cb_onItemSingleTapUp_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnItemSingleTapUp_ILjava_lang_Object_);
				return cb_onItemSingleTapUp_ILjava_lang_Object_;
			}

			static bool n_OnItemSingleTapUp_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_item)
			{
				global::Osmdroid.Views.Overlay.ItemizedIconOverlay.IOnItemGestureListener __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedIconOverlay.IOnItemGestureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object item = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_item, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnItemSingleTapUp (index, item);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_onItemSingleTapUp_ILjava_lang_Object_;
			public bool OnItemSingleTapUp (int index, global::Java.Lang.Object item)
			{
				if (id_onItemSingleTapUp_ILjava_lang_Object_ == IntPtr.Zero)
					id_onItemSingleTapUp_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onItemSingleTapUp", "(ILjava/lang/Object;)Z");
				IntPtr native_item = JNIEnv.ToLocalJniHandle (item);
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_onItemSingleTapUp_ILjava_lang_Object_, new JValue (index), new JValue (native_item));
				JNIEnv.DeleteLocalRef (native_item);
				return __ret;
			}

		}

		public partial class ItemLongPressEventArgs : global::System.EventArgs {

			public ItemLongPressEventArgs (bool handled, int index, global::Java.Lang.Object item)
			{
				this.handled = handled;
				this.index = index;
				this.item = item;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			int index;
			public int Index {
				get { return index; }
			}

			global::Java.Lang.Object item;
			public global::Java.Lang.Object Item {
				get { return item; }
			}
		}

		public partial class ItemSingleTapUpEventArgs : global::System.EventArgs {

			public ItemSingleTapUpEventArgs (bool handled, int index, global::Java.Lang.Object item)
			{
				this.handled = handled;
				this.index = index;
				this.item = item;
			}

			bool handled;
			public bool Handled {
				get { return handled; }
				set { handled = value; }
			}

			int index;
			public int Index {
				get { return index; }
			}

			global::Java.Lang.Object item;
			public global::Java.Lang.Object Item {
				get { return item; }
			}
		}

		[global::Android.Runtime.Register ("mono/org/osmdroid/views/overlay/ItemizedIconOverlay_OnItemGestureListenerImplementor")]
		internal sealed class IOnItemGestureListenerImplementor : global::Java.Lang.Object, IOnItemGestureListener {

			object sender;

			public IOnItemGestureListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/org/osmdroid/views/overlay/ItemizedIconOverlay_OnItemGestureListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ItemLongPressEventArgs> OnItemLongPressHandler;
#pragma warning restore 0649

			public bool OnItemLongPress (int index, global::Java.Lang.Object item)
			{
				var __h = OnItemLongPressHandler;
				if (__h == null)
					return false;
				var __e = new ItemLongPressEventArgs (true, index, item);
				__h (sender, __e);
				return __e.Handled;
			}
#pragma warning disable 0649
			public EventHandler<ItemSingleTapUpEventArgs> OnItemSingleTapUpHandler;
#pragma warning restore 0649

			public bool OnItemSingleTapUp (int index, global::Java.Lang.Object item)
			{
				var __h = OnItemSingleTapUpHandler;
				if (__h == null)
					return false;
				var __e = new ItemSingleTapUpEventArgs (true, index, item);
				__h (sender, __e);
				return __e.Handled;
			}

			internal static bool __IsEmpty (IOnItemGestureListenerImplementor value)
			{
				return value.OnItemLongPressHandler == null && value.OnItemSingleTapUpHandler == null;
			}
		}


		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/ItemizedIconOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ItemizedIconOverlay); }
		}

		protected ItemizedIconOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_List_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/constructor[@name='ItemizedIconOverlay' and count(parameter)=4 and parameter[1][@type='java.util.List'] and parameter[2][@type='android.graphics.drawable.Drawable'] and parameter[3][@type='org.osmdroid.views.overlay.ItemizedIconOverlay.OnItemGestureListener'] and parameter[4][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Ljava/util/List;Landroid/graphics/drawable/Drawable;Lorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;Lorg/osmdroid/ResourceProxy;)V", "")]
		public ItemizedIconOverlay (global::System.Collections.IList p0, global::Android.Graphics.Drawables.Drawable p1, global::Osmdroid.Views.Overlay.ItemizedIconOverlay.IOnItemGestureListener p2, global::Osmdroid.IResourceProxy p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);;
			if (GetType () != typeof (ItemizedIconOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;Landroid/graphics/drawable/Drawable;Lorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;Lorg/osmdroid/ResourceProxy;)V", new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/List;Landroid/graphics/drawable/Drawable;Lorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;Lorg/osmdroid/ResourceProxy;)V", new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_util_List_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_Lorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_ctor_Ljava_util_List_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_Lorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;Landroid/graphics/drawable/Drawable;Lorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;Lorg/osmdroid/ResourceProxy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_Lorg_osmdroid_ResourceProxy_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_List_Landroid_graphics_drawable_Drawable_Lorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_Lorg_osmdroid_ResourceProxy_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_util_List_Lorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/constructor[@name='ItemizedIconOverlay' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List'] and parameter[3][@type='org.osmdroid.views.overlay.ItemizedIconOverlay.OnItemGestureListener']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/List;Lorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;)V", "")]
		public ItemizedIconOverlay (global::Android.Content.Context p0, global::System.Collections.IList p1, global::Osmdroid.Views.Overlay.ItemizedIconOverlay.IOnItemGestureListener p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);;
			if (GetType () != typeof (ItemizedIconOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/util/List;Lorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;)V", new JValue (p0), new JValue (native_p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/util/List;Lorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;)V", new JValue (p0), new JValue (native_p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_util_List_Lorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_util_List_Lorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/util/List;Lorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_Lorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_, new JValue (p0), new JValue (native_p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_Lorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Ljava_util_List_Lorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/constructor[@name='ItemizedIconOverlay' and count(parameter)=3 and parameter[1][@type='java.util.List'] and parameter[2][@type='org.osmdroid.views.overlay.ItemizedIconOverlay.OnItemGestureListener'] and parameter[3][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Ljava/util/List;Lorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;Lorg/osmdroid/ResourceProxy;)V", "")]
		public ItemizedIconOverlay (global::System.Collections.IList p0, global::Osmdroid.Views.Overlay.ItemizedIconOverlay.IOnItemGestureListener p1, global::Osmdroid.IResourceProxy p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);;
			if (GetType () != typeof (ItemizedIconOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;Lorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;Lorg/osmdroid/ResourceProxy;)V", new JValue (native_p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/List;Lorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;Lorg/osmdroid/ResourceProxy;)V", new JValue (native_p0), new JValue (p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_util_List_Lorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_Lorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_ctor_Ljava_util_List_Lorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_Lorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;Lorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;Lorg/osmdroid/ResourceProxy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_Lorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_Lorg_osmdroid_ResourceProxy_, new JValue (native_p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_List_Lorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_Lorg_osmdroid_ResourceProxy_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_getDrawnItemsLimit;
#pragma warning disable 0169
		static Delegate GetGetDrawnItemsLimitHandler ()
		{
			if (cb_getDrawnItemsLimit == null)
				cb_getDrawnItemsLimit = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDrawnItemsLimit);
			return cb_getDrawnItemsLimit;
		}

		static int n_GetDrawnItemsLimit (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.ItemizedIconOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedIconOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DrawnItemsLimit;
		}
#pragma warning restore 0169

		static Delegate cb_setDrawnItemsLimit_I;
#pragma warning disable 0169
		static Delegate GetSetDrawnItemsLimit_IHandler ()
		{
			if (cb_setDrawnItemsLimit_I == null)
				cb_setDrawnItemsLimit_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDrawnItemsLimit_I);
			return cb_setDrawnItemsLimit_I;
		}

		static void n_SetDrawnItemsLimit_I (IntPtr jnienv, IntPtr native__this, int aLimit)
		{
			global::Osmdroid.Views.Overlay.ItemizedIconOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedIconOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DrawnItemsLimit = aLimit;
		}
#pragma warning restore 0169

		static IntPtr id_getDrawnItemsLimit;
		static IntPtr id_setDrawnItemsLimit_I;
		public virtual int DrawnItemsLimit {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/method[@name='getDrawnItemsLimit' and count(parameter)=0]"
			[Register ("getDrawnItemsLimit", "()I", "GetGetDrawnItemsLimitHandler")]
			get {
				if (id_getDrawnItemsLimit == IntPtr.Zero)
					id_getDrawnItemsLimit = JNIEnv.GetMethodID (class_ref, "getDrawnItemsLimit", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getDrawnItemsLimit);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDrawnItemsLimit", "()I"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/method[@name='setDrawnItemsLimit' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDrawnItemsLimit", "(I)V", "GetSetDrawnItemsLimit_IHandler")]
			set {
				if (id_setDrawnItemsLimit_I == IntPtr.Zero)
					id_setDrawnItemsLimit_I = JNIEnv.GetMethodID (class_ref, "setDrawnItemsLimit", "(I)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setDrawnItemsLimit_I, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDrawnItemsLimit", "(I)V"), new JValue (value));
			}
		}

		static Delegate cb_addItem_Lorg_osmdroid_views_overlay_OverlayItem_;
#pragma warning disable 0169
		static Delegate GetAddItem_Lorg_osmdroid_views_overlay_OverlayItem_Handler ()
		{
			if (cb_addItem_Lorg_osmdroid_views_overlay_OverlayItem_ == null)
				cb_addItem_Lorg_osmdroid_views_overlay_OverlayItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddItem_Lorg_osmdroid_views_overlay_OverlayItem_);
			return cb_addItem_Lorg_osmdroid_views_overlay_OverlayItem_;
		}

		static bool n_AddItem_Lorg_osmdroid_views_overlay_OverlayItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			global::Osmdroid.Views.Overlay.ItemizedIconOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedIconOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object item = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_item, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddItem (item);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addItem_Lorg_osmdroid_views_overlay_OverlayItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/method[@name='addItem' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.overlay.OverlayItem']]"
		[Register ("addItem", "(Lorg/osmdroid/views/overlay/OverlayItem;)Z", "GetAddItem_Lorg_osmdroid_views_overlay_OverlayItem_Handler")]
		public virtual bool AddItem (global::Java.Lang.Object item)
		{
			if (id_addItem_Lorg_osmdroid_views_overlay_OverlayItem_ == IntPtr.Zero)
				id_addItem_Lorg_osmdroid_views_overlay_OverlayItem_ = JNIEnv.GetMethodID (class_ref, "addItem", "(Lorg/osmdroid/views/overlay/OverlayItem;)Z");
			IntPtr native_item = JNIEnv.ToLocalJniHandle (item);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_addItem_Lorg_osmdroid_views_overlay_OverlayItem_, new JValue (native_item));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addItem", "(Lorg/osmdroid/views/overlay/OverlayItem;)Z"), new JValue (native_item));
			JNIEnv.DeleteLocalRef (native_item);
			return __ret;
		}

		static Delegate cb_addItem_ILorg_osmdroid_views_overlay_OverlayItem_;
#pragma warning disable 0169
		static Delegate GetAddItem_ILorg_osmdroid_views_overlay_OverlayItem_Handler ()
		{
			if (cb_addItem_ILorg_osmdroid_views_overlay_OverlayItem_ == null)
				cb_addItem_ILorg_osmdroid_views_overlay_OverlayItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AddItem_ILorg_osmdroid_views_overlay_OverlayItem_);
			return cb_addItem_ILorg_osmdroid_views_overlay_OverlayItem_;
		}

		static void n_AddItem_ILorg_osmdroid_views_overlay_OverlayItem_ (IntPtr jnienv, IntPtr native__this, int location, IntPtr native_item)
		{
			global::Osmdroid.Views.Overlay.ItemizedIconOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedIconOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object item = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_item, JniHandleOwnership.DoNotTransfer);
			__this.AddItem (location, item);
		}
#pragma warning restore 0169

		static IntPtr id_addItem_ILorg_osmdroid_views_overlay_OverlayItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/method[@name='addItem' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.osmdroid.views.overlay.OverlayItem']]"
		[Register ("addItem", "(ILorg/osmdroid/views/overlay/OverlayItem;)V", "GetAddItem_ILorg_osmdroid_views_overlay_OverlayItem_Handler")]
		public virtual void AddItem (int location, global::Java.Lang.Object item)
		{
			if (id_addItem_ILorg_osmdroid_views_overlay_OverlayItem_ == IntPtr.Zero)
				id_addItem_ILorg_osmdroid_views_overlay_OverlayItem_ = JNIEnv.GetMethodID (class_ref, "addItem", "(ILorg/osmdroid/views/overlay/OverlayItem;)V");
			IntPtr native_item = JNIEnv.ToLocalJniHandle (item);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_addItem_ILorg_osmdroid_views_overlay_OverlayItem_, new JValue (location), new JValue (native_item));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addItem", "(ILorg/osmdroid/views/overlay/OverlayItem;)V"), new JValue (location), new JValue (native_item));
			JNIEnv.DeleteLocalRef (native_item);
		}

		static Delegate cb_addItems_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddItems_Ljava_util_List_Handler ()
		{
			if (cb_addItems_Ljava_util_List_ == null)
				cb_addItems_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddItems_Ljava_util_List_);
			return cb_addItems_Ljava_util_List_;
		}

		static bool n_AddItems_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Osmdroid.Views.Overlay.ItemizedIconOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedIconOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.IList p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddItems (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_addItems_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/method[@name='addItems' and count(parameter)=1 and parameter[1][@type='java.util.List']]"
		[Register ("addItems", "(Ljava/util/List;)Z", "GetAddItems_Ljava_util_List_Handler")]
		public virtual bool AddItems (global::System.Collections.IList p0)
		{
			if (id_addItems_Ljava_util_List_ == IntPtr.Zero)
				id_addItems_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addItems", "(Ljava/util/List;)Z");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_addItems_Ljava_util_List_, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addItems", "(Ljava/util/List;)Z"), new JValue (native_p0));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_createItem_I;
#pragma warning disable 0169
		static Delegate GetCreateItem_IHandler ()
		{
			if (cb_createItem_I == null)
				cb_createItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_CreateItem_I);
			return cb_createItem_I;
		}

		static IntPtr n_CreateItem_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Osmdroid.Views.Overlay.ItemizedIconOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedIconOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateItem (index));
		}
#pragma warning restore 0169

		static IntPtr id_createItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/method[@name='createItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("createItem", "(I)Lorg/osmdroid/views/overlay/OverlayItem;", "GetCreateItem_IHandler")]
		protected override global::Java.Lang.Object CreateItem (int index)
		{
			if (id_createItem_I == IntPtr.Zero)
				id_createItem_I = JNIEnv.GetMethodID (class_ref, "createItem", "(I)Lorg/osmdroid/views/overlay/OverlayItem;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_createItem_I, new JValue (index)), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "createItem", "(I)Lorg/osmdroid/views/overlay/OverlayItem;"), new JValue (index)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_onLongPressHelper_ILorg_osmdroid_views_overlay_OverlayItem_;
#pragma warning disable 0169
		static Delegate GetOnLongPressHelper_ILorg_osmdroid_views_overlay_OverlayItem_Handler ()
		{
			if (cb_onLongPressHelper_ILorg_osmdroid_views_overlay_OverlayItem_ == null)
				cb_onLongPressHelper_ILorg_osmdroid_views_overlay_OverlayItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_OnLongPressHelper_ILorg_osmdroid_views_overlay_OverlayItem_);
			return cb_onLongPressHelper_ILorg_osmdroid_views_overlay_OverlayItem_;
		}

		static bool n_OnLongPressHelper_ILorg_osmdroid_views_overlay_OverlayItem_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_item)
		{
			global::Osmdroid.Views.Overlay.ItemizedIconOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedIconOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object item = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_item, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnLongPressHelper (index, item);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onLongPressHelper_ILorg_osmdroid_views_overlay_OverlayItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/method[@name='onLongPressHelper' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='org.osmdroid.views.overlay.OverlayItem']]"
		[Register ("onLongPressHelper", "(ILorg/osmdroid/views/overlay/OverlayItem;)Z", "GetOnLongPressHelper_ILorg_osmdroid_views_overlay_OverlayItem_Handler")]
		protected virtual bool OnLongPressHelper (int index, global::Java.Lang.Object item)
		{
			if (id_onLongPressHelper_ILorg_osmdroid_views_overlay_OverlayItem_ == IntPtr.Zero)
				id_onLongPressHelper_ILorg_osmdroid_views_overlay_OverlayItem_ = JNIEnv.GetMethodID (class_ref, "onLongPressHelper", "(ILorg/osmdroid/views/overlay/OverlayItem;)Z");
			IntPtr native_item = JNIEnv.ToLocalJniHandle (item);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onLongPressHelper_ILorg_osmdroid_views_overlay_OverlayItem_, new JValue (index), new JValue (native_item));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLongPressHelper", "(ILorg/osmdroid/views/overlay/OverlayItem;)Z"), new JValue (index), new JValue (native_item));
			JNIEnv.DeleteLocalRef (native_item);
			return __ret;
		}

		static Delegate cb_onSingleTapUpHelper_ILorg_osmdroid_views_overlay_OverlayItem_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetOnSingleTapUpHelper_ILorg_osmdroid_views_overlay_OverlayItem_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_onSingleTapUpHelper_ILorg_osmdroid_views_overlay_OverlayItem_Lorg_osmdroid_views_MapView_ == null)
				cb_onSingleTapUpHelper_ILorg_osmdroid_views_overlay_OverlayItem_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, bool>) n_OnSingleTapUpHelper_ILorg_osmdroid_views_overlay_OverlayItem_Lorg_osmdroid_views_MapView_);
			return cb_onSingleTapUpHelper_ILorg_osmdroid_views_overlay_OverlayItem_Lorg_osmdroid_views_MapView_;
		}

		static bool n_OnSingleTapUpHelper_ILorg_osmdroid_views_overlay_OverlayItem_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_item, IntPtr native_mapView)
		{
			global::Osmdroid.Views.Overlay.ItemizedIconOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedIconOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object item = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_item, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSingleTapUpHelper (index, item, mapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onSingleTapUpHelper_ILorg_osmdroid_views_overlay_OverlayItem_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/method[@name='onSingleTapUpHelper' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='org.osmdroid.views.overlay.OverlayItem'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register ("onSingleTapUpHelper", "(ILorg/osmdroid/views/overlay/OverlayItem;Lorg/osmdroid/views/MapView;)Z", "GetOnSingleTapUpHelper_ILorg_osmdroid_views_overlay_OverlayItem_Lorg_osmdroid_views_MapView_Handler")]
		protected virtual bool OnSingleTapUpHelper (int index, global::Java.Lang.Object item, global::Osmdroid.Views.MapView mapView)
		{
			if (id_onSingleTapUpHelper_ILorg_osmdroid_views_overlay_OverlayItem_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_onSingleTapUpHelper_ILorg_osmdroid_views_overlay_OverlayItem_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "onSingleTapUpHelper", "(ILorg/osmdroid/views/overlay/OverlayItem;Lorg/osmdroid/views/MapView;)Z");
			IntPtr native_item = JNIEnv.ToLocalJniHandle (item);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onSingleTapUpHelper_ILorg_osmdroid_views_overlay_OverlayItem_Lorg_osmdroid_views_MapView_, new JValue (index), new JValue (native_item), new JValue (mapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSingleTapUpHelper", "(ILorg/osmdroid/views/overlay/OverlayItem;Lorg/osmdroid/views/MapView;)Z"), new JValue (index), new JValue (native_item), new JValue (mapView));
			JNIEnv.DeleteLocalRef (native_item);
			return __ret;
		}

		static Delegate cb_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_;
#pragma warning disable 0169
		static Delegate GetOnSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_Handler ()
		{
			if (cb_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_ == null)
				cb_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr, bool>) n_OnSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_);
			return cb_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_;
		}

		static bool n_OnSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_ (IntPtr jnienv, IntPtr native__this, int pX, int pY, IntPtr native_pSnapPoint, IntPtr native_pMapView)
		{
			global::Osmdroid.Views.Overlay.ItemizedIconOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedIconOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point pSnapPoint = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_pSnapPoint, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IMapView pMapView = (global::Osmdroid.Api.IMapView)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IMapView> (native_pMapView, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnSnapToItem (pX, pY, pSnapPoint, pMapView);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/method[@name='onSnapToItem' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.graphics.Point'] and parameter[4][@type='org.osmdroid.api.IMapView']]"
		[Register ("onSnapToItem", "(IILandroid/graphics/Point;Lorg/osmdroid/api/IMapView;)Z", "GetOnSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_Handler")]
		public override bool OnSnapToItem (int pX, int pY, global::Android.Graphics.Point pSnapPoint, global::Osmdroid.Api.IMapView pMapView)
		{
			if (id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_ == IntPtr.Zero)
				id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_ = JNIEnv.GetMethodID (class_ref, "onSnapToItem", "(IILandroid/graphics/Point;Lorg/osmdroid/api/IMapView;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_onSnapToItem_IILandroid_graphics_Point_Lorg_osmdroid_api_IMapView_, new JValue (pX), new JValue (pY), new JValue (pSnapPoint), new JValue (pMapView));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSnapToItem", "(IILandroid/graphics/Point;Lorg/osmdroid/api/IMapView;)Z"), new JValue (pX), new JValue (pY), new JValue (pSnapPoint), new JValue (pMapView));
			return __ret;
		}

		static Delegate cb_removeAllItems;
#pragma warning disable 0169
		static Delegate GetRemoveAllItemsHandler ()
		{
			if (cb_removeAllItems == null)
				cb_removeAllItems = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllItems);
			return cb_removeAllItems;
		}

		static void n_RemoveAllItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.ItemizedIconOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedIconOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllItems ();
		}
#pragma warning restore 0169

		static IntPtr id_removeAllItems;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/method[@name='removeAllItems' and count(parameter)=0]"
		[Register ("removeAllItems", "()V", "GetRemoveAllItemsHandler")]
		public virtual void RemoveAllItems ()
		{
			if (id_removeAllItems == IntPtr.Zero)
				id_removeAllItems = JNIEnv.GetMethodID (class_ref, "removeAllItems", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeAllItems);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllItems", "()V"));
		}

		static Delegate cb_removeAllItems_Z;
#pragma warning disable 0169
		static Delegate GetRemoveAllItems_ZHandler ()
		{
			if (cb_removeAllItems_Z == null)
				cb_removeAllItems_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_RemoveAllItems_Z);
			return cb_removeAllItems_Z;
		}

		static void n_RemoveAllItems_Z (IntPtr jnienv, IntPtr native__this, bool withPopulate)
		{
			global::Osmdroid.Views.Overlay.ItemizedIconOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedIconOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllItems (withPopulate);
		}
#pragma warning restore 0169

		static IntPtr id_removeAllItems_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/method[@name='removeAllItems' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("removeAllItems", "(Z)V", "GetRemoveAllItems_ZHandler")]
		public virtual void RemoveAllItems (bool withPopulate)
		{
			if (id_removeAllItems_Z == IntPtr.Zero)
				id_removeAllItems_Z = JNIEnv.GetMethodID (class_ref, "removeAllItems", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_removeAllItems_Z, new JValue (withPopulate));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeAllItems", "(Z)V"), new JValue (withPopulate));
		}

		static Delegate cb_removeItem_Lorg_osmdroid_views_overlay_OverlayItem_;
#pragma warning disable 0169
		static Delegate GetRemoveItem_Lorg_osmdroid_views_overlay_OverlayItem_Handler ()
		{
			if (cb_removeItem_Lorg_osmdroid_views_overlay_OverlayItem_ == null)
				cb_removeItem_Lorg_osmdroid_views_overlay_OverlayItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveItem_Lorg_osmdroid_views_overlay_OverlayItem_);
			return cb_removeItem_Lorg_osmdroid_views_overlay_OverlayItem_;
		}

		static bool n_RemoveItem_Lorg_osmdroid_views_overlay_OverlayItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			global::Osmdroid.Views.Overlay.ItemizedIconOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedIconOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object item = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_item, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveItem (item);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeItem_Lorg_osmdroid_views_overlay_OverlayItem_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/method[@name='removeItem' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.overlay.OverlayItem']]"
		[Register ("removeItem", "(Lorg/osmdroid/views/overlay/OverlayItem;)Z", "GetRemoveItem_Lorg_osmdroid_views_overlay_OverlayItem_Handler")]
		public virtual bool RemoveItem (global::Java.Lang.Object item)
		{
			if (id_removeItem_Lorg_osmdroid_views_overlay_OverlayItem_ == IntPtr.Zero)
				id_removeItem_Lorg_osmdroid_views_overlay_OverlayItem_ = JNIEnv.GetMethodID (class_ref, "removeItem", "(Lorg/osmdroid/views/overlay/OverlayItem;)Z");
			IntPtr native_item = JNIEnv.ToLocalJniHandle (item);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_removeItem_Lorg_osmdroid_views_overlay_OverlayItem_, new JValue (native_item));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeItem", "(Lorg/osmdroid/views/overlay/OverlayItem;)Z"), new JValue (native_item));
			JNIEnv.DeleteLocalRef (native_item);
			return __ret;
		}

		static Delegate cb_removeItem_I;
#pragma warning disable 0169
		static Delegate GetRemoveItem_IHandler ()
		{
			if (cb_removeItem_I == null)
				cb_removeItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_RemoveItem_I);
			return cb_removeItem_I;
		}

		static IntPtr n_RemoveItem_I (IntPtr jnienv, IntPtr native__this, int position)
		{
			global::Osmdroid.Views.Overlay.ItemizedIconOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedIconOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RemoveItem (position));
		}
#pragma warning restore 0169

		static IntPtr id_removeItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/method[@name='removeItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeItem", "(I)Lorg/osmdroid/views/overlay/OverlayItem;", "GetRemoveItem_IHandler")]
		public virtual global::Java.Lang.Object RemoveItem (int position)
		{
			if (id_removeItem_I == IntPtr.Zero)
				id_removeItem_I = JNIEnv.GetMethodID (class_ref, "removeItem", "(I)Lorg/osmdroid/views/overlay/OverlayItem;");

			if (GetType () == ThresholdType)
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_removeItem_I, new JValue (position)), JniHandleOwnership.TransferLocalRef);
			else
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeItem", "(I)Lorg/osmdroid/views/overlay/OverlayItem;"), new JValue (position)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.ItemizedIconOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedIconOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedIconOverlay']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public override int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_size);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "size", "()I"));
		}

	}
}
