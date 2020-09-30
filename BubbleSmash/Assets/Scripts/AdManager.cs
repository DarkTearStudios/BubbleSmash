using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using GoogleMobileAds;

public class AdManager : MonoBehaviour
{
    public static AdManager instance;
    private BannerView bannerView;

    public void Start()
    {
        


#if UNITY_ANDROID
        string appId = "Hidden";
#elif UNITY_IPHONE
         string appId = "Hidden";
#else
         string appId = "unexpected_platform";
#endif
        MobileAds.Initialize(appId);
        this.RequestBanner();

    }

    private void RequestBanner()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-1336589162908525/3799733658;";
#elif UNITY_IPHONE
         string adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
         string adUnitId = "unexpected_platform";
#endif

        if (bannerView != null)
        {
            bannerView.Destroy();
        }
        bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        bannerView.LoadAd(request);
    }
    public void Destroy(){
     bannerView.Hide();
     bannerView.Destroy();
 }
}