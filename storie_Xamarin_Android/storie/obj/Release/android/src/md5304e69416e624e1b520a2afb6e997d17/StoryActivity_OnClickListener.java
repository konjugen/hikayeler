package md5304e69416e624e1b520a2afb6e997d17;


public class StoryActivity_OnClickListener
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
		mono.android.Runtime.register ("storie.StoryActivity+OnClickListener, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", StoryActivity_OnClickListener.class, __md_methods);
	}


	public StoryActivity_OnClickListener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == StoryActivity_OnClickListener.class)
			mono.android.TypeManager.Activate ("storie.StoryActivity+OnClickListener, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public StoryActivity_OnClickListener (md5304e69416e624e1b520a2afb6e997d17.StoryActivity p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == StoryActivity_OnClickListener.class)
			mono.android.TypeManager.Activate ("storie.StoryActivity+OnClickListener, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "storie.StoryActivity, storie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
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
