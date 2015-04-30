using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Osmdroid.Views.Overlay {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']"
	[global::Android.Runtime.Register ("org/osmdroid/views/overlay/ScaleBarOverlay", DoNotGenerateAcw=true)]
	public partial class ScaleBarOverlay : global::Osmdroid.Views.Overlay.Overlay {


		static IntPtr barPath_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/field[@name='barPath']"
		[Register ("barPath")]
		protected global::Android.Graphics.Path BarPath {
			get {
				if (barPath_jfieldId == IntPtr.Zero)
					barPath_jfieldId = JNIEnv.GetFieldID (class_ref, "barPath", "Landroid/graphics/Path;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, barPath_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (barPath_jfieldId == IntPtr.Zero)
					barPath_jfieldId = JNIEnv.GetFieldID (class_ref, "barPath", "Landroid/graphics/Path;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, barPath_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr latitudeBarRect_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/field[@name='latitudeBarRect']"
		[Register ("latitudeBarRect")]
		protected global::Android.Graphics.Rect LatitudeBarRect {
			get {
				if (latitudeBarRect_jfieldId == IntPtr.Zero)
					latitudeBarRect_jfieldId = JNIEnv.GetFieldID (class_ref, "latitudeBarRect", "Landroid/graphics/Rect;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, latitudeBarRect_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (latitudeBarRect_jfieldId == IntPtr.Zero)
					latitudeBarRect_jfieldId = JNIEnv.GetFieldID (class_ref, "latitudeBarRect", "Landroid/graphics/Rect;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, latitudeBarRect_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr longitudeBarRect_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/field[@name='longitudeBarRect']"
		[Register ("longitudeBarRect")]
		protected global::Android.Graphics.Rect LongitudeBarRect {
			get {
				if (longitudeBarRect_jfieldId == IntPtr.Zero)
					longitudeBarRect_jfieldId = JNIEnv.GetFieldID (class_ref, "longitudeBarRect", "Landroid/graphics/Rect;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, longitudeBarRect_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (longitudeBarRect_jfieldId == IntPtr.Zero)
					longitudeBarRect_jfieldId = JNIEnv.GetFieldID (class_ref, "longitudeBarRect", "Landroid/graphics/Rect;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, longitudeBarRect_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr screenHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/field[@name='screenHeight']"
		[Register ("screenHeight")]
		public int ScreenHeight {
			get {
				if (screenHeight_jfieldId == IntPtr.Zero)
					screenHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "screenHeight", "I");
				return JNIEnv.GetIntField (Handle, screenHeight_jfieldId);
			}
			set {
				if (screenHeight_jfieldId == IntPtr.Zero)
					screenHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "screenHeight", "I");
				JNIEnv.SetField (Handle, screenHeight_jfieldId, value);
			}
		}

		static IntPtr screenWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/field[@name='screenWidth']"
		[Register ("screenWidth")]
		public int ScreenWidth {
			get {
				if (screenWidth_jfieldId == IntPtr.Zero)
					screenWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "screenWidth", "I");
				return JNIEnv.GetIntField (Handle, screenWidth_jfieldId);
			}
			set {
				if (screenWidth_jfieldId == IntPtr.Zero)
					screenWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "screenWidth", "I");
				JNIEnv.SetField (Handle, screenWidth_jfieldId, value);
			}
		}

		static IntPtr xdpi_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/field[@name='xdpi']"
		[Register ("xdpi")]
		public float Xdpi {
			get {
				if (xdpi_jfieldId == IntPtr.Zero)
					xdpi_jfieldId = JNIEnv.GetFieldID (class_ref, "xdpi", "F");
				return JNIEnv.GetFloatField (Handle, xdpi_jfieldId);
			}
			set {
				if (xdpi_jfieldId == IntPtr.Zero)
					xdpi_jfieldId = JNIEnv.GetFieldID (class_ref, "xdpi", "F");
				JNIEnv.SetField (Handle, xdpi_jfieldId, value);
			}
		}

		static IntPtr ydpi_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/field[@name='ydpi']"
		[Register ("ydpi")]
		public float Ydpi {
			get {
				if (ydpi_jfieldId == IntPtr.Zero)
					ydpi_jfieldId = JNIEnv.GetFieldID (class_ref, "ydpi", "F");
				return JNIEnv.GetFloatField (Handle, ydpi_jfieldId);
			}
			set {
				if (ydpi_jfieldId == IntPtr.Zero)
					ydpi_jfieldId = JNIEnv.GetFieldID (class_ref, "ydpi", "F");
				JNIEnv.SetField (Handle, ydpi_jfieldId, value);
			}
		}

		public static class InterfaceConsts {

			// The following are fields from: org.osmdroid.util.constants.GeoConstants

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util.constants']/interface[@name='GeoConstants']/field[@name='EQUATORCIRCUMFENCE']"
			[Register ("EQUATORCIRCUMFENCE")]
			public const int Equatorcircumfence = (int) 40075016;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util.constants']/interface[@name='GeoConstants']/field[@name='FEET_PER_METER']"
			[Register ("FEET_PER_METER")]
			public const double FeetPerMeter = (double) 3.280839900000000;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util.constants']/interface[@name='GeoConstants']/field[@name='METERS_PER_NAUTICAL_MILE']"
			[Register ("METERS_PER_NAUTICAL_MILE")]
			public const double MetersPerNauticalMile = (double) 1852.000000000000000;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util.constants']/interface[@name='GeoConstants']/field[@name='METERS_PER_STATUTE_MILE']"
			[Register ("METERS_PER_STATUTE_MILE")]
			public const double MetersPerStatuteMile = (double) 1609.344000000000000;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.util.constants']/interface[@name='GeoConstants']/field[@name='RADIUS_EARTH_METERS']"
			[Register ("RADIUS_EARTH_METERS")]
			public const int RadiusEarthMeters = (int) 6378137;
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay.UnitsOfMeasure']"
		[global::Android.Runtime.Register ("org/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure", DoNotGenerateAcw=true)]
		public sealed partial class UnitsOfMeasure : global::Java.Lang.Enum {


			static IntPtr imperial_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay.UnitsOfMeasure']/field[@name='imperial']"
			[Register ("imperial")]
			public static global::Osmdroid.Views.Overlay.ScaleBarOverlay.UnitsOfMeasure Imperial {
				get {
					if (imperial_jfieldId == IntPtr.Zero)
						imperial_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "imperial", "Lorg/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, imperial_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay.UnitsOfMeasure> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (imperial_jfieldId == IntPtr.Zero)
						imperial_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "imperial", "Lorg/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, imperial_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr metric_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay.UnitsOfMeasure']/field[@name='metric']"
			[Register ("metric")]
			public static global::Osmdroid.Views.Overlay.ScaleBarOverlay.UnitsOfMeasure Metric {
				get {
					if (metric_jfieldId == IntPtr.Zero)
						metric_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "metric", "Lorg/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, metric_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay.UnitsOfMeasure> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (metric_jfieldId == IntPtr.Zero)
						metric_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "metric", "Lorg/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, metric_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr nautical_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay.UnitsOfMeasure']/field[@name='nautical']"
			[Register ("nautical")]
			public static global::Osmdroid.Views.Overlay.ScaleBarOverlay.UnitsOfMeasure Nautical {
				get {
					if (nautical_jfieldId == IntPtr.Zero)
						nautical_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "nautical", "Lorg/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, nautical_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay.UnitsOfMeasure> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (nautical_jfieldId == IntPtr.Zero)
						nautical_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "nautical", "Lorg/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					JNIEnv.SetStaticField (class_ref, nautical_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UnitsOfMeasure); }
			}

			internal UnitsOfMeasure (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay.UnitsOfMeasure']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lorg/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure;", "")]
			public static global::Osmdroid.Views.Overlay.ScaleBarOverlay.UnitsOfMeasure ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lorg/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure;");
				IntPtr native_name = JNIEnv.NewString (name);
				global::Osmdroid.Views.Overlay.ScaleBarOverlay.UnitsOfMeasure __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay.UnitsOfMeasure> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, new JValue (native_name)), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_name);
				return __ret;
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay.UnitsOfMeasure']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lorg/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure;", "")]
			public static global::Osmdroid.Views.Overlay.ScaleBarOverlay.UnitsOfMeasure[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lorg/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure;");
				return (global::Osmdroid.Views.Overlay.ScaleBarOverlay.UnitsOfMeasure[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Osmdroid.Views.Overlay.ScaleBarOverlay.UnitsOfMeasure));
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/views/overlay/ScaleBarOverlay", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ScaleBarOverlay); }
		}

		protected ScaleBarOverlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Lorg_osmdroid_ResourceProxy_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/constructor[@name='ScaleBarOverlay' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='org.osmdroid.ResourceProxy']]"
		[Register (".ctor", "(Landroid/content/Context;Lorg/osmdroid/ResourceProxy;)V", "")]
		public ScaleBarOverlay (global::Android.Content.Context context, global::Osmdroid.IResourceProxy pResourceProxy) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ScaleBarOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Lorg/osmdroid/ResourceProxy;)V", new JValue (context), new JValue (pResourceProxy)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Lorg/osmdroid/ResourceProxy;)V", new JValue (context), new JValue (pResourceProxy));
				return;
			}

			if (id_ctor_Landroid_content_Context_Lorg_osmdroid_ResourceProxy_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Lorg_osmdroid_ResourceProxy_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lorg/osmdroid/ResourceProxy;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lorg_osmdroid_ResourceProxy_, new JValue (context), new JValue (pResourceProxy)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Lorg_osmdroid_ResourceProxy_, new JValue (context), new JValue (pResourceProxy));
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/constructor[@name='ScaleBarOverlay' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public ScaleBarOverlay (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (ScaleBarOverlay)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (context)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (context));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (context)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (context));
		}

		static Delegate cb_getBarPaint;
#pragma warning disable 0169
		static Delegate GetGetBarPaintHandler ()
		{
			if (cb_getBarPaint == null)
				cb_getBarPaint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBarPaint);
			return cb_getBarPaint;
		}

		static IntPtr n_GetBarPaint (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BarPaint);
		}
#pragma warning restore 0169

		static Delegate cb_setBarPaint_Landroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetSetBarPaint_Landroid_graphics_Paint_Handler ()
		{
			if (cb_setBarPaint_Landroid_graphics_Paint_ == null)
				cb_setBarPaint_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBarPaint_Landroid_graphics_Paint_);
			return cb_setBarPaint_Landroid_graphics_Paint_;
		}

		static void n_SetBarPaint_Landroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pBarPaint)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint pBarPaint = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_pBarPaint, JniHandleOwnership.DoNotTransfer);
			__this.BarPaint = pBarPaint;
		}
#pragma warning restore 0169

		static IntPtr id_getBarPaint;
		static IntPtr id_setBarPaint_Landroid_graphics_Paint_;
		public virtual global::Android.Graphics.Paint BarPaint {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='getBarPaint' and count(parameter)=0]"
			[Register ("getBarPaint", "()Landroid/graphics/Paint;", "GetGetBarPaintHandler")]
			get {
				if (id_getBarPaint == IntPtr.Zero)
					id_getBarPaint = JNIEnv.GetMethodID (class_ref, "getBarPaint", "()Landroid/graphics/Paint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (JNIEnv.CallObjectMethod  (Handle, id_getBarPaint), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBarPaint", "()Landroid/graphics/Paint;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='setBarPaint' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint']]"
			[Register ("setBarPaint", "(Landroid/graphics/Paint;)V", "GetSetBarPaint_Landroid_graphics_Paint_Handler")]
			set {
				if (id_setBarPaint_Landroid_graphics_Paint_ == IntPtr.Zero)
					id_setBarPaint_Landroid_graphics_Paint_ = JNIEnv.GetMethodID (class_ref, "setBarPaint", "(Landroid/graphics/Paint;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setBarPaint_Landroid_graphics_Paint_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBarPaint", "(Landroid/graphics/Paint;)V"), new JValue (value));
			}
		}

		static Delegate cb_getTextPaint;
#pragma warning disable 0169
		static Delegate GetGetTextPaintHandler ()
		{
			if (cb_getTextPaint == null)
				cb_getTextPaint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextPaint);
			return cb_getTextPaint;
		}

		static IntPtr n_GetTextPaint (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextPaint);
		}
#pragma warning restore 0169

		static Delegate cb_setTextPaint_Landroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetSetTextPaint_Landroid_graphics_Paint_Handler ()
		{
			if (cb_setTextPaint_Landroid_graphics_Paint_ == null)
				cb_setTextPaint_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextPaint_Landroid_graphics_Paint_);
			return cb_setTextPaint_Landroid_graphics_Paint_;
		}

		static void n_SetTextPaint_Landroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pTextPaint)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint pTextPaint = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_pTextPaint, JniHandleOwnership.DoNotTransfer);
			__this.TextPaint = pTextPaint;
		}
