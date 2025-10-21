using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Clicker : MonoBehaviour
{
    private int clicks = 0;
    private int clickCount = 0;
    [Header("Animation Setting")]
    public Ease ease;
    public AudioSource audioSource;
    public ParticleSystem particles;

    public int Clicks {
        get
        {
             return clicks;
        }
        set
        {
            particles.Emit(value -clicks);
            clicks = value;
            UIManager.instance.UpdateClicks(Clicks);
        }}


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        UIManager.instance.UpdateClicks(clicks);
    }
    private void OnMouseDown()
    {
        Clicks++;
        audioSource.Play();
        transform.DOScale(Vector3.one, 0.1f)
            .ChangeStartValue(Vector3.one * 1.5f)
            .SetEase(ease);
            //.SetLoops(2, LoopType.Yoyo);
    }
}
