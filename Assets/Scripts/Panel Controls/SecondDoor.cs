using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDoor : MonoBehaviour
{
    public GameObject switchPanel;
    public GameObject lav;
    bool fCheck, switchControl;
    public static bool blueElavator;

    // Start is called before the first frame update
    void Start()
    {
        blueElavator = false;
    }

    // Update is called once per frame
    void Update()
    {
        Kontrol();
    }

    void Kontrol()
    {
        if (fCheck && Input.GetKeyDown(KeyCode.F) && !switchControl)
        {
            switchPanel.SetActive(true);
            lav.SetActive(false);
            blueElavator = true;
            fCheck = false;
            switchControl = true;
        }
        else if (fCheck && Input.GetKeyDown(KeyCode.F) && switchControl)
        {
            switchPanel.SetActive(false);
            lav.SetActive(true);
            blueElavator = false;
            fCheck = false;
            switchControl = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            fCheck = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            fCheck = false;
        }
    }
}
