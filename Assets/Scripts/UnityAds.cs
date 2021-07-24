using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class UnityAds : MonoBehaviour, IUnityAdsListener
{
    private string gameID = "4231067";
    private string bannerID = "banner";
    private string interstitialID = "instertitial";
    public bool TestMode;
    public Button interstitialBtn;

    void Awake()
    {
        App.unityAds = this;
    }

    void Start()
    {
        Advertisement.Initialize(gameID, TestMode);
        Advertisement.AddListener(this);
    }

    public void ShowInterstitial()
    {
        if (Advertisement.IsReady(interstitialID))
        {
            Advertisement.Show(interstitialID);
        }
    }

    public void HideBanner()
    {
        Advertisement.Banner.Hide();
    }

    public void OnUnityAdsReady(string placementID)
    {
        if (placementID == interstitialID)
        {
            //interstitialBtn.interactable = true;
        }

        if (placementID == bannerID)
        {
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
            Advertisement.Banner.Show(bannerID);
        }
    }

    public void OnUnityAdsDidFinish(string placementID, ShowResult showResult)
    {
        //if (placementID == re)
    }

    public void OnUnityAdsDidError(string message)
    {

    }

    public void OnUnityAdsDidStart(string placementID)
    {

    }
}
