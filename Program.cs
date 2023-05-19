class Program
{

    static void Main(string[] args)
    {
        string sub;
        do
        {
            Console.Write("Input DNA sequence: ");
            string inputdna = Console.ReadLine();

                if (IsValidSequence(inputdna))
                {
                    sub = "Do you want to replicate it ? (Y/N) : ";
                    Console.WriteLine("Current half DNA sequence : {0}", inputdna);
                    Console.Write(sub);

                    if (Inspect(sub)){
                    inputdna = ReplicateSeqeunce(inputdna);
                    Console.WriteLine("Replicated half DNA sequence : {0}", inputdna); }

                }else{Console.WriteLine("That half DNA sequence is invalid.");}

            sub = "Do you want to process another sequence ? (Y/N) : ";
                Console.Write(sub);

        } while (Inspect(sub));
    }

    static bool Inspect(string w)
    {
        while (true)
        {
            string text = Console.ReadLine();
            if (text == "Y")
            {
                return true;
            }
            if (text == "N")
            {
                return false;
            }
            Console.WriteLine("Please input Y or N.");
            Console.Write(w);
        }
    }

    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }

    static string ReplicateSeqeunce(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }
}
