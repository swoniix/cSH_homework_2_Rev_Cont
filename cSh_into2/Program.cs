//4
Console.WriteLine("Enter array M size: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter array N size: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[m];
int[] arr2 = new int[n];
Console.WriteLine("Enter array M numbers: ");
for (int i = 0; i < m; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Enter array N numbers: ");
for(int i=0; i<n; i++)
{
    arr2[i] = int.Parse(Console.ReadLine());
}
//3 array
int[] common =  new int[Math.Min(m,n)]; //ищем мин размер массива
int count = 0;

for(int i=0;i<m;i++)
{
    bool FoundInArr2 =  false;
    for (int j=0; j < n; j++)
    {
        if (arr[i] == arr2[j])
        {
            FoundInArr2 = true;
            break;
        }
    }

    if (FoundInArr2)
    {
        bool alreadyAdded = false;
        for (int k = 0; k < count; k++)
        {
            if (arr[k] == common[k])
            {
                alreadyAdded = true;
                break;
            }
        }

        if (!alreadyAdded)
        {
            common[count] = arr[i];
            count++;
        }
    }
}
Console.WriteLine("Common numbers:");
for (int i = 0; i < count; i++)
{
    Console.Write(common[i]+" ");
}
//7
Console.WriteLine("Enter a text: ");
string[] words = Console.ReadLine().Split(' ');
for (int i = 0; i < words.Length; i++)
{
    char[] letters = words[i].ToCharArray();
    Array.Reverse(letters);
    string reversed = new string(letters);
    Console.Write(reversed + " ");
}
//8
Console.WriteLine("Enter a sentence: ");
string sentence = Console.ReadLine() ?? " ";
string exep = "aeiouAEIOU";
int count = 0;
for (int i = 0; i < sentence.Length; i++)
{
    if (exep.Contains(sentence[i]))
    {
        count++;
    }
}
Console.WriteLine($"Number of sentences: {count}");
