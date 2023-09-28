using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class AdsMob : MonoBehaviour
{
    BannerView _bannerView;
    private string _adUnitId="ca-app-pub-3100666941994405/2616257803";
    // Start is called before the first frame update
    void Start()
    {
         MobileAds.Initialize(initStatus => { });
         LoadBanner();
    }

private void CreateBannerView()
  {
      Debug.Log("Creating banner view");

      // If we already have a banner, destroy the old one.
      if (_bannerView != null)
      {

      }

      // Create a 320x50 banner at top of the screen
      _bannerView = new BannerView(_adUnitId, AdSize.Banner, AdPosition.Top);
  }

  public void LoadBanner()
{
    // create an instance of a banner view first.
    if(_bannerView == null)
    {
        CreateBannerView();
    }
    // create our request used to load the ad.
    var adRequest = new AdRequest();

    // send the request to load the ad.
    Debug.Log("Loading banner ad.");
    _bannerView.LoadAd(adRequest);
}

}
