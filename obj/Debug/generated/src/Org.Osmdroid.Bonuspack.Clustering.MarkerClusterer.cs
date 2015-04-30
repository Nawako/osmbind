using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Osmdroid.Bonuspack.Clustering {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']"
	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/clustering/MarkerClusterer", DoNotGenerateAcw=true)]
	public abstract partial class MarkerClusterer : global::Osmdroid.Views.Overlay.Overlay {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/field[@name='FORCE_CLUSTERING']"
		[Register ("FORCE_CLUSTERING")]
		protected const int ForceClustering = (int) -1;

		static IntPtr mClusterIcon_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/field[@name='mClusterIcon']"
		[Register ("mClusterIcon")]
		protected global::Android.Graphics.Bitmap MClusterIcon {
			get {
				if (mClusterIcon_jfieldId == IntPtr.Zero)
					mClusterIcon_jfieldId = JNIEnv.GetFieldID (class_ref, "mClusterIcon", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mClusterIcon_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mClusterIcon_jfieldId == IntPtr.Zero)
					mClusterIcon_jfieldId = JNIEnv.GetFieldID (class_ref, "mClusterIcon", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mClusterIcon_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mClusters_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/field[@name='mClusters']"
		[Register ("mClusters")]
		protected global::System.Collections.IList MClusters {
			get {
				if (mClusters_jfieldId == IntPtr.Zero)
					mClusters_jfieldId = JNIEnv.GetFieldID (class_ref, "mClusters", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mClusters_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mClusters_jfieldId == IntPtr.Zero)
					mClusters_jfieldId = JNIEnv.GetFieldID (class_ref, "mClusters", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mClusters_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mItems_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/field[@name='mItems']"
		[Register ("mItems")]
		protected global::System.Collections.IList MItems {
			get {
				if (mItems_jfieldId == IntPtr.Zero)
					mItems_jfieldId = JNIEnv.GetFieldID (class_ref, "mItems", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mItems_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mItems_jfieldId == IntPtr.Zero)
					mItems_jfieldId = JNIEnv.GetFieldID (class_ref, "mItems", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mItems_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mLastZoomLevel_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/field[@name='mLastZoomLevel']"
		[Register ("mLastZoomLevel")]
		protected int MLastZoomLevel {
			get {
				if (mLastZoomLevel_jfieldId == IntPtr.Zero)
					mLastZoomLevel_jfieldId = JNIEnv.GetFieldID (class_ref, "mLastZoomLevel", "I");
				return JNIEnv.GetIntField (Handle, mLastZoomLevel_jfieldId);
			}
			set {
				if (mLastZoomLevel_jfieldId == IntPtr.Zero)
					mLastZoomLevel_jfieldId = JNIEnv.GetFieldID (class_ref, "mLastZoomLevel", "I");
				JNIEnv.SetField (Handle, mLastZoomLevel_jfieldId, value);
			}
		}

		static IntPtr mPoint_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/field[@name='mPoint']"
		[Register ("mPoint")]
		protected global::Android.Graphics.Point MPoint {
			get {
				if (mPoint_jfieldId == IntPtr.Zero)
					mPoint_jfieldId = JNIEnv.GetFieldID (class_ref, "mPoint", "Landroid/graphics/Point;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mPoint_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mPoint_jfieldId == IntPtr.Zero)
					mPoint_jfieldId = JNIEnv.GetFieldID (class_ref, "mPoint", "Landroid/graphics/Point;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mPoint_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/osmdroid/bonuspack/clustering/MarkerClusterer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MarkerClusterer); }
		}

		protected MarkerClusterer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/constructor[@name='MarkerClusterer' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public MarkerClusterer (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (MarkerClusterer)) {
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

		static Delegate cb_getItems;
#pragma warning disable 0169
		static Delegate GetGetItemsHandler ()
		{
			if (cb_getItems == null)
				cb_getItems = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetItems);
			return cb_getItems;
		}

		static IntPtr n_GetItems (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Osmdroid.Bonuspack.Overlays.Marker>.ToLocalJniHandle (__this.Items);
		}
#pragma warning restore 0169

		static IntPtr id_getItems;
		public virtual global::System.Collections.Generic.IList<global::Osmdroid.Bonuspack.Overlays.Marker> Items {
			// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/method[@name='getItems' and count(parameter)=0]"
			[Register ("getItems", "()Ljava/util/ArrayList;", "GetGetItemsHandler")]
			get {
				if (id_getItems == IntPtr.Zero)
					id_getItems = JNIEnv.GetMethodID (class_ref, "getItems", "()Ljava/util/ArrayList;");

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaList<global::Osmdroid.Bonuspack.Overlays.Marker>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getItems), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaList<global::Osmdroid.Bonuspack.Overlays.Marker>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItems", "()Ljava/util/ArrayList;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_add_Lorg_osmdroid_bonuspack_overlays_Marker_;
#pragma warning disable 0169
		static Delegate GetAdd_Lorg_osmdroid_bonuspack_overlays_Marker_Handler ()
		{
			if (cb_add_Lorg_osmdroid_bonuspack_overlays_Marker_ == null)
				cb_add_Lorg_osmdroid_bonuspack_overlays_Marker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Lorg_osmdroid_bonuspack_overlays_Marker_);
			return cb_add_Lorg_osmdroid_bonuspack_overlays_Marker_;
		}

		static void n_Add_Lorg_osmdroid_bonuspack_overlays_Marker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Bonuspack.Overlays.Marker p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		static IntPtr id_add_Lorg_osmdroid_bonuspack_overlays_Marker_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/method[@name='add' and count(parameter)=1 and parameter[1][@type='org.osmdroid.bonuspack.overlays.Marker']]"
		[Register ("add", "(Lorg/osmdroid/bonuspack/overlays/Marker;)V", "GetAdd_Lorg_osmdroid_bonuspack_overlays_Marker_Handler")]
		public virtual void Add (global::Osmdroid.Bonuspack.Overlays.Marker p0)
		{
			if (id_add_Lorg_osmdroid_bonuspack_overlays_Marker_ == IntPtr.Zero)
				id_add_Lorg_osmdroid_bonuspack_overlays_Marker_ = JNIEnv.GetMethodID (class_ref, "add", "(Lorg/osmdroid/bonuspack/overlays/Marker;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_add_Lorg_osmdroid_bonuspack_overlays_Marker_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lorg/osmdroid/bonuspack/overlays/Marker;)V"), new JValue (p0));
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
			global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster p0 = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildClusterMarker (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/method[@name='buildClusterMarker' and count(parameter)=2 and parameter[1][@type='org.osmdroid.bonuspack.clustering.StaticCluster'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("buildClusterMarker", "(Lorg/osmdroid/bonuspack/clustering/StaticCluster;Lorg/osmdroid/views/MapView;)Lorg/osmdroid/bonuspack/overlays/Marker;", "GetBuildClusterMarker_Lorg_osmdroid_bonuspack_clustering_StaticCluster_Lorg_osmdroid_views_MapView_Handler")]
		public abstract global::Osmdroid.Bonuspack.Overlays.Marker BuildClusterMarker (global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster p0, global::Osmdroid.Views.MapView p1);

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
			global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p0 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster>.ToLocalJniHandle (__this.Clusterer (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/method[@name='clusterer' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.MapView']]"
		[Register ("clusterer", "(Lorg/osmdroid/views/MapView;)Ljava/util/ArrayList;", "GetClusterer_Lorg_osmdroid_views_MapView_Handler")]
		public abstract global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster> Clusterer (global::Osmdroid.Views.MapView p0);

		static Delegate cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == null)
				cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z);
			return cb_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		}

		static void n_Draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p1 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='org.osmdroid.views.MapView'] and parameter[3][@type='boolean']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V", "GetDraw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ZHandler")]
		public override void Draw (global::Android.Graphics.Canvas p0, global::Osmdroid.Views.MapView p1, bool p2)
		{
			if (id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_draw_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Z, new JValue (p0), new JValue (p1), new JValue (p2));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "draw", "(Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;Z)V"), new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_getItem_I;
#pragma warning disable 0169
		static Delegate GetGetItem_IHandler ()
		{
			if (cb_getItem_I == null)
				cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
			return cb_getItem_I;
		}

		static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getItem_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getItem", "(I)Lorg/osmdroid/bonuspack/overlays/Marker;", "GetGetItem_IHandler")]
		public virtual global::Osmdroid.Bonuspack.Overlays.Marker GetItem (int p0)
		{
			if (id_getItem_I == IntPtr.Zero)
				id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Lorg/osmdroid/bonuspack/overlays/Marker;");

			if (GetType () == ThresholdType)
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (JNIEnv.CallObjectMethod  (Handle, id_getItem_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			else
				return global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "(I)Lorg/osmdroid/bonuspack/overlays/Marker;"), new JValue (p0)), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_invalidate;
#pragma warning disable 0169
		static Delegate GetInvalidateHandler ()
		{
			if (cb_invalidate == null)
				cb_invalidate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Invalidate);
			return cb_invalidate;
		}

		static void n_Invalidate (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Invalidate ();
		}
#pragma warning restore 0169

		static IntPtr id_invalidate;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/method[@name='invalidate' and count(parameter)=0]"
		[Register ("invalidate", "()V", "GetInvalidateHandler")]
		public virtual void Invalidate ()
		{
			if (id_invalidate == IntPtr.Zero)
				id_invalidate = JNIEnv.GetMethodID (class_ref, "invalidate", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_invalidate);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "invalidate", "()V"));
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
			global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.Collections.Generic.IList<Org.Osmdroid.Bonuspack.Clustering.StaticCluster> p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Osmdroid.Views.MapView p2 = global::Java.Lang.Object.GetObject<global::Osmdroid.Views.MapView> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.Renderer (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/method[@name='renderer' and count(parameter)=3 and parameter[1][@type='java.util.ArrayList'] and parameter[2][@type='android.graphics.Canvas'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register ("renderer", "(Ljava/util/ArrayList;Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;)V", "GetRenderer_Ljava_util_ArrayList_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Handler")]
		public abstract void Renderer (global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster> p0, global::Android.Graphics.Canvas p1, global::Osmdroid.Views.MapView p2);

		static Delegate cb_setIcon_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetIcon_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setIcon_Landroid_graphics_Bitmap_ == null)
				cb_setIcon_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIcon_Landroid_graphics_Bitmap_);
			return cb_setIcon_Landroid_graphics_Bitmap_;
		}

		static void n_SetIcon_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer __this = global::Java.Lang.Object.GetObject<global::Org.Osmdroid.Bonuspack.Clustering.MarkerClusterer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetIcon (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setIcon_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setIcon", "(Landroid/graphics/Bitmap;)V", "GetSetIcon_Landroid_graphics_Bitmap_Handler")]
		public virtual void SetIcon (global::Android.Graphics.Bitmap p0)
		{
			if (id_setIcon_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setIcon_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setIcon", "(Landroid/graphics/Bitmap;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setIcon_Landroid_graphics_Bitmap_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIcon", "(Landroid/graphics/Bitmap;)V"), new JValue (p0));
		}

	}

	[global::Android.Runtime.Register ("org/osmdroid/bonuspack/clustering/MarkerClusterer", DoNotGenerateAcw=true)]
	internal partial class MarkerClustererInvoker : MarkerClusterer {

		public MarkerClustererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (MarkerClustererInvoker); }
		}

		static IntPtr id_buildClusterMarker_Lorg_osmdroid_bonuspack_clustering_StaticCluster_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/method[@name='buildClusterMarker' and count(parameter)=2 and parameter[1][@type='org.osmdroid.bonuspack.clustering.StaticCluster'] and parameter[2][@type='org.osmdroid.views.MapView']]"
		[Register ("buildClusterMarker", "(Lorg/osmdroid/bonuspack/clustering/StaticCluster;Lorg/osmdroid/views/MapView;)Lorg/osmdroid/bonuspack/overlays/Marker;", "GetBuildClusterMarker_Lorg_osmdroid_bonuspack_clustering_StaticCluster_Lorg_osmdroid_views_MapView_Handler")]
		public override global::Osmdroid.Bonuspack.Overlays.Marker BuildClusterMarker (global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster p0, global::Osmdroid.Views.MapView p1)
		{
			if (id_buildClusterMarker_Lorg_osmdroid_bonuspack_clustering_StaticCluster_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_buildClusterMarker_Lorg_osmdroid_bonuspack_clustering_StaticCluster_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "buildClusterMarker", "(Lorg/osmdroid/bonuspack/clustering/StaticCluster;Lorg/osmdroid/views/MapView;)Lorg/osmdroid/bonuspack/overlays/Marker;");
			global::Osmdroid.Bonuspack.Overlays.Marker __ret = global::Java.Lang.Object.GetObject<global::Osmdroid.Bonuspack.Overlays.Marker> (JNIEnv.CallObjectMethod  (Handle, id_buildClusterMarker_Lorg_osmdroid_bonuspack_clustering_StaticCluster_Lorg_osmdroid_views_MapView_, new JValue (p0), new JValue (p1)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_clusterer_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/method[@name='clusterer' and count(parameter)=1 and parameter[1][@type='org.osmdroid.views.MapView']]"
		[Register ("clusterer", "(Lorg/osmdroid/views/MapView;)Ljava/util/ArrayList;", "GetClusterer_Lorg_osmdroid_views_MapView_Handler")]
		public override global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster> Clusterer (global::Osmdroid.Views.MapView p0)
		{
			if (id_clusterer_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_clusterer_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "clusterer", "(Lorg/osmdroid/views/MapView;)Ljava/util/ArrayList;");
			global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster> __ret = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster>.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_clusterer_Lorg_osmdroid_views_MapView_, new JValue (p0)), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static IntPtr id_renderer_Ljava_util_ArrayList_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.osmdroid.bonuspack.clustering']/class[@name='MarkerClusterer']/method[@name='renderer' and count(parameter)=3 and parameter[1][@type='java.util.ArrayList'] and parameter[2][@type='android.graphics.Canvas'] and parameter[3][@type='org.osmdroid.views.MapView']]"
		[Register ("renderer", "(Ljava/util/ArrayList;Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;)V", "GetRenderer_Ljava_util_ArrayList_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_Handler")]
		public override void Renderer (global::System.Collections.Generic.IList<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster> p0, global::Android.Graphics.Canvas p1, global::Osmdroid.Views.MapView p2)
		{
			if (id_renderer_Ljava_util_ArrayList_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ == IntPtr.Zero)
				id_renderer_Ljava_util_ArrayList_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_ = JNIEnv.GetMethodID (class_ref, "renderer", "(Ljava/util/ArrayList;Landroid/graphics/Canvas;Lorg/osmdroid/views/MapView;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Org.Osmdroid.Bonuspack.Clustering.StaticCluster>.ToLocalJniHandle (p0);
			JNIEnv.CallVoidMethod  (Handle, id_renderer_Ljava_util_ArrayList_Landroid_graphics_Canvas_Lorg_osmdroid_views_MapView_, new JValue (native_p0), new JValue (p1), new JValue (p2));
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
