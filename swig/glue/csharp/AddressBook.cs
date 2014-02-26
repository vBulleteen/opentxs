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

public class AddressBook : Storable {
  private HandleRef swigCPtr;

  internal AddressBook(IntPtr cPtr, bool cMemoryOwn) : base(otapiPINVOKE.AddressBook_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(AddressBook obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~AddressBook() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          otapiPINVOKE.delete_AddressBook(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public uint GetContactCount() {
    uint ret = otapiPINVOKE.AddressBook_GetContactCount(swigCPtr);
    return ret;
  }

  public Contact GetContact(uint nIndex) {
    IntPtr cPtr = otapiPINVOKE.AddressBook_GetContact(swigCPtr, nIndex);
    Contact ret = (cPtr == IntPtr.Zero) ? null : new Contact(cPtr, false);
    return ret;
  }

  public bool RemoveContact(uint nIndexContact) {
    bool ret = otapiPINVOKE.AddressBook_RemoveContact(swigCPtr, nIndexContact);
    return ret;
  }

  public bool AddContact(Contact disownObject) {
    bool ret = otapiPINVOKE.AddressBook_AddContact(swigCPtr, Contact.getCPtr(disownObject));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static AddressBook ot_dynamic_cast(Storable pObject) {
    IntPtr cPtr = otapiPINVOKE.AddressBook_ot_dynamic_cast(Storable.getCPtr(pObject));
    AddressBook ret = (cPtr == IntPtr.Zero) ? null : new AddressBook(cPtr, false);
    return ret;
  }

}

}
