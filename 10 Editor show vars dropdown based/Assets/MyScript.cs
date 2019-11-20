using UnityEngine;

public class MyScript : MonoBehaviour
{
    public enum Modes { Move, Size, Scale }; 
    public Modes Mode; // This will create the dropdown in the inspector
    public int type1Var; // only show if type == Types.Type1
    public int type2Var; // only show if type == Types.Type2

}