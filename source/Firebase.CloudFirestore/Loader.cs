﻿using System;
namespace Firebase.CloudFirestore
{
	public class Loader
	{
		static Loader ()
		{
			Firebase.InstanceID.Loader.ForceLoad ();
			Firebase.Core.Loader.ForceLoad ();
			Firebase.Analytics.Loader.ForceLoad ();
			Firebase.Auth.Loader.ForceLoad ();
		}

		public static void ForceLoad () { }
	}
}

namespace ApiDefinition
{
	partial class Messaging
	{
		static Messaging ()
		{
			Firebase.CloudFirestore.Loader.ForceLoad ();
		}
	}
}
