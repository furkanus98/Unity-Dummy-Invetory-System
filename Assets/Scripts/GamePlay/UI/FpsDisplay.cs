using TMPro;
using UnityEngine;

public class FpsDisplay : MonoBehaviour
{
    [SerializeField] private bool displayFPS;
    [SerializeField] private TMP_Text m_FpsCounterText;
    [SerializeField] private GameObject m_FpsCounterPrefab;

    void OnEnable()
    {
        FpsCounter.OnFPSUpdated += UpdateFPSDisplay; // Event'e abone ol
    }

    void OnDisable()
    {
        FpsCounter.OnFPSUpdated -= UpdateFPSDisplay; // Event'ten çýk
    }

    private void UpdateFPSDisplay(int fps)
    {
        if (m_FpsCounterPrefab == null || m_FpsCounterText == null)
            return;

        m_FpsCounterPrefab.SetActive(displayFPS);

        if (displayFPS)
        {
            m_FpsCounterText.text = $"FPS: {fps}";
        }
    }
}