#pragma warning restore 0169

		static IntPtr id_getTextPaint;
		static IntPtr id_setTextPaint_Landroid_graphics_Paint_;
		public virtual global::Android.Graphics.Paint TextPaint {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='getTextPaint' and count(parameter)=0]"
			[Register ("getTextPaint", "()Landroid/graphics/Paint;", "GetGetTextPaintHandler")]
			get {
				if (id_getTextPaint == IntPtr.Zero)
					id_getTextPaint = JNIEnv.GetMethodID (class_ref, "getTextPaint", "()Landroid/graphics/Paint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (JNIEnv.CallObjectMethod  (Handle, id_getTextPaint), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextPaint", "()Landroid/graphics/Paint;")), JniHandleOwnership.TransferLocalRef);
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='setTextPaint' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint']]"
			[Register ("setTextPaint", "(Landroid/graphics/Paint;)V", "GetSetTextPaint_Landroid_graphics_Paint_Handler")]
			set {
				if (id_setTextPaint_Landroid_graphics_Paint_ == IntPtr.Zero)
					id_setTextPaint_Landroid_graphics_Paint_ = JNIEnv.GetMethodID (class_ref, "setTextPaint", "(Landroid/graphics/Paint;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setTextPaint_Landroid_graphics_Paint_, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextPaint", "(Landroid/graphics/Paint;)V"), new JValue (value));
			}
		}

		static Delegate cb_disableScaleBar;
