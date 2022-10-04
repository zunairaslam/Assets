using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] Player;
    public GameObject[] Weapons;
    public int selectedPlayer = 0;
    public int selectedWeapon = 0,a;
    public PlayerSelected playervalue1;

    // Start is called before the first frame update
    private void Update()
    {
        playervalue1 = GameObject.Find("Character Selection").GetComponent<PlayerSelected>();
    }
    public void NextPlayer(GameObject[] playerSelected, int playerIndex)
    {
        Player = playerSelected;
        selectedPlayer = playerIndex%Player.Length;
        Debug.Log(selectedPlayer);
        Player[selectedPlayer].SetActive(false);
        selectedPlayer = (selectedPlayer + 1) % Player.Length;
        Player[selectedPlayer].SetActive(true);
    }

    public void PreviousPlayer(GameObject[] playerSelected, int playerIndex)
    {
        Player = playerSelected;
        selectedPlayer = playerIndex%Player.Length;

        Player[selectedPlayer].SetActive(false);
        selectedPlayer--;
        if(selectedPlayer < 0)
        {
            selectedPlayer += Player.Length;
        }
        Player[selectedPlayer].SetActive(true);
    }

    public void StartGame(string weaponseleted, int weaponValue)
    {
        a=playervalue1.playervalue; 
        PlayerPrefs.SetInt("selectedWeapon", weaponValue);
        PlayerPrefs.SetInt("selectedPlayer", a);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    

}
