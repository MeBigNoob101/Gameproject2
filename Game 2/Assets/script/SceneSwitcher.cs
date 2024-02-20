using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitcher : MonoBehaviour
{
    public GameObject player;

    private PlayerInventory inventory;

    private void Start()
    {
        inventory = player.GetComponent<PlayerInventory>();

    }



    // Update is called once per frame
    void Update()
    {
        if (inventory.NumberOfDiamonds >= 5)
        {
            SceneManager.LoadScene("3. End");
        }
    }
}
