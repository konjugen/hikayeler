package md5304e69416e624e1b520a2afb6e997d17;


public class ContentActivity_AdListener
	extends com.google.android.gms.ads.AdListener
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onAdClosed:()V:GetOnAdClosedHandler\n" +
			"";
		mono.android.Runtime.register ("storie.ContentActivity+AdListener, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ContentActivity_AdListener.class, __md_methods);
	}


	public ContentActivity_AdListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ContentActivity_AdListener.class)
			mono.android.TypeManager.Activate ("storie.ContentActivity+AdListener, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public ContentActivity_AdListener (md5304e69416e624e1b520a2afb6e997d17.ContentActivity p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == ContentActivity_AdListener.class)
			mono.android.TypeManager.Activate ("storie.ContentActivity+AdListener, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "storie.ContentActivity, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public void onAdClosed ()
	{
		n_onAdClosed ();
	}

	private native void n_onAdClosed ();

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
