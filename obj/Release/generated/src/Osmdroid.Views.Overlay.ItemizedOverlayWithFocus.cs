using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/ItemizedOverlayWithFocus", DoNotGenerateAcw=true)]
	public partial class ItemizedOverlayWithFocus : global::Osmdroid.Views.Overlay.ItemizedIconOverlay {


		static IntPtr DEFAULTMARKER_BACKGROUNDCOLOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/field[@name='DEFAULTMARKER_BACKGROUNDCOLOR']"
		[Register ("DEFAULTMARKER_BACKGROUNDCOLOR")]
		protected static int DefaultmarkerBackgroundcolor {
			get {
				if (DEFAULTMARKER_BACKGROUNDCOLOR_jfieldId == IntPtr.Zero)
					DEFAULTMARKER_BACKGROUNDCOLOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULTMARKER_BACKGROUNDCOLOR", "I");
				return JNIEnv.GetStaticIntField (class_ref, DEFAULTMARKER_BACKGROUNDCOLOR_jfieldId);
			}
			set {
				if (DEFAULTMARKER_BACKGROUNDCOLOR_jfieldId == IntPtr.Zero)
					DEFAULTMARKER_BACKGROUNDCOLOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULTMARKER_BACKGROUNDCOLOR", "I");
				JNIEnv.SetStaticField (class_ref, DEFAULTMARKER_BACKGROUNDCOLOR_jfieldId, value);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/field[@name='DESCRIPTION_BOX_CORNERWIDTH']"
		[Register ("DESCRIPTION_BOX_CORNERWIDTH")]
		public const int DescriptionBoxCornerwidth = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/field[@name='DESCRIPTION_BOX_PADDING']"
		[Register ("DESCRIPTION_BOX_PADDING")]
		public const int DescriptionBoxPadding = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/field[@name='DESCRIPTION_LINE_HEIGHT']"
		[Register ("DESCRIPTION_LINE_HEIGHT")]
		public const int DescriptionLineHeight = (int) 12;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/field[@name='DESCRIPTION_MAXWIDTH']"
		[Register ("DESCRIPTION_MAXWIDTH")]
		protected const int DescriptionMaxwidth = (int) 200;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/field[@name='DESCRIPTION_TITLE_EXTRA_LINE_HEIGHT']"
		[Register ("DESCRIPTION_TITLE_EXTRA_LINE_HEIGHT")]
		public const int DescriptionTitleExtraLineHeight = (int) 2;

		static IntPtr mDescriptionPaint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/field[@name='mDescriptionPaint']"
		[Register ("mDescriptionPaint")]
		protected global::Android.Graphics.Paint MDescriptionPaint {
			get {
				if (mDescriptionPaint_jfieldId == IntPtr.Zero)
					mDescriptionPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mDescriptionPaint", "Landroid/graphics/Paint;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mDescriptionPaint_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDescriptionPaint_jfieldId == IntPtr.Zero)
					mDescriptionPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mDescriptionPaint", "Landroid/graphics/Paint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mDescriptionPaint_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mFocusItemsOnTap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/field[@name='mFocusItemsOnTap']"
		[Register ("mFocusItemsOnTap")]
		protected bool MFocusItemsOnTap {
			get {
				if (mFocusItemsOnTap_jfieldId == IntPtr.Zero)
					mFocusItemsOnTap_jfieldId = JNIEnv.GetFieldID (class_ref, "mFocusItemsOnTap", "Z");
				return JNIEnv.GetBooleanField (Handle, mFocusItemsOnTap_jfieldId);
			}
			set {
				if (mFocusItemsOnTap_jfieldId == IntPtr.Zero)
					mFocusItemsOnTap_jfieldId = JNIEnv.GetFieldID (class_ref, "mFocusItemsOnTap", "Z");
				JNIEnv.SetField (Handle, mFocusItemsOnTap_jfieldId, value);
			}
		}

		static IntPtr mFocusedItemIndex_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/field[@name='mFocusedItemIndex']"
		[Register ("mFocusedItemIndex")]
		protected int MFocusedItemIndex {
			get {
				if (mFocusedItemIndex_jfieldId == IntPtr.Zero)
					mFocusedItemIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "mFocusedItemIndex", "I");
				return JNIEnv.GetIntField (Handle, mFocusedItemIndex_jfieldId);
			}
			set {
				if (mFocusedItemIndex_jfieldId == IntPtr.Zero)
					mFocusedItemIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "mFocusedItemIndex", "I");
				JNIEnv.SetField (Handle, mFocusedItemIndex_jfieldId, value);
			}
		}

		static IntPtr mMarkerBackgroundPaint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/field[@name='mMarkerBackgroundPaint']"
		[Register ("mMarkerBackgroundPaint")]
		protected global::Android.Graphics.Paint MMarkerBackgroundPaint {
			get {
				if (mMarkerBackgroundPaint_jfieldId == IntPtr.Zero)
					mMarkerBackgroundPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mMarkerBackgroundPaint", "Landroid/graphics/Paint;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mMarkerBackgroundPaint_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMarkerBackgroundPaint_jfieldId == IntPtr.Zero)
					mMarkerBackgroundPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mMarkerBackgroundPaint", "Landroid/graphics/Paint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mMarkerBackgroundPaint_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mMarkerFocusedBackgroundColor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/field[@name='mMarkerFocusedBackgroundColor']"
		[Register ("mMarkerFocusedBackgroundColor")]
		protected int MMarkerFocusedBackgroundColor {
			get {
				if (mMarkerFocusedBackgroundColor_jfieldId == IntPtr.Zero)
					mMarkerFocusedBackgroundColor_jfieldId = JNIEnv.GetFieldID (class_ref, "mMarkerFocusedBackgroundColor", "I");
				return JNIEnv.GetIntField (Handle, mMarkerFocusedBackgroundColor_jfieldId);
			}
			set {
				if (mMarkerFocusedBackgroundColor_jfieldId == IntPtr.Zero)
					mMarkerFocusedBackgroundColor_jfieldId = JNIEnv.GetFieldID (class_ref, "mMarkerFocusedBackgroundColor", "I");
				JNIEnv.SetField (Handle, mMarkerFocusedBackgroundColor_jfieldId, value);
			}
		}

		static IntPtr mMarkerFocusedBase_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/field[@name='mMarkerFocusedBase']"
		[Register ("mMarkerFocusedBase")]
		protected global::Android.Graphics.Drawables.Drawable MMarkerFocusedBase {
			get {
				if (mMarkerFocusedBase_jfieldId == IntPtr.Zero)
					mMarkerFocusedBase_jfieldId = JNIEnv.GetFieldID (class_ref, "mMarkerFocusedBase", "Landroid/graphics/drawable/Drawable;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mMarkerFocusedBase_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMarkerFocusedBase_jfieldId == IntPtr.Zero)
					mMarkerFocusedBase_jfieldId = JNIEnv.GetFieldID (class_ref, "mMarkerFocusedBase", "Landroid/graphics/drawable/Drawable;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mMarkerFocusedBase_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mTitlePaint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/field[@name='mTitlePaint']"
		[Register ("mTitlePaint")]
		protected global::Android.Graphics.Paint MTitlePaint {
			get {
				if (mTitlePaint_jfieldId == IntPtr.Zero)
					mTitlePaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mTitlePaint", "Landroid/graphics/Paint;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mTitlePaint_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTitlePaint_jfieldId == IntPtr.Zero)
					mTitlePaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mTitlePaint", "Landroid/graphics/Paint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mTitlePaint_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/ItemizedOverlayWithFocus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ItemizedOverlayWithFocus); }
		}

		protected ItemizedOverlayWithFocus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_List_Lorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/constructor[@name='ItemizedOverlayWithFocus' and count(parameter)=3 and parameter[1][@type='java.util.List'] and parameter[2][@type='org.osmdroid.views.overlay.ItemizedIconOverlay.OnItemGestureListener'] and parameter[3][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Ljava/util/List;Lorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;Lorg/osmdroid/ResourceProxy;)V", "")]
		public ItemizedOverlayWithFocus (global::System.Collections.IList p0, global::Osmdroid.Views.Overlay.ItemizedIconOverlay.IOnItemGestureListener p1, global::Osmdroid.IResourceProxy p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);;
			if (GetType () != typeof (ItemizedOverlayWithFocus)) {
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

		static IntPtr id_ctor_Ljava_util_List_Landroid_graphics_drawable_Drawable_Landroid_graphics_drawable_Drawable_ILorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/constructor[@name='ItemizedOverlayWithFocus' and count(parameter)=6 and parameter[1][@type='java.util.List'] and parameter[2][@type='android.graphics.drawable.Drawable'] and parameter[3][@type='android.graphics.drawable.Drawable'] and parameter[4][@type='int'] and parameter[5][@type='org.osmdroid.views.overlay.ItemizedIconOverlay.OnItemGestureListener'] and parameter[6][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Ljava/util/List;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;ILorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;Lorg/osmdroid/ResourceProxy;)V", "")]
		public ItemizedOverlayWithFocus (global::System.Collections.IList p0, global::Android.Graphics.Drawables.Drawable p1, global::Android.Graphics.Drawables.Drawable p2, int p3, global::Osmdroid.Views.Overlay.ItemizedIconOverlay.IOnItemGestureListener p4, global::Osmdroid.IResourceProxy p5) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);;
			if (GetType () != typeof (ItemizedOverlayWithFocus)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/util/List;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;ILorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;Lorg/osmdroid/ResourceProxy;)V", new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/util/List;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;ILorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;Lorg/osmdroid/ResourceProxy;)V", new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
				JNIEnv.DeleteLocalRef (native_p0);
				return;
			}

			if (id_ctor_Ljava_util_List_Landroid_graphics_drawable_Drawable_Landroid_graphics_drawable_Drawable_ILorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_Lorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_ctor_Ljava_util_List_Landroid_graphics_drawable_Drawable_Landroid_graphics_drawable_Drawable_ILorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_Lorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;Landroid/graphics/drawable/Drawable;Landroid/graphics/drawable/Drawable;ILorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;Lorg/osmdroid/ResourceProxy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_Landroid_graphics_drawable_Drawable_Landroid_graphics_drawable_Drawable_ILorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_Lorg_osmdroid_ResourceProxy_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_util_List_Landroid_graphics_drawable_Drawable_Landroid_graphics_drawable_Drawable_ILorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_Lorg_osmdroid_ResourceProxy_, new JValue (native_p0), new JValue (p1), new JValue (p2), new JValue (p3), new JValue (p4), new JValue (p5));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_util_List_Lorg_osmdroid_views_overlay_ItemizedIconOverlay_OnItemGestureListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/constructor[@name='ItemizedOverlayWithFocus' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List'] and parameter[3][@type='org.osmdroid.views.overlay.ItemizedIconOverlay.OnItemGestureListener']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/List;Lorg/osmdroid/views/overlay/ItemizedIconOverlay$OnItemGestureListener;)V", "")]
		public ItemizedOverlayWithFocus (global::Android.Content.Context p0, global::System.Collections.IList p1, global::Osmdroid.Views.Overlay.ItemizedIconOverlay.IOnItemGestureListener p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);;
			if (GetType () != typeof (ItemizedOverlayWithFocus)) {
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

		static Delegate cb_getFocusedItem;
#pragma warning disable 0169
		static Delegate GetGetFocusedItemHandler ()
		{
			if (cb_getFocusedItem == null)
				cb_getFocusedItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFocusedItem);
			return cb_getFocusedItem;
		}

		static IntPtr n_GetFocusedItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlayWithFocus __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlayWithFocus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FocusedItem);
		}
#pragma warning restore 0169

		static Delegate cb_setFocusedItem_Lorg_osmdroid_views_overlay_OverlayItem_;
#pragma warning disable 0169
		static Delegate GetSetFocusedItem_Lorg_osmdroid_views_overlay_OverlayItem_Handler ()
		{
			if (cb_setFocusedItem_Lorg_osmdroid_views_overlay_OverlayItem_ == null)
				cb_setFocusedItem_Lorg_osmdroid_views_overlay_OverlayItem_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFocusedItem_Lorg_osmdroid_views_overlay_OverlayItem_);
			return cb_setFocusedItem_Lorg_osmdroid_views_overlay_OverlayItem_;
		}

		static void n_SetFocusedItem_Lorg_osmdroid_views_overlay_OverlayItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pItem)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlayWithFocus __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlayWithFocus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object pItem = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_pItem, JniHandleOwnership.DoNotTransfer);
			__this.FocusedItem = pItem;
		}
#pragma warning restore 0169

		static IntPtr id_getFocusedItem;
		static IntPtr id_setFocusedItem_Lorg_osmdroid_views_overlay_OverlayItem_;
		public virtual global::Java.Lang.Object FocusedItem {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/method[@name='getFocusedItem' and count(parameter)=0]"
			[Register ("getFocusedItem", "()Lorg/osmdroid/views/overlay/OverlayItem;", "GetGetFocusedItemHandler")]
			get {
				if (id_getFocusedItem == IntPtr.Zero)
					id_getFocusedItem = JNIEnv.GetMethodID (class_ref, "getFocusedItem", "()Lorg/osmdroid/views/overlay/OverlayItem;");

				if (GetType () == ThresholdType)
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getFocusedItem), JniHandleOwnership.TransferLocalRef);
				else
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFocusedItem", "()Lorg/osmdroid/views/overlay/OverlayItem;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/method[@name='setFocusedItem' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.overlay.OverlayItem']]"
			[Register ("setFocusedItem", "(Lorg/osmdroid/views/overlay/OverlayItem;)V", "GetSetFocusedItem_Lorg_osmdroid_views_overlay_OverlayItem_Handler")]
			set {
				if (id_setFocusedItem_Lorg_osmdroid_views_overlay_OverlayItem_ == IntPtr.Zero)
					id_setFocusedItem_Lorg_osmdroid_views_overlay_OverlayItem_ = JNIEnv.GetMethodID (class_ref, "setFocusedItem", "(Lorg/osmdroid/views/overlay/OverlayItem;)V");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setFocusedItem_Lorg_osmdroid_views_overlay_OverlayItem_, new JValue (native_value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFocusedItem", "(Lorg/osmdroid/views/overlay/OverlayItem;)V"), new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == null)
				cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z);
			return cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		}

		static void n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_osmv, bool shadow)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlayWithFocus __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlayWithFocus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView osmv = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_osmv, JniHandleOwnership.DoNotTransfer);
			__this.Draw (c, osmv, shadow);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V", "GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler")]
		public override void Draw (global::Android.Graphics.Canvas c, global::Osmdroid.Views.MapView osmv, bool shadow)
		{
			if (id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z, new JValue (c), new JValue (osmv), new JValue (shadow));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V"), new JValue (c), new JValue (osmv), new JValue (shadow));
		}

		static Delegate cb_setFocusItemsOnTap_Z;
