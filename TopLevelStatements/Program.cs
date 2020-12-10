using System;
using System.Threading.Tasks;

Console.WriteLine("Hello World!");

await DoSomethingAsync();

async Task<int> DoSomethingAsync()
{
    return await Task.FromResult(0);
}