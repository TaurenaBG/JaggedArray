using System.ComponentModel;

int Rows = int.Parse(Console.ReadLine());

List<List<int>> matrix = new List<List<int>>();
for(int i = 0; i < Rows; i++)
{   
    List<int> matrixRow = Console.ReadLine()
        .Split(' ',StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToList();
      
        matrix.Add(matrixRow.ToList());  
}
for (int i = 0; i < matrix.Count - 1; i++)
{
    if (matrix[i].Count == matrix[i + 1].Count)
    {
        for (int j = 0; j < matrix[i].Count; j++)
        {
            matrix[i][j] *= 2;
            matrix[i + 1][j] *= 2;
        }
    }
    else
    {
        for (int j = 0; j < matrix[i].Count; j++)
        {
            matrix[i][j] /= 2;           
        }
        for (int j = 0; j < matrix[i+1].Count; j++)
        {
            matrix[i + 1][j] /= 2;
        }
    }
}

string comandd;
while((comandd = Console.ReadLine()) != "End")
{
    string[] input = comandd.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
    int row = int.Parse(input[1]);
    int col = int.Parse(input[2]);
    int value = int.Parse(input[3]);
    switch (input[0])
    {

        case "Add":
            
            if(row > -1 && row < matrix.Count )
            {
                if (col > -1 && col < matrix[row].Count)
                {
                    matrix[row][col] += value;
                }
            }
                break;
        case "Subtract":
            if (row > -1 && row < matrix.Count)
            {
                if (col > -1 && col < matrix[row].Count)
                {
                    matrix[row][col] -= value;
                }
            }
            break;

        default: break;      
    }
}

foreach (List<int> item in matrix)
{
    Console.WriteLine(string.Join(" ",item));
    
}
