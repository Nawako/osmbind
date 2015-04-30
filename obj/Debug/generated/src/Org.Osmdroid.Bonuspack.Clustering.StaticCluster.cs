using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Bonuspack.Clustering {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='StaticCluster']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/clustering/StaticCluster", DoNotGenerateAcw=true)]
	public partial class StaticCluster : global::Java.Lang.Object {


		static IntPtr mCenter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='StaticCluster']/field[@name='mCenter']"
		[Register ("mCenter")]
		protected global::Org.Osmdroid.Util.GeoPoint MCenter {
			get {
				if (mCenter_jfieldId == IntPtr.Zero)
					mCenter_jfieldId = JNIEnv.GetFieldID (class_ref, "mCenter", "Lorg/osmdroid/util/GeoPoint;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mCenter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCenter_jfieldId == IntPtr.Zero)
					mCenter_jfieldId = JNIEnv.GetFieldID (class_ref, "mCenter", "Lorg/osmdroid/util/GeoPoint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mCenter_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mItems_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='StaticCluster']/field[@name='mItems']"
		[Register ("mItems")]
		protected global::System.Collections.IList MItems {
			get {
				if (mItems_jfieldId == IntPtr.Zero)
					mItems_jfieldId = JNIEnv.GetFieldID (class_ref, "mItems", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mItems_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mItems_jfieldId == IntPtr.Zero)
					mItems_jfieldId = JNIEnv.GetFieldID (class_ref, "mItems", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mItems_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mMarker_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='StaticCluster']/field[@name='mMarker']"
		[Register ("mMarker")]
		protected global::Osmdroid.Bonuspack.Overlays.Marker MMarker {
			get {
				if (mMarker_jfieldId == IntPtr.Zero)
					mMarker_jfieldId = JNIEnv.GetFieldID (class_ref, "mMarker", "Lorg/osmdroid/bonuspack/overlays/Marker;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mMarker_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMarker_jfieldId == IntPtr.Zero)
					mMarker_jfieldId = JNIEnv.GetFieldID (class_ref, "mMarker", "Lorg/osmdroid/bonuspack/overlays/Marker;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mMarker_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/clustering/StaticCluster", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StaticCluster); }
		}

		protected StaticCluster (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lorg_osmdroid_util_GeoPoint_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='StaticCluster']/constructor[@name='StaticCluster' and count(parameter)=1 and parameter[1][@type='org.osmdroid.util.GeoPoint']]"
		[Register (".ctor", "(Lorg/osmdroid/util/GeoPoint;)V", "")]
		public StaticCluster (global::Org.Osmdroid.Util.GeoPoint p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (StaticCluster)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lorg/osmdroid/util/GeoPoint;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lorg/osmdroid/util/GeoPoint;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
				id_ctor_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/util/GeoPoint;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_util_GeoPoint_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_util_GeoPoint_, new JValue (p0));
		}

		static Delegate cb_getMarker;
#pragma warning disable 0169
		static Delegate GetGetMarkerHandler ()
		{
			if (cb_getMarker == null)
				cb_getMarker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMarker);
			return cb_getMarker;
		}

		static IntPtr n_GetMarker (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Marker);
		}
#pragma warning restore 0169

		static Delegate cb_setMarker_Lorg_osmdroid_bonuspack_overlays_Marker_;
#pragma warning disable 0169
		static Delegate GetSetMarker_Lorg_osmdroid_bonuspack_overlays_Marker_Handler ()
		{
			if (cb_setMarker_Lorg_osmdroid_bonuspack_overlays_Marker_ == null)
				cb_setMarker_Lorg_osmdroid_bonuspack_overlays_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMarker_Lorg_osmdroid_bonuspack_overlays_Marker_);
			return cb_setMarker_Lorg_osmdroid_bonuspack_overlays_Marker_;
		}

		static void n_SetMarker_Lorg_osmdroid_bonuspack_overlays_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Bonuspack.Overlays.Marker p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Marker = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMarker;
		static IntPtr id_setMarker_Lorg_osmdroid_bonuspack_overlays_Marker_;
		public virtual global::Osmdroid.Bonuspack.Overlays.Marker Marker {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='StaticCluster']/method[@name='getMarker' and count(parameter)=0]"
			[Register ("getMarker", "()Lorg/osmdroid/bonuspack/overlays/Marker;", "GetGetMarkerHandler")]
			get {
				if (id_getMarker == IntPtr.Zero)
					id_getMarker = JNIEnv.GetMethodID (class_ref, "getMarker", "()Lorg/osmdroid/bonuspack/overlays/Marker;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (JNIEnv.CallObjectMethod  (Handle, id_getMarker), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMarker", "()Lorg/osmdroid/bonuspack/overlays/Marker;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='StaticCluster']/method[@name='setMarker' and count(parameter)=1 and parameter[1][@type='org.osmdroid.bonuspack.overlays.Marker']]"
			[Register ("setMarker", "(Lorg/osmdroid/bonuspack/overlays/Marker;)V", "GetSetMarker_Lorg_osmdroid_bonuspack_overlays_Marker_Handler")]
			set {
				if (id_setMarker_Lorg_osmdroid_bonuspack_overlays_Marker_ == IntPtr.Zero)
					id_setMarker_Lorg_osmdroid_bonuspack_overlays_Marker_ = JNIEnv.GetMethodID (class_ref, "setMarker", "(Lorg/osmdroid/bonuspack/overlays/Marker;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMarker_Lorg_osmdroid_bonuspack_overlays_Marker_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMarker", "(Lorg/osmdroid/bonuspack/overlays/Marker;)V"), new JValue (value));
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPosition);
			return cb_getPosition;
		}

		static IntPtr n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Position);
		}
#pragma warning restore 0169

		static Delegate cb_setPosition_Lorg_osmdroid_util_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetSetPosition_Lorg_osmdroid_util_GeoPoint_Handler ()
		{
			if (cb_setPosition_Lorg_osmdroid_util_GeoPoint_ == null)
				cb_setPosition_Lorg_osmdroid_util_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPosition_Lorg_osmdroid_util_GeoPoint_);
			return cb_setPosition_Lorg_osmdroid_util_GeoPoint_;
		}

		static void n_SetPosition_Lorg_osmdroid_util_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Util.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Position = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPosition;
		static IntPtr id_setPosition_Lorg_osmdroid_util_GeoPoint_;
		public virtual global::Org.Osmdroid.Util.GeoPoint Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='StaticCluster']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lorg/osmdroid/util/GeoPoint;", "GetGetPositionHandler")]
			get {
				if (id_getPosition == IntPtr.Zero)
					id_getPosition = JNIEnv.GetMethodID (class_ref, "getPosition", "()Lorg/osmdroid/util/GeoPoint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (JNIEnv.CallObjectMethod  (Handle, id_getPosition), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPosition", "()Lorg/osmdroid/util/GeoPoint;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='StaticCluster']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='org.osmdroid.util.GeoPoint']]"
			[Register ("setPosition", "(Lorg/osmdroid/util/GeoPoint;)V", "GetSetPosition_Lorg_osmdroid_util_GeoPoint_Handler")]
			set {
				if (id_setPosition_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
					id_setPosition_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetMethodID (class_ref, "setPosition", "(Lorg/osmdroid/util/GeoPoint;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setPosition_Lorg_osmdroid_util_GeoPoint_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPosition", "(Lorg/osmdroid/util/GeoPoint;)V"), new JValue (value));
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSize);
			return cb_getSize;
		}

		static int n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		static IntPtr id_getSize;
		public virtual int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='StaticCluster']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				if (id_getSize == IntPtr.Zero)
					id_getSize = JNIEnv.GetMethodID (class_ref, "getSize", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getSize);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSize", "()I"));
			}
		}

		static Delegate cb_add_Lorg_osmdroid_bonuspack_overlays_Marker_;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_osmdroid_bonuspack_overlays_Marker_Handler ()
		{
			if (cb_add_Lorg_osmdroid_bonuspack_overlays_Marker_ == null)
				cb_add_Lorg_osmdroid_bonuspack_overlays_Marker_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Add_Lorg_osmdroid_bonuspack_overlays_Marker_);
			return cb_add_Lorg_osmdroid_bonuspack_overlays_Marker_;
		}

		static bool n_Add_Lorg_osmdroid_bonuspack_overlays_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Bonuspack.Overlays.Marker p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Add (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_Lorg_osmdroid_bonuspack_overlays_Marker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='StaticCluster']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.osmdroid.bonuspack.overlays.Marker']]"
		[Register ("add", "(Lorg/osmdroid/bonuspack/overlays/Marker;)Z", "GetAdd_Lorg_osmdroid_bonuspack_overlays_Marker_Handler")]
		public virtual bool Add (global::Osmdroid.Bonuspack.Overlays.Marker p0)
		{
			if (id_add_Lorg_osmdroid_bonuspack_overlays_Marker_ == IntPtr.Zero)
				id_add_Lorg_osmdroid_bonuspack_overlays_Marker_ = JNIEnv.GetMethodID (class_ref, "add", "(Lorg/osmdroid/bonuspack/overlays/Marker;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_add_Lorg_osmdroid_bonuspack_overlays_Marker_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lorg/osmdroid/bonuspack/overlays/Marker;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_getItem_I;
#pragma warning disable 0169
		static Delegate GetGetItem_IHandler ()
		{
			if (cb_getItem_I == null)
				cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
			return cb_getItem_I;
		}

		static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='StaticCluster']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Lorg/osmdroid/bonuspack/overlays/Marker;", "GetGetItem_IHandler")]
		public virtual global::Osmdroid.Bonuspack.Overlays.Marker GetItem (int p0)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Lorg/osmdroid/bonuspack/overlays/Marker;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (JNIEnv.CallObjectMethod  (Handle, id_getItem_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "(I)Lorg/osmdroid/bonuspack/overlays/Marker;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

	}
}
