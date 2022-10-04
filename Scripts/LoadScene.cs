using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    public GameObject[] characterPrefab;
    public GameObject[] weaponPrefab;
    public Transform spawnPoint;
    public Transform spawnPoint1;
    public GameObject prefab, clone, clone1;
    // Start is called before the first frame update
    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedPlayer");
        prefab = characterPrefab[selectedCharacter];
        clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        int selectedWeapon = PlayerPrefs.GetInt("selectedWeapon");
        GameObject prefab1 = weaponPrefab[selectedWeapon];
        clone1 = Instantiate(prefab1, spawnPoint1.position+new Vector3(0.6f,0,0), Quaternion.identity);
        clone1.gameObject.SetActive(true);
    }

    
}
