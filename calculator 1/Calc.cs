using System;
using System.Collections.Generic;
using System.Text;

namespace calculator_1
{
    public class Calc
    {

        public float Add(float x, float y) { return x + y; }
        public float Subtract(float x, float y) { return x - y; }
        public float Divide(float x, float y) 
        {
            try
            {
                return x / y;

            }
          catch (DivideByZeroException)
            {
               return float.NaN;
            }
                                                      
        }

        public float Multiply(float x, float y) { return x * y; }
        public int Add(int x, int y) { return x + y; }
        public int Subtract(int x, int y) { return x - y; }
        public int Divide(int x, int y) { return x / y; }
        public int Multiply(int x, int y) { return x * y; }
        public float Add(List<float> x) {
            float result = 0;
            
            for (int i = 0; i < x.Count; i++)
            {
                result += x[i];
                
            }
            return result;       
        
        }

        
        public float Subtract(List<float> x) {
            float result = 0;
            for (int i = 0; i < x.Count; i++)
            {
                result -= x[i];
            }
            return result;
               
            
        }
        
        
    }

}
