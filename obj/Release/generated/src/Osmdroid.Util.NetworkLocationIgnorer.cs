using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.util']/class[@name='NetworkLocationIgnorer']"
	[global::Android.Runtime.Register ("org/osmdroid/util/NetworkLocationIgnorer", DoNotGenerateAcw=true)]
	public partial class NetworkLocationIgnorer : global::Java.Lang.Object {


		public static class InterfaceConsts {

			// The following are fields from: org.osmdroid.util.constants.UtilConstants

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util.constants']/interface[@name='UtilConstants']/field[@name='GPS_WAIT_TIME']"
			[Register ("GPS_WAIT_TIME")]
			public const long GpsWaitTime = (long) 20000L;
		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/util/NetworkLocationIgnorer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkLocationIgnorer); }
		}

		protected NetworkLocationIgnorer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.util']/class[@name='NetworkLocationIgnorer']/constructor[@name='NetworkLocationIgnorer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public NetworkLocationIgnorer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (NetworkLocationIgnorer)) {
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

		static Delegate cb_shouldIgnore_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetShouldIgnore_Ljava_lang_String_JHandler ()
		{
			if (cb_shouldIgnore_Ljava_lang_String_J == null)
				cb_shouldIgnore_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, bool>) n_ShouldIgnore_Ljava_lang_String_J);
			return cb_shouldIgnore_Ljava_lang_String_J;
		}

		static bool n_ShouldIgnore_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_pProvider, long pTime)
		{
			global::Osmdroid.Util.NetworkLocationIgnorer __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.NetworkLocationIgnorer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string pProvider = JNIEnv.GetString (native_pProvider, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShouldIgnore (pProvider, pTime);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_shouldIgnore_Ljava_lang_String_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='NetworkLocationIgnorer']/method[@name='shouldIgnore' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("shouldIgnore", "(Ljava/lang/String;J)Z", "GetShouldIgnore_Ljava_lang_String_JHandler")]
		public virtual bool ShouldIgnore (string pProvider, long pTime)
		{
			if (id_shouldIgnore_Ljava_lang_String_J == IntPtr.Zero)
				id_shouldIgnore_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "shouldIgnore", "(Ljava/lang/String;J)Z");
			IntPtr native_pProvider = JNIEnv.NewString (pProvider);

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_shouldIgnore_Ljava_lang_String_J, new JValue (native_pProvider), new JValue (pTime));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "shouldIgnore", "(Ljava/lang/String;J)Z"), new JValue (native_pProvider), new JValue (pTime));
			JNIEnv.DeleteLocalRef (native_pProvider);
			return __ret;
		}

	}
}
