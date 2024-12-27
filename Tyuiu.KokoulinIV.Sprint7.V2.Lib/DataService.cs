namespace Tyuiu.KokoulinIV.Sprint6.V2.Lib
{
    public class DataService
    {
        public string[,] GetMatrix(string seach ,string[,] array)
        {
            string[,] arrayNew = new string[array.GetLength(0), array.Length/ array.GetLength(0)];
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.Length / array.GetLength(0); j++)
                {
                    if (seach == array[i,1])
                    {
                        arrayNew[i,j] = array[i,j];
                    }
                 
                    else
                    {

                        continue;

                    }
                }
            }
            return arrayNew;
        }
    }
}
