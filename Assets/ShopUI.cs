using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool shopOpen = false;
    public GameObject shopMenuUI;
    Collider2D shopCollider;
    void Start()
    {
        shopMenuUI.SetActive(false);

        shopCollider = GetComponent<Collider2D>();
        shopCollider.enabled = true;
    }
    void Update()
    {
        if(shopOpen && (Input.GetKeyDown(KeyCode.W)))
        {

            Close();
        }
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Player")
        {
            Open();
        }
    }
    void Open()
    {
        shopMenuUI.SetActive(true);
        shopOpen = true;
        Time.timeScale = 0f;
    }
    void Close()
    {
        shopMenuUI.SetActive(false);
        shopOpen = false;
        Time.timeScale = 1f;
    }
}
