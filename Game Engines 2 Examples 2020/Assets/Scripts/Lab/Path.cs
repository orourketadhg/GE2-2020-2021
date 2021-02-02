using System;
using System.Collections.Generic;
using UnityEngine;

namespace Lab {

    public class Path : MonoBehaviour {
        [HideInInspector] public List<Vector3> waypoints = new List<Vector3>();
        public bool isLooped;
        
        private void Awake() {
            waypoints.Add(transform.position);
            foreach (Transform child in transform) {
                waypoints.Add(child.position);
            }
        }
        
        private void OnDrawGizmosSelected() {
            if (!Application.isPlaying) {
                return;
            }
            
            Gizmos.color = Color.blue;
            for (int i = 0; i < waypoints.Count - 1; i++) {
                Gizmos.DrawLine(waypoints[i], waypoints[i + 1]);
            }

            if (isLooped) {
                Gizmos.DrawLine(waypoints[0], waypoints[waypoints.Count - 1]);
            }
            
        }
        
    }
    
}
