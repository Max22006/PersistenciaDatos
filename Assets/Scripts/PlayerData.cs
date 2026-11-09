using UnityEngine;

public static class PlayerData
{
    public static string nombreUsuario;
    public static int vigor;
    public static int fuerza;
    public static int resistencia;
    public static int inteligencia;
    public static float experiencia;

    public static Vector3 lastPosition;


    public static void Save()
    {
        PlayerPrefs.SetString("NombreUsuario", nombreUsuario);
        PlayerPrefs.SetInt("VigorUsuario", vigor);
        PlayerPrefs.SetFloat("XPUsuario", experiencia);
    }

    public static void Load()
    {
        nombreUsuario = PlayerPrefs.GetString("NombreUsuario", nombreUsuario);
        vigor = PlayerPrefs.GetInt("VigorUsuario", vigor);
        experiencia = PlayerPrefs.GetFloat("XPUsuario", experiencia);
    }
}
