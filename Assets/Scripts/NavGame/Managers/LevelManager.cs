using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NavGame.Managers
{

    public abstract class LevelManager : MonoBehaviour
    {
        public static LevelManager instance;
        public Action [] actions;
        protected int setectedAction = -1;

        protected virtual void Awake()
        {
            if(instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }

        }

        void Start()
        {
            StartCoroutine(SpawnBad());
        }

        public virtual void SelectAction(int actionIndex)
        {
            Debug.Log("Selected:" + actions[actionIndex].prefab.name);
            setectedAction = actionIndex;
        }

        public virtual void DoAction(Vector3 point)
        {
            Debug.Log("Do:" + actions[setectedAction].prefab.name);
            Instantiate(actions[setectedAction].prefab, point, Quaternion.identity);
        }

        public virtual void CancelAction()
        {
            if(setectedAction != -1)
            {
                setectedAction = -1;
            }
        }

        public bool IsActionSelected()
        {
            return setectedAction != -1;
        }

        protected abstract IEnumerator SpawnBad();

        [Serializable]

        public class Action
        {
            public int cost;
            public GameObject prefab;
            public float waitTime = 1f;
            public float coolDown;
        }

    }
}
