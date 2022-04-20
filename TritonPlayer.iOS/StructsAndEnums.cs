using ObjCRuntime;

namespace TritonPlayerSDK
{
	[Native]
	public enum TDAdErrorCode : long
	{
		InvalidRequest = 101,
		UndefinedSize = 102,
		NoInventory = 103,
		InvalidAdURL = 104,
		ResponseParsingFailed = 105
	}

	[Native]
	public enum TDGender : long
	{
		NotDefined,
		Female,
		Male,
		Other
	}

	[Native]
	public enum TDAdType : long
	{
		Preroll,
		Midroll
	}

	[Native]
	public enum TDAssetType : long
	{
		NotDefined,
		Audio,
		Video,
		AudioVideo
	}

	[Native]
	public enum TDCuePointHistoryError : long
	{
		InvalidMountError = 3000,
		UnknownError = 3001
	}

	[Native]
	public enum PlayerContentType : long
	{
		Flv,
		Hls,
		Other
	}

	[Native]
	public enum TDPlayerError : long
	{
		MountNotFoundError = 3000,
		MountGeoblockedError = 3001,
		MountBadRequestError = 3002,
		MountNotImplemntedError = 3003,
		HostNotFoundError = 3004,
		DeviceMuted = 3005
	}

	[Native]
	public enum TDPlayerState : long
	{
		Stopped,
		Playing,
		Connecting,
		Paused,
		Error,
		Completed
	}

	[Native]
	public enum TDPlayerInfo : long
	{
		ConnectedToStream,
		Buffering,
		ForwardedToAlternateMount
	}
}
