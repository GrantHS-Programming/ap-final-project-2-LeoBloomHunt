using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public GameObject textmeshpro_time;
    public int textmeshpro_t;
    TextMeshProUGUI textmeshpro_time_text;
    // Start is called before the first frame update
    public float timer = 0;
    void Start()
    {
        textmeshpro_time_text = textmeshpro_time.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        int minutes = (int)(timer / 60);
        timer += Time.deltaTime;
        textmeshpro_time_text.text = minutes+":"+(int)(timer-minutes*60);
    }
}
