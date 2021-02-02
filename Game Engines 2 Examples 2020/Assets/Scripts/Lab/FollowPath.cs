using UnityEngine;

namespace Lab {

    public class FollowPath : MonoBehaviour {

        public float speed = 1f; 

        private Path _path;
        private Rigidbody _rb;

        private const float Threshold = 0.1f;
        private int _targetWaypointIndex;

        private void Start() {
            _path = FindObjectOfType<Path>();
            _rb = GetComponent<Rigidbody>();
            
            _targetWaypointIndex = 0;
        }

        private void FixedUpdate() {
            _rb.velocity = Seek(_path.waypoints[_targetWaypointIndex]);

            if (!( ( _path.waypoints[_targetWaypointIndex] - transform.position ).magnitude <= Threshold * Threshold )) {
                return;
            }

            if (_path.isLooped) {
                _targetWaypointIndex += 1;
                _targetWaypointIndex %= _path.waypoints.Count;
            }
            else {
                _targetWaypointIndex += ( _targetWaypointIndex == _path.waypoints.Count - 1 ) ? -1 : 1;
            }

        }

        private Vector3 Seek(Vector3 target) {
            Vector3 dir = target - transform.position;
            Vector3 desiredVelocity = dir.normalized * speed;

            return (desiredVelocity - _rb.velocity);
        }
    }

}