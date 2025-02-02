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

[Preserve]
public class SdfAssetPathArray : Vt_ArrayBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SdfAssetPathArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.SdfAssetPathArray_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfAssetPathArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SdfAssetPathArray() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_SdfAssetPathArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

	  public SdfAssetPath this[int index] {
		  get { return GetValue(index); }
		  set { SetValue(index, value); }
	  }
  
  public SdfAssetPathArray() : this(UsdCsPINVOKE.new_SdfAssetPathArray__SWIG_0(), true) {
  }

  public SdfAssetPathArray(SdfAssetPathArray other) : this(UsdCsPINVOKE.new_SdfAssetPathArray__SWIG_1(SdfAssetPathArray.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SdfAssetPathArray(uint n) : this(UsdCsPINVOKE.new_SdfAssetPathArray__SWIG_3(n), true) {
  }

  public SdfAssetPathArray(uint n, SdfAssetPath value) : this(UsdCsPINVOKE.new_SdfAssetPathArray__SWIG_4(n, SdfAssetPath.getCPtr(value)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void push_back(SdfAssetPath elem) {
    UsdCsPINVOKE.SdfAssetPathArray_push_back(swigCPtr, SdfAssetPath.getCPtr(elem));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pop_back() {
    UsdCsPINVOKE.SdfAssetPathArray_pop_back(swigCPtr);
  }

  public uint size() {
    uint ret = UsdCsPINVOKE.SdfAssetPathArray_size(swigCPtr);
    return ret;
  }

  public uint capacity() {
    uint ret = UsdCsPINVOKE.SdfAssetPathArray_capacity(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = UsdCsPINVOKE.SdfAssetPathArray_empty(swigCPtr);
    return ret;
  }

  public void reserve(uint num) {
    UsdCsPINVOKE.SdfAssetPathArray_reserve(swigCPtr, num);
  }

  public void resize(uint newSize) {
    UsdCsPINVOKE.SdfAssetPathArray_resize(swigCPtr, newSize);
  }

  public void clear() {
    UsdCsPINVOKE.SdfAssetPathArray_clear(swigCPtr);
  }

  public void assign(uint n, SdfAssetPath fill) {
    UsdCsPINVOKE.SdfAssetPathArray_assign(swigCPtr, n, SdfAssetPath.getCPtr(fill));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void swap(SdfAssetPathArray other) {
    UsdCsPINVOKE.SdfAssetPathArray_swap(swigCPtr, SdfAssetPathArray.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsIdentical(SdfAssetPathArray other) {
    bool ret = UsdCsPINVOKE.SdfAssetPathArray_IsIdentical(swigCPtr, SdfAssetPathArray.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Equals(SdfAssetPathArray lhs, SdfAssetPathArray rhs) {
    bool ret = UsdCsPINVOKE.SdfAssetPathArray_Equals(SdfAssetPathArray.getCPtr(lhs), SdfAssetPathArray.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string ToString() {
    string ret = UsdCsPINVOKE.SdfAssetPathArray_ToString(swigCPtr);
    return ret;
  }

  public void CopyToArray(SdfAssetPath[] dest) {
    UsdCsPINVOKE.SdfAssetPathArray_CopyToArray__SWIG_0(swigCPtr, dest);
  }

  public void CopyFromArray(SdfAssetPath[] src) {
    UsdCsPINVOKE.SdfAssetPathArray_CopyFromArray__SWIG_0(swigCPtr, src);
  }

  public void CopyToArray(System.IntPtr dest) {
    UsdCsPINVOKE.SdfAssetPathArray_CopyToArray__SWIG_1(swigCPtr, dest);
  }

  public void CopyFromArray(System.IntPtr src) {
    UsdCsPINVOKE.SdfAssetPathArray_CopyFromArray__SWIG_1(swigCPtr, src);
  }

  protected SdfAssetPath GetValue(int index) {
    SdfAssetPath ret = new SdfAssetPath(UsdCsPINVOKE.SdfAssetPathArray_GetValue(swigCPtr, index), false);
    return ret;
  }

  protected void SetValue(int index, SdfAssetPath value) {
    UsdCsPINVOKE.SdfAssetPathArray_SetValue(swigCPtr, index, SdfAssetPath.getCPtr(value));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
