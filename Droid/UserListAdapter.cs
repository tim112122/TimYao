using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Views;
using System.Collections.Generic;

namespace timyao.Droid
{
	public class UserListAdapter : BaseAdapter<User>
	{
		private Activity context;

		private List<User> Users { get; set; }


		public UserListAdapter(IEnumerable<User> users, Activity context)
		{
			this.context = context;

			Users = new List<User>();
			Users.AddRange(users);
		}


		public override User this[int position] => Users[position];

		public override int Count => Users.Count;

		public override long GetItemId(int position)
		{
			return position;
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			// UI Binding
			var view = convertView;

			if (null == view)
			{
                view = context.LayoutInflater.Inflate(Resource.Layout.master_masterview_useritem, parent, false);

			}

			// Data Binding
			User user = Users[position];

			view.FindViewById<TextView>(Resource.Id.master_masterview_useritemview_lbuser).Text = user.Name;
            view.FindViewById<TextView>(Resource.Id.master_masterview_useritemview_lbDescription).Text = user.Description;

			return view;
		}
	}
}
