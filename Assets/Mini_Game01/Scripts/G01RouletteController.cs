using UnityEngine;
using UnityEngine.Video;

public class G01RouletteController : MonoBehaviour
{
    [SerializeField] private Transform rotationTarget;
    [SerializeField] private AudioSource audiosource;
    [SerializeField] private AudioClip audoclip;
    [SerializeField] private float playSpeed = 480f;
    [SerializeField] private float braking = 180f;
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private G01VidioController vidioController;

    private float rotSpeed = 0f;
    private bool isStopping = false;

    void Awake()
    {
        if (rotationTarget == null)
        {
            rotationTarget = transform;
        }
    }

    void Update()
    {
        if (rotSpeed > 0f)
        {
            rotationTarget.Rotate(0f, 0f, rotSpeed * Time.deltaTime);
        }

        if (isStopping)
        {
            rotSpeed = Mathf.MoveTowards(rotSpeed, 0f, braking * Time.deltaTime);
            if (rotSpeed <= 0f)
            {
                rotSpeed = 0f;
                isStopping = false;
            }
        }
    }

    public void RollStart()
    {
        rotSpeed = playSpeed;
        isStopping = false;

        if (vidioController != null)
        {
            vidioController.Playing();
        }

        if (audiosource != null && audoclip != null)
        {
            audiosource.clip = audoclip;
            audiosource.Play();
        }

        if (videoPlayer != null)
        {
            videoPlayer.Play();
        }
    }

    public void Stop()
    {
        isStopping = true;

        if (vidioController != null)
        {
            vidioController.Stopping();
        }

        if (audiosource != null)
        {
            audiosource.Stop();
        }

        if (videoPlayer != null)
        {
            videoPlayer.Stop();
        }
    }
}
