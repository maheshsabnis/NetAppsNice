// See https://aka.ms/new-console-template for more information
using CS_Parallel_Invoke;

Console.WriteLine("Parallel Reading from Multiple Files using Parallel.Invoke()");

string huntData = string.Empty;
string bondData = string.Empty;

/*Read files parallely*/

FilesReader filesReader = new FilesReader();
try
{

	Parallel.Invoke(() =>
	{
		huntData = filesReader.ReadHuntFile();
		bondData = filesReader.ReadBondFile();
	});

	
    Console.WriteLine($"Hunt = {huntData}");
    Console.WriteLine($"Bond = {bondData}");

}
catch (Exception ex)
{
    Console.WriteLine($"Exception Occurred {ex.Message}");

}

Console.ReadLine();
