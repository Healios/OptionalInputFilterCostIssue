var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGraphQLServer()
                .AddFiltering()
                .AddSorting()
                .ModifyPagingOptions(options =>
                {
                    options.DefaultPageSize = 50;
                    options.MaxPageSize = 100;
                    options.IncludeTotalCount = true;
                })
                .AddOptionalInputFilterCostIssueTypes();

var app = builder.Build();
app.MapGraphQL();
app.UseHttpsRedirection();
app.Run();
