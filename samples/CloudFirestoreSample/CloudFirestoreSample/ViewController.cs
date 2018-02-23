using System;

using UIKit;
using System.Threading.Tasks;

using Firebase.Auth;
using Firebase.CloudFirestore;

namespace CloudFirestoreSample {
	public partial class ViewController : UIViewController {
		protected ViewController (IntPtr handle) : base (handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void BtnTest_TouchUpInside (Foundation.NSObject sender)
		{
			Task.Factory.StartNew (async () => await TestFirestore ());
		}

		async Task TestFirestore ()
		{
			var user = await Auth.DefaultInstance.SignInAnonymouslyAsync ();
			var dataReference = Firestore.SharedInstance.GetDocument ($"notes_app/{user.Uid}");
			var snapshot = await dataReference.GetDocumentAsync ();

			Console.WriteLine (snapshot.Exists);
		}
	}
}
