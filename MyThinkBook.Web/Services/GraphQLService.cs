using GraphQL;
using GraphQL.Client.Abstractions;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.SystemTextJson;
using System.Net.Http;

namespace MyThinkBook.Web.Services;

public class HelloResponse
{
    public string Hello { get; set; } = string.Empty;
}

public class GraphQLService : IGraphQLService
{
    private readonly ILogger<GraphQLService> logger;
    private readonly GraphQLHttpClient graphQLClient;

    public GraphQLService(ILogger<GraphQLService> logger, HttpClient httpClient)
    {
        this.logger = logger;

        // using Microsoft.Net.Http.Headers;
        //this.httpClient.DefaultRequestHeaders.Add(HeaderNames.Accept, "application/vnd.github.v3+json");
        //this.httpClient.DefaultRequestHeaders.Add(HeaderNames.UserAgent, "HttpRequestsSample");

        var graphQLHttpClientOptions = new GraphQLHttpClientOptions
        {
            EndPoint = new Uri("http://localhost:31000/graphql")
        };

        graphQLClient = new GraphQLHttpClient(graphQLHttpClientOptions, new SystemTextJsonSerializer(), httpClient);
    }

    public async Task<HelloResponse> TestAsync()
    {
        var query = new GraphQLRequest()
        {
            Query = @"query {
  hello
}"
        };

        var response = await graphQLClient.SendQueryAsync<HelloResponse>(query);

        logger.LogInformation("GraphQL call returns {response}", response);
        return response.Data;

    }

    // https://graphql.org/code/#c-net
    // https://github.com/graphql-dotnet/graphql-dotnet
    // https://github.com/graphql-dotnet/graphql-client
    // https://graphql-dotnet.github.io/docs/getting-started/introduction/
    // https://graphql.org/learn/schema/#type-language
    // https://softchris.github.io/pages/dotnet-graphql.html#how-to-query
    // HotChoco/Strawberry
    // https://www.ezzylearning.net/tutorial/consuming-graphql-apis-in-asp-net-core
    // https://www.red-gate.com/simple-talk/development/dotnet-development/building-and-consuming-graphql-api-in-asp-net-core-5/


}
