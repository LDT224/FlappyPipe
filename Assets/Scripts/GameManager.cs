using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField]
    private GameObject[] Birds;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartGame()
    {
        int r = Random.Range(0, Birds.Length);
        GameObject bird = Instantiate(Birds[r]);
        Debug.Log("Game Started");
    }

    public void EndGame()
    {
        Debug.Log("Game Ended");
    }
}
