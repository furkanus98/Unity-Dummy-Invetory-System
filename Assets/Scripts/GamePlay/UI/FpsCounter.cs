using System;
using TMPro;
using UnityEngine;

public class FpsCounter : MonoBehaviour
{
    public static event Action<int> OnFPSUpdated; // FPS güncelleme event'i

    [SerializeField] private float updateInterval = 1.0f; // Kaç saniyede bir FPS güncellenecek
    private float deltaTime = 0.0f;
    private float fpsUpdateTimer = 0.0f;

    private void Update()
    {
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;

        fpsUpdateTimer += Time.deltaTime;

        if (fpsUpdateTimer >= updateInterval)
        {
            fpsUpdateTimer = 0.0f;
            int fps = Mathf.CeilToInt(1.0f / deltaTime);

            // FPS deðerini event ile bildir
            OnFPSUpdated?.Invoke(fps);
        }
    }

}
