using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GEMFFile']"
	[global::Android.Runtime.Register ("org/osmdroid/util/GEMFFile", DoNotGenerateAcw=true)]
	public partial class GEMFFile : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GEMFFile.GEMFInputStream']"
		[global::Android.Runtime.Register ("org/osmdroid/util/GEMFFile$GEMFInputStream", DoNotGenerateAcw=true)]
		public partial class GEMFInputStream : global::Java.IO.InputStream {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/util/GEMFFile$GEMFInputStream", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GEMFInputStream); }
			}

			protected GEMFInputStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_read;
#pragma warning disable 0169
			static Delegate GetReadHandler ()
			{
				if (cb_read == null)
					cb_read = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Read);
				return cb_read;
			}

			static int n_Read (IntPtr jnienv, IntPtr native__this)
			{
				global::Osmdroid.Util.GEMFFile.GEMFInputStream __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GEMFFile.GEMFInputStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Read ();
			}
#pragma warning restore 0169

			static IntPtr id_read;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GEMFFile.GEMFInputStream']/method[@name='read' and count(parameter)=0]"
			[Register ("read", "()I", "GetReadHandler")]
			public override int Read ()
			{
				if (id_read == IntPtr.Zero)
					id_read = JNIEnv.GetMethodID (class_ref, "read", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_read);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "()I"));
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GEMFFile.GEMFRange']"
		[global::Android.Runtime.Register ("org/osmdroid/util/GEMFFile$GEMFRange", DoNotGenerateAcw=true)]
		public partial class GEMFRange : global::Java.Lang.Object {

			protected GEMFRange (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/util/GEMFFile", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GEMFFile); }
		}

		protected GEMFFile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_File_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GEMFFile']/constructor[@name='GEMFFile' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register (".ctor", "(Ljava/io/File;)V", "")]
		public GEMFFile (global::Java.IO.File pLocation) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GEMFFile)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/io/File;)V", new JValue (pLocation)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/io/File;)V", new JValue (pLocation));
				return;
			}

			if (id_ctor_Ljava_io_File_ == IntPtr.Zero)
				id_ctor_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/File;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_File_, new JValue (pLocation)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_io_File_, new JValue (pLocation));
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GEMFFile']/constructor[@name='GEMFFile' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.List']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/util/List;)V", "")]
		public GEMFFile (string p0, global::System.Collections.Generic.IList<global::Java.IO.File> p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);;
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.IO.File>.ToLocalJniHandle (p1);;
			if (GetType () != typeof (GEMFFile)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Ljava/util/List;)V", new JValue (native_p0), new JValue (native_p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Ljava/util/List;)V", new JValue (native_p0), new JValue (native_p1));
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				return;
			}

			if (id_ctor_Ljava_lang_String_Ljava_util_List_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/util/List;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_, new JValue (native_p0), new JValue (native_p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_util_List_, new JValue (native_p0), new JValue (native_p1));
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GEMFFile']/constructor[@name='GEMFFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public GEMFFile (string pLocation) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_pLocation = JNIEnv.NewString (pLocation);;
			if (GetType () != typeof (GEMFFile)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", new JValue (native_pLocation)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;)V", new JValue (native_pLocation));
				JNIEnv.DeleteLocalRef (native_pLocation);
				return;
			}

			if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
				id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, new JValue (native_pLocation)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_, new JValue (native_pLocation));
			JNIEnv.DeleteLocalRef (native_pLocation);
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.GEMFFile __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GEMFFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static IntPtr id_getName;
		public virtual string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GEMFFile']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");

				if (GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getSources;
#pragma warning disable 0169
		static Delegate GetGetSourcesHandler ()
		{
			if (cb_getSources == null)
				cb_getSources = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSources);
			return cb_getSources;
		}

		static IntPtr n_GetSources (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.GEMFFile __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GEMFFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Sources);
		}
