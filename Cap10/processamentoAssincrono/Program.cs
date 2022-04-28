// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http;
using System.Threading.Tasks;

AccessTheWebAsync();

async Task<int> AccessTheWebAsync() {
	HttpClient client = new HttpClient(); 

	Task<string> getStringTask = client.GetStringAsync("http://msdn.microsoft.com");
	
	DoIndependentWork();

	string urlContents = await getStringTask;

	return urlContents.Length;

}

void DoIndependentWork()
{
	Console.WriteLine("Working . . . . . . \r\n");
}
