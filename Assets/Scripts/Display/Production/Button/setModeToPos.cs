using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Display.Production
{
    public class setModeToPos : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        
        public void ChangeColor()
        {
            ProductionManager.CurrentMode = Mode.ChangePos;
        }
        
    }
}
