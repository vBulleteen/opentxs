/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace OpenTransactions.OTAPI {

using System;
using System.Runtime.InteropServices;

public class Storage : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Storage(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Storage obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Storage() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          otapiPINVOKE.delete_Storage(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_OTPacker GetPacker(PackType ePackType) {
    IntPtr cPtr = otapiPINVOKE.Storage_GetPacker__SWIG_0(swigCPtr, (int)ePackType);
    SWIGTYPE_p_OTPacker ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_OTPacker(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_OTPacker GetPacker() {
    IntPtr cPtr = otapiPINVOKE.Storage_GetPacker__SWIG_1(swigCPtr);
    SWIGTYPE_p_OTPacker ret = (cPtr == IntPtr.Zero) ? null : new SWIGTYPE_p_OTPacker(cPtr, false);
    return ret;
  }

  public virtual bool Exists(string strFolder, string oneStr, string twoStr, string threeStr) {
    bool ret = otapiPINVOKE.Storage_Exists__SWIG_0(swigCPtr, strFolder, oneStr, twoStr, threeStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Exists(string strFolder, string oneStr, string twoStr) {
    bool ret = otapiPINVOKE.Storage_Exists__SWIG_1(swigCPtr, strFolder, oneStr, twoStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Exists(string strFolder, string oneStr) {
    bool ret = otapiPINVOKE.Storage_Exists__SWIG_2(swigCPtr, strFolder, oneStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool Exists(string strFolder) {
    bool ret = otapiPINVOKE.Storage_Exists__SWIG_3(swigCPtr, strFolder);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool StoreString(string strContents, string strFolder, string oneStr, string twoStr, string threeStr) {
    bool ret = otapiPINVOKE.Storage_StoreString__SWIG_0(swigCPtr, strContents, strFolder, oneStr, twoStr, threeStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool StoreString(string strContents, string strFolder, string oneStr, string twoStr) {
    bool ret = otapiPINVOKE.Storage_StoreString__SWIG_1(swigCPtr, strContents, strFolder, oneStr, twoStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool StoreString(string strContents, string strFolder, string oneStr) {
    bool ret = otapiPINVOKE.Storage_StoreString__SWIG_2(swigCPtr, strContents, strFolder, oneStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool StoreString(string strContents, string strFolder) {
    bool ret = otapiPINVOKE.Storage_StoreString__SWIG_3(swigCPtr, strContents, strFolder);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string QueryString(string strFolder, string oneStr, string twoStr, string threeStr) {
    string ret = otapiPINVOKE.Storage_QueryString__SWIG_0(swigCPtr, strFolder, oneStr, twoStr, threeStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string QueryString(string strFolder, string oneStr, string twoStr) {
    string ret = otapiPINVOKE.Storage_QueryString__SWIG_1(swigCPtr, strFolder, oneStr, twoStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string QueryString(string strFolder, string oneStr) {
    string ret = otapiPINVOKE.Storage_QueryString__SWIG_2(swigCPtr, strFolder, oneStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string QueryString(string strFolder) {
    string ret = otapiPINVOKE.Storage_QueryString__SWIG_3(swigCPtr, strFolder);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool StorePlainString(string strContents, string strFolder, string oneStr, string twoStr, string threeStr) {
    bool ret = otapiPINVOKE.Storage_StorePlainString__SWIG_0(swigCPtr, strContents, strFolder, oneStr, twoStr, threeStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool StorePlainString(string strContents, string strFolder, string oneStr, string twoStr) {
    bool ret = otapiPINVOKE.Storage_StorePlainString__SWIG_1(swigCPtr, strContents, strFolder, oneStr, twoStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool StorePlainString(string strContents, string strFolder, string oneStr) {
    bool ret = otapiPINVOKE.Storage_StorePlainString__SWIG_2(swigCPtr, strContents, strFolder, oneStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool StorePlainString(string strContents, string strFolder) {
    bool ret = otapiPINVOKE.Storage_StorePlainString__SWIG_3(swigCPtr, strContents, strFolder);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string QueryPlainString(string strFolder, string oneStr, string twoStr, string threeStr) {
    string ret = otapiPINVOKE.Storage_QueryPlainString__SWIG_0(swigCPtr, strFolder, oneStr, twoStr, threeStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string QueryPlainString(string strFolder, string oneStr, string twoStr) {
    string ret = otapiPINVOKE.Storage_QueryPlainString__SWIG_1(swigCPtr, strFolder, oneStr, twoStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string QueryPlainString(string strFolder, string oneStr) {
    string ret = otapiPINVOKE.Storage_QueryPlainString__SWIG_2(swigCPtr, strFolder, oneStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string QueryPlainString(string strFolder) {
    string ret = otapiPINVOKE.Storage_QueryPlainString__SWIG_3(swigCPtr, strFolder);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool StoreObject(Storable theContents, string strFolder, string oneStr, string twoStr, string threeStr) {
    bool ret = otapiPINVOKE.Storage_StoreObject__SWIG_0(swigCPtr, Storable.getCPtr(theContents), strFolder, oneStr, twoStr, threeStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool StoreObject(Storable theContents, string strFolder, string oneStr, string twoStr) {
    bool ret = otapiPINVOKE.Storage_StoreObject__SWIG_1(swigCPtr, Storable.getCPtr(theContents), strFolder, oneStr, twoStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool StoreObject(Storable theContents, string strFolder, string oneStr) {
    bool ret = otapiPINVOKE.Storage_StoreObject__SWIG_2(swigCPtr, Storable.getCPtr(theContents), strFolder, oneStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool StoreObject(Storable theContents, string strFolder) {
    bool ret = otapiPINVOKE.Storage_StoreObject__SWIG_3(swigCPtr, Storable.getCPtr(theContents), strFolder);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Storable QueryObject(StoredObjectType theObjectType, string strFolder, string oneStr, string twoStr, string threeStr) {
    IntPtr cPtr = otapiPINVOKE.Storage_QueryObject__SWIG_0(swigCPtr, (int)theObjectType, strFolder, oneStr, twoStr, threeStr);
    Storable ret = (cPtr == IntPtr.Zero) ? null : new Storable(cPtr, true);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Storable QueryObject(StoredObjectType theObjectType, string strFolder, string oneStr, string twoStr) {
    IntPtr cPtr = otapiPINVOKE.Storage_QueryObject__SWIG_1(swigCPtr, (int)theObjectType, strFolder, oneStr, twoStr);
    Storable ret = (cPtr == IntPtr.Zero) ? null : new Storable(cPtr, true);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Storable QueryObject(StoredObjectType theObjectType, string strFolder, string oneStr) {
    IntPtr cPtr = otapiPINVOKE.Storage_QueryObject__SWIG_2(swigCPtr, (int)theObjectType, strFolder, oneStr);
    Storable ret = (cPtr == IntPtr.Zero) ? null : new Storable(cPtr, true);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Storable QueryObject(StoredObjectType theObjectType, string strFolder) {
    IntPtr cPtr = otapiPINVOKE.Storage_QueryObject__SWIG_3(swigCPtr, (int)theObjectType, strFolder);
    Storable ret = (cPtr == IntPtr.Zero) ? null : new Storable(cPtr, true);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string EncodeObject(Storable theContents) {
    string ret = otapiPINVOKE.Storage_EncodeObject(swigCPtr, Storable.getCPtr(theContents));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Storable DecodeObject(StoredObjectType theObjectType, string strInput) {
    IntPtr cPtr = otapiPINVOKE.Storage_DecodeObject(swigCPtr, (int)theObjectType, strInput);
    Storable ret = (cPtr == IntPtr.Zero) ? null : new Storable(cPtr, true);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool EraseValueByKey(string strFolder, string oneStr, string twoStr, string threeStr) {
    bool ret = otapiPINVOKE.Storage_EraseValueByKey__SWIG_0(swigCPtr, strFolder, oneStr, twoStr, threeStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool EraseValueByKey(string strFolder, string oneStr, string twoStr) {
    bool ret = otapiPINVOKE.Storage_EraseValueByKey__SWIG_1(swigCPtr, strFolder, oneStr, twoStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool EraseValueByKey(string strFolder, string oneStr) {
    bool ret = otapiPINVOKE.Storage_EraseValueByKey__SWIG_2(swigCPtr, strFolder, oneStr);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool EraseValueByKey(string strFolder) {
    bool ret = otapiPINVOKE.Storage_EraseValueByKey__SWIG_3(swigCPtr, strFolder);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Storable CreateObject(StoredObjectType eType) {
    IntPtr cPtr = otapiPINVOKE.Storage_CreateObject(swigCPtr, (int)eType);
    Storable ret = (cPtr == IntPtr.Zero) ? null : new Storable(cPtr, true);
    return ret;
  }

  public static Storage Create(StorageType eStorageType, PackType ePackType) {
    IntPtr cPtr = otapiPINVOKE.Storage_Create((int)eStorageType, (int)ePackType);
    Storage ret = (cPtr == IntPtr.Zero) ? null : new Storage(cPtr, false);
    return ret;
  }

  public StorageType GetType() {
    StorageType ret = (StorageType)otapiPINVOKE.Storage_GetType(swigCPtr);
    return ret;
  }

}

}
