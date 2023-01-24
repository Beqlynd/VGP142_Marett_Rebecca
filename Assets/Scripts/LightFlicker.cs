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
    private Light light;

    public void Start()
    {
        light = GetComponent<Light>();
        startingIntensity = light.intensity;
    }

    void Update()
    {
        time += Time.deltaTime * (1 - Random.Range(-speedRandom, speedRandom)) * Mathf.PI;
        light.intensity = startingIntensity + Mathf.Sin(time * flickerPerSecond) * flickerIntensity;
    }
}
