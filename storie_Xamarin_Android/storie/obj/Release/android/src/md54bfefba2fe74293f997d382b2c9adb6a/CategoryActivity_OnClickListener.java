package md54bfefba2fe74293f997d382b2c9adb6a;


public class CategoryActivity_OnClickListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnClickListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler:Android.Views.View/IOnClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("XamarinTodoQuickStart.CategoryActivity+OnClickListener, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CategoryActivity_OnClickListener.class, __md_methods);
	}


	public CategoryActivity_OnClickListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CategoryActivity_OnClickListener.class)
			mono.android.TypeManager.Activate ("XamarinTodoQuickStart.CategoryActivity+OnClickListener, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public CategoryActivity_OnClickListener (md54bfefba2fe74293f997d382b2c9adb6a.CategoryActivity p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == CategoryActivity_OnClickListener.class)
			mono.android.TypeManager.Activate ("XamarinTodoQuickStart.CategoryActivity+OnClickListener, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "XamarinTodoQuickStart.CategoryActivity, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);

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
