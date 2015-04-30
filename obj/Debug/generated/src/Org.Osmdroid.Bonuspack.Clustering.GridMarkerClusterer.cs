using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Bonuspack.Clustering {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='GridMarkerClusterer']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/clustering/GridMarkerClusterer", DoNotGenerateAcw=true)]
	public partial class GridMarkerClusterer : global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer {


		static IntPtr mAnchorU_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='GridMarkerClusterer']/field[@name='mAnchorU']"
		[Register ("mAnchorU")]
		public float MAnchorU {
			get {
				if (mAnchorU_jfieldId == IntPtr.Zero)
					mAnchorU_jfieldId = JNIEnv.GetFieldID (class_ref, "mAnchorU", "F");
				return JNIEnv.GetFloatField (Handle, mAnchorU_jfieldId);
			}
			set {
				if (mAnchorU_jfieldId == IntPtr.Zero)
					mAnchorU_jfieldId = JNIEnv.GetFieldID (class_ref, "mAnchorU", "F");
				JNIEnv.SetField (Handle, mAnchorU_jfieldId, value);
			}
		}

		static IntPtr mAnchorV_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='GridMarkerClusterer']/field[@name='mAnchorV']"
		[Register ("mAnchorV")]
		public float MAnchorV {
			get {
				if (mAnchorV_jfieldId == IntPtr.Zero)
					mAnchorV_jfieldId = JNIEnv.GetFieldID (class_ref, "mAnchorV", "F");
				return JNIEnv.GetFloatField (Handle, mAnchorV_jfieldId);
			}
			set {
				if (mAnchorV_jfieldId == IntPtr.Zero)
					mAnchorV_jfieldId = JNIEnv.GetFieldID (class_ref, "mAnchorV", "F");
				JNIEnv.SetField (Handle, mAnchorV_jfieldId, value);
			}
		}

		static IntPtr mGridSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='GridMarkerClusterer']/field[@name='mGridSize']"
		[Register ("mGridSize")]
		protected int MGridSize {
			get {
				if (mGridSize_jfieldId == IntPtr.Zero)
					mGridSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mGridSize", "I");
				return JNIEnv.GetIntField (Handle, mGridSize_jfieldId);
			}
			set {
				if (mGridSize_jfieldId == IntPtr.Zero)
					mGridSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mGridSize", "I");
				JNIEnv.SetField (Handle, mGridSize_jfieldId, value);
			}
		}

		static IntPtr mTextAnchorU_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='GridMarkerClusterer']/field[@name='mTextAnchorU']"
		[Register ("mTextAnchorU")]
		public float MTextAnchorU {
			get {
				if (mTextAnchorU_jfieldId == IntPtr.Zero)
					mTextAnchorU_jfieldId = JNIEnv.GetFieldID (class_ref, "mTextAnchorU", "F");
				return JNIEnv.GetFloatField (Handle, mTextAnchorU_jfieldId);
			}
			set {
				if (mTextAnchorU_jfieldId == IntPtr.Zero)
					mTextAnchorU_jfieldId = JNIEnv.GetFieldID (class_ref, "mTextAnchorU", "F");
				JNIEnv.SetField (Handle, mTextAnchorU_jfieldId, value);
			}
		}

		static IntPtr mTextAnchorV_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='GridMarkerClusterer']/field[@name='mTextAnchorV']"
		[Register ("mTextAnchorV")]
		public float MTextAnchorV {
			get {
				if (mTextAnchorV_jfieldId == IntPtr.Zero)
					mTextAnchorV_jfieldId = JNIEnv.GetFieldID (class_ref, "mTextAnchorV", "F");
				return JNIEnv.GetFloatField (Handle, mTextAnchorV_jfieldId);
			}
			set {
				if (mTextAnchorV_jfieldId == IntPtr.Zero)
					mTextAnchorV_jfieldId = JNIEnv.GetFieldID (class_ref, "mTextAnchorV", "F");
				JNIEnv.SetField (Handle, mTextAnchorV_jfieldId, value);
			}
		}

		static IntPtr mTextPaint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='GridMarkerClusterer']/field[@name='mTextPaint']"
		[Register ("mTextPaint")]
		protected global::Android.Graphics.Paint MTextPaint {
			get {
				if (mTextPaint_jfieldId == IntPtr.Zero)
					mTextPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mTextPaint", "Landroid/graphics/Paint;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mTextPaint_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mTextPaint_jfieldId == IntPtr.Zero)
					mTextPaint_jfieldId = JNIEnv.GetFieldID (class_ref, "mTextPaint", "Landroid/graphics/Paint;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mTextPaint_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/clustering/GridMarkerClusterer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GridMarkerClusterer); }
		}

		protected GridMarkerClusterer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='GridMarkerClusterer']/constructor[@name='GridMarkerClusterer' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public GridMarkerClusterer (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GridMarkerClusterer)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
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
			global::Org.Osmdroid.Bonuspack.Clustering.GridMarkerClusterer __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.GridMarkerClusterer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextPaint);
		}
