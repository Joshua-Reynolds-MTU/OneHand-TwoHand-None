﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backScript : MonoBehaviour
{
    public void goBack()
    {
        SceneManager.LoadScene("Menu");
    }
}
