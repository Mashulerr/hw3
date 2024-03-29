namespace hw3{

    public sealed class OneDimensionalArray : BaseArray {

        private int[] _arr1;
        public OneDimensionalArray(int[] array, int length, bool userFilled = false){
            _arr1 = array;
            
            _arr1 = new int[length];
        if (userFilled)
        {
            FillArrayByUser();
        }
        else
        {
            FillRandomly();
        }
    }

    public override void FillArrayByUser()
    {
        for (int i = 0; i < _arr1.Length; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            _arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    public override void FillRandomly()
    {
        Random rnd = new Random();
        for (int i = 0; i < _arr1.Length; i++)
        {
            _arr1[i] = rnd.Next();
        }
    }


    public override double Average()
    {
        double sum = 0;
        for (int i = 0; i < _arr1.Length; i++)
        {
            sum += _arr1[i];
        }
        return sum / _arr1.Length;
    }

 public void DeleteElementsBiggerThan100()
    {
        int Index = 0;
        for (int i = 0; i < _arr1.Length; i++)
        {
            if (_arr1[i] < 100)
            {
                if (_arr1[i] > 100)
                {
                    Index += 1;
                }
            }
        }
        int[] newArray = new int[Index];

        int NewIndex = 0;

        foreach (int num in _arr1)
        {
            if (num >= -100 && num <= 100)
            {
                newArray[NewIndex] = num;
                NewIndex += 1;
            }
        }
        for (int i = 0; i < _arr1.Length; i++)
        {
            Console.Write(_arr1[i] + " ");
        }
        Console.WriteLine();
    }


    public void RemoveDuplicates()
    {
        int count = 0;
        for (int i = 0; i < _arr1.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < i; j++)
            {
                if (_arr1[j] == _arr1[i])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                count++;
            }
        }

        int[] newArray = new int[count];
        int index = 0;
        for (int i = 0; i < _arr1.Length; i++)
        {
            bool isDuplicate = false;
            for (int j = 0; j < i; j++)
            {
                if (_arr1[j] == _arr1[i])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                newArray[index] = _arr1[i];
                index++;
            }
        }

        _arr1 = newArray;
    }
  
 
    public override void Print(){
        Console.WriteLine("Массив:");
        for (int i = 0; i < _arr1.Length; i++)
        {
            Console.WriteLine(_arr1[i]);
        }
    }
      
    }
}