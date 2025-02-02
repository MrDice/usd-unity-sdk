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
public class VtVec3hArray : Vt_ArrayBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal VtVec3hArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.VtVec3hArray_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VtVec3hArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VtVec3hArray() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_VtVec3hArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

	  public GfVec3h this[int index] {
		  get { return GetValue(index); }
		  set { SetValue(index, value); }
	  }
  
  public VtVec3hArray() : this(UsdCsPINVOKE.new_VtVec3hArray__SWIG_0(), true) {
  }

  public VtVec3hArray(VtVec3hArray other) : this(UsdCsPINVOKE.new_VtVec3hArray__SWIG_1(VtVec3hArray.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtVec3hArray(uint n) : this(UsdCsPINVOKE.new_VtVec3hArray__SWIG_3(n), true) {
  }

  public VtVec3hArray(uint n, GfVec3h value) : this(UsdCsPINVOKE.new_VtVec3hArray__SWIG_4(n, GfVec3h.getCPtr(value)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void push_back(GfVec3h elem) {
    UsdCsPINVOKE.VtVec3hArray_push_back(swigCPtr, GfVec3h.getCPtr(elem));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pop_back() {
    UsdCsPINVOKE.VtVec3hArray_pop_back(swigCPtr);
  }

  public uint size() {
    uint ret = UsdCsPINVOKE.VtVec3hArray_size(swigCPtr);
    return ret;
  }

  public uint capacity() {
    uint ret = UsdCsPINVOKE.VtVec3hArray_capacity(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = UsdCsPINVOKE.VtVec3hArray_empty(swigCPtr);
    return ret;
  }

  public void reserve(uint num) {
    UsdCsPINVOKE.VtVec3hArray_reserve(swigCPtr, num);
  }

  public void resize(uint newSize) {
    UsdCsPINVOKE.VtVec3hArray_resize(swigCPtr, newSize);
  }

  public void clear() {
    UsdCsPINVOKE.VtVec3hArray_clear(swigCPtr);
  }

  public void assign(uint n, GfVec3h fill) {
    UsdCsPINVOKE.VtVec3hArray_assign(swigCPtr, n, GfVec3h.getCPtr(fill));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void swap(VtVec3hArray other) {
    UsdCsPINVOKE.VtVec3hArray_swap(swigCPtr, VtVec3hArray.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsIdentical(VtVec3hArray other) {
    bool ret = UsdCsPINVOKE.VtVec3hArray_IsIdentical(swigCPtr, VtVec3hArray.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Equals(VtVec3hArray lhs, VtVec3hArray rhs) {
    bool ret = UsdCsPINVOKE.VtVec3hArray_Equals(VtVec3hArray.getCPtr(lhs), VtVec3hArray.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string ToString() {
    string ret = UsdCsPINVOKE.VtVec3hArray_ToString(swigCPtr);
    return ret;
  }

  public void CopyToArray(GfVec3h[] dest) {
    UsdCsPINVOKE.VtVec3hArray_CopyToArray__SWIG_0(swigCPtr, dest);
  }

  public void CopyFromArray(GfVec3h[] src) {
    UsdCsPINVOKE.VtVec3hArray_CopyFromArray__SWIG_0(swigCPtr, src);
  }

  public void CopyToArray(System.IntPtr dest) {
    UsdCsPINVOKE.VtVec3hArray_CopyToArray__SWIG_1(swigCPtr, dest);
  }

  public void CopyFromArray(System.IntPtr src) {
    UsdCsPINVOKE.VtVec3hArray_CopyFromArray__SWIG_1(swigCPtr, src);
  }

  protected GfVec3h GetValue(int index) {
    GfVec3h ret = new GfVec3h(UsdCsPINVOKE.VtVec3hArray_GetValue(swigCPtr, index), false);
    return ret;
  }

  protected void SetValue(int index, GfVec3h value) {
    UsdCsPINVOKE.VtVec3hArray_SetValue(swigCPtr, index, GfVec3h.getCPtr(value));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