#pragma warning disable 0169
		static Delegate GetDisableScaleBarHandler ()
		{
			if (cb_disableScaleBar == null)
				cb_disableScaleBar = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableScaleBar);
			return cb_disableScaleBar;
		}

		static void n_DisableScaleBar (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableScaleBar ();
		}
#pragma warning restore 0169

		static IntPtr id_disableScaleBar;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='disableScaleBar' and count(parameter)=0]"
		[Register ("disableScaleBar", "()V", "GetDisableScaleBarHandler")]
		public virtual void DisableScaleBar ()
		{
			if (id_disableScaleBar == IntPtr.Zero)
				id_disableScaleBar = JNIEnv.GetMethodID (class_ref, "disableScaleBar", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_disableScaleBar);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableScaleBar", "()V"));
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == null)
				cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z);
			return cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		}

		static void n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_mapView, bool shadow)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView mapView = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_mapView, JniHandleOwnership.DoNotTransfer);
			__this.Draw (c, mapView, shadow);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V", "GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler")]
		public override void Draw (global::Android.Graphics.Canvas c, global::Osmdroid.Views.MapView mapView, bool shadow)
		{
			if (id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z, new JValue (c), new JValue (mapView), new JValue (shadow));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V"), new JValue (c), new JValue (mapView), new JValue (shadow));
		}

		static Delegate cb_drawLatitudeScale_Z;
