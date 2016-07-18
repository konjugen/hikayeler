package md5304e69416e624e1b520a2afb6e997d17;


public class ContentActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("storie.ContentActivity, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ContentActivity.class, __md_methods);
	}


	public ContentActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ContentActivity.class)
			mono.android.TypeManager.Activate ("storie.ContentActivity, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
