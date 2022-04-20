using CoreGraphics;
using Foundation;
using System;
using TritonPlayerSDK;
using UIKit;

namespace TritoniOSSample
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            
            var keys = new object[]
            {
                Constants.SettingsStationNameKey,
                Constants.SettingsBroadcasterKey,
                Constants.SettingsMountKey
            };
            var values = new object[]
            {
                "MOBILEFM",
                "Triton Digital",
                "MOBILEFM_AACV2"
            };

            NSDictionary setting = NSDictionary.FromObjectsAndKeys(values, keys);

            TritonPlayer player = new TritonPlayer(new TritonDelegate(), setting);
            
            var startButton = UIButton.FromType(UIButtonType.System);
            startButton.Frame = new CGRect(20, 200, 280, 44);
            startButton.SetTitle("Start", UIControlState.Normal);
            startButton.TouchUpInside += (sender, e) => {
                player.Play();
            };

            View.AddSubview(startButton);

            var pauseButton = UIButton.FromType(UIButtonType.System);
            pauseButton.Frame = new CGRect(20, 250, 280, 44);
            pauseButton.SetTitle("Pause", UIControlState.Normal);
            pauseButton.TouchUpInside += (sender, e) => {
                player.Pause();
            };

            View.AddSubview(pauseButton);

            var stopButton = UIButton.FromType(UIButtonType.System);
            stopButton.Frame = new CGRect(20, 300, 280, 44);
            stopButton.SetTitle("Stop", UIControlState.Normal);
            stopButton.TouchUpInside += (sender, e) => {
                player.Stop();
            };

            View.AddSubview(stopButton);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }

    public class TritonDelegate : TritonPlayerDelegate
    {
        public override void PlayerDidChangeState(TritonPlayer player, TDPlayerState state)
        {
            
        }
    }
}