#pragma warning disable 0169
		static Delegate GetDrawLatitudeScale_ZHandler ()
		{
			if (cb_drawLatitudeScale_Z == null)
				cb_drawLatitudeScale_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_DrawLatitudeScale_Z);
			return cb_drawLatitudeScale_Z;
		}

		static void n_DrawLatitudeScale_Z (IntPtr jnienv, IntPtr native__this, bool latitude)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DrawLatitudeScale (latitude);
		}
#pragma warning restore 0169

		static IntPtr id_drawLatitudeScale_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='drawLatitudeScale' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("drawLatitudeScale", "(Z)V", "GetDrawLatitudeScale_ZHandler")]
		public virtual void DrawLatitudeScale (bool latitude)
		{
			if (id_drawLatitudeScale_Z == IntPtr.Zero)
				id_drawLatitudeScale_Z = JNIEnv.GetMethodID (class_ref, "drawLatitudeScale", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_drawLatitudeScale_Z, new JValue (latitude));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawLatitudeScale", "(Z)V"), new JValue (latitude));
		}

		static Delegate cb_drawLongitudeScale_Z;
#pragma warning disable 0169
		static Delegate GetDrawLongitudeScale_ZHandler ()
		{
			if (cb_drawLongitudeScale_Z == null)
				cb_drawLongitudeScale_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_DrawLongitudeScale_Z);
			return cb_drawLongitudeScale_Z;
		}

		static void n_DrawLongitudeScale_Z (IntPtr jnienv, IntPtr native__this, bool longitude)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DrawLongitudeScale (longitude);
		}
