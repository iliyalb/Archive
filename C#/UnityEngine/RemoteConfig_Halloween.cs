// Brackeys: https://youtu.be/14njHI4CGgA
using System.Collections;
using System.Collections.Generic;
using Unity.RemoteConfig;
using UnityEngine;

public class Halloween : MonoBehaviour
{
    public struct userAttributes
    {

    }

    public struct appAttributes
    {

    }

    public bool isHalloween = false;

    public GameObject halloweenLights;
    public GameObject defaultLights;

    public GameObject halloweenPlayer;
    public GameObject defaultPlayer;

    void Awake ()
    {
        ConfigManager.FetchCompleted += ApplyRemoteSettings;
        ConfigManager.FetchConfigs<userAttributes, appAttributes> (new userAttributes (), new appAttributes ());
    }

    void ApplyRemoteSettings (ConfigResponse response)
    {
        isHalloween = ConfigManager.appConfig.GetBool ("isHalloween"); // Key followed by a Rule

        if (isHalloween)
        {
            SetupHalloween ();
        }
        else
        {
            SetupDefault ();
        }
    }

    void SetupHalloween ()
    {
        RenderSettings.ambientIntensity = .5f;

        halloweenLights.SetActive (true);
        defaultLights.SetActive (false);

        halloweenPlayer.SetActive (true);
        defaultPlayer.SetActive (false);
    }

    void SetupDefault ()
    {
        RenderSettings.ambientIntensity = .5f;

        halloweenLights.SetActive (false);
        defaultLights.SetActive (true);

        halloweenPlayer.SetActive (false);
        defaultPlayer.SetActive (true);
    }

    void OnDestroy ()
    {
        ConfigManager.FetchCompleted -= ApplyRemoteSettings;
    }
}