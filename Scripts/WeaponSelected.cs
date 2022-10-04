using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponSelected : CharacterSelection
{
    public GameObject[] weaponSelected;
    public int weaponvalue;
    public string weaponseleted;   

    // Start is called before the first frame update
    private void Start()
    {
        weaponseleted = "weaponvalue";
    }
    public void upcomingweapon()
    {
        NextPlayer(weaponSelected, weaponvalue++);  
    }

    public void previousedweapon()
    {
        PreviousPlayer(weaponSelected, weaponvalue--);

        if (weaponvalue < 0)
        {
            weaponvalue += weaponSelected.Length;
        }
    }
    public void SelectedWeapon()
    {
        StartGame(weaponseleted, weaponvalue);
    }

}
