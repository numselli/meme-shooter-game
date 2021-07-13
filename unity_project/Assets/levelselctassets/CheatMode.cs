using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(KonamiCode))]
public class CheatMode : MonoBehaviour
{
    private KonamiCode code;


    void Awake()
    {
        code = GetComponent<KonamiCode>();
    }

    void Update ()
    {
		if (code.success)
        {
            print("code works");
            SceneManager.LoadScene(8);

        }
    }
}
