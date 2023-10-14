using System.Collections.Generic;
using UnityEngine;
using UnityFx.Outline;

namespace Display.Production
{
    
    public class ProductionManager : MonoBehaviour
    {
        public static Mode CurrentMode = Mode.ChangeColor;

        public static List<GameObject> selectedGameObjects = new List<GameObject>();
        public static List<GameObject> createdGameObjects = new List<GameObject>();
        
        public GlobalVariables globalvariables;
        
        // Start is called before the first frame update
        void Start()
        {
            
            
            foreach (var createdGameObject in createdGameObjects)
            {
            }
        }

        void Update()
        {
            if (selectedGameObjects.Count == 0)
            {
                ProductionFunction.Camera();
                ProductionFunction.RotateCamera();
            }
            else
            {
                ProductionFunction.ChangeScale();
                ProductionFunction.ChangePos();
            }
            
            // if (globalvariables.GetSetProperty == false)
            // {
            //
            // }
            
            //選択されているオブジェクトにアウトラインを適用する処理
            foreach (var createdGameObject in createdGameObjects)
            {
                var outline = createdGameObject.GetComponent<OutlineBehaviour>();
                
                if (selectedGameObjects.Exists(x => x == createdGameObject))
                {
                    outline.enabled = true;
                }
                else
                {
                    outline.enabled = false;
                }
            }
        }
    }
}
