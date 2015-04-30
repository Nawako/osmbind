using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Views.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.util']/class[@name='MyMath']"
	[global::Android.Runtime.Register ("org/osmdroid/views/util/MyMath", DoNotGenerateAcw=true)]
	public partial class MyMath : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/util/MyMath", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MyMath); }
		}

		protected MyMath (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getNextSquareNumberAbove_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.util']/class[@name='MyMath']/method[@name='getNextSquareNumberAbove' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getNextSquareNumberAbove", "(F)I", "")]
		public static int GetNextSquareNumberAbove (float factor)
		{
			if (id_getNextSquareNumberAbove_F == IntPtr.Zero)
				id_getNextSquareNumberAbove_F = JNIEnv.GetStaticMethodID (class_ref, "getNextSquareNumberAbove", "(F)I");
			return JNIEnv.CallStaticIntMethod  (class_ref, id_getNextSquareNumberAbove_F, new JValue (factor));
		}

	}
}
