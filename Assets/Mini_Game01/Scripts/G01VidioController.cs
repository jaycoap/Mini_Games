using UnityEngine;

public class G01VidioController : MonoBehaviour
{
    [SerializeField] private Transform targetRoot;
    [SerializeField] private float playingAlpha = 0.5f;
    [SerializeField] private float stoppedAlpha = 1f;

    private SpriteRenderer[] renderers;

    void Awake()
    {
        if (targetRoot == null)
        {
            targetRoot = transform;
        }

        renderers = targetRoot.GetComponentsInChildren<SpriteRenderer>(true);
    }

    public void Playing()
    {
        SetAlpha(playingAlpha);
    }

    public void Stopping()
    {
        SetAlpha(stoppedAlpha);
    }

    void SetAlpha(float alpha)
    {
        foreach (SpriteRenderer sr in renderers)
        {
            if (sr == null)
            {
                continue;
            }

            Color c = sr.color;
            c.a = alpha;
            sr.color = c;
        }
    }
}
