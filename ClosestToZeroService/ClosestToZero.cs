using System;

namespace ClosestToZeroService
{
    public class ClosestToZero
    
    {
        public int GetClosest(int[] InputArray){
            if (InputArray == null || InputArray.Length == 0) {
                throw new ArgumentException();
            } 
            int closest = int.MinValue;
            foreach (int element in InputArray){
                if (closest == int.MinValue || Math.Abs(element) < Math.Abs(closest)) {
                    closest = element;
                } 
               if(Math.Abs(closest) == Math.Abs(element)){
                    closest = Math.Abs(element);
                }
            }
            return closest;
        }
    }
}
