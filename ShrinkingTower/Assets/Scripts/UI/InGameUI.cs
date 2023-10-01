using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InGameUI : MonoBehaviour
{
    [SerializeField] private PlayerMovement pm;
    [SerializeField] private TextMeshProUGUI coinText;  

    private void Start() {
        pm = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }
    void Update()
    {
        coinText.text = "" + pm.coinCounter;
    }
}