#pragma warning restore 0169

		static IntPtr id_drawLongitudeScale_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='drawLongitudeScale' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("drawLongitudeScale", "(Z)V", "GetDrawLongitudeScale_ZHandler")]
		public virtual void DrawLongitudeScale (bool longitude)
		{
			if (id_drawLongitudeScale_Z == IntPtr.Zero)
				id_drawLongitudeScale_Z = JNIEnv.GetMethodID (class_ref, "drawLongitudeScale", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_drawLongitudeScale_Z, new JValue (longitude));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawLongitudeScale", "(Z)V"), new JValue (longitude));
		}

		static Delegate cb_enableScaleBar;
#pragma warning disable 0169
		static Delegate GetEnableScaleBarHandler ()
		{
			if (cb_enableScaleBar == null)
				cb_enableScaleBar = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EnableScaleBar);
			return cb_enableScaleBar;
		}

		static void n_EnableScaleBar (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableScaleBar ();
		}
#pragma warning restore 0169

		static IntPtr id_enableScaleBar;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='enableScaleBar' and count(parameter)=0]"
		[Register ("enableScaleBar", "()V", "GetEnableScaleBarHandler")]
		public virtual void EnableScaleBar ()
		{
			if (id_enableScaleBar == IntPtr.Zero)
				id_enableScaleBar = JNIEnv.GetMethodID (class_ref, "enableScaleBar", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_enableScaleBar);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enableScaleBar", "()V"));
		}

		static Delegate cb_getUnitsOfMeasure;
#pragma warning disable 0169
		static Delegate GetGetUnitsOfMeasureHandler ()
		{
			if (cb_getUnitsOfMeasure == null)
				cb_getUnitsOfMeasure = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUnitsOfMeasure);
			return cb_getUnitsOfMeasure;
		}

		static IntPtr n_GetUnitsOfMeasure (IntPtr jnienv, IntPtr native__this)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetUnitsOfMeasure ());
		}
#pragma warning restore 0169

		static IntPtr id_getUnitsOfMeasure;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='getUnitsOfMeasure' and count(parameter)=0]"
		[Register ("getUnitsOfMeasure", "()Lorg/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure;", "GetGetUnitsOfMeasureHandler")]
		public virtual global::Osmdroid.Views.Overlay.ScaleBarOverlay.UnitsOfMeasure GetUnitsOfMeasure ()
		{
			if (id_getUnitsOfMeasure == IntPtr.Zero)
				id_getUnitsOfMeasure = JNIEnv.GetMethodID (class_ref, "getUnitsOfMeasure", "()Lorg/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay.UnitsOfMeasure> (JNIEnv.CallObjectMethod  (Handle, id_getUnitsOfMeasure), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay.UnitsOfMeasure> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUnitsOfMeasure", "()Lorg/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure;")), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_scaleBarLengthText_I;
#pragma warning disable 0169
		static Delegate GetScaleBarLengthText_IHandler ()
		{
			if (cb_scaleBarLengthText_I == null)
				cb_scaleBarLengthText_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ScaleBarLengthText_I);
			return cb_scaleBarLengthText_I;
		}

		static IntPtr n_ScaleBarLengthText_I (IntPtr jnienv, IntPtr native__this, int meters)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ScaleBarLengthText (meters));
		}
