package md54bfefba2fe74293f997d382b2c9adb6a;


public class CategoryActivity_AdListener
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
		mono.android.Runtime.register ("XamarinTodoQuickStart.CategoryActivity+AdListener, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CategoryActivity_AdListener.class, __md_methods);
	}


	public CategoryActivity_AdListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CategoryActivity_AdListener.class)
			mono.android.TypeManager.Activate ("XamarinTodoQuickStart.CategoryActivity+AdListener, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public CategoryActivity_AdListener (md54bfefba2fe74293f997d382b2c9adb6a.CategoryActivity p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == CategoryActivity_AdListener.class)
			mono.android.TypeManager.Activate ("XamarinTodoQuickStart.CategoryActivity+AdListener, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "XamarinTodoQuickStart.CategoryActivity, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
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
