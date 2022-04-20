using System;
using AVFoundation;
using AudioToolbox;
using CoreGraphics;
using CoreLocation;
using CoreMedia;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace TritonPlayerSDK
{
	[Static]
	partial interface Constants
	{
		// extern NSString *const EventTypeAd;
		[Field("EventTypeAd", "__Internal")]
		NSString EventTypeAd { get; }

		// extern NSString *const EventTypeAudio;
		[Field("EventTypeAudio", "__Internal")]
		NSString EventTypeAudio { get; }

		// extern NSString *const EventTypeCustom;
		[Field("EventTypeCustom", "__Internal")]
		NSString EventTypeCustom { get; }

		// extern NSString *const EventTypeProfanity;
		[Field("EventTypeProfanity", "__Internal")]
		NSString EventTypeProfanity { get; }

		// extern NSString *const EventTypeRecording;
		[Field("EventTypeRecording", "__Internal")]
		NSString EventTypeRecording { get; }

		// extern NSString *const EventTypeSidekick;
		[Field("EventTypeSidekick", "__Internal")]
		NSString EventTypeSidekick { get; }

		// extern NSString *const EventTypeSpeech;
		[Field("EventTypeSpeech", "__Internal")]
		NSString EventTypeSpeech { get; }

		// extern NSString *const EventTypeSweeper;
		[Field("EventTypeSweeper", "__Internal")]
		NSString EventTypeSweeper { get; }

		// extern NSString *const EventTypeTrack;
		[Field("EventTypeTrack", "__Internal")]
		NSString EventTypeTrack { get; }

		// extern NSString *const EventTypeUnknown;
		[Field("EventTypeUnknown", "__Internal")]
		NSString EventTypeUnknown { get; }

		// extern NSString *const CommonCueDisplayKey;
		[Field("CommonCueDisplayKey", "__Internal")]
		NSString CommonCueDisplayKey { get; }

		// extern NSString *const CommonCueTimeDurationKey;
		[Field("CommonCueTimeDurationKey", "__Internal")]
		NSString CommonCueTimeDurationKey { get; }

		// extern NSString *const CommonCueTimeStartKey;
		[Field("CommonCueTimeStartKey", "__Internal")]
		NSString CommonCueTimeStartKey { get; }

		// extern NSString *const CommonCueTitleKey;
		[Field("CommonCueTitleKey", "__Internal")]
		NSString CommonCueTitleKey { get; }

		// extern NSString *const CommonCueTypeKey;
		[Field("CommonCueTypeKey", "__Internal")]
		NSString CommonCueTypeKey { get; }

		// extern NSString *const CommonProgramTimeDurationKey;
		[Field("CommonProgramTimeDurationKey", "__Internal")]
		NSString CommonProgramTimeDurationKey { get; }

		// extern NSString *const CommonProgramTimeStartKey;
		[Field("CommonProgramTimeStartKey", "__Internal")]
		NSString CommonProgramTimeStartKey { get; }

		// extern NSString *const CommonProgramGuestNIdKey;
		[Field("CommonProgramGuestNIdKey", "__Internal")]
		NSString CommonProgramGuestNIdKey { get; }

		// extern NSString *const CommonProgramGuestNNameKey;
		[Field("CommonProgramGuestNNameKey", "__Internal")]
		NSString CommonProgramGuestNNameKey { get; }

		// extern NSString *const CommonProgramHostNIdKey;
		[Field("CommonProgramHostNIdKey", "__Internal")]
		NSString CommonProgramHostNIdKey { get; }

		// extern NSString *const CommonProgramHostNNameKey;
		[Field("CommonProgramHostNNameKey", "__Internal")]
		NSString CommonProgramHostNNameKey { get; }

		// extern NSString *const CommonProgramIdKey;
		[Field("CommonProgramIdKey", "__Internal")]
		NSString CommonProgramIdKey { get; }

		// extern NSString *const CommonProgramTitleKey;
		[Field("CommonProgramTitleKey", "__Internal")]
		NSString CommonProgramTitleKey { get; }

		// extern NSString *const CommonProgramGuestNHomepageKey;
		[Field("CommonProgramGuestNHomepageKey", "__Internal")]
		NSString CommonProgramGuestNHomepageKey { get; }

		// extern NSString *const CommonProgramGuestNPictureURLKey;
		[Field("CommonProgramGuestNPictureURLKey", "__Internal")]
		NSString CommonProgramGuestNPictureURLKey { get; }

		// extern NSString *const CommonProgramHomepageKey;
		[Field("CommonProgramHomepageKey", "__Internal")]
		NSString CommonProgramHomepageKey { get; }

		// extern NSString *const CommonProgramHostNHomepage;
		[Field("CommonProgramHostNHomepage", "__Internal")]
		NSString CommonProgramHostNHomepage { get; }

		// extern NSString *const CommonProgramHostPictureURLKey;
		[Field("CommonProgramHostPictureURLKey", "__Internal")]
		NSString CommonProgramHostPictureURLKey { get; }

		// extern NSString *const CommonProgramImageKey;
		[Field("CommonProgramImageKey", "__Internal")]
		NSString CommonProgramImageKey { get; }

		// extern NSString *const AdReplaceKey;
		[Field("AdReplaceKey", "__Internal")]
		NSString AdReplaceKey { get; }

		// extern NSString *const AdIdKey;
		[Field("AdIdKey", "__Internal")]
		NSString AdIdKey { get; }

		// extern NSString *const AdTypeKey;
		[Field("AdTypeKey", "__Internal")]
		NSString AdTypeKey { get; }

		// extern NSString *const AdVastKey;
		[Field("AdVastKey", "__Internal")]
		NSString AdVastKey { get; }

		// extern NSString *const AdVastURLKey;
		[Field("AdVastURLKey", "__Internal")]
		NSString AdVastURLKey { get; }

		// extern NSString *const AdURLKey;
		[Field("AdURLKey", "__Internal")]
		NSString AdURLKey { get; }

		// extern NSString *const AdURL1Key;
		[Field("AdURL1Key", "__Internal")]
		NSString AdURL1Key { get; }

		// extern NSString *const AdURL2Key;
		[Field("AdURL2Key", "__Internal")]
		NSString AdURL2Key { get; }

		// extern NSString *const AdURL3Key;
		[Field("AdURL3Key", "__Internal")]
		NSString AdURL3Key { get; }

		// extern NSString *const AdURL4Key;
		[Field("AdURL4Key", "__Internal")]
		NSString AdURL4Key { get; }

		// extern NSString *const SweeperIdKey;
		[Field("SweeperIdKey", "__Internal")]
		NSString SweeperIdKey { get; }

		// extern NSString *const SweeperTypeKey;
		[Field("SweeperTypeKey", "__Internal")]
		NSString SweeperTypeKey { get; }

		// extern NSString *const TrackGenreKey;
		[Field("TrackGenreKey", "__Internal")]
		NSString TrackGenreKey { get; }

		// extern NSString *const TrackAlbumNameKey;
		[Field("TrackAlbumNameKey", "__Internal")]
		NSString TrackAlbumNameKey { get; }

		// extern NSString *const TrackAlbumPublisherKey;
		[Field("TrackAlbumPublisherKey", "__Internal")]
		NSString TrackAlbumPublisherKey { get; }

		// extern NSString *const TrackAlbumYearKey;
		[Field("TrackAlbumYearKey", "__Internal")]
		NSString TrackAlbumYearKey { get; }

		// extern NSString *const TrackArtistNameKey;
		[Field("TrackArtistNameKey", "__Internal")]
		NSString TrackArtistNameKey { get; }

		// extern NSString *const TrackFormatKey;
		[Field("TrackFormatKey", "__Internal")]
		NSString TrackFormatKey { get; }

		/*MTOUCH: Error MT5214: Native linking failed, undefined symbol: _TrackIdKey.
          This symbol was referenced by the managed member TritonPlayerSDK.Constants.TrackIdKey.
          Please verify that all the necessary frameworks have been referenced and native libraries linked.
		*/
		//// extern NSString *const TrackIdKey;
		//[Field("TrackIdKey", "__Internal")]
		//NSString TrackIdKey { get; }

		// extern NSString *const TrackIsrcKey;
		[Field("TrackIsrcKey", "__Internal")]
		NSString TrackIsrcKey { get; }

		// extern NSString *const TrackCoverURLKey;
		[Field("TrackCoverURLKey", "__Internal")]
		NSString TrackCoverURLKey { get; }

		// extern NSString *const TrackNowPlayingURLKey;
		[Field("TrackNowPlayingURLKey", "__Internal")]
		NSString TrackNowPlayingURLKey { get; }

		// extern NSString *const TrackProductURLKey;
		[Field("TrackProductURLKey", "__Internal")]
		NSString TrackProductURLKey { get; }

		// extern NSString *const LegacyTypeKey;
		[Field("LegacyTypeKey", "__Internal")]
		NSString LegacyTypeKey { get; }

		// extern NSString *const LegacyAdImageURLKey;
		[Field("LegacyAdImageURLKey", "__Internal")]
		NSString LegacyAdImageURLKey { get; }

		// extern NSString *const LegacyBuyURLKey;
		[Field("LegacyBuyURLKey", "__Internal")]
		NSString LegacyBuyURLKey { get; }

		// extern NSString *const TDErrorDomain;
		[Field("TDErrorDomain", "__Internal")]
		NSString TDErrorDomain { get; }

		// extern NSString *const TDCuePointHistoryErrorDomain;
		[Field("TDCuePointHistoryErrorDomain", "__Internal")]
		NSString TDCuePointHistoryErrorDomain { get; }

		// extern NSString *const SettingsSBMURLKey;
		[Field("SettingsSBMURLKey", "__Internal")]
		NSString SettingsSBMURLKey { get; }

		// extern NSString *const TritonSDKVersion;
		[Field("TritonSDKVersion", "__Internal")]
		NSString TritonSDKVersion { get; }

		// extern NSString *const SettingsEnableLocationTrackingKey;
		[Field("SettingsEnableLocationTrackingKey", "__Internal")]
		NSString SettingsEnableLocationTrackingKey { get; }

		// extern NSString *const SettingsStationNameKey;
		[Field("SettingsStationNameKey", "__Internal")]
		NSString SettingsStationNameKey { get; }

		// extern NSString *const SettingsMountKey;
		[Field("SettingsMountKey", "__Internal")]
		NSString SettingsMountKey { get; }

		// extern NSString *const SettingsContentURLKey;
		[Field("SettingsContentURLKey", "__Internal")]
		NSString SettingsContentURLKey { get; }

		// extern NSString *const SettingsContentTypeKey;
		[Field("SettingsContentTypeKey", "__Internal")]
		NSString SettingsContentTypeKey { get; }

		// extern NSString *const SettingsAppNameKey;
		[Field("SettingsAppNameKey", "__Internal")]
		NSString SettingsAppNameKey { get; }

		// extern NSString *const SettingsBroadcasterKey;
		[Field("SettingsBroadcasterKey", "__Internal")]
		NSString SettingsBroadcasterKey { get; }

		// extern NSString *const SettingsStreamParamsExtraKey;
		[Field("SettingsStreamParamsExtraKey", "__Internal")]
		NSString SettingsStreamParamsExtraKey { get; }

		// extern NSString *const SettingsTtagKey;
		[Field("SettingsTtagKey", "__Internal")]
		NSString SettingsTtagKey { get; }

		// extern NSString *const SettingsLowDelayKey;
		[Field("SettingsLowDelayKey", "__Internal")]
		NSString SettingsLowDelayKey { get; }

		// extern NSString *const SettingsPlayerServicesRegion;
		[Field("SettingsPlayerServicesRegion", "__Internal")]
		NSString SettingsPlayerServicesRegion { get; }

		// extern NSString *const SettingsBitrateKey;
		[Field("SettingsBitrateKey", "__Internal")]
		NSString SettingsBitrateKey { get; }

		// extern NSString *const SettingsDistributionParameterKey;
		[Field("SettingsDistributionParameterKey", "__Internal")]
		NSString SettingsDistributionParameterKey { get; }

		// extern NSString *const StreamParamExtraLatitudeKey;
		[Field("StreamParamExtraLatitudeKey", "__Internal")]
		NSString StreamParamExtraLatitudeKey { get; }

		// extern NSString *const StreamParamExtraLongitudeKey;
		[Field("StreamParamExtraLongitudeKey", "__Internal")]
		NSString StreamParamExtraLongitudeKey { get; }

		// extern NSString *const StreamParamExtraPostalCodeKey;
		[Field("StreamParamExtraPostalCodeKey", "__Internal")]
		NSString StreamParamExtraPostalCodeKey { get; }

		// extern NSString *const StreamParamExtraCountryKey;
		[Field("StreamParamExtraCountryKey", "__Internal")]
		NSString StreamParamExtraCountryKey { get; }

		// extern NSString *const StreamParamExtraAgeKey;
		[Field("StreamParamExtraAgeKey", "__Internal")]
		NSString StreamParamExtraAgeKey { get; }

		// extern NSString *const StreamParamExtraDateOfBirthKey;
		[Field("StreamParamExtraDateOfBirthKey", "__Internal")]
		NSString StreamParamExtraDateOfBirthKey { get; }

		// extern NSString *const StreamParamExtraYearOfBirthKey;
		[Field("StreamParamExtraYearOfBirthKey", "__Internal")]
		NSString StreamParamExtraYearOfBirthKey { get; }

		// extern NSString *const StreamParamExtraGenderKey;
		[Field("StreamParamExtraGenderKey", "__Internal")]
		NSString StreamParamExtraGenderKey { get; }

		// extern NSString *const SettingsDebouncingKey;
		[Field("SettingsDebouncingKey", "__Internal")]
		NSString SettingsDebouncingKey { get; }

		// extern NSString *const StreamParamExtraCustomSegmentIdKey;
		[Field("StreamParamExtraCustomSegmentIdKey", "__Internal")]
		NSString StreamParamExtraCustomSegmentIdKey { get; }

		// extern NSString *const StreamParamExtraBannersKey;
		[Field("StreamParamExtraBannersKey", "__Internal")]
		NSString StreamParamExtraBannersKey { get; }

		// extern NSString *const StreamParamExtraAuthorizationTokenKey;
		[Field("StreamParamExtraAuthorizationTokenKey", "__Internal")]
		NSString StreamParamExtraAuthorizationTokenKey { get; }

		// extern NSString *const StreamParamExtraAuthorizationUserId;
		[Field("StreamParamExtraAuthorizationUserId", "__Internal")]
		NSString StreamParamExtraAuthorizationUserId { get; }

		// extern NSString *const StreamParamExtraAuthorizationRegisteredUser;
		[Field("StreamParamExtraAuthorizationRegisteredUser", "__Internal")]
		NSString StreamParamExtraAuthorizationRegisteredUser { get; }

		// extern NSString *const StreamParamExtraAuthorizationKeyId;
		[Field("StreamParamExtraAuthorizationKeyId", "__Internal")]
		NSString StreamParamExtraAuthorizationKeyId { get; }

		// extern NSString *const StreamParamExtraAuthorizationSecretKey;
		[Field("StreamParamExtraAuthorizationSecretKey", "__Internal")]
		NSString StreamParamExtraAuthorizationSecretKey { get; }

		// extern NSString *const SettingsTimeshiftEnabledKey;
		[Field("SettingsTimeshiftEnabledKey", "__Internal")]
		NSString SettingsTimeshiftEnabledKey { get; }

		// extern NSString *const TritonPlayerDomain;
		[Field("TritonPlayerDomain", "__Internal")]
		NSString TritonPlayerDomain { get; }

		// extern NSString *const InfoBufferingPercentageKey;
		[Field("InfoBufferingPercentageKey", "__Internal")]
		NSString InfoBufferingPercentageKey { get; }

		// extern NSString *const InfoAlternateMountNameKey;
		[Field("InfoAlternateMountNameKey", "__Internal")]
		NSString InfoAlternateMountNameKey { get; }

		// extern double TritonPlayerSDKVersionNumber;
		[Field("TritonPlayerSDKVersionNumber", "__Internal")]
		double TritonPlayerSDKVersionNumber { get; }

		// extern const unsigned char [] TritonPlayerSDKVersionString;
		[Field("TritonPlayerSDKVersionString", "__Internal")]
		NSString TritonPlayerSDKVersionString { get; }
	}

	// @interface CuePointEvent : NSObject
	[BaseType(typeof(NSObject))]
	interface CuePointEvent
	{
		// @property (readonly, nonatomic) NSTimeInterval timestamp;
		[Export("timestamp")]
		double Timestamp { get; }

		// @property (readonly, strong) NSDictionary * data;
		[Export("data", ArgumentSemantic.Strong)]
		NSDictionary Data { get; }

		// @property (readonly, strong) NSString * type;
		[Export("type", ArgumentSemantic.Strong)]
		string Type { get; }

		// @property (readonly, assign) BOOL executionCanceled;
		[Export("executionCanceled")]
		bool ExecutionCanceled { get; }

		// -(instancetype)initEventWithAMFObjectData:(NSDictionary *)inAMFData andTimestamp:(NSTimeInterval)inTimestamp;
		[Export("initEventWithAMFObjectData:andTimestamp:")]
		IntPtr InitEventWithAMFObjectData(NSDictionary inAMFData, double inTimestamp);

		// -(instancetype)initWithData:(NSDictionary *)data andTimestamp:(NSTimeInterval)timestamp;
		[Export("initWithData:andTimestamp:")]
		IntPtr InitWithData(NSDictionary data, double timestamp);
	}

	// @interface TDAd : NSObject
	[BaseType(typeof(NSObject))]
	interface TDAd
	{
		// @property (nonatomic, strong) NSArray * mediaImpressionURLs;
		[Export("mediaImpressionURLs", ArgumentSemantic.Strong)]
		NSArray[] MediaImpressionURLs { get; set; }

		// @property (nonatomic, strong) NSString * mediaMIMEType;
		[Export("mediaMIMEType", ArgumentSemantic.Strong)]
		string MediaMIMEType { get; set; }

		// @property (nonatomic, strong) NSString * format;
		[Export("format", ArgumentSemantic.Strong)]
		string Format { get; set; }

		// @property (nonatomic, strong) NSURL * mediaURL;
		[Export("mediaURL", ArgumentSemantic.Strong)]
		NSUrl MediaURL { get; set; }

		// @property (nonatomic, strong) NSArray * companionBanners;
		[Export("companionBanners", ArgumentSemantic.Strong)]
		NSArray[] CompanionBanners { get; set; }

		// @property (assign, nonatomic) NSInteger videoWidth;
		[Export("videoWidth")]
		nint VideoWidth { get; set; }

		// @property (assign, nonatomic) NSInteger videoHeight;
		[Export("videoHeight")]
		nint VideoHeight { get; set; }

		// @property (nonatomic, strong) NSURL * videoClickThroughURL;
		[Export("videoClickThroughURL", ArgumentSemantic.Strong)]
		NSUrl VideoClickThroughURL { get; set; }

		// @property (nonatomic, strong) NSArray * clickTrackingURLs;
		[Export("clickTrackingURLs", ArgumentSemantic.Strong)]
		NSArray[] ClickTrackingURLs { get; set; }

		// @property (nonatomic, strong) NSURL * vastAdTagUri;
		[Export("vastAdTagUri", ArgumentSemantic.Strong)]
		NSUrl VastAdTagUri { get; set; }

		// @property (nonatomic, strong) NSURL * errorUrl;
		[Export("errorUrl", ArgumentSemantic.Strong)]
		NSUrl ErrorUrl { get; set; }

		// -(TDCompanionBanner *)bestCompanionBannerForWidth:(NSInteger)width andHeight:(NSInteger)height;
		[Export("bestCompanionBannerForWidth:andHeight:")]
		TDCompanionBanner BestCompanionBannerForWidth(nint width, nint height);

		// -(void)trackMediaImpressions;
		[Export("trackMediaImpressions")]
		void TrackMediaImpressions();

		// -(void)trackVideoClick;
		[Export("trackVideoClick")]
		void TrackVideoClick();
	}

	// @interface TDAdLoader : NSObject
	[BaseType(typeof(NSObject))]
	interface TDAdLoader
	{
		// -(void)loadAdWithStringRequest:(NSString *)request completionHandler:(void (^)(TDAd *, NSError *))completionHandler;
		[Export("loadAdWithStringRequest:completionHandler:")]
		void LoadAdWithStringRequest(string request, Action<TDAd, NSError> completionHandler);

		// -(void)loadAdWithBuilder:(TDAdRequestURLBuilder *)builder completionHandler:(void (^)(TDAd *, NSError *))completionHandler;
		[Export("loadAdWithBuilder:completionHandler:")]
		void LoadAdWithBuilder(TDAdRequestURLBuilder builder, Action<TDAd, NSError> completionHandler);
	}

	// @interface TDAdRequestURLBuilder : NSObject
	[BaseType(typeof(NSObject))]
	interface TDAdRequestURLBuilder
	{
		// +(instancetype)builderWithHostURL:(NSString *)url;
		[Export("builderWithHostURL:")]
		IntPtr BuilderWithHostURL(string url);

		// -(instancetype)initWithHostURL:(NSString *)url;
		[Export("initWithHostURL:")]
		IntPtr InitWithHostURL(string url);

		// @property (assign, nonatomic) TDAdType adType;
		[Export("adType", ArgumentSemantic.Assign)]
		TDAdType AdType { get; set; }

		// @property (assign, nonatomic) NSInteger stationId;
		[Export("stationId")]
		nint StationId { get; set; }

		// @property (copy, nonatomic) NSString * stationName;
		[Export("stationName")]
		string StationName { get; set; }

		// @property (copy, nonatomic) NSString * postalCode;
		[Export("postalCode")]
		string PostalCode { get; set; }

		// @property (copy, nonatomic) NSString * country;
		[Export("country")]
		string Country { get; set; }

		// -(void)setLocationWithLatitude:(float)latitude andLongitude:(float)longitude;
		[Export("setLocationWithLatitude:andLongitude:")]
		void SetLocationWithLatitude(float latitude, float longitude);

		// @property (assign, nonatomic) float latitude;
		[Export("latitude")]
		float Latitude { get; set; }

		// @property (assign, nonatomic) float longitude;
		[Export("longitude")]
		float Longitude { get; set; }

		// @property (getter = isAutoLocationTrackingEnabled, nonatomic) BOOL autoLocationTrackingEnabled;
		[Export("autoLocationTrackingEnabled")]
		bool AutoLocationTrackingEnabled { [Bind("isAutoLocationTrackingEnabled")] get; set; }

		// @property (assign, nonatomic) NSInteger age;
		[Export("age")]
		nint Age { get; set; }

		// @property (copy, nonatomic) NSDate * dateOfBirth;
		[Export("dateOfBirth", ArgumentSemantic.Copy)]
		NSDate DateOfBirth { get; set; }

		// -(void)setDateOfBirthFromString:(NSString *)dateOfBirth;
		[Export("setDateOfBirthFromString:")]
		void SetDateOfBirthFromString(string dateOfBirth);

		// @property (assign, nonatomic) NSInteger yearOfBirth;
		[Export("yearOfBirth")]
		nint YearOfBirth { get; set; }

		// @property (assign, nonatomic) TDGender gender;
		[Export("gender", ArgumentSemantic.Assign)]
		TDGender Gender { get; set; }

		// @property (assign, nonatomic) NSString * bundleId;
		[Export("bundleId")]
		string BundleId { get; set; }

		// @property (assign, nonatomic) NSString * storeId;
		[Export("storeId")]
		string StoreId { get; set; }

		// @property (assign, nonatomic) NSString * storeUrl;
		[Export("storeUrl")]
		string StoreUrl { get; set; }

		// @property (copy, nonatomic) NSString * banners;
		[Export("banners")]
		string Banners { get; set; }

		// @property (assign, nonatomic) NSInteger customSegmentId;
		[Export("customSegmentId")]
		nint CustomSegmentId { get; set; }

		// @property (assign, nonatomic) TDAssetType assetType;
		[Export("assetType", ArgumentSemantic.Assign)]
		TDAssetType AssetType { get; set; }

		// @property (copy, nonatomic) NSDictionary * extraParameters;
		[Export("extraParameters", ArgumentSemantic.Copy)]
		NSDictionary ExtraParameters { get; set; }

		// @property (copy, nonatomic) NSArray * TTags;
		[Export("TTags", ArgumentSemantic.Copy)]
		NSArray[] TTags { get; set; }

		// -(NSString *)generateAdRequestURL;
		[Export("generateAdRequestURL")]
		string GenerateAdRequestURL { get; }

		// -(void)reset;
		[Export("reset")]
		void Reset();
	}

	// @interface TDAnalyticsTracker : NSObject
	[BaseType(typeof(NSObject))]
	interface TDAnalyticsTracker
	{
		// +(instancetype)sharedTracker;
		[Export("sharedTracker")]
		IntPtr SharedTracker();

		// +(instancetype)sharedTracker:(BOOL)isTritonApp;
		[Export("sharedTracker:")]
		IntPtr SharedTracker(bool isTritonApp);

		// -(void)initialize;
		[Export("initialize")]
		void Initialize();

		// -(void)addType:(NSString *)type;
		[Export("addType:")]
		void AddType(string type);

		// -(NSTimeInterval)stopTimer;
		[Export("stopTimer")]
		double StopTimer { get; }

		// -(void)startTimer;
		[Export("startTimer")]
		void StartTimer();

		// -(void)trackStreamingConnectionSuccessWithMount:(NSString *)mount withBroadcaster:(NSString *)broadcaster withLoadTime:(NSTimeInterval)loadTime;
		[Export("trackStreamingConnectionSuccessWithMount:withBroadcaster:withLoadTime:")]
		void TrackStreamingConnectionSuccessWithMount(string mount, string broadcaster, double loadTime);

		// -(void)trackStreamingConnectionUnavailableWithMount:(NSString *)mount withBroadcaster:(NSString *)broadcaster withLoadTime:(NSTimeInterval)loadTime;
		[Export("trackStreamingConnectionUnavailableWithMount:withBroadcaster:withLoadTime:")]
		void TrackStreamingConnectionUnavailableWithMount(string mount, string broadcaster, double loadTime);

		// -(void)trackStreamingConnectionErrorWithMount:(NSString *)mount withBroadcaster:(NSString *)broadcaster withLoadTime:(NSTimeInterval)loadTime;
		[Export("trackStreamingConnectionErrorWithMount:withBroadcaster:withLoadTime:")]
		void TrackStreamingConnectionErrorWithMount(string mount, string broadcaster, double loadTime);

		// -(void)trackStreamingConnectionGeoblockedWithMount:(NSString *)mount withBroadcaster:(NSString *)broadcaster withLoadTime:(NSTimeInterval)loadTime;
		[Export("trackStreamingConnectionGeoblockedWithMount:withBroadcaster:withLoadTime:")]
		void TrackStreamingConnectionGeoblockedWithMount(string mount, string broadcaster, double loadTime);

		// -(void)trackStreamingConnectionFailedWithMount:(NSString *)mount withBroadcaster:(NSString *)broadcaster withLoadTime:(NSTimeInterval)loadTime;
		[Export("trackStreamingConnectionFailedWithMount:withBroadcaster:withLoadTime:")]
		void TrackStreamingConnectionFailedWithMount(string mount, string broadcaster, double loadTime);

		// -(void)trackAdPrerollSuccessWithFormat:(NSString *)adFormat isVideo:(BOOL)isvideo withLoadTime:(NSTimeInterval)loadTime;
		[Export("trackAdPrerollSuccessWithFormat:isVideo:withLoadTime:")]
		void TrackAdPrerollSuccessWithFormat(string adFormat, bool isvideo, double loadTime);

		// -(void)trackAdPrerollErrorWithFormat:(NSString *)adFormat isVideo:(BOOL)isvideo withLoadTime:(NSTimeInterval)loadTime;
		[Export("trackAdPrerollErrorWithFormat:isVideo:withLoadTime:")]
		void TrackAdPrerollErrorWithFormat(string adFormat, bool isvideo, double loadTime);

		// -(void)trackOnDemandSuccess;
		[Export("trackOnDemandSuccess")]
		void TrackOnDemandSuccess();

		// -(void)trackOnDemandError;
		[Export("trackOnDemandError")]
		void TrackOnDemandError();
	}

	// @interface TDAuthUtils : NSObject
	[BaseType(typeof(NSObject))]
	interface TDAuthUtils
	{
		// +(NSString *)createJWTTokenWithSecretKey:(NSString *)secretKey andSecretKeyId:(NSString *)secretKeyId andRegisteredUser:(BOOL)registeredUser andUserId:(NSString *)userId andTargetingParameters:(NSDictionary *)targetingParameters;
		[Static]
		[Export("createJWTTokenWithSecretKey:andSecretKeyId:andRegisteredUser:andUserId:andTargetingParameters:")]
		string CreateJWTTokenWithSecretKey(string secretKey, string secretKeyId, bool registeredUser, string userId, NSDictionary targetingParameters);
	}

	// @protocol TDBannerViewDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface TDBannerViewDelegate
	{
		// @optional -(void)bannerViewDidPresentAd:(TDBannerView *)bannerView;
		[Export("bannerViewDidPresentAd:")]
		void BannerViewDidPresentAd(TDBannerView bannerView);

		// @optional -(void)bannerView:(TDBannerView *)bannerView didFailToPresentAdWithError:(NSError *)error;
		[Export("bannerView:didFailToPresentAdWithError:")]
		void BannerView(TDBannerView bannerView, NSError error);

		// @optional -(void)bannerViewWillLeaveApplication:(TDBannerView *)bannerView;
		[Export("bannerViewWillLeaveApplication:")]
		void BannerViewWillLeaveApplication(TDBannerView bannerView);
	}

	// @interface TDBannerView : UIView
	[BaseType(typeof(UIView))]
	interface TDBannerView
	{
		[Wrap("WeakDelegate")]
		TDBannerViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<TDBannerViewDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype)initWithWidth:(NSInteger)width andHeight:(NSInteger)height;
		[Export("initWithWidth:andHeight:")]
		IntPtr Constructor(nint width, nint height);

		// -(instancetype)initWithWidth:(NSInteger)width andHeight:(NSInteger)height andFallbackWidth:(NSInteger)fallbackWidth andFallbackHeight:(NSInteger)fallbackHeight;
		[Export("initWithWidth:andHeight:andFallbackWidth:andFallbackHeight:")]
		IntPtr Constructor(nint width, nint height, nint fallbackWidth, nint fallbackHeight);

		// -(instancetype)initWithWidth:(NSInteger)width andHeight:(NSInteger)height andFallbackWidth:(NSInteger)fallbackWidth andFallbackHeight:(NSInteger)fallbackHeight andOrigin:(CGPoint)origin;
		[Export("initWithWidth:andHeight:andFallbackWidth:andFallbackHeight:andOrigin:")]
		IntPtr Constructor(nint width, nint height, nint fallbackWidth, nint fallbackHeight, CGPoint origin);

		// @property (readonly, assign) NSInteger width;
		[Export("width")]
		nint Width { get; }

		// @property (readonly, assign) NSInteger height;
		[Export("height")]
		nint Height { get; }

		// @property (readonly, assign) NSInteger fallbackWidth;
		[Export("fallbackWidth")]
		nint FallbackWidth { get; }

		// @property (readonly, assign) NSInteger fallbackHeight;
		[Export("fallbackHeight")]
		nint FallbackHeight { get; }

		// -(void)setWidth:(NSInteger)width andHeight:(NSInteger)height;
		[Export("setWidth:andHeight:")]
		void SetWidth(nint width, nint height);

		// -(void)setFallbackWidth:(NSInteger)fallbackWidth andHeight:(NSInteger)fallbackHeight;
		[Export("setFallbackWidth:andHeight:")]
		void SetFallbackWidth(nint fallbackWidth, nint fallbackHeight);

		// -(void)setOrigin:(CGPoint)origin;
		[Export("setOrigin:")]
		void SetOrigin(CGPoint origin);

		// -(void)presentAd:(TDAd *)ad;
		[Export("presentAd:")]
		void PresentAd(TDAd ad);

		// -(void)clear;
		[Export("clear")]
		void Clear();
	}

	// @interface TDCompanionBanner : NSObject
	[BaseType(typeof(NSObject))]
	interface TDCompanionBanner
	{
		// @property (assign, nonatomic) NSInteger width;
		[Export("width")]
		nint Width { get; set; }

		// @property (assign, nonatomic) NSInteger height;
		[Export("height")]
		nint Height { get; set; }

		// @property (nonatomic, strong) NSURL * contentURL;
		[Export("contentURL", ArgumentSemantic.Strong)]
		NSUrl ContentURL { get; set; }

		// @property (nonatomic, strong) NSString * contentHTML;
		[Export("contentHTML", ArgumentSemantic.Strong)]
		string ContentHTML { get; set; }
	}

	// @interface TDCuePointHistory : NSObject
	[BaseType(typeof(NSObject))]
	interface TDCuePointHistory
	{
		// -(void)requestHistoryForMount:(NSString *)mountName withMaximumItems:(NSInteger)maximum eventTypeFilter:(NSArray *)filter completionHandler:(void (^)(NSArray *, NSError *))completionHandler;
		[Export("requestHistoryForMount:withMaximumItems:eventTypeFilter:completionHandler:")]
		void RequestHistoryForMount(string mountName, nint maximum, NSArray[] filter, Action<NSArray, NSError> completionHandler);
	}

	// @protocol TDInterstitialDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface TDInterstitialDelegate
	{
		// @optional -(void)interstitialDidLoadAd:(TDInterstitialAd *)ad;
		[Export("interstitialDidLoadAd:")]
		void InterstitialDidLoadAd(TDInterstitialAd ad);

		// @optional -(void)interstitial:(TDInterstitialAd *)ad didFailToLoadAdWithError:(NSError *)error;
		[Export("interstitial:didFailToLoadAdWithError:")]
		void Interstitial(TDInterstitialAd ad, NSError error);

		// @optional -(void)interstitialWillPresent:(TDInterstitialAd *)ad;
		[Export("interstitialWillPresent:")]
		void InterstitialWillPresent(TDInterstitialAd ad);

		// @optional -(void)interstitialWillDismiss:(TDInterstitialAd *)ad;
		[Export("interstitialWillDismiss:")]
		void InterstitialWillDismiss(TDInterstitialAd ad);

		// @optional -(void)interstitialDidDismiss:(TDInterstitialAd *)ad;
		[Export("interstitialDidDismiss:")]
		void InterstitialDidDismiss(TDInterstitialAd ad);

		// @optional -(void)interstitialPlaybackFinished:(TDInterstitialAd *)ad;
		[Export("interstitialPlaybackFinished:")]
		void InterstitialPlaybackFinished(TDInterstitialAd ad);

		// @optional -(void)interstitialWillLeaveApplication:(TDInterstitialAd *)ad;
		[Export("interstitialWillLeaveApplication:")]
		void InterstitialWillLeaveApplication(TDInterstitialAd ad);
	}

	// @interface TDInterstitialAd : NSObject
	[BaseType(typeof(NSObject))]
	interface TDInterstitialAd
	{
		[Wrap("WeakDelegate")]
		TDInterstitialDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<TDInterstitialDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic) BOOL loaded;
		[Export("loaded")]
		bool Loaded { get; }

		// -(void)loadAd:(TDAd *)ad;
		[Export("loadAd:")]
		void LoadAd(TDAd ad);

		// -(void)loadRequestBuilder:(TDAdRequestURLBuilder *)requestBuilder;
		[Export("loadRequestBuilder:")]
		void LoadRequestBuilder(TDAdRequestURLBuilder requestBuilder);

		// -(void)loadStringRequest:(NSString *)stringRequest;
		[Export("loadStringRequest:")]
		void LoadStringRequest(string stringRequest);

		// -(void)presentFromViewController:(UIViewController *)rootViewController;
		[Export("presentFromViewController:")]
		void PresentFromViewController(UIViewController rootViewController);
	}

	// @protocol TDSBMPlayerPlayerDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface TDSBMPlayerPlayerDelegate
	{
		// @required -(void)sbmPlayer:(TDSBMPlayer *)player didReceiveCuePointEvent:(CuePointEvent *)cuePointEvent;
		[Abstract]
		[Export("sbmPlayer:didReceiveCuePointEvent:")]
		void SbmPlayer(TDSBMPlayer player, CuePointEvent cuePointEvent);

		// @required -(void)sbmPlayer:(TDSBMPlayer *)player didFailConnectingWithError:(NSError *)error;
		[Abstract]
		[Export("sbmPlayer:didFailConnectingWithError:")]
		void SbmPlayer(TDSBMPlayer player, NSError error);

		// @optional -(void)sbmPlayerDidOpenConnection:(TDSBMPlayer *)player;
		[Export("sbmPlayerDidOpenConnection:")]
		void SbmPlayerDidOpenConnection(TDSBMPlayer player);
	}

	// @interface TDSBMPlayer : NSObject
	[BaseType(typeof(NSObject))]
	interface TDSBMPlayer
	{
		[Wrap("WeakDelegate")]
		TDSBMPlayerPlayerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<TDSBMPlayerPlayerDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, assign) NSTimeInterval currentPlaybackTime;
		[Export("currentPlaybackTime")]
		double CurrentPlaybackTime { get; }

		// @property (readonly, assign) CMTime latestPlaybackTime;
		[Export("latestPlaybackTime", ArgumentSemantic.Assign)]
		CMTime LatestPlaybackTime { get; }

		// @property (assign, nonatomic) NSTimeInterval synchronizationOffset;
		[Export("synchronizationOffset")]
		double SynchronizationOffset { get; set; }

		// @property (assign, nonatomic) BOOL autoSynchronizeCuePoints;
		[Export("autoSynchronizeCuePoints")]
		bool AutoSynchronizeCuePoints { get; set; }

		// +(NSString *)generateSBMSessionId;
		[Static]
		[Export("generateSBMSessionId")]
		string GenerateSBMSessionId { get; }

		// -(instancetype)initWithSettings:(NSDictionary *)settings;
		[Export("initWithSettings:")]
		IntPtr Constructor(NSDictionary settings);

		// -(void)updateSettings:(NSDictionary *)settings;
		[Export("updateSettings:")]
		void UpdateSettings(NSDictionary settings);

		// -(void)play;
		[Export("play")]
		void Play();

		// -(void)stop;
		[Export("stop")]
		void Stop();

		// -(void)close;
		[Export("close")]
		void Close();
	}

	// @interface TDSyncBannerView : TDBannerView
	[BaseType(typeof(TDBannerView))]
	interface TDSyncBannerView
	{
		// -(void)loadCuePoint:(CuePointEvent *)cuePoint;
		[Export("loadCuePoint:")]
		void LoadCuePoint(CuePointEvent cuePoint);
	}

	// @protocol TritonPlayerDelegate <NSObject>
	[Protocol, Model(AutoGeneratedName = true)]
	[BaseType(typeof(NSObject))]
	interface TritonPlayerDelegate
	{
		// @required -(void)player:(TritonPlayer *)player didChangeState:(TDPlayerState)state;
		[Abstract]
		[Export("player:didChangeState:")]
		void PlayerDidChangeState(TritonPlayer player, TDPlayerState state);

		// @optional -(void)player:(TritonPlayer *)player didReceiveInfo:(TDPlayerInfo)info andExtra:(NSDictionary *)extra;
		[Export("player:didReceiveInfo:andExtra:")]
		void PlayerDidReceiveInfo(TritonPlayer player, TDPlayerInfo info, NSDictionary extra);

		// @optional -(void)player:(TritonPlayer *)player didReceiveCuePointEvent:(CuePointEvent *)cuePointEvent;
		[Export("player:didReceiveCuePointEvent:")]
		void PlayerDidReceiveCuePointEvent(TritonPlayer player, CuePointEvent cuePointEvent);

		// @optional -(void)player:(TritonPlayer *)player didReceiveAnalyticsEvent:(AVPlayerItemAccessLogEvent *)analyticsEvent;
		[Export("player:didReceiveAnalyticsEvent:")]
		void PlayerDidReceiveAnalyticsEvent(TritonPlayer player, AVPlayerItemAccessLogEvent analyticsEvent);

		// @optional -(void)playerBeginInterruption:(TritonPlayer *)player;
		[Export("playerBeginInterruption:")]
		void PlayerBeginInterruption(TritonPlayer player);

		// @optional -(void)playerEndInterruption:(TritonPlayer *)player;
		[Export("playerEndInterruption:")]
		void PlayerEndInterruption(TritonPlayer player);

		// @optional -(void)player:(TritonPlayer *)player didReceiveMetaData:(NSDictionary *)metaData;
		[Export("player:didReceiveMetaData:")]
		void PlayerDidReceiveMetaData(TritonPlayer player, NSDictionary metaData);
	}

	// @interface TritonPlayer : NSObject
	[BaseType(typeof(NSObject))]
	interface TritonPlayer
	{
		// @property (readonly) TDPlayerState state;
		[Export("state")]
		TDPlayerState State { get; }

		// @property (readonly) NSTimeInterval playbackDuration;
		[Export("playbackDuration")]
		double PlaybackDuration { get; }

		// @property (readonly) NSTimeInterval currentPlaybackTime;
		[Export("currentPlaybackTime")]
		double CurrentPlaybackTime { get; }

		// @property (readonly) CMTime latestPlaybackTime;
		[Export("latestPlaybackTime")]
		CMTime LatestPlaybackTime { get; }

		// @property (readonly) BOOL isExecuting;
		[Export("isExecuting")]
		bool IsExecuting { get; }

		// @property (readonly) NSError * error;
		[Export("error")]
		NSError Error { get; }

		////Can't Find the header file *******************
		//// -(AudioQueueRef)getAudioQueue;
		//[Export("getAudioQueue")]
		//[Verify(MethodToProperty)]
		//unsafe AudioQueueRef* AudioQueue { get; }

		// -(NSString *)getLibVersion;
		[Export("getLibVersion")]
		string LibVersion { get; }

		// -(BOOL)isNetworkReachable;
		[Export("isNetworkReachable")]
		bool IsNetworkReachable { get; }

		// @property (readonly) CLLocation * targetingLocation;
		[Export("targetingLocation")]
		CLLocation TargetingLocation { get; }

		// @property (readonly) BOOL shouldResumePlaybackAfterInterruption;
		[Export("shouldResumePlaybackAfterInterruption")]
		bool ShouldResumePlaybackAfterInterruption { get; }

		// -(id)initWithDelegate:(id<TritonPlayerDelegate>)inDelegate andSettings:(NSDictionary *)settings;
		[Export("initWithDelegate:andSettings:")]
		IntPtr Constructor(TritonPlayerDelegate inDelegate, NSDictionary settings);

		// -(void)updateSettings:(NSDictionary *)settings;
		[Export("updateSettings:")]
		void UpdateSettings(NSDictionary settings);

		// -(void)play;
		[Export("play")]
		void Play();

		// -(void)stop;
		[Export("stop")]
		void Stop();

		// -(void)pause;
		[Export("pause")]
		void Pause();

		// -(void)seekToTimeInterval:(NSTimeInterval)interval;
		[Export("seekToTimeInterval:")]
		void SeekToTimeInterval(double interval);

		// -(void)seekToTime:(CMTime)time completionHandler:(void (^)(BOOL))completionHandler;
		[Export("seekToTime:completionHandler:")]
		void SeekToTime(CMTime time, Action<bool> completionHandler);

		// -(void)mute;
		[Export("mute")]
		void Mute();

		// -(void)unmute;
		[Export("unmute")]
		void Unmute();

		// -(void)setVolume:(float)volume;
		[Export("setVolume:")]
		void SetVolume(float volume);

		// -(void)setAllowsExternalPlayback:(BOOL)allow;
		[Export("setAllowsExternalPlayback:")]
		void SetAllowsExternalPlayback(bool allow);

		// -(NSString *)getCastStreamingUrl;
		[Export("getCastStreamingUrl")]
		string CastStreamingUrl { get; }

		// -(NSString *)getSideBandMetadataUrl;
		[Export("getSideBandMetadataUrl")]
		string SideBandMetadataUrl { get; }

		// +(NSString *)toStringState:(TDPlayerState)state;
		[Static]
		[Export("toStringState:")]
		string ToStringState(TDPlayerState state);
	}
}
