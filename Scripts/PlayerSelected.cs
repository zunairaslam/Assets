using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelected : CharacterSelection
{

    public GameObject[] playerSelected;
    public int playervalue = 0;
    // Start is called before the first frame update
    
    public void upcomingPlayer()
    {
        NextPlayer(playerSelected, playervalue++);
    }

    public void previousedPlayer()
    {
        PreviousPlayer(playerSelected,playervalue--);

        if(playervalue < 0)
        {
            playervalue += playerSelected.Length;
        }
    }
}
