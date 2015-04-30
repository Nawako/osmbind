using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.util']/class[@name='Position']"
	[global::Android.Runtime.Register ("org/osmdroid/util/Position", DoNotGenerateAcw=true)]
	public partial class Position : global::Java.Lang.Object, global::Osmdroid.Api.IPosition {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/util/Position", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Position); }
		}

		protected Position (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_DD;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.util']/class[@name='Position']/constructor[@name='Position' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register (".ctor", "(DD)V", "")]
		public Position (double aLatitude, double aLongitude) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (Position)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(DD)V", new JValue (aLatitude), new JValue (aLongitude)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(DD)V", new JValue (aLatitude), new JValue (aLongitude));
				return;
			}

			if (id_ctor_DD == IntPtr.Zero)
				id_ctor_DD = JNIEnv.GetMethodID (class_ref, "<init>", "(DD)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_DD, new JValue (aLatitude), new JValue (aLongitude)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_DD, new JValue (aLatitude), new JValue (aLongitude));
		}

		static Delegate cb_getBearing;
#pragma warning disable 0169
		static Delegate GetGetBearingHandler ()
		{
			if (cb_getBearing == null)
				cb_getBearing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBearing);
			return cb_getBearing;
		}

		static float n_GetBearing (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.Position __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.Position> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Bearing;
		}
#pragma warning restore 0169

		static Delegate cb_setBearing_F;
#pragma warning disable 0169
		static Delegate GetSetBearing_FHandler ()
		{
			if (cb_setBearing_F == null)
				cb_setBearing_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBearing_F);
			return cb_setBearing_F;
		}

		static void n_SetBearing_F (IntPtr jnienv, IntPtr native__this, float aBearing)
		{
			global::Osmdroid.Util.Position __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.Position> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Bearing = aBearing;
		}
#pragma warning restore 0169

		static IntPtr id_getBearing;
		static IntPtr id_setBearing_F;
		public virtual float Bearing {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='Position']/method[@name='getBearing' and count(parameter)=0]"
			[Register ("getBearing", "()F", "GetGetBearingHandler")]
			get {
				if (id_getBearing == IntPtr.Zero)
					id_getBearing = JNIEnv.GetMethodID (class_ref, "getBearing", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getBearing);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBearing", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='Position']/method[@name='setBearing' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBearing", "(F)V", "GetSetBearing_FHandler")]
			set {
				if (id_setBearing_F == IntPtr.Zero)
					id_setBearing_F = JNIEnv.GetMethodID (class_ref, "setBearing", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBearing_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBearing", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_hasBearing;
#pragma warning disable 0169
		static Delegate GetHasBearingHandler ()
		{
			if (cb_hasBearing == null)
				cb_hasBearing = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasBearing);
			return cb_hasBearing;
		}

		static bool n_HasBearing (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.Position __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.Position> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasBearing;
		}
#pragma warning restore 0169

		static IntPtr id_hasBearing;
		public virtual bool HasBearing {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='Position']/method[@name='hasBearing' and count(parameter)=0]"
			[Register ("hasBearing", "()Z", "GetHasBearingHandler")]
			get {
				if (id_hasBearing == IntPtr.Zero)
					id_hasBearing = JNIEnv.GetMethodID (class_ref, "hasBearing", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_hasBearing);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasBearing", "()Z"));
			}
		}

		static Delegate cb_hasZoomLevel;
#pragma warning disable 0169
		static Delegate GetHasZoomLevelHandler ()
		{
			if (cb_hasZoomLevel == null)
				cb_hasZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasZoomLevel);
			return cb_hasZoomLevel;
		}

		static bool n_HasZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.Position __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.Position> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_hasZoomLevel;
		public virtual bool HasZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='Position']/method[@name='hasZoomLevel' and count(parameter)=0]"
			[Register ("hasZoomLevel", "()Z", "GetHasZoomLevelHandler")]
			get {
				if (id_hasZoomLevel == IntPtr.Zero)
					id_hasZoomLevel = JNIEnv.GetMethodID (class_ref, "hasZoomLevel", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_hasZoomLevel);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasZoomLevel", "()Z"));
			}
		}

		static Delegate cb_getLatitude;
#pragma warning disable 0169
		static Delegate GetGetLatitudeHandler ()
		{
			if (cb_getLatitude == null)
				cb_getLatitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLatitude);
			return cb_getLatitude;
		}

		static double n_GetLatitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.Position __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.Position> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Latitude;
		}
#pragma warning restore 0169

		static IntPtr id_getLatitude;
		public virtual double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='Position']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler")]
			get {
				if (id_getLatitude == IntPtr.Zero)
					id_getLatitude = JNIEnv.GetMethodID (class_ref, "getLatitude", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getLatitude);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLatitude", "()D"));
			}
		}

		static Delegate cb_getLongitude;
#pragma warning disable 0169
		static Delegate GetGetLongitudeHandler ()
		{
			if (cb_getLongitude == null)
				cb_getLongitude = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetLongitude);
			return cb_getLongitude;
		}

		static double n_GetLongitude (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.Position __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.Position> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Longitude;
		}
#pragma warning restore 0169

		static IntPtr id_getLongitude;
		public virtual double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='Position']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler")]
			get {
				if (id_getLongitude == IntPtr.Zero)
					id_getLongitude = JNIEnv.GetMethodID (class_ref, "getLongitude", "()D");

				if (GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod  (Handle, id_getLongitude);
				else
					return JNIEnv.CallNonvirtualDoubleMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLongitude", "()D"));
			}
		}

		static Delegate cb_getZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetZoomLevelHandler ()
		{
			if (cb_getZoomLevel == null)
				cb_getZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetZoomLevel);
			return cb_getZoomLevel;
		}

		static float n_GetZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.Position __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.Position> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomLevel;
		}
#pragma warning restore 0169

		static Delegate cb_setZoomLevel_F;
#pragma warning disable 0169
		static Delegate GetSetZoomLevel_FHandler ()
		{
			if (cb_setZoomLevel_F == null)
				cb_setZoomLevel_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetZoomLevel_F);
			return cb_setZoomLevel_F;
		}

		static void n_SetZoomLevel_F (IntPtr jnienv, IntPtr native__this, float aZoomLevel)
		{
			global::Osmdroid.Util.Position __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.Position> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomLevel = aZoomLevel;
		}
#pragma warning restore 0169

		static IntPtr id_getZoomLevel;
		static IntPtr id_setZoomLevel_F;
		public virtual float ZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='Position']/method[@name='getZoomLevel' and count(parameter)=0]"
			[Register ("getZoomLevel", "()F", "GetGetZoomLevelHandler")]
			get {
				if (id_getZoomLevel == IntPtr.Zero)
					id_getZoomLevel = JNIEnv.GetMethodID (class_ref, "getZoomLevel", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getZoomLevel);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZoomLevel", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='Position']/method[@name='setZoomLevel' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setZoomLevel", "(F)V", "GetSetZoomLevel_FHandler")]
			set {
				if (id_setZoomLevel_F == IntPtr.Zero)
					id_setZoomLevel_F = JNIEnv.GetMethodID (class_ref, "setZoomLevel", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setZoomLevel_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoomLevel", "(F)V"), new JValue (value));
			}
		}

	}
}
