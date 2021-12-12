using UnityEngine;
using System.Collections;
public class PlayerStats : MonoBehaviour
{
    public static int Lives;
    public int startLives = 20;

    void Start()
    {
        Lives = startLives;
    }

}