#pragma warning restore 0169

		static IntPtr id_scaleBarLengthText_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='scaleBarLengthText' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("scaleBarLengthText", "(I)Ljava/lang/String;", "GetScaleBarLengthText_IHandler")]
		protected virtual string ScaleBarLengthText (int meters)
		{
			if (id_scaleBarLengthText_I == IntPtr.Zero)
				id_scaleBarLengthText_I = JNIEnv.GetMethodID (class_ref, "scaleBarLengthText", "(I)Ljava/lang/String;");

			if (GetType () == ThresholdType)
				return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_scaleBarLengthText_I, new JValue (meters)), JniHandleOwnership.TransferLocalRef);
			else
				return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "scaleBarLengthText", "(I)Ljava/lang/String;"), new JValue (meters)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_setBackgroundPaint_Landroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetSetBackgroundPaint_Landroid_graphics_Paint_Handler ()
		{
			if (cb_setBackgroundPaint_Landroid_graphics_Paint_ == null)
				cb_setBackgroundPaint_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBackgroundPaint_Landroid_graphics_Paint_);
			return cb_setBackgroundPaint_Landroid_graphics_Paint_;
		}

		static void n_SetBackgroundPaint_Landroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pBgPaint)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint pBgPaint = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_pBgPaint, JniHandleOwnership.DoNotTransfer);
			__this.SetBackgroundPaint (pBgPaint);
		}
#pragma warning restore 0169

		static IntPtr id_setBackgroundPaint_Landroid_graphics_Paint_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='setBackgroundPaint' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint']]"
		[Register ("setBackgroundPaint", "(Landroid/graphics/Paint;)V", "GetSetBackgroundPaint_Landroid_graphics_Paint_Handler")]
		public virtual void SetBackgroundPaint (global::Android.Graphics.Paint pBgPaint)
		{
			if (id_setBackgroundPaint_Landroid_graphics_Paint_ == IntPtr.Zero)
				id_setBackgroundPaint_Landroid_graphics_Paint_ = JNIEnv.GetMethodID (class_ref, "setBackgroundPaint", "(Landroid/graphics/Paint;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setBackgroundPaint_Landroid_graphics_Paint_, new JValue (pBgPaint));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBackgroundPaint", "(Landroid/graphics/Paint;)V"), new JValue (pBgPaint));
		}

		static Delegate cb_setCentred_Z;
#pragma warning disable 0169
		static Delegate GetSetCentred_ZHandler ()
		{
			if (cb_setCentred_Z == null)
				cb_setCentred_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCentred_Z);
			return cb_setCentred_Z;
		}

		static void n_SetCentred_Z (IntPtr jnienv, IntPtr native__this, bool centred)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCentred (centred);
		}
#pragma warning restore 0169

		static IntPtr id_setCentred_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='setCentred' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCentred", "(Z)V", "GetSetCentred_ZHandler")]
		public virtual void SetCentred (bool centred)
		{
			if (id_setCentred_Z == IntPtr.Zero)
				id_setCentred_Z = JNIEnv.GetMethodID (class_ref, "setCentred", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setCentred_Z, new JValue (centred));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCentred", "(Z)V"), new JValue (centred));
		}

		static Delegate cb_setEnableAdjustLength_Z;
#pragma warning disable 0169
		static Delegate GetSetEnableAdjustLength_ZHandler ()
		{
			if (cb_setEnableAdjustLength_Z == null)
				cb_setEnableAdjustLength_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEnableAdjustLength_Z);
			return cb_setEnableAdjustLength_Z;
		}

		static void n_SetEnableAdjustLength_Z (IntPtr jnienv, IntPtr native__this, bool adjustLength)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEnableAdjustLength (adjustLength);
		}
