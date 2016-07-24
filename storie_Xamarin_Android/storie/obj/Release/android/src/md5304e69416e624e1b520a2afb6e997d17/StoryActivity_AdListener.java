package md5304e69416e624e1b520a2afb6e997d17;


public class StoryActivity_AdListener
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
		mono.android.Runtime.register ("storie.StoryActivity+AdListener, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", StoryActivity_AdListener.class, __md_methods);
	}


	public StoryActivity_AdListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == StoryActivity_AdListener.class)
			mono.android.TypeManager.Activate ("storie.StoryActivity+AdListener, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public StoryActivity_AdListener (md5304e69416e624e1b520a2afb6e997d17.StoryActivity p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == StoryActivity_AdListener.class)
			mono.android.TypeManager.Activate ("storie.StoryActivity+AdListener, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "storie.StoryActivity, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
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
