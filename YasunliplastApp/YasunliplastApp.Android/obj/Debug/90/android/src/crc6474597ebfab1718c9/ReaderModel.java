package crc6474597ebfab1718c9;


public class ReaderModel
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.zebra.rfid.api3.Readers.RFIDReaderEventHandler,
		com.zebra.rfid.api3.RfidEventsListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_RFIDReaderAppeared:(Lcom/zebra/rfid/api3/ReaderDevice;)V:GetRFIDReaderAppeared_Lcom_zebra_rfid_api3_ReaderDevice_Handler:Com.Zebra.Rfid.Api3.Readers/IRFIDReaderEventHandlerInvoker, XamarinZebraRFID\n" +
			"n_RFIDReaderDisappeared:(Lcom/zebra/rfid/api3/ReaderDevice;)V:GetRFIDReaderDisappeared_Lcom_zebra_rfid_api3_ReaderDevice_Handler:Com.Zebra.Rfid.Api3.Readers/IRFIDReaderEventHandlerInvoker, XamarinZebraRFID\n" +
			"n_eventReadNotify:(Lcom/zebra/rfid/api3/RfidReadEvents;)V:GetEventReadNotify_Lcom_zebra_rfid_api3_RfidReadEvents_Handler:Com.Zebra.Rfid.Api3.IRfidEventsListenerInvoker, XamarinZebraRFID\n" +
			"n_eventStatusNotify:(Lcom/zebra/rfid/api3/RfidStatusEvents;)V:GetEventStatusNotify_Lcom_zebra_rfid_api3_RfidStatusEvents_Handler:Com.Zebra.Rfid.Api3.IRfidEventsListenerInvoker, XamarinZebraRFID\n" +
			"";
		mono.android.Runtime.register ("YasunliplastApp.Models.ReaderModel, YasunliplastApp", ReaderModel.class, __md_methods);
	}


	public ReaderModel ()
	{
		super ();
		if (getClass () == ReaderModel.class)
			mono.android.TypeManager.Activate ("YasunliplastApp.Models.ReaderModel, YasunliplastApp", "", this, new java.lang.Object[] {  });
	}


	public void RFIDReaderAppeared (com.zebra.rfid.api3.ReaderDevice p0)
	{
		n_RFIDReaderAppeared (p0);
	}

	private native void n_RFIDReaderAppeared (com.zebra.rfid.api3.ReaderDevice p0);


	public void RFIDReaderDisappeared (com.zebra.rfid.api3.ReaderDevice p0)
	{
		n_RFIDReaderDisappeared (p0);
	}

	private native void n_RFIDReaderDisappeared (com.zebra.rfid.api3.ReaderDevice p0);


	public void eventReadNotify (com.zebra.rfid.api3.RfidReadEvents p0)
	{
		n_eventReadNotify (p0);
	}

	private native void n_eventReadNotify (com.zebra.rfid.api3.RfidReadEvents p0);


	public void eventStatusNotify (com.zebra.rfid.api3.RfidStatusEvents p0)
	{
		n_eventStatusNotify (p0);
	}

	private native void n_eventStatusNotify (com.zebra.rfid.api3.RfidStatusEvents p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
