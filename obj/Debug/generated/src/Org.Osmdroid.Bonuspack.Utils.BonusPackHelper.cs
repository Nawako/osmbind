using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Bonuspack.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='BonusPackHelper']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/utils/BonusPackHelper", DoNotGenerateAcw=true)]
	public partial class BonusPackHelper : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='BonusPackHelper']/field[@name='DEFAULT_USER_AGENT']"
		[Register ("DEFAULT_USER_AGENT")]
		public const string DefaultUserAgent = (string) "OsmBonusPack/1";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='BonusPackHelper']/field[@name='LOG_TAG']"
		[Register ("LOG_TAG")]
		public const string LogTag = (string) "BONUSPACK";

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='BonusPackHelper']/field[@name='UNDEFINED_RES_ID']"
		[Register ("UNDEFINED_RES_ID")]
		public const int UndefinedResId = (int) 0;
		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='BonusPackHelper.FlushedInputStream']"
		[global::Android.Runtime.Register ("org/osmdroid/bonuspack/utils/BonusPackHelper$FlushedInputStream", DoNotGenerateAcw=true)]
		public partial class FlushedInputStream : global::Java.IO.FilterInputStream {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/bonuspack/utils/BonusPackHelper$FlushedInputStream", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FlushedInputStream); }
			}

			protected FlushedInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_io_InputStream_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='BonusPackHelper.FlushedInputStream']/constructor[@name='BonusPackHelper.FlushedInputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
			[Register (".ctor", "(Ljava/io/InputStream;)V", "")]
			public FlushedInputStream (global::System.IO.Stream p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);;
				if (GetType () != typeof (FlushedInputStream)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/InputStream;)V", new JValue (native_p0)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/InputStream;)V", new JValue (native_p0));
					JNIEnv.DeleteLocalRef (native_p0);
					return;
				}

				if (id_ctor_Ljava_io_InputStream_ == IntPtr.Zero)
					id_ctor_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/InputStream;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_InputStream_, new JValue (native_p0)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_InputStream_, new JValue (native_p0));
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/utils/BonusPackHelper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (BonusPackHelper); }
		}

		protected BonusPackHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='BonusPackHelper']/constructor[@name='BonusPackHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public BonusPackHelper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (BonusPackHelper)) {
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

		static IntPtr id_isEmulator;
		public static bool IsEmulator {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='BonusPackHelper']/method[@name='isEmulator' and count(parameter)=0]"
			[Register ("isEmulator", "()Z", "GetIsEmulatorHandler")]
			get {
				if (id_isEmulator == IntPtr.Zero)
					id_isEmulator = JNIEnv.GetStaticMethodID (class_ref, "isEmulator", "()Z");
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isEmulator);
			}
		}

		static IntPtr id_cloneBoundingBoxE6_Lorg_osmdroid_util_BoundingBoxE6_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='BonusPackHelper']/method[@name='cloneBoundingBoxE6' and count(parameter)=1 and parameter[1][@type='org.osmdroid.util.BoundingBoxE6']]"
		[Register ("cloneBoundingBoxE6", "(Lorg/osmdroid/util/BoundingBoxE6;)Lorg/osmdroid/util/BoundingBoxE6;", "")]
		public static global::Org.Osmdroid.Util.BoundingBoxE6 CloneBoundingBoxE6 (global::Org.Osmdroid.Util.BoundingBoxE6 p0)
		{
			if (id_cloneBoundingBoxE6_Lorg_osmdroid_util_BoundingBoxE6_ == IntPtr.Zero)
				id_cloneBoundingBoxE6_Lorg_osmdroid_util_BoundingBoxE6_ = JNIEnv.GetStaticMethodID (class_ref, "cloneBoundingBoxE6", "(Lorg/osmdroid/util/BoundingBoxE6;)Lorg/osmdroid/util/BoundingBoxE6;");
			global::Org.Osmdroid.Util.BoundingBoxE6 __ret = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.BoundingBoxE6> (JNIEnv.CallStaticObjectMethod  (class_ref, id_cloneBoundingBoxE6_Lorg_osmdroid_util_BoundingBoxE6_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_concatBoundingBoxE6_Lorg_osmdroid_util_BoundingBoxE6_Lorg_osmdroid_util_BoundingBoxE6_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='BonusPackHelper']/method[@name='concatBoundingBoxE6' and count(parameter)=2 and parameter[1][@type='org.osmdroid.util.BoundingBoxE6'] and parameter[2][@type='org.osmdroid.util.BoundingBoxE6']]"
		[Register ("concatBoundingBoxE6", "(Lorg/osmdroid/util/BoundingBoxE6;Lorg/osmdroid/util/BoundingBoxE6;)Lorg/osmdroid/util/BoundingBoxE6;", "")]
		public static global::Org.Osmdroid.Util.BoundingBoxE6 ConcatBoundingBoxE6 (global::Org.Osmdroid.Util.BoundingBoxE6 p0, global::Org.Osmdroid.Util.BoundingBoxE6 p1)
		{
			if (id_concatBoundingBoxE6_Lorg_osmdroid_util_BoundingBoxE6_Lorg_osmdroid_util_BoundingBoxE6_ == IntPtr.Zero)
				id_concatBoundingBoxE6_Lorg_osmdroid_util_BoundingBoxE6_Lorg_osmdroid_util_BoundingBoxE6_ = JNIEnv.GetStaticMethodID (class_ref, "concatBoundingBoxE6", "(Lorg/osmdroid/util/BoundingBoxE6;Lorg/osmdroid/util/BoundingBoxE6;)Lorg/osmdroid/util/BoundingBoxE6;");
			global::Org.Osmdroid.Util.BoundingBoxE6 __ret = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.BoundingBoxE6> (JNIEnv.CallStaticObjectMethod  (class_ref, id_concatBoundingBoxE6_Lorg_osmdroid_util_BoundingBoxE6_Lorg_osmdroid_util_BoundingBoxE6_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_convertStreamToString_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='BonusPackHelper']/method[@name='convertStreamToString' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("convertStreamToString", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static string ConvertStreamToString (global::System.IO.Stream p0)
		{
			if (id_convertStreamToString_Ljava_io_InputStream_ == IntPtr.Zero)
				id_convertStreamToString_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "convertStreamToString", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertStreamToString_Ljava_io_InputStream_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_loadBitmap_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='BonusPackHelper']/method[@name='loadBitmap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadBitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "")]
		public static global::Android.Graphics.Bitmap LoadBitmap (string p0)
		{
			if (id_loadBitmap_Ljava_lang_String_ == IntPtr.Zero)
				id_loadBitmap_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "loadBitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadBitmap_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static IntPtr id_requestStringFromPost_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='BonusPackHelper']/method[@name='requestStringFromPost' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List']]"
		[Register ("requestStringFromPost", "(Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;", "")]
		public static string RequestStringFromPost (string p0, global::System.Collections.Generic.IList<global::Org.Apache.Http.INameValuePair> p1)
		{
			if (id_requestStringFromPost_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_requestStringFromPost_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetStaticMethodID (class_ref, "requestStringFromPost", "(Ljava/lang/String;Ljava/util/List;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Org.Apache.Http.INameValuePair>.ToLocalJniHandle (p1);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_requestStringFromPost_Ljava_lang_String_Ljava_util_List_, new JValue (native_p0), new JValue (native_p1)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static IntPtr id_requestStringFromUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.utils']/class[@name='BonusPackHelper']/method[@name='requestStringFromUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("requestStringFromUrl", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static string RequestStringFromUrl (string p0)
		{
			if (id_requestStringFromUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_requestStringFromUrl_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "requestStringFromUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_requestStringFromUrl_Ljava_lang_String_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}
}
