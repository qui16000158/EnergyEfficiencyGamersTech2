﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObject : MonoBehaviour
{
    public void DisableCurrentObject()
    {
        gameObject.SetActive(false);
    }
}
