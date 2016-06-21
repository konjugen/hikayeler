package md5304e69416e624e1b520a2afb6e997d17;


public class Story_StorieItemWrapper
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("storie.Story+StorieItemWrapper, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Story_StorieItemWrapper.class, __md_methods);
	}


	public Story_StorieItemWrapper () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Story_StorieItemWrapper.class)
			mono.android.TypeManager.Activate ("storie.Story+StorieItemWrapper, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	java.util.ArrayList refList;
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
