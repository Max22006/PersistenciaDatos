using UnityEngine;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour
{

    public string nombreUsuario;
   public int vigor;
   public int fuerza;
   public int resistencia;
   public int inteligencia;
   public float experiencia;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        LoadData();
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(1);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            SaveData();
        }
    }

    void SaveData()
    {
        PlayerPrefs.SetString("NombreUsuario", nombreUsuario);
        PlayerPrefs.SetInt("VigorPersonaje", vigor);
        PlayerPrefs.SetInt("FuerzaPersonaje", fuerza);
        PlayerPrefs.SetInt("StamPersonaje", resistencia);
        PlayerPrefs.SetInt("IntPersonaje", inteligencia);
        PlayerPrefs.SetFloat("EXPPersonaje", experiencia);
    }
    void LoadData()
    {
        nombreUsuario = PlayerPrefs.GetString("NombreUsuario", "Samuel");
        vigor = PlayerPrefs.GetInt("VigorPersonaje", 1);
        fuerza = PlayerPrefs.GetInt("FuerzaPersonaje", 1);
        resistencia = PlayerPrefs.GetInt("StamPersonaje", 1);
        inteligencia = PlayerPrefs.GetInt("IntPersonaje", 1);
        experiencia = PlayerPrefs.GetFloat("EXPPersonaje", 1);
    }
}
