using Create.API.Client;

var client = new CreateApiClient();

var response = await client.TextGenerator
        .GenerateSentenceAsync(1)
        .ConfigureAwait(false);

Console.WriteLine(response);