#pragma warning restore 0169

		static IntPtr id_getSources;
		public virtual global::Java.Util.LinkedHashMap Sources {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GEMFFile']/method[@name='getSources' and count(parameter)=0]"
			[Register ("getSources", "()Ljava/util/LinkedHashMap;", "GetGetSourcesHandler")]
			get {
				if (id_getSources == IntPtr.Zero)
					id_getSources = JNIEnv.GetMethodID (class_ref, "getSources", "()Ljava/util/LinkedHashMap;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Java.Util.LinkedHashMap> (JNIEnv.CallObjectMethod  (Handle, id_getSources), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Java.Util.LinkedHashMap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSources", "()Ljava/util/LinkedHashMap;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getZoomLevels;
#pragma warning disable 0169
		static Delegate GetGetZoomLevelsHandler ()
		{
			if (cb_getZoomLevels == null)
				cb_getZoomLevels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetZoomLevels);
			return cb_getZoomLevels;
		}

		static IntPtr n_GetZoomLevels (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.GEMFFile __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GEMFFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.ToLocalJniHandle (__this.ZoomLevels);
		}
#pragma warning restore 0169

		static IntPtr id_getZoomLevels;
		public virtual global::System.Collections.Generic.ICollection<global::Java.Lang.Integer> ZoomLevels {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GEMFFile']/method[@name='getZoomLevels' and count(parameter)=0]"
			[Register ("getZoomLevels", "()Ljava/util/Set;", "GetGetZoomLevelsHandler")]
			get {
				if (id_getZoomLevels == IntPtr.Zero)
					id_getZoomLevels = JNIEnv.GetMethodID (class_ref, "getZoomLevels", "()Ljava/util/Set;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getZoomLevels), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaSet<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZoomLevels", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_acceptAnySource;
#pragma warning disable 0169
		static Delegate GetAcceptAnySourceHandler ()
		{
			if (cb_acceptAnySource == null)
				cb_acceptAnySource = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AcceptAnySource);
			return cb_acceptAnySource;
		}

		static void n_AcceptAnySource (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.GEMFFile __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GEMFFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AcceptAnySource ();
		}
#pragma warning restore 0169

		static IntPtr id_acceptAnySource;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GEMFFile']/method[@name='acceptAnySource' and count(parameter)=0]"
		[Register ("acceptAnySource", "()V", "GetAcceptAnySourceHandler")]
		public virtual void AcceptAnySource ()
		{
			if (id_acceptAnySource == IntPtr.Zero)
				id_acceptAnySource = JNIEnv.GetMethodID (class_ref, "acceptAnySource", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_acceptAnySource);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "acceptAnySource", "()V"));
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Util.GEMFFile __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GEMFFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GEMFFile']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_close);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
		}

		static Delegate cb_getInputStream_III;
#pragma warning disable 0169
		static Delegate GetGetInputStream_IIIHandler ()
		{
			if (cb_getInputStream_III == null)
				cb_getInputStream_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, IntPtr>) n_GetInputStream_III);
			return cb_getInputStream_III;
		}

		static IntPtr n_GetInputStream_III (IntPtr jnienv, IntPtr native__this, int pX, int pY, int pZ)
		{
			global::Osmdroid.Util.GEMFFile __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GEMFFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.GetInputStream (pX, pY, pZ));
		}
#pragma warning restore 0169

		static IntPtr id_getInputStream_III;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GEMFFile']/method[@name='getInputStream' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getInputStream", "(III)Ljava/io/InputStream;", "GetGetInputStream_IIIHandler")]
		public virtual global::System.IO.Stream GetInputStream (int pX, int pY, int pZ)
		{
			if (id_getInputStream_III == IntPtr.Zero)
				id_getInputStream_III = JNIEnv.GetMethodID (class_ref, "getInputStream", "(III)Ljava/io/InputStream;");

			if (GetType () == ThresholdType)
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getInputStream_III, new JValue (pX), new JValue (pY), new JValue (pZ)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputStream", "(III)Ljava/io/InputStream;"), new JValue (pX), new JValue (pY), new JValue (pZ)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_selectSource_I;
#pragma warning disable 0169
		static Delegate GetSelectSource_IHandler ()
		{
			if (cb_selectSource_I == null)
				cb_selectSource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SelectSource_I);
			return cb_selectSource_I;
		}

		static void n_SelectSource_I (IntPtr jnienv, IntPtr native__this, int pSource)
		{
			global::Osmdroid.Util.GEMFFile __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Util.GEMFFile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectSource (pSource);
		}
#pragma warning restore 0169

		static IntPtr id_selectSource_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.util']/class[@name='GEMFFile']/method[@name='selectSource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("selectSource", "(I)V", "GetSelectSource_IHandler")]
		public virtual void SelectSource (int pSource)
		{
			if (id_selectSource_I == IntPtr.Zero)
				id_selectSource_I = JNIEnv.GetMethodID (class_ref, "selectSource", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_selectSource_I, new JValue (pSource));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "selectSource", "(I)V"), new JValue (pSource));
		}

	}
}
