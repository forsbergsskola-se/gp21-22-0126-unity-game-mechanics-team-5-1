using UnityEngine;
using UnityEngine.UI;

public class UI_FlightBar : MonoBehaviour
{
    private Slider slider;
    private ParticleSystem particleSys;

    public float speed = 0.5f;
    private float target = 0;

    void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        particleSys = GameObject.Find("Bar Particles").GetComponent<ParticleSystem>();
    }

    private void Start()
    {
        DecreaseBar(0.75f);
    }

    void Update()
    {
        if (slider.value > target)
        {
            slider.value -= speed * Time.deltaTime;
            if (!particleSys.isPlaying) particleSys.Play();
        }
        else particleSys.Stop();
    }

    public void DecreaseBar(float progress)
    {
        target = slider.value - progress;
    }
}
