using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour {

    public Transform enemyPrefab;

    public Transform spawnPoint;
    public float TimeBetweenWaves = 5f;
    private float countdown = 2f;
    public int waveTotal;
    private int waveNumber = 0;

	// Update is called once per frame
	void Update () {
	    if(countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = TimeBetweenWaves;
        }

        countdown -= Time.deltaTime;
	}

    IEnumerator SpawnWave()
    {
        waveNumber++; 

        if (waveNumber > waveTotal)
        {
            changeScence.changeToScene(playerState.curretScenceNumber);
        }

            for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }

    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

    }
}
