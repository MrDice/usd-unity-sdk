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
public class VtUInt64Array : Vt_ArrayBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal VtUInt64Array(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.VtUInt64Array_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VtUInt64Array obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VtUInt64Array() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_VtUInt64Array(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

	  public ulong this[int index] {
		  get { return GetValue(index); }
		  set { SetValue(index, value); }
	  }
  
  public VtUInt64Array() : this(UsdCsPINVOKE.new_VtUInt64Array__SWIG_0(), true) {
  }

  public VtUInt64Array(VtUInt64Array other) : this(UsdCsPINVOKE.new_VtUInt64Array__SWIG_1(VtUInt64Array.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtUInt64Array(uint n) : this(UsdCsPINVOKE.new_VtUInt64Array__SWIG_3(n), true) {
  }

  public VtUInt64Array(uint n, ulong value) : this(UsdCsPINVOKE.new_VtUInt64Array__SWIG_4(n, value), true) {
  }

  public void push_back(ulong elem) {
    UsdCsPINVOKE.VtUInt64Array_push_back(swigCPtr, elem);
  }

  public void pop_back() {
    UsdCsPINVOKE.VtUInt64Array_pop_back(swigCPtr);
  }

  public uint size() {
    uint ret = UsdCsPINVOKE.VtUInt64Array_size(swigCPtr);
    return ret;
  }

  public uint capacity() {
    uint ret = UsdCsPINVOKE.VtUInt64Array_capacity(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = UsdCsPINVOKE.VtUInt64Array_empty(swigCPtr);
    return ret;
  }

  public void reserve(uint num) {
    UsdCsPINVOKE.VtUInt64Array_reserve(swigCPtr, num);
  }

  public void resize(uint newSize) {
    UsdCsPINVOKE.VtUInt64Array_resize(swigCPtr, newSize);
  }

  public void clear() {
    UsdCsPINVOKE.VtUInt64Array_clear(swigCPtr);
  }

  public void assign(uint n, ulong fill) {
    UsdCsPINVOKE.VtUInt64Array_assign(swigCPtr, n, fill);
  }

  public void swap(VtUInt64Array other) {
    UsdCsPINVOKE.VtUInt64Array_swap(swigCPtr, VtUInt64Array.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsIdentical(VtUInt64Array other) {
    bool ret = UsdCsPINVOKE.VtUInt64Array_IsIdentical(swigCPtr, VtUInt64Array.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Equals(VtUInt64Array lhs, VtUInt64Array rhs) {
    bool ret = UsdCsPINVOKE.VtUInt64Array_Equals(VtUInt64Array.getCPtr(lhs), VtUInt64Array.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string ToString() {
    string ret = UsdCsPINVOKE.VtUInt64Array_ToString(swigCPtr);
    return ret;
  }

  public void CopyToArray(ulong[] dest) {
    UsdCsPINVOKE.VtUInt64Array_CopyToArray__SWIG_0(swigCPtr, dest);
  }

  public void CopyFromArray(ulong[] src) {
    UsdCsPINVOKE.VtUInt64Array_CopyFromArray__SWIG_0(swigCPtr, src);
  }

  public void CopyToArray(System.IntPtr dest) {
    UsdCsPINVOKE.VtUInt64Array_CopyToArray__SWIG_1(swigCPtr, dest);
  }

  public void CopyFromArray(System.IntPtr src) {
    UsdCsPINVOKE.VtUInt64Array_CopyFromArray__SWIG_1(swigCPtr, src);
  }

  protected ulong GetValue(int index) {
    ulong ret = UsdCsPINVOKE.VtUInt64Array_GetValue(swigCPtr, index);
    return ret;
  }

  protected void SetValue(int index, ulong value) {
    UsdCsPINVOKE.VtUInt64Array_SetValue(swigCPtr, index, value);
  }

}

}
