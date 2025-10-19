using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    [Header("Show")]
    [SerializeField] // show in inspector. Matomas is inspektoriaus? bet nepasiekiamas kitiems objektams
    private TextMeshProUGUI clickText;



    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake() //before start
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("More than 1 UIManager detected");
            Destroy(gameObject);
        }
    }
    public void UpdateClicks(int clicks)
    {
        clickText.text = clicks.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
