using UnityEngine;

public class UserStats : MonoBehaviour
{
    public string playerName;
    public Vector3 playerPosition;
    public float playerHealth;
    public int playerExp;


}

public static class Stats
{
    public static UserStats userStats = new UserStats();
}