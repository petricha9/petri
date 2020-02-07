using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.IO;

public static class SaveManager 
{

    [System.Serializable]
    public class Data
    {
        //item to be save
        public int currentEnergy;
        //public float lastAddedTime;
        //public float ExitTime;

        //public bool[] itemCollected;
    }


    public static Data data;

    public static void SaveProgress ()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/item.data";
        FileStream stream = new FileStream(path, FileMode.Create);
        formatter.Serialize(stream, data); //to save data into the file inputting the stream as the location and data as data 
        
        stream.Close();
    }

    public static void LoadPlayer()
    {
        string path = Application.persistentDataPath + "/item.data";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            

            data = formatter.Deserialize(stream) as Data;

            stream.Close();
        }
        else
        {
            Debug.Log("created");
            //run once just to create file
            data = new Data
            {
                
                currentEnergy = 1,
                //lastAddedTime = (float)DateTime.MinValue.ToOADate()
            };
            Debug.LogError("Save file not found in " + path);
           
        }
    }

}
