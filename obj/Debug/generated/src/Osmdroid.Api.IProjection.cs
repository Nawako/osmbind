using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IProjection']"
	[Register ("org/osmdroid/api/IProjection", "", "Osmdroid.Api.IProjectionInvoker")]
	public partial interface IProjection : IJavaObject {

		global::Osmdroid.Api.IGeoPoint NorthEast {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IProjection']/method[@name='getNorthEast' and count(parameter)=0]"
			[Register ("getNorthEast", "()Lorg/osmdroid/api/IGeoPoint;", "GetGetNorthEastHandler:Osmdroid.Api.IProjectionInvoker, OsmdroidAndroidBinding")] get;
		}

		global::Osmdroid.Api.IGeoPoint SouthWest {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IProjection']/method[@name='getSouthWest' and count(parameter)=0]"
			[Register ("getSouthWest", "()Lorg/osmdroid/api/IGeoPoint;", "GetGetSouthWestHandler:Osmdroid.Api.IProjectionInvoker, OsmdroidAndroidBinding")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IProjection']/method[@name='fromPixels' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("fromPixels", "(II)Lorg/osmdroid/api/IGeoPoint;", "GetFromPixels_IIHandler:Osmdroid.Api.IProjectionInvoker, OsmdroidAndroidBinding")]
		global::Osmdroid.Api.IGeoPoint FromPixels (int x, int y);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IProjection']/method[@name='metersToEquatorPixels' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("metersToEquatorPixels", "(F)F", "GetMetersToEquatorPixels_FHandler:Osmdroid.Api.IProjectionInvoker, OsmdroidAndroidBinding")]
		float MetersToEquatorPixels (float meters);

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.api']/interface[@name='IProjection']/method[@name='toPixels' and count(parameter)=2 and parameter[1][@type='org.osmdroid.api.IGeoPoint'] and parameter[2][@type='android.graphics.Point']]"
		[Register ("toPixels", "(Lorg/osmdroid/api/IGeoPoint;Landroid/graphics/Point;)Landroid/graphics/Point;", "GetToPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_Handler:Osmdroid.Api.IProjectionInvoker, OsmdroidAndroidBinding")]
		global::Android.Graphics.Point ToPixels (global::Osmdroid.Api.IGeoPoint @in, global::Android.Graphics.Point @out);

	}

	[global::Android.Runtime.Register ("org/osmdroid/api/IProjection", DoNotGenerateAcw=true)]
	internal class IProjectionInvoker : global::Java.Lang.Object, IProjection {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/api/IProjection");
		IntPtr class_ref;

		public static IProjection GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IProjection> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.api.IProjection"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IProjectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IProjectionInvoker); }
		}

		static Delegate cb_getNorthEast;
#pragma warning disable 0169
		static Delegate GetGetNorthEastHandler ()
		{
			if (cb_getNorthEast == null)
				cb_getNorthEast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNorthEast);
			return cb_getNorthEast;
		}

		static IntPtr n_GetNorthEast (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IProjection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IProjection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NorthEast);
		}
#pragma warning restore 0169

		IntPtr id_getNorthEast;
		public global::Osmdroid.Api.IGeoPoint NorthEast {
			get {
				if (id_getNorthEast == IntPtr.Zero)
					id_getNorthEast = JNIEnv.GetMethodID (class_ref, "getNorthEast", "()Lorg/osmdroid/api/IGeoPoint;");
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (JNIEnv.CallObjectMethod (Handle, id_getNorthEast), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSouthWest;
#pragma warning disable 0169
		static Delegate GetGetSouthWestHandler ()
		{
			if (cb_getSouthWest == null)
				cb_getSouthWest = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSouthWest);
			return cb_getSouthWest;
		}

		static IntPtr n_GetSouthWest (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Api.IProjection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IProjection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SouthWest);
		}
#pragma warning restore 0169

		IntPtr id_getSouthWest;
		public global::Osmdroid.Api.IGeoPoint SouthWest {
			get {
				if (id_getSouthWest == IntPtr.Zero)
					id_getSouthWest = JNIEnv.GetMethodID (class_ref, "getSouthWest", "()Lorg/osmdroid/api/IGeoPoint;");
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (JNIEnv.CallObjectMethod (Handle, id_getSouthWest), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_fromPixels_II;
#pragma warning disable 0169
		static Delegate GetFromPixels_IIHandler ()
		{
			if (cb_fromPixels_II == null)
				cb_fromPixels_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_FromPixels_II);
			return cb_fromPixels_II;
		}

		static IntPtr n_FromPixels_II (IntPtr jnienv, IntPtr native__this, int x, int y)
		{
			global::Osmdroid.Api.IProjection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IProjection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FromPixels (x, y));
		}
#pragma warning restore 0169

		IntPtr id_fromPixels_II;
		public global::Osmdroid.Api.IGeoPoint FromPixels (int x, int y)
		{
			if (id_fromPixels_II == IntPtr.Zero)
				id_fromPixels_II = JNIEnv.GetMethodID (class_ref, "fromPixels", "(II)Lorg/osmdroid/api/IGeoPoint;");
			return global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (JNIEnv.CallObjectMethod (Handle, id_fromPixels_II, new JValue (x), new JValue (y)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_metersToEquatorPixels_F;
#pragma warning disable 0169
		static Delegate GetMetersToEquatorPixels_FHandler ()
		{
			if (cb_metersToEquatorPixels_F == null)
				cb_metersToEquatorPixels_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float>) n_MetersToEquatorPixels_F);
			return cb_metersToEquatorPixels_F;
		}

		static float n_MetersToEquatorPixels_F (IntPtr jnienv, IntPtr native__this, float meters)
		{
			global::Osmdroid.Api.IProjection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IProjection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MetersToEquatorPixels (meters);
		}
#pragma warning restore 0169

		IntPtr id_metersToEquatorPixels_F;
		public float MetersToEquatorPixels (float meters)
		{
			if (id_metersToEquatorPixels_F == IntPtr.Zero)
				id_metersToEquatorPixels_F = JNIEnv.GetMethodID (class_ref, "metersToEquatorPixels", "(F)F");
			return JNIEnv.CallFloatMethod (Handle, id_metersToEquatorPixels_F, new JValue (meters));
		}

		static Delegate cb_toPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetToPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_Handler ()
		{
			if (cb_toPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_ == null)
				cb_toPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ToPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_);
			return cb_toPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_;
		}

		static IntPtr n_ToPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in, IntPtr native__out)
		{
			global::Osmdroid.Api.IProjection __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IProjection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Api.IGeoPoint @in = (global::Osmdroid.Api.IGeoPoint)global::Java.Lang.Object.GetObject<global::Osmdroid.Api.IGeoPoint> (native__in, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point @out = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native__out, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToPixels (@in, @out));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_toPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_;
		public global::Android.Graphics.Point ToPixels (global::Osmdroid.Api.IGeoPoint @in, global::Android.Graphics.Point @out)
		{
			if (id_toPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_ == IntPtr.Zero)
				id_toPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_ = JNIEnv.GetMethodID (class_ref, "toPixels", "(Lorg/osmdroid/api/IGeoPoint;Landroid/graphics/Point;)Landroid/graphics/Point;");
			global::Android.Graphics.Point __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (JNIEnv.CallObjectMethod (Handle, id_toPixels_Lorg_osmdroid_api_IGeoPoint_Landroid_graphics_Point_, new JValue (@in), new JValue (@out)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
