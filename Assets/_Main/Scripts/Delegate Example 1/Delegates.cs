using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegates : MonoBehaviour
{
   // Method Signature
   private delegate void ChangeColor(Color newColor);

   // Store Method
   private ChangeColor _onColorChange;
   
   private delegate void Complete();

   private Complete _onComplete;

   private void Start()
   {
      _onColorChange = UpdateColor;

      _onColorChange(Color.green);

      // SingleCastExample();
      
      MultiCastExample();

      _onComplete?.Invoke();
   }

   private void SingleCastExample()
   {
      _onComplete = Task1;
   }

   private void MultiCastExample()
   {
      _onComplete += Task1;
      _onComplete += Task2;
      _onComplete += Task3;
   }

   private void UpdateColor(Color color)
   {
      Debug.Log("Changing color to: " + color.ToString());
   }

   private void Task1()
   {
      Debug.Log("Complete Task1");
   }
   
   private void Task2()
   {
      Debug.Log("Complete Task2");
   }
   
   private void Task3()
   {
      Debug.Log("Complete Task3");
   }
}
