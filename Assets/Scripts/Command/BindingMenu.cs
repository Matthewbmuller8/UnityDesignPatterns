using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BindingMenu : MonoBehaviour
{
    public GameObject UIMenu;

    private void Start()
    {
        if (UIMenu != null)
        {
            UIMenu.SetActive(false);
        }
    }

    public void ToggleMenu()
    {
        if (UIMenu.activeSelf)
        {
            UIMenu.SetActive(false);
        }
        else
        {
            UIMenu.SetActive(true);
        }
    }

}
