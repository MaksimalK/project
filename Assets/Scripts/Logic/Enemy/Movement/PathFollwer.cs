using UnityEngine;

namespace Logic.Enemy.Movement
{
    public class PathFollwer :  MonoBehaviour
    {

        [SerializeField] private float speed;

        private Transform[] path;

        private int pointIndex;
        private Vector3 currentPoint => path[pointIndex].position;

        public void Init(Transform[] path)
        {
            this.path = path;
            pointIndex = 0;
        }

        private void Update()
        {
            Vector3 direction = (currentPoint - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime, Space.World);
            transform.LookAt(currentPoint);
            if((transform.position - currentPoint).magnitude < 0.5)
            {
                if(pointIndex >= path.Length - 1)
                    Destroy(gameObject);
                else
                    pointIndex++;

            }
        }
    }
}