#pragma warning restore 0169

		static IntPtr id_setEnableAdjustLength_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='setEnableAdjustLength' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setEnableAdjustLength", "(Z)V", "GetSetEnableAdjustLength_ZHandler")]
		public virtual void SetEnableAdjustLength (bool adjustLength)
		{
			if (id_setEnableAdjustLength_Z == IntPtr.Zero)
				id_setEnableAdjustLength_Z = JNIEnv.GetMethodID (class_ref, "setEnableAdjustLength", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setEnableAdjustLength_Z, new JValue (adjustLength));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEnableAdjustLength", "(Z)V"), new JValue (adjustLength));
		}

		static Delegate cb_setLineWidth_F;
#pragma warning disable 0169
		static Delegate GetSetLineWidth_FHandler ()
		{
			if (cb_setLineWidth_F == null)
				cb_setLineWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLineWidth_F);
			return cb_setLineWidth_F;
		}

		static void n_SetLineWidth_F (IntPtr jnienv, IntPtr native__this, float width)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLineWidth (width);
		}
#pragma warning restore 0169

		static IntPtr id_setLineWidth_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='setLineWidth' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setLineWidth", "(F)V", "GetSetLineWidth_FHandler")]
		public virtual void SetLineWidth (float width)
		{
			if (id_setLineWidth_F == IntPtr.Zero)
				id_setLineWidth_F = JNIEnv.GetMethodID (class_ref, "setLineWidth", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setLineWidth_F, new JValue (width));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLineWidth", "(F)V"), new JValue (width));
		}

		static Delegate cb_setMaxLength_F;
#pragma warning disable 0169
		static Delegate GetSetMaxLength_FHandler ()
		{
			if (cb_setMaxLength_F == null)
				cb_setMaxLength_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMaxLength_F);
			return cb_setMaxLength_F;
		}

		static void n_SetMaxLength_F (IntPtr jnienv, IntPtr native__this, float pMaxLengthInCm)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxLength (pMaxLengthInCm);
		}
#pragma warning restore 0169

		static IntPtr id_setMaxLength_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='setMaxLength' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setMaxLength", "(F)V", "GetSetMaxLength_FHandler")]
		public virtual void SetMaxLength (float pMaxLengthInCm)
		{
			if (id_setMaxLength_F == IntPtr.Zero)
				id_setMaxLength_F = JNIEnv.GetMethodID (class_ref, "setMaxLength", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setMaxLength_F, new JValue (pMaxLengthInCm));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxLength", "(F)V"), new JValue (pMaxLengthInCm));
		}

		static Delegate cb_setMinZoom_I;
#pragma warning disable 0169
		static Delegate GetSetMinZoom_IHandler ()
		{
			if (cb_setMinZoom_I == null)
				cb_setMinZoom_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMinZoom_I);
			return cb_setMinZoom_I;
		}

		static void n_SetMinZoom_I (IntPtr jnienv, IntPtr native__this, int zoom)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMinZoom (zoom);
		}
#pragma warning restore 0169

		static IntPtr id_setMinZoom_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='setMinZoom' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMinZoom", "(I)V", "GetSetMinZoom_IHandler")]
		public virtual void SetMinZoom (int zoom)
		{
			if (id_setMinZoom_I == IntPtr.Zero)
				id_setMinZoom_I = JNIEnv.GetMethodID (class_ref, "setMinZoom", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setMinZoom_I, new JValue (zoom));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinZoom", "(I)V"), new JValue (zoom));
		}

		static Delegate cb_setScaleBarOffset_II;
#pragma warning disable 0169
		static Delegate GetSetScaleBarOffset_IIHandler ()
		{
			if (cb_setScaleBarOffset_II == null)
				cb_setScaleBarOffset_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetScaleBarOffset_II);
			return cb_setScaleBarOffset_II;
		}

		static void n_SetScaleBarOffset_II (IntPtr jnienv, IntPtr native__this, int x, int y)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleBarOffset (x, y);
		}
#pragma warning restore 0169

		static IntPtr id_setScaleBarOffset_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='setScaleBarOffset' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setScaleBarOffset", "(II)V", "GetSetScaleBarOffset_IIHandler")]
		public virtual void SetScaleBarOffset (int x, int y)
		{
			if (id_setScaleBarOffset_II == IntPtr.Zero)
				id_setScaleBarOffset_II = JNIEnv.GetMethodID (class_ref, "setScaleBarOffset", "(II)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setScaleBarOffset_II, new JValue (x), new JValue (y));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScaleBarOffset", "(II)V"), new JValue (x), new JValue (y));
		}

		static Delegate cb_setTextSize_F;
