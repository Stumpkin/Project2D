﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LevelParserStarter : MonoBehaviour
{
    public string filename;

    public GameObject Rock;

    public GameObject Brick;

    public GameObject QuestionBox;

    public GameObject Stone;

    public GameObject badBlock;

    public GameObject Goal;

    public GameObject Coin;

    public Transform parentTransform;
    // Start is called before the first frame update
    void Start()
    {
        RefreshParse();
    }


    private void FileParser()
    {
        string fileToParse = string.Format("{0}{1}{2}.txt", Application.dataPath, "/Resources/", filename);

        using (StreamReader sr = new StreamReader(fileToParse))
        {
            string line = "";
            int row = 16;

            while ((line = sr.ReadLine()) != null)
            {
                int column = 0;
                char[] letters = line.ToCharArray();
                foreach (var letter in letters)
                {
                    //Debug.Log(string.Format("{0} {1} | {2}", row, column, letter));
                    Vector3 calls = new Vector3(column, row, 0f);
                    SpawnPrefab(letter, calls);
                    column++;
                    //Call SpawnPrefab
                }
                row--;
            }

            sr.Close();
        }
    }

    private void SpawnPrefab(char spot, Vector3 positionToSpawn)
    {
        GameObject ToSpawn;

        switch (spot)
        {
            case 'b':
                //Debug.Log("Spawn Brick");
               
                ToSpawn = Brick;
                break;

            case '?':
                
                ToSpawn = QuestionBox;
                //Debug.Log("Spawn QuestionBox"); 
                break;

            case 'x':
               
                ToSpawn = Rock;
                //Debug.Log("Spawn Rock"); 
                break;

            case 's':
                
                ToSpawn = Stone;
                //Debug.Log("Spawn Rock"); 
                break;

            case 'B':
                ToSpawn = badBlock;
                break;

            case 'G':
                ToSpawn = Goal;
                break;

            case 'C':
                ToSpawn = Coin;
                break;

            //default: Debug.Log("Default Entered"); break;
            default: return;
                //ToSpawn = //Brick;       break;
        }

        //ToSpawn = GameObject.Instantiate(ToSpawn, parentTransform);
        ToSpawn.transform.localPosition = positionToSpawn;
        Instantiate(ToSpawn);

    }

    public void RefreshParse()
    {
        GameObject newParent = new GameObject();
        newParent.name = "Environment";
        newParent.transform.position = parentTransform.position;
        newParent.transform.parent = this.transform;
        
        if (parentTransform) Destroy(parentTransform.gameObject);

        parentTransform = newParent.transform;
        FileParser();
    }
}
