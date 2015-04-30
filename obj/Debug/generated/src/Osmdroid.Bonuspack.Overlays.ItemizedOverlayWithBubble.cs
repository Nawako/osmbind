using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Bonuspack.Overlays {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ItemizedOverlayWithBubble']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/overlays/ItemizedOverlayWithBubble", DoNotGenerateAcw=true)]
	public partial class ItemizedOverlayWithBubble : global::Osmdroid.Views.Overlay.ItemizedIconOverlay {


		static IntPtr mBubble_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ItemizedOverlayWithBubble']/field[@name='mBubble']"
		[Register ("mBubble")]
		protected global::Osmdroid.Bonuspack.Overlays.InfoWindow MBubble {
			get {
				if (mBubble_jfieldId == IntPtr.Zero)
					mBubble_jfieldId = JNIEnv.GetFieldID (class_ref, "mBubble", "Lorg/osmdroid/bonuspack/overlays/InfoWindow;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mBubble_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.InfoWindow> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBubble_jfieldId == IntPtr.Zero)
					mBubble_jfieldId = JNIEnv.GetFieldID (class_ref, "mBubble", "Lorg/osmdroid/bonuspack/overlays/InfoWindow;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mBubble_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mItemWithBubble_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ItemizedOverlayWithBubble']/field[@name='mItemWithBubble']"
		[Register ("mItemWithBubble")]
		protected global::Osmdroid.Views.Overlay.OverlayItem MItemWithBubble {
			get {
				if (mItemWithBubble_jfieldId == IntPtr.Zero)
					mItemWithBubble_jfieldId = JNIEnv.GetFieldID (class_ref, "mItemWithBubble", "Lorg/osmdroid/views/overlay/OverlayItem;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mItemWithBubble_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mItemWithBubble_jfieldId == IntPtr.Zero)
					mItemWithBubble_jfieldId = JNIEnv.GetFieldID (class_ref, "mItemWithBubble", "Lorg/osmdroid/views/overlay/OverlayItem;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mItemWithBubble_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/overlays/ItemizedOverlayWithBubble", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ItemizedOverlayWithBubble); }
		}

		protected ItemizedOverlayWithBubble (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_util_List_Lorg_osmdroid_views_MapView_Lorg_osmdroid_bonuspack_overlays_InfoWindow_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ItemizedOverlayWithBubble']/constructor[@name='ItemizedOverlayWithBubble' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List'] and parameter[3][@type='org.osmdroid.views.MapView'] and parameter[4][@type='org.osmdroid.bonuspack.overlays.InfoWindow']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/List;Lorg/osmdroid/views/MapView;Lorg/osmdroid/bonuspack/overlays/InfoWindow;)V", "")]
		public ItemizedOverlayWithBubble (global::Android.Content.Context p0, global::System.Collections.IList p1, global::Osmdroid.Views.MapView p2, global::Osmdroid.Bonuspack.Overlays.InfoWindow p3) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);;
			if (GetType () != typeof (ItemizedOverlayWithBubble)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/util/List;Lorg/osmdroid/views/MapView;Lorg/osmdroid/bonuspack/overlays/InfoWindow;)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/util/List;Lorg/osmdroid/views/MapView;Lorg/osmdroid/bonuspack/overlays/InfoWindow;)V", new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_util_List_Lorg_osmdroid_views_MapView_Lorg_osmdroid_bonuspack_overlays_InfoWindow_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_util_List_Lorg_osmdroid_views_MapView_Lorg_osmdroid_bonuspack_overlays_InfoWindow_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/util/List;Lorg/osmdroid/views/MapView;Lorg/osmdroid/bonuspack/overlays/InfoWindow;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_Lorg_osmdroid_views_MapView_Lorg_osmdroid_bonuspack_overlays_InfoWindow_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_Lorg_osmdroid_views_MapView_Lorg_osmdroid_bonuspack_overlays_InfoWindow_, new JValue (p0), new JValue (native_p1), new JValue (p2), new JValue (p3));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Landroid_content_Context_Ljava_util_List_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ItemizedOverlayWithBubble']/constructor[@name='ItemizedOverlayWithBubble' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.List'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/util/List;Lorg/osmdroid/views/MapView;)V", "")]
		public ItemizedOverlayWithBubble (global::Android.Content.Context p0, global::System.Collections.IList p1, global::Osmdroid.Views.MapView p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = global::Android.Runtime.JavaList.ToLocalJniHandle (p1);;
			if (GetType () != typeof (ItemizedOverlayWithBubble)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Ljava/util/List;Lorg/osmdroid/views/MapView;)V", new JValue (p0), new JValue (native_p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Ljava/util/List;Lorg/osmdroid/views/MapView;)V", new JValue (p0), new JValue (native_p1), new JValue (p2));
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Landroid_content_Context_Ljava_util_List_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Ljava_util_List_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Ljava/util/List;Lorg/osmdroid/views/MapView;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_Lorg_osmdroid_views_MapView_, new JValue (p0), new JValue (native_p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Ljava_util_List_Lorg_osmdroid_views_MapView_, new JValue (p0), new JValue (native_p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_getBoundingBoxE6;
#pragma warning disable 0169
		static Delegate GetGetBoundingBoxE6Handler ()
		{
			if (cb_getBoundingBoxE6 == null)
				cb_getBoundingBoxE6 = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBoundingBoxE6);
			return cb_getBoundingBoxE6;
		}

		static IntPtr n_GetBoundingBoxE6 (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.ItemizedOverlayWithBubble __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ItemizedOverlayWithBubble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BoundingBoxE6);
		}
#pragma warning restore 0169

		static IntPtr id_getBoundingBoxE6;
		public virtual global::Org.Osmdroid.Util.BoundingBoxE6 BoundingBoxE6 {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ItemizedOverlayWithBubble']/method[@name='getBoundingBoxE6' and count(parameter)=0]"
			[Register ("getBoundingBoxE6", "()Lorg/osmdroid/util/BoundingBoxE6;", "GetGetBoundingBoxE6Handler")]
			get {
				if (id_getBoundingBoxE6 == IntPtr.Zero)
					id_getBoundingBoxE6 = JNIEnv.GetMethodID (class_ref, "getBoundingBoxE6", "()Lorg/osmdroid/util/BoundingBoxE6;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.BoundingBoxE6> (JNIEnv.CallObjectMethod  (Handle, id_getBoundingBoxE6), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.BoundingBoxE6> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBoundingBoxE6", "()Lorg/osmdroid/util/BoundingBoxE6;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBubbledItem;
#pragma warning disable 0169
		static Delegate GetGetBubbledItemHandler ()
		{
			if (cb_getBubbledItem == null)
				cb_getBubbledItem = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBubbledItem);
			return cb_getBubbledItem;
		}

		static IntPtr n_GetBubbledItem (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.ItemizedOverlayWithBubble __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ItemizedOverlayWithBubble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BubbledItem);
		}
#pragma warning restore 0169

		static IntPtr id_getBubbledItem;
		public virtual global::Osmdroid.Views.Overlay.OverlayItem BubbledItem {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ItemizedOverlayWithBubble']/method[@name='getBubbledItem' and count(parameter)=0]"
			[Register ("getBubbledItem", "()Lorg/osmdroid/views/overlay/OverlayItem;", "GetGetBubbledItemHandler")]
			get {
				if (id_getBubbledItem == IntPtr.Zero)
					id_getBubbledItem = JNIEnv.GetMethodID (class_ref, "getBubbledItem", "()Lorg/osmdroid/views/overlay/OverlayItem;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem> (JNIEnv.CallObjectMethod  (Handle, id_getBubbledItem), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.OverlayItem> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBubbledItem", "()Lorg/osmdroid/views/overlay/OverlayItem;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getBubbledItemId;
#pragma warning disable 0169
		static Delegate GetGetBubbledItemIdHandler ()
		{
			if (cb_getBubbledItemId == null)
				cb_getBubbledItemId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBubbledItemId);
			return cb_getBubbledItemId;
		}

		static int n_GetBubbledItemId (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.ItemizedOverlayWithBubble __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ItemizedOverlayWithBubble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BubbledItemId;
		}
#pragma warning restore 0169

		static IntPtr id_getBubbledItemId;
		public virtual int BubbledItemId {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ItemizedOverlayWithBubble']/method[@name='getBubbledItemId' and count(parameter)=0]"
			[Register ("getBubbledItemId", "()I", "GetGetBubbledItemIdHandler")]
			get {
				if (id_getBubbledItemId == IntPtr.Zero)
					id_getBubbledItemId = JNIEnv.GetMethodID (class_ref, "getBubbledItemId", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getBubbledItemId);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBubbledItemId", "()I"));
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

		static void n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Osmdroid.Bonuspack.Overlays.ItemizedOverlayWithBubble __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ItemizedOverlayWithBubble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ItemizedOverlayWithBubble']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V", "GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler")]
		public override void Draw (global::Android.Graphics.Canvas p0, global::Osmdroid.Views.MapView p1, bool p2)
		{
			if (id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_hideBubble;
#pragma warning disable 0169
		static Delegate GetHideBubbleHandler ()
		{
			if (cb_hideBubble == null)
				cb_hideBubble = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_HideBubble);
			return cb_hideBubble;
		}

		static void n_HideBubble (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Bonuspack.Overlays.ItemizedOverlayWithBubble __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ItemizedOverlayWithBubble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HideBubble ();
		}
#pragma warning restore 0169

		static IntPtr id_hideBubble;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ItemizedOverlayWithBubble']/method[@name='hideBubble' and count(parameter)=0]"
		[Register ("hideBubble", "()V", "GetHideBubbleHandler")]
		public virtual void HideBubble ()
		{
			if (id_hideBubble == IntPtr.Zero)
				id_hideBubble = JNIEnv.GetMethodID (class_ref, "hideBubble", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_hideBubble);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hideBubble", "()V"));
		}

		static Delegate cb_showBubbleOnItem_ILorg_osmdroid_views_MapView_Z;
#pragma warning disable 0169
		static Delegate GetShowBubbleOnItem_ILorg_osmdroid_views_MapView_ZHandler ()
		{
			if (cb_showBubbleOnItem_ILorg_osmdroid_views_MapView_Z == null)
				cb_showBubbleOnItem_ILorg_osmdroid_views_MapView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, bool>) n_ShowBubbleOnItem_ILorg_osmdroid_views_MapView_Z);
			return cb_showBubbleOnItem_ILorg_osmdroid_views_MapView_Z;
		}

		static void n_ShowBubbleOnItem_ILorg_osmdroid_views_MapView_Z (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, bool p2)
		{
			global::Osmdroid.Bonuspack.Overlays.ItemizedOverlayWithBubble __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ItemizedOverlayWithBubble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ShowBubbleOnItem (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_showBubbleOnItem_ILorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ItemizedOverlayWithBubble']/method[@name='showBubbleOnItem' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("showBubbleOnItem", "(ILorg/osmdroid/views/MapView;Z)V", "GetShowBubbleOnItem_ILorg_osmdroid_views_MapView_ZHandler")]
		public virtual void ShowBubbleOnItem (int p0, global::Osmdroid.Views.MapView p1, bool p2)
		{
			if (id_showBubbleOnItem_ILorg_osmdroid_views_MapView_Z == IntPtr.Zero)
				id_showBubbleOnItem_ILorg_osmdroid_views_MapView_Z = JNIEnv.GetMethodID (class_ref, "showBubbleOnItem", "(ILorg/osmdroid/views/MapView;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_showBubbleOnItem_ILorg_osmdroid_views_MapView_Z, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showBubbleOnItem", "(ILorg/osmdroid/views/MapView;Z)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_showBubbleOnItem_Lorg_osmdroid_bonuspack_overlays_ExtendedOverlayItem_Lorg_osmdroid_views_MapView_Z;
#pragma warning disable 0169
		static Delegate GetShowBubbleOnItem_Lorg_osmdroid_bonuspack_overlays_ExtendedOverlayItem_Lorg_osmdroid_views_MapView_ZHandler ()
		{
			if (cb_showBubbleOnItem_Lorg_osmdroid_bonuspack_overlays_ExtendedOverlayItem_Lorg_osmdroid_views_MapView_Z == null)
				cb_showBubbleOnItem_Lorg_osmdroid_bonuspack_overlays_ExtendedOverlayItem_Lorg_osmdroid_views_MapView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_ShowBubbleOnItem_Lorg_osmdroid_bonuspack_overlays_ExtendedOverlayItem_Lorg_osmdroid_views_MapView_Z);
			return cb_showBubbleOnItem_Lorg_osmdroid_bonuspack_overlays_ExtendedOverlayItem_Lorg_osmdroid_views_MapView_Z;
		}

		static void n_ShowBubbleOnItem_Lorg_osmdroid_bonuspack_overlays_ExtendedOverlayItem_Lorg_osmdroid_views_MapView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Osmdroid.Bonuspack.Overlays.ItemizedOverlayWithBubble __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ItemizedOverlayWithBubble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ShowBubbleOnItem (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_showBubbleOnItem_Lorg_osmdroid_bonuspack_overlays_ExtendedOverlayItem_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.overlays']/class[@name='ItemizedOverlayWithBubble']/method[@name='showBubbleOnItem' and count(parameter)=3 and parameter[1][@type='org.osmdroid.bonuspack.overlays.ExtendedOverlayItem'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("showBubbleOnItem", "(Lorg/osmdroid/bonuspack/overlays/ExtendedOverlayItem;Lorg/osmdroid/views/MapView;Z)V", "GetShowBubbleOnItem_Lorg_osmdroid_bonuspack_overlays_ExtendedOverlayItem_Lorg_osmdroid_views_MapView_ZHandler")]
		public virtual void ShowBubbleOnItem (global::Osmdroid.Bonuspack.Overlays.ExtendedOverlayItem p0, global::Osmdroid.Views.MapView p1, bool p2)
		{
			if (id_showBubbleOnItem_Lorg_osmdroid_bonuspack_overlays_ExtendedOverlayItem_Lorg_osmdroid_views_MapView_Z == IntPtr.Zero)
				id_showBubbleOnItem_Lorg_osmdroid_bonuspack_overlays_ExtendedOverlayItem_Lorg_osmdroid_views_MapView_Z = JNIEnv.GetMethodID (class_ref, "showBubbleOnItem", "(Lorg/osmdroid/bonuspack/overlays/ExtendedOverlayItem;Lorg/osmdroid/views/MapView;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_showBubbleOnItem_Lorg_osmdroid_bonuspack_overlays_ExtendedOverlayItem_Lorg_osmdroid_views_MapView_Z, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "showBubbleOnItem", "(Lorg/osmdroid/bonuspack/overlays/ExtendedOverlayItem;Lorg/osmdroid/views/MapView;Z)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

	}
}
