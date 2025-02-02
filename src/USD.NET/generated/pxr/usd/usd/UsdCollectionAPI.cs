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

public class UsdCollectionAPI : UsdAPISchemaBase {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal UsdCollectionAPI(global::System.IntPtr cPtr, bool cMemoryOwn) : base(UsdCsPINVOKE.UsdCollectionAPI_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdCollectionAPI obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdCollectionAPI() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdCollectionAPI(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public UsdCollectionAPI(UsdPrim prim, TfToken name) : this(UsdCsPINVOKE.new_UsdCollectionAPI__SWIG_0(UsdPrim.getCPtr(prim), TfToken.getCPtr(name)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdCollectionAPI(UsdPrim prim) : this(UsdCsPINVOKE.new_UsdCollectionAPI__SWIG_1(UsdPrim.getCPtr(prim)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdCollectionAPI() : this(UsdCsPINVOKE.new_UsdCollectionAPI__SWIG_2(), true) {
  }

  public UsdCollectionAPI(UsdSchemaBase schemaObj, TfToken name) : this(UsdCsPINVOKE.new_UsdCollectionAPI__SWIG_3(UsdSchemaBase.getCPtr(schemaObj), TfToken.getCPtr(name)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static TfTokenVector GetSchemaAttributeNames(bool includeInherited, TfToken instanceName) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdCollectionAPI_GetSchemaAttributeNames__SWIG_0(includeInherited, TfToken.getCPtr(instanceName)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames(bool includeInherited) {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdCollectionAPI_GetSchemaAttributeNames__SWIG_1(includeInherited), false);
    return ret;
  }

  public new static TfTokenVector GetSchemaAttributeNames() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.UsdCollectionAPI_GetSchemaAttributeNames__SWIG_2(), false);
    return ret;
  }

  public TfToken GetName() {
    TfToken ret = new TfToken(UsdCsPINVOKE.UsdCollectionAPI_GetName(swigCPtr), true);
    return ret;
  }

  public static UsdCollectionAPI Get(UsdStageWeakPtr stage, SdfPath path) {
    UsdCollectionAPI ret = new UsdCollectionAPI(UsdCsPINVOKE.UsdCollectionAPI_Get__SWIG_0(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(path)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdCollectionAPI Get(UsdPrim prim, TfToken name) {
    UsdCollectionAPI ret = new UsdCollectionAPI(UsdCsPINVOKE.UsdCollectionAPI_Get__SWIG_1(UsdPrim.getCPtr(prim), TfToken.getCPtr(name)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool IsSchemaPropertyBaseName(TfToken baseName) {
    bool ret = UsdCsPINVOKE.UsdCollectionAPI_IsSchemaPropertyBaseName(TfToken.getCPtr(baseName));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool IsCollectionAPIPath(SdfPath path, TfToken name) {
    bool ret = UsdCsPINVOKE.UsdCollectionAPI_IsCollectionAPIPath(SdfPath.getCPtr(path), TfToken.getCPtr(name));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute GetExpansionRuleAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdCollectionAPI_GetExpansionRuleAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateExpansionRuleAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdCollectionAPI_CreateExpansionRuleAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateExpansionRuleAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdCollectionAPI_CreateExpansionRuleAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateExpansionRuleAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdCollectionAPI_CreateExpansionRuleAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdAttribute GetIncludeRootAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdCollectionAPI_GetIncludeRootAttr(swigCPtr), true);
    return ret;
  }

  public UsdAttribute CreateIncludeRootAttr(VtValue defaultValue, bool writeSparsely) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdCollectionAPI_CreateIncludeRootAttr__SWIG_0(swigCPtr, VtValue.getCPtr(defaultValue), writeSparsely), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateIncludeRootAttr(VtValue defaultValue) {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdCollectionAPI_CreateIncludeRootAttr__SWIG_1(swigCPtr, VtValue.getCPtr(defaultValue)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdAttribute CreateIncludeRootAttr() {
    UsdAttribute ret = new UsdAttribute(UsdCsPINVOKE.UsdCollectionAPI_CreateIncludeRootAttr__SWIG_2(swigCPtr), true);
    return ret;
  }

  public UsdRelationship GetIncludesRel() {
    UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdCollectionAPI_GetIncludesRel(swigCPtr), true);
    return ret;
  }

  public UsdRelationship CreateIncludesRel() {
    UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdCollectionAPI_CreateIncludesRel(swigCPtr), true);
    return ret;
  }

  public UsdRelationship GetExcludesRel() {
    UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdCollectionAPI_GetExcludesRel(swigCPtr), true);
    return ret;
  }

  public UsdRelationship CreateExcludesRel() {
    UsdRelationship ret = new UsdRelationship(UsdCsPINVOKE.UsdCollectionAPI_CreateExcludesRel(swigCPtr), true);
    return ret;
  }

  public static UsdCollectionAPI ApplyCollection(UsdPrim prim, TfToken name, TfToken expansionRule) {
    UsdCollectionAPI ret = new UsdCollectionAPI(UsdCsPINVOKE.UsdCollectionAPI_ApplyCollection__SWIG_0(UsdPrim.getCPtr(prim), TfToken.getCPtr(name), TfToken.getCPtr(expansionRule)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdCollectionAPI ApplyCollection(UsdPrim prim, TfToken name) {
    UsdCollectionAPI ret = new UsdCollectionAPI(UsdCsPINVOKE.UsdCollectionAPI_ApplyCollection__SWIG_1(UsdPrim.getCPtr(prim), TfToken.getCPtr(name)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdCollectionAPI GetCollection(UsdStageWeakPtr stage, SdfPath collectionPath) {
    UsdCollectionAPI ret = new UsdCollectionAPI(UsdCsPINVOKE.UsdCollectionAPI_GetCollection__SWIG_0(UsdStageWeakPtr.getCPtr(stage), SdfPath.getCPtr(collectionPath)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdCollectionAPI GetCollection(UsdPrim prim, TfToken name) {
    UsdCollectionAPI ret = new UsdCollectionAPI(UsdCsPINVOKE.UsdCollectionAPI_GetCollection__SWIG_1(UsdPrim.getCPtr(prim), TfToken.getCPtr(name)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static UsdCollectionAPIVector GetAllCollections(UsdPrim prim) {
    UsdCollectionAPIVector ret = new UsdCollectionAPIVector(UsdCsPINVOKE.UsdCollectionAPI_GetAllCollections(UsdPrim.getCPtr(prim)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfPath GetCollectionPath() {
    SdfPath ret = new SdfPath(UsdCsPINVOKE.UsdCollectionAPI_GetCollectionPath(swigCPtr), true);
    return ret;
  }

  public static SdfPath GetNamedCollectionPath(UsdPrim prim, TfToken collectionName) {
    SdfPath ret = new SdfPath(UsdCsPINVOKE.UsdCollectionAPI_GetNamedCollectionPath(UsdPrim.getCPtr(prim), TfToken.getCPtr(collectionName)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_UsdCollectionMembershipQuery ComputeMembershipQuery() {
    SWIGTYPE_p_UsdCollectionMembershipQuery ret = new SWIGTYPE_p_UsdCollectionMembershipQuery(UsdCsPINVOKE.UsdCollectionAPI_ComputeMembershipQuery__SWIG_0(swigCPtr), true);
    return ret;
  }

  public void ComputeMembershipQuery(SWIGTYPE_p_UsdCollectionMembershipQuery query) {
    UsdCsPINVOKE.UsdCollectionAPI_ComputeMembershipQuery__SWIG_1(swigCPtr, SWIGTYPE_p_UsdCollectionMembershipQuery.getCPtr(query));
  }

  public bool HasNoIncludedPaths() {
    bool ret = UsdCsPINVOKE.UsdCollectionAPI_HasNoIncludedPaths(swigCPtr);
    return ret;
  }

  public static SWIGTYPE_p_std__setT_SdfPath_t ComputeIncludedPaths(SWIGTYPE_p_UsdCollectionMembershipQuery query, UsdStageWeakPtr stage, Usd_PrimFlagsPredicate pred) {
    SWIGTYPE_p_std__setT_SdfPath_t ret = new SWIGTYPE_p_std__setT_SdfPath_t(UsdCsPINVOKE.UsdCollectionAPI_ComputeIncludedPaths__SWIG_0(SWIGTYPE_p_UsdCollectionMembershipQuery.getCPtr(query), UsdStageWeakPtr.getCPtr(stage), Usd_PrimFlagsPredicate.getCPtr(pred)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static SWIGTYPE_p_std__setT_SdfPath_t ComputeIncludedPaths(SWIGTYPE_p_UsdCollectionMembershipQuery query, UsdStageWeakPtr stage) {
    SWIGTYPE_p_std__setT_SdfPath_t ret = new SWIGTYPE_p_std__setT_SdfPath_t(UsdCsPINVOKE.UsdCollectionAPI_ComputeIncludedPaths__SWIG_1(SWIGTYPE_p_UsdCollectionMembershipQuery.getCPtr(query), UsdStageWeakPtr.getCPtr(stage)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IncludePath(SdfPath pathToInclude) {
    bool ret = UsdCsPINVOKE.UsdCollectionAPI_IncludePath(swigCPtr, SdfPath.getCPtr(pathToInclude));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ExcludePath(SdfPath pathToExclude) {
    bool ret = UsdCsPINVOKE.UsdCollectionAPI_ExcludePath(swigCPtr, SdfPath.getCPtr(pathToExclude));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Validate(/*cstype*/ out string reason) {
    bool ret = UsdCsPINVOKE.UsdCollectionAPI_Validate(swigCPtr, out reason);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ResetCollection() {
    bool ret = UsdCsPINVOKE.UsdCollectionAPI_ResetCollection(swigCPtr);
    return ret;
  }

  public bool BlockCollection() {
    bool ret = UsdCsPINVOKE.UsdCollectionAPI_BlockCollection(swigCPtr);
    return ret;
  }

  public static UsdObjectVector ComputeIncludedObjects(SWIGTYPE_p_UsdCollectionMembershipQuery query, UsdStageWeakPtr stage) {
    UsdObjectVector ret = new UsdObjectVector(UsdCsPINVOKE.UsdCollectionAPI_ComputeIncludedObjects(SWIGTYPE_p_UsdCollectionMembershipQuery.getCPtr(query), UsdStageWeakPtr.getCPtr(stage)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
