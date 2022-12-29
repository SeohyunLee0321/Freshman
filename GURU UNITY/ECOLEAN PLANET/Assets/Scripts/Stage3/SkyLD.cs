using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyLD : MonoBehaviour
{
    public static SkyLD skyLS = null;

    public Light skylight;

    public float currentIntensity = 1.0f;
    [HideInInspector]
    float downIntensity = 0.2f;

    private void Awake()
    {
        if (skyLS == null)
        {
            skyLS = this;
        }
    }

    void Start()
    {
        skylight = GetComponent<Light>();
        skylight.intensity = currentIntensity;
    }

    void Update()
    {
        currentIntensity = skylight.intensity;
    }

    public void LightDown()
    {
        if (skylight.intensity > 0)
        {
            skylight.intensity -= downIntensity;
        }
    }
}
