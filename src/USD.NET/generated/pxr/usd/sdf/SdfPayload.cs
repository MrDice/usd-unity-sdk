//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class SdfPayload : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SdfPayload(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfPayload obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SdfPayload() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_SdfPayload(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SdfPayload(string assetPath, SdfPath primPath, SdfLayerOffset layerOffset) : this(UsdCsPINVOKE.new_SdfPayload__SWIG_0(assetPath, SdfPath.getCPtr(primPath), SdfLayerOffset.getCPtr(layerOffset)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SdfPayload(string assetPath, SdfPath primPath) : this(UsdCsPINVOKE.new_SdfPayload__SWIG_1(assetPath, SdfPath.getCPtr(primPath)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SdfPayload(string assetPath) : this(UsdCsPINVOKE.new_SdfPayload__SWIG_2(assetPath), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SdfPayload() : this(UsdCsPINVOKE.new_SdfPayload__SWIG_3(), true) {
  }

  public string GetAssetPath() {
    string ret = UsdCsPINVOKE.SdfPayload_GetAssetPath(swigCPtr);
    return ret;
  }

  public void SetAssetPath(string assetPath) {
    UsdCsPINVOKE.SdfPayload_SetAssetPath(swigCPtr, assetPath);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SdfPath GetPrimPath() {
    SdfPath ret = new SdfPath(UsdCsPINVOKE.SdfPayload_GetPrimPath(swigCPtr), false);
    return ret;
  }

  public void SetPrimPath(SdfPath primPath) {
    UsdCsPINVOKE.SdfPayload_SetPrimPath(swigCPtr, SdfPath.getCPtr(primPath));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SdfLayerOffset GetLayerOffset() {
    SdfLayerOffset ret = new SdfLayerOffset(UsdCsPINVOKE.SdfPayload_GetLayerOffset(swigCPtr), false);
    return ret;
  }

  public void SetLayerOffset(SdfLayerOffset layerOffset) {
    UsdCsPINVOKE.SdfPayload_SetLayerOffset(swigCPtr, SdfLayerOffset.getCPtr(layerOffset));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
