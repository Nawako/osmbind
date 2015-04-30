using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Bonuspack.Location {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/location/POI", DoNotGenerateAcw=true)]
	public partial class POI : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetStaticField (class_ref, CREATOR_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr MAX_LOADING_ATTEMPTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/field[@name='MAX_LOADING_ATTEMPTS']"
		[Register ("MAX_LOADING_ATTEMPTS")]
		protected static int MaxLoadingAttempts {
			get {
				if (MAX_LOADING_ATTEMPTS_jfieldId == IntPtr.Zero)
					MAX_LOADING_ATTEMPTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAX_LOADING_ATTEMPTS", "I");
				return JNIEnv.GetStaticIntField (class_ref, MAX_LOADING_ATTEMPTS_jfieldId);
			}
			set {
				if (MAX_LOADING_ATTEMPTS_jfieldId == IntPtr.Zero)
					MAX_LOADING_ATTEMPTS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAX_LOADING_ATTEMPTS", "I");
				JNIEnv.SetStaticField (class_ref, MAX_LOADING_ATTEMPTS_jfieldId, value);
			}
		}

		static IntPtr POI_SERVICE_FLICKR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/field[@name='POI_SERVICE_FLICKR']"
		[Register ("POI_SERVICE_FLICKR")]
		public static int PoiServiceFlickr {
			get {
				if (POI_SERVICE_FLICKR_jfieldId == IntPtr.Zero)
					POI_SERVICE_FLICKR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POI_SERVICE_FLICKR", "I");
				return JNIEnv.GetStaticIntField (class_ref, POI_SERVICE_FLICKR_jfieldId);
			}
			set {
				if (POI_SERVICE_FLICKR_jfieldId == IntPtr.Zero)
					POI_SERVICE_FLICKR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POI_SERVICE_FLICKR", "I");
				JNIEnv.SetStaticField (class_ref, POI_SERVICE_FLICKR_jfieldId, value);
			}
		}

		static IntPtr POI_SERVICE_GEONAMES_WIKIPEDIA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/field[@name='POI_SERVICE_GEONAMES_WIKIPEDIA']"
		[Register ("POI_SERVICE_GEONAMES_WIKIPEDIA")]
		public static int PoiServiceGeonamesWikipedia {
			get {
				if (POI_SERVICE_GEONAMES_WIKIPEDIA_jfieldId == IntPtr.Zero)
					POI_SERVICE_GEONAMES_WIKIPEDIA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POI_SERVICE_GEONAMES_WIKIPEDIA", "I");
				return JNIEnv.GetStaticIntField (class_ref, POI_SERVICE_GEONAMES_WIKIPEDIA_jfieldId);
			}
			set {
				if (POI_SERVICE_GEONAMES_WIKIPEDIA_jfieldId == IntPtr.Zero)
					POI_SERVICE_GEONAMES_WIKIPEDIA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POI_SERVICE_GEONAMES_WIKIPEDIA", "I");
				JNIEnv.SetStaticField (class_ref, POI_SERVICE_GEONAMES_WIKIPEDIA_jfieldId, value);
			}
		}

		static IntPtr POI_SERVICE_NOMINATIM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/field[@name='POI_SERVICE_NOMINATIM']"
		[Register ("POI_SERVICE_NOMINATIM")]
		public static int PoiServiceNominatim {
			get {
				if (POI_SERVICE_NOMINATIM_jfieldId == IntPtr.Zero)
					POI_SERVICE_NOMINATIM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POI_SERVICE_NOMINATIM", "I");
				return JNIEnv.GetStaticIntField (class_ref, POI_SERVICE_NOMINATIM_jfieldId);
			}
			set {
				if (POI_SERVICE_NOMINATIM_jfieldId == IntPtr.Zero)
					POI_SERVICE_NOMINATIM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POI_SERVICE_NOMINATIM", "I");
				JNIEnv.SetStaticField (class_ref, POI_SERVICE_NOMINATIM_jfieldId, value);
			}
		}

		static IntPtr POI_SERVICE_PICASA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/field[@name='POI_SERVICE_PICASA']"
		[Register ("POI_SERVICE_PICASA")]
		public static int PoiServicePicasa {
			get {
				if (POI_SERVICE_PICASA_jfieldId == IntPtr.Zero)
					POI_SERVICE_PICASA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POI_SERVICE_PICASA", "I");
				return JNIEnv.GetStaticIntField (class_ref, POI_SERVICE_PICASA_jfieldId);
			}
			set {
				if (POI_SERVICE_PICASA_jfieldId == IntPtr.Zero)
					POI_SERVICE_PICASA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POI_SERVICE_PICASA", "I");
				JNIEnv.SetStaticField (class_ref, POI_SERVICE_PICASA_jfieldId, value);
			}
		}

		static IntPtr mCategory_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/field[@name='mCategory']"
		[Register ("mCategory")]
		public string MCategory {
			get {
				if (mCategory_jfieldId == IntPtr.Zero)
					mCategory_jfieldId = JNIEnv.GetFieldID (class_ref, "mCategory", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mCategory_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCategory_jfieldId == IntPtr.Zero)
					mCategory_jfieldId = JNIEnv.GetFieldID (class_ref, "mCategory", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mCategory_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mDescription_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/field[@name='mDescription']"
		[Register ("mDescription")]
		public string MDescription {
			get {
				if (mDescription_jfieldId == IntPtr.Zero)
					mDescription_jfieldId = JNIEnv.GetFieldID (class_ref, "mDescription", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mDescription_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDescription_jfieldId == IntPtr.Zero)
					mDescription_jfieldId = JNIEnv.GetFieldID (class_ref, "mDescription", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mDescription_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/field[@name='mId']"
		[Register ("mId")]
		public long MId {
			get {
				if (mId_jfieldId == IntPtr.Zero)
					mId_jfieldId = JNIEnv.GetFieldID (class_ref, "mId", "J");
				return JNIEnv.GetLongField (Handle, mId_jfieldId);
			}
			set {
				if (mId_jfieldId == IntPtr.Zero)
					mId_jfieldId = JNIEnv.GetFieldID (class_ref, "mId", "J");
				JNIEnv.SetField (Handle, mId_jfieldId, value);
			}
		}

		static IntPtr mLocation_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/field[@name='mLocation']"
		[Register ("mLocation")]
		public global::Org.Osmdroid.Util.GeoPoint MLocation {
			get {
				if (mLocation_jfieldId == IntPtr.Zero)
					mLocation_jfieldId = JNIEnv.GetFieldID (class_ref, "mLocation", "Lorg/osmdroid/util/GeoPoint;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mLocation_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Util.GeoPoint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mLocation_jfieldId == IntPtr.Zero)
					mLocation_jfieldId = JNIEnv.GetFieldID (class_ref, "mLocation", "Lorg/osmdroid/util/GeoPoint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mLocation_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mRank_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/field[@name='mRank']"
		[Register ("mRank")]
		public int MRank {
			get {
				if (mRank_jfieldId == IntPtr.Zero)
					mRank_jfieldId = JNIEnv.GetFieldID (class_ref, "mRank", "I");
				return JNIEnv.GetIntField (Handle, mRank_jfieldId);
			}
			set {
				if (mRank_jfieldId == IntPtr.Zero)
					mRank_jfieldId = JNIEnv.GetFieldID (class_ref, "mRank", "I");
				JNIEnv.SetField (Handle, mRank_jfieldId, value);
			}
		}

		static IntPtr mServiceId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/field[@name='mServiceId']"
		[Register ("mServiceId")]
		public int MServiceId {
			get {
				if (mServiceId_jfieldId == IntPtr.Zero)
					mServiceId_jfieldId = JNIEnv.GetFieldID (class_ref, "mServiceId", "I");
				return JNIEnv.GetIntField (Handle, mServiceId_jfieldId);
			}
			set {
				if (mServiceId_jfieldId == IntPtr.Zero)
					mServiceId_jfieldId = JNIEnv.GetFieldID (class_ref, "mServiceId", "I");
				JNIEnv.SetField (Handle, mServiceId_jfieldId, value);
			}
		}

		static IntPtr mThumbnail_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/field[@name='mThumbnail']"
		[Register ("mThumbnail")]
		public global::Android.Graphics.Bitmap MThumbnail {
			get {
				if (mThumbnail_jfieldId == IntPtr.Zero)
					mThumbnail_jfieldId = JNIEnv.GetFieldID (class_ref, "mThumbnail", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mThumbnail_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mThumbnail_jfieldId == IntPtr.Zero)
					mThumbnail_jfieldId = JNIEnv.GetFieldID (class_ref, "mThumbnail", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mThumbnail_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mThumbnailLoadingFailures_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/field[@name='mThumbnailLoadingFailures']"
		[Register ("mThumbnailLoadingFailures")]
		protected int MThumbnailLoadingFailures {
			get {
				if (mThumbnailLoadingFailures_jfieldId == IntPtr.Zero)
					mThumbnailLoadingFailures_jfieldId = JNIEnv.GetFieldID (class_ref, "mThumbnailLoadingFailures", "I");
				return JNIEnv.GetIntField (Handle, mThumbnailLoadingFailures_jfieldId);
			}
			set {
				if (mThumbnailLoadingFailures_jfieldId == IntPtr.Zero)
					mThumbnailLoadingFailures_jfieldId = JNIEnv.GetFieldID (class_ref, "mThumbnailLoadingFailures", "I");
				JNIEnv.SetField (Handle, mThumbnailLoadingFailures_jfieldId, value);
			}
		}

		static IntPtr mThumbnailPath_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/field[@name='mThumbnailPath']"
		[Register ("mThumbnailPath")]
		public string MThumbnailPath {
			get {
				if (mThumbnailPath_jfieldId == IntPtr.Zero)
					mThumbnailPath_jfieldId = JNIEnv.GetFieldID (class_ref, "mThumbnailPath", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mThumbnailPath_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mThumbnailPath_jfieldId == IntPtr.Zero)
					mThumbnailPath_jfieldId = JNIEnv.GetFieldID (class_ref, "mThumbnailPath", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mThumbnailPath_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/field[@name='mType']"
		[Register ("mType")]
		public string MType {
			get {
				if (mType_jfieldId == IntPtr.Zero)
					mType_jfieldId = JNIEnv.GetFieldID (class_ref, "mType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mType_jfieldId == IntPtr.Zero)
					mType_jfieldId = JNIEnv.GetFieldID (class_ref, "mType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mType_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mUrl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/field[@name='mUrl']"
		[Register ("mUrl")]
		public string MUrl {
			get {
				if (mUrl_jfieldId == IntPtr.Zero)
					mUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "mUrl", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mUrl_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mUrl_jfieldId == IntPtr.Zero)
					mUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "mUrl", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				JNIEnv.SetField (Handle, mUrl_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI.ThumbnailTask']"
		[global::Android.Runtime.Register ("org/osmdroid/bonuspack/location/POI$ThumbnailTask", DoNotGenerateAcw=true)]
		public partial class ThumbnailTask : global::Android.OS.AsyncTask {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("org/osmdroid/bonuspack/location/POI$ThumbnailTask", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ThumbnailTask); }
			}

			protected ThumbnailTask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lorg_osmdroid_bonuspack_location_POI_Landroid_widget_ImageView_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI.ThumbnailTask']/constructor[@name='POI.ThumbnailTask' and count(parameter)=2 and parameter[1][@type='org.osmdroid.bonuspack.location.POI'] and parameter[2][@type='android.widget.ImageView']]"
			[Register (".ctor", "(Lorg/osmdroid/bonuspack/location/POI;Landroid/widget/ImageView;)V", "")]
			public ThumbnailTask (global::Org.Osmdroid.Bonuspack.Location.POI __self, global::Android.Widget.ImageView p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (Handle != IntPtr.Zero)
					return;

				if (GetType () != typeof (ThumbnailTask)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/widget/ImageView;)V", new JValue (__self), new JValue (p1)),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/widget/ImageView;)V", new JValue (__self), new JValue (p1));
					return;
				}

				if (id_ctor_Lorg_osmdroid_bonuspack_location_POI_Landroid_widget_ImageView_ == IntPtr.Zero)
					id_ctor_Lorg_osmdroid_bonuspack_location_POI_Landroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lorg/osmdroid/bonuspack/location/POI;Landroid/widget/ImageView;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lorg_osmdroid_bonuspack_location_POI_Landroid_widget_ImageView_, new JValue (__self), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lorg_osmdroid_bonuspack_location_POI_Landroid_widget_ImageView_, new JValue (__self), new JValue (p1));
			}

			static Delegate cb_doInBackground_arrayLandroid_widget_ImageView_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLandroid_widget_ImageView_Handler ()
			{
				if (cb_doInBackground_arrayLandroid_widget_ImageView_ == null)
					cb_doInBackground_arrayLandroid_widget_ImageView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLandroid_widget_ImageView_);
				return cb_doInBackground_arrayLandroid_widget_ImageView_;
			}

			static IntPtr n_DoInBackground_arrayLandroid_widget_ImageView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Osmdroid.Bonuspack.Location.POI.ThumbnailTask __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.POI.ThumbnailTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.ImageView[] p0 = (global::Android.Widget.ImageView[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Widget.ImageView));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLandroid_widget_ImageView_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI.ThumbnailTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView...']]"
			[Register ("doInBackground", "([Landroid/widget/ImageView;)Landroid/widget/ImageView;", "GetDoInBackground_arrayLandroid_widget_ImageView_Handler")]
			protected virtual global::Android.Widget.ImageView DoInBackground (params global:: Android.Widget.ImageView[] p0)
			{
				if (id_doInBackground_arrayLandroid_widget_ImageView_ == IntPtr.Zero)
					id_doInBackground_arrayLandroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Landroid/widget/ImageView;)Landroid/widget/ImageView;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);

				global::Android.Widget.ImageView __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLandroid_widget_ImageView_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Landroid/widget/ImageView;)Landroid/widget/ImageView;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static Delegate cb_doInBackground_arrayLjava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetDoInBackground_arrayLjava_lang_Object_Handler ()
			{
				if (cb_doInBackground_arrayLjava_lang_Object_ == null)
					cb_doInBackground_arrayLjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DoInBackground_arrayLjava_lang_Object_);
				return cb_doInBackground_arrayLjava_lang_Object_;
			}

			static IntPtr n_DoInBackground_arrayLjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Osmdroid.Bonuspack.Location.POI.ThumbnailTask __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.POI.ThumbnailTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object[] p0 = (global::Java.Lang.Object[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Java.Lang.Object));
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DoInBackground (p0));
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doInBackground_arrayLjava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI.ThumbnailTask']/method[@name='doInBackground' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
			[Register ("doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", "GetDoInBackground_arrayLjava_lang_Object_Handler")]
			protected override global::Java.Lang.Object DoInBackground (params global:: Java.Lang.Object[] p0)
			{
				if (id_doInBackground_arrayLjava_lang_Object_ == IntPtr.Zero)
					id_doInBackground_arrayLjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
				IntPtr native_p0 = JNIEnv.NewArray (p0);

				global::Java.Lang.Object __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_doInBackground_arrayLjava_lang_Object_, new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;"), new JValue (native_p0)), JniHandleOwnership.TransferLocalRef);
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				return __ret;
			}

			static Delegate cb_onPostExecute_Landroid_widget_ImageView_;
#pragma warning disable 0169
			static Delegate GetOnPostExecute_Landroid_widget_ImageView_Handler ()
			{
				if (cb_onPostExecute_Landroid_widget_ImageView_ == null)
					cb_onPostExecute_Landroid_widget_ImageView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPostExecute_Landroid_widget_ImageView_);
				return cb_onPostExecute_Landroid_widget_ImageView_;
			}

			static void n_OnPostExecute_Landroid_widget_ImageView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Org.Osmdroid.Bonuspack.Location.POI.ThumbnailTask __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.POI.ThumbnailTask> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Widget.ImageView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPostExecute (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onPostExecute_Landroid_widget_ImageView_;
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI.ThumbnailTask']/method[@name='onPostExecute' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
			[Register ("onPostExecute", "(Landroid/widget/ImageView;)V", "GetOnPostExecute_Landroid_widget_ImageView_Handler")]
			protected virtual void OnPostExecute (global::Android.Widget.ImageView p0)
			{
				if (id_onPostExecute_Landroid_widget_ImageView_ == IntPtr.Zero)
					id_onPostExecute_Landroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "onPostExecute", "(Landroid/widget/ImageView;)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_onPostExecute_Landroid_widget_ImageView_, new JValue (p0));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPostExecute", "(Landroid/widget/ImageView;)V"), new JValue (p0));
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/location/POI", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (POI); }
		}

		protected POI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/constructor[@name='POI' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public POI (int p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (POI)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I)V", new JValue (p0));
				return;
			}

			if (id_ctor_I == IntPtr.Zero)
				id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_I, new JValue (p0));
		}

		static Delegate cb_getThumbnail;
#pragma warning disable 0169
		static Delegate GetGetThumbnailHandler ()
		{
			if (cb_getThumbnail == null)
				cb_getThumbnail = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetThumbnail);
			return cb_getThumbnail;
		}

		static IntPtr n_GetThumbnail (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Bonuspack.Location.POI __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.POI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Thumbnail);
		}
#pragma warning restore 0169

		static IntPtr id_getThumbnail;
		public virtual global::Android.Graphics.Bitmap Thumbnail {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/method[@name='getThumbnail' and count(parameter)=0]"
			[Register ("getThumbnail", "()Landroid/graphics/Bitmap;", "GetGetThumbnailHandler")]
			get {
				if (id_getThumbnail == IntPtr.Zero)
					id_getThumbnail = JNIEnv.GetMethodID (class_ref, "getThumbnail", "()Landroid/graphics/Bitmap;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getThumbnail), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getThumbnail", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Bonuspack.Location.POI __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.POI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_describeContents);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
		}

		static Delegate cb_fetchThumbnailOnThread_Landroid_widget_ImageView_;
#pragma warning disable 0169
		static Delegate GetFetchThumbnailOnThread_Landroid_widget_ImageView_Handler ()
		{
			if (cb_fetchThumbnailOnThread_Landroid_widget_ImageView_ == null)
				cb_fetchThumbnailOnThread_Landroid_widget_ImageView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FetchThumbnailOnThread_Landroid_widget_ImageView_);
			return cb_fetchThumbnailOnThread_Landroid_widget_ImageView_;
		}

		static void n_FetchThumbnailOnThread_Landroid_widget_ImageView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Osmdroid.Bonuspack.Location.POI __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.POI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.FetchThumbnailOnThread (p0);
		}
#pragma warning restore 0169

		static IntPtr id_fetchThumbnailOnThread_Landroid_widget_ImageView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/method[@name='fetchThumbnailOnThread' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView']]"
		[Register ("fetchThumbnailOnThread", "(Landroid/widget/ImageView;)V", "GetFetchThumbnailOnThread_Landroid_widget_ImageView_Handler")]
		public virtual void FetchThumbnailOnThread (global::Android.Widget.ImageView p0)
		{
			if (id_fetchThumbnailOnThread_Landroid_widget_ImageView_ == IntPtr.Zero)
				id_fetchThumbnailOnThread_Landroid_widget_ImageView_ = JNIEnv.GetMethodID (class_ref, "fetchThumbnailOnThread", "(Landroid/widget/ImageView;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_fetchThumbnailOnThread_Landroid_widget_ImageView_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fetchThumbnailOnThread", "(Landroid/widget/ImageView;)V"), new JValue (p0));
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Org.Osmdroid.Bonuspack.Location.POI __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Location.POI> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.location']/class[@name='POI']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_writeToParcel_Landroid_os_Parcel_I, new JValue (p0), new JValue ((int) p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), new JValue (p0), new JValue ((int) p1));
		}

	}
}
