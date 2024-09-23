
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


class Reset : MonoBehaviour
{
    public void Redo()
    {
        for (int c = 0; c < 3; c++)
        {
            for (int r = 0; r < 3; r++)
            {
                GameManager.Grid[c, r].ButtonReset();
                
            }
        }
        GameManager.Turn = 0;
        GameManager.Winner = -1;
        gameObject.SetActive(false);
    }
}

