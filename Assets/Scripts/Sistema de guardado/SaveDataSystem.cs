using UnityEngine;
using System.IO;

public static class SaveDataSystem 
{
    static string savePath = Application.persistentDataPath + "/SaveFile.save";

    public static void Save()
    {
        string json = JsonUtility.ToJson(Stats.userStats, true);
        File.WriteAllText(savePath, json);
        Debug.Log("Guardado en: " + savePath);
    }

    public static void Load()
    {
        if(File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            Stats.userStats = JsonUtility.FromJson<UserStats>(json);
            Debug.Log("Datos cargados");
        }
        else
        {

        }
    }
}
