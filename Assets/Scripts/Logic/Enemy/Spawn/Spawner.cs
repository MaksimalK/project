using Logic.Enemy.Movement;
using System.Collections;
using UnityEngine;

namespace Logic.Enemy.Spawn
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private PathFollwer followerPrefab;
        [SerializeField] private float spawnInterval;
        [SerializeField] private float delay;
        [SerializeField] private int spawnCount;
        [SerializeField] private Transform[] path;

        private void Start()
        {
            StartCoroutine(Spawn());
        }

        private IEnumerator Spawn()
        {
            yield return new WaitForSeconds(delay);

            while (spawnCount > 0)
            {
                PathFollwer pathFollwer = Instantiate(followerPrefab, path[0].position, Quaternion.identity);
                pathFollwer.Init(path);
                spawnCount--;
                yield return new WaitForSeconds(spawnInterval);
            }
        }
    }
}