#pragma warning restore 0169

		static IntPtr id_getTextPaint;
		public virtual global::Android.Graphics.Paint TextPaint {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='GridMarkerClusterer']/method[@name='getTextPaint' and count(parameter)=0]"
			[Register ("getTextPaint", "()Landroid/graphics/Paint;", "GetGetTextPaintHandler")]
			get {
				if (id_getTextPaint == IntPtr.Zero)
					id_getTextPaint = JNIEnv.GetMethodID (class_ref, "getTextPaint", "()Landroid/graphics/Paint;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (JNIEnv.CallObjectMethod  (Handle, id_getTextPaint), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTextPaint", "()Landroid/graphics/Paint;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_buildClusterMarker_Lorg_osmdroid_bonuspack_clustering_StaticCluster_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetBuildClusterMarker_Lorg_osmdroid_bonuspack_clustering_StaticCluster_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_buildClusterMarker_Lorg_osmdroid_bonuspack_clustering_StaticCluster_Lorg_osmdroid_views_MapView_ == null)
				cb_buildClusterMarker_Lorg_osmdroid_bonuspack_clustering_StaticCluster_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_BuildClusterMarker_Lorg_osmdroid_bonuspack_clustering_StaticCluster_Lorg_osmdroid_views_MapView_);
			return cb_buildClusterMarker_Lorg_osmdroid_bonuspack_clustering_StaticCluster_Lorg_osmdroid_views_MapView_;
		}

		static IntPtr n_BuildClusterMarker_Lorg_osmdroid_bonuspack_clustering_StaticCluster_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Org.Osmdroid.Bonuspack.Clustering.GridMarkerClusterer __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.GridMarkerClusterer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster p0 = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildClusterMarker (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_buildClusterMarker_Lorg_osmdroid_bonuspack_clustering_StaticCluster_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='GridMarkerClusterer']/method[@name='buildClusterMarker' and count(parameter)=2 and parameter[1][@type='org.osmdroid.bonuspack.clustering.StaticCluster'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("buildClusterMarker", "(Lorg/osmdroid/bonuspack/clustering/StaticCluster;Lorg/osmdroid/views/MapView;)Lorg/osmdroid/bonuspack/overlays/Marker;", "GetBuildClusterMarker_Lorg_osmdroid_bonuspack_clustering_StaticCluster_Lorg_osmdroid_views_MapView_Handler")]
		public override global::Osmdroid.Bonuspack.Overlays.Marker BuildClusterMarker (global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster p0, global::Osmdroid.Views.MapView p1)
		{
			if (id_buildClusterMarker_Lorg_osmdroid_bonuspack_clustering_StaticCluster_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_buildClusterMarker_Lorg_osmdroid_bonuspack_clustering_StaticCluster_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "buildClusterMarker", "(Lorg/osmdroid/bonuspack/clustering/StaticCluster;Lorg/osmdroid/views/MapView;)Lorg/osmdroid/bonuspack/overlays/Marker;");

			global::Osmdroid.Bonuspack.Overlays.Marker __ret;
			if (GetType () == ThresholdType)
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (JNIEnv.CallObjectMethod  (Handle, id_buildClusterMarker_Lorg_osmdroid_bonuspack_clustering_StaticCluster_Lorg_osmdroid_views_MapView_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildClusterMarker", "(Lorg/osmdroid/bonuspack/clustering/StaticCluster;Lorg/osmdroid/views/MapView;)Lorg/osmdroid/bonuspack/overlays/Marker;"), new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_clusterer_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetClusterer_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_clusterer_Lorg_osmdroid_views_MapView_ == null)
				cb_clusterer_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Clusterer_Lorg_osmdroid_views_MapView_);
			return cb_clusterer_Lorg_osmdroid_views_MapView_;
		}

		static IntPtr n_Clusterer_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Osmdroid.Bonuspack.Clustering.GridMarkerClusterer __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.GridMarkerClusterer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster>.ToLocalJniHandle (__this.Clusterer (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_clusterer_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='GridMarkerClusterer']/method[@name='clusterer' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.MapView']]"
		[Register ("clusterer", "(Lorg/osmdroid/views/MapView;)Ljava/util/ArrayList;", "GetClusterer_Lorg_osmdroid_views_MapView_Handler")]
		public override global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster> Clusterer (global::Osmdroid.Views.MapView p0)
		{
			if (id_clusterer_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_clusterer_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "clusterer", "(Lorg/osmdroid/views/MapView;)Ljava/util/ArrayList;");

			global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster> __ret;
			if (GetType () == ThresholdType)
				__ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_clusterer_Lorg_osmdroid_views_MapView_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				__ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clusterer", "(Lorg/osmdroid/views/MapView;)Ljava/util/ArrayList;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_renderer_Ljava_util_ArrayList_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_;
#pragma warning disable 0169
		static Delegate GetRenderer_Ljava_util_ArrayList_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Handler ()
		{
			if (cb_renderer_Ljava_util_ArrayList_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ == null)
				cb_renderer_Ljava_util_ArrayList_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Renderer_Ljava_util_ArrayList_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_);
			return cb_renderer_Ljava_util_ArrayList_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_;
		}

		static void n_Renderer_Ljava_util_ArrayList_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Org.Osmdroid.Bonuspack.Clustering.GridMarkerClusterer __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.GridMarkerClusterer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Osmdroid.Bonuspack.Clustering.StaticCluster> p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p2 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Renderer (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_renderer_Ljava_util_ArrayList_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='GridMarkerClusterer']/method[@name='renderer' and count(parameter)=3 and parameter[1][@type='java.util.ArrayList'] and parameter[2][@type='android.graphics.Canvas'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register ("renderer", "(Ljava/util/ArrayList;Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;)V", "GetRenderer_Ljava_util_ArrayList_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Handler")]
		public override void Renderer (global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster> p0, global::Android.Graphics.Canvas p1, global::Osmdroid.Views.MapView p2)
		{
			if (id_renderer_Ljava_util_ArrayList_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_renderer_Ljava_util_ArrayList_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "renderer", "(Ljava/util/ArrayList;Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster>.ToLocalJniHandle (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_renderer_Ljava_util_ArrayList_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "renderer", "(Ljava/util/ArrayList;Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;)V"), new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_setGridSize_I;
#pragma warning disable 0169
		static Delegate GetSetGridSize_IHandler ()
		{
			if (cb_setGridSize_I == null)
				cb_setGridSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetGridSize_I);
			return cb_setGridSize_I;
		}

		static void n_SetGridSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Osmdroid.Bonuspack.Clustering.GridMarkerClusterer __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.GridMarkerClusterer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGridSize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setGridSize_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='GridMarkerClusterer']/method[@name='setGridSize' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setGridSize", "(I)V", "GetSetGridSize_IHandler")]
		public virtual void SetGridSize (int p0)
		{
			if (id_setGridSize_I == IntPtr.Zero)
				id_setGridSize_I = JNIEnv.GetMethodID (class_ref, "setGridSize", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setGridSize_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGridSize", "(I)V"), new JValue (p0));
		}

	}
}
