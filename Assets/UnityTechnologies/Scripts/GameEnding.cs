using UnityEngine;

public class GameEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup;

    bool m_IsPlayerAtExit;
    float m_Timer;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerAtExit = true;
        }
    }
    private void Update()
    {
        if (m_IsPlayerAtExit)
        {
            EndLevel();
        }
    }
    void EndLevel()
    {
        exitBackgroundImageCanvasGroup.alpha = m_Timer / fadeDuration;
        m_Timer += Time.deltaTime;

        if (m_Timer > fadeDuration + displayImageDuration)
        {
            Application.Quit();
        }
    }

}
