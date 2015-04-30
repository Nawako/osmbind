using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Bonuspack.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='DouglasPeuckerReducer']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/utils/DouglasPeuckerReducer", DoNotGenerateAcw=true)]
	public partial class DouglasPeuckerReducer : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/utils/DouglasPeuckerReducer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DouglasPeuckerReducer); }
		}

		protected DouglasPeuckerReducer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='DouglasPeuckerReducer']/constructor[@name='DouglasPeuckerReducer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public DouglasPeuckerReducer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (DouglasPeuckerReducer)) {
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

		static IntPtr id_orthogonalDistance_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='DouglasPeuckerReducer']/method[@name='orthogonalDistance' and count(parameter)=3 and parameter[1][@type='org.osmdroid.util.GeoPoint'] and parameter[2][@type='org.osmdroid.util.GeoPoint'] and parameter[3][@type='org.osmdroid.util.GeoPoint']]"
		[Register ("orthogonalDistance", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/util/GeoPoint;)D", "")]
		public static double OrthogonalDistance (global::Org.Osmdroid.Util.GeoPoint p0, global::Org.Osmdroid.Util.GeoPoint p1, global::Org.Osmdroid.Util.GeoPoint p2)
		{
			if (id_orthogonalDistance_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_ == IntPtr.Zero)
				id_orthogonalDistance_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_ = JNIEnv.GetStaticMethodID (class_ref, "orthogonalDistance", "(Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/util/GeoPoint;Lorg/osmdroid/util/GeoPoint;)D");
			double __ret = JNIEnv.CallStaticDoubleMethod  (class_ref, id_orthogonalDistance_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_Lorg_osmdroid_util_GeoPoint_, new JValue (p0), new JValue (p1), new JValue (p2));
			return __ret;
		}

		static IntPtr id_reduceWithTolerance_Ljava_util_ArrayList_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='DouglasPeuckerReducer']/method[@name='reduceWithTolerance' and count(parameter)=2 and parameter[1][@type='java.util.ArrayList'] and parameter[2][@type='double']]"
		[Register ("reduceWithTolerance", "(Ljava/util/ArrayList;D)Ljava/util/ArrayList;", "")]
		public static global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> ReduceWithTolerance (global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> p0, double p1)
		{
			if (id_reduceWithTolerance_Ljava_util_ArrayList_D == IntPtr.Zero)
				id_reduceWithTolerance_Ljava_util_ArrayList_D = JNIEnv.GetStaticMethodID (class_ref, "reduceWithTolerance", "(Ljava/util/ArrayList;D)Ljava/util/ArrayList;");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.ToLocalJniHandle (p0);
			global::System.Collections.Generic.IList<global::Org.Osmdroid.Util.GeoPoint> __ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Util.GeoPoint>.FromJniHandle (JNIEnv.CallStaticObjectMethod  (class_ref, id_reduceWithTolerance_Ljava_util_ArrayList_D, new JValue (native_p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