#pragma warning disable 0169
		static Delegate GetSetTextSize_FHandler ()
		{
			if (cb_setTextSize_F == null)
				cb_setTextSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTextSize_F);
			return cb_setTextSize_F;
		}

		static void n_SetTextSize_F (IntPtr jnienv, IntPtr native__this, float size)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTextSize (size);
		}
#pragma warning restore 0169

		static IntPtr id_setTextSize_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='setTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setTextSize", "(F)V", "GetSetTextSize_FHandler")]
		public virtual void SetTextSize (float size)
		{
			if (id_setTextSize_F == IntPtr.Zero)
				id_setTextSize_F = JNIEnv.GetMethodID (class_ref, "setTextSize", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setTextSize_F, new JValue (size));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTextSize", "(F)V"), new JValue (size));
		}

		static Delegate cb_setUnitsOfMeasure_Lorg_osmdroid_views_overlay_ScaleBarOverlay_UnitsOfMeasure_;
#pragma warning disable 0169
		static Delegate GetSetUnitsOfMeasure_Lorg_osmdroid_views_overlay_ScaleBarOverlay_UnitsOfMeasure_Handler ()
		{
			if (cb_setUnitsOfMeasure_Lorg_osmdroid_views_overlay_ScaleBarOverlay_UnitsOfMeasure_ == null)
				cb_setUnitsOfMeasure_Lorg_osmdroid_views_overlay_ScaleBarOverlay_UnitsOfMeasure_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUnitsOfMeasure_Lorg_osmdroid_views_overlay_ScaleBarOverlay_UnitsOfMeasure_);
			return cb_setUnitsOfMeasure_Lorg_osmdroid_views_overlay_ScaleBarOverlay_UnitsOfMeasure_;
		}

		static void n_SetUnitsOfMeasure_Lorg_osmdroid_views_overlay_ScaleBarOverlay_UnitsOfMeasure_ (IntPtr jnienv, IntPtr native__this, IntPtr native_unitsOfMeasure)
		{
			global::Osmdroid.Views.Overlay.ScaleBarOverlay __this = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.Overlay.ScaleBarOverlay.UnitsOfMeasure unitsOfMeasure = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.Overlay.ScaleBarOverlay.UnitsOfMeasure> (native_unitsOfMeasure, JniHandleOwnership.DoNotTransfer);
			__this.SetUnitsOfMeasure (unitsOfMeasure);
		}
#pragma warning restore 0169

		static IntPtr id_setUnitsOfMeasure_Lorg_osmdroid_views_overlay_ScaleBarOverlay_UnitsOfMeasure_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.views.overlay']/class[@name='ScaleBarOverlay']/method[@name='setUnitsOfMeasure' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.overlay.ScaleBarOverlay.UnitsOfMeasure']]"
		[Register ("setUnitsOfMeasure", "(Lorg/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure;)V", "GetSetUnitsOfMeasure_Lorg_osmdroid_views_overlay_ScaleBarOverlay_UnitsOfMeasure_Handler")]
		public virtual void SetUnitsOfMeasure (global::Osmdroid.Views.Overlay.ScaleBarOverlay.UnitsOfMeasure unitsOfMeasure)
		{
			if (id_setUnitsOfMeasure_Lorg_osmdroid_views_overlay_ScaleBarOverlay_UnitsOfMeasure_ == IntPtr.Zero)
				id_setUnitsOfMeasure_Lorg_osmdroid_views_overlay_ScaleBarOverlay_UnitsOfMeasure_ = JNIEnv.GetMethodID (class_ref, "setUnitsOfMeasure", "(Lorg/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setUnitsOfMeasure_Lorg_osmdroid_views_overlay_ScaleBarOverlay_UnitsOfMeasure_, new JValue (unitsOfMeasure));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUnitsOfMeasure", "(Lorg/osmdroid/views/overlay/ScaleBarOverlay$UnitsOfMeasure;)V"), new JValue (unitsOfMeasure));
		}

	}
}
