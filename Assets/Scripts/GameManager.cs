using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField]
    private GameObject[] birds;
    [SerializeField]
    private GameObject pipePrefab;
    [SerializeField]
    private GameObject pipeSpawn;

    private GameObject[] listPipe;

    public int pipeSpeed = 0;
    private int minTimeSpawnPipe = 1;
    private int maxTimeSpawnPipe = 3;
    private float lastSpawnTime = 0;
    private bool play = false;
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
        int r = Random.Range(0, birds.Length);
        GameObject bird = Instantiate(birds[r]);

        pipeSpeed = 3;
        play = true;

        Debug.Log("Game Started");
    }

    public void EndGame()
    {
        Debug.Log("Game Ended");
    }

    private void Update()
    {
        if (!play)
        {
            return;
        }
        if (lastSpawnTime < Time.time)
        {
            spawnPipe();

            int nextSpawn = Random.Range(minTimeSpawnPipe, maxTimeSpawnPipe);
            lastSpawnTime = Time.time + nextSpawn;
        }
    }

    private void spawnPipe()
    {
        GameObject pipe = Instantiate(pipePrefab);
        pipe.transform.parent = pipeSpawn.transform;
    }
}
