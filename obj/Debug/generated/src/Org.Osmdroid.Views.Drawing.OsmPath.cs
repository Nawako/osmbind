using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Views.Drawing {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.drawing']/class[@name='OsmPath']"
	[global::Android.Runtime.Register ("org/osmdroid/views/drawing/OsmPath", DoNotGenerateAcw=true)]
	public partial class OsmPath : global::Android.Graphics.Path {


		static IntPtr mReferencePoint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.drawing']/class[@name='OsmPath']/field[@name='mReferencePoint']"
		[Register ("mReferencePoint")]
		protected global::Android.Graphics.Point MReferencePoint {
			get {
				if (mReferencePoint_jfieldId == IntPtr.Zero)
					mReferencePoint_jfieldId = JNIEnv.GetFieldID (class_ref, "mReferencePoint", "Landroid/graphics/Point;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mReferencePoint_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mReferencePoint_jfieldId == IntPtr.Zero)
					mReferencePoint_jfieldId = JNIEnv.GetFieldID (class_ref, "mReferencePoint", "Landroid/graphics/Point;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mReferencePoint_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/drawing/OsmPath", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OsmPath); }
		}

		protected OsmPath (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.drawing']/class[@name='OsmPath']/constructor[@name='OsmPath' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public OsmPath () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OsmPath)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static IntPtr id_ctor_Landroid_graphics_Path_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.drawing']/class[@name='OsmPath']/constructor[@name='OsmPath' and count(parameter)=1 and parameter[1][@type='android.graphics.Path']]"
		[Register (".ctor", "(Landroid/graphics/Path;)V", "")]
		public OsmPath (global::Android.Graphics.Path src) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (OsmPath)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/graphics/Path;)V", new JValue (src)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/graphics/Path;)V", new JValue (src));
				return;
			}

			if (id_ctor_Landroid_graphics_Path_ == IntPtr.Zero)
				id_ctor_Landroid_graphics_Path_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/Path;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_Path_, new JValue (src)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_graphics_Path_, new JValue (src));
		}

		static Delegate cb_onDrawCycle_Lorg_osmdroid_views_Projection_;
#pragma warning disable 0169
		static Delegate GetOnDrawCycle_Lorg_osmdroid_views_Projection_Handler ()
		{
			if (cb_onDrawCycle_Lorg_osmdroid_views_Projection_ == null)
				cb_onDrawCycle_Lorg_osmdroid_views_Projection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDrawCycle_Lorg_osmdroid_views_Projection_);
			return cb_onDrawCycle_Lorg_osmdroid_views_Projection_;
		}

		static void n_OnDrawCycle_Lorg_osmdroid_views_Projection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_proj)
		{
			global::Org.Osmdroid.Views.Drawing.OsmPath __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Views.Drawing.OsmPath> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Projection proj = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Projection> (native_proj, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawCycle (proj);
		}
#pragma warning restore 0169

		static IntPtr id_onDrawCycle_Lorg_osmdroid_views_Projection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.drawing']/class[@name='OsmPath']/method[@name='onDrawCycle' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.Projection']]"
		[Register ("onDrawCycle", "(Lorg/osmdroid/views/Projection;)V", "GetOnDrawCycle_Lorg_osmdroid_views_Projection_Handler")]
		public virtual void OnDrawCycle (global::Osmdroid.Views.Projection proj)
		{
			if (id_onDrawCycle_Lorg_osmdroid_views_Projection_ == IntPtr.Zero)
				id_onDrawCycle_Lorg_osmdroid_views_Projection_ = JNIEnv.GetMethodID (class_ref, "onDrawCycle", "(Lorg/osmdroid/views/Projection;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_onDrawCycle_Lorg_osmdroid_views_Projection_, new JValue (proj));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDrawCycle", "(Lorg/osmdroid/views/Projection;)V"), new JValue (proj));
		}

	}
}
