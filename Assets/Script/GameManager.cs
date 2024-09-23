
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Sprite _X;
    [SerializeField] private Sprite _O;
    public static Sprite CurrentP;
    public static ButtonB[,] Grid;
    public static int Turn = 0;
    public static int Winner = -1;
    [SerializeField] private GameObject Banner;
    [SerializeField] private TextMeshProUGUI Writing;
    private void Awake()
    {
        Grid = new ButtonB[3,3];
    }
  
    public static int player_1 = 0;
    public static int  player_2 = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    public static int Check()// check for up, down or diganaol
    {
        
        for (int y = 0; y < 3; y++)
        {
            int B1 = Grid[0, y].CurrentC;
            int B2 = Grid[1, y].CurrentC;
            int B3 = Grid[2, y].CurrentC;
            if (B1 == B2 && B1 == B3 && B1 != -1)//Rows
            {
                return B1;
            }
        }
        for (int x = 0; x < 3; x++)
        {
            int B1 = Grid[x, 0].CurrentC;
            int B2 = Grid[x, 1].CurrentC;
            int B3 = Grid[x, 2].CurrentC;
            if (B1 == B2 && B1 == B3 && B1 != -1)//Columns
            {
                return B1;
            }
        }




        if (Grid[0, 0].CurrentC == Grid[1, 1].CurrentC && Grid[0, 0].CurrentC == Grid[2, 2].CurrentC && Grid[0, 0].CurrentC != -1)//top left down Diagnol1
        {
            return Grid[0, 0].CurrentC;
        }
        if (Grid[2, 0].CurrentC == Grid[1, 1].CurrentC && Grid[2, 0].CurrentC == Grid[0, 2].CurrentC && Grid[2, 0].CurrentC != -1)//top right down Diagnol2
        {
            return Grid[2, 0].CurrentC;
        }
        

        return -1;
    }
    //Assign value to player's x||o and then assign it to the button of choice.
    void Update()
    {
        if (Winner != -1)
        {
            Banner.SetActive(true);
            Writing.text = "Winner Player" + (Winner + 1); 
        }
        if (Turn % 2 == 0)
        {
            
            CurrentP = _X;

        }

        else
        {
            
            CurrentP = _O;
        }


    }
}
//player1 is 0, player2 is 1, etc
// if player1 matches value of turn, run and block other players control
//else if player2 matches value of turn, run and block other players control
//if spaces are full, stop
//if player 1 has three in a row -> win
//else other player is loser
//if player1 selects an option all other buttons are locked
//else if player2 selects an option all other buttons are locked
//else other player that is not choosing is locked from controls
//if space is taken do not change

//Run said loop to count the interger to determine turn of the the players.   players->   1-2
//The program needs to know whose turn it is depending on the score-> wether it is either 0-1
//turn is decieded by number

//if spaces are full, stop
//win- if either x or O are three in row
//loser- is decided by being the other player to winner
//player is allowed only one button of their chosing
//player cannot pick a space that is taken

// 