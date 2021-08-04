using UnityEngine;

public class ChangeModels : MonoBehaviour
{
    public GameObject[] Models;

    public bool CheckIfExists(int changer)
    {
        int index = GetCurrentIndex();
        if (index < 0) 
        {
            Debug.Log("Hyuston we entered black hole...");
            return false;
        }

        int amount = Models.Length;
        if (changer > 0)
        {
            return index + changer < amount;
        }
        else 
        {
            return index + changer >= 0;
        }
    }

     public int GetCurrentIndex() 
     {
         for (int i = 0; i < Models.Length; i++) 
         {
            if (Models[i].activeInHierarchy)
            {
                return i;
            }
         }
         return -1;
     }
    public void ModelChange(bool direction)
    {
        if (direction)
        {
            if (CheckIfExists(1))
            {
                int index = GetCurrentIndex();

                Models[index].SetActive(false);
                Models[index + 1].SetActive(true);
            }
            else
                Debug.Log("Hyuston we have a problem, we reach the maximum");
        }
        else
        {
            if (CheckIfExists(-1))
            {
                int index = GetCurrentIndex();

                Models[index].SetActive(false);
                Models[index - 1].SetActive(true);
            }
            else
                Debug.Log("Hyuston we have a problem, we reach the minimum");
        }
    }
}
