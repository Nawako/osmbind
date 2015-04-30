using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.util']/class[@name='MyMath']"
	[global::Android.Runtime.Register ("org/osmdroid/util/MyMath", DoNotGenerateAcw=true)]
	public partial class MyMath : global::Java.Lang.Object {


		public static class InterfaceConsts {

			// The following are fields from: org.osmdroid.views.util.constants.MathConstants

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='DEG2RAD']"
			[Register ("DEG2RAD")]
			public const float Deg2rad = (float) 0.017453;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='PI']"
			[Register ("PI")]
			public const float Pi = (float) 3.141593;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='PI_2']"
			[Register ("PI_2")]
			public const float Pi2 = (float) 1.570796;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='PI_4']"
			[Register ("PI_4")]
			public const float Pi4 = (float) 0.785398;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.util.constants']/interface[@name='MathConstants']/field[@name='RAD2DEG']"
			[Register ("RAD2DEG")]
			public const float Rad2deg = (float) 57.295780;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/util/MyMath", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MyMath); }
		}

		protected MyMath (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_gudermann_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='MyMath']/method[@name='gudermann' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("gudermann", "(D)D", "")]
		public static double Gudermann (double y)
		{
			if (id_gudermann_D == IntPtr.Zero)
				id_gudermann_D = JNIEnv.GetStaticMethodID (class_ref, "gudermann", "(D)D");
			return JNIEnv.CallStaticDoubleMethod  (class_ref, id_gudermann_D, new JValue (y));
		}

		static IntPtr id_gudermannInverse_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='MyMath']/method[@name='gudermannInverse' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("gudermannInverse", "(D)D", "")]
		public static double GudermannInverse (double aLatitude)
		{
			if (id_gudermannInverse_D == IntPtr.Zero)
				id_gudermannInverse_D = JNIEnv.GetStaticMethodID (class_ref, "gudermannInverse", "(D)D");
			return JNIEnv.CallStaticDoubleMethod  (class_ref, id_gudermannInverse_D, new JValue (aLatitude));
		}

		static IntPtr id_mod_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='MyMath']/method[@name='mod' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("mod", "(II)I", "")]
		public static int Mod (int number, int modulus)
		{
			if (id_mod_II == IntPtr.Zero)
				id_mod_II = JNIEnv.GetStaticMethodID (class_ref, "mod", "(II)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_mod_II, new JValue (number), new JValue (modulus));
		}

	}
}
