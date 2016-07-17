package md5304e69416e624e1b520a2afb6e997d17;


public class CategoryItemWrapper
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("storie.CategoryItemWrapper, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CategoryItemWrapper.class, __md_methods);
	}


	public CategoryItemWrapper () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CategoryItemWrapper.class)
			mono.android.TypeManager.Activate ("storie.CategoryItemWrapper, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

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