#pragma warning disable 0169
		static Delegate GetSetFocusItemsOnTap_ZHandler ()
		{
			if (cb_setFocusItemsOnTap_Z == null)
				cb_setFocusItemsOnTap_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFocusItemsOnTap_Z);
			return cb_setFocusItemsOnTap_Z;
		}

		static void n_SetFocusItemsOnTap_Z (IntPtr jnienv, IntPtr native__this, bool doit)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlayWithFocus __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlayWithFocus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFocusItemsOnTap (doit);
		}
#pragma warning restore 0169

		static IntPtr id_setFocusItemsOnTap_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/method[@name='setFocusItemsOnTap' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFocusItemsOnTap", "(Z)V", "GetSetFocusItemsOnTap_ZHandler")]
		public virtual void SetFocusItemsOnTap (bool doit)
		{
			if (id_setFocusItemsOnTap_Z == IntPtr.Zero)
				id_setFocusItemsOnTap_Z = JNIEnv.GetMethodID (class_ref, "setFocusItemsOnTap", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setFocusItemsOnTap_Z, new JValue (doit));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFocusItemsOnTap", "(Z)V"), new JValue (doit));
		}

		static Delegate cb_setFocusedItem_I;
#pragma warning disable 0169
		static Delegate GetSetFocusedItem_IHandler ()
		{
			if (cb_setFocusedItem_I == null)
				cb_setFocusedItem_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFocusedItem_I);
			return cb_setFocusedItem_I;
		}

		static void n_SetFocusedItem_I (IntPtr jnienv, IntPtr native__this, int pIndex)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlayWithFocus __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlayWithFocus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFocusedItem (pIndex);
		}
