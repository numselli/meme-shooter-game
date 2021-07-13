using System.IO;
using UnityEngine;
using System.Collections.Generic;

public class savecontrol : MonoBehaviour {
string saveFileLocation;
public bool IsReady { get; private set; }
public int [] ff;
    public void Start()
    {
        saveFileLocation = Path.Combine(Application.persistentDataPath, "savegame.json");

    }
    public void hi()
{
        Debug.Log("load");

        if (File.Exists(saveFileLocation))
        {

            var json = File.ReadAllText(saveFileLocation);
            var saveyame = JsonUtility.FromJson<SaveGame>(json);
            ff = saveyame.ff;
            FindObjectOfType<level_manager>().ff = ff;
            FindObjectOfType<level_manager>().Gold = FindObjectOfType<level_manager>().ff[0];
            FindObjectOfType<level_manager>().currentlevel = FindObjectOfType<level_manager>().ff[1];
            FindObjectOfType<level_manager>().coinlevel = FindObjectOfType<level_manager>().ff[2];
            FindObjectOfType<level_manager>().anamatedplayer = FindObjectOfType<level_manager>().ff[3];

            //FindObjectOfType<level_manager>().Gold = ff[0];
            //FindObjectOfType<level_manager>().currentlevel = ff[1];
            //FindObjectOfType<level_manager>().coinlevel = ff[2];
            Debug.Log("load done");
            //ff = savegame.ff;
        }
        IsReady = true;
    }

    public void SaveProgres()
    {
        Debug.Log("setting");

        FindObjectOfType<level_manager>().ff[0] = FindObjectOfType<level_manager>().Gold;
        FindObjectOfType<level_manager>().ff[1] = FindObjectOfType<level_manager>().currentlevel;
        FindObjectOfType<level_manager>().ff[2] = FindObjectOfType<level_manager>().coinlevel;
        FindObjectOfType<level_manager>().ff[3] = FindObjectOfType<level_manager>().anamatedplayer;

        Debug.Log("saving");
        var savgame = new SaveGame() { ff = FindObjectOfType<level_manager>().ff};
        var jon = JsonUtility.ToJson(savgame);
        File.WriteAllText(saveFileLocation, jon);
        Debug.Log("save completed");
    }
    void ProgramBegins()
    {
        hi();
    }
}
//void ProgramBegins()
//{
//    // code executed only once when the app is started
//}