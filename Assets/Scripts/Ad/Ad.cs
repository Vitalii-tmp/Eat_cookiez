﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GoogleMobileAds.Api;
using System;
using UnityEngine.UI;
using Assets.FUGAS.Ads.Scripts;

public class Ad : MonoBehaviour
{
   
    private void Start()
    {
        if (lineCheck.dieCounter > 1)
        {
            var ad = FindObjectOfType<RewardedAdScript>(); // this can be a field
            if (ad != default)
            {
                var view = ad.GetView(); // get current ad view (cached one)
                view.OnUserEarnedReward += (s, e) =>
                {
                    var reward = view.GetRewardItem();
                    if (reward != default)
                    {
                        var rewardType = reward.Type;
                        var rewardValue = reward.Amount;
                    }
                };
                ad.ShowAd(true); // forcing to refresh cache
            }
        }
    }

   


}
