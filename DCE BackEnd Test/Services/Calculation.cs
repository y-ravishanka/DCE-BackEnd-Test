namespace DCE_BackEnd_Test.Services
{
    internal class Calculation : ICalculation
    {
        int ICalculation.BoolToIntConvert(bool t)
        {
            switch (t)
            {
                case true :
                    return 1;
                    
                case false :
                    return 0;
            }
        }

        bool ICalculation.IntToBoolConvert(int t)
        {
            switch (t)
            {
                case 1:
                    return true;
                
                case 0:
                    return false;
                
                default :
                    return false;
            }
        }
    }
}