#pragma warning restore 0169

		static IntPtr id_setFocusedItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/method[@name='setFocusedItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFocusedItem", "(I)V", "GetSetFocusedItem_IHandler")]
		public virtual void SetFocusedItem (int pIndex)
		{
			if (id_setFocusedItem_I == IntPtr.Zero)
				id_setFocusedItem_I = JNIEnv.GetMethodID (class_ref, "setFocusedItem", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setFocusedItem_I, new JValue (pIndex));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFocusedItem", "(I)V"), new JValue (pIndex));
		}

		static Delegate cb_unSetFocusedItem;
#pragma warning disable 0169
		static Delegate GetUnSetFocusedItemHandler ()
		{
			if (cb_unSetFocusedItem == null)
				cb_unSetFocusedItem = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UnSetFocusedItem);
			return cb_unSetFocusedItem;
		}

		static void n_UnSetFocusedItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.ItemizedOverlayWithFocus __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ItemizedOverlayWithFocus> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UnSetFocusedItem ();
		}
#pragma warning restore 0169

		static IntPtr id_unSetFocusedItem;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ItemizedOverlayWithFocus']/method[@name='unSetFocusedItem' and count(parameter)=0]"
		[Register ("unSetFocusedItem", "()V", "GetUnSetFocusedItemHandler")]
		public virtual void UnSetFocusedItem ()
		{
			if (id_unSetFocusedItem == IntPtr.Zero)
				id_unSetFocusedItem = JNIEnv.GetMethodID (class_ref, "unSetFocusedItem", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_unSetFocusedItem);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "unSetFocusedItem", "()V"));
		}

	}
}
