using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.TileProvider.TileSource {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/interface[@name='IStyledTileSource']"
	[Register ("org/osmdroid/tileprovider/tilesource/IStyledTileSource", "", "Osmdroid.TileProvider.TileSource.IStyledTileSourceInvoker")]
	public partial interface IStyledTileSource : IJavaObject {

		global::Java.Lang.Object Style {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/interface[@name='IStyledTileSource']/method[@name='getStyle' and count(parameter)=0]"
			[Register ("getStyle", "()Ljava/lang/Object;", "GetGetStyleHandler:Osmdroid.TileProvider.TileSource.IStyledTileSourceInvoker, OsmdroidAndroidBinding")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/interface[@name='IStyledTileSource']/method[@name='setStyle' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setStyle", "(Ljava/lang/Object;)V", "GetSetStyle_Ljava_lang_Object_Handler:Osmdroid.TileProvider.TileSource.IStyledTileSourceInvoker, OsmdroidAndroidBinding")] set;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.tileprovider.tilesource']/interface[@name='IStyledTileSource']/method[@name='setStyle' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setStyle", "(Ljava/lang/String;)V", "GetSetStyle_Ljava_lang_String_Handler:Osmdroid.TileProvider.TileSource.IStyledTileSourceInvoker, OsmdroidAndroidBinding")]
		void SetStyle (string style);

	}

	[global::Android.Runtime.Register ("org/osmdroid/tileprovider/tilesource/IStyledTileSource", DoNotGenerateAcw=true)]
	internal class IStyledTileSourceInvoker : global::Java.Lang.Object, IStyledTileSource {

		static IntPtr java_class_ref = JNIEnv.FindClass ("org/osmdroid/tileprovider/tilesource/IStyledTileSource");
		IntPtr class_ref;

		public static IStyledTileSource GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStyledTileSource> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.osmdroid.tileprovider.tilesource.IStyledTileSource"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStyledTileSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override System.Type ThresholdType {
			get { return typeof (IStyledTileSourceInvoker); }
		}

		static Delegate cb_getStyle;
#pragma warning disable 0169
		static Delegate GetGetStyleHandler ()
		{
			if (cb_getStyle == null)
				cb_getStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStyle);
			return cb_getStyle;
		}

		static IntPtr n_GetStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.TileProvider.TileSource.IStyledTileSource __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.IStyledTileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Style);
		}
#pragma warning restore 0169

		static Delegate cb_setStyle_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetStyle_Ljava_lang_Object_Handler ()
		{
			if (cb_setStyle_Ljava_lang_Object_ == null)
				cb_setStyle_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStyle_Ljava_lang_Object_);
			return cb_setStyle_Ljava_lang_Object_;
		}

		static void n_SetStyle_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_style)
		{
			global::Osmdroid.TileProvider.TileSource.IStyledTileSource __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.IStyledTileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object style = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_style, JniHandleOwnership.DoNotTransfer);
			__this.Style = style;
		}
#pragma warning restore 0169

		IntPtr id_getStyle;
		IntPtr id_setStyle_Ljava_lang_Object_;
		public global::Java.Lang.Object Style {
			get {
				if (id_getStyle == IntPtr.Zero)
					id_getStyle = JNIEnv.GetMethodID (class_ref, "getStyle", "()Ljava/lang/Object;");
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (Handle, id_getStyle), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setStyle_Ljava_lang_Object_ == IntPtr.Zero)
					id_setStyle_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setStyle", "(Ljava/lang/Object;)V");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.CallVoidMethod (Handle, id_setStyle_Ljava_lang_Object_, new JValue (native_value));
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_setStyle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStyle_Ljava_lang_String_Handler ()
		{
			if (cb_setStyle_Ljava_lang_String_ == null)
				cb_setStyle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStyle_Ljava_lang_String_);
			return cb_setStyle_Ljava_lang_String_;
		}

		static void n_SetStyle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_style)
		{
			global::Osmdroid.TileProvider.TileSource.IStyledTileSource __this = global::Java.Lang.Object.GetObject<global::Osmdroid.TileProvider.TileSource.IStyledTileSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string style = JNIEnv.GetString (native_style, JniHandleOwnership.DoNotTransfer);
			__this.SetStyle (style);
		}
#pragma warning restore 0169

		IntPtr id_setStyle_Ljava_lang_String_;
		public void SetStyle (string style)
		{
			if (id_setStyle_Ljava_lang_String_ == IntPtr.Zero)
				id_setStyle_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setStyle", "(Ljava/lang/String;)V");
			IntPtr native_style = JNIEnv.NewString (style);
			JNIEnv.CallVoidMethod (Handle, id_setStyle_Ljava_lang_String_, new JValue (native_style));
			JNIEnv.DeleteLocalRef (native_style);
		}

	}

}
