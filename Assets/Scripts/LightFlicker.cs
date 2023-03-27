using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public float flickerIntensity = 0.2f;
    public float flickerPerSecond = 3.0f;
    public float speedRandom = 1.0f;

    private float time;
    private float startingIntensity;
    private Light baseLight;

    public void Start()
    {
        baseLight = GetComponent<Light>();
        startingIntensity = baseLight.intensity;
    }

    void Update()
    {
        time += Time.deltaTime * (1 - Random.Range(-speedRandom, speedRandom)) * Mathf.PI;
        baseLight.intensity = startingIntensity + Mathf.Sin(time * flickerPerSecond) * flickerIntensity;
    }
}
