
using UnityEngine;
using UnityEngine.UI;
public class ButtonB : MonoBehaviour
{
    public bool buttonSpace = false;
    [SerializeField] private Sprite _X;
    [SerializeField] private Sprite _O;
    [SerializeField] private int _XP;
    [SerializeField] private int _YP;
    public int CurrentC = -1;
    private void Start()
    {
        GameManager.Grid[_XP, _YP] = this;
    }
    public void ButtonReset()
    {
        buttonSpace = false;
        CurrentC = -1;
        GetComponent<Image>().sprite = null;
    }
 
    public void Click()
    {
        
        string Id = gameObject.name;
        Debug.Log(Id + " " + buttonSpace.ToString());
        if (!buttonSpace && GameManager.Winner == -1)
        {
           ExecuteClick();

        }
    }
    private void ExecuteClick()
    {
        Debug.Log("Click");
        buttonSpace = true;
        CurrentC = GameManager.Turn % 2;
        GetComponent<Image>().sprite = GameManager.CurrentP;
        if (GameManager.Check() == -1)
        { GameManager.Turn++; }
        else { Debug.Log((CurrentC) +(1) + " Winner!");
            GameManager.Winner = CurrentC;
        }
        
    }//Put banner and reset button in unity
    
}


/*
GameManager.player_1 = 
if value is 0 for turn use _X


GetComponent<Image>().sprite = _X;
        GetComponent<Image>().sprite = _O;

*/
// if (GameManager.Turn % 2 == 0)
// {
//     Debug.Log("Player 1's Turn.");
//     GetComponent<Image>().sprite = _X;
// }

// else
// {
//     Debug.Log("Player 2's Turn.");
//     GetComponent<Image>().sprite = _O;
// }