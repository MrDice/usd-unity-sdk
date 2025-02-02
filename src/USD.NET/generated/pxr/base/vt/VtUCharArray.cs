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
public class VtUCharArray : Vt_ArrayBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal VtUCharArray(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.VtUCharArray_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VtUCharArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~VtUCharArray() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_VtUCharArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

	  public byte this[int index] {
		  get { return GetValue(index); }
		  set { SetValue(index, value); }
	  }
  
  public VtUCharArray() : this(UsdCsPINVOKE.new_VtUCharArray__SWIG_0(), true) {
  }

  public VtUCharArray(VtUCharArray other) : this(UsdCsPINVOKE.new_VtUCharArray__SWIG_1(VtUCharArray.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public VtUCharArray(uint n) : this(UsdCsPINVOKE.new_VtUCharArray__SWIG_3(n), true) {
  }

  public VtUCharArray(uint n, byte value) : this(UsdCsPINVOKE.new_VtUCharArray__SWIG_4(n, value), true) {
  }

  public void push_back(byte elem) {
    UsdCsPINVOKE.VtUCharArray_push_back(swigCPtr, elem);
  }

  public void pop_back() {
    UsdCsPINVOKE.VtUCharArray_pop_back(swigCPtr);
  }

  public uint size() {
    uint ret = UsdCsPINVOKE.VtUCharArray_size(swigCPtr);
    return ret;
  }

  public uint capacity() {
    uint ret = UsdCsPINVOKE.VtUCharArray_capacity(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = UsdCsPINVOKE.VtUCharArray_empty(swigCPtr);
    return ret;
  }

  public void reserve(uint num) {
    UsdCsPINVOKE.VtUCharArray_reserve(swigCPtr, num);
  }

  public void resize(uint newSize) {
    UsdCsPINVOKE.VtUCharArray_resize(swigCPtr, newSize);
  }

  public void clear() {
    UsdCsPINVOKE.VtUCharArray_clear(swigCPtr);
  }

  public void assign(uint n, byte fill) {
    UsdCsPINVOKE.VtUCharArray_assign(swigCPtr, n, fill);
  }

  public void swap(VtUCharArray other) {
    UsdCsPINVOKE.VtUCharArray_swap(swigCPtr, VtUCharArray.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsIdentical(VtUCharArray other) {
    bool ret = UsdCsPINVOKE.VtUCharArray_IsIdentical(swigCPtr, VtUCharArray.getCPtr(other));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool Equals(VtUCharArray lhs, VtUCharArray rhs) {
    bool ret = UsdCsPINVOKE.VtUCharArray_Equals(VtUCharArray.getCPtr(lhs), VtUCharArray.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string ToString() {
    string ret = UsdCsPINVOKE.VtUCharArray_ToString(swigCPtr);
    return ret;
  }

  public void CopyToArray(byte[] dest) {
    UsdCsPINVOKE.VtUCharArray_CopyToArray__SWIG_0(swigCPtr, dest);
  }

  public void CopyFromArray(byte[] src) {
    UsdCsPINVOKE.VtUCharArray_CopyFromArray__SWIG_0(swigCPtr, src);
  }

  public void CopyToArray(System.IntPtr dest) {
    UsdCsPINVOKE.VtUCharArray_CopyToArray__SWIG_1(swigCPtr, dest);
  }

  public void CopyFromArray(System.IntPtr src) {
    UsdCsPINVOKE.VtUCharArray_CopyFromArray__SWIG_1(swigCPtr, src);
  }

  protected byte GetValue(int index) {
    byte ret = UsdCsPINVOKE.VtUCharArray_GetValue(swigCPtr, index);
    return ret;
  }

  protected void SetValue(int index, byte value) {
    UsdCsPINVOKE.VtUCharArray_SetValue(swigCPtr, index, value);
  }

}

}
