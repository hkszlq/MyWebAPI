using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace MyTestWebAPI.Filter
{
    public class defaultstirngsettingFilter : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (schema==null)
            {
                return;
            }
            var myschema = schema;
            foreach (var item in myschema.Properties)
            {
                if ((item.Value.Type == "string") &&item.Value.Default==null)
                {
                    item.Value.Default =new OpenApiString("");
                } 
                if ((item.Key=="Pagesize")|| item.Key == "pagesize")
                {
                    item.Value.Default = new OpenApiInteger(10);            
                }
            }
        }
    }
}
